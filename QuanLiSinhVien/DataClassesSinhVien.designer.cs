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

namespace QuanLiSinhVien
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="qlsinhvien15a10")]
	public partial class DataClassesSinhVienDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertlop(lop instance);
    partial void Updatelop(lop instance);
    partial void Deletelop(lop instance);
    partial void Insertsinhvien(sinhvien instance);
    partial void Updatesinhvien(sinhvien instance);
    partial void Deletesinhvien(sinhvien instance);
    #endregion
		
		public DataClassesSinhVienDataContext() : 
				base(global::QuanLiSinhVien.Properties.Settings.Default.qlsinhvien15a10ConnectionString2, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesSinhVienDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesSinhVienDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesSinhVienDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesSinhVienDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<lop> lops
		{
			get
			{
				return this.GetTable<lop>();
			}
		}
		
		public System.Data.Linq.Table<sinhvien> sinhviens
		{
			get
			{
				return this.GetTable<sinhvien>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.lop")]
	public partial class lop : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _malop;
		
		private string _tenlop;
		
		private string _email;
		
		private string _hoten;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmalopChanging(string value);
    partial void OnmalopChanged();
    partial void OntenlopChanging(string value);
    partial void OntenlopChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OnhotenChanging(string value);
    partial void OnhotenChanged();
    #endregion
		
		public lop()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_malop", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string malop
		{
			get
			{
				return this._malop;
			}
			set
			{
				if ((this._malop != value))
				{
					this.OnmalopChanging(value);
					this.SendPropertyChanging();
					this._malop = value;
					this.SendPropertyChanged("malop");
					this.OnmalopChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tenlop", DbType="VarChar(50)")]
		public string tenlop
		{
			get
			{
				return this._tenlop;
			}
			set
			{
				if ((this._tenlop != value))
				{
					this.OntenlopChanging(value);
					this.SendPropertyChanging();
					this._tenlop = value;
					this.SendPropertyChanged("tenlop");
					this.OntenlopChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="VarChar(50)")]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hoten", DbType="VarChar(50)")]
		public string hoten
		{
			get
			{
				return this._hoten;
			}
			set
			{
				if ((this._hoten != value))
				{
					this.OnhotenChanging(value);
					this.SendPropertyChanging();
					this._hoten = value;
					this.SendPropertyChanged("hoten");
					this.OnhotenChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.sinhvien")]
	public partial class sinhvien : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _masv;
		
		private string _hoten;
		
		private string _gioitinh;
		
		private string _quequan;
		
		private string _malop;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmasvChanging(string value);
    partial void OnmasvChanged();
    partial void OnhotenChanging(string value);
    partial void OnhotenChanged();
    partial void OngioitinhChanging(string value);
    partial void OngioitinhChanged();
    partial void OnquequanChanging(string value);
    partial void OnquequanChanged();
    partial void OnmalopChanging(string value);
    partial void OnmalopChanged();
    #endregion
		
		public sinhvien()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_masv", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string masv
		{
			get
			{
				return this._masv;
			}
			set
			{
				if ((this._masv != value))
				{
					this.OnmasvChanging(value);
					this.SendPropertyChanging();
					this._masv = value;
					this.SendPropertyChanged("masv");
					this.OnmasvChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hoten", DbType="VarChar(100)")]
		public string hoten
		{
			get
			{
				return this._hoten;
			}
			set
			{
				if ((this._hoten != value))
				{
					this.OnhotenChanging(value);
					this.SendPropertyChanging();
					this._hoten = value;
					this.SendPropertyChanged("hoten");
					this.OnhotenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gioitinh", DbType="VarChar(5)")]
		public string gioitinh
		{
			get
			{
				return this._gioitinh;
			}
			set
			{
				if ((this._gioitinh != value))
				{
					this.OngioitinhChanging(value);
					this.SendPropertyChanging();
					this._gioitinh = value;
					this.SendPropertyChanged("gioitinh");
					this.OngioitinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_quequan", DbType="VarChar(250)")]
		public string quequan
		{
			get
			{
				return this._quequan;
			}
			set
			{
				if ((this._quequan != value))
				{
					this.OnquequanChanging(value);
					this.SendPropertyChanging();
					this._quequan = value;
					this.SendPropertyChanged("quequan");
					this.OnquequanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_malop", DbType="VarChar(50)")]
		public string malop
		{
			get
			{
				return this._malop;
			}
			set
			{
				if ((this._malop != value))
				{
					this.OnmalopChanging(value);
					this.SendPropertyChanging();
					this._malop = value;
					this.SendPropertyChanged("malop");
					this.OnmalopChanged();
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
