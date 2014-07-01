using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Compilation;
using System.Globalization;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Safe_Task_Analysis.Controllers
{

    /*
     * These functions are named explicitly, if you understand algorithm and MVC logic it should be okay
     * DDM = Drop Down Menu
    */

    public class JSAController : BaseController
    {
        protected Safe_Task_Analysis.Models.JSA_DataFunctions df = new Safe_Task_Analysis.Models.JSA_DataFunctions();

        //Return a view of a new analysis if the url does not contain a JSA ID - Otherwise displays the analysis
        public ActionResult Index(int JSA_ID = 0)
        {
            Safe_Task_Analysis.Models.JSA temp = null;
            if (JSA_ID > 0)
                temp = df.getJSA(JSA_ID);
            return View(temp);
        }

        //Displays the Research page
        public ActionResult Search(int JSA_ID = 0)
        {
            Safe_Task_Analysis.Models.JSA temp = null;
            return View(temp);
        }

        //Displays the Tutorial page
        public ActionResult Tutorial(int JSA_ID = 0)
        {
            Safe_Task_Analysis.Models.JSA tuto = null;
            return View(tuto);
        }

        public ActionResult Admin(int JSA_ID = 0)
        {
            Safe_Task_Analysis.Models.JSA admin = null;
            if (df.authAdmin())
                return View(admin);
            else
            {
                Response.Write(@"<script language='javascript'>alert('Access denied');</script>");
                return View(@Url.Content("/JSA/Views/Home/Index2.cshtml"));
            }
        }

        public string isAdmin()
        {
            if (df.authAdmin())
                return "true";
            else
                return "false";
        }

        public string deleteAdmin(string nameAdmin)
        {
            string s = "Task failed !";
            if (df.authAdmin())
            {
                if (df.deleteAdmin(nameAdmin))
                    s = "Success !";
            }
            else
                s = "You are not administrator";
            return s;
        }

        public string deleteRegion(int idRegion)
        {
            string s = "Task failed !";
            if (df.authAdmin())
            {
                if (df.deleteRegion(idRegion))
                    s = "Success !";
            }
            else
                s = "You are not administrator";
            return s;
        }

        public string deleteBranch(int idBranch)
        {
            string s = "Task failed !";
            if (df.authAdmin())
            {
                if (df.deleteBranch(idBranch))
                    s = "Success !";
            }
            else
                s = "You are not administrator";
            return s;
        }

        public string deleteOrganisation(int idOrganisation)
        {
            string s = "Task failed !";
            if (df.authAdmin())
            {
                if (df.deleteOrganisation(idOrganisation))
                    s = "Success !";
            }
            else
                s = "You are not administrator";
            return s;
        }

        public string deleteEnv(int idEnv)
        {
            string s = "Task failed !";
            if (df.authAdmin())
            {
                if (df.deleteEnv(idEnv))
                    s = "Success !";
            }
            else
                s = "You are not administrator";
            return s;
        }

        public string deleteSupervisor(int idSupervisor)
        {
            string s = "Task failed !";
            if (df.authAdmin())
            {
                if (df.deleteSupervisor(idSupervisor))
                    s = "Success !";
            }
            else
                s = "You are not administrator";
            return s;
        }

        public int copyJsaAttr(int ID)
        {
            return df.copyJsaAttr(ID);
        }

        public string getInfoGen(int ID)
        {
            return df.getInfoGen(ID);
        }

        public string saveInfGen(string InfoGen, int JSAID)
        {
            string s = "Task failed !";
            if (df.saveInfGen(InfoGen, JSAID))
                s = "Success !";
            return s;
        }

        public string addAdmin(string nameAdmin)
        {
            string s = "Task failed !";
            if (df.authAdmin())
            {
                if (df.addAdmin(nameAdmin))
                    s = "Success !";
            }
            else
                s = "You are not administrator";
            return s;
        }

        public string addRegion(string nameFR, string nameEng)
        {
            string s = "Task failed !";
            if (df.authAdmin())
            {
                if (df.addRegion(nameFR, nameEng))
                    s = "Success !";
            }
            else
                s = "You are not administrator";
            return s;
        }

        public string addOrganisation(string nameFR, string nameEng, string nameRegion)
        {
            string s = "Task failed !";
            int i = Convert.ToInt16(nameRegion);
            if (df.authAdmin())
            {
                if (df.addOrganisation(nameFR, nameEng, i))
                    s = "Success !";
            }
            else
                s = "You are not administrator";
            return s;
        }

        public string addEnv(string nameFR, string nameEng)
        {
            string s = "Task failed !";
            if (df.authAdmin())
            {
                if (df.addEnv(nameFR, nameEng))
                    s = "Success !";
            }
            else
                s = "You are not administrator";
            return s;
        }

        public string addBranch(string nameFR, string nameEng)
        {
            string s = "Task failed !";
            if (df.authAdmin())
            {
                if (df.addBranch(nameFR, nameEng))
                    s = "Success !";
            }
            else
                s = "You are not administrator";
            return s;
        }

        public string addSupervisor(string nameSupervisor, int idOrganisation)
        {
            string s = "Task failed !";
            if (df.authAdmin())
            {
                if (df.addSupervisor(nameSupervisor, idOrganisation))
                    s = "Success !";
            }
            else
                s = "You are not administrator";
            return s;
        }

        //Delete a JSA (via function deleteJSA)
        public string deleteJSA(int JSA_ID)
        {
            string ModifiedTasks = "";
            List<string> errors = new List<string>();
            df.deleteJSA(JSA_ID, out ModifiedTasks, ref errors);
            return ModifiedTasks;
        }

        //Return a DDM from a query to the database (via function getAllTask) containing the list where the keyword appears
        public PartialViewResult getTasks(string word)
        {
            List<Safe_Task_Analysis.Models.JSA_Attr> temp;
            temp = df.getAllTask(word);
            return PartialView("_SearchResults", temp);
        }

        public PartialViewResult getAllJSAs()
        {
            List<Safe_Task_Analysis.Models.JSA_Attr> temp;
            temp = df.getAllJSAs();
            return PartialView("_SearchResults", temp);
        }

        //Return a DDM from a query to the database (via function getAllTaskAuthor) containing the title of analysis made by author 
        public PartialViewResult getAuthors()
        {
            List<SelectListItem> temp;
            temp = df.getAuthors().Select(r => new SelectListItem { Text = r, Value = r, Selected = false }).ToList();
            temp.Insert(0, new SelectListItem { Text = "--- " + Resources.Global.JSAIndexChooseAuthor + " ---", Value = "0", Selected = true });
            ViewBag.OnchangeCount = 0;
            ViewBag.CboName = "authorAjax";
            ViewBag.Disabled = "false";
            return PartialView("_DynamicCombo", temp);
        }

        public PartialViewResult getAdmins()
        {
            List<SelectListItem> temp;
            temp = df.getAdmins().Select(r => new SelectListItem { Text = r, Value = r, Selected = false }).ToList();
            temp.Insert(0, new SelectListItem { Text = "--- " + Resources.Global.JSAIndexChooseAdmin + " ---", Value = "0", Selected = true });
            ViewBag.OnchangeCount = 0;
            ViewBag.CboName = "adminAjax";
            ViewBag.Disabled = "false";
            return PartialView("_DynamicCombo", temp);
        }

        public PartialViewResult getTasksAuthor(string author)
        {
            List<Safe_Task_Analysis.Models.JSA_Attr> temp;
            temp = df.getAllTaskAuthor(author);
            return PartialView("_SearchResults", temp);
        }

        public PartialViewResult getTasksBranch(int branch)
        {
            List<Safe_Task_Analysis.Models.JSA_Attr> temp;
            temp = df.getTasksBranch(branch);
            return PartialView("_SearchResults", temp);
        }

        public PartialViewResult getTasksRegion(int region)
        {
            List<Safe_Task_Analysis.Models.JSA_Attr> temp;
            temp = df.getTasksRegion(region);
            return PartialView("_SearchResults", temp);
        }

        public PartialViewResult getTasksOrganisation(int organisation)
        {
            List<Safe_Task_Analysis.Models.JSA_Attr> temp;
            temp = df.getTasksOrganisation(organisation);
            return PartialView("_SearchResults", temp);
        }

        public PartialViewResult getTasksEnv(int env)
        {
            List<Safe_Task_Analysis.Models.JSA_Attr> temp;
            temp = df.getTasksEnv(env);
            return PartialView("_SearchResults", temp);
        }

        public PartialViewResult getTasksSupervisor(int namesupervisor)
        {
            List<Safe_Task_Analysis.Models.JSA_Attr> temp;
            temp = df.getTasksSupervisor(namesupervisor);
            return PartialView("_SearchResults", temp);
        }

        //Return a DDM from a query to the database (via function getRegions) different within the current language 
        public PartialViewResult getRegions(string lang, string current = "0", string disabled = "false")
        {
            List<SelectListItem> temp;
            int iCurrent;
            int.TryParse(current, out iCurrent);
            if (current_lang == 0)
                temp = df.getRegions(current_lang).Select(r => new SelectListItem { Text = r.NameEn, Value = r.IdrEgion.ToString(), Selected = r.IdrEgion == iCurrent }).ToList();
            else if (current_lang == 1)
                temp = df.getRegions(current_lang).Select(r => new SelectListItem { Text = r.NameFr, Value = r.IdrEgion.ToString(), Selected = r.IdrEgion == iCurrent }).ToList();
            else
                temp = df.getRegions(current_lang).Select(r => new SelectListItem { Text = r.NameEn, Value = r.IdrEgion.ToString(), Selected = r.IdrEgion == iCurrent }).ToList();
            ViewBag.OnchangeCount = 1;
            temp.Insert(0, new SelectListItem { Text = "--- " + Resources.Global.JSAIndexChooseRegion + " ---", Value = "0", Selected = 0 == iCurrent });
            ViewBag.DivName = "OrganisationDiv";
            ViewBag.CboName = "SelectRegion";
            ViewBag.FuncName = "getOrganisationByRegion";
            ViewBag.VarName = "RegionID";
            ViewBag.Disabled = disabled;
            return PartialView("_DynamicCombo", temp);
        }

        public PartialViewResult getOrganisationByRegion(string RegionID, string lang, string current = "0", string disabled = "false")
        {
            int i = int.Parse(RegionID);
            int iCurrent;
            int.TryParse(current, out iCurrent);
            List<SelectListItem> temp;
            if (current_lang == 0)
                temp = df.getOrganisations(i, current_lang).Select(s => new SelectListItem { Text = s.NameEn, Value = s.IdOrganisation.ToString(), Selected = s.IdOrganisation == iCurrent }).ToList();
            else if (current_lang == 1)
                temp = df.getOrganisations(i, current_lang).Select(s => new SelectListItem { Text = s.NameFr, Value = s.IdOrganisation.ToString(), Selected = s.IdOrganisation == iCurrent }).ToList();
            else
                temp = df.getOrganisations(i, current_lang).Select(s => new SelectListItem { Text = s.NameEn, Value = s.IdOrganisation.ToString(), Selected = s.IdOrganisation == iCurrent }).ToList();
            ViewBag.OnchangeCount = 1;
            temp.Insert(0, new SelectListItem { Text = "--- " + Resources.Global.JSAIndexChooseOrganisation + " ---", Value = "0", Selected = 0 == iCurrent });
            ViewBag.DivName = "SupervisorDiv";
            ViewBag.CboName = "Organisation";
            ViewBag.FuncName = "getSupervisorByOrganisation";
            ViewBag.VarName = "OrganisationID";
            ViewBag.Disabled = disabled;
            return PartialView("_DynamicCombo", temp);
        }

        //Return a DDM of the different environment from a query to the database (via function getWorkEnvironments) 
        //different within the current language and the Organisation
        public PartialViewResult getWorkEnv(string lang, string current = "0", string disabled = "false")
        {
            int iCurrent;
            int.TryParse(current, out iCurrent);
            List<SelectListItem> temp;
            if (current_lang == 0)
                temp = df.getWorkEnvironments(current_lang).Select(w => new SelectListItem { Text = w.NameEn, Value = w.IdwOrkEnv.ToString(), Selected = w.IdwOrkEnv == iCurrent }).ToList();
            else if (current_lang == 1)
                temp = df.getWorkEnvironments(current_lang).Select(w => new SelectListItem { Text = w.NameFr, Value = w.IdwOrkEnv.ToString(), Selected = w.IdwOrkEnv == iCurrent }).ToList();
            else
                temp = df.getWorkEnvironments(current_lang).Select(w => new SelectListItem { Text = w.NameEn, Value = w.IdwOrkEnv.ToString(), Selected = w.IdwOrkEnv == iCurrent }).ToList();
            temp.Insert(0, new SelectListItem { Text = "--- " + Resources.Global.JSAIndexChooseEnvironment + " ---", Value = "0", Selected = 0 == iCurrent });
            ViewBag.OnchangeCount = 0;
            ViewBag.Disabled = disabled;
            ViewBag.CboName = "WorkEnv";
            return PartialView("_DynamicCombo", temp);
        }

        public PartialViewResult getBranch(string lang, string current = "0", string disabled = "false")
        {
            int iCurrent;
            int.TryParse(current, out iCurrent);
            List<SelectListItem> temp;
            if (current_lang == 0)
                temp = df.getBranch(0).Select(w => new SelectListItem { Text = w.NameEn, Value = w.IdbRanch.ToString(), Selected = w.IdbRanch == iCurrent }).ToList();
            else if (current_lang == 1)
                temp = df.getBranch(1).Select(w => new SelectListItem { Text = w.NameFr, Value = w.IdbRanch.ToString(), Selected = w.IdbRanch == iCurrent }).ToList();
            else
                temp = df.getBranch(0).Select(w => new SelectListItem { Text = w.NameEn, Value = w.IdbRanch.ToString(), Selected = w.IdbRanch == iCurrent }).ToList();
            temp.Insert(0, new SelectListItem { Text = "--- " + Resources.Global.JSAIndexChooseBranch + " ---", Value = "0", Selected = 0 == iCurrent });
            ViewBag.OnchangeCount = 0;
            ViewBag.Disabled = disabled;
            ViewBag.CboName = "BranchEnv";
            return PartialView("_DynamicCombo", temp);
        }

        //Return a DDM from a query to the database (via function getSupervisors) different within the current language and the current Organisation
        public PartialViewResult getSupervisorByOrganisation(string OrganisationID, string lang, string current = "0", string disabled = "false")
        {
            int i = int.Parse(OrganisationID.ToString());
            int iCurrent;
            int.TryParse(current, out iCurrent);
            List<SelectListItem> temp;
            temp = df.getSupervisors(i).Select(t => new SelectListItem { Text = t.Description, Value = t.IdsUpervisor.ToString(), Selected = t.IdsUpervisor == iCurrent }).ToList();
            temp.Insert(0, new SelectListItem { Text = "---" +  Resources.Global.UnspecifiedSup + "---", Value = "1", Selected = 0 == iCurrent });
            ViewBag.OnchangeCount = 0;
            ViewBag.Disabled = disabled;
            ViewBag.CboName = "Supervisor";
            return PartialView("_DynamicCombo", temp);
        }

        public PartialViewResult loadJSA(int JSAID, string lang)
        {
            Safe_Task_Analysis.Models.JSA temp = null;
            temp = df.getJSA(JSAID);
            ViewBag.Errors = new List<string>();
            return PartialView("_loadTable", temp);
        }

        public string modifySupervisor(int idSupervisor, string newName)
        {
            string s = "Task failed !";
            if (df.authAdmin())
            {
                if (df.modifySupervisor(idSupervisor, newName))
                    s = "Success !";
            }
            else
                s = "You are not administrator";
            return s;
        }

        public string modifyBranch(int idBranch, string nameFR, string nameEN)
        {
            string s = "Task failed !";
            if (df.authAdmin())
            {
                if (df.modifyBranch(idBranch, nameFR, nameEN))
                    s = "Success !";
            }
            else
                s = "You are not administrator";
            return s;
        }
        
        public string modifyRegion(int idRegion, string nameFR, string nameEN)
        {
            string s = "Task failed !";
            if (df.authAdmin())
            {
                if (df.modifyRegion(idRegion, nameFR, nameEN))
                    s = "Success !";
            }
            else
                s = "You are not administrator";
            return s;
        }

        public string modifyOrganisation(int idOrganisation, string nameFR, string nameEN)
        {
            string s = "Task failed !";
            if (df.authAdmin())
            {
                if (df.modifyOrganisation(idOrganisation, nameFR, nameEN))
                    s = "Success !";
            }
            else
                s = "You are not administrator";
            return s;
        }

        public string modifyEnv(int idEnv, string nameFR, string nameEN)
        {
            string s = "Task failed !";
            if (df.authAdmin())
            {
                if (df.modifyEnv(idEnv, nameFR, nameEN))
                    s = "Success !";
            }
            else
                s = "You are not administrator";
            return s;
        }
        
        [HttpPost]
        public ActionResult Index(HttpPostedFileBase file, int jsaid)
        {
            if (file != null && file.ContentLength > 0)
            {
                // extract only the filename
                string fileName = Path.GetFileName(file.FileName);
                // store the file inside ~/Content/pdfs" folder
                string path = Path.Combine(Server.MapPath("~/Content/pdfs"), fileName);
                file.SaveAs(path);
                string s = Url.Content("Content/pdfs/") + fileName;
                if (df.savePath(s, jsaid))
                    return Index(jsaid);
            }
            return Index(jsaid);
        }

        //Save the current header
        public PartialViewResult saveJSAHeader(int BranchID, int RegionID, int OrganisationID, int EnvirID, int SupervisorID, string TaskName, string EditorName, string lang, int TaskID)
        {
            int new_id = -1;
            List<string> errors = new List<string>();
            string TaskNameD;
            TaskNameD = System.Web.HttpUtility.HtmlDecode(TaskName);
            EditorName = Server.HtmlDecode(EditorName);
            if (errors.Count == 0)
            {
                new_id = df.saveJSAHeader(BranchID, TaskID, RegionID, OrganisationID, EnvirID, SupervisorID, TaskNameD, EditorName, ref errors);
                if (new_id > 0)
                    return loadJSAHeader(new_id, lang, errors);
            }
            return loadJSAHeader(-1, lang, errors);
        }

        //Load a new header for a JSA if no id in the url / otherwise load the jsa
        public PartialViewResult loadJSAHeader(int JSA_ID, string lang, List<string> errors = null)
        {
            Safe_Task_Analysis.Models.JSA temp = null;
            if (JSA_ID > 0)
            {
                temp = df.getJSA(JSA_ID);
            }
            if (errors != null)
                ViewBag.Errors = errors;
            else
                ViewBag.Errors = new List<string>();
            return PartialView("_loadJSAHeader", temp);
        }

        public PartialViewResult loadStatistics()
        {
            List<List<Safe_Task_Analysis.Models.JSA_Attr>> temp = df.getStatistics();
            return PartialView("_loadStatistics", temp);
        }

        public PartialViewResult loadSearchHeader(int JSA_ID, string lang, List<string> errors = null)
        {
            Safe_Task_Analysis.Models.JSA temp = null;
            return PartialView("_loadSearchHeader", temp);
        }

        public PartialViewResult saveJSATask(string JSA_ID, string TaskDesc, string OrderNo, string lang)
        {
            int iJSA_ID;
            int iOrderNo;
            List<string> errors = new List<string>();
            Safe_Task_Analysis.Models.Task temp = null;
            if (!int.TryParse(JSA_ID, out iJSA_ID))
                errors.Add("Error parsing JSA_ID, invalid value");
            if (!int.TryParse(OrderNo, out iOrderNo))
                errors.Add("Error parsing OrderNo, invalid value");
            iOrderNo = iOrderNo + 1;
            temp = df.saveJSATask(iJSA_ID, TaskDesc, iOrderNo, ref errors);
            ViewBag.Errors = errors;
            return loadJSA(temp.JSAid, lang);
        }

        public PartialViewResult loadJSATask(int TaskID, string lang)
        {
            Safe_Task_Analysis.Models.Task temp = null;
            temp = df.getTask(TaskID);
            ViewBag.Errors = new List<string>();
            return PartialView("_loadTaskDesc", temp);
        }

        public PartialViewResult updateJSATask(string TaskID, string TaskDesc, string lang)
        {
            int iTaskID;
            List<string> errors = new List<string>();
            if (!int.TryParse(TaskID, out iTaskID))
                errors.Add("Error parsing JSA_ID, invalid value");
            Safe_Task_Analysis.Models.Task temp = null;
            temp = df.updateJSATask(iTaskID, TaskDesc, ref  errors);
            return loadJSA(temp.JSAid, lang);
        }

        public PartialViewResult deleteJSATask(string TaskID, string lang)
        {
            int iTaskID;
            string ModifiedTasks = "";
            List<string> errors = new List<string>();
            if (!int.TryParse(TaskID, out iTaskID))
                errors.Add("Error parsing JSA_ID, invalid value");
            List<int> temp = new List<int>();
            temp = df.deleteJSATask(iTaskID, out ModifiedTasks, ref errors);
            df.reorderTable(temp[0], temp[1]);
            return loadJSA(temp[1], lang);

        }

        public PartialViewResult saveJSARisk(string TaskID, string RiskDesc, string lang)
        {
            int iTaskID;
            List<string> errors = new List<string>();
            Safe_Task_Analysis.Models.AssociatedRisk temp = null;
            if (!int.TryParse(TaskID, out iTaskID))
                errors.Add("Error parsing TaskID, invalid value");
            temp = df.saveJSARisk(iTaskID, RiskDesc, ref errors);
            ViewBag.Errors = errors;
            ViewBag.CurrentLang = current_lang;
            return loadJSA(temp.Task.JSAid, lang);
        }

        public PartialViewResult loadJSARisk(int RiskID, string lang)
        {
            Safe_Task_Analysis.Models.AssociatedRisk temp = null;
            temp = df.getAssRisk(RiskID);
            ViewBag.Errors = new List<string>();
            ViewBag.CurrentLang = current_lang;
            return PartialView("_loadPotentialRisk", temp);
        }

        public PartialViewResult updateJSARisk(string AssRiskID, string RiskDesc, string lang)
        {
            int iAssRiskID;
            List<string> errors = new List<string>();
            if (!int.TryParse(AssRiskID, out iAssRiskID))
                errors.Add("Error parsing AssRiskID, invalid value");
            Safe_Task_Analysis.Models.AssociatedRisk temp = null;
            temp = df.updateJSARisk(iAssRiskID, RiskDesc, ref errors);
            return loadJSA(temp.Task.JSAid, lang);
        }

        public PartialViewResult deleteJSARisk(string AssRiskID, string lang)
        {
            int iAssRiskID;
            List<string> errors = new List<string>();
            if (!int.TryParse(AssRiskID, out iAssRiskID))
                errors.Add("Error parsing AssRiskID, invalid value");
            Safe_Task_Analysis.Models.AssociatedRisk temp = null;
            temp = df.deleteJSARisk(iAssRiskID, ref errors);
            return loadJSA(temp.Task.JSAid, lang);
        }

        public PartialViewResult updateJSAPrevMes(string PrevMesID, string PrevMesDesc, string lang)
        {
            int iPrevMesID;
            List<string> errors = new List<string>();
            if (!int.TryParse(PrevMesID, out iPrevMesID))
                errors.Add("Error parsing PrevMesID, invalid value");
            Safe_Task_Analysis.Models.PreventiveMesure temp = null;
            temp = df.updateJSAPrevMes(iPrevMesID, PrevMesDesc, ref errors);
            return loadJSA(temp.AssociatedRisk.Task.JSAid, lang);
        }

        public PartialViewResult deleteJSAPrevMes(string PrevMeskID, string lang)
        {
            int iPrevMeskID;
            List<string> errors = new List<string>();
            if (!int.TryParse(PrevMeskID, out iPrevMeskID))
                errors.Add("Error parsing AssRiskID, invalid value");
            Safe_Task_Analysis.Models.PreventiveMesure temp = null;
            temp = df.deleteJSAPrevMes(iPrevMeskID, ref errors);
            return loadJSA(temp.AssociatedRisk.Task.JSAid, lang);
        }

        public PartialViewResult saveJSAPrevMes(string AssRiskID, string PrevMesDesc, string lang)
        {
            int iAssRiskID;
            List<string> errors = new List<string>();
            Safe_Task_Analysis.Models.PreventiveMesure temp = null;
            if (!int.TryParse(AssRiskID, out iAssRiskID))
                errors.Add("Error parsing AssRiskID, invalid value");
            temp = df.saveJSAPrevMes(iAssRiskID, PrevMesDesc, ref errors);
            ViewBag.Errors = errors;
            return loadJSA(temp.AssociatedRisk.Task.JSAid, lang);
        }

        public PartialViewResult loadJSAPrevMes(int PrevMesID, string lang)
        {
            Safe_Task_Analysis.Models.PreventiveMesure temp = null;
            ViewBag.Errors = new List<string>();
            temp = df.getPrevMes(PrevMesID);
            return PartialView("_loadPrevMesure", temp);
        }

        public string saveJSASafetyEquip(int JSA_ID, bool Helmet, bool Goggles, bool HearPlugs, bool Gloves, bool Boots, bool BreathingMask, bool Blouse, bool Face, bool Headcover, bool Item, string lang)
        {
            List<string> errors = new List<string>();
            df.saveJSASafetyEquip(JSA_ID, Helmet, Goggles, HearPlugs, Gloves, Boots, BreathingMask, Blouse, Face, Headcover, Item, ref errors);
            return "";
        }

        public PartialViewResult moveJSATask(string movement, int TaskID, string lang)
        {
            List<string> errors = new List<string>();
            Safe_Task_Analysis.Models.Task temp = null;
            temp = df.moveTask(movement, TaskID, ref errors);
            return loadJSA(temp.JSAid, lang);
        }

        public string getDoc(int IDJSA)
        {
            return df.getDoc(IDJSA);
        }

        public void updateSaveStage(int JSA_ID, int stage)
        {
            df.updateSaveStage(JSA_ID, stage);
        }

        public string countJSA()
        {
            return df.countJSA();
        }

        public string deleteAssDoc(int taskid)
        {
            string s = "Task failed !";
            if (df.deleteAssDoc(taskid))
                s = "Success !";
            return s;
        }

        //Using the library iTextSharp  we can export a pdf from the current html 
        public void exportPDF(int JSA_ID)
        {
            Safe_Task_Analysis.Models.JSA jsa = df.getJSA(JSA_ID);
            if (jsa == null)
                return;
            Document document = new Document();
            MemoryStream output = new MemoryStream();
            PdfWriter writer = PdfWriter.GetInstance(document, output);
            document.Open();
            Paragraph p = new Paragraph(Resources.Global.GlobalSafeTaskAnalysisTitle, FontFactory.GetFont("Arial", 18, Font.BOLD));
            p.Alignment = Element.ALIGN_CENTER;
            document.Add(p);

            PdfPTable tbl0 = new PdfPTable(4);
            tbl0.WidthPercentage = 100;
            tbl0.HorizontalAlignment = 0;
            tbl0.SpacingBefore = 20f;
            tbl0.SpacingAfter = 10f;
            tbl0.AddCell(new PdfPCell(new Phrase(Resources.Global.JSAIndexTaskToAnalize, FontFactory.GetFont("Arial", 12, Font.BOLD))));
            tbl0.AddCell(new PdfPCell(new Phrase(jsa.JSA_Attr.Last().TaskName, FontFactory.GetFont("Arial", 12, Font.NORMAL))));
            tbl0.AddCell(new PdfPCell(new Phrase("No", FontFactory.GetFont("Arial", 12, Font.BOLD))));
            tbl0.AddCell(new PdfPCell(new Phrase(jsa.JSA_Attr.Last().JSAid.ToString(), FontFactory.GetFont("Arial", 12, Font.NORMAL))));
            document.Add(tbl0);

            PdfPTable tbl1 = new PdfPTable(4);
            tbl1.WidthPercentage = 100;
            tbl1.HorizontalAlignment = 0;
            tbl1.SpacingBefore = 20f;
            tbl1.SpacingAfter = 10f;
            tbl1.AddCell(new PdfPCell(new Phrase(Resources.Global.JSAIndexBranch, FontFactory.GetFont("Arial", 12, Font.BOLD))));
            tbl1.AddCell(new PdfPCell(new Phrase(current_lang == 1 ? jsa.JSA_Attr.Last().Branch.NameFr : jsa.JSA_Attr.Last().Branch.NameEn, FontFactory.GetFont("Arial", 12, Font.NORMAL))));
            tbl1.AddCell(new PdfPCell(new Phrase(Resources.Global.GlobalAuthor, FontFactory.GetFont("Arial", 12, Font.BOLD))));
            tbl1.AddCell(new PdfPCell(new Phrase(jsa.JSA_Attr.Last().CreatedBy, FontFactory.GetFont("Arial", 12, Font.NORMAL))));
            tbl1.AddCell(new PdfPCell(new Phrase(Resources.Global.JSAIndexRegion, FontFactory.GetFont("Arial", 12, Font.BOLD))));
            tbl1.AddCell(new PdfPCell(new Phrase(current_lang == 1 ? jsa.JSA_Attr.Last().Region.NameFr : jsa.JSA_Attr.Last().Region.NameEn, FontFactory.GetFont("Arial", 12, Font.NORMAL))));
            tbl1.AddCell(new PdfPCell(new Phrase(Resources.Global.GlobalCreateDate, FontFactory.GetFont("Arial", 12, Font.BOLD))));
            tbl1.AddCell(new PdfPCell(new Phrase(jsa.JSA_Attr.Last().CreationDate.ToShortDateString(), FontFactory.GetFont("Arial", 12, Font.NORMAL))));
            tbl1.AddCell(new PdfPCell(new Phrase(Resources.Global.JSAIndexEnvironment, FontFactory.GetFont("Arial", 12, Font.BOLD))));
            tbl1.AddCell(new PdfPCell(new Phrase(current_lang == 1 ? jsa.JSA_Attr.Last().WorkEnvironment.NameFr : jsa.JSA_Attr.Last().WorkEnvironment.NameEn, FontFactory.GetFont("Arial", 12, Font.NORMAL))));
            tbl1.AddCell(new PdfPCell(new Phrase(Resources.Global.JSAIndexOrganisation, FontFactory.GetFont("Arial", 12, Font.BOLD))));
            tbl1.AddCell(new PdfPCell(new Phrase(current_lang == 1 ? jsa.JSA_Attr.Last().Organisation.NameFr : jsa.JSA_Attr.Last().Organisation.NameEn, FontFactory.GetFont("Arial", 12, Font.NORMAL))));            
            tbl1.AddCell(new PdfPCell(new Phrase(Resources.Global.JSAIndexSupervisor, FontFactory.GetFont("Arial", 12, Font.BOLD))));
            tbl1.AddCell(new PdfPCell(new Phrase(jsa.JSA_Attr.Last().Supervisor.Description, FontFactory.GetFont("Arial", 12, Font.NORMAL))));
            tbl1.AddCell(new PdfPCell(new Phrase(Resources.Global.GlobalModificationDate, FontFactory.GetFont("Arial", 12, Font.BOLD))));
            tbl1.AddCell(new PdfPCell(new Phrase(jsa.JSA_Attr.Last().ModifiedDate.ToShortDateString(), FontFactory.GetFont("Arial", 12, Font.NORMAL))));
            document.Add(tbl1);

            PdfPTable tbl = new PdfPTable(4);
            PdfPCell pcell = new PdfPCell();
            tbl.HorizontalAlignment = 0;
            int i = 0;
            float[] widths = new float[] { 0.25f, 0.75f, 1.5f, 1.5f };
            tbl.SetWidths(widths);
            tbl.SpacingBefore = 20f;
            tbl.SpacingAfter = 30f;
            tbl.WidthPercentage = 100;
            tbl.DefaultCell.Border = Rectangle.BOX;
            tbl.AddCell(new PdfPCell(new Phrase("#", FontFactory.GetFont("Arial", 14, Font.BOLD))));
            tbl.AddCell(new PdfPCell(new Phrase(Resources.Global.JSAIndexTaskOrder, FontFactory.GetFont("Arial", 14, Font.BOLD))));
            tbl.AddCell(new PdfPCell(new Phrase(Resources.Global.JSAIndexPotentialRisk, FontFactory.GetFont("Arial", 14, Font.BOLD))));
            tbl.AddCell(new PdfPCell(new Phrase(Resources.Global.JSAIndexPreventiveMesures, FontFactory.GetFont("Arial", 14, Font.BOLD))));
            foreach (Safe_Task_Analysis.Models.Task t in jsa.Task.Where(lb => lb.Task_Attr.Last().Active == true).ToList())
            {
                i = i + 1;
                tbl.AddCell(new PdfPCell(new Phrase(i.ToString(), FontFactory.GetFont("Arial", 14, Font.BOLD))));
                tbl.AddCell(new PdfPCell(new Phrase(t.Task_Attr.Last().Description, FontFactory.GetFont("Arial", 12, Font.NORMAL))));
                PdfPTable nestedRisks = new PdfPTable(1);
                PdfPTable nestedPm = new PdfPTable(1);
                foreach (Safe_Task_Analysis.Models.AssociatedRisk ar in t.AssociatedRisk.Where(lb => lb.AssociatedRisk_Attr.Last().Active == true).ToList())
                {
                    foreach (Safe_Task_Analysis.Models.PreventiveMesure pm in ar.PreventiveMesure.Where(lb => lb.PreventiveMesure_Attr.Last().Active == true).ToList())
                    {
                        nestedPm.AddCell(new PdfPCell(new Phrase(pm.PreventiveMesure_Attr.Last().Description, FontFactory.GetFont("Arial", 12, Font.NORMAL))));
                    }
                    nestedRisks.AddCell(new PdfPCell(new Phrase(ar.AssociatedRisk_Attr.Last().DescriptionRisk, FontFactory.GetFont("Arial", 12, Font.NORMAL))));
                }
                tbl.AddCell(nestedRisks);
                tbl.AddCell(nestedPm);
            }
            document.Add(tbl);
            p = new Paragraph(Resources.Global.JSAIndexSafeTyEquip, FontFactory.GetFont("Arial", 14, Font.BOLD));
            p.Alignment = Element.ALIGN_CENTER;
            document.Add(p);
            Image img;
            bool hasAny = false;
            if (jsa.JSA_Attr.Last().Helmet)
            {
                img = iTextSharp.text.Image.GetInstance(Server.MapPath(Url.Content("~/Images/helmet.png")));
                img.ScaleAbsolute(50, 50);
                img.Alignment = Image.TEXTWRAP;
                img.IndentationRight = 5;
                document.Add(img);
                hasAny = true;
            }
            if (jsa.JSA_Attr.Last().Goggles)
            {
                img = iTextSharp.text.Image.GetInstance(Server.MapPath(Url.Content("~/Images/goggles.png")));
                img.ScaleAbsolute(50, 50);
                img.Alignment = Image.TEXTWRAP;
                img.IndentationRight = 5;
                document.Add(img);
                hasAny = true;
            }
            if (jsa.JSA_Attr.Last().HearPlugs)
            {
                img = iTextSharp.text.Image.GetInstance(Server.MapPath(Url.Content("~/Images/HearPlugs.png")));
                img.ScaleAbsolute(50, 50);
                img.Alignment = Image.TEXTWRAP;
                img.IndentationRight = 5;
                document.Add(img);
                hasAny = true;
            }
            if (jsa.JSA_Attr.Last().Gloves)
            {
                img = iTextSharp.text.Image.GetInstance(Server.MapPath(Url.Content("~/Images/Gloves.png")));
                img.ScaleAbsolute(50, 50);
                img.Alignment = Image.TEXTWRAP;
                img.IndentationRight = 5;
                document.Add(img);
                hasAny = true;
            }
            if (jsa.JSA_Attr.Last().Boots)
            {
                img = iTextSharp.text.Image.GetInstance(Server.MapPath(Url.Content("~/Images/Boots.png")));
                img.ScaleAbsolute(50, 50);
                img.Alignment = Image.TEXTWRAP;
                img.IndentationRight = 5;
                document.Add(img);
                hasAny = true;
            }
            if (jsa.JSA_Attr.Last().BreathingMask)
            {
                img = iTextSharp.text.Image.GetInstance(Server.MapPath(Url.Content("~/Images/BreathingMask.png")));
                img.Alignment = Image.TEXTWRAP;
                img.ScaleAbsolute(50, 50);
                img.IndentationRight = 5;
                document.Add(img);
                hasAny = true;
            }
            if (jsa.JSA_Attr.Last().Blouse)
            {
                img = iTextSharp.text.Image.GetInstance(Server.MapPath(Url.Content("~/Images/Blouse.png")));
                img.ScaleAbsolute(50, 50);
                img.Alignment = Image.TEXTWRAP;
                img.IndentationRight = 5;
                document.Add(img);
                hasAny = true;
            }
            if (jsa.JSA_Attr.Last().Face)
            {
                img = iTextSharp.text.Image.GetInstance(Server.MapPath(Url.Content("~/Images/Face.png")));
                img.ScaleAbsolute(50, 50);
                img.Alignment = Image.TEXTWRAP;
                img.IndentationRight = 5;
                document.Add(img);
                hasAny = true;
            }
            if (jsa.JSA_Attr.Last().Headcover)
            {
                img = iTextSharp.text.Image.GetInstance(Server.MapPath(Url.Content("~/Images/Headcover.png")));
                img.ScaleAbsolute(50, 50);
                img.Alignment = Image.TEXTWRAP;
                img.IndentationRight = 5;
                document.Add(img);
                hasAny = true;
            }
            if (jsa.JSA_Attr.Last().Item)
            {
                img = iTextSharp.text.Image.GetInstance(Server.MapPath(Url.Content("~/Images/Item.png")));
                img.ScaleAbsolute(50, 50);
                img.Alignment = Image.TEXTWRAP;
                img.IndentationRight = 5;
                document.Add(img);
                hasAny = true;
            }
            if (!hasAny)
                document.Add(new Phrase(Resources.Global.JSAexportPdfNoneRequired));
            document.Close();
            Response.ContentType = "application/pdf";
            Response.AddHeader("Content-Disposition", string.Format("attachment;filename=JSA-AST-{0}.pdf", jsa.IDJSA));
            Response.BinaryWrite(output.ToArray());

        }
    }
}