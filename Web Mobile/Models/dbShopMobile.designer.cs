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

namespace Web_Mobile.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ShopMobile")]
	public partial class dbShopMobileDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertDONDATHANG(DONDATHANG instance);
    partial void UpdateDONDATHANG(DONDATHANG instance);
    partial void DeleteDONDATHANG(DONDATHANG instance);
    partial void InsertCHITIETDONTHANG(CHITIETDONTHANG instance);
    partial void UpdateCHITIETDONTHANG(CHITIETDONTHANG instance);
    partial void DeleteCHITIETDONTHANG(CHITIETDONTHANG instance);
    partial void InsertKHACHHANG(KHACHHANG instance);
    partial void UpdateKHACHHANG(KHACHHANG instance);
    partial void DeleteKHACHHANG(KHACHHANG instance);
    partial void InsertLoaiSanPham(LoaiSanPham instance);
    partial void UpdateLoaiSanPham(LoaiSanPham instance);
    partial void DeleteLoaiSanPham(LoaiSanPham instance);
    partial void InsertNhaSanXuat(NhaSanXuat instance);
    partial void UpdateNhaSanXuat(NhaSanXuat instance);
    partial void DeleteNhaSanXuat(NhaSanXuat instance);
    partial void InsertSanPham(SanPham instance);
    partial void UpdateSanPham(SanPham instance);
    partial void DeleteSanPham(SanPham instance);
    #endregion
		
		public dbShopMobileDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["ShopMobileConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public dbShopMobileDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbShopMobileDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbShopMobileDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbShopMobileDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<DONDATHANG> DONDATHANGs
		{
			get
			{
				return this.GetTable<DONDATHANG>();
			}
		}
		
		public System.Data.Linq.Table<CHITIETDONTHANG> CHITIETDONTHANGs
		{
			get
			{
				return this.GetTable<CHITIETDONTHANG>();
			}
		}
		
		public System.Data.Linq.Table<KHACHHANG> KHACHHANGs
		{
			get
			{
				return this.GetTable<KHACHHANG>();
			}
		}
		
		public System.Data.Linq.Table<LoaiSanPham> LoaiSanPhams
		{
			get
			{
				return this.GetTable<LoaiSanPham>();
			}
		}
		
		public System.Data.Linq.Table<NhaSanXuat> NhaSanXuats
		{
			get
			{
				return this.GetTable<NhaSanXuat>();
			}
		}
		
		public System.Data.Linq.Table<SanPham> SanPhams
		{
			get
			{
				return this.GetTable<SanPham>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DONDATHANG")]
	public partial class DONDATHANG : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaDH;
		
		private System.Nullable<bool> _Dathanhtoan;
		
		private System.Nullable<bool> _Tinhtranggiaohang;
		
		private System.Nullable<System.DateTime> _Ngaydat;
		
		private System.Nullable<System.DateTime> _Ngaygiao;
		
		private System.Nullable<int> _MaKH;
		
		private EntitySet<CHITIETDONTHANG> _CHITIETDONTHANGs;
		
		private EntityRef<KHACHHANG> _KHACHHANG;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaDHChanging(int value);
    partial void OnMaDHChanged();
    partial void OnDathanhtoanChanging(System.Nullable<bool> value);
    partial void OnDathanhtoanChanged();
    partial void OnTinhtranggiaohangChanging(System.Nullable<bool> value);
    partial void OnTinhtranggiaohangChanged();
    partial void OnNgaydatChanging(System.Nullable<System.DateTime> value);
    partial void OnNgaydatChanged();
    partial void OnNgaygiaoChanging(System.Nullable<System.DateTime> value);
    partial void OnNgaygiaoChanged();
    partial void OnMaKHChanging(System.Nullable<int> value);
    partial void OnMaKHChanged();
    #endregion
		
		public DONDATHANG()
		{
			this._CHITIETDONTHANGs = new EntitySet<CHITIETDONTHANG>(new Action<CHITIETDONTHANG>(this.attach_CHITIETDONTHANGs), new Action<CHITIETDONTHANG>(this.detach_CHITIETDONTHANGs));
			this._KHACHHANG = default(EntityRef<KHACHHANG>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDH", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaDH
		{
			get
			{
				return this._MaDH;
			}
			set
			{
				if ((this._MaDH != value))
				{
					this.OnMaDHChanging(value);
					this.SendPropertyChanging();
					this._MaDH = value;
					this.SendPropertyChanged("MaDH");
					this.OnMaDHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Dathanhtoan", DbType="Bit")]
		public System.Nullable<bool> Dathanhtoan
		{
			get
			{
				return this._Dathanhtoan;
			}
			set
			{
				if ((this._Dathanhtoan != value))
				{
					this.OnDathanhtoanChanging(value);
					this.SendPropertyChanging();
					this._Dathanhtoan = value;
					this.SendPropertyChanged("Dathanhtoan");
					this.OnDathanhtoanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tinhtranggiaohang", DbType="Bit")]
		public System.Nullable<bool> Tinhtranggiaohang
		{
			get
			{
				return this._Tinhtranggiaohang;
			}
			set
			{
				if ((this._Tinhtranggiaohang != value))
				{
					this.OnTinhtranggiaohangChanging(value);
					this.SendPropertyChanging();
					this._Tinhtranggiaohang = value;
					this.SendPropertyChanged("Tinhtranggiaohang");
					this.OnTinhtranggiaohangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ngaydat", DbType="DateTime")]
		public System.Nullable<System.DateTime> Ngaydat
		{
			get
			{
				return this._Ngaydat;
			}
			set
			{
				if ((this._Ngaydat != value))
				{
					this.OnNgaydatChanging(value);
					this.SendPropertyChanging();
					this._Ngaydat = value;
					this.SendPropertyChanged("Ngaydat");
					this.OnNgaydatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ngaygiao", DbType="DateTime")]
		public System.Nullable<System.DateTime> Ngaygiao
		{
			get
			{
				return this._Ngaygiao;
			}
			set
			{
				if ((this._Ngaygiao != value))
				{
					this.OnNgaygiaoChanging(value);
					this.SendPropertyChanging();
					this._Ngaygiao = value;
					this.SendPropertyChanged("Ngaygiao");
					this.OnNgaygiaoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKH", DbType="Int")]
		public System.Nullable<int> MaKH
		{
			get
			{
				return this._MaKH;
			}
			set
			{
				if ((this._MaKH != value))
				{
					if (this._KHACHHANG.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaKHChanging(value);
					this.SendPropertyChanging();
					this._MaKH = value;
					this.SendPropertyChanged("MaKH");
					this.OnMaKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DONDATHANG_CHITIETDONTHANG", Storage="_CHITIETDONTHANGs", ThisKey="MaDH", OtherKey="MaDH")]
		public EntitySet<CHITIETDONTHANG> CHITIETDONTHANGs
		{
			get
			{
				return this._CHITIETDONTHANGs;
			}
			set
			{
				this._CHITIETDONTHANGs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KHACHHANG_DONDATHANG", Storage="_KHACHHANG", ThisKey="MaKH", OtherKey="MaKH", IsForeignKey=true)]
		public KHACHHANG KHACHHANG
		{
			get
			{
				return this._KHACHHANG.Entity;
			}
			set
			{
				KHACHHANG previousValue = this._KHACHHANG.Entity;
				if (((previousValue != value) 
							|| (this._KHACHHANG.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._KHACHHANG.Entity = null;
						previousValue.DONDATHANGs.Remove(this);
					}
					this._KHACHHANG.Entity = value;
					if ((value != null))
					{
						value.DONDATHANGs.Add(this);
						this._MaKH = value.MaKH;
					}
					else
					{
						this._MaKH = default(Nullable<int>);
					}
					this.SendPropertyChanged("KHACHHANG");
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
		
		private void attach_CHITIETDONTHANGs(CHITIETDONTHANG entity)
		{
			this.SendPropertyChanging();
			entity.DONDATHANG = this;
		}
		
		private void detach_CHITIETDONTHANGs(CHITIETDONTHANG entity)
		{
			this.SendPropertyChanging();
			entity.DONDATHANG = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CHITIETDONTHANG")]
	public partial class CHITIETDONTHANG : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaDH;
		
		private int _MaSP;
		
		private System.Nullable<int> _Soluong;
		
		private System.Nullable<decimal> _Dongia;
		
		private EntityRef<DONDATHANG> _DONDATHANG;
		
		private EntityRef<SanPham> _SanPham;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaDHChanging(int value);
    partial void OnMaDHChanged();
    partial void OnMaSPChanging(int value);
    partial void OnMaSPChanged();
    partial void OnSoluongChanging(System.Nullable<int> value);
    partial void OnSoluongChanged();
    partial void OnDongiaChanging(System.Nullable<decimal> value);
    partial void OnDongiaChanged();
    #endregion
		
		public CHITIETDONTHANG()
		{
			this._DONDATHANG = default(EntityRef<DONDATHANG>);
			this._SanPham = default(EntityRef<SanPham>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDH", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaDH
		{
			get
			{
				return this._MaDH;
			}
			set
			{
				if ((this._MaDH != value))
				{
					if (this._DONDATHANG.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaDHChanging(value);
					this.SendPropertyChanging();
					this._MaDH = value;
					this.SendPropertyChanged("MaDH");
					this.OnMaDHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSP", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaSP
		{
			get
			{
				return this._MaSP;
			}
			set
			{
				if ((this._MaSP != value))
				{
					if (this._SanPham.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaSPChanging(value);
					this.SendPropertyChanging();
					this._MaSP = value;
					this.SendPropertyChanged("MaSP");
					this.OnMaSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Soluong", DbType="Int")]
		public System.Nullable<int> Soluong
		{
			get
			{
				return this._Soluong;
			}
			set
			{
				if ((this._Soluong != value))
				{
					this.OnSoluongChanging(value);
					this.SendPropertyChanging();
					this._Soluong = value;
					this.SendPropertyChanged("Soluong");
					this.OnSoluongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Dongia", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> Dongia
		{
			get
			{
				return this._Dongia;
			}
			set
			{
				if ((this._Dongia != value))
				{
					this.OnDongiaChanging(value);
					this.SendPropertyChanging();
					this._Dongia = value;
					this.SendPropertyChanged("Dongia");
					this.OnDongiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DONDATHANG_CHITIETDONTHANG", Storage="_DONDATHANG", ThisKey="MaDH", OtherKey="MaDH", IsForeignKey=true)]
		public DONDATHANG DONDATHANG
		{
			get
			{
				return this._DONDATHANG.Entity;
			}
			set
			{
				DONDATHANG previousValue = this._DONDATHANG.Entity;
				if (((previousValue != value) 
							|| (this._DONDATHANG.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._DONDATHANG.Entity = null;
						previousValue.CHITIETDONTHANGs.Remove(this);
					}
					this._DONDATHANG.Entity = value;
					if ((value != null))
					{
						value.CHITIETDONTHANGs.Add(this);
						this._MaDH = value.MaDH;
					}
					else
					{
						this._MaDH = default(int);
					}
					this.SendPropertyChanged("DONDATHANG");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SanPham_CHITIETDONTHANG", Storage="_SanPham", ThisKey="MaSP", OtherKey="MaSP", IsForeignKey=true)]
		public SanPham SanPham
		{
			get
			{
				return this._SanPham.Entity;
			}
			set
			{
				SanPham previousValue = this._SanPham.Entity;
				if (((previousValue != value) 
							|| (this._SanPham.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._SanPham.Entity = null;
						previousValue.CHITIETDONTHANGs.Remove(this);
					}
					this._SanPham.Entity = value;
					if ((value != null))
					{
						value.CHITIETDONTHANGs.Add(this);
						this._MaSP = value.MaSP;
					}
					else
					{
						this._MaSP = default(int);
					}
					this.SendPropertyChanged("SanPham");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.KHACHHANG")]
	public partial class KHACHHANG : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaKH;
		
		private string _HoTen;
		
		private string _Taikhoan;
		
		private string _Matkhau;
		
		private string _Email;
		
		private string _DiachiKH;
		
		private string _DienthoaiKH;
		
		private System.Nullable<System.DateTime> _Ngaysinh;
		
		private EntitySet<DONDATHANG> _DONDATHANGs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaKHChanging(int value);
    partial void OnMaKHChanged();
    partial void OnHoTenChanging(string value);
    partial void OnHoTenChanged();
    partial void OnTaikhoanChanging(string value);
    partial void OnTaikhoanChanged();
    partial void OnMatkhauChanging(string value);
    partial void OnMatkhauChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnDiachiKHChanging(string value);
    partial void OnDiachiKHChanged();
    partial void OnDienthoaiKHChanging(string value);
    partial void OnDienthoaiKHChanged();
    partial void OnNgaysinhChanging(System.Nullable<System.DateTime> value);
    partial void OnNgaysinhChanged();
    #endregion
		
		public KHACHHANG()
		{
			this._DONDATHANGs = new EntitySet<DONDATHANG>(new Action<DONDATHANG>(this.attach_DONDATHANGs), new Action<DONDATHANG>(this.detach_DONDATHANGs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKH", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaKH
		{
			get
			{
				return this._MaKH;
			}
			set
			{
				if ((this._MaKH != value))
				{
					this.OnMaKHChanging(value);
					this.SendPropertyChanging();
					this._MaKH = value;
					this.SendPropertyChanged("MaKH");
					this.OnMaKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoTen", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string HoTen
		{
			get
			{
				return this._HoTen;
			}
			set
			{
				if ((this._HoTen != value))
				{
					this.OnHoTenChanging(value);
					this.SendPropertyChanging();
					this._HoTen = value;
					this.SendPropertyChanged("HoTen");
					this.OnHoTenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Taikhoan", DbType="VarChar(50)")]
		public string Taikhoan
		{
			get
			{
				return this._Taikhoan;
			}
			set
			{
				if ((this._Taikhoan != value))
				{
					this.OnTaikhoanChanging(value);
					this.SendPropertyChanging();
					this._Taikhoan = value;
					this.SendPropertyChanged("Taikhoan");
					this.OnTaikhoanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Matkhau", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Matkhau
		{
			get
			{
				return this._Matkhau;
			}
			set
			{
				if ((this._Matkhau != value))
				{
					this.OnMatkhauChanging(value);
					this.SendPropertyChanging();
					this._Matkhau = value;
					this.SendPropertyChanged("Matkhau");
					this.OnMatkhauChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(100)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiachiKH", DbType="NVarChar(200)")]
		public string DiachiKH
		{
			get
			{
				return this._DiachiKH;
			}
			set
			{
				if ((this._DiachiKH != value))
				{
					this.OnDiachiKHChanging(value);
					this.SendPropertyChanging();
					this._DiachiKH = value;
					this.SendPropertyChanged("DiachiKH");
					this.OnDiachiKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DienthoaiKH", DbType="VarChar(50)")]
		public string DienthoaiKH
		{
			get
			{
				return this._DienthoaiKH;
			}
			set
			{
				if ((this._DienthoaiKH != value))
				{
					this.OnDienthoaiKHChanging(value);
					this.SendPropertyChanging();
					this._DienthoaiKH = value;
					this.SendPropertyChanged("DienthoaiKH");
					this.OnDienthoaiKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ngaysinh", DbType="DateTime")]
		public System.Nullable<System.DateTime> Ngaysinh
		{
			get
			{
				return this._Ngaysinh;
			}
			set
			{
				if ((this._Ngaysinh != value))
				{
					this.OnNgaysinhChanging(value);
					this.SendPropertyChanging();
					this._Ngaysinh = value;
					this.SendPropertyChanged("Ngaysinh");
					this.OnNgaysinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KHACHHANG_DONDATHANG", Storage="_DONDATHANGs", ThisKey="MaKH", OtherKey="MaKH")]
		public EntitySet<DONDATHANG> DONDATHANGs
		{
			get
			{
				return this._DONDATHANGs;
			}
			set
			{
				this._DONDATHANGs.Assign(value);
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
		
		private void attach_DONDATHANGs(DONDATHANG entity)
		{
			this.SendPropertyChanging();
			entity.KHACHHANG = this;
		}
		
		private void detach_DONDATHANGs(DONDATHANG entity)
		{
			this.SendPropertyChanging();
			entity.KHACHHANG = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.LoaiSanPham")]
	public partial class LoaiSanPham : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaLSP;
		
		private string _TenLSP;
		
		private EntitySet<SanPham> _SanPhams;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaLSPChanging(int value);
    partial void OnMaLSPChanged();
    partial void OnTenLSPChanging(string value);
    partial void OnTenLSPChanged();
    #endregion
		
		public LoaiSanPham()
		{
			this._SanPhams = new EntitySet<SanPham>(new Action<SanPham>(this.attach_SanPhams), new Action<SanPham>(this.detach_SanPhams));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaLSP", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaLSP
		{
			get
			{
				return this._MaLSP;
			}
			set
			{
				if ((this._MaLSP != value))
				{
					this.OnMaLSPChanging(value);
					this.SendPropertyChanging();
					this._MaLSP = value;
					this.SendPropertyChanged("MaLSP");
					this.OnMaLSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenLSP", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TenLSP
		{
			get
			{
				return this._TenLSP;
			}
			set
			{
				if ((this._TenLSP != value))
				{
					this.OnTenLSPChanging(value);
					this.SendPropertyChanging();
					this._TenLSP = value;
					this.SendPropertyChanged("TenLSP");
					this.OnTenLSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LoaiSanPham_SanPham", Storage="_SanPhams", ThisKey="MaLSP", OtherKey="MaLSP")]
		public EntitySet<SanPham> SanPhams
		{
			get
			{
				return this._SanPhams;
			}
			set
			{
				this._SanPhams.Assign(value);
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
		
		private void attach_SanPhams(SanPham entity)
		{
			this.SendPropertyChanging();
			entity.LoaiSanPham = this;
		}
		
		private void detach_SanPhams(SanPham entity)
		{
			this.SendPropertyChanging();
			entity.LoaiSanPham = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NhaSanXuat")]
	public partial class NhaSanXuat : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaNSX;
		
		private string _TenNSX;
		
		private EntitySet<SanPham> _SanPhams;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaNSXChanging(int value);
    partial void OnMaNSXChanged();
    partial void OnTenNSXChanging(string value);
    partial void OnTenNSXChanged();
    #endregion
		
		public NhaSanXuat()
		{
			this._SanPhams = new EntitySet<SanPham>(new Action<SanPham>(this.attach_SanPhams), new Action<SanPham>(this.detach_SanPhams));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNSX", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaNSX
		{
			get
			{
				return this._MaNSX;
			}
			set
			{
				if ((this._MaNSX != value))
				{
					this.OnMaNSXChanging(value);
					this.SendPropertyChanging();
					this._MaNSX = value;
					this.SendPropertyChanged("MaNSX");
					this.OnMaNSXChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenNSX", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TenNSX
		{
			get
			{
				return this._TenNSX;
			}
			set
			{
				if ((this._TenNSX != value))
				{
					this.OnTenNSXChanging(value);
					this.SendPropertyChanging();
					this._TenNSX = value;
					this.SendPropertyChanged("TenNSX");
					this.OnTenNSXChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NhaSanXuat_SanPham", Storage="_SanPhams", ThisKey="MaNSX", OtherKey="MaNSX")]
		public EntitySet<SanPham> SanPhams
		{
			get
			{
				return this._SanPhams;
			}
			set
			{
				this._SanPhams.Assign(value);
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
		
		private void attach_SanPhams(SanPham entity)
		{
			this.SendPropertyChanging();
			entity.NhaSanXuat = this;
		}
		
		private void detach_SanPhams(SanPham entity)
		{
			this.SendPropertyChanging();
			entity.NhaSanXuat = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SanPham")]
	public partial class SanPham : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaSP;
		
		private string _TenSP;
		
		private System.Nullable<decimal> _Giaban;
		
		private string _Mota;
		
		private string _HinhChinh;
		
		private string _Hinh1;
		
		private string _Hinh2;
		
		private string _Hinh3;
		
		private string _Hinh4;
		
		private System.Nullable<System.DateTime> _Ngaycapnhat;
		
		private System.Nullable<int> _Soluongton;
		
		private System.Nullable<int> _MaLSP;
		
		private System.Nullable<int> _MaNSX;
		
		private EntitySet<CHITIETDONTHANG> _CHITIETDONTHANGs;
		
		private EntityRef<LoaiSanPham> _LoaiSanPham;
		
		private EntityRef<NhaSanXuat> _NhaSanXuat;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaSPChanging(int value);
    partial void OnMaSPChanged();
    partial void OnTenSPChanging(string value);
    partial void OnTenSPChanged();
    partial void OnGiabanChanging(System.Nullable<decimal> value);
    partial void OnGiabanChanged();
    partial void OnMotaChanging(string value);
    partial void OnMotaChanged();
    partial void OnHinhChinhChanging(string value);
    partial void OnHinhChinhChanged();
    partial void OnHinh1Changing(string value);
    partial void OnHinh1Changed();
    partial void OnHinh2Changing(string value);
    partial void OnHinh2Changed();
    partial void OnHinh3Changing(string value);
    partial void OnHinh3Changed();
    partial void OnHinh4Changing(string value);
    partial void OnHinh4Changed();
    partial void OnNgaycapnhatChanging(System.Nullable<System.DateTime> value);
    partial void OnNgaycapnhatChanged();
    partial void OnSoluongtonChanging(System.Nullable<int> value);
    partial void OnSoluongtonChanged();
    partial void OnMaLSPChanging(System.Nullable<int> value);
    partial void OnMaLSPChanged();
    partial void OnMaNSXChanging(System.Nullable<int> value);
    partial void OnMaNSXChanged();
    #endregion
		
		public SanPham()
		{
			this._CHITIETDONTHANGs = new EntitySet<CHITIETDONTHANG>(new Action<CHITIETDONTHANG>(this.attach_CHITIETDONTHANGs), new Action<CHITIETDONTHANG>(this.detach_CHITIETDONTHANGs));
			this._LoaiSanPham = default(EntityRef<LoaiSanPham>);
			this._NhaSanXuat = default(EntityRef<NhaSanXuat>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSP", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaSP
		{
			get
			{
				return this._MaSP;
			}
			set
			{
				if ((this._MaSP != value))
				{
					this.OnMaSPChanging(value);
					this.SendPropertyChanging();
					this._MaSP = value;
					this.SendPropertyChanged("MaSP");
					this.OnMaSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenSP", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string TenSP
		{
			get
			{
				return this._TenSP;
			}
			set
			{
				if ((this._TenSP != value))
				{
					this.OnTenSPChanging(value);
					this.SendPropertyChanging();
					this._TenSP = value;
					this.SendPropertyChanged("TenSP");
					this.OnTenSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Giaban", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> Giaban
		{
			get
			{
				return this._Giaban;
			}
			set
			{
				if ((this._Giaban != value))
				{
					this.OnGiabanChanging(value);
					this.SendPropertyChanging();
					this._Giaban = value;
					this.SendPropertyChanged("Giaban");
					this.OnGiabanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mota", DbType="NVarChar(MAX)")]
		public string Mota
		{
			get
			{
				return this._Mota;
			}
			set
			{
				if ((this._Mota != value))
				{
					this.OnMotaChanging(value);
					this.SendPropertyChanging();
					this._Mota = value;
					this.SendPropertyChanged("Mota");
					this.OnMotaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HinhChinh", DbType="VarChar(50)")]
		public string HinhChinh
		{
			get
			{
				return this._HinhChinh;
			}
			set
			{
				if ((this._HinhChinh != value))
				{
					this.OnHinhChinhChanging(value);
					this.SendPropertyChanging();
					this._HinhChinh = value;
					this.SendPropertyChanged("HinhChinh");
					this.OnHinhChinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Hinh1", DbType="VarChar(50)")]
		public string Hinh1
		{
			get
			{
				return this._Hinh1;
			}
			set
			{
				if ((this._Hinh1 != value))
				{
					this.OnHinh1Changing(value);
					this.SendPropertyChanging();
					this._Hinh1 = value;
					this.SendPropertyChanged("Hinh1");
					this.OnHinh1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Hinh2", DbType="VarChar(50)")]
		public string Hinh2
		{
			get
			{
				return this._Hinh2;
			}
			set
			{
				if ((this._Hinh2 != value))
				{
					this.OnHinh2Changing(value);
					this.SendPropertyChanging();
					this._Hinh2 = value;
					this.SendPropertyChanged("Hinh2");
					this.OnHinh2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Hinh3", DbType="VarChar(50)")]
		public string Hinh3
		{
			get
			{
				return this._Hinh3;
			}
			set
			{
				if ((this._Hinh3 != value))
				{
					this.OnHinh3Changing(value);
					this.SendPropertyChanging();
					this._Hinh3 = value;
					this.SendPropertyChanged("Hinh3");
					this.OnHinh3Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Hinh4", DbType="VarChar(50)")]
		public string Hinh4
		{
			get
			{
				return this._Hinh4;
			}
			set
			{
				if ((this._Hinh4 != value))
				{
					this.OnHinh4Changing(value);
					this.SendPropertyChanging();
					this._Hinh4 = value;
					this.SendPropertyChanged("Hinh4");
					this.OnHinh4Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ngaycapnhat", DbType="DateTime")]
		public System.Nullable<System.DateTime> Ngaycapnhat
		{
			get
			{
				return this._Ngaycapnhat;
			}
			set
			{
				if ((this._Ngaycapnhat != value))
				{
					this.OnNgaycapnhatChanging(value);
					this.SendPropertyChanging();
					this._Ngaycapnhat = value;
					this.SendPropertyChanged("Ngaycapnhat");
					this.OnNgaycapnhatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Soluongton", DbType="Int")]
		public System.Nullable<int> Soluongton
		{
			get
			{
				return this._Soluongton;
			}
			set
			{
				if ((this._Soluongton != value))
				{
					this.OnSoluongtonChanging(value);
					this.SendPropertyChanging();
					this._Soluongton = value;
					this.SendPropertyChanged("Soluongton");
					this.OnSoluongtonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaLSP", DbType="Int")]
		public System.Nullable<int> MaLSP
		{
			get
			{
				return this._MaLSP;
			}
			set
			{
				if ((this._MaLSP != value))
				{
					if (this._LoaiSanPham.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaLSPChanging(value);
					this.SendPropertyChanging();
					this._MaLSP = value;
					this.SendPropertyChanged("MaLSP");
					this.OnMaLSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNSX", DbType="Int")]
		public System.Nullable<int> MaNSX
		{
			get
			{
				return this._MaNSX;
			}
			set
			{
				if ((this._MaNSX != value))
				{
					if (this._NhaSanXuat.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaNSXChanging(value);
					this.SendPropertyChanging();
					this._MaNSX = value;
					this.SendPropertyChanged("MaNSX");
					this.OnMaNSXChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SanPham_CHITIETDONTHANG", Storage="_CHITIETDONTHANGs", ThisKey="MaSP", OtherKey="MaSP")]
		public EntitySet<CHITIETDONTHANG> CHITIETDONTHANGs
		{
			get
			{
				return this._CHITIETDONTHANGs;
			}
			set
			{
				this._CHITIETDONTHANGs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LoaiSanPham_SanPham", Storage="_LoaiSanPham", ThisKey="MaLSP", OtherKey="MaLSP", IsForeignKey=true)]
		public LoaiSanPham LoaiSanPham
		{
			get
			{
				return this._LoaiSanPham.Entity;
			}
			set
			{
				LoaiSanPham previousValue = this._LoaiSanPham.Entity;
				if (((previousValue != value) 
							|| (this._LoaiSanPham.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._LoaiSanPham.Entity = null;
						previousValue.SanPhams.Remove(this);
					}
					this._LoaiSanPham.Entity = value;
					if ((value != null))
					{
						value.SanPhams.Add(this);
						this._MaLSP = value.MaLSP;
					}
					else
					{
						this._MaLSP = default(Nullable<int>);
					}
					this.SendPropertyChanged("LoaiSanPham");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NhaSanXuat_SanPham", Storage="_NhaSanXuat", ThisKey="MaNSX", OtherKey="MaNSX", IsForeignKey=true)]
		public NhaSanXuat NhaSanXuat
		{
			get
			{
				return this._NhaSanXuat.Entity;
			}
			set
			{
				NhaSanXuat previousValue = this._NhaSanXuat.Entity;
				if (((previousValue != value) 
							|| (this._NhaSanXuat.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._NhaSanXuat.Entity = null;
						previousValue.SanPhams.Remove(this);
					}
					this._NhaSanXuat.Entity = value;
					if ((value != null))
					{
						value.SanPhams.Add(this);
						this._MaNSX = value.MaNSX;
					}
					else
					{
						this._MaNSX = default(Nullable<int>);
					}
					this.SendPropertyChanged("NhaSanXuat");
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
		
		private void attach_CHITIETDONTHANGs(CHITIETDONTHANG entity)
		{
			this.SendPropertyChanging();
			entity.SanPham = this;
		}
		
		private void detach_CHITIETDONTHANGs(CHITIETDONTHANG entity)
		{
			this.SendPropertyChanging();
			entity.SanPham = null;
		}
	}
}
#pragma warning restore 1591
