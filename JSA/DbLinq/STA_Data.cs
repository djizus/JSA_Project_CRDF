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
namespace STA_Data
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
	
	
	public partial class SafeTaskAnalysis : DataContext
	{
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		#endregion
		
		
		public SafeTaskAnalysis(string connectionString) : 
				base(connectionString)
		{
			this.OnCreated();
		}
		
		public SafeTaskAnalysis(string connection, MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			this.OnCreated();
		}
		
		public SafeTaskAnalysis(IDbConnection connection, MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			this.OnCreated();
		}
		
		public Table<AdMIn> AdMIn
		{
			get
			{
				return this.GetTable<AdMIn>();
			}
		}
		
		public Table<AssociatedRisk> AssociatedRisk
		{
			get
			{
				return this.GetTable<AssociatedRisk>();
			}
		}
		
		public Table<AssociatedRiskAtTR> AssociatedRiskAtTR
		{
			get
			{
				return this.GetTable<AssociatedRiskAtTR>();
			}
		}
		
		public Table<Branch> Branch
		{
			get
			{
				return this.GetTable<Branch>();
			}
		}
		
		public Table<JSa> JSa
		{
			get
			{
				return this.GetTable<JSa>();
			}
		}
		
		public Table<JSaAtTR> JSaAtTR
		{
			get
			{
				return this.GetTable<JSaAtTR>();
			}
		}
		
		public Table<OrganIsaTIon> OrganIsaTIon
		{
			get
			{
				return this.GetTable<OrganIsaTIon>();
			}
		}
		
		public Table<PreventiveMeSure> PreventiveMeSure
		{
			get
			{
				return this.GetTable<PreventiveMeSure>();
			}
		}
		
		public Table<PreventiveMeSureAtTR> PreventiveMeSureAtTR
		{
			get
			{
				return this.GetTable<PreventiveMeSureAtTR>();
			}
		}
		
		public Table<Region> Region
		{
			get
			{
				return this.GetTable<Region>();
			}
		}
		
		public Table<Supervisor> Supervisor
		{
			get
			{
				return this.GetTable<Supervisor>();
			}
		}
		
		public Table<Task> Task
		{
			get
			{
				return this.GetTable<Task>();
			}
		}
		
		public Table<TaskAtTR> TaskAtTR
		{
			get
			{
				return this.GetTable<TaskAtTR>();
			}
		}
		
		public Table<WorkEnvironment> WorkEnvironment
		{
			get
			{
				return this.GetTable<WorkEnvironment>();
			}
		}
	}
	
	#region Start MONO_STRICT
#if MONO_STRICT

	public partial class SafeTaskAnalysis
	{
		
		public SafeTaskAnalysis(IDbConnection connection) : 
				base(connection)
		{
			this.OnCreated();
		}
	}
	#region End MONO_STRICT
	#endregion
#else     // MONO_STRICT
	
	public partial class SafeTaskAnalysis
	{
		
		public SafeTaskAnalysis(IDbConnection connection) : 
				base(connection, new DbLinq.MySql.MySqlVendor())
		{
			this.OnCreated();
		}
		
		public SafeTaskAnalysis(IDbConnection connection, IVendor sqlDialect) : 
				base(connection, sqlDialect)
		{
			this.OnCreated();
		}
		
		public SafeTaskAnalysis(IDbConnection connection, MappingSource mappingSource, IVendor sqlDialect) : 
				base(connection, mappingSource, sqlDialect)
		{
			this.OnCreated();
		}
	}
	#region End Not MONO_STRICT
	#endregion
#endif     // MONO_STRICT
	#endregion
	
	[Table(Name="safetaskanalysis.admin")]
	public partial class AdMIn : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private int _idaDmin;
		
		private string _login;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnIDAdminChanged();
		
		partial void OnIDAdminChanging(int value);
		
		partial void OnLoginChanged();
		
		partial void OnLoginChanging(string value);
		#endregion
		
		
		public AdMIn()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_idaDmin", Name="idAdmin", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int IDAdmin
		{
			get
			{
				return this._idaDmin;
			}
			set
			{
				if ((_idaDmin != value))
				{
					this.OnIDAdminChanging(value);
					this.SendPropertyChanging();
					this._idaDmin = value;
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
		
		private EntitySet<AssociatedRiskAtTR> _associatedRiskAtTr;
		
		private EntitySet<PreventiveMeSure> _preventiveMeSure;
		
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
			_associatedRiskAtTr = new EntitySet<AssociatedRiskAtTR>(new Action<AssociatedRiskAtTR>(this.AssociatedRiskAtTR_Attach), new Action<AssociatedRiskAtTR>(this.AssociatedRiskAtTR_Detach));
			_preventiveMeSure = new EntitySet<PreventiveMeSure>(new Action<PreventiveMeSure>(this.PreventiveMeSure_Attach), new Action<PreventiveMeSure>(this.PreventiveMeSure_Detach));
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
		[Association(Storage="_associatedRiskAtTr", OtherKey="AssRiskID", ThisKey="IdaSsRisk", Name="FK_Attr_AssRisk")]
		[DebuggerNonUserCode()]
		public EntitySet<AssociatedRiskAtTR> AssociatedRiskAtTR
		{
			get
			{
				return this._associatedRiskAtTr;
			}
			set
			{
				this._associatedRiskAtTr = value;
			}
		}
		
		[Association(Storage="_preventiveMeSure", OtherKey="RiskID", ThisKey="IdaSsRisk", Name="FK_PrevMes_AssRisk")]
		[DebuggerNonUserCode()]
		public EntitySet<PreventiveMeSure> PreventiveMeSure
		{
			get
			{
				return this._preventiveMeSure;
			}
			set
			{
				this._preventiveMeSure = value;
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
		private void AssociatedRiskAtTR_Attach(AssociatedRiskAtTR entity)
		{
			this.SendPropertyChanging();
			entity.AssociatedRisk = this;
		}
		
		private void AssociatedRiskAtTR_Detach(AssociatedRiskAtTR entity)
		{
			this.SendPropertyChanging();
			entity.AssociatedRisk = null;
		}
		
		private void PreventiveMeSure_Attach(PreventiveMeSure entity)
		{
			this.SendPropertyChanging();
			entity.AssociatedRisk = this;
		}
		
		private void PreventiveMeSure_Detach(PreventiveMeSure entity)
		{
			this.SendPropertyChanging();
			entity.AssociatedRisk = null;
		}
		#endregion
	}
	
	[Table(Name="safetaskanalysis.associatedrisk_attr")]
	public partial class AssociatedRiskAtTR : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private sbyte _active;
		
		private int _assRiskID;
		
		private string _descriptionRisk;
		
		private int _idaSsRiskAttr;
		
		private EntityRef<AssociatedRisk> _associatedRisk = new EntityRef<AssociatedRisk>();
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnActiveChanged();
		
		partial void OnActiveChanging(sbyte value);
		
		partial void OnAssRiskIDChanged();
		
		partial void OnAssRiskIDChanging(int value);
		
		partial void OnDescriptionRiskChanged();
		
		partial void OnDescriptionRiskChanging(string value);
		
		partial void OnIdaSsRiskAttrChanged();
		
		partial void OnIdaSsRiskAttrChanging(int value);
		#endregion
		
		
		public AssociatedRiskAtTR()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_active", Name="Active", DbType="tinyint(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public sbyte Active
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
						previousAssociatedRisk.AssociatedRiskAtTR.Remove(this);
					}
					this._associatedRisk.Entity = value;
					if ((value != null))
					{
						value.AssociatedRiskAtTR.Add(this);
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
		
		private EntitySet<JSaAtTR> _jsAAtTr;
		
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
			_jsAAtTr = new EntitySet<JSaAtTR>(new Action<JSaAtTR>(this.JSaAtTR_Attach), new Action<JSaAtTR>(this.JSaAtTR_Detach));
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
		[Association(Storage="_jsAAtTr", OtherKey="BranchID", ThisKey="IdbRanch", Name="FK_JSA_Branch")]
		[DebuggerNonUserCode()]
		public EntitySet<JSaAtTR> JSaAtTR
		{
			get
			{
				return this._jsAAtTr;
			}
			set
			{
				this._jsAAtTr = value;
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
		private void JSaAtTR_Attach(JSaAtTR entity)
		{
			this.SendPropertyChanging();
			entity.Branch = this;
		}
		
		private void JSaAtTR_Detach(JSaAtTR entity)
		{
			this.SendPropertyChanging();
			entity.Branch = null;
		}
		#endregion
	}
	
	[Table(Name="safetaskanalysis.jsa")]
	public partial class JSa : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private sbyte _active;
		
		private int _idjsA;
		
		private EntitySet<JSaAtTR> _jsAAtTr;
		
		private EntitySet<Task> _task;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnActiveChanged();
		
		partial void OnActiveChanging(sbyte value);
		
		partial void OnIDJSaChanged();
		
		partial void OnIDJSaChanging(int value);
		#endregion
		
		
		public JSa()
		{
			_jsAAtTr = new EntitySet<JSaAtTR>(new Action<JSaAtTR>(this.JSaAtTR_Attach), new Action<JSaAtTR>(this.JSaAtTR_Detach));
			_task = new EntitySet<Task>(new Action<Task>(this.Task_Attach), new Action<Task>(this.Task_Detach));
			this.OnCreated();
		}
		
		[Column(Storage="_active", Name="Active", DbType="tinyint(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public sbyte Active
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
		
		[Column(Storage="_idjsA", Name="ID_JSA", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int IDJSa
		{
			get
			{
				return this._idjsA;
			}
			set
			{
				if ((_idjsA != value))
				{
					this.OnIDJSaChanging(value);
					this.SendPropertyChanging();
					this._idjsA = value;
					this.SendPropertyChanged("IDJSa");
					this.OnIDJSaChanged();
				}
			}
		}
		
		#region Children
		[Association(Storage="_jsAAtTr", OtherKey="JSaid", ThisKey="IDJSa", Name="FK_JSA_ID")]
		[DebuggerNonUserCode()]
		public EntitySet<JSaAtTR> JSaAtTR
		{
			get
			{
				return this._jsAAtTr;
			}
			set
			{
				this._jsAAtTr = value;
			}
		}
		
		[Association(Storage="_task", OtherKey="JSaid", ThisKey="IDJSa", Name="FK_Task_JSA")]
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
		private void JSaAtTR_Attach(JSaAtTR entity)
		{
			this.SendPropertyChanging();
			entity.JSa = this;
		}
		
		private void JSaAtTR_Detach(JSaAtTR entity)
		{
			this.SendPropertyChanging();
			entity.JSa = null;
		}
		
		private void Task_Attach(Task entity)
		{
			this.SendPropertyChanging();
			entity.JSa = this;
		}
		
		private void Task_Detach(Task entity)
		{
			this.SendPropertyChanging();
			entity.JSa = null;
		}
		#endregion
	}
	
	[Table(Name="safetaskanalysis.jsa_attr")]
	public partial class JSaAtTR : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private sbyte _active;
		
		private string _associatedDoc;
		
		private sbyte _blouse;
		
		private sbyte _boots;
		
		private int _branchID;
		
		private sbyte _breathingMask;
		
		private string _createdBy;
		
		private System.DateTime _creationDate;
		
		private int _currentSaveStage;
		
		private sbyte _face;
		
		private sbyte _gloves;
		
		private sbyte _goggles;
		
		private sbyte _headcover;
		
		private sbyte _hearPlugs;
		
		private sbyte _helmet;
		
		private int _idjsaaTtr;
		
		private string _infoGen;
		
		private sbyte _item;
		
		private int _jsAid;
		
		private string _modifiedBy;
		
		private System.DateTime _modifiedDate;
		
		private int _organisationID;
		
		private int _regionID;
		
		private int _supervisorID;
		
		private string _taskName;
		
		private int _workEnvID;
		
		private EntityRef<Branch> _branch = new EntityRef<Branch>();
		
		private EntityRef<JSa> _jsA = new EntityRef<JSa>();
		
		private EntityRef<OrganIsaTIon> _organIsaTiOn = new EntityRef<OrganIsaTIon>();
		
		private EntityRef<Region> _region = new EntityRef<Region>();
		
		private EntityRef<Supervisor> _supervisor = new EntityRef<Supervisor>();
		
		private EntityRef<WorkEnvironment> _workEnvironment = new EntityRef<WorkEnvironment>();
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnActiveChanged();
		
		partial void OnActiveChanging(sbyte value);
		
		partial void OnAssociatedDocChanged();
		
		partial void OnAssociatedDocChanging(string value);
		
		partial void OnBlouseChanged();
		
		partial void OnBlouseChanging(sbyte value);
		
		partial void OnBootsChanged();
		
		partial void OnBootsChanging(sbyte value);
		
		partial void OnBranchIDChanged();
		
		partial void OnBranchIDChanging(int value);
		
		partial void OnBreathingMaskChanged();
		
		partial void OnBreathingMaskChanging(sbyte value);
		
		partial void OnCreatedByChanged();
		
		partial void OnCreatedByChanging(string value);
		
		partial void OnCreationDateChanged();
		
		partial void OnCreationDateChanging(System.DateTime value);
		
		partial void OnCurrentSaveStageChanged();
		
		partial void OnCurrentSaveStageChanging(int value);
		
		partial void OnFaceChanged();
		
		partial void OnFaceChanging(sbyte value);
		
		partial void OnGlovesChanged();
		
		partial void OnGlovesChanging(sbyte value);
		
		partial void OnGogglesChanged();
		
		partial void OnGogglesChanging(sbyte value);
		
		partial void OnHeadcoverChanged();
		
		partial void OnHeadcoverChanging(sbyte value);
		
		partial void OnHearPlugsChanged();
		
		partial void OnHearPlugsChanging(sbyte value);
		
		partial void OnHelmetChanged();
		
		partial void OnHelmetChanging(sbyte value);
		
		partial void OnIdjsaaTtrChanged();
		
		partial void OnIdjsaaTtrChanging(int value);
		
		partial void OnInfoGenChanged();
		
		partial void OnInfoGenChanging(string value);
		
		partial void OnItemChanged();
		
		partial void OnItemChanging(sbyte value);
		
		partial void OnJSaidChanged();
		
		partial void OnJSaidChanging(int value);
		
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
		
		
		public JSaAtTR()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_active", Name="Active", DbType="tinyint(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public sbyte Active
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
		public sbyte Blouse
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
		public sbyte Boots
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
		public sbyte BreathingMask
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
		public sbyte Face
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
		public sbyte Gloves
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
		public sbyte Goggles
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
		public sbyte Headcover
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
		public sbyte HearPlugs
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
		public sbyte Helmet
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
		
		[Column(Storage="_idjsaaTtr", Name="ID_JSA_Attr", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int IdjsaaTtr
		{
			get
			{
				return this._idjsaaTtr;
			}
			set
			{
				if ((_idjsaaTtr != value))
				{
					this.OnIdjsaaTtrChanging(value);
					this.SendPropertyChanging();
					this._idjsaaTtr = value;
					this.SendPropertyChanged("IdjsaaTtr");
					this.OnIdjsaaTtrChanged();
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
		public sbyte Item
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
		
		[Column(Storage="_jsAid", Name="JSA_ID", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int JSaid
		{
			get
			{
				return this._jsAid;
			}
			set
			{
				if ((_jsAid != value))
				{
					this.OnJSaidChanging(value);
					this.SendPropertyChanging();
					this._jsAid = value;
					this.SendPropertyChanged("JSaid");
					this.OnJSaidChanged();
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
		
		[Column(Storage="_organisationID", Name="Organisation_ID", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int OrganisationID
		{
			get
			{
				return this._organisationID;
			}
			set
			{
				if ((_organisationID != value))
				{
					this.OnOrganisationIDChanging(value);
					this.SendPropertyChanging();
					this._organisationID = value;
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
						previousBranch.JSaAtTR.Remove(this);
					}
					this._branch.Entity = value;
					if ((value != null))
					{
						value.JSaAtTR.Add(this);
						_branchID = value.IdbRanch;
					}
					else
					{
						_branchID = default(int);
					}
				}
			}
		}
		
		[Association(Storage="_jsA", OtherKey="IDJSa", ThisKey="JSaid", Name="FK_JSA_ID", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public JSa JSa
		{
			get
			{
				return this._jsA.Entity;
			}
			set
			{
				if (((this._jsA.Entity == value) 
							== false))
				{
					if ((this._jsA.Entity != null))
					{
						JSa previousJSa = this._jsA.Entity;
						this._jsA.Entity = null;
						previousJSa.JSaAtTR.Remove(this);
					}
					this._jsA.Entity = value;
					if ((value != null))
					{
						value.JSaAtTR.Add(this);
						_jsAid = value.IDJSa;
					}
					else
					{
						_jsAid = default(int);
					}
				}
			}
		}
		
		[Association(Storage="_organIsaTiOn", OtherKey="IdoRganisation", ThisKey="OrganisationID", Name="FK_JSA_Organisation", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public OrganIsaTIon OrganIsaTIon
		{
			get
			{
				return this._organIsaTiOn.Entity;
			}
			set
			{
				if (((this._organIsaTiOn.Entity == value) 
							== false))
				{
					if ((this._organIsaTiOn.Entity != null))
					{
						OrganIsaTIon previousOrganIsaTIon = this._organIsaTiOn.Entity;
						this._organIsaTiOn.Entity = null;
						previousOrganIsaTIon.JSaAtTR.Remove(this);
					}
					this._organIsaTiOn.Entity = value;
					if ((value != null))
					{
						value.JSaAtTR.Add(this);
						_organisationID = value.IdoRganisation;
					}
					else
					{
						_organisationID = default(int);
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
						previousRegion.JSaAtTR.Remove(this);
					}
					this._region.Entity = value;
					if ((value != null))
					{
						value.JSaAtTR.Add(this);
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
						previousSupervisor.JSaAtTR.Remove(this);
					}
					this._supervisor.Entity = value;
					if ((value != null))
					{
						value.JSaAtTR.Add(this);
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
						previousWorkEnvironment.JSaAtTR.Remove(this);
					}
					this._workEnvironment.Entity = value;
					if ((value != null))
					{
						value.JSaAtTR.Add(this);
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
	
	[Table(Name="safetaskanalysis.organisation")]
	public partial class OrganIsaTIon : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private sbyte _active;
		
		private int _idoRganisation;
		
		private string _nameEn;
		
		private string _nameFr;
		
		private int _regionID;
		
		private EntitySet<JSaAtTR> _jsAAtTr;
		
		private EntitySet<Supervisor> _supervisor;
		
		private EntityRef<Region> _region = new EntityRef<Region>();
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnActiveChanged();
		
		partial void OnActiveChanging(sbyte value);
		
		partial void OnIdoRganisationChanged();
		
		partial void OnIdoRganisationChanging(int value);
		
		partial void OnNameEnChanged();
		
		partial void OnNameEnChanging(string value);
		
		partial void OnNameFrChanged();
		
		partial void OnNameFrChanging(string value);
		
		partial void OnRegionIDChanged();
		
		partial void OnRegionIDChanging(int value);
		#endregion
		
		
		public OrganIsaTIon()
		{
			_jsAAtTr = new EntitySet<JSaAtTR>(new Action<JSaAtTR>(this.JSaAtTR_Attach), new Action<JSaAtTR>(this.JSaAtTR_Detach));
			_supervisor = new EntitySet<Supervisor>(new Action<Supervisor>(this.Supervisor_Attach), new Action<Supervisor>(this.Supervisor_Detach));
			this.OnCreated();
		}
		
		[Column(Storage="_active", Name="Active", DbType="tinyint(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public sbyte Active
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
		
		[Column(Storage="_idoRganisation", Name="ID_Organisation", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int IdoRganisation
		{
			get
			{
				return this._idoRganisation;
			}
			set
			{
				if ((_idoRganisation != value))
				{
					this.OnIdoRganisationChanging(value);
					this.SendPropertyChanging();
					this._idoRganisation = value;
					this.SendPropertyChanged("IdoRganisation");
					this.OnIdoRganisationChanged();
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
		[Association(Storage="_jsAAtTr", OtherKey="OrganisationID", ThisKey="IdoRganisation", Name="FK_JSA_Organisation")]
		[DebuggerNonUserCode()]
		public EntitySet<JSaAtTR> JSaAtTR
		{
			get
			{
				return this._jsAAtTr;
			}
			set
			{
				this._jsAAtTr = value;
			}
		}
		
		[Association(Storage="_supervisor", OtherKey="OrganisationID", ThisKey="IdoRganisation", Name="Fk_Org_ID")]
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
						previousRegion.OrganIsaTIon.Remove(this);
					}
					this._region.Entity = value;
					if ((value != null))
					{
						value.OrganIsaTIon.Add(this);
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
		private void JSaAtTR_Attach(JSaAtTR entity)
		{
			this.SendPropertyChanging();
			entity.OrganIsaTIon = this;
		}
		
		private void JSaAtTR_Detach(JSaAtTR entity)
		{
			this.SendPropertyChanging();
			entity.OrganIsaTIon = null;
		}
		
		private void Supervisor_Attach(Supervisor entity)
		{
			this.SendPropertyChanging();
			entity.OrganIsaTIon = this;
		}
		
		private void Supervisor_Detach(Supervisor entity)
		{
			this.SendPropertyChanging();
			entity.OrganIsaTIon = null;
		}
		#endregion
	}
	
	[Table(Name="safetaskanalysis.preventivemesure")]
	public partial class PreventiveMeSure : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private int _idpReVmESure;
		
		private int _riskID;
		
		private EntitySet<PreventiveMeSureAtTR> _preventiveMeSureAtTr;
		
		private EntityRef<AssociatedRisk> _associatedRisk = new EntityRef<AssociatedRisk>();
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnIDPreVMeSureChanged();
		
		partial void OnIDPreVMeSureChanging(int value);
		
		partial void OnRiskIDChanged();
		
		partial void OnRiskIDChanging(int value);
		#endregion
		
		
		public PreventiveMeSure()
		{
			_preventiveMeSureAtTr = new EntitySet<PreventiveMeSureAtTR>(new Action<PreventiveMeSureAtTR>(this.PreventiveMeSureAtTR_Attach), new Action<PreventiveMeSureAtTR>(this.PreventiveMeSureAtTR_Detach));
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
		[Association(Storage="_preventiveMeSureAtTr", OtherKey="PreVMeSureID", ThisKey="IDPreVMeSure", Name="FK_Attr_PrevMes")]
		[DebuggerNonUserCode()]
		public EntitySet<PreventiveMeSureAtTR> PreventiveMeSureAtTR
		{
			get
			{
				return this._preventiveMeSureAtTr;
			}
			set
			{
				this._preventiveMeSureAtTr = value;
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
						previousAssociatedRisk.PreventiveMeSure.Remove(this);
					}
					this._associatedRisk.Entity = value;
					if ((value != null))
					{
						value.PreventiveMeSure.Add(this);
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
		private void PreventiveMeSureAtTR_Attach(PreventiveMeSureAtTR entity)
		{
			this.SendPropertyChanging();
			entity.PreventiveMeSure = this;
		}
		
		private void PreventiveMeSureAtTR_Detach(PreventiveMeSureAtTR entity)
		{
			this.SendPropertyChanging();
			entity.PreventiveMeSure = null;
		}
		#endregion
	}
	
	[Table(Name="safetaskanalysis.preventivemesure_attr")]
	public partial class PreventiveMeSureAtTR : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private sbyte _active;
		
		private string _description;
		
		private int _idprevmesureaTtr;
		
		private int _preVmESureID;
		
		private EntityRef<PreventiveMeSure> _preventiveMeSure = new EntityRef<PreventiveMeSure>();
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnActiveChanged();
		
		partial void OnActiveChanging(sbyte value);
		
		partial void OnDescriptionChanged();
		
		partial void OnDescriptionChanging(string value);
		
		partial void OnIdprevmesureaTtrChanged();
		
		partial void OnIdprevmesureaTtrChanging(int value);
		
		partial void OnPreVMeSureIDChanged();
		
		partial void OnPreVMeSureIDChanging(int value);
		#endregion
		
		
		public PreventiveMeSureAtTR()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_active", Name="Active", DbType="tinyint(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public sbyte Active
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
		[Association(Storage="_preventiveMeSure", OtherKey="IDPreVMeSure", ThisKey="PreVMeSureID", Name="FK_Attr_PrevMes", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public PreventiveMeSure PreventiveMeSure
		{
			get
			{
				return this._preventiveMeSure.Entity;
			}
			set
			{
				if (((this._preventiveMeSure.Entity == value) 
							== false))
				{
					if ((this._preventiveMeSure.Entity != null))
					{
						PreventiveMeSure previousPreventiveMeSure = this._preventiveMeSure.Entity;
						this._preventiveMeSure.Entity = null;
						previousPreventiveMeSure.PreventiveMeSureAtTR.Remove(this);
					}
					this._preventiveMeSure.Entity = value;
					if ((value != null))
					{
						value.PreventiveMeSureAtTR.Add(this);
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
		
		private sbyte _active;
		
		private int _idrEgion;
		
		private string _nameEn;
		
		private string _nameFr;
		
		private EntitySet<JSaAtTR> _jsAAtTr;
		
		private EntitySet<OrganIsaTIon> _organIsaTiOn;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnActiveChanged();
		
		partial void OnActiveChanging(sbyte value);
		
		partial void OnIdrEgionChanged();
		
		partial void OnIdrEgionChanging(int value);
		
		partial void OnNameEnChanged();
		
		partial void OnNameEnChanging(string value);
		
		partial void OnNameFrChanged();
		
		partial void OnNameFrChanging(string value);
		#endregion
		
		
		public Region()
		{
			_jsAAtTr = new EntitySet<JSaAtTR>(new Action<JSaAtTR>(this.JSaAtTR_Attach), new Action<JSaAtTR>(this.JSaAtTR_Detach));
			_organIsaTiOn = new EntitySet<OrganIsaTIon>(new Action<OrganIsaTIon>(this.OrganIsaTIon_Attach), new Action<OrganIsaTIon>(this.OrganIsaTIon_Detach));
			this.OnCreated();
		}
		
		[Column(Storage="_active", Name="Active", DbType="tinyint(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public sbyte Active
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
		[Association(Storage="_jsAAtTr", OtherKey="RegionID", ThisKey="IdrEgion", Name="FK_JSA_Region")]
		[DebuggerNonUserCode()]
		public EntitySet<JSaAtTR> JSaAtTR
		{
			get
			{
				return this._jsAAtTr;
			}
			set
			{
				this._jsAAtTr = value;
			}
		}
		
		[Association(Storage="_organIsaTiOn", OtherKey="RegionID", ThisKey="IdrEgion", Name="FK_Region_ID")]
		[DebuggerNonUserCode()]
		public EntitySet<OrganIsaTIon> OrganIsaTIon
		{
			get
			{
				return this._organIsaTiOn;
			}
			set
			{
				this._organIsaTiOn = value;
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
		private void JSaAtTR_Attach(JSaAtTR entity)
		{
			this.SendPropertyChanging();
			entity.Region = this;
		}
		
		private void JSaAtTR_Detach(JSaAtTR entity)
		{
			this.SendPropertyChanging();
			entity.Region = null;
		}
		
		private void OrganIsaTIon_Attach(OrganIsaTIon entity)
		{
			this.SendPropertyChanging();
			entity.Region = this;
		}
		
		private void OrganIsaTIon_Detach(OrganIsaTIon entity)
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
		
		private sbyte _active;
		
		private string _description;
		
		private int _idsUpervisor;
		
		private int _organisationID;
		
		private EntitySet<JSaAtTR> _jsAAtTr;
		
		private EntityRef<OrganIsaTIon> _organIsaTiOn = new EntityRef<OrganIsaTIon>();
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnActiveChanged();
		
		partial void OnActiveChanging(sbyte value);
		
		partial void OnDescriptionChanged();
		
		partial void OnDescriptionChanging(string value);
		
		partial void OnIdsUpervisorChanged();
		
		partial void OnIdsUpervisorChanging(int value);
		
		partial void OnOrganisationIDChanged();
		
		partial void OnOrganisationIDChanging(int value);
		#endregion
		
		
		public Supervisor()
		{
			_jsAAtTr = new EntitySet<JSaAtTR>(new Action<JSaAtTR>(this.JSaAtTR_Attach), new Action<JSaAtTR>(this.JSaAtTR_Detach));
			this.OnCreated();
		}
		
		[Column(Storage="_active", Name="Active", DbType="tinyint(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public sbyte Active
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
		
		[Column(Storage="_organisationID", Name="Organisation_ID", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int OrganisationID
		{
			get
			{
				return this._organisationID;
			}
			set
			{
				if ((_organisationID != value))
				{
					this.OnOrganisationIDChanging(value);
					this.SendPropertyChanging();
					this._organisationID = value;
					this.SendPropertyChanged("OrganisationID");
					this.OnOrganisationIDChanged();
				}
			}
		}
		
		#region Children
		[Association(Storage="_jsAAtTr", OtherKey="SupervisorID", ThisKey="IdsUpervisor", Name="FK_JSA_Supervisor")]
		[DebuggerNonUserCode()]
		public EntitySet<JSaAtTR> JSaAtTR
		{
			get
			{
				return this._jsAAtTr;
			}
			set
			{
				this._jsAAtTr = value;
			}
		}
		#endregion
		
		#region Parents
		[Association(Storage="_organIsaTiOn", OtherKey="IdoRganisation", ThisKey="OrganisationID", Name="Fk_Org_ID", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public OrganIsaTIon OrganIsaTIon
		{
			get
			{
				return this._organIsaTiOn.Entity;
			}
			set
			{
				if (((this._organIsaTiOn.Entity == value) 
							== false))
				{
					if ((this._organIsaTiOn.Entity != null))
					{
						OrganIsaTIon previousOrganIsaTIon = this._organIsaTiOn.Entity;
						this._organIsaTiOn.Entity = null;
						previousOrganIsaTIon.Supervisor.Remove(this);
					}
					this._organIsaTiOn.Entity = value;
					if ((value != null))
					{
						value.Supervisor.Add(this);
						_organisationID = value.IdoRganisation;
					}
					else
					{
						_organisationID = default(int);
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
		private void JSaAtTR_Attach(JSaAtTR entity)
		{
			this.SendPropertyChanging();
			entity.Supervisor = this;
		}
		
		private void JSaAtTR_Detach(JSaAtTR entity)
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
		
		private int _jsAid;
		
		private EntitySet<AssociatedRisk> _associatedRisk;
		
		private EntitySet<TaskAtTR> _taskAtTr;
		
		private EntityRef<JSa> _jsA = new EntityRef<JSa>();
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnIdtAskChanged();
		
		partial void OnIdtAskChanging(int value);
		
		partial void OnJSaidChanged();
		
		partial void OnJSaidChanging(int value);
		#endregion
		
		
		public Task()
		{
			_associatedRisk = new EntitySet<AssociatedRisk>(new Action<AssociatedRisk>(this.AssociatedRisk_Attach), new Action<AssociatedRisk>(this.AssociatedRisk_Detach));
			_taskAtTr = new EntitySet<TaskAtTR>(new Action<TaskAtTR>(this.TaskAtTR_Attach), new Action<TaskAtTR>(this.TaskAtTR_Detach));
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
		
		[Column(Storage="_jsAid", Name="JSA_ID", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int JSaid
		{
			get
			{
				return this._jsAid;
			}
			set
			{
				if ((_jsAid != value))
				{
					this.OnJSaidChanging(value);
					this.SendPropertyChanging();
					this._jsAid = value;
					this.SendPropertyChanged("JSaid");
					this.OnJSaidChanged();
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
		
		[Association(Storage="_taskAtTr", OtherKey="TaskID", ThisKey="IdtAsk", Name="FK_Attr_Task")]
		[DebuggerNonUserCode()]
		public EntitySet<TaskAtTR> TaskAtTR
		{
			get
			{
				return this._taskAtTr;
			}
			set
			{
				this._taskAtTr = value;
			}
		}
		#endregion
		
		#region Parents
		[Association(Storage="_jsA", OtherKey="IDJSa", ThisKey="JSaid", Name="FK_Task_JSA", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public JSa JSa
		{
			get
			{
				return this._jsA.Entity;
			}
			set
			{
				if (((this._jsA.Entity == value) 
							== false))
				{
					if ((this._jsA.Entity != null))
					{
						JSa previousJSa = this._jsA.Entity;
						this._jsA.Entity = null;
						previousJSa.Task.Remove(this);
					}
					this._jsA.Entity = value;
					if ((value != null))
					{
						value.Task.Add(this);
						_jsAid = value.IDJSa;
					}
					else
					{
						_jsAid = default(int);
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
		
		private void TaskAtTR_Attach(TaskAtTR entity)
		{
			this.SendPropertyChanging();
			entity.Task = this;
		}
		
		private void TaskAtTR_Detach(TaskAtTR entity)
		{
			this.SendPropertyChanging();
			entity.Task = null;
		}
		#endregion
	}
	
	[Table(Name="safetaskanalysis.task_attr")]
	public partial class TaskAtTR : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private sbyte _active;
		
		private string _description;
		
		private int _idtAskAttr;
		
		private int _orderNo;
		
		private int _taskID;
		
		private EntityRef<Task> _task = new EntityRef<Task>();
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnActiveChanged();
		
		partial void OnActiveChanging(sbyte value);
		
		partial void OnDescriptionChanged();
		
		partial void OnDescriptionChanging(string value);
		
		partial void OnIdtAskAttrChanged();
		
		partial void OnIdtAskAttrChanging(int value);
		
		partial void OnOrderNoChanged();
		
		partial void OnOrderNoChanging(int value);
		
		partial void OnTaskIDChanged();
		
		partial void OnTaskIDChanging(int value);
		#endregion
		
		
		public TaskAtTR()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_active", Name="Active", DbType="tinyint(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public sbyte Active
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
		
		[Column(Storage="_idtAskAttr", Name="ID_Task_Attr", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int IdtAskAttr
		{
			get
			{
				return this._idtAskAttr;
			}
			set
			{
				if ((_idtAskAttr != value))
				{
					this.OnIdtAskAttrChanging(value);
					this.SendPropertyChanging();
					this._idtAskAttr = value;
					this.SendPropertyChanged("IdtAskAttr");
					this.OnIdtAskAttrChanged();
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
						previousTask.TaskAtTR.Remove(this);
					}
					this._task.Entity = value;
					if ((value != null))
					{
						value.TaskAtTR.Add(this);
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
		
		private System.Nullable<sbyte> _active;
		
		private int _idwOrkEnv;
		
		private string _nameEn;
		
		private string _nameFr;
		
		private EntitySet<JSaAtTR> _jsAAtTr;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnActiveChanged();
		
		partial void OnActiveChanging(System.Nullable<sbyte> value);
		
		partial void OnIdwOrkEnvChanged();
		
		partial void OnIdwOrkEnvChanging(int value);
		
		partial void OnNameEnChanged();
		
		partial void OnNameEnChanging(string value);
		
		partial void OnNameFrChanged();
		
		partial void OnNameFrChanging(string value);
		#endregion
		
		
		public WorkEnvironment()
		{
			_jsAAtTr = new EntitySet<JSaAtTR>(new Action<JSaAtTR>(this.JSaAtTR_Attach), new Action<JSaAtTR>(this.JSaAtTR_Detach));
			this.OnCreated();
		}
		
		[Column(Storage="_active", Name="Active", DbType="tinyint(1)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<sbyte> Active
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
		[Association(Storage="_jsAAtTr", OtherKey="WorkEnvID", ThisKey="IdwOrkEnv", Name="FK_JSA_WorkEnv")]
		[DebuggerNonUserCode()]
		public EntitySet<JSaAtTR> JSaAtTR
		{
			get
			{
				return this._jsAAtTr;
			}
			set
			{
				this._jsAAtTr = value;
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
		private void JSaAtTR_Attach(JSaAtTR entity)
		{
			this.SendPropertyChanging();
			entity.WorkEnvironment = this;
		}
		
		private void JSaAtTR_Detach(JSaAtTR entity)
		{
			this.SendPropertyChanging();
			entity.WorkEnvironment = null;
		}
		#endregion
	}
}
