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

namespace DAL
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QLGRXH")]
	public partial class QLGRXHDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertChitiet_HD(Chitiet_HD instance);
    partial void UpdateChitiet_HD(Chitiet_HD instance);
    partial void DeleteChitiet_HD(Chitiet_HD instance);
    partial void InsertTho(Tho instance);
    partial void UpdateTho(Tho instance);
    partial void DeleteTho(Tho instance);
    partial void InsertCong_Viec(Cong_Viec instance);
    partial void UpdateCong_Viec(Cong_Viec instance);
    partial void DeleteCong_Viec(Cong_Viec instance);
    partial void InsertHop_Dong(Hop_Dong instance);
    partial void UpdateHop_Dong(Hop_Dong instance);
    partial void DeleteHop_Dong(Hop_Dong instance);
    partial void InsertPhieu_thu(Phieu_thu instance);
    partial void UpdatePhieu_thu(Phieu_thu instance);
    partial void DeletePhieu_thu(Phieu_thu instance);
    #endregion
		
		public QLGRXHDataContext() : 
				base(global::DAL.Properties.Settings.Default.QLGRXHConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public QLGRXHDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLGRXHDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLGRXHDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLGRXHDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Chitiet_HD> Chitiet_HDs
		{
			get
			{
				return this.GetTable<Chitiet_HD>();
			}
		}
		
		public System.Data.Linq.Table<Tho> Thos
		{
			get
			{
				return this.GetTable<Tho>();
			}
		}
		
		public System.Data.Linq.Table<Cong_Viec> Cong_Viecs
		{
			get
			{
				return this.GetTable<Cong_Viec>();
			}
		}
		
		public System.Data.Linq.Table<Hop_Dong> Hop_Dongs
		{
			get
			{
				return this.GetTable<Hop_Dong>();
			}
		}
		
		public System.Data.Linq.Table<Phieu_thu> Phieu_thus
		{
			get
			{
				return this.GetTable<Phieu_thu>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Chitiet_HD")]
	public partial class Chitiet_HD : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _soHD;
		
		private string _maCV;
		
		private decimal _triGia_CV;
		
		private string _maTho;
		
		private decimal _khoanTho;
		
		private EntityRef<Tho> _Tho;
		
		private EntityRef<Cong_Viec> _Cong_Viec;
		
		private EntityRef<Hop_Dong> _Hop_Dong;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnsoHDChanging(string value);
    partial void OnsoHDChanged();
    partial void OnmaCVChanging(string value);
    partial void OnmaCVChanged();
    partial void OntriGia_CVChanging(decimal value);
    partial void OntriGia_CVChanged();
    partial void OnmaThoChanging(string value);
    partial void OnmaThoChanged();
    partial void OnkhoanThoChanging(decimal value);
    partial void OnkhoanThoChanged();
    #endregion
		
		public Chitiet_HD()
		{
			this._Tho = default(EntityRef<Tho>);
			this._Cong_Viec = default(EntityRef<Cong_Viec>);
			this._Hop_Dong = default(EntityRef<Hop_Dong>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_soHD", DbType="NChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string soHD
		{
			get
			{
				return this._soHD;
			}
			set
			{
				if ((this._soHD != value))
				{
					if (this._Hop_Dong.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnsoHDChanging(value);
					this.SendPropertyChanging();
					this._soHD = value;
					this.SendPropertyChanged("soHD");
					this.OnsoHDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_maCV", DbType="NChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string maCV
		{
			get
			{
				return this._maCV;
			}
			set
			{
				if ((this._maCV != value))
				{
					if (this._Cong_Viec.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnmaCVChanging(value);
					this.SendPropertyChanging();
					this._maCV = value;
					this.SendPropertyChanged("maCV");
					this.OnmaCVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_triGia_CV", DbType="Money NOT NULL")]
		public decimal triGia_CV
		{
			get
			{
				return this._triGia_CV;
			}
			set
			{
				if ((this._triGia_CV != value))
				{
					this.OntriGia_CVChanging(value);
					this.SendPropertyChanging();
					this._triGia_CV = value;
					this.SendPropertyChanged("triGia_CV");
					this.OntriGia_CVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_maTho", DbType="NChar(50) NOT NULL", CanBeNull=false)]
		public string maTho
		{
			get
			{
				return this._maTho;
			}
			set
			{
				if ((this._maTho != value))
				{
					if (this._Tho.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnmaThoChanging(value);
					this.SendPropertyChanging();
					this._maTho = value;
					this.SendPropertyChanged("maTho");
					this.OnmaThoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_khoanTho", DbType="Money NOT NULL")]
		public decimal khoanTho
		{
			get
			{
				return this._khoanTho;
			}
			set
			{
				if ((this._khoanTho != value))
				{
					this.OnkhoanThoChanging(value);
					this.SendPropertyChanging();
					this._khoanTho = value;
					this.SendPropertyChanged("khoanTho");
					this.OnkhoanThoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Tho_Chitiet_HD", Storage="_Tho", ThisKey="maTho", OtherKey="maTho", IsForeignKey=true)]
		public Tho Tho
		{
			get
			{
				return this._Tho.Entity;
			}
			set
			{
				Tho previousValue = this._Tho.Entity;
				if (((previousValue != value) 
							|| (this._Tho.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Tho.Entity = null;
						previousValue.Chitiet_HDs.Remove(this);
					}
					this._Tho.Entity = value;
					if ((value != null))
					{
						value.Chitiet_HDs.Add(this);
						this._maTho = value.maTho;
					}
					else
					{
						this._maTho = default(string);
					}
					this.SendPropertyChanged("Tho");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Cong_Viec_Chitiet_HD", Storage="_Cong_Viec", ThisKey="maCV", OtherKey="MACV", IsForeignKey=true)]
		public Cong_Viec Cong_Viec
		{
			get
			{
				return this._Cong_Viec.Entity;
			}
			set
			{
				Cong_Viec previousValue = this._Cong_Viec.Entity;
				if (((previousValue != value) 
							|| (this._Cong_Viec.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Cong_Viec.Entity = null;
						previousValue.Chitiet_HDs.Remove(this);
					}
					this._Cong_Viec.Entity = value;
					if ((value != null))
					{
						value.Chitiet_HDs.Add(this);
						this._maCV = value.MACV;
					}
					else
					{
						this._maCV = default(string);
					}
					this.SendPropertyChanged("Cong_Viec");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Hop_Dong_Chitiet_HD", Storage="_Hop_Dong", ThisKey="soHD", OtherKey="soHD", IsForeignKey=true)]
		public Hop_Dong Hop_Dong
		{
			get
			{
				return this._Hop_Dong.Entity;
			}
			set
			{
				Hop_Dong previousValue = this._Hop_Dong.Entity;
				if (((previousValue != value) 
							|| (this._Hop_Dong.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Hop_Dong.Entity = null;
						previousValue.Chitiet_HDs.Remove(this);
					}
					this._Hop_Dong.Entity = value;
					if ((value != null))
					{
						value.Chitiet_HDs.Add(this);
						this._soHD = value.soHD;
					}
					else
					{
						this._soHD = default(string);
					}
					this.SendPropertyChanged("Hop_Dong");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Tho")]
	public partial class Tho : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _maTho;
		
		private string _tenTho;
		
		private string _nhom;
		
		private string _nhom_Truong;
		
		private EntitySet<Chitiet_HD> _Chitiet_HDs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmaThoChanging(string value);
    partial void OnmaThoChanged();
    partial void OntenThoChanging(string value);
    partial void OntenThoChanged();
    partial void OnnhomChanging(string value);
    partial void OnnhomChanged();
    partial void Onnhom_TruongChanging(string value);
    partial void Onnhom_TruongChanged();
    #endregion
		
		public Tho()
		{
			this._Chitiet_HDs = new EntitySet<Chitiet_HD>(new Action<Chitiet_HD>(this.attach_Chitiet_HDs), new Action<Chitiet_HD>(this.detach_Chitiet_HDs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_maTho", DbType="NChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string maTho
		{
			get
			{
				return this._maTho;
			}
			set
			{
				if ((this._maTho != value))
				{
					this.OnmaThoChanging(value);
					this.SendPropertyChanging();
					this._maTho = value;
					this.SendPropertyChanged("maTho");
					this.OnmaThoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tenTho", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string tenTho
		{
			get
			{
				return this._tenTho;
			}
			set
			{
				if ((this._tenTho != value))
				{
					this.OntenThoChanging(value);
					this.SendPropertyChanging();
					this._tenTho = value;
					this.SendPropertyChanged("tenTho");
					this.OntenThoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nhom", DbType="NChar(50) NOT NULL", CanBeNull=false)]
		public string nhom
		{
			get
			{
				return this._nhom;
			}
			set
			{
				if ((this._nhom != value))
				{
					this.OnnhomChanging(value);
					this.SendPropertyChanging();
					this._nhom = value;
					this.SendPropertyChanged("nhom");
					this.OnnhomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nhom_Truong", DbType="NChar(50) NOT NULL", CanBeNull=false)]
		public string nhom_Truong
		{
			get
			{
				return this._nhom_Truong;
			}
			set
			{
				if ((this._nhom_Truong != value))
				{
					this.Onnhom_TruongChanging(value);
					this.SendPropertyChanging();
					this._nhom_Truong = value;
					this.SendPropertyChanged("nhom_Truong");
					this.Onnhom_TruongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Tho_Chitiet_HD", Storage="_Chitiet_HDs", ThisKey="maTho", OtherKey="maTho")]
		public EntitySet<Chitiet_HD> Chitiet_HDs
		{
			get
			{
				return this._Chitiet_HDs;
			}
			set
			{
				this._Chitiet_HDs.Assign(value);
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
		
		private void attach_Chitiet_HDs(Chitiet_HD entity)
		{
			this.SendPropertyChanging();
			entity.Tho = this;
		}
		
		private void detach_Chitiet_HDs(Chitiet_HD entity)
		{
			this.SendPropertyChanging();
			entity.Tho = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Cong_Viec")]
	public partial class Cong_Viec : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MACV;
		
		private string _NOIDUNGCV;
		
		private EntitySet<Chitiet_HD> _Chitiet_HDs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMACVChanging(string value);
    partial void OnMACVChanged();
    partial void OnNOIDUNGCVChanging(string value);
    partial void OnNOIDUNGCVChanged();
    #endregion
		
		public Cong_Viec()
		{
			this._Chitiet_HDs = new EntitySet<Chitiet_HD>(new Action<Chitiet_HD>(this.attach_Chitiet_HDs), new Action<Chitiet_HD>(this.detach_Chitiet_HDs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MACV", DbType="NChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MACV
		{
			get
			{
				return this._MACV;
			}
			set
			{
				if ((this._MACV != value))
				{
					this.OnMACVChanging(value);
					this.SendPropertyChanging();
					this._MACV = value;
					this.SendPropertyChanged("MACV");
					this.OnMACVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NOIDUNGCV", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string NOIDUNGCV
		{
			get
			{
				return this._NOIDUNGCV;
			}
			set
			{
				if ((this._NOIDUNGCV != value))
				{
					this.OnNOIDUNGCVChanging(value);
					this.SendPropertyChanging();
					this._NOIDUNGCV = value;
					this.SendPropertyChanged("NOIDUNGCV");
					this.OnNOIDUNGCVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Cong_Viec_Chitiet_HD", Storage="_Chitiet_HDs", ThisKey="MACV", OtherKey="maCV")]
		public EntitySet<Chitiet_HD> Chitiet_HDs
		{
			get
			{
				return this._Chitiet_HDs;
			}
			set
			{
				this._Chitiet_HDs.Assign(value);
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
		
		private void attach_Chitiet_HDs(Chitiet_HD entity)
		{
			this.SendPropertyChanging();
			entity.Cong_Viec = this;
		}
		
		private void detach_Chitiet_HDs(Chitiet_HD entity)
		{
			this.SendPropertyChanging();
			entity.Cong_Viec = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Hop_Dong")]
	public partial class Hop_Dong : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _soHD;
		
		private string _maKH;
		
		private string _tenKH;
		
		private string _diaChi;
		
		private System.DateTime _ngayHD;
		
		private string _soXe;
		
		private decimal _triGiaHD;
		
		private System.DateTime _ng_Giao_DK;
		
		private System.DateTime _ng_NgThu;
		
		private EntitySet<Chitiet_HD> _Chitiet_HDs;
		
		private EntitySet<Phieu_thu> _Phieu_thus;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnsoHDChanging(string value);
    partial void OnsoHDChanged();
    partial void OnmaKHChanging(string value);
    partial void OnmaKHChanged();
    partial void OntenKHChanging(string value);
    partial void OntenKHChanged();
    partial void OndiaChiChanging(string value);
    partial void OndiaChiChanged();
    partial void OnngayHDChanging(System.DateTime value);
    partial void OnngayHDChanged();
    partial void OnsoXeChanging(string value);
    partial void OnsoXeChanged();
    partial void OntriGiaHDChanging(decimal value);
    partial void OntriGiaHDChanged();
    partial void Onng_Giao_DKChanging(System.DateTime value);
    partial void Onng_Giao_DKChanged();
    partial void Onng_NgThuChanging(System.DateTime value);
    partial void Onng_NgThuChanged();
    #endregion
		
		public Hop_Dong()
		{
			this._Chitiet_HDs = new EntitySet<Chitiet_HD>(new Action<Chitiet_HD>(this.attach_Chitiet_HDs), new Action<Chitiet_HD>(this.detach_Chitiet_HDs));
			this._Phieu_thus = new EntitySet<Phieu_thu>(new Action<Phieu_thu>(this.attach_Phieu_thus), new Action<Phieu_thu>(this.detach_Phieu_thus));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_soHD", DbType="NChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string soHD
		{
			get
			{
				return this._soHD;
			}
			set
			{
				if ((this._soHD != value))
				{
					this.OnsoHDChanging(value);
					this.SendPropertyChanging();
					this._soHD = value;
					this.SendPropertyChanged("soHD");
					this.OnsoHDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_maKH", DbType="NChar(50) NOT NULL", CanBeNull=false)]
		public string maKH
		{
			get
			{
				return this._maKH;
			}
			set
			{
				if ((this._maKH != value))
				{
					this.OnmaKHChanging(value);
					this.SendPropertyChanging();
					this._maKH = value;
					this.SendPropertyChanged("maKH");
					this.OnmaKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tenKH", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string tenKH
		{
			get
			{
				return this._tenKH;
			}
			set
			{
				if ((this._tenKH != value))
				{
					this.OntenKHChanging(value);
					this.SendPropertyChanging();
					this._tenKH = value;
					this.SendPropertyChanged("tenKH");
					this.OntenKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_diaChi", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string diaChi
		{
			get
			{
				return this._diaChi;
			}
			set
			{
				if ((this._diaChi != value))
				{
					this.OndiaChiChanging(value);
					this.SendPropertyChanging();
					this._diaChi = value;
					this.SendPropertyChanged("diaChi");
					this.OndiaChiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ngayHD", DbType="DateTime NOT NULL")]
		public System.DateTime ngayHD
		{
			get
			{
				return this._ngayHD;
			}
			set
			{
				if ((this._ngayHD != value))
				{
					this.OnngayHDChanging(value);
					this.SendPropertyChanging();
					this._ngayHD = value;
					this.SendPropertyChanged("ngayHD");
					this.OnngayHDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_soXe", DbType="NChar(50) NOT NULL", CanBeNull=false)]
		public string soXe
		{
			get
			{
				return this._soXe;
			}
			set
			{
				if ((this._soXe != value))
				{
					this.OnsoXeChanging(value);
					this.SendPropertyChanging();
					this._soXe = value;
					this.SendPropertyChanged("soXe");
					this.OnsoXeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_triGiaHD", DbType="Money NOT NULL")]
		public decimal triGiaHD
		{
			get
			{
				return this._triGiaHD;
			}
			set
			{
				if ((this._triGiaHD != value))
				{
					this.OntriGiaHDChanging(value);
					this.SendPropertyChanging();
					this._triGiaHD = value;
					this.SendPropertyChanged("triGiaHD");
					this.OntriGiaHDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ng_Giao_DK", DbType="DateTime NOT NULL")]
		public System.DateTime ng_Giao_DK
		{
			get
			{
				return this._ng_Giao_DK;
			}
			set
			{
				if ((this._ng_Giao_DK != value))
				{
					this.Onng_Giao_DKChanging(value);
					this.SendPropertyChanging();
					this._ng_Giao_DK = value;
					this.SendPropertyChanged("ng_Giao_DK");
					this.Onng_Giao_DKChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ng_NgThu", DbType="DateTime NOT NULL")]
		public System.DateTime ng_NgThu
		{
			get
			{
				return this._ng_NgThu;
			}
			set
			{
				if ((this._ng_NgThu != value))
				{
					this.Onng_NgThuChanging(value);
					this.SendPropertyChanging();
					this._ng_NgThu = value;
					this.SendPropertyChanged("ng_NgThu");
					this.Onng_NgThuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Hop_Dong_Chitiet_HD", Storage="_Chitiet_HDs", ThisKey="soHD", OtherKey="soHD")]
		public EntitySet<Chitiet_HD> Chitiet_HDs
		{
			get
			{
				return this._Chitiet_HDs;
			}
			set
			{
				this._Chitiet_HDs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Hop_Dong_Phieu_thu", Storage="_Phieu_thus", ThisKey="soHD", OtherKey="soHD")]
		public EntitySet<Phieu_thu> Phieu_thus
		{
			get
			{
				return this._Phieu_thus;
			}
			set
			{
				this._Phieu_thus.Assign(value);
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
		
		private void attach_Chitiet_HDs(Chitiet_HD entity)
		{
			this.SendPropertyChanging();
			entity.Hop_Dong = this;
		}
		
		private void detach_Chitiet_HDs(Chitiet_HD entity)
		{
			this.SendPropertyChanging();
			entity.Hop_Dong = null;
		}
		
		private void attach_Phieu_thus(Phieu_thu entity)
		{
			this.SendPropertyChanging();
			entity.Hop_Dong = this;
		}
		
		private void detach_Phieu_thus(Phieu_thu entity)
		{
			this.SendPropertyChanging();
			entity.Hop_Dong = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Phieu_thu")]
	public partial class Phieu_thu : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _soPH;
		
		private System.DateTime _ngayPH;
		
		private string _soHD;
		
		private string _hoTen;
		
		private decimal _soTienThu;
		
		private EntityRef<Hop_Dong> _Hop_Dong;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnsoPHChanging(string value);
    partial void OnsoPHChanged();
    partial void OnngayPHChanging(System.DateTime value);
    partial void OnngayPHChanged();
    partial void OnsoHDChanging(string value);
    partial void OnsoHDChanged();
    partial void OnhoTenChanging(string value);
    partial void OnhoTenChanged();
    partial void OnsoTienThuChanging(decimal value);
    partial void OnsoTienThuChanged();
    #endregion
		
		public Phieu_thu()
		{
			this._Hop_Dong = default(EntityRef<Hop_Dong>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_soPH", DbType="NChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string soPH
		{
			get
			{
				return this._soPH;
			}
			set
			{
				if ((this._soPH != value))
				{
					this.OnsoPHChanging(value);
					this.SendPropertyChanging();
					this._soPH = value;
					this.SendPropertyChanged("soPH");
					this.OnsoPHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ngayPH", DbType="DateTime NOT NULL")]
		public System.DateTime ngayPH
		{
			get
			{
				return this._ngayPH;
			}
			set
			{
				if ((this._ngayPH != value))
				{
					this.OnngayPHChanging(value);
					this.SendPropertyChanging();
					this._ngayPH = value;
					this.SendPropertyChanged("ngayPH");
					this.OnngayPHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_soHD", DbType="NChar(50) NOT NULL", CanBeNull=false)]
		public string soHD
		{
			get
			{
				return this._soHD;
			}
			set
			{
				if ((this._soHD != value))
				{
					if (this._Hop_Dong.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnsoHDChanging(value);
					this.SendPropertyChanging();
					this._soHD = value;
					this.SendPropertyChanged("soHD");
					this.OnsoHDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hoTen", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string hoTen
		{
			get
			{
				return this._hoTen;
			}
			set
			{
				if ((this._hoTen != value))
				{
					this.OnhoTenChanging(value);
					this.SendPropertyChanging();
					this._hoTen = value;
					this.SendPropertyChanged("hoTen");
					this.OnhoTenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_soTienThu", DbType="Money NOT NULL")]
		public decimal soTienThu
		{
			get
			{
				return this._soTienThu;
			}
			set
			{
				if ((this._soTienThu != value))
				{
					this.OnsoTienThuChanging(value);
					this.SendPropertyChanging();
					this._soTienThu = value;
					this.SendPropertyChanged("soTienThu");
					this.OnsoTienThuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Hop_Dong_Phieu_thu", Storage="_Hop_Dong", ThisKey="soHD", OtherKey="soHD", IsForeignKey=true)]
		public Hop_Dong Hop_Dong
		{
			get
			{
				return this._Hop_Dong.Entity;
			}
			set
			{
				Hop_Dong previousValue = this._Hop_Dong.Entity;
				if (((previousValue != value) 
							|| (this._Hop_Dong.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Hop_Dong.Entity = null;
						previousValue.Phieu_thus.Remove(this);
					}
					this._Hop_Dong.Entity = value;
					if ((value != null))
					{
						value.Phieu_thus.Add(this);
						this._soHD = value.soHD;
					}
					else
					{
						this._soHD = default(string);
					}
					this.SendPropertyChanged("Hop_Dong");
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
