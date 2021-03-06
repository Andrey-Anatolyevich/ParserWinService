﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ParserCore.DB.Sql
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Parser")]
	public partial class ParserSqlDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertImage(Image instance);
    partial void UpdateImage(Image instance);
    partial void DeleteImage(Image instance);
    partial void InsertAdd(Add instance);
    partial void UpdateAdd(Add instance);
    partial void DeleteAdd(Add instance);
    #endregion
		
		public ParserSqlDataContext() : 
				base(global::ParserCore.Properties.Settings.Default.ParserConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ParserSqlDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ParserSqlDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ParserSqlDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ParserSqlDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Image> Images
		{
			get
			{
				return this.GetTable<Image>();
			}
		}
		
		public System.Data.Linq.Table<Add> Adds
		{
			get
			{
				return this.GetTable<Add>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetFilteredUnshippedAdds")]
		public ISingleResult<GetFilteredUnshippedAddsResult> GetFilteredUnshippedAdds([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> priceMin, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> priceMax, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(MAX)")] string urlOriginal, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(MAX)")] string constraints, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(MAX)")] string keyWords, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Bit")] System.Nullable<bool> onlyWithPictures)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), priceMin, priceMax, urlOriginal, constraints, keyWords, onlyWithPictures);
			return ((ISingleResult<GetFilteredUnshippedAddsResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.AddEmailSetting")]
		public int AddEmailSetting([global::System.Data.Linq.Mapping.ParameterAttribute(Name="SmtpHostName", DbType="NVarChar(50)")] string smtpHostName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="SmtpPort", DbType="Int")] System.Nullable<int> smtpPort, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="SSLEnabled", DbType="Bit")] System.Nullable<bool> sSLEnabled, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="AccountLogin", DbType="NVarChar(50)")] string accountLogin, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="AccountPassCrypted", DbType="NVarChar(50)")] string accountPassCrypted, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="AccountPassSalt", DbType="NVarChar(250)")] string accountPassSalt, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="TargetEmailFrom", DbType="NVarChar(100)")] string targetEmailFrom, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="TargetEmailTo", DbType="NVarChar(100)")] string targetEmailTo, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="EmailTitle", DbType="NVarChar(200)")] string emailTitle)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), smtpHostName, smtpPort, sSLEnabled, accountLogin, accountPassCrypted, accountPassSalt, targetEmailFrom, targetEmailTo, emailTitle);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetMailSettingByID")]
		public ISingleResult<GetMailSettingByIDResult> GetMailSettingByID([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id);
			return ((ISingleResult<GetMailSettingByIDResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetMailSettings")]
		public ISingleResult<GetMailSettingsResult> GetMailSettings([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> from, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> to)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), from, to);
			return ((ISingleResult<GetMailSettingsResult>)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Images")]
	public partial class Image : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _AddID;
		
		private string _Url;
		
		private System.DateTime _InsertDt;
		
		private System.Nullable<System.DateTime> _UpdateDt;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnAddIDChanging(int value);
    partial void OnAddIDChanged();
    partial void OnUrlChanging(string value);
    partial void OnUrlChanged();
    partial void OnInsertDtChanging(System.DateTime value);
    partial void OnInsertDtChanged();
    partial void OnUpdateDtChanging(System.Nullable<System.DateTime> value);
    partial void OnUpdateDtChanged();
    #endregion
		
		public Image()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AddID", DbType="Int NOT NULL")]
		public int AddID
		{
			get
			{
				return this._AddID;
			}
			set
			{
				if ((this._AddID != value))
				{
					this.OnAddIDChanging(value);
					this.SendPropertyChanging();
					this._AddID = value;
					this.SendPropertyChanged("AddID");
					this.OnAddIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Url", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Url
		{
			get
			{
				return this._Url;
			}
			set
			{
				if ((this._Url != value))
				{
					this.OnUrlChanging(value);
					this.SendPropertyChanging();
					this._Url = value;
					this.SendPropertyChanged("Url");
					this.OnUrlChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InsertDt", DbType="DateTime2 NOT NULL")]
		public System.DateTime InsertDt
		{
			get
			{
				return this._InsertDt;
			}
			set
			{
				if ((this._InsertDt != value))
				{
					this.OnInsertDtChanging(value);
					this.SendPropertyChanging();
					this._InsertDt = value;
					this.SendPropertyChanged("InsertDt");
					this.OnInsertDtChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UpdateDt", DbType="DateTime2")]
		public System.Nullable<System.DateTime> UpdateDt
		{
			get
			{
				return this._UpdateDt;
			}
			set
			{
				if ((this._UpdateDt != value))
				{
					this.OnUpdateDtChanging(value);
					this.SendPropertyChanging();
					this._UpdateDt = value;
					this.SendPropertyChanged("UpdateDt");
					this.OnUpdateDtChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Adds")]
	public partial class Add : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _UrlParent;
		
		private string _Url;
		
		private string _AddID;
		
		private string _Title;
		
		private string _Text;
		
		private System.Nullable<bool> _IsProcessed;
		
		private System.Nullable<bool> _IsMailed;
		
		private System.Nullable<System.DateTime> _InsertDt;
		
		private System.Nullable<System.DateTime> _UpdateDt;
		
		private System.Nullable<double> _Price;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnUrlParentChanging(string value);
    partial void OnUrlParentChanged();
    partial void OnUrlChanging(string value);
    partial void OnUrlChanged();
    partial void OnAddIDChanging(string value);
    partial void OnAddIDChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnTextChanging(string value);
    partial void OnTextChanged();
    partial void OnIsProcessedChanging(System.Nullable<bool> value);
    partial void OnIsProcessedChanged();
    partial void OnIsMailedChanging(System.Nullable<bool> value);
    partial void OnIsMailedChanged();
    partial void OnInsertDtChanging(System.Nullable<System.DateTime> value);
    partial void OnInsertDtChanged();
    partial void OnUpdateDtChanging(System.Nullable<System.DateTime> value);
    partial void OnUpdateDtChanged();
    partial void OnPriceChanging(System.Nullable<double> value);
    partial void OnPriceChanged();
    #endregion
		
		public Add()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UrlParent", DbType="NVarChar(MAX)")]
		public string UrlParent
		{
			get
			{
				return this._UrlParent;
			}
			set
			{
				if ((this._UrlParent != value))
				{
					this.OnUrlParentChanging(value);
					this.SendPropertyChanging();
					this._UrlParent = value;
					this.SendPropertyChanged("UrlParent");
					this.OnUrlParentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Url", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Url
		{
			get
			{
				return this._Url;
			}
			set
			{
				if ((this._Url != value))
				{
					this.OnUrlChanging(value);
					this.SendPropertyChanging();
					this._Url = value;
					this.SendPropertyChanged("Url");
					this.OnUrlChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AddID", DbType="NVarChar(MAX)")]
		public string AddID
		{
			get
			{
				return this._AddID;
			}
			set
			{
				if ((this._AddID != value))
				{
					this.OnAddIDChanging(value);
					this.SendPropertyChanging();
					this._AddID = value;
					this.SendPropertyChanged("AddID");
					this.OnAddIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NVarChar(MAX)")]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Text", DbType="NVarChar(MAX)")]
		public string Text
		{
			get
			{
				return this._Text;
			}
			set
			{
				if ((this._Text != value))
				{
					this.OnTextChanging(value);
					this.SendPropertyChanging();
					this._Text = value;
					this.SendPropertyChanged("Text");
					this.OnTextChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsProcessed", DbType="Bit")]
		public System.Nullable<bool> IsProcessed
		{
			get
			{
				return this._IsProcessed;
			}
			set
			{
				if ((this._IsProcessed != value))
				{
					this.OnIsProcessedChanging(value);
					this.SendPropertyChanging();
					this._IsProcessed = value;
					this.SendPropertyChanged("IsProcessed");
					this.OnIsProcessedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsMailed", DbType="Bit")]
		public System.Nullable<bool> IsMailed
		{
			get
			{
				return this._IsMailed;
			}
			set
			{
				if ((this._IsMailed != value))
				{
					this.OnIsMailedChanging(value);
					this.SendPropertyChanging();
					this._IsMailed = value;
					this.SendPropertyChanged("IsMailed");
					this.OnIsMailedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InsertDt", DbType="DateTime2")]
		public System.Nullable<System.DateTime> InsertDt
		{
			get
			{
				return this._InsertDt;
			}
			set
			{
				if ((this._InsertDt != value))
				{
					this.OnInsertDtChanging(value);
					this.SendPropertyChanging();
					this._InsertDt = value;
					this.SendPropertyChanged("InsertDt");
					this.OnInsertDtChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UpdateDt", DbType="DateTime2")]
		public System.Nullable<System.DateTime> UpdateDt
		{
			get
			{
				return this._UpdateDt;
			}
			set
			{
				if ((this._UpdateDt != value))
				{
					this.OnUpdateDtChanging(value);
					this.SendPropertyChanging();
					this._UpdateDt = value;
					this.SendPropertyChanged("UpdateDt");
					this.OnUpdateDtChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Float")]
		public System.Nullable<double> Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	public partial class GetFilteredUnshippedAddsResult
	{
		
		private int _ID;
		
		private string _UrlParent;
		
		private string _Url;
		
		private string _AddID;
		
		private string _Title;
		
		private string _Text;
		
		private System.Nullable<bool> _IsProcessed;
		
		private System.Nullable<bool> _IsMailed;
		
		private System.Nullable<System.DateTime> _InsertDt;
		
		private System.Nullable<System.DateTime> _UpdateDt;
		
		private System.Nullable<double> _Price;
		
		public GetFilteredUnshippedAddsResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL")]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UrlParent", DbType="NVarChar(MAX)")]
		public string UrlParent
		{
			get
			{
				return this._UrlParent;
			}
			set
			{
				if ((this._UrlParent != value))
				{
					this._UrlParent = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Url", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Url
		{
			get
			{
				return this._Url;
			}
			set
			{
				if ((this._Url != value))
				{
					this._Url = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AddID", DbType="NVarChar(MAX)")]
		public string AddID
		{
			get
			{
				return this._AddID;
			}
			set
			{
				if ((this._AddID != value))
				{
					this._AddID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NVarChar(MAX)")]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this._Title = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Text", DbType="NVarChar(MAX)")]
		public string Text
		{
			get
			{
				return this._Text;
			}
			set
			{
				if ((this._Text != value))
				{
					this._Text = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsProcessed", DbType="Bit")]
		public System.Nullable<bool> IsProcessed
		{
			get
			{
				return this._IsProcessed;
			}
			set
			{
				if ((this._IsProcessed != value))
				{
					this._IsProcessed = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsMailed", DbType="Bit")]
		public System.Nullable<bool> IsMailed
		{
			get
			{
				return this._IsMailed;
			}
			set
			{
				if ((this._IsMailed != value))
				{
					this._IsMailed = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InsertDt", DbType="DateTime2")]
		public System.Nullable<System.DateTime> InsertDt
		{
			get
			{
				return this._InsertDt;
			}
			set
			{
				if ((this._InsertDt != value))
				{
					this._InsertDt = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UpdateDt", DbType="DateTime2")]
		public System.Nullable<System.DateTime> UpdateDt
		{
			get
			{
				return this._UpdateDt;
			}
			set
			{
				if ((this._UpdateDt != value))
				{
					this._UpdateDt = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Float")]
		public System.Nullable<double> Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this._Price = value;
				}
			}
		}
	}
	
	public partial class GetMailSettingByIDResult
	{
		
		private string _SmtpHostName;
		
		private int _SmtpPort;
		
		private bool _SSLEnabled;
		
		private string _AccountLogin;
		
		private string _AccountPassCrypted;
		
		private string _AccountPassSalt;
		
		private string _TargetEmailFrom;
		
		private string _TargetEmailTo;
		
		private string _EmailTitle;
		
		public GetMailSettingByIDResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SmtpHostName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string SmtpHostName
		{
			get
			{
				return this._SmtpHostName;
			}
			set
			{
				if ((this._SmtpHostName != value))
				{
					this._SmtpHostName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SmtpPort", DbType="Int NOT NULL")]
		public int SmtpPort
		{
			get
			{
				return this._SmtpPort;
			}
			set
			{
				if ((this._SmtpPort != value))
				{
					this._SmtpPort = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SSLEnabled", DbType="Bit NOT NULL")]
		public bool SSLEnabled
		{
			get
			{
				return this._SSLEnabled;
			}
			set
			{
				if ((this._SSLEnabled != value))
				{
					this._SSLEnabled = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AccountLogin", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string AccountLogin
		{
			get
			{
				return this._AccountLogin;
			}
			set
			{
				if ((this._AccountLogin != value))
				{
					this._AccountLogin = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AccountPassCrypted", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string AccountPassCrypted
		{
			get
			{
				return this._AccountPassCrypted;
			}
			set
			{
				if ((this._AccountPassCrypted != value))
				{
					this._AccountPassCrypted = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AccountPassSalt", DbType="NVarChar(250) NOT NULL", CanBeNull=false)]
		public string AccountPassSalt
		{
			get
			{
				return this._AccountPassSalt;
			}
			set
			{
				if ((this._AccountPassSalt != value))
				{
					this._AccountPassSalt = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TargetEmailFrom", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string TargetEmailFrom
		{
			get
			{
				return this._TargetEmailFrom;
			}
			set
			{
				if ((this._TargetEmailFrom != value))
				{
					this._TargetEmailFrom = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TargetEmailTo", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string TargetEmailTo
		{
			get
			{
				return this._TargetEmailTo;
			}
			set
			{
				if ((this._TargetEmailTo != value))
				{
					this._TargetEmailTo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmailTitle", DbType="NVarChar(200) NOT NULL", CanBeNull=false)]
		public string EmailTitle
		{
			get
			{
				return this._EmailTitle;
			}
			set
			{
				if ((this._EmailTitle != value))
				{
					this._EmailTitle = value;
				}
			}
		}
	}
	
	public partial class GetMailSettingsResult
	{
		
		private string _SmtpHostName;
		
		private int _SmtpPort;
		
		private bool _SSLEnabled;
		
		private string _AccountLogin;
		
		private string _AccountPassCrypted;
		
		private string _AccountPassSalt;
		
		private string _TargetEmailFrom;
		
		private string _TargetEmailTo;
		
		private string _EmailTitle;
		
		public GetMailSettingsResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SmtpHostName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string SmtpHostName
		{
			get
			{
				return this._SmtpHostName;
			}
			set
			{
				if ((this._SmtpHostName != value))
				{
					this._SmtpHostName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SmtpPort", DbType="Int NOT NULL")]
		public int SmtpPort
		{
			get
			{
				return this._SmtpPort;
			}
			set
			{
				if ((this._SmtpPort != value))
				{
					this._SmtpPort = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SSLEnabled", DbType="Bit NOT NULL")]
		public bool SSLEnabled
		{
			get
			{
				return this._SSLEnabled;
			}
			set
			{
				if ((this._SSLEnabled != value))
				{
					this._SSLEnabled = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AccountLogin", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string AccountLogin
		{
			get
			{
				return this._AccountLogin;
			}
			set
			{
				if ((this._AccountLogin != value))
				{
					this._AccountLogin = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AccountPassCrypted", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string AccountPassCrypted
		{
			get
			{
				return this._AccountPassCrypted;
			}
			set
			{
				if ((this._AccountPassCrypted != value))
				{
					this._AccountPassCrypted = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AccountPassSalt", DbType="NVarChar(250) NOT NULL", CanBeNull=false)]
		public string AccountPassSalt
		{
			get
			{
				return this._AccountPassSalt;
			}
			set
			{
				if ((this._AccountPassSalt != value))
				{
					this._AccountPassSalt = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TargetEmailFrom", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string TargetEmailFrom
		{
			get
			{
				return this._TargetEmailFrom;
			}
			set
			{
				if ((this._TargetEmailFrom != value))
				{
					this._TargetEmailFrom = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TargetEmailTo", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string TargetEmailTo
		{
			get
			{
				return this._TargetEmailTo;
			}
			set
			{
				if ((this._TargetEmailTo != value))
				{
					this._TargetEmailTo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmailTitle", DbType="NVarChar(200) NOT NULL", CanBeNull=false)]
		public string EmailTitle
		{
			get
			{
				return this._EmailTitle;
			}
			set
			{
				if ((this._EmailTitle != value))
				{
					this._EmailTitle = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
