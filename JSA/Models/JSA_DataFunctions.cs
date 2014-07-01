using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq;
using System.Configuration;
using Safe_Task_Analysis;

namespace Safe_Task_Analysis.Models
{
    /* Here are done the queries to the database. 
     * To avoid a ridiculous loading time, we try to avoid making controls here :
     * Controls are meant to be done by the controller (here the functions in JSAController.cs)
     * Please don't overload the model with control queries, make sure the data coming in these functions are correct
     *
     * If you don't understand what i've done, google it
    */

    public class JSA_DataFunctions
    {
        private STA_DataDataContext dc;

        public JSA_DataFunctions()
        {
            dc = new STA_DataDataContext(ConfigurationManager.ConnectionStrings["AST_DBConnectionString"].ConnectionString);
        }

        // This function delete a JSA and all the foreigns keys linked to it
        public bool deleteJSA(int JSAid, out string ModifiedTasks, ref List<string> errors)
        {
            ModifiedTasks = "";
            if (!dc.JSAs.Any(t => t.IDJSA == JSAid))
            {
                errors.Add("Id does not exists, invalid JSAid");
                return false;
            }
            JSA currentJSA = dc.JSAs.Single(j => j.IDJSA == JSAid);
            dc.PreventiveMesure_Attrs.DeleteAllOnSubmit(dc.PreventiveMesure_Attrs.Where(j => j.PreventiveMesure.AssociatedRisk.Task.JSAid == JSAid));
            dc.PreventiveMesures.DeleteAllOnSubmit(dc.PreventiveMesures.Where(j => j.AssociatedRisk.Task.JSAid == JSAid));
            dc.AssociatedRisk_Attrs.DeleteAllOnSubmit(dc.AssociatedRisk_Attrs.Where(a => a.AssociatedRisk.Task.JSAid == JSAid));
            dc.AssociatedRisks.DeleteAllOnSubmit(dc.AssociatedRisks.Where(a => a.Task.JSAid == JSAid));
            dc.Task_Attrs.DeleteAllOnSubmit(dc.Task_Attrs.Where(t => t.Task.JSAid == JSAid));
            dc.Tasks.DeleteAllOnSubmit(dc.Tasks.Where(t => t.JSAid == JSAid));
            dc.JSA_Attrs.DeleteAllOnSubmit(dc.JSA_Attrs.Where(s => s.JSAid == JSAid));
            dc.JSAs.DeleteOnSubmit(currentJSA);
            dc.SubmitChanges();
            return true;
        }

        public JSA getJSA(int JSAid)
        {
            if (dc.JSAs.Any(s => s.IDJSA == JSAid))
                return dc.JSAs.Single(s => s.IDJSA == JSAid);
            else return null;
        }

        public List<JSA_Attr> getAllJSAs()
        {
            return dc.JSA_Attrs.OrderBy(l => l.JSAid).ToList();
        }

        public List<JSA_Attr> getAllTask(string word)
        {
            return dc.JSA_Attrs.Distinct().Where(l => l.TaskName.ToLower().Contains(word.ToLower()) == true).ToList();
        }

        public List<JSA_Attr> getTasksBranch(int id)
        {
            return dc.JSA_Attrs.Where(l => l.BranchID == id).ToList();
        }

        public List<JSA_Attr> getTasksRegion(int id)
        {
            return dc.JSA_Attrs.Distinct().Where(l => l.RegionID == id).ToList();
        }

        public List<JSA_Attr> getTasksOrganisation(int id)
        {
            return dc.JSA_Attrs.Distinct().Where(l => l.OrganisationID == id).ToList();
        }

        public List<JSA_Attr> getTasksEnv(int id)
        {
            return dc.JSA_Attrs.Distinct().Where(l => l.WorkEnvID == id).ToList();
        }

        public List<JSA_Attr> getTasksSupervisor(int id)
        {
            return dc.JSA_Attrs.Distinct().Where(l => l.SupervisorID == id).ToList();
        }

        public List<JSA_Attr> getAllTaskAuthor(string author)
        {
            return dc.JSA_Attrs.Distinct().Where(l => l.CreatedBy.ToLower().Contains(author.ToLower()) == true).ToList();
        }

        //
        public List<string> getAuthors()
        {
            return dc.JSA_Attrs.Distinct().Select(l => l.CreatedBy).OrderBy(item => item).ToList();
        }

        public Task getTask(int TaskID)
        {
            return dc.Tasks.Single(t => t.IdtAsk == TaskID);
        }

        public AssociatedRisk getAssRisk(int RiskID)
        {
            return dc.AssociatedRisks.Single(ar => ar.IdaSsRisk == RiskID);
        }

        public PreventiveMesure getPrevMes(int PrevMesID)
        {
            return dc.PreventiveMesures.Single(pm => pm.IDPreVMeSure == PrevMesID);
        }

        public List<Region> getRegions(int lang)
        {
            if (lang == 0)
            return dc.Regions.OrderBy(item => item.NameEn).ToList();
             else
                return dc.Regions.OrderBy(item => item.NameFr).ToList();
        }

        public List<Branch> getBranch(int lang)
        {
            if (lang == 0)
                return dc.Branchs.OrderBy(item => item.NameEn).ToList();
            else
                return dc.Branchs.OrderBy(item => item.NameFr).ToList();
        }

        public List<WorkEnvironment> getWorkEnvironments(int lang)
        {
            if (lang == 0)
                return dc.WorkEnvironments.OrderBy(item => item.NameEn).ToList();
            else
                return dc.WorkEnvironments.OrderBy(item => item.NameFr).ToList();

        }

        public List<Organisation> getOrganisations(int RegionID, int lang)
        {
            if (lang == 0)
            {
                if (RegionID == 0)
                    return dc.Organisations.OrderBy(item => item.NameEn).ToList();
                return dc.Organisations.Where(s => s.RegionID == RegionID && s.Active == true).OrderBy(item => item.NameEn).ToList();
            }
            else
            {
                if (RegionID == 0)
                    return dc.Organisations.OrderBy(item => item.NameFr).ToList();
                return dc.Organisations.Where(s => s.RegionID == RegionID && s.Active == true).OrderBy(item => item.NameFr).ToList();
            }
        }

        public List<Supervisor> getSupervisors(int OrganisationID)
        {
            if (OrganisationID == 0)
            {
                List<Supervisor> list = dc.Supervisors.OrderBy(item => item.Description).ToList();
                list.Remove(list[0]);
                return list;
            }
            return dc.Supervisors.Where(t => t.OrganisationID == OrganisationID).OrderBy(item => item.Description).ToList();
        }

        public bool savePath(string path, int jsaid)
        {
            try
            {
                JSA_Attr attr = dc.JSA_Attrs.Single(i => i.JSAid == jsaid);
                attr.AssociatedDoc = path;
                attr.ModifiedBy = GetUserName();
                attr.ModifiedDate = DateTime.Now;
                dc.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //
        public int saveJSAHeader(int BranchID, int TaskID, int RegionID, int OrganisationID, int EnvirID, int SupervisorID, string TaskName, string EditorName, ref List<string> errors)
        {
            JSA jsa;
            JSA_Attr attr = new JSA_Attr();
            DateTime dt = DateTime.Now;
            if (TaskID > 0)
                if (!dc.JSAs.Any(sta => sta.IDJSA == TaskID))
                    errors.Add("JSA does not exists, invalid TaskID");
            if (errors.Count > 0)
            {
                return -1;
            }
            if (!dc.JSAs.Any(j => j.IDJSA == TaskID))
            {
                jsa = new JSA();
                dc.JSAs.InsertOnSubmit(jsa);
                attr.CurrentSaveStage = 1;
                attr.CreatedBy = GetUserName();
                attr.CreationDate = dt;
                jsa.JSA_Attr.Add(attr);
            }
            else
            {
                jsa = dc.JSAs.Single(sta => sta.IDJSA == TaskID);
                attr = jsa.JSA_Attr.Last();
            }
            attr.ModifiedBy = GetUserName();
            attr.ModifiedDate = dt;
            attr.Active = true;
            attr.BranchID = BranchID;
            attr.RegionID = RegionID;
            attr.OrganisationID = OrganisationID;
            attr.WorkEnvID = EnvirID;
            attr.SupervisorID = SupervisorID;
            attr.TaskName = TaskName;

            dc.SubmitChanges();
            return jsa.IDJSA;
        }

        public Task saveJSATask(int JSAid, string desc, int OrderNo, ref List<string> errors)
        {
            Task task = new Task();
            Task_Attr attr = new Task_Attr();
            attr.Active = true;
            attr.Description = desc;
            attr.OrderNo = OrderNo;
            task.Task_Attr.Add(attr);
            JSA jsa = dc.JSAs.Single(j => j.IDJSA == JSAid);
            jsa.JSA_Attr.Last().ModifiedBy = GetUserName();
            jsa.JSA_Attr.Last().ModifiedDate = DateTime.Now;
            jsa.Task.Add(task);
            dc.SubmitChanges();
            return task;
        }

        public AssociatedRisk saveJSARisk(int TaskID, string Desc, ref List<string> errors)
        {
            AssociatedRisk ar = new AssociatedRisk();
            AssociatedRisk_Attr attr = new AssociatedRisk_Attr();
            Task task;
            task = dc.Tasks.Single(t => t.IdtAsk == TaskID);
            attr.Active = true;
            attr.DescriptionRisk = Desc;
            JSA jsa = task.JSA;
            jsa.JSA_Attr.Last().ModifiedBy = GetUserName();
            jsa.JSA_Attr.Last().ModifiedDate = DateTime.Now;
            ar.AssociatedRisk_Attr.Add(attr);
            task.AssociatedRisk.Add(ar);
            dc.SubmitChanges();
            return ar;
        }

        public PreventiveMesure saveJSAPrevMes(int AssRiskID, string desc, ref List<string> errors)
        {
            PreventiveMesure pm = new PreventiveMesure();
            PreventiveMesure_Attr attr = new PreventiveMesure_Attr();
            AssociatedRisk ar;
            if (desc.Length < 1 || desc.Length > 500)
            {
                errors.Add("Preventive mesure description must be at least 1 characters long and at most 500");
                return null;
            }
            ar = dc.AssociatedRisks.Single(a => a.IdaSsRisk == AssRiskID);
            attr.Active = true;
            attr.Description = desc;
            JSA jsa = ar.Task.JSA;
            jsa.JSA_Attr.Last().ModifiedBy = GetUserName();
            jsa.JSA_Attr.Last().ModifiedDate = DateTime.Now;
            pm.PreventiveMesure_Attr.Add(attr);
            ar.PreventiveMesure.Add(pm);
            dc.SubmitChanges();
            return pm;
        }

        public Task updateJSATask(int TaskID, string TaskDesc, ref List<string> errors)
        {
            Task task;
            Task_Attr attr = new Task_Attr();
            task = dc.Tasks.Single(t => t.IdtAsk == TaskID);
            attr = task.Task_Attr.Last();
            attr.Active = true;
            attr.Description = TaskDesc;
            task.JSA.JSA_Attr.Last().ModifiedBy = GetUserName();
            task.JSA.JSA_Attr.Last().ModifiedDate = DateTime.Now;
            dc.SubmitChanges();
            return task;
        }

        public List<int> deleteJSATask(int TaskID, out string ModifiedTasks, ref List<string> errors)
        {
            ModifiedTasks = "";
            Task task = dc.Tasks.Single(t => t.IdtAsk == TaskID);
            List<int> temp = new List<int>();
            temp.Add(task.Task_Attr.Last().OrderNo);
            temp.Add(task.JSAid);
            dc.PreventiveMesure_Attrs.DeleteAllOnSubmit(dc.PreventiveMesure_Attrs.Where(j => j.PreventiveMesure.AssociatedRisk.TaskID == TaskID));
            dc.PreventiveMesures.DeleteAllOnSubmit(dc.PreventiveMesures.Where(j => j.AssociatedRisk.TaskID == TaskID));
            dc.AssociatedRisk_Attrs.DeleteAllOnSubmit(dc.AssociatedRisk_Attrs.Where(a => a.AssociatedRisk.TaskID == TaskID));
            dc.AssociatedRisks.DeleteAllOnSubmit(dc.AssociatedRisks.Where(a => a.TaskID == TaskID));
            dc.Task_Attrs.DeleteAllOnSubmit(dc.Task_Attrs.Where(t => t.TaskID == TaskID));
            dc.Tasks.DeleteOnSubmit(task);
            dc.SubmitChanges();

            return temp;
        }

        public void reorderTable(int order, int jsaid)
        {
            List<Task> list = new List<Task>();
            List<String> errors = new List<String>();
            List<Task> listsorted = new List<Task>();
            Task task = new Task();
            int temp = 0;
            if (dc.Tasks.Any(t => t.Task_Attr.Last().OrderNo > order && t.JSAid == jsaid))
            {
                list = dc.Tasks.Where(t => t.Task_Attr.Last().OrderNo >= order && t.JSAid == jsaid && t.Task_Attr.Last().Active == true).ToList();
                listsorted = list.OrderBy(item => item.Task_Attr.Last().OrderNo).ToList();
                for (int i = 0; i < listsorted.Count(); ++i)
                {
                    temp = listsorted[i].Task_Attr.Last().OrderNo - 1;
                    listsorted[i].Task_Attr.Last().OrderNo = temp;
                }
                dc.SubmitChanges();
            }
        }

        public AssociatedRisk updateJSARisk(int AssRiskID, string Riskdesc, ref List<string> errors)
        {
            AssociatedRisk risk = dc.AssociatedRisks.Single(ar => ar.IdaSsRisk == AssRiskID);
            AssociatedRisk_Attr attr = risk.AssociatedRisk_Attr.Last();
            attr.Active = true;
            attr.DescriptionRisk = Riskdesc;
            risk.Task.JSA.JSA_Attr.Last().ModifiedBy = GetUserName();
            risk.Task.JSA.JSA_Attr.Last().ModifiedDate = DateTime.Now;
            dc.SubmitChanges();
            return risk;
        }

        public PreventiveMesure updateJSAPrevMes(int PrevMesID, string PrevMesDesc, ref List<string> errors)
        {
            PreventiveMesure pm = dc.PreventiveMesures.Single(p => p.IDPreVMeSure == PrevMesID);
            PreventiveMesure_Attr attr = pm.PreventiveMesure_Attr.Last();
            attr.Active = true;
            attr.Description = PrevMesDesc;
            pm.AssociatedRisk.Task.JSA.JSA_Attr.Last().ModifiedBy = GetUserName();
            pm.AssociatedRisk.Task.JSA.JSA_Attr.Last().ModifiedDate = DateTime.Now;
            dc.SubmitChanges();
            return pm;
        }

        public AssociatedRisk deleteJSARisk(int AssRiskID, ref List<string> errors)
        {
            AssociatedRisk risk = dc.AssociatedRisks.Single(ar => ar.IdaSsRisk == AssRiskID);
            dc.PreventiveMesure_Attrs.DeleteAllOnSubmit(dc.PreventiveMesure_Attrs.Where(j => j.PreventiveMesure.AssociatedRisk.IdaSsRisk == AssRiskID));
            dc.PreventiveMesures.DeleteAllOnSubmit(dc.PreventiveMesures.Where(j => j.AssociatedRisk.IdaSsRisk == AssRiskID));
            dc.AssociatedRisk_Attrs.DeleteAllOnSubmit(dc.AssociatedRisk_Attrs.Where(a => a.AssRiskID == AssRiskID));
            dc.AssociatedRisks.DeleteOnSubmit(risk);
            dc.SubmitChanges();
            return risk;
        }

        public PreventiveMesure deleteJSAPrevMes(int PrevMesID, ref List<string> errors)
        {
            PreventiveMesure mesure = dc.PreventiveMesures.Single(pm => pm.IDPreVMeSure == PrevMesID);
            dc.PreventiveMesure_Attrs.DeleteAllOnSubmit(dc.PreventiveMesure_Attrs.Where(j => j.PreVMeSureID == PrevMesID));
            dc.PreventiveMesures.DeleteOnSubmit(mesure);
            dc.SubmitChanges();
            return mesure;
        }

        public void updateSaveStage(int JSAid, int stage)
        {
            JSA temp = dc.JSAs.Single(jsa => jsa.IDJSA == JSAid);
            if (stage > temp.JSA_Attr.Last().CurrentSaveStage)
            {
                temp.JSA_Attr.Last().CurrentSaveStage = stage <= 3 ? stage : 3;
                dc.SubmitChanges();
            }
        }

        public bool saveJSASafetyEquip(int JSAid, bool Helmet, bool Goggles, bool HearPlugs, bool Gloves, bool Boots, bool BreathingMask, bool Blouse, bool Face, bool Headcover, bool Item, ref List<string> errors)
        {
            JSA jsa = dc.JSAs.Single(j => j.IDJSA == JSAid);
            JSA_Attr attr = jsa.JSA_Attr.Last();
            attr.Active = true;
            attr.Helmet = Helmet;
            attr.Goggles = Goggles;
            attr.HearPlugs = HearPlugs;
            attr.Gloves = Gloves;
            attr.Boots = Boots;
            attr.BreathingMask = BreathingMask;
            attr.Blouse = Blouse;
            attr.Face = Face;
            attr.Headcover = Headcover;
            attr.Item = Item;
            attr.CurrentSaveStage = 3;
            attr.ModifiedBy = GetUserName();
            attr.ModifiedDate = DateTime.Now;
            attr.ModifiedDate = attr.ModifiedDate;
            attr.ModifiedBy = attr.ModifiedBy;
            dc.SubmitChanges();
            return true;
        }

        public Task moveTask(string movement, int TaskID, ref List<string> errors)
        {
            Task CurrentTask = dc.Tasks.Single(t => t.IdtAsk == TaskID);
            Task singleTask = new Task();
            CurrentTask.JSA.JSA_Attr.Last().ModifiedDate = DateTime.Now;
            CurrentTask.JSA.JSA_Attr.Last().ModifiedBy = GetUserName();
            if (movement.Equals("Up"))
            {
                if (CurrentTask.JSA.Task.Any(t => t.Task_Attr.Last().OrderNo == (CurrentTask.Task_Attr.Last().OrderNo - 1)))
                    singleTask = CurrentTask.JSA.Task.Single(t => t.Task_Attr.Last().OrderNo == (CurrentTask.Task_Attr.Last().OrderNo - 1));
            }
            else if (movement.Equals("Down"))
            {
                if (CurrentTask.JSA.Task.Any(t => t.Task_Attr.Last().OrderNo == (CurrentTask.Task_Attr.Last().OrderNo + 1)))
                    singleTask = CurrentTask.JSA.Task.Single(t => t.Task_Attr.Last().OrderNo == (CurrentTask.Task_Attr.Last().OrderNo + 1));
            }
            Task_Attr old = CurrentTask.Task_Attr.Last();
            int orderNo = old.OrderNo;
            Task_Attr attr = singleTask.Task_Attr.Last();
            old.OrderNo = attr.OrderNo;
            attr.OrderNo = orderNo;
            dc.SubmitChanges();
            return CurrentTask;
        }

        public List<string> getAdmins()
        {
            List<string> a = dc.Admins.Select(r => r.Login).OrderBy(item => item).ToList();
            int j = a.IndexOf("mehrjc");
            a.RemoveAt(j);
            int i = a.IndexOf(GetUserName().ToLower());
            if (i != -1)
                a.RemoveAt(i);
            return a;
        }

        public bool deleteAdmin(string item)
        {
            if (dc.Admins.Any(i => i.Login.Contains(item.ToLower())))
            {
                try
                {
                    dc.Admins.DeleteOnSubmit(dc.Admins.Single(i => i.Login.Contains(item)));
                    dc.SubmitChanges();
                    return true;
                }
                catch { }
            }
            return false;
        }

        public bool deleteRegion(int item)
        {
            if (dc.Regions.Any(i => i.IdrEgion == item))
            {
                try
                {
                    dc.Regions.DeleteOnSubmit(dc.Regions.Single(i => i.IdrEgion == item));
                    dc.SubmitChanges();
                    return true;
                }
                catch { }
            }
            return false;
        }

        public bool deleteBranch(int item)
        {
            if (dc.Branchs.Any(i => i.IdbRanch == item))
            {
                try
                {
                    dc.Branchs.DeleteOnSubmit(dc.Branchs.Single(i => i.IdbRanch == item));
                    dc.SubmitChanges();
                    return true;
                }
                catch { }
            }
            return false;
        }

        public bool deleteOrganisation(int item)
        {
            if (dc.Organisations.Any(i => i.IdOrganisation == item))
            {
                try
                {
                    dc.Organisations.DeleteOnSubmit(dc.Organisations.Single(i => i.IdOrganisation == item));
                    dc.SubmitChanges();
                    return true;
                }
                catch { }
            }
            return false;
        }

        public bool deleteEnv(int item)
        {
            if (dc.WorkEnvironments.Any(i => i.IdwOrkEnv == item))
            {
                try
                {
                    dc.WorkEnvironments.DeleteOnSubmit(dc.WorkEnvironments.Single(i => i.IdwOrkEnv == item));
                    dc.SubmitChanges();
                    return true;
                }
                catch { }
            }
            return false;
        }

        public bool deleteSupervisor(int item)
        {
            if (dc.Supervisors.Any(i => i.IdsUpervisor == item))
            {
                try
                {
                    dc.Supervisors.DeleteOnSubmit(dc.Supervisors.Single(i => i.IdsUpervisor == item));
                    dc.SubmitChanges();
                    return true;
                }
                catch { }
            }
            return false;
        }

        public bool addAdmin(string item)
        {
            Admin admin = new Admin();
            admin.Login = item.ToLower();
            if (!dc.Admins.Any(i => i.Login.Contains(item.ToLower())))
            {
                try
                {
                    dc.Admins.InsertOnSubmit(admin);
                    dc.SubmitChanges();
                    return true;
                }
                catch { }
            }
            return false;
        }

        public bool addRegion(string NameFr, string NameEng)
        {
            Region region = new Region();

            if (!dc.Regions.Any(i => i.NameEn.ToLower().Contains(NameEng) || i.NameEn.ToLower().Contains(NameFr)))
            {
                try
                {
                    region.NameEn = NameEng;
                    region.NameFr = NameFr;
                    region.Active = true;
                    dc.Regions.InsertOnSubmit(region);
                    dc.SubmitChanges();
                    return true;
                }
                catch { }
            }
            return false;
        }

        public bool addOrganisation(string NameFr, string NameEng, int idRegion)
        {
            Organisation Organisation = new Organisation();
            if (!dc.Organisations.Any(i => i.NameEn.ToLower().Contains(NameEng.ToLower()) || i.NameFr.ToLower().Contains(NameFr.ToLower())))
            {
                try
                {
                    Organisation.NameEn = NameEng;
                    Organisation.NameFr = NameFr;
                    Organisation.Active = true;
                    Organisation.RegionID = idRegion;
                    dc.Organisations.InsertOnSubmit(Organisation);
                    dc.SubmitChanges();
                    return true;
                }
                catch { }
            }
            return false;
        }

        public bool addBranch(string NameFr, string NameEng)
        {
            Branch env = new Branch();
            if (!dc.Branchs.Any(i => i.NameEn.ToLower().Contains(NameEng.ToLower()) || i.NameFr.ToLower().Contains(NameFr.ToLower())))
            {
                try
                {
                    env.NameEn = NameEng;
                    env.NameFr = NameFr;
                    dc.Branchs.InsertOnSubmit(env);
                    dc.SubmitChanges();
                    return true;
                }
                catch { }
            }
            return false;
        }

        public bool addEnv(string NameFr, string NameEng)
        {
            WorkEnvironment env = new WorkEnvironment();
            if (!dc.WorkEnvironments.Any(i => i.NameEn.ToLower().Contains(NameEng.ToLower()) || i.NameFr.ToLower().Contains(NameFr.ToLower())))
            {
                try
                {
                    env.Active = true;
                    env.NameEn = NameEng;
                    env.NameFr = NameFr;
                    dc.WorkEnvironments.InsertOnSubmit(env);
                    dc.SubmitChanges();
                    return true;
                }
                catch { }
            }
            return false;
        }

        public bool deleteAssDoc(int taskid)
        {
            try
            {
                JSA_Attr attr = dc.JSA_Attrs.Single(i => i.JSAid == taskid);
                attr.AssociatedDoc = null;
                dc.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool addSupervisor(string nameSupervisor, int idOrganisation)
        {
            Supervisor Supervisor = new Supervisor();
            if (!dc.Supervisors.Any(i => i.Description.ToLower().Contains(nameSupervisor.ToLower())))
            {
                try
                {
                    Supervisor.Active = true;
                    Supervisor.OrganisationID = idOrganisation;
                    Supervisor.Description = nameSupervisor;
                    dc.Supervisors.InsertOnSubmit(Supervisor);
                    dc.SubmitChanges();
                    return true;
                }
                catch { }
            }
            return false;
        }

        public bool authAdmin()
        {
            List<Admin> listadmin = new List<Admin>();
            listadmin = dc.Admins.ToList();
            foreach (Admin admin in listadmin)
            {
                if (GetUserName().ToLower().Equals(admin.Login.ToLower()))
                    return true;
            }
            return false;
        }

        public List<List<JSA_Attr>> getStatistics()
        {
            List<List<JSA_Attr>> listStat = new List<List<JSA_Attr>>();
            int nbreg = dc.Regions.Count();
            int nbbranch = dc.Branchs.Count();
            for (int i = 0; i < nbreg; ++i)
            {
                listStat.Add(dc.JSA_Attrs.Where(l => l.RegionID == i).ToList());
            }
            for (int i = 0; i < nbbranch; ++i)
            {
                listStat.Add(dc.JSA_Attrs.Where(l => l.BranchID == i).ToList());
            }
            return listStat;
        }

        public string getDoc(int IDjsa)
        {
            JSA_Attr attr = dc.JSA_Attrs.Single(i => i.JSAid == IDjsa);
            if (attr.AssociatedDoc != "")
                return attr.AssociatedDoc;
            return "";
        }

        public string getInfoGen(int ID)
        {
            JSA_Attr attr = dc.JSA_Attrs.Single(i => i.JSAid == ID);
            if (attr.InfoGen == null)
            {
                attr.InfoGen = "";
                dc.SubmitChanges();
            }
            return attr.InfoGen;
        }

        public bool saveInfGen(string InfoGen, int JSAID)
        {
            JSA_Attr attr = dc.JSA_Attrs.Single(i => i.JSAid == JSAID);
            try
            {
                attr.InfoGen = InfoGen;
                attr.ModifiedBy = GetUserName();
                attr.ModifiedDate = DateTime.Now;
                dc.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool modifySupervisor(int idSupervisor, string newName)
        {
            try
            {
                Supervisor supp = dc.Supervisors.Single(i => i.IdsUpervisor == idSupervisor);
                supp.Description = newName;
                dc.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool modifyEnv(int idEnv, string nameFR, string nameEN)
        {
            try
            {
                WorkEnvironment env = dc.WorkEnvironments.Single(i => i.IdwOrkEnv == idEnv);
                env.NameFr = nameFR;
                env.NameEn = nameEN;
                dc.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool modifyOrganisation(int idOrganisation, string nameFR, string nameEN)
        {
            try
            {
                Organisation org = dc.Organisations.Single(i => i.IdOrganisation == idOrganisation);
                org.NameEn = nameEN;
                org.NameFr = nameFR;
                dc.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool modifyRegion(int idRegion, string nameFR, string nameEN)
        {
            try
            {
                Region reg = dc.Regions.Single(i => i.IdrEgion == idRegion);
                reg.NameEn = nameEN;
                reg.NameFr = nameFR;
                dc.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool modifyBranch(int idBranch, string nameFR, string nameEN)
        {
            try
            {
                Branch branch = dc.Branchs.Single(i => i.IdbRanch == idBranch);
                branch.NameEn = nameEN;
                branch.NameFr = nameFR;
                dc.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public int copyJsaAttr(int oldjsaid)
        {
            try
            {
                JSA oldJSA = dc.JSAs.Single(i => i.IDJSA == oldjsaid); 
                JSA jsa = new JSA();
                JSA_Attr attr = new JSA_Attr();
                dc.JSAs.InsertOnSubmit(jsa);
                attr.CurrentSaveStage = 2;
                attr.CreatedBy = GetUserName();
                attr.CreationDate = DateTime.Now;
                attr.ModifiedBy = GetUserName();
                attr.ModifiedDate = DateTime.Now;
                attr.InfoGen = oldJSA.JSA_Attr.Last().InfoGen;
                attr.Active = true;
                attr.BranchID = 16;
                attr.RegionID = 15;
                attr.OrganisationID = 53;
                attr.WorkEnvID = 10;
                attr.SupervisorID = 1;
                attr.TaskName = oldJSA.JSA_Attr.Last().TaskName;
                attr.AssociatedDoc = oldJSA.JSA_Attr.Last().AssociatedDoc;
                jsa.JSA_Attr.Add(attr);

                List<Task> listTasks = dc.Tasks.Where(i => i.JSAid == oldjsaid).ToList();
                foreach (Task t in listTasks)
                {
                    Task task = new Task();
                    Task_Attr tAttr = new Task_Attr();
                    task.JSAid = jsa.IDJSA;
                    tAttr.Active = true;
                    tAttr.TaskID = task.IdtAsk;
                    tAttr.Description = t.Task_Attr.Last().Description;
                    tAttr.OrderNo = t.Task_Attr.Last().OrderNo;
                    task.Task_Attr.Add(tAttr);
                    jsa.Task.Add(task);

                    List<AssociatedRisk> listRisks = dc.AssociatedRisks.Where(i => i.TaskID == t.IdtAsk).ToList();
                    foreach (AssociatedRisk r in listRisks)
                    {
                        AssociatedRisk ar = new AssociatedRisk();
                        ar.TaskID = task.IdtAsk;
                        AssociatedRisk_Attr arAttr = new AssociatedRisk_Attr();
                        arAttr.AssRiskID = ar.IdaSsRisk;
                        arAttr.Active = true;
                        arAttr.DescriptionRisk = r.AssociatedRisk_Attr.Last().DescriptionRisk;
                        ar.AssociatedRisk_Attr.Add(arAttr);
                        task.AssociatedRisk.Add(ar);

                        List<PreventiveMesure> listPM = dc.PreventiveMesures.Where(i => i.RiskID == r.IdaSsRisk).ToList();
                        foreach (PreventiveMesure pm in listPM)
                        {
                            PreventiveMesure prevmes = new PreventiveMesure();
                            prevmes.RiskID = ar.IdaSsRisk;
                            PreventiveMesure_Attr pmattr = new PreventiveMesure_Attr();
                            pmattr.Description = pm.PreventiveMesure_Attr.Last().Description;
                            pmattr.Active = true;
                            prevmes.PreventiveMesure_Attr.Add(pmattr);
                            ar.PreventiveMesure.Add(prevmes);
                        }
                    }
                }
                dc.SubmitChanges();
                return jsa.IDJSA;
            }
            catch
            {
                return 0;
            }
        }

        public string countJSA()
        {
            return dc.JSAs.Count().ToString();
        }

        public static String GetUserName()
        {
            String s = HttpContext.Current.User.Identity.Name.ToString();
            if (s.IndexOf("\\") > 0)
                s = s.Substring(s.LastIndexOf("\\") + 1);
            return s;
        }

    }
}