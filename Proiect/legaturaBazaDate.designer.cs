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

namespace Proiect
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="FARMACIE")]
	public partial class legaturaBazaDateDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertMedicamente(Medicamente instance);
    partial void UpdateMedicamente(Medicamente instance);
    partial void DeleteMedicamente(Medicamente instance);
    partial void InsertPacienti(Pacienti instance);
    partial void UpdatePacienti(Pacienti instance);
    partial void DeletePacienti(Pacienti instance);
    partial void InsertRetete(Retete instance);
    partial void UpdateRetete(Retete instance);
    partial void DeleteRetete(Retete instance);
    #endregion
		
		public legaturaBazaDateDataContext() : 
				base(global::Proiect.Properties.Settings.Default.FARMACIEConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public legaturaBazaDateDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public legaturaBazaDateDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public legaturaBazaDateDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public legaturaBazaDateDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Medicamente> Medicamentes
		{
			get
			{
				return this.GetTable<Medicamente>();
			}
		}
		
		public System.Data.Linq.Table<Pacienti> Pacientis
		{
			get
			{
				return this.GetTable<Pacienti>();
			}
		}
		
		public System.Data.Linq.Table<Retete> Retetes
		{
			get
			{
				return this.GetTable<Retete>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Medicamente")]
	public partial class Medicamente : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _strDenumineComerciala;
		
		private string _strSubstanta;
		
		private int _id_medicament;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnstrDenumineComercialaChanging(string value);
    partial void OnstrDenumineComercialaChanged();
    partial void OnstrSubstantaChanging(string value);
    partial void OnstrSubstantaChanged();
    partial void Onid_medicamentChanging(int value);
    partial void Onid_medicamentChanged();
    #endregion
		
		public Medicamente()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_strDenumineComerciala", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string strDenumineComerciala
		{
			get
			{
				return this._strDenumineComerciala;
			}
			set
			{
				if ((this._strDenumineComerciala != value))
				{
					this.OnstrDenumineComercialaChanging(value);
					this.SendPropertyChanging();
					this._strDenumineComerciala = value;
					this.SendPropertyChanged("strDenumineComerciala");
					this.OnstrDenumineComercialaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_strSubstanta", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string strSubstanta
		{
			get
			{
				return this._strSubstanta;
			}
			set
			{
				if ((this._strSubstanta != value))
				{
					this.OnstrSubstantaChanging(value);
					this.SendPropertyChanging();
					this._strSubstanta = value;
					this.SendPropertyChanged("strSubstanta");
					this.OnstrSubstantaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_medicament", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int id_medicament
		{
			get
			{
				return this._id_medicament;
			}
			set
			{
				if ((this._id_medicament != value))
				{
					this.Onid_medicamentChanging(value);
					this.SendPropertyChanging();
					this._id_medicament = value;
					this.SendPropertyChanged("id_medicament");
					this.Onid_medicamentChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Pacienti")]
	public partial class Pacienti : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _strPacient;
		
		private int _idReteta;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnstrPacientChanging(string value);
    partial void OnstrPacientChanged();
    partial void OnidRetetaChanging(int value);
    partial void OnidRetetaChanged();
    #endregion
		
		public Pacienti()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_strPacient", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string strPacient
		{
			get
			{
				return this._strPacient;
			}
			set
			{
				if ((this._strPacient != value))
				{
					this.OnstrPacientChanging(value);
					this.SendPropertyChanging();
					this._strPacient = value;
					this.SendPropertyChanged("strPacient");
					this.OnstrPacientChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idReteta", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int idReteta
		{
			get
			{
				return this._idReteta;
			}
			set
			{
				if ((this._idReteta != value))
				{
					this.OnidRetetaChanging(value);
					this.SendPropertyChanging();
					this._idReteta = value;
					this.SendPropertyChanged("idReteta");
					this.OnidRetetaChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Retete")]
	public partial class Retete : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _strMedicament;
		
		private int _idReteta;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnstrMedicamentChanging(string value);
    partial void OnstrMedicamentChanged();
    partial void OnidRetetaChanging(int value);
    partial void OnidRetetaChanged();
    #endregion
		
		public Retete()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_strMedicament", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string strMedicament
		{
			get
			{
				return this._strMedicament;
			}
			set
			{
				if ((this._strMedicament != value))
				{
					this.OnstrMedicamentChanging(value);
					this.SendPropertyChanging();
					this._strMedicament = value;
					this.SendPropertyChanged("strMedicament");
					this.OnstrMedicamentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idReteta", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int idReteta
		{
			get
			{
				return this._idReteta;
			}
			set
			{
				if ((this._idReteta != value))
				{
					this.OnidRetetaChanging(value);
					this.SendPropertyChanging();
					this._idReteta = value;
					this.SendPropertyChanged("idReteta");
					this.OnidRetetaChanged();
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
}
#pragma warning restore 1591