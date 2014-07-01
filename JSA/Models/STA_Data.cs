// 
//  ____  _     __  __      _        _ 
// |  _ \| |__ |  \/  | ___| |_ __ _| |
// | | | | '_ \| |\/| |/ _ \ __/ _` | |
// | |_| | |_) | |  | |  __/ || (_| | |
// |____/|_.__/|_|  |_|\___|\__\__,_|_|
//
// Auto-generated from SafeTaskAnalysis on 2012-05-17 12:05:31Z.
// Please visit http://code.google.com/p/dblinq2007/ for more information.
//
namespace Safe_Task_Analysis.Models
{
    using System;
    using System.ComponentModel;
    using System.Data;
#if MONO_STRICT
	using System.Data.Linq;
#else   // MONO_STRICT
    using DbLinq.Data.Linq;
    using DbLinq.Vendor;
#endif  // MONO_STRICT
    using System.Data.Linq.Mapping;
    using System.Diagnostics;


    public partial class STA_DataDataContext : DataContext
    {

        #region Extensibility Method Declarations
        partial void OnCreated();
        #endregion


        public STA_DataDataContext(string connectionString) :
            base(connectionString)
        {
            this.OnCreated();
        }

        public STA_DataDataContext(string connection, MappingSource mappingSource) :
            base(connection, mappingSource)
        {
            this.OnCreated();
        }

        public STA_DataDataContext(IDbConnection connection, MappingSource mappingSource) :
            base(connection, mappingSource)
        {
            this.OnCreated();
        }

        public Table<Admin> Admins
        {
            get
            {
                return this.GetTable<Admin>();
            }
        }

        public Table<AssociatedRisk> AssociatedRisks
        {
            get
            {
                return this.GetTable<AssociatedRisk>();
            }
        }

        public Table<AssociatedRisk_Attr> AssociatedRisk_Attrs
        {
            get
            {
                return this.GetTable<AssociatedRisk_Attr>();
            }
        }

        public Table<Branch> Branchs
        {
            get
            {
                return this.GetTable<Branch>();
            }
        }

        public Table<JSA> JSAs
        {
            get
            {
                return this.GetTable<JSA>();
            }
        }

        public Table<JSA_Attr> JSA_Attrs
        {
            get
            {
                return this.GetTable<JSA_Attr>();
            }
        }

        public Table<Organisation> Organisations
        {
            get
            {
                return this.GetTable<Organisation>();
            }
        }

        public Table<PreventiveMesure> PreventiveMesures
        {
            get
            {
                return this.GetTable<PreventiveMesure>();
            }
        }

        public Table<PreventiveMesure_Attr> PreventiveMesure_Attrs
        {
            get
            {
                return this.GetTable<PreventiveMesure_Attr>();
            }
        }

        public Table<Region> Regions
        {
            get
            {
                return this.GetTable<Region>();
            }
        }

        public Table<Supervisor> Supervisors
        {
            get
            {
                return this.GetTable<Supervisor>();
            }
        }

        public Table<Task> Tasks
        {
            get
            {
                return this.GetTable<Task>();
            }
        }

        public Table<Task_Attr> Task_Attrs
        {
            get
            {
                return this.GetTable<Task_Attr>();
            }
        }

        public Table<WorkEnvironment> WorkEnvironments
        {
            get
            {
                return this.GetTable<WorkEnvironment>();
            }
        }
    }

    #region Start MONO_STRICT
#if MONO_STRICT

	public partial class STA_DataDataContext
	{
		
		public STA_DataDataContext(IDbConnection connection) : 
				base(connection)
		{
			this.OnCreated();
		}
	}
    #region End MONO_STRICT
    #endregion
#else     // MONO_STRICT

    public partial class STA_DataDataContext
    {

        public STA_DataDataContext(IDbConnection connection) :
            base(connection, new DbLinq.MySql.MySqlVendor())
        {
            this.OnCreated();
        }

        public STA_DataDataContext(IDbConnection connection, IVendor sqlDialect) :
            base(connection, sqlDialect)
        {
            this.OnCreated();
        }

        public STA_DataDataContext(IDbConnection connection, MappingSource mappingSource, IVendor sqlDialect) :
            base(connection, mappingSource, sqlDialect)
        {
            this.OnCreated();
        }
    }
    #region End Not MONO_STRICT
    #endregion
#endif     // MONO_STRICT
    #endregion
	
	[Table(Name="safetaskanalysis.Admin")]
	public partial class Admin : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private int _idAdmin;
		
		private string _login;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnIDAdminChanged();
		
		partial void OnIDAdminChanging(int value);
		
		partial void OnLoginChanged();
		
		partial void OnLoginChanging(string value);
		#endregion
		
		
		public Admin()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_idAdmin", Name="idAdmin", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int IDAdmin
		{
			get
			{
				return this._idAdmin;
			}
			set
			{
				if ((_idAdmin != value))
				{
					this.OnIDAdminChanging(value);
					this.SendPropertyChanging();
					this._idAdmin = value;
					this.SendPropertyChanged("IDAdmin");
					this.OnIDAdminChanged();
				}
			}
		}
		
		[Column(Storage="_login", Name="login", DbType="varchar(30)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Login
		{
			get
			{
				return this._login;
			}
			set
			{
				if (((_login == value) 
							== false))
				{
					this.OnLoginChanging(value);
					this.SendPropertyChanging();
					this._login = value;
					this.SendPropertyChanged("Login");
					this.OnLoginChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="safetaskanalysis.associatedrisk")]
	public partial class AssociatedRisk : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private int _idaSsRisk;
		
		private int _taskID;
		
		private EntitySet<AssociatedRisk_Attr> _AssociatedRisk_Attr;
		
		private EntitySet<PreventiveMesure> _PreventiveMesure;
		
		private EntityRef<Task> _task = new EntityRef<Task>();
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnIdaSsRiskChanged();
		
		partial void OnIdaSsRiskChanging(int value);
		
		partial void OnTaskIDChanged();
		
		partial void OnTaskIDChanging(int value);
		#endregion
		
		
		public AssociatedRisk()
		{
			_AssociatedRisk_Attr = new EntitySet<AssociatedRisk_Attr>(new Action<AssociatedRisk_Attr>(this.AssociatedRisk_Attr_Attach), new Action<AssociatedRisk_Attr>(this.AssociatedRisk_Attr_Detach));
			_PreventiveMesure = new EntitySet<PreventiveMesure>(new Action<PreventiveMesure>(this.PreventiveMesure_Attach), new Action<PreventiveMesure>(this.PreventiveMesure_Detach));
			this.OnCreated();
		}
		
		[Column(Storage="_idaSsRisk", Name="ID_Ass_Risk", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int IdaSsRisk
		{
			get
			{
				return this._idaSsRisk;
			}
			set
			{
				if ((_idaSsRisk != value))
				{
					this.OnIdaSsRiskChanging(value);
					this.SendPropertyChanging();
					this._idaSsRisk = value;
					this.SendPropertyChanged("IdaSsRisk");
					this.OnIdaSsRiskChanged();
				}
			}
		}
		
		[Column(Storage="_taskID", Name="Task_ID", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int TaskID
		{
			get
			{
				return this._taskID;
			}
			set
			{
				if ((_taskID != value))
				{
					this.OnTaskIDChanging(value);
					this.SendPropertyChanging();
					this._taskID = value;
					this.SendPropertyChanged("TaskID");
					this.OnTaskIDChanged();
				}
			}
		}
		
		#region Children
		[Association(Storage="_AssociatedRisk_Attr", OtherKey="AssRiskID", ThisKey="IdaSsRisk", Name="FK_Attr_AssRisk")]
		[DebuggerNonUserCode()]
		public EntitySet<AssociatedRisk_Attr> AssociatedRisk_Attr
		{
			get
			{
				return this._AssociatedRisk_Attr;
			}
			set
			{
				this._AssociatedRisk_Attr = value;
			}
		}
		
		[Association(Storage="_PreventiveMesure", OtherKey="RiskID", ThisKey="IdaSsRisk", Name="FK_PrevMes_AssRisk")]
		[DebuggerNonUserCode()]
		public EntitySet<PreventiveMesure> PreventiveMesure
		{
			get
			{
				return this._PreventiveMesure;
			}
			set
			{
				this._PreventiveMesure = value;
			}
		}
		#endregion
		
		#region Parents
		[Association(Storage="_task", OtherKey="IdtAsk", ThisKey="TaskID", Name="FK_AssRisk_Task", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public Task Task
		{
			get
			{
				return this._task.Entity;
			}
			set
			{
				if (((this._task.Entity == value) 
							== false))
				{
					if ((this._task.Entity != null))
					{
						Task previousTask = this._task.Entity;
						this._task.Entity = null;
						previousTask.AssociatedRisk.Remove(this);
					}
					this._task.Entity = value;
					if ((value != null))
					{
						value.AssociatedRisk.Add(this);
						_taskID = value.IdtAsk;
					}
					else
					{
						_taskID = default(int);
					}
				}
			}
		}
		#endregion
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		#region Attachment handlers
		private void AssociatedRisk_Attr_Attach(AssociatedRisk_Attr entity)
		{
			this.SendPropertyChanging();
			entity.AssociatedRisk = this;
		}
		
		private void AssociatedRisk_Attr_Detach(AssociatedRisk_Attr entity)
		{
			this.SendPropertyChanging();
			entity.AssociatedRisk = null;
		}
		
		private void PreventiveMesure_Attach(PreventiveMesure entity)
		{
			this.SendPropertyChanging();
			entity.AssociatedRisk = this;
		}
		
		private void PreventiveMesure_Detach(PreventiveMesure entity)
		{
			this.SendPropertyChanging();
			entity.AssociatedRisk = null;
		}
		#endregion
	}
	
	[Table(Name="safetaskanalysis.associatedrisk_attr")]
	public partial class AssociatedRisk_Attr : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private bool _active;
		
		private int _assRiskID;
		
		private string _descriptionRisk;
		
		private int _idaSsRiskAttr;
		
		private EntityRef<AssociatedRisk> _associatedRisk = new EntityRef<AssociatedRisk>();
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnActiveChanged();
		
		partial void OnActiveChanging(bool value);
		
		partial void OnAssRiskIDChanged();
		
		partial void OnAssRiskIDChanging(int value);
		
		partial void OnDescriptionRiskChanged();
		
		partial void OnDescriptionRiskChanging(string value);
		
		partial void OnIdaSsRiskAttrChanged();
		
		partial void OnIdaSsRiskAttrChanging(int value);
		#endregion
		
		
		public AssociatedRisk_Attr()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_active", Name="Active", DbType="tinyint(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public bool Active
		{
			get
			{
				return this._active;
			}
			set
			{
				if ((_active != value))
				{
					this.OnActiveChanging(value);
					this.SendPropertyChanging();
					this._active = value;
					this.SendPropertyChanged("Active");
					this.OnActiveChanged();
				}
			}
		}
		
		[Column(Storage="_assRiskID", Name="Ass_Risk_ID", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int AssRiskID
		{
			get
			{
				return this._assRiskID;
			}
			set
			{
				if ((_assRiskID != value))
				{
					this.OnAssRiskIDChanging(value);
					this.SendPropertyChanging();
					this._assRiskID = value;
					this.SendPropertyChanged("AssRiskID");
					this.OnAssRiskIDChanged();
				}
			}
		}
		
		[Column(Storage="_descriptionRisk", Name="Description_risk", DbType="varchar(100)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string DescriptionRisk
		{
			get
			{
				return this._descriptionRisk;
			}
			set
			{
				if (((_descriptionRisk == value) 
							== false))
				{
					this.OnDescriptionRiskChanging(value);
					this.SendPropertyChanging();
					this._descriptionRisk = value;
					this.SendPropertyChanged("DescriptionRisk");
					this.OnDescriptionRiskChanged();
				}
			}
		}
		
		[Column(Storage="_idaSsRiskAttr", Name="ID_Ass_Risk_Attr", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int IdaSsRiskAttr
		{
			get
			{
				return this._idaSsRiskAttr;
			}
			set
			{
				if ((_idaSsRiskAttr != value))
				{
					this.OnIdaSsRiskAttrChanging(value);
					this.SendPropertyChanging();
					this._idaSsRiskAttr = value;
					this.SendPropertyChanged("IdaSsRiskAttr");
					this.OnIdaSsRiskAttrChanged();
				}
			}
		}
		
		#region Parents
		[Association(Storage="_associatedRisk", OtherKey="IdaSsRisk", ThisKey="AssRiskID", Name="FK_Attr_AssRisk", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public AssociatedRisk AssociatedRisk
		{
			get
			{
				return this._associatedRisk.Entity;
			}
			set
			{
				if (((this._associatedRisk.Entity == value) 
							== false))
				{
					if ((this._associatedRisk.Entity != null))
					{
						AssociatedRisk previousAssociatedRisk = this._associatedRisk.Entity;
						this._associatedRisk.Entity = null;
						previousAssociatedRisk.AssociatedRisk_Attr.Remove(this);
					}
					this._associatedRisk.Entity = value;
					if ((value != null))
					{
						value.AssociatedRisk_Attr.Add(this);
						_assRiskID = value.IdaSsRisk;
					}
					else
					{
						_assRiskID = default(int);
					}
				}
			}
		}
		#endregion
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="safetaskanalysis.branch")]
	public partial class Branch : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private int _idbRanch;
		
		private string _nameEn;
		
		private string _nameFr;
		
		private EntitySet<JSA_Attr> _JSA_Attr;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnIdbRanchChanged();
		
		partial void OnIdbRanchChanging(int value);
		
		partial void OnNameEnChanged();
		
		partial void OnNameEnChanging(string value);
		
		partial void OnNameFrChanged();
		
		partial void OnNameFrChanging(string value);
		#endregion
		
		
		public Branch()
		{
			_JSA_Attr = new EntitySet<JSA_Attr>(new Action<JSA_Attr>(this.JSA_Attr_Attach), new Action<JSA_Attr>(this.JSA_Attr_Detach));
			this.OnCreated();
		}
		
		[Column(Storage="_idbRanch", Name="ID_Branch", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int IdbRanch
		{
			get
			{
				return this._idbRanch;
			}
			set
			{
				if ((_idbRanch != value))
				{
					this.OnIdbRanchChanging(value);
					this.SendPropertyChanging();
					this._idbRanch = value;
					this.SendPropertyChanged("IdbRanch");
					this.OnIdbRanchChanged();
				}
			}
		}
		
		[Column(Storage="_nameEn", Name="NameEN", DbType="varchar(75)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string NameEn
		{
			get
			{
				return this._nameEn;
			}
			set
			{
				if (((_nameEn == value) 
							== false))
				{
					this.OnNameEnChanging(value);
					this.SendPropertyChanging();
					this._nameEn = value;
					this.SendPropertyChanged("NameEn");
					this.OnNameEnChanged();
				}
			}
		}
		
		[Column(Storage="_nameFr", Name="NameFR", DbType="varchar(75)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string NameFr
		{
			get
			{
				return this._nameFr;
			}
			set
			{
				if (((_nameFr == value) 
							== false))
				{
					this.OnNameFrChanging(value);
					this.SendPropertyChanging();
					this._nameFr = value;
					this.SendPropertyChanged("NameFr");
					this.OnNameFrChanged();
				}
			}
		}
		
		#region Children
		[Association(Storage="_JSA_Attr", OtherKey="BranchID", ThisKey="IdbRanch", Name="FK_JSA_Branch")]
		[DebuggerNonUserCode()]
		public EntitySet<JSA_Attr> JSA_Attr
		{
			get
			{
				return this._JSA_Attr;
			}
			set
			{
				this._JSA_Attr = value;
			}
		}
		#endregion
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		#region Attachment handlers
		private void JSA_Attr_Attach(JSA_Attr entity)
		{
			this.SendPropertyChanging();
			entity.Branch = this;
		}
		
		private void JSA_Attr_Detach(JSA_Attr entity)
		{
			this.SendPropertyChanging();
			entity.Branch = null;
		}
		#endregion
	}
	
	[Table(Name="safetaskanalysis.JSA")]
	public partial class JSA : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private bool _active;
		
		private int _idJSA;
		
		private EntitySet<JSA_Attr> _JSA_Attr;
		
		private EntitySet<Task> _task;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnActiveChanged();
		
		partial void OnActiveChanging(bool value);
		
		partial void OnIDJSAChanged();
		
		partial void OnIDJSAChanging(int value);
		#endregion
		
		
		public JSA()
		{
			_JSA_Attr = new EntitySet<JSA_Attr>(new Action<JSA_Attr>(this.JSA_Attr_Attach), new Action<JSA_Attr>(this.JSA_Attr_Detach));
			_task = new EntitySet<Task>(new Action<Task>(this.Task_Attach), new Action<Task>(this.Task_Detach));
			this.OnCreated();
		}
		
		[Column(Storage="_active", Name="Active", DbType="tinyint(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public bool Active
		{
			get
			{
				return this._active;
			}
			set
			{
				if ((_active != value))
				{
					this.OnActiveChanging(value);
					this.SendPropertyChanging();
					this._active = value;
					this.SendPropertyChanged("Active");
					this.OnActiveChanged();
				}
			}
		}
		
		[Column(Storage="_idJSA", Name="ID_JSA", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int IDJSA
		{
			get
			{
				return this._idJSA;
			}
			set
			{
				if ((_idJSA != value))
				{
					this.OnIDJSAChanging(value);
					this.SendPropertyChanging();
					this._idJSA = value;
					this.SendPropertyChanged("IDJSA");
					this.OnIDJSAChanged();
				}
			}
		}
		
		#region Children
		[Association(Storage="_JSA_Attr", OtherKey="JSAid", ThisKey="IDJSA", Name="FK_JSA_ID")]
		[DebuggerNonUserCode()]
		public EntitySet<JSA_Attr> JSA_Attr
		{
			get
			{
				return this._JSA_Attr;
			}
			set
			{
				this._JSA_Attr = value;
			}
		}
		
		[Association(Storage="_task", OtherKey="JSAid", ThisKey="IDJSA", Name="FK_Task_JSA")]
		[DebuggerNonUserCode()]
		public EntitySet<Task> Task
		{
			get
			{
				return this._task;
			}
			set
			{
				this._task = value;
			}
		}
		#endregion
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		#region Attachment handlers
		private void JSA_Attr_Attach(JSA_Attr entity)
		{
			this.SendPropertyChanging();
			entity.JSA = this;
		}
		
		private void JSA_Attr_Detach(JSA_Attr entity)
		{
			this.SendPropertyChanging();
			entity.JSA = null;
		}
		
		private void Task_Attach(Task entity)
		{
			this.SendPropertyChanging();
			entity.JSA = this;
		}
		
		private void Task_Detach(Task entity)
		{
			this.SendPropertyChanging();
			entity.JSA = null;
		}
		#endregion
	}
	
	[Table(Name="safetaskanalysis.JSA_attr")]
	public partial class JSA_Attr : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private bool _active;
		
		private string _associatedDoc;
		
		private bool _blouse;
		
		private bool _boots;
		
		private int _branchID;
		
		private bool _breathingMask;
		
		private string _createdBy;
		
		private System.DateTime _creationDate;
		
		private int _currentSaveStage;
		
		private bool _face;
		
		private bool _gloves;
		
		private bool _goggles;
		
		private bool _headcover;
		
		private bool _hearPlugs;
		
		private bool _helmet;
		
		private int _idJSA_Attr;
		
		private string _infoGen;
		
		private bool _item;
		
		private int _JSAid;
		
		private string _modifiedBy;
		
		private System.DateTime _modifiedDate;
		
		private int _OrganisationID;
		
		private int _regionID;
		
		private int _supervisorID;
		
		private string _taskName;
		
		private int _workEnvID;
		
		private EntityRef<Branch> _branch = new EntityRef<Branch>();
		
		private EntityRef<JSA> _JSA = new EntityRef<JSA>();
		
		private EntityRef<Organisation> _Organisation = new EntityRef<Organisation>();
		
		private EntityRef<Region> _region = new EntityRef<Region>();
		
		private EntityRef<Supervisor> _supervisor = new EntityRef<Supervisor>();
		
		private EntityRef<WorkEnvironment> _workEnvironment = new EntityRef<WorkEnvironment>();
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnActiveChanged();
		
		partial void OnActiveChanging(bool value);
		
		partial void OnAssociatedDocChanged();
		
		partial void OnAssociatedDocChanging(string value);
		
		partial void OnBlouseChanged();
		
		partial void OnBlouseChanging(bool value);
		
		partial void OnBootsChanged();
		
		partial void OnBootsChanging(bool value);
		
		partial void OnBranchIDChanged();
		
		partial void OnBranchIDChanging(int value);
		
		partial void OnBreathingMaskChanged();
		
		partial void OnBreathingMaskChanging(bool value);
		
		partial void OnCreatedByChanged();
		
		partial void OnCreatedByChanging(string value);
		
		partial void OnCreationDateChanged();
		
		partial void OnCreationDateChanging(System.DateTime value);
		
		partial void OnCurrentSaveStageChanged();
		
		partial void OnCurrentSaveStageChanging(int value);
		
		partial void OnFaceChanged();
		
		partial void OnFaceChanging(bool value);
		
		partial void OnGlovesChanged();
		
		partial void OnGlovesChanging(bool value);
		
		partial void OnGogglesChanged();
		
		partial void OnGogglesChanging(bool value);
		
		partial void OnHeadcoverChanged();
		
		partial void OnHeadcoverChanging(bool value);
		
		partial void OnHearPlugsChanged();
		
		partial void OnHearPlugsChanging(bool value);
		
		partial void OnHelmetChanged();
		
		partial void OnHelmetChanging(bool value);
		
		partial void OnIdJSA_AttrChanged();
		
		partial void OnIdJSA_AttrChanging(int value);
		
		partial void OnInfoGenChanged();
		
		partial void OnInfoGenChanging(string value);
		
		partial void OnItemChanged();
		
		partial void OnItemChanging(bool value);
		
		partial void OnJSAidChanged();
		
		partial void OnJSAidChanging(int value);
		
		partial void OnModifiedByChanged();
		
		partial void OnModifiedByChanging(string value);
		
		partial void OnModifiedDateChanged();
		
		partial void OnModifiedDateChanging(System.DateTime value);
		
		partial void OnOrganisationIDChanged();
		
		partial void OnOrganisationIDChanging(int value);
		
		partial void OnRegionIDChanged();
		
		partial void OnRegionIDChanging(int value);
		
		partial void OnSupervisorIDChanged();
		
		partial void OnSupervisorIDChanging(int value);
		
		partial void OnTaskNameChanged();
		
		partial void OnTaskNameChanging(string value);
		
		partial void OnWorkEnvIDChanged();
		
		partial void OnWorkEnvIDChanging(int value);
		#endregion
		
		
		public JSA_Attr()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_active", Name="Active", DbType="tinyint(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public bool Active
		{
			get
			{
				return this._active;
			}
			set
			{
				if ((_active != value))
				{
					this.OnActiveChanging(value);
					this.SendPropertyChanging();
					this._active = value;
					this.SendPropertyChanged("Active");
					this.OnActiveChanged();
				}
			}
		}
		
		[Column(Storage="_associatedDoc", Name="associatedDoc", DbType="varchar(250)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AssociatedDoc
		{
			get
			{
				return this._associatedDoc;
			}
			set
			{
				if (((_associatedDoc == value) 
							== false))
				{
					this.OnAssociatedDocChanging(value);
					this.SendPropertyChanging();
					this._associatedDoc = value;
					this.SendPropertyChanged("AssociatedDoc");
					this.OnAssociatedDocChanged();
				}
			}
		}
		
		[Column(Storage="_blouse", Name="Blouse", DbType="tinyint(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public bool Blouse
		{
			get
			{
				return this._blouse;
			}
			set
			{
				if ((_blouse != value))
				{
					this.OnBlouseChanging(value);
					this.SendPropertyChanging();
					this._blouse = value;
					this.SendPropertyChanged("Blouse");
					this.OnBlouseChanged();
				}
			}
		}
		
		[Column(Storage="_boots", Name="Boots", DbType="tinyint(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public bool Boots
		{
			get
			{
				return this._boots;
			}
			set
			{
				if ((_boots != value))
				{
					this.OnBootsChanging(value);
					this.SendPropertyChanging();
					this._boots = value;
					this.SendPropertyChanged("Boots");
					this.OnBootsChanged();
				}
			}
		}
		
		[Column(Storage="_branchID", Name="Branch_ID", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int BranchID
		{
			get
			{
				return this._branchID;
			}
			set
			{
				if ((_branchID != value))
				{
					this.OnBranchIDChanging(value);
					this.SendPropertyChanging();
					this._branchID = value;
					this.SendPropertyChanged("BranchID");
					this.OnBranchIDChanged();
				}
			}
		}
		
		[Column(Storage="_breathingMask", Name="BreathingMask", DbType="tinyint(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public bool BreathingMask
		{
			get
			{
				return this._breathingMask;
			}
			set
			{
				if ((_breathingMask != value))
				{
					this.OnBreathingMaskChanging(value);
					this.SendPropertyChanging();
					this._breathingMask = value;
					this.SendPropertyChanged("BreathingMask");
					this.OnBreathingMaskChanged();
				}
			}
		}
		
		[Column(Storage="_createdBy", Name="CreatedBy", DbType="varchar(50)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string CreatedBy
		{
			get
			{
				return this._createdBy;
			}
			set
			{
				if (((_createdBy == value) 
							== false))
				{
					this.OnCreatedByChanging(value);
					this.SendPropertyChanging();
					this._createdBy = value;
					this.SendPropertyChanged("CreatedBy");
					this.OnCreatedByChanged();
				}
			}
		}
		
		[Column(Storage="_creationDate", Name="CreationDate", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime CreationDate
		{
			get
			{
				return this._creationDate;
			}
			set
			{
				if ((_creationDate != value))
				{
					this.OnCreationDateChanging(value);
					this.SendPropertyChanging();
					this._creationDate = value;
					this.SendPropertyChanged("CreationDate");
					this.OnCreationDateChanged();
				}
			}
		}
		
		[Column(Storage="_currentSaveStage", Name="CurrentSaveStage", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int CurrentSaveStage
		{
			get
			{
				return this._currentSaveStage;
			}
			set
			{
				if ((_currentSaveStage != value))
				{
					this.OnCurrentSaveStageChanging(value);
					this.SendPropertyChanging();
					this._currentSaveStage = value;
					this.SendPropertyChanged("CurrentSaveStage");
					this.OnCurrentSaveStageChanged();
				}
			}
		}
		
		[Column(Storage="_face", Name="Face", DbType="tinyint(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public bool Face
		{
			get
			{
				return this._face;
			}
			set
			{
				if ((_face != value))
				{
					this.OnFaceChanging(value);
					this.SendPropertyChanging();
					this._face = value;
					this.SendPropertyChanged("Face");
					this.OnFaceChanged();
				}
			}
		}
		
		[Column(Storage="_gloves", Name="Gloves", DbType="tinyint(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public bool Gloves
		{
			get
			{
				return this._gloves;
			}
			set
			{
				if ((_gloves != value))
				{
					this.OnGlovesChanging(value);
					this.SendPropertyChanging();
					this._gloves = value;
					this.SendPropertyChanged("Gloves");
					this.OnGlovesChanged();
				}
			}
		}
		
		[Column(Storage="_goggles", Name="Goggles", DbType="tinyint(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public bool Goggles
		{
			get
			{
				return this._goggles;
			}
			set
			{
				if ((_goggles != value))
				{
					this.OnGogglesChanging(value);
					this.SendPropertyChanging();
					this._goggles = value;
					this.SendPropertyChanged("Goggles");
					this.OnGogglesChanged();
				}
			}
		}
		
		[Column(Storage="_headcover", Name="Headcover", DbType="tinyint(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public bool Headcover
		{
			get
			{
				return this._headcover;
			}
			set
			{
				if ((_headcover != value))
				{
					this.OnHeadcoverChanging(value);
					this.SendPropertyChanging();
					this._headcover = value;
					this.SendPropertyChanged("Headcover");
					this.OnHeadcoverChanged();
				}
			}
		}
		
		[Column(Storage="_hearPlugs", Name="HearPlugs", DbType="tinyint(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public bool HearPlugs
		{
			get
			{
				return this._hearPlugs;
			}
			set
			{
				if ((_hearPlugs != value))
				{
					this.OnHearPlugsChanging(value);
					this.SendPropertyChanging();
					this._hearPlugs = value;
					this.SendPropertyChanged("HearPlugs");
					this.OnHearPlugsChanged();
				}
			}
		}
		
		[Column(Storage="_helmet", Name="Helmet", DbType="tinyint(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public bool Helmet
		{
			get
			{
				return this._helmet;
			}
			set
			{
				if ((_helmet != value))
				{
					this.OnHelmetChanging(value);
					this.SendPropertyChanging();
					this._helmet = value;
					this.SendPropertyChanged("Helmet");
					this.OnHelmetChanged();
				}
			}
		}
		
		[Column(Storage="_idJSA_Attr", Name="ID_JSA_Attr", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int IdJSA_Attr
		{
			get
			{
				return this._idJSA_Attr;
			}
			set
			{
				if ((_idJSA_Attr != value))
				{
					this.OnIdJSA_AttrChanging(value);
					this.SendPropertyChanging();
					this._idJSA_Attr = value;
					this.SendPropertyChanged("IdJSA_Attr");
					this.OnIdJSA_AttrChanged();
				}
			}
		}
		
		[Column(Storage="_infoGen", Name="InfoGen", DbType="varchar(500)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string InfoGen
		{
			get
			{
				return this._infoGen;
			}
			set
			{
				if (((_infoGen == value) 
							== false))
				{
					this.OnInfoGenChanging(value);
					this.SendPropertyChanging();
					this._infoGen = value;
					this.SendPropertyChanged("InfoGen");
					this.OnInfoGenChanged();
				}
			}
		}
		
		[Column(Storage="_item", Name="Item", DbType="tinyint(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public bool Item
		{
			get
			{
				return this._item;
			}
			set
			{
				if ((_item != value))
				{
					this.OnItemChanging(value);
					this.SendPropertyChanging();
					this._item = value;
					this.SendPropertyChanged("Item");
					this.OnItemChanged();
				}
			}
		}
		
		[Column(Storage="_JSAid", Name="JSA_ID", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int JSAid
		{
			get
			{
				return this._JSAid;
			}
			set
			{
				if ((_JSAid != value))
				{
					this.OnJSAidChanging(value);
					this.SendPropertyChanging();
					this._JSAid = value;
					this.SendPropertyChanged("JSAid");
					this.OnJSAidChanged();
				}
			}
		}
		
		[Column(Storage="_modifiedBy", Name="ModifiedBy", DbType="varchar(50)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string ModifiedBy
		{
			get
			{
				return this._modifiedBy;
			}
			set
			{
				if (((_modifiedBy == value) 
							== false))
				{
					this.OnModifiedByChanging(value);
					this.SendPropertyChanging();
					this._modifiedBy = value;
					this.SendPropertyChanged("ModifiedBy");
					this.OnModifiedByChanged();
				}
			}
		}
		
		[Column(Storage="_modifiedDate", Name="ModifiedDate", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime ModifiedDate
		{
			get
			{
				return this._modifiedDate;
			}
			set
			{
				if ((_modifiedDate != value))
				{
					this.OnModifiedDateChanging(value);
					this.SendPropertyChanging();
					this._modifiedDate = value;
					this.SendPropertyChanged("ModifiedDate");
					this.OnModifiedDateChanged();
				}
			}
		}
		
		[Column(Storage="_OrganisationID", Name="Organisation_ID", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int OrganisationID
		{
			get
			{
				return this._OrganisationID;
			}
			set
			{
				if ((_OrganisationID != value))
				{
					this.OnOrganisationIDChanging(value);
					this.SendPropertyChanging();
					this._OrganisationID = value;
					this.SendPropertyChanged("OrganisationID");
					this.OnOrganisationIDChanged();
				}
			}
		}
		
		[Column(Storage="_regionID", Name="Region_ID", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int RegionID
		{
			get
			{
				return this._regionID;
			}
			set
			{
				if ((_regionID != value))
				{
					this.OnRegionIDChanging(value);
					this.SendPropertyChanging();
					this._regionID = value;
					this.SendPropertyChanged("RegionID");
					this.OnRegionIDChanged();
				}
			}
		}
		
		[Column(Storage="_supervisorID", Name="Supervisor_ID", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int SupervisorID
		{
			get
			{
				return this._supervisorID;
			}
			set
			{
				if ((_supervisorID != value))
				{
					this.OnSupervisorIDChanging(value);
					this.SendPropertyChanging();
					this._supervisorID = value;
					this.SendPropertyChanged("SupervisorID");
					this.OnSupervisorIDChanged();
				}
			}
		}
		
		[Column(Storage="_taskName", Name="TaskName", DbType="varchar(100)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string TaskName
		{
			get
			{
				return this._taskName;
			}
			set
			{
				if (((_taskName == value) 
							== false))
				{
					this.OnTaskNameChanging(value);
					this.SendPropertyChanging();
					this._taskName = value;
					this.SendPropertyChanged("TaskName");
					this.OnTaskNameChanged();
				}
			}
		}
		
		[Column(Storage="_workEnvID", Name="WorkEnv_ID", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int WorkEnvID
		{
			get
			{
				return this._workEnvID;
			}
			set
			{
				if ((_workEnvID != value))
				{
					this.OnWorkEnvIDChanging(value);
					this.SendPropertyChanging();
					this._workEnvID = value;
					this.SendPropertyChanged("WorkEnvID");
					this.OnWorkEnvIDChanged();
				}
			}
		}
		
		#region Parents
		[Association(Storage="_branch", OtherKey="IdbRanch", ThisKey="BranchID", Name="FK_JSA_Branch", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public Branch Branch
		{
			get
			{
				return this._branch.Entity;
			}
			set
			{
				if (((this._branch.Entity == value) 
							== false))
				{
					if ((this._branch.Entity != null))
					{
						Branch previousBranch = this._branch.Entity;
						this._branch.Entity = null;
						previousBranch.JSA_Attr.Remove(this);
					}
					this._branch.Entity = value;
					if ((value != null))
					{
						value.JSA_Attr.Add(this);
						_branchID = value.IdbRanch;
					}
					else
					{
						_branchID = default(int);
					}
				}
			}
		}
		
		[Association(Storage="_JSA", OtherKey="IDJSA", ThisKey="JSAid", Name="FK_JSA_ID", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public JSA JSA
		{
			get
			{
				return this._JSA.Entity;
			}
			set
			{
				if (((this._JSA.Entity == value) 
							== false))
				{
					if ((this._JSA.Entity != null))
					{
						JSA previousJSA = this._JSA.Entity;
						this._JSA.Entity = null;
						previousJSA.JSA_Attr.Remove(this);
					}
					this._JSA.Entity = value;
					if ((value != null))
					{
						value.JSA_Attr.Add(this);
						_JSAid = value.IDJSA;
					}
					else
					{
						_JSAid = default(int);
					}
				}
			}
		}
		
		[Association(Storage="_Organisation", OtherKey="IdOrganisation", ThisKey="OrganisationID", Name="FK_JSA_Organisation", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public Organisation Organisation
		{
			get
			{
				return this._Organisation.Entity;
			}
			set
			{
				if (((this._Organisation.Entity == value) 
							== false))
				{
					if ((this._Organisation.Entity != null))
					{
						Organisation previousOrganisation = this._Organisation.Entity;
						this._Organisation.Entity = null;
						previousOrganisation.JSA_Attr.Remove(this);
					}
					this._Organisation.Entity = value;
					if ((value != null))
					{
						value.JSA_Attr.Add(this);
						_OrganisationID = value.IdOrganisation;
					}
					else
					{
						_OrganisationID = default(int);
					}
				}
			}
		}
		
		[Association(Storage="_region", OtherKey="IdrEgion", ThisKey="RegionID", Name="FK_JSA_Region", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public Region Region
		{
			get
			{
				return this._region.Entity;
			}
			set
			{
				if (((this._region.Entity == value) 
							== false))
				{
					if ((this._region.Entity != null))
					{
						Region previousRegion = this._region.Entity;
						this._region.Entity = null;
						previousRegion.JSA_Attr.Remove(this);
					}
					this._region.Entity = value;
					if ((value != null))
					{
						value.JSA_Attr.Add(this);
						_regionID = value.IdrEgion;
					}
					else
					{
						_regionID = default(int);
					}
				}
			}
		}
		
		[Association(Storage="_supervisor", OtherKey="IdsUpervisor", ThisKey="SupervisorID", Name="FK_JSA_Supervisor", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public Supervisor Supervisor
		{
			get
			{
				return this._supervisor.Entity;
			}
			set
			{
				if (((this._supervisor.Entity == value) 
							== false))
				{
					if ((this._supervisor.Entity != null))
					{
						Supervisor previousSupervisor = this._supervisor.Entity;
						this._supervisor.Entity = null;
						previousSupervisor.JSA_Attr.Remove(this);
					}
					this._supervisor.Entity = value;
					if ((value != null))
					{
						value.JSA_Attr.Add(this);
						_supervisorID = value.IdsUpervisor;
					}
					else
					{
						_supervisorID = default(int);
					}
				}
			}
		}
		
		[Association(Storage="_workEnvironment", OtherKey="IdwOrkEnv", ThisKey="WorkEnvID", Name="FK_JSA_WorkEnv", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public WorkEnvironment WorkEnvironment
		{
			get
			{
				return this._workEnvironment.Entity;
			}
			set
			{
				if (((this._workEnvironment.Entity == value) 
							== false))
				{
					if ((this._workEnvironment.Entity != null))
					{
						WorkEnvironment previousWorkEnvironment = this._workEnvironment.Entity;
						this._workEnvironment.Entity = null;
						previousWorkEnvironment.JSA_Attr.Remove(this);
					}
					this._workEnvironment.Entity = value;
					if ((value != null))
					{
						value.JSA_Attr.Add(this);
						_workEnvID = value.IdwOrkEnv;
					}
					else
					{
						_workEnvID = default(int);
					}
				}
			}
		}
		#endregion
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="safetaskanalysis.Organisation")]
	public partial class Organisation : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private bool _active;
		
		private int _idOrganisation;
		
		private string _nameEn;
		
		private string _nameFr;
		
		private int _regionID;
		
		private EntitySet<JSA_Attr> _JSA_Attr;
		
		private EntitySet<Supervisor> _supervisor;
		
		private EntityRef<Region> _region = new EntityRef<Region>();
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnActiveChanged();
		
		partial void OnActiveChanging(bool value);
		
		partial void OnIdOrganisationChanged();
		
		partial void OnIdOrganisationChanging(int value);
		
		partial void OnNameEnChanged();
		
		partial void OnNameEnChanging(string value);
		
		partial void OnNameFrChanged();
		
		partial void OnNameFrChanging(string value);
		
		partial void OnRegionIDChanged();
		
		partial void OnRegionIDChanging(int value);
		#endregion
		
		
		public Organisation()
		{
			_JSA_Attr = new EntitySet<JSA_Attr>(new Action<JSA_Attr>(this.JSA_Attr_Attach), new Action<JSA_Attr>(this.JSA_Attr_Detach));
			_supervisor = new EntitySet<Supervisor>(new Action<Supervisor>(this.Supervisor_Attach), new Action<Supervisor>(this.Supervisor_Detach));
			this.OnCreated();
		}
		
		[Column(Storage="_active", Name="Active", DbType="tinyint(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public bool Active
		{
			get
			{
				return this._active;
			}
			set
			{
				if ((_active != value))
				{
					this.OnActiveChanging(value);
					this.SendPropertyChanging();
					this._active = value;
					this.SendPropertyChanged("Active");
					this.OnActiveChanged();
				}
			}
		}
		
		[Column(Storage="_idOrganisation", Name="ID_Organisation", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int IdOrganisation
		{
			get
			{
				return this._idOrganisation;
			}
			set
			{
				if ((_idOrganisation != value))
				{
					this.OnIdOrganisationChanging(value);
					this.SendPropertyChanging();
					this._idOrganisation = value;
					this.SendPropertyChanged("IdOrganisation");
					this.OnIdOrganisationChanged();
				}
			}
		}
		
		[Column(Storage="_nameEn", Name="NameEN", DbType="varchar(50)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string NameEn
		{
			get
			{
				return this._nameEn;
			}
			set
			{
				if (((_nameEn == value) 
							== false))
				{
					this.OnNameEnChanging(value);
					this.SendPropertyChanging();
					this._nameEn = value;
					this.SendPropertyChanged("NameEn");
					this.OnNameEnChanged();
				}
			}
		}
		
		[Column(Storage="_nameFr", Name="NameFR", DbType="varchar(50)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string NameFr
		{
			get
			{
				return this._nameFr;
			}
			set
			{
				if (((_nameFr == value) 
							== false))
				{
					this.OnNameFrChanging(value);
					this.SendPropertyChanging();
					this._nameFr = value;
					this.SendPropertyChanged("NameFr");
					this.OnNameFrChanged();
				}
			}
		}
		
		[Column(Storage="_regionID", Name="Region_ID", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int RegionID
		{
			get
			{
				return this._regionID;
			}
			set
			{
				if ((_regionID != value))
				{
					this.OnRegionIDChanging(value);
					this.SendPropertyChanging();
					this._regionID = value;
					this.SendPropertyChanged("RegionID");
					this.OnRegionIDChanged();
				}
			}
		}
		
		#region Children
		[Association(Storage="_JSA_Attr", OtherKey="OrganisationID", ThisKey="IdOrganisation", Name="FK_JSA_Organisation")]
		[DebuggerNonUserCode()]
		public EntitySet<JSA_Attr> JSA_Attr
		{
			get
			{
				return this._JSA_Attr;
			}
			set
			{
				this._JSA_Attr = value;
			}
		}
		
		[Association(Storage="_supervisor", OtherKey="OrganisationID", ThisKey="IdOrganisation", Name="Fk_Org_ID")]
		[DebuggerNonUserCode()]
		public EntitySet<Supervisor> Supervisor
		{
			get
			{
				return this._supervisor;
			}
			set
			{
				this._supervisor = value;
			}
		}
		#endregion
		
		#region Parents
		[Association(Storage="_region", OtherKey="IdrEgion", ThisKey="RegionID", Name="FK_Region_ID", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public Region Region
		{
			get
			{
				return this._region.Entity;
			}
			set
			{
				if (((this._region.Entity == value) 
							== false))
				{
					if ((this._region.Entity != null))
					{
						Region previousRegion = this._region.Entity;
						this._region.Entity = null;
						previousRegion.Organisation.Remove(this);
					}
					this._region.Entity = value;
					if ((value != null))
					{
						value.Organisation.Add(this);
						_regionID = value.IdrEgion;
					}
					else
					{
						_regionID = default(int);
					}
				}
			}
		}
		#endregion
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		#region Attachment handlers
		private void JSA_Attr_Attach(JSA_Attr entity)
		{
			this.SendPropertyChanging();
			entity.Organisation = this;
		}
		
		private void JSA_Attr_Detach(JSA_Attr entity)
		{
			this.SendPropertyChanging();
			entity.Organisation = null;
		}
		
		private void Supervisor_Attach(Supervisor entity)
		{
			this.SendPropertyChanging();
			entity.Organisation = this;
		}
		
		private void Supervisor_Detach(Supervisor entity)
		{
			this.SendPropertyChanging();
			entity.Organisation = null;
		}
		#endregion
	}
	
	[Table(Name="safetaskanalysis.PreventiveMesure")]
	public partial class PreventiveMesure : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private int _idpReVmESure;
		
		private int _riskID;
		
		private EntitySet<PreventiveMesure_Attr> _PreventiveMesure_Attr;
		
		private EntityRef<AssociatedRisk> _associatedRisk = new EntityRef<AssociatedRisk>();
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnIDPreVMeSureChanged();
		
		partial void OnIDPreVMeSureChanging(int value);
		
		partial void OnRiskIDChanged();
		
		partial void OnRiskIDChanging(int value);
		#endregion
		
		
		public PreventiveMesure()
		{
			_PreventiveMesure_Attr = new EntitySet<PreventiveMesure_Attr>(new Action<PreventiveMesure_Attr>(this.PreventiveMesure_Attr_Attach), new Action<PreventiveMesure_Attr>(this.PreventiveMesure_Attr_Detach));
			this.OnCreated();
		}
		
		[Column(Storage="_idpReVmESure", Name="ID_PREV_MESURE", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int IDPreVMeSure
		{
			get
			{
				return this._idpReVmESure;
			}
			set
			{
				if ((_idpReVmESure != value))
				{
					this.OnIDPreVMeSureChanging(value);
					this.SendPropertyChanging();
					this._idpReVmESure = value;
					this.SendPropertyChanged("IDPreVMeSure");
					this.OnIDPreVMeSureChanged();
				}
			}
		}
		
		[Column(Storage="_riskID", Name="Risk_ID", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int RiskID
		{
			get
			{
				return this._riskID;
			}
			set
			{
				if ((_riskID != value))
				{
					this.OnRiskIDChanging(value);
					this.SendPropertyChanging();
					this._riskID = value;
					this.SendPropertyChanged("RiskID");
					this.OnRiskIDChanged();
				}
			}
		}
		
		#region Children
		[Association(Storage="_PreventiveMesure_Attr", OtherKey="PreVMeSureID", ThisKey="IDPreVMeSure", Name="FK_Attr_PrevMes")]
		[DebuggerNonUserCode()]
		public EntitySet<PreventiveMesure_Attr> PreventiveMesure_Attr
		{
			get
			{
				return this._PreventiveMesure_Attr;
			}
			set
			{
				this._PreventiveMesure_Attr = value;
			}
		}
		#endregion
		
		#region Parents
		[Association(Storage="_associatedRisk", OtherKey="IdaSsRisk", ThisKey="RiskID", Name="FK_PrevMes_AssRisk", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public AssociatedRisk AssociatedRisk
		{
			get
			{
				return this._associatedRisk.Entity;
			}
			set
			{
				if (((this._associatedRisk.Entity == value) 
							== false))
				{
					if ((this._associatedRisk.Entity != null))
					{
						AssociatedRisk previousAssociatedRisk = this._associatedRisk.Entity;
						this._associatedRisk.Entity = null;
						previousAssociatedRisk.PreventiveMesure.Remove(this);
					}
					this._associatedRisk.Entity = value;
					if ((value != null))
					{
						value.PreventiveMesure.Add(this);
						_riskID = value.IdaSsRisk;
					}
					else
					{
						_riskID = default(int);
					}
				}
			}
		}
		#endregion
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		#region Attachment handlers
		private void PreventiveMesure_Attr_Attach(PreventiveMesure_Attr entity)
		{
			this.SendPropertyChanging();
			entity.PreventiveMesure = this;
		}
		
		private void PreventiveMesure_Attr_Detach(PreventiveMesure_Attr entity)
		{
			this.SendPropertyChanging();
			entity.PreventiveMesure = null;
		}
		#endregion
	}
	
	[Table(Name="safetaskanalysis.PreventiveMesure_attr")]
	public partial class PreventiveMesure_Attr : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private bool _active;
		
		private string _description;
		
		private int _idprevmesureaTtr;
		
		private int _preVmESureID;
		
		private EntityRef<PreventiveMesure> _PreventiveMesure = new EntityRef<PreventiveMesure>();
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnActiveChanged();
		
		partial void OnActiveChanging(bool value);
		
		partial void OnDescriptionChanged();
		
		partial void OnDescriptionChanging(string value);
		
		partial void OnIdprevmesureaTtrChanged();
		
		partial void OnIdprevmesureaTtrChanging(int value);
		
		partial void OnPreVMeSureIDChanged();
		
		partial void OnPreVMeSureIDChanging(int value);
		#endregion
		
		
		public PreventiveMesure_Attr()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_active", Name="Active", DbType="tinyint(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public bool Active
		{
			get
			{
				return this._active;
			}
			set
			{
				if ((_active != value))
				{
					this.OnActiveChanging(value);
					this.SendPropertyChanging();
					this._active = value;
					this.SendPropertyChanged("Active");
					this.OnActiveChanged();
				}
			}
		}
		
		[Column(Storage="_description", Name="Description", DbType="varchar(500)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value) 
							== false))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[Column(Storage="_idprevmesureaTtr", Name="ID_PREV_MESURE_Attr", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int IdprevmesureaTtr
		{
			get
			{
				return this._idprevmesureaTtr;
			}
			set
			{
				if ((_idprevmesureaTtr != value))
				{
					this.OnIdprevmesureaTtrChanging(value);
					this.SendPropertyChanging();
					this._idprevmesureaTtr = value;
					this.SendPropertyChanged("IdprevmesureaTtr");
					this.OnIdprevmesureaTtrChanged();
				}
			}
		}
		
		[Column(Storage="_preVmESureID", Name="PREV_MESURE_ID", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int PreVMeSureID
		{
			get
			{
				return this._preVmESureID;
			}
			set
			{
				if ((_preVmESureID != value))
				{
					this.OnPreVMeSureIDChanging(value);
					this.SendPropertyChanging();
					this._preVmESureID = value;
					this.SendPropertyChanged("PreVMeSureID");
					this.OnPreVMeSureIDChanged();
				}
			}
		}
		
		#region Parents
		[Association(Storage="_PreventiveMesure", OtherKey="IDPreVMeSure", ThisKey="PreVMeSureID", Name="FK_Attr_PrevMes", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public PreventiveMesure PreventiveMesure
		{
			get
			{
				return this._PreventiveMesure.Entity;
			}
			set
			{
				if (((this._PreventiveMesure.Entity == value) 
							== false))
				{
					if ((this._PreventiveMesure.Entity != null))
					{
						PreventiveMesure previousPreventiveMesure = this._PreventiveMesure.Entity;
						this._PreventiveMesure.Entity = null;
						previousPreventiveMesure.PreventiveMesure_Attr.Remove(this);
					}
					this._PreventiveMesure.Entity = value;
					if ((value != null))
					{
						value.PreventiveMesure_Attr.Add(this);
						_preVmESureID = value.IDPreVMeSure;
					}
					else
					{
						_preVmESureID = default(int);
					}
				}
			}
		}
		#endregion
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="safetaskanalysis.region")]
	public partial class Region : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private bool _active;
		
		private int _idrEgion;
		
		private string _nameEn;
		
		private string _nameFr;
		
		private EntitySet<JSA_Attr> _JSA_Attr;
		
		private EntitySet<Organisation> _Organisation;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnActiveChanged();
		
		partial void OnActiveChanging(bool value);
		
		partial void OnIdrEgionChanged();
		
		partial void OnIdrEgionChanging(int value);
		
		partial void OnNameEnChanged();
		
		partial void OnNameEnChanging(string value);
		
		partial void OnNameFrChanged();
		
		partial void OnNameFrChanging(string value);
		#endregion
		
		
		public Region()
		{
			_JSA_Attr = new EntitySet<JSA_Attr>(new Action<JSA_Attr>(this.JSA_Attr_Attach), new Action<JSA_Attr>(this.JSA_Attr_Detach));
			_Organisation = new EntitySet<Organisation>(new Action<Organisation>(this.Organisation_Attach), new Action<Organisation>(this.Organisation_Detach));
			this.OnCreated();
		}
		
		[Column(Storage="_active", Name="Active", DbType="tinyint(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public bool Active
		{
			get
			{
				return this._active;
			}
			set
			{
				if ((_active != value))
				{
					this.OnActiveChanging(value);
					this.SendPropertyChanging();
					this._active = value;
					this.SendPropertyChanged("Active");
					this.OnActiveChanged();
				}
			}
		}
		
		[Column(Storage="_idrEgion", Name="ID_Region", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int IdrEgion
		{
			get
			{
				return this._idrEgion;
			}
			set
			{
				if ((_idrEgion != value))
				{
					this.OnIdrEgionChanging(value);
					this.SendPropertyChanging();
					this._idrEgion = value;
					this.SendPropertyChanged("IdrEgion");
					this.OnIdrEgionChanged();
				}
			}
		}
		
		[Column(Storage="_nameEn", Name="NameEN", DbType="varchar(50)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string NameEn
		{
			get
			{
				return this._nameEn;
			}
			set
			{
				if (((_nameEn == value) 
							== false))
				{
					this.OnNameEnChanging(value);
					this.SendPropertyChanging();
					this._nameEn = value;
					this.SendPropertyChanged("NameEn");
					this.OnNameEnChanged();
				}
			}
		}
		
		[Column(Storage="_nameFr", Name="NameFR", DbType="varchar(50)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string NameFr
		{
			get
			{
				return this._nameFr;
			}
			set
			{
				if (((_nameFr == value) 
							== false))
				{
					this.OnNameFrChanging(value);
					this.SendPropertyChanging();
					this._nameFr = value;
					this.SendPropertyChanged("NameFr");
					this.OnNameFrChanged();
				}
			}
		}
		
		#region Children
		[Association(Storage="_JSA_Attr", OtherKey="RegionID", ThisKey="IdrEgion", Name="FK_JSA_Region")]
		[DebuggerNonUserCode()]
		public EntitySet<JSA_Attr> JSA_Attr
		{
			get
			{
				return this._JSA_Attr;
			}
			set
			{
				this._JSA_Attr = value;
			}
		}
		
		[Association(Storage="_Organisation", OtherKey="RegionID", ThisKey="IdrEgion", Name="FK_Region_ID")]
		[DebuggerNonUserCode()]
		public EntitySet<Organisation> Organisation
		{
			get
			{
				return this._Organisation;
			}
			set
			{
				this._Organisation = value;
			}
		}
		#endregion
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		#region Attachment handlers
		private void JSA_Attr_Attach(JSA_Attr entity)
		{
			this.SendPropertyChanging();
			entity.Region = this;
		}
		
		private void JSA_Attr_Detach(JSA_Attr entity)
		{
			this.SendPropertyChanging();
			entity.Region = null;
		}
		
		private void Organisation_Attach(Organisation entity)
		{
			this.SendPropertyChanging();
			entity.Region = this;
		}
		
		private void Organisation_Detach(Organisation entity)
		{
			this.SendPropertyChanging();
			entity.Region = null;
		}
		#endregion
	}
	
	[Table(Name="safetaskanalysis.supervisor")]
	public partial class Supervisor : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private bool _active;
		
		private string _description;
		
		private int _idsUpervisor;
		
		private int _OrganisationID;
		
		private EntitySet<JSA_Attr> _JSA_Attr;
		
		private EntityRef<Organisation> _Organisation = new EntityRef<Organisation>();
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnActiveChanged();
		
		partial void OnActiveChanging(bool value);
		
		partial void OnDescriptionChanged();
		
		partial void OnDescriptionChanging(string value);
		
		partial void OnIdsUpervisorChanged();
		
		partial void OnIdsUpervisorChanging(int value);
		
		partial void OnOrganisationIDChanged();
		
		partial void OnOrganisationIDChanging(int value);
		#endregion
		
		
		public Supervisor()
		{
			_JSA_Attr = new EntitySet<JSA_Attr>(new Action<JSA_Attr>(this.JSA_Attr_Attach), new Action<JSA_Attr>(this.JSA_Attr_Detach));
			this.OnCreated();
		}
		
		[Column(Storage="_active", Name="Active", DbType="tinyint(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public bool Active
		{
			get
			{
				return this._active;
			}
			set
			{
				if ((_active != value))
				{
					this.OnActiveChanging(value);
					this.SendPropertyChanging();
					this._active = value;
					this.SendPropertyChanged("Active");
					this.OnActiveChanged();
				}
			}
		}
		
		[Column(Storage="_description", Name="Description", DbType="varchar(100)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value) 
							== false))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[Column(Storage="_idsUpervisor", Name="ID_Supervisor", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int IdsUpervisor
		{
			get
			{
				return this._idsUpervisor;
			}
			set
			{
				if ((_idsUpervisor != value))
				{
					this.OnIdsUpervisorChanging(value);
					this.SendPropertyChanging();
					this._idsUpervisor = value;
					this.SendPropertyChanged("IdsUpervisor");
					this.OnIdsUpervisorChanged();
				}
			}
		}
		
		[Column(Storage="_OrganisationID", Name="Organisation_ID", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int OrganisationID
		{
			get
			{
				return this._OrganisationID;
			}
			set
			{
				if ((_OrganisationID != value))
				{
					this.OnOrganisationIDChanging(value);
					this.SendPropertyChanging();
					this._OrganisationID = value;
					this.SendPropertyChanged("OrganisationID");
					this.OnOrganisationIDChanged();
				}
			}
		}
		
		#region Children
		[Association(Storage="_JSA_Attr", OtherKey="SupervisorID", ThisKey="IdsUpervisor", Name="FK_JSA_Supervisor")]
		[DebuggerNonUserCode()]
		public EntitySet<JSA_Attr> JSA_Attr
		{
			get
			{
				return this._JSA_Attr;
			}
			set
			{
				this._JSA_Attr = value;
			}
		}
		#endregion
		
		#region Parents
		[Association(Storage="_Organisation", OtherKey="IdOrganisation", ThisKey="OrganisationID", Name="Fk_Org_ID", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public Organisation Organisation
		{
			get
			{
				return this._Organisation.Entity;
			}
			set
			{
				if (((this._Organisation.Entity == value) 
							== false))
				{
					if ((this._Organisation.Entity != null))
					{
						Organisation previousOrganisation = this._Organisation.Entity;
						this._Organisation.Entity = null;
						previousOrganisation.Supervisor.Remove(this);
					}
					this._Organisation.Entity = value;
					if ((value != null))
					{
						value.Supervisor.Add(this);
						_OrganisationID = value.IdOrganisation;
					}
					else
					{
						_OrganisationID = default(int);
					}
				}
			}
		}
		#endregion
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		#region Attachment handlers
		private void JSA_Attr_Attach(JSA_Attr entity)
		{
			this.SendPropertyChanging();
			entity.Supervisor = this;
		}
		
		private void JSA_Attr_Detach(JSA_Attr entity)
		{
			this.SendPropertyChanging();
			entity.Supervisor = null;
		}
		#endregion
	}
	
	[Table(Name="safetaskanalysis.task")]
	public partial class Task : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private int _idtAsk;
		
		private int _JSAid;
		
		private EntitySet<AssociatedRisk> _associatedRisk;
		
		private EntitySet<Task_Attr> _Task_Attr;
		
		private EntityRef<JSA> _JSA = new EntityRef<JSA>();
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnIdtAskChanged();
		
		partial void OnIdtAskChanging(int value);
		
		partial void OnJSAidChanged();
		
		partial void OnJSAidChanging(int value);
		#endregion
		
		
		public Task()
		{
			_associatedRisk = new EntitySet<AssociatedRisk>(new Action<AssociatedRisk>(this.AssociatedRisk_Attach), new Action<AssociatedRisk>(this.AssociatedRisk_Detach));
			_Task_Attr = new EntitySet<Task_Attr>(new Action<Task_Attr>(this.Task_Attr_Attach), new Action<Task_Attr>(this.Task_Attr_Detach));
			this.OnCreated();
		}
		
		[Column(Storage="_idtAsk", Name="ID_Task", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int IdtAsk
		{
			get
			{
				return this._idtAsk;
			}
			set
			{
				if ((_idtAsk != value))
				{
					this.OnIdtAskChanging(value);
					this.SendPropertyChanging();
					this._idtAsk = value;
					this.SendPropertyChanged("IdtAsk");
					this.OnIdtAskChanged();
				}
			}
		}
		
		[Column(Storage="_JSAid", Name="JSA_ID", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int JSAid
		{
			get
			{
				return this._JSAid;
			}
			set
			{
				if ((_JSAid != value))
				{
					this.OnJSAidChanging(value);
					this.SendPropertyChanging();
					this._JSAid = value;
					this.SendPropertyChanged("JSAid");
					this.OnJSAidChanged();
				}
			}
		}
		
		#region Children
		[Association(Storage="_associatedRisk", OtherKey="TaskID", ThisKey="IdtAsk", Name="FK_AssRisk_Task")]
		[DebuggerNonUserCode()]
		public EntitySet<AssociatedRisk> AssociatedRisk
		{
			get
			{
				return this._associatedRisk;
			}
			set
			{
				this._associatedRisk = value;
			}
		}
		
		[Association(Storage="_Task_Attr", OtherKey="TaskID", ThisKey="IdtAsk", Name="FK_Attr_Task")]
		[DebuggerNonUserCode()]
		public EntitySet<Task_Attr> Task_Attr
		{
			get
			{
				return this._Task_Attr;
			}
			set
			{
				this._Task_Attr = value;
			}
		}
		#endregion
		
		#region Parents
		[Association(Storage="_JSA", OtherKey="IDJSA", ThisKey="JSAid", Name="FK_Task_JSA", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public JSA JSA
		{
			get
			{
				return this._JSA.Entity;
			}
			set
			{
				if (((this._JSA.Entity == value) 
							== false))
				{
					if ((this._JSA.Entity != null))
					{
						JSA previousJSA = this._JSA.Entity;
						this._JSA.Entity = null;
						previousJSA.Task.Remove(this);
					}
					this._JSA.Entity = value;
					if ((value != null))
					{
						value.Task.Add(this);
						_JSAid = value.IDJSA;
					}
					else
					{
						_JSAid = default(int);
					}
				}
			}
		}
		#endregion
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		#region Attachment handlers
		private void AssociatedRisk_Attach(AssociatedRisk entity)
		{
			this.SendPropertyChanging();
			entity.Task = this;
		}
		
		private void AssociatedRisk_Detach(AssociatedRisk entity)
		{
			this.SendPropertyChanging();
			entity.Task = null;
		}
		
		private void Task_Attr_Attach(Task_Attr entity)
		{
			this.SendPropertyChanging();
			entity.Task = this;
		}
		
		private void Task_Attr_Detach(Task_Attr entity)
		{
			this.SendPropertyChanging();
			entity.Task = null;
		}
		#endregion
	}
	
	[Table(Name="safetaskanalysis.task_attr")]
	public partial class Task_Attr : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private bool _active;
		
		private string _description;
		
		private int _idTask_Attr;
		
		private int _orderNo;
		
		private int _taskID;
		
		private EntityRef<Task> _task = new EntityRef<Task>();
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnActiveChanged();
		
		partial void OnActiveChanging(bool value);
		
		partial void OnDescriptionChanged();
		
		partial void OnDescriptionChanging(string value);
		
		partial void OnIdTask_AttrChanged();
		
		partial void OnIdTask_AttrChanging(int value);
		
		partial void OnOrderNoChanged();
		
		partial void OnOrderNoChanging(int value);
		
		partial void OnTaskIDChanged();
		
		partial void OnTaskIDChanging(int value);
		#endregion
		
		
		public Task_Attr()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_active", Name="Active", DbType="tinyint(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public bool Active
		{
			get
			{
				return this._active;
			}
			set
			{
				if ((_active != value))
				{
					this.OnActiveChanging(value);
					this.SendPropertyChanging();
					this._active = value;
					this.SendPropertyChanged("Active");
					this.OnActiveChanged();
				}
			}
		}
		
		[Column(Storage="_description", Name="Description", DbType="varchar(100)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value) 
							== false))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[Column(Storage="_idTask_Attr", Name="ID_Task_Attr", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int IdTask_Attr
		{
			get
			{
				return this._idTask_Attr;
			}
			set
			{
				if ((_idTask_Attr != value))
				{
					this.OnIdTask_AttrChanging(value);
					this.SendPropertyChanging();
					this._idTask_Attr = value;
					this.SendPropertyChanged("IdTask_Attr");
					this.OnIdTask_AttrChanged();
				}
			}
		}
		
		[Column(Storage="_orderNo", Name="OrderNo", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int OrderNo
		{
			get
			{
				return this._orderNo;
			}
			set
			{
				if ((_orderNo != value))
				{
					this.OnOrderNoChanging(value);
					this.SendPropertyChanging();
					this._orderNo = value;
					this.SendPropertyChanged("OrderNo");
					this.OnOrderNoChanged();
				}
			}
		}
		
		[Column(Storage="_taskID", Name="Task_ID", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int TaskID
		{
			get
			{
				return this._taskID;
			}
			set
			{
				if ((_taskID != value))
				{
					this.OnTaskIDChanging(value);
					this.SendPropertyChanging();
					this._taskID = value;
					this.SendPropertyChanged("TaskID");
					this.OnTaskIDChanged();
				}
			}
		}
		
		#region Parents
		[Association(Storage="_task", OtherKey="IdtAsk", ThisKey="TaskID", Name="FK_Attr_Task", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public Task Task
		{
			get
			{
				return this._task.Entity;
			}
			set
			{
				if (((this._task.Entity == value) 
							== false))
				{
					if ((this._task.Entity != null))
					{
						Task previousTask = this._task.Entity;
						this._task.Entity = null;
						previousTask.Task_Attr.Remove(this);
					}
					this._task.Entity = value;
					if ((value != null))
					{
						value.Task_Attr.Add(this);
						_taskID = value.IdtAsk;
					}
					else
					{
						_taskID = default(int);
					}
				}
			}
		}
		#endregion
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="safetaskanalysis.workenvironment")]
	public partial class WorkEnvironment : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<bool> _active;
		
		private int _idwOrkEnv;
		
		private string _nameEn;
		
		private string _nameFr;
		
		private EntitySet<JSA_Attr> _JSA_Attr;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnActiveChanged();
		
		partial void OnActiveChanging(System.Nullable<bool> value);
		
		partial void OnIdwOrkEnvChanged();
		
		partial void OnIdwOrkEnvChanging(int value);
		
		partial void OnNameEnChanged();
		
		partial void OnNameEnChanging(string value);
		
		partial void OnNameFrChanged();
		
		partial void OnNameFrChanging(string value);
		#endregion
		
		
		public WorkEnvironment()
		{
			_JSA_Attr = new EntitySet<JSA_Attr>(new Action<JSA_Attr>(this.JSA_Attr_Attach), new Action<JSA_Attr>(this.JSA_Attr_Detach));
			this.OnCreated();
		}
		
		[Column(Storage="_active", Name="Active", DbType="tinyint(1)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<bool> Active
		{
			get
			{
				return this._active;
			}
			set
			{
				if ((_active != value))
				{
					this.OnActiveChanging(value);
					this.SendPropertyChanging();
					this._active = value;
					this.SendPropertyChanged("Active");
					this.OnActiveChanged();
				}
			}
		}
		
		[Column(Storage="_idwOrkEnv", Name="ID_WorkEnv", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int IdwOrkEnv
		{
			get
			{
				return this._idwOrkEnv;
			}
			set
			{
				if ((_idwOrkEnv != value))
				{
					this.OnIdwOrkEnvChanging(value);
					this.SendPropertyChanging();
					this._idwOrkEnv = value;
					this.SendPropertyChanged("IdwOrkEnv");
					this.OnIdwOrkEnvChanged();
				}
			}
		}
		
		[Column(Storage="_nameEn", Name="NameEN", DbType="varchar(50)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string NameEn
		{
			get
			{
				return this._nameEn;
			}
			set
			{
				if (((_nameEn == value) 
							== false))
				{
					this.OnNameEnChanging(value);
					this.SendPropertyChanging();
					this._nameEn = value;
					this.SendPropertyChanged("NameEn");
					this.OnNameEnChanged();
				}
			}
		}
		
		[Column(Storage="_nameFr", Name="NameFR", DbType="varchar(50)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string NameFr
		{
			get
			{
				return this._nameFr;
			}
			set
			{
				if (((_nameFr == value) 
							== false))
				{
					this.OnNameFrChanging(value);
					this.SendPropertyChanging();
					this._nameFr = value;
					this.SendPropertyChanged("NameFr");
					this.OnNameFrChanged();
				}
			}
		}
		
		#region Children
		[Association(Storage="_JSA_Attr", OtherKey="WorkEnvID", ThisKey="IdwOrkEnv", Name="FK_JSA_WorkEnv")]
		[DebuggerNonUserCode()]
		public EntitySet<JSA_Attr> JSA_Attr
		{
			get
			{
				return this._JSA_Attr;
			}
			set
			{
				this._JSA_Attr = value;
			}
		}
		#endregion
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		#region Attachment handlers
		private void JSA_Attr_Attach(JSA_Attr entity)
		{
			this.SendPropertyChanging();
			entity.WorkEnvironment = this;
		}
		
		private void JSA_Attr_Detach(JSA_Attr entity)
		{
			this.SendPropertyChanging();
			entity.WorkEnvironment = null;
		}
		#endregion
	}
}
