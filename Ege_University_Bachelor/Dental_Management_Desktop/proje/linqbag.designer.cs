﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace proje
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="DisHekimi")]
	public partial class linqbagDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertDoctor(Doctor instance);
    partial void UpdateDoctor(Doctor instance);
    partial void DeleteDoctor(Doctor instance);
    partial void Insertİslem(İslem instance);
    partial void Updateİslem(İslem instance);
    partial void Deleteİslem(İslem instance);
    partial void InsertKayıt(Kayıt instance);
    partial void UpdateKayıt(Kayıt instance);
    partial void DeleteKayıt(Kayıt instance);
    partial void InsertPerson(Person instance);
    partial void UpdatePerson(Person instance);
    partial void DeletePerson(Person instance);
    #endregion
		
		public linqbagDataContext() : 
				base(global::proje.Properties.Settings.Default.DisHekimiConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public linqbagDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public linqbagDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public linqbagDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public linqbagDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Doctor> Doctors
		{
			get
			{
				return this.GetTable<Doctor>();
			}
		}
		
		public System.Data.Linq.Table<İslem> İslems
		{
			get
			{
				return this.GetTable<İslem>();
			}
		}
		
		public System.Data.Linq.Table<Kayıt> Kayıts
		{
			get
			{
				return this.GetTable<Kayıt>();
			}
		}
		
		public System.Data.Linq.Table<Person> Persons
		{
			get
			{
				return this.GetTable<Person>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Doctor")]
	public partial class Doctor : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _TC_kimlik;
		
		private string _AdSoyad;
		
		private string _SicilNo;
		
		private string _Ceptel;
		
		private string _Evtel;
		
		private bool _Cinsiyet;
		
		private string _il;
		
		private string _ilce;
		
		private string _Adres;
		
		private string _Email;
		
		private EntitySet<İslem> _İslems;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTC_kimlikChanging(string value);
    partial void OnTC_kimlikChanged();
    partial void OnAdSoyadChanging(string value);
    partial void OnAdSoyadChanged();
    partial void OnSicilNoChanging(string value);
    partial void OnSicilNoChanged();
    partial void OnCeptelChanging(string value);
    partial void OnCeptelChanged();
    partial void OnEvtelChanging(string value);
    partial void OnEvtelChanged();
    partial void OnCinsiyetChanging(bool value);
    partial void OnCinsiyetChanged();
    partial void OnilChanging(string value);
    partial void OnilChanged();
    partial void OnilceChanging(string value);
    partial void OnilceChanged();
    partial void OnAdresChanging(string value);
    partial void OnAdresChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    #endregion
		
		public Doctor()
		{
			this._İslems = new EntitySet<İslem>(new Action<İslem>(this.attach_İslems), new Action<İslem>(this.detach_İslems));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TC_kimlik", DbType="NVarChar(11) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string TC_kimlik
		{
			get
			{
				return this._TC_kimlik;
			}
			set
			{
				if ((this._TC_kimlik != value))
				{
					this.OnTC_kimlikChanging(value);
					this.SendPropertyChanging();
					this._TC_kimlik = value;
					this.SendPropertyChanged("TC_kimlik");
					this.OnTC_kimlikChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AdSoyad", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string AdSoyad
		{
			get
			{
				return this._AdSoyad;
			}
			set
			{
				if ((this._AdSoyad != value))
				{
					this.OnAdSoyadChanging(value);
					this.SendPropertyChanging();
					this._AdSoyad = value;
					this.SendPropertyChanged("AdSoyad");
					this.OnAdSoyadChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SicilNo", DbType="NVarChar(11)")]
		public string SicilNo
		{
			get
			{
				return this._SicilNo;
			}
			set
			{
				if ((this._SicilNo != value))
				{
					this.OnSicilNoChanging(value);
					this.SendPropertyChanging();
					this._SicilNo = value;
					this.SendPropertyChanged("SicilNo");
					this.OnSicilNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ceptel", DbType="NVarChar(11)")]
		public string Ceptel
		{
			get
			{
				return this._Ceptel;
			}
			set
			{
				if ((this._Ceptel != value))
				{
					this.OnCeptelChanging(value);
					this.SendPropertyChanging();
					this._Ceptel = value;
					this.SendPropertyChanged("Ceptel");
					this.OnCeptelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Evtel", DbType="NVarChar(11)")]
		public string Evtel
		{
			get
			{
				return this._Evtel;
			}
			set
			{
				if ((this._Evtel != value))
				{
					this.OnEvtelChanging(value);
					this.SendPropertyChanging();
					this._Evtel = value;
					this.SendPropertyChanged("Evtel");
					this.OnEvtelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cinsiyet", DbType="Bit NOT NULL")]
		public bool Cinsiyet
		{
			get
			{
				return this._Cinsiyet;
			}
			set
			{
				if ((this._Cinsiyet != value))
				{
					this.OnCinsiyetChanging(value);
					this.SendPropertyChanging();
					this._Cinsiyet = value;
					this.SendPropertyChanged("Cinsiyet");
					this.OnCinsiyetChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_il", DbType="NVarChar(50)")]
		public string il
		{
			get
			{
				return this._il;
			}
			set
			{
				if ((this._il != value))
				{
					this.OnilChanging(value);
					this.SendPropertyChanging();
					this._il = value;
					this.SendPropertyChanged("il");
					this.OnilChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ilce", DbType="NVarChar(50)")]
		public string ilce
		{
			get
			{
				return this._ilce;
			}
			set
			{
				if ((this._ilce != value))
				{
					this.OnilceChanging(value);
					this.SendPropertyChanging();
					this._ilce = value;
					this.SendPropertyChanged("ilce");
					this.OnilceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Adres", DbType="NVarChar(100)")]
		public string Adres
		{
			get
			{
				return this._Adres;
			}
			set
			{
				if ((this._Adres != value))
				{
					this.OnAdresChanging(value);
					this.SendPropertyChanging();
					this._Adres = value;
					this.SendPropertyChanged("Adres");
					this.OnAdresChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Doctor_İslem", Storage="_İslems", ThisKey="TC_kimlik", OtherKey="Doktor_TC")]
		public EntitySet<İslem> İslems
		{
			get
			{
				return this._İslems;
			}
			set
			{
				this._İslems.Assign(value);
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
		
		private void attach_İslems(İslem entity)
		{
			this.SendPropertyChanging();
			entity.Doctor = this;
		}
		
		private void detach_İslems(İslem entity)
		{
			this.SendPropertyChanging();
			entity.Doctor = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.İslem")]
	public partial class İslem : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _RezID;
		
		private System.DateTime _RezTarihi;
		
		private string _MuayaneTur;
		
		private string _Doktor_TC;
		
		private string _Hasta_TC;
		
		private string _Saat;
		
		private EntityRef<Doctor> _Doctor;
		
		private EntityRef<Person> _Person;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnRezIDChanging(int value);
    partial void OnRezIDChanged();
    partial void OnRezTarihiChanging(System.DateTime value);
    partial void OnRezTarihiChanged();
    partial void OnMuayaneTurChanging(string value);
    partial void OnMuayaneTurChanged();
    partial void OnDoktor_TCChanging(string value);
    partial void OnDoktor_TCChanged();
    partial void OnHasta_TCChanging(string value);
    partial void OnHasta_TCChanged();
    partial void OnSaatChanging(string value);
    partial void OnSaatChanged();
    #endregion
		
		public İslem()
		{
			this._Doctor = default(EntityRef<Doctor>);
			this._Person = default(EntityRef<Person>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RezID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int RezID
		{
			get
			{
				return this._RezID;
			}
			set
			{
				if ((this._RezID != value))
				{
					this.OnRezIDChanging(value);
					this.SendPropertyChanging();
					this._RezID = value;
					this.SendPropertyChanged("RezID");
					this.OnRezIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RezTarihi", DbType="Date NOT NULL")]
		public System.DateTime RezTarihi
		{
			get
			{
				return this._RezTarihi;
			}
			set
			{
				if ((this._RezTarihi != value))
				{
					this.OnRezTarihiChanging(value);
					this.SendPropertyChanging();
					this._RezTarihi = value;
					this.SendPropertyChanged("RezTarihi");
					this.OnRezTarihiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MuayaneTur", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string MuayaneTur
		{
			get
			{
				return this._MuayaneTur;
			}
			set
			{
				if ((this._MuayaneTur != value))
				{
					this.OnMuayaneTurChanging(value);
					this.SendPropertyChanging();
					this._MuayaneTur = value;
					this.SendPropertyChanged("MuayaneTur");
					this.OnMuayaneTurChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Doktor_TC", DbType="NVarChar(11) NOT NULL", CanBeNull=false)]
		public string Doktor_TC
		{
			get
			{
				return this._Doktor_TC;
			}
			set
			{
				if ((this._Doktor_TC != value))
				{
					if (this._Doctor.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnDoktor_TCChanging(value);
					this.SendPropertyChanging();
					this._Doktor_TC = value;
					this.SendPropertyChanged("Doktor_TC");
					this.OnDoktor_TCChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Hasta_TC", DbType="NVarChar(11) NOT NULL", CanBeNull=false)]
		public string Hasta_TC
		{
			get
			{
				return this._Hasta_TC;
			}
			set
			{
				if ((this._Hasta_TC != value))
				{
					if (this._Person.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnHasta_TCChanging(value);
					this.SendPropertyChanging();
					this._Hasta_TC = value;
					this.SendPropertyChanged("Hasta_TC");
					this.OnHasta_TCChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Saat", DbType="NVarChar(5) NOT NULL", CanBeNull=false)]
		public string Saat
		{
			get
			{
				return this._Saat;
			}
			set
			{
				if ((this._Saat != value))
				{
					this.OnSaatChanging(value);
					this.SendPropertyChanging();
					this._Saat = value;
					this.SendPropertyChanged("Saat");
					this.OnSaatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Doctor_İslem", Storage="_Doctor", ThisKey="Doktor_TC", OtherKey="TC_kimlik", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public Doctor Doctor
		{
			get
			{
				return this._Doctor.Entity;
			}
			set
			{
				Doctor previousValue = this._Doctor.Entity;
				if (((previousValue != value) 
							|| (this._Doctor.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Doctor.Entity = null;
						previousValue.İslems.Remove(this);
					}
					this._Doctor.Entity = value;
					if ((value != null))
					{
						value.İslems.Add(this);
						this._Doktor_TC = value.TC_kimlik;
					}
					else
					{
						this._Doktor_TC = default(string);
					}
					this.SendPropertyChanged("Doctor");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Person_İslem", Storage="_Person", ThisKey="Hasta_TC", OtherKey="TC_kimlik", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public Person Person
		{
			get
			{
				return this._Person.Entity;
			}
			set
			{
				Person previousValue = this._Person.Entity;
				if (((previousValue != value) 
							|| (this._Person.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Person.Entity = null;
						previousValue.İslems.Remove(this);
					}
					this._Person.Entity = value;
					if ((value != null))
					{
						value.İslems.Add(this);
						this._Hasta_TC = value.TC_kimlik;
					}
					else
					{
						this._Hasta_TC = default(string);
					}
					this.SendPropertyChanged("Person");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Kayıt")]
	public partial class Kayıt : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _K_Adi;
		
		private string _sifre;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnK_AdiChanging(string value);
    partial void OnK_AdiChanged();
    partial void OnsifreChanging(string value);
    partial void OnsifreChanged();
    #endregion
		
		public Kayıt()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_K_Adi", DbType="NVarChar(25) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string K_Adi
		{
			get
			{
				return this._K_Adi;
			}
			set
			{
				if ((this._K_Adi != value))
				{
					this.OnK_AdiChanging(value);
					this.SendPropertyChanging();
					this._K_Adi = value;
					this.SendPropertyChanged("K_Adi");
					this.OnK_AdiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sifre", DbType="NVarChar(11) NOT NULL", CanBeNull=false)]
		public string sifre
		{
			get
			{
				return this._sifre;
			}
			set
			{
				if ((this._sifre != value))
				{
					this.OnsifreChanging(value);
					this.SendPropertyChanging();
					this._sifre = value;
					this.SendPropertyChanged("sifre");
					this.OnsifreChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Person")]
	public partial class Person : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _TC_kimlik;
		
		private string _AdSoyad;
		
		private string _BabaAdı;
		
		private string _AnaAdı;
		
		private string _DogumYeri;
		
		private System.Nullable<System.DateTime> _DogumTarihi;
		
		private bool _Cinsiyet;
		
		private string _SosyalGüvence;
		
		private string _SGNO;
		
		private bool _MedeniDurum;
		
		private string _il;
		
		private string _ilce;
		
		private string _Adres;
		
		private System.Nullable<int> _PostaKodu;
		
		private string _Email;
		
		private string _Ceptel;
		
		private string _Evtel;
		
		private EntitySet<İslem> _İslems;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTC_kimlikChanging(string value);
    partial void OnTC_kimlikChanged();
    partial void OnAdSoyadChanging(string value);
    partial void OnAdSoyadChanged();
    partial void OnBabaAdıChanging(string value);
    partial void OnBabaAdıChanged();
    partial void OnAnaAdıChanging(string value);
    partial void OnAnaAdıChanged();
    partial void OnDogumYeriChanging(string value);
    partial void OnDogumYeriChanged();
    partial void OnDogumTarihiChanging(System.Nullable<System.DateTime> value);
    partial void OnDogumTarihiChanged();
    partial void OnCinsiyetChanging(bool value);
    partial void OnCinsiyetChanged();
    partial void OnSosyalGüvenceChanging(string value);
    partial void OnSosyalGüvenceChanged();
    partial void OnSGNOChanging(string value);
    partial void OnSGNOChanged();
    partial void OnMedeniDurumChanging(bool value);
    partial void OnMedeniDurumChanged();
    partial void OnilChanging(string value);
    partial void OnilChanged();
    partial void OnilceChanging(string value);
    partial void OnilceChanged();
    partial void OnAdresChanging(string value);
    partial void OnAdresChanged();
    partial void OnPostaKoduChanging(System.Nullable<int> value);
    partial void OnPostaKoduChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnCeptelChanging(string value);
    partial void OnCeptelChanged();
    partial void OnEvtelChanging(string value);
    partial void OnEvtelChanged();
    #endregion
		
		public Person()
		{
			this._İslems = new EntitySet<İslem>(new Action<İslem>(this.attach_İslems), new Action<İslem>(this.detach_İslems));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TC_kimlik", DbType="NVarChar(11) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string TC_kimlik
		{
			get
			{
				return this._TC_kimlik;
			}
			set
			{
				if ((this._TC_kimlik != value))
				{
					this.OnTC_kimlikChanging(value);
					this.SendPropertyChanging();
					this._TC_kimlik = value;
					this.SendPropertyChanged("TC_kimlik");
					this.OnTC_kimlikChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AdSoyad", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string AdSoyad
		{
			get
			{
				return this._AdSoyad;
			}
			set
			{
				if ((this._AdSoyad != value))
				{
					this.OnAdSoyadChanging(value);
					this.SendPropertyChanging();
					this._AdSoyad = value;
					this.SendPropertyChanged("AdSoyad");
					this.OnAdSoyadChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BabaAdı", DbType="NVarChar(50)")]
		public string BabaAdı
		{
			get
			{
				return this._BabaAdı;
			}
			set
			{
				if ((this._BabaAdı != value))
				{
					this.OnBabaAdıChanging(value);
					this.SendPropertyChanging();
					this._BabaAdı = value;
					this.SendPropertyChanged("BabaAdı");
					this.OnBabaAdıChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AnaAdı", DbType="NVarChar(50)")]
		public string AnaAdı
		{
			get
			{
				return this._AnaAdı;
			}
			set
			{
				if ((this._AnaAdı != value))
				{
					this.OnAnaAdıChanging(value);
					this.SendPropertyChanging();
					this._AnaAdı = value;
					this.SendPropertyChanged("AnaAdı");
					this.OnAnaAdıChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DogumYeri", DbType="NVarChar(50)")]
		public string DogumYeri
		{
			get
			{
				return this._DogumYeri;
			}
			set
			{
				if ((this._DogumYeri != value))
				{
					this.OnDogumYeriChanging(value);
					this.SendPropertyChanging();
					this._DogumYeri = value;
					this.SendPropertyChanged("DogumYeri");
					this.OnDogumYeriChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DogumTarihi", DbType="Date")]
		public System.Nullable<System.DateTime> DogumTarihi
		{
			get
			{
				return this._DogumTarihi;
			}
			set
			{
				if ((this._DogumTarihi != value))
				{
					this.OnDogumTarihiChanging(value);
					this.SendPropertyChanging();
					this._DogumTarihi = value;
					this.SendPropertyChanged("DogumTarihi");
					this.OnDogumTarihiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cinsiyet", DbType="Bit NOT NULL")]
		public bool Cinsiyet
		{
			get
			{
				return this._Cinsiyet;
			}
			set
			{
				if ((this._Cinsiyet != value))
				{
					this.OnCinsiyetChanging(value);
					this.SendPropertyChanging();
					this._Cinsiyet = value;
					this.SendPropertyChanged("Cinsiyet");
					this.OnCinsiyetChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SosyalGüvence", DbType="NVarChar(50)")]
		public string SosyalGüvence
		{
			get
			{
				return this._SosyalGüvence;
			}
			set
			{
				if ((this._SosyalGüvence != value))
				{
					this.OnSosyalGüvenceChanging(value);
					this.SendPropertyChanging();
					this._SosyalGüvence = value;
					this.SendPropertyChanged("SosyalGüvence");
					this.OnSosyalGüvenceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SGNO", DbType="NVarChar(11)")]
		public string SGNO
		{
			get
			{
				return this._SGNO;
			}
			set
			{
				if ((this._SGNO != value))
				{
					this.OnSGNOChanging(value);
					this.SendPropertyChanging();
					this._SGNO = value;
					this.SendPropertyChanged("SGNO");
					this.OnSGNOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MedeniDurum", DbType="Bit NOT NULL")]
		public bool MedeniDurum
		{
			get
			{
				return this._MedeniDurum;
			}
			set
			{
				if ((this._MedeniDurum != value))
				{
					this.OnMedeniDurumChanging(value);
					this.SendPropertyChanging();
					this._MedeniDurum = value;
					this.SendPropertyChanged("MedeniDurum");
					this.OnMedeniDurumChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_il", DbType="NVarChar(50)")]
		public string il
		{
			get
			{
				return this._il;
			}
			set
			{
				if ((this._il != value))
				{
					this.OnilChanging(value);
					this.SendPropertyChanging();
					this._il = value;
					this.SendPropertyChanged("il");
					this.OnilChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ilce", DbType="NVarChar(50)")]
		public string ilce
		{
			get
			{
				return this._ilce;
			}
			set
			{
				if ((this._ilce != value))
				{
					this.OnilceChanging(value);
					this.SendPropertyChanging();
					this._ilce = value;
					this.SendPropertyChanged("ilce");
					this.OnilceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Adres", DbType="NVarChar(100)")]
		public string Adres
		{
			get
			{
				return this._Adres;
			}
			set
			{
				if ((this._Adres != value))
				{
					this.OnAdresChanging(value);
					this.SendPropertyChanging();
					this._Adres = value;
					this.SendPropertyChanged("Adres");
					this.OnAdresChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PostaKodu", DbType="Int")]
		public System.Nullable<int> PostaKodu
		{
			get
			{
				return this._PostaKodu;
			}
			set
			{
				if ((this._PostaKodu != value))
				{
					this.OnPostaKoduChanging(value);
					this.SendPropertyChanging();
					this._PostaKodu = value;
					this.SendPropertyChanged("PostaKodu");
					this.OnPostaKoduChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ceptel", DbType="NVarChar(11)")]
		public string Ceptel
		{
			get
			{
				return this._Ceptel;
			}
			set
			{
				if ((this._Ceptel != value))
				{
					this.OnCeptelChanging(value);
					this.SendPropertyChanging();
					this._Ceptel = value;
					this.SendPropertyChanged("Ceptel");
					this.OnCeptelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Evtel", DbType="NVarChar(50)")]
		public string Evtel
		{
			get
			{
				return this._Evtel;
			}
			set
			{
				if ((this._Evtel != value))
				{
					this.OnEvtelChanging(value);
					this.SendPropertyChanging();
					this._Evtel = value;
					this.SendPropertyChanged("Evtel");
					this.OnEvtelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Person_İslem", Storage="_İslems", ThisKey="TC_kimlik", OtherKey="Hasta_TC")]
		public EntitySet<İslem> İslems
		{
			get
			{
				return this._İslems;
			}
			set
			{
				this._İslems.Assign(value);
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
		
		private void attach_İslems(İslem entity)
		{
			this.SendPropertyChanging();
			entity.Person = this;
		}
		
		private void detach_İslems(İslem entity)
		{
			this.SendPropertyChanging();
			entity.Person = null;
		}
	}
}
#pragma warning restore 1591
