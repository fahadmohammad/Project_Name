﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StartingForm
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="MillionaireDB")]
	public partial class MillionaireLinqDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertQuestion(Question instance);
    partial void UpdateQuestion(Question instance);
    partial void DeleteQuestion(Question instance);
    partial void InsertA1(A1 instance);
    partial void UpdateA1(A1 instance);
    partial void DeleteA1(A1 instance);
    partial void InsertA4(A4 instance);
    partial void UpdateA4(A4 instance);
    partial void DeleteA4(A4 instance);
    partial void InsertRA(RA instance);
    partial void UpdateRA(RA instance);
    partial void DeleteRA(RA instance);
    partial void InsertA2(A2 instance);
    partial void UpdateA2(A2 instance);
    partial void DeleteA2(A2 instance);
    partial void InsertA3(A3 instance);
    partial void UpdateA3(A3 instance);
    partial void DeleteA3(A3 instance);
    #endregion
		
		public MillionaireLinqDataContext() : 
				base(global::StartingForm.Properties.Settings.Default.MillionaireDBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public MillionaireLinqDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MillionaireLinqDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MillionaireLinqDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MillionaireLinqDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Question> Questions
		{
			get
			{
				return this.GetTable<Question>();
			}
		}
		
		public System.Data.Linq.Table<A1> A1s
		{
			get
			{
				return this.GetTable<A1>();
			}
		}
		
		public System.Data.Linq.Table<A4> A4s
		{
			get
			{
				return this.GetTable<A4>();
			}
		}
		
		public System.Data.Linq.Table<RA> RAs
		{
			get
			{
				return this.GetTable<RA>();
			}
		}
		
		public System.Data.Linq.Table<A2> A2s
		{
			get
			{
				return this.GetTable<A2>();
			}
		}
		
		public System.Data.Linq.Table<A3> A3s
		{
			get
			{
				return this.GetTable<A3>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Question")]
	public partial class Question : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _QNo;
		
		private string _QLine;
		
		private EntityRef<A1> _A1;
		
		private EntityRef<A4> _A4;
		
		private EntityRef<RA> _RA;
		
		private EntityRef<A2> _A2;
		
		private EntityRef<A3> _A3;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnQNoChanging(int value);
    partial void OnQNoChanged();
    partial void OnQLineChanging(string value);
    partial void OnQLineChanged();
    #endregion
		
		public Question()
		{
			this._A1 = default(EntityRef<A1>);
			this._A4 = default(EntityRef<A4>);
			this._RA = default(EntityRef<RA>);
			this._A2 = default(EntityRef<A2>);
			this._A3 = default(EntityRef<A3>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QNo", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int QNo
		{
			get
			{
				return this._QNo;
			}
			set
			{
				if ((this._QNo != value))
				{
					if (((((this._A1.HasLoadedOrAssignedValue || this._A4.HasLoadedOrAssignedValue) 
								|| this._RA.HasLoadedOrAssignedValue) 
								|| this._A2.HasLoadedOrAssignedValue) 
								|| this._A3.HasLoadedOrAssignedValue))
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnQNoChanging(value);
					this.SendPropertyChanging();
					this._QNo = value;
					this.SendPropertyChanged("QNo");
					this.OnQNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QLine", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string QLine
		{
			get
			{
				return this._QLine;
			}
			set
			{
				if ((this._QLine != value))
				{
					this.OnQLineChanging(value);
					this.SendPropertyChanging();
					this._QLine = value;
					this.SendPropertyChanged("QLine");
					this.OnQLineChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="A1_Question", Storage="_A1", ThisKey="QNo", OtherKey="A1No", IsForeignKey=true)]
		public A1 A1
		{
			get
			{
				return this._A1.Entity;
			}
			set
			{
				A1 previousValue = this._A1.Entity;
				if (((previousValue != value) 
							|| (this._A1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._A1.Entity = null;
						previousValue.Question = null;
					}
					this._A1.Entity = value;
					if ((value != null))
					{
						value.Question = this;
						this._QNo = value.A1No;
					}
					else
					{
						this._QNo = default(int);
					}
					this.SendPropertyChanged("A1");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="A4_Question", Storage="_A4", ThisKey="QNo", OtherKey="A4No", IsForeignKey=true)]
		public A4 A4
		{
			get
			{
				return this._A4.Entity;
			}
			set
			{
				A4 previousValue = this._A4.Entity;
				if (((previousValue != value) 
							|| (this._A4.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._A4.Entity = null;
						previousValue.Question = null;
					}
					this._A4.Entity = value;
					if ((value != null))
					{
						value.Question = this;
						this._QNo = value.A4No;
					}
					else
					{
						this._QNo = default(int);
					}
					this.SendPropertyChanged("A4");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="RA_Question", Storage="_RA", ThisKey="QNo", OtherKey="ANo", IsForeignKey=true)]
		public RA RA
		{
			get
			{
				return this._RA.Entity;
			}
			set
			{
				RA previousValue = this._RA.Entity;
				if (((previousValue != value) 
							|| (this._RA.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._RA.Entity = null;
						previousValue.Question = null;
					}
					this._RA.Entity = value;
					if ((value != null))
					{
						value.Question = this;
						this._QNo = value.ANo;
					}
					else
					{
						this._QNo = default(int);
					}
					this.SendPropertyChanged("RA");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="A2_Question", Storage="_A2", ThisKey="QNo", OtherKey="A2No", IsForeignKey=true)]
		public A2 A2
		{
			get
			{
				return this._A2.Entity;
			}
			set
			{
				A2 previousValue = this._A2.Entity;
				if (((previousValue != value) 
							|| (this._A2.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._A2.Entity = null;
						previousValue.Question = null;
					}
					this._A2.Entity = value;
					if ((value != null))
					{
						value.Question = this;
						this._QNo = value.A2No;
					}
					else
					{
						this._QNo = default(int);
					}
					this.SendPropertyChanged("A2");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="A3_Question", Storage="_A3", ThisKey="QNo", OtherKey="A3No", IsForeignKey=true)]
		public A3 A3
		{
			get
			{
				return this._A3.Entity;
			}
			set
			{
				A3 previousValue = this._A3.Entity;
				if (((previousValue != value) 
							|| (this._A3.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._A3.Entity = null;
						previousValue.Question = null;
					}
					this._A3.Entity = value;
					if ((value != null))
					{
						value.Question = this;
						this._QNo = value.A3No;
					}
					else
					{
						this._QNo = default(int);
					}
					this.SendPropertyChanged("A3");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.A1")]
	public partial class A1 : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _A1No;
		
		private string _A;
		
		private EntityRef<Question> _Question;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnA1NoChanging(int value);
    partial void OnA1NoChanged();
    partial void OnAChanging(string value);
    partial void OnAChanged();
    #endregion
		
		public A1()
		{
			this._Question = default(EntityRef<Question>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_A1No", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int A1No
		{
			get
			{
				return this._A1No;
			}
			set
			{
				if ((this._A1No != value))
				{
					this.OnA1NoChanging(value);
					this.SendPropertyChanging();
					this._A1No = value;
					this.SendPropertyChanged("A1No");
					this.OnA1NoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_A", DbType="VarChar(MAX)")]
		public string A
		{
			get
			{
				return this._A;
			}
			set
			{
				if ((this._A != value))
				{
					this.OnAChanging(value);
					this.SendPropertyChanging();
					this._A = value;
					this.SendPropertyChanged("A");
					this.OnAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="A1_Question", Storage="_Question", ThisKey="A1No", OtherKey="QNo", IsUnique=true, IsForeignKey=false)]
		public Question Question
		{
			get
			{
				return this._Question.Entity;
			}
			set
			{
				Question previousValue = this._Question.Entity;
				if (((previousValue != value) 
							|| (this._Question.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Question.Entity = null;
						previousValue.A1 = null;
					}
					this._Question.Entity = value;
					if ((value != null))
					{
						value.A1 = this;
					}
					this.SendPropertyChanged("Question");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.A4")]
	public partial class A4 : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _A4No;
		
		private string _A;
		
		private EntityRef<Question> _Question;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnA4NoChanging(int value);
    partial void OnA4NoChanged();
    partial void OnAChanging(string value);
    partial void OnAChanged();
    #endregion
		
		public A4()
		{
			this._Question = default(EntityRef<Question>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_A4No", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int A4No
		{
			get
			{
				return this._A4No;
			}
			set
			{
				if ((this._A4No != value))
				{
					this.OnA4NoChanging(value);
					this.SendPropertyChanging();
					this._A4No = value;
					this.SendPropertyChanged("A4No");
					this.OnA4NoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_A", DbType="VarChar(MAX)")]
		public string A
		{
			get
			{
				return this._A;
			}
			set
			{
				if ((this._A != value))
				{
					this.OnAChanging(value);
					this.SendPropertyChanging();
					this._A = value;
					this.SendPropertyChanged("A");
					this.OnAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="A4_Question", Storage="_Question", ThisKey="A4No", OtherKey="QNo", IsUnique=true, IsForeignKey=false)]
		public Question Question
		{
			get
			{
				return this._Question.Entity;
			}
			set
			{
				Question previousValue = this._Question.Entity;
				if (((previousValue != value) 
							|| (this._Question.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Question.Entity = null;
						previousValue.A4 = null;
					}
					this._Question.Entity = value;
					if ((value != null))
					{
						value.A4 = this;
					}
					this.SendPropertyChanged("Question");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.RA")]
	public partial class RA : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ANo;
		
		private string _RA1;
		
		private EntityRef<Question> _Question;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnANoChanging(int value);
    partial void OnANoChanged();
    partial void OnRA1Changing(string value);
    partial void OnRA1Changed();
    #endregion
		
		public RA()
		{
			this._Question = default(EntityRef<Question>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ANo", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ANo
		{
			get
			{
				return this._ANo;
			}
			set
			{
				if ((this._ANo != value))
				{
					this.OnANoChanging(value);
					this.SendPropertyChanging();
					this._ANo = value;
					this.SendPropertyChanged("ANo");
					this.OnANoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="RA", Storage="_RA1", DbType="VarChar(MAX)")]
		public string RA1
		{
			get
			{
				return this._RA1;
			}
			set
			{
				if ((this._RA1 != value))
				{
					this.OnRA1Changing(value);
					this.SendPropertyChanging();
					this._RA1 = value;
					this.SendPropertyChanged("RA1");
					this.OnRA1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="RA_Question", Storage="_Question", ThisKey="ANo", OtherKey="QNo", IsUnique=true, IsForeignKey=false)]
		public Question Question
		{
			get
			{
				return this._Question.Entity;
			}
			set
			{
				Question previousValue = this._Question.Entity;
				if (((previousValue != value) 
							|| (this._Question.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Question.Entity = null;
						previousValue.RA = null;
					}
					this._Question.Entity = value;
					if ((value != null))
					{
						value.RA = this;
					}
					this.SendPropertyChanged("Question");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.A2")]
	public partial class A2 : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _A2No;
		
		private string _A;
		
		private EntityRef<Question> _Question;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnA2NoChanging(int value);
    partial void OnA2NoChanged();
    partial void OnAChanging(string value);
    partial void OnAChanged();
    #endregion
		
		public A2()
		{
			this._Question = default(EntityRef<Question>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_A2No", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int A2No
		{
			get
			{
				return this._A2No;
			}
			set
			{
				if ((this._A2No != value))
				{
					this.OnA2NoChanging(value);
					this.SendPropertyChanging();
					this._A2No = value;
					this.SendPropertyChanged("A2No");
					this.OnA2NoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_A", DbType="VarChar(MAX)")]
		public string A
		{
			get
			{
				return this._A;
			}
			set
			{
				if ((this._A != value))
				{
					this.OnAChanging(value);
					this.SendPropertyChanging();
					this._A = value;
					this.SendPropertyChanged("A");
					this.OnAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="A2_Question", Storage="_Question", ThisKey="A2No", OtherKey="QNo", IsUnique=true, IsForeignKey=false)]
		public Question Question
		{
			get
			{
				return this._Question.Entity;
			}
			set
			{
				Question previousValue = this._Question.Entity;
				if (((previousValue != value) 
							|| (this._Question.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Question.Entity = null;
						previousValue.A2 = null;
					}
					this._Question.Entity = value;
					if ((value != null))
					{
						value.A2 = this;
					}
					this.SendPropertyChanged("Question");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.A3")]
	public partial class A3 : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _A3No;
		
		private string _A;
		
		private EntityRef<Question> _Question;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnA3NoChanging(int value);
    partial void OnA3NoChanged();
    partial void OnAChanging(string value);
    partial void OnAChanged();
    #endregion
		
		public A3()
		{
			this._Question = default(EntityRef<Question>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_A3No", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int A3No
		{
			get
			{
				return this._A3No;
			}
			set
			{
				if ((this._A3No != value))
				{
					this.OnA3NoChanging(value);
					this.SendPropertyChanging();
					this._A3No = value;
					this.SendPropertyChanged("A3No");
					this.OnA3NoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_A", DbType="VarChar(MAX)")]
		public string A
		{
			get
			{
				return this._A;
			}
			set
			{
				if ((this._A != value))
				{
					this.OnAChanging(value);
					this.SendPropertyChanging();
					this._A = value;
					this.SendPropertyChanged("A");
					this.OnAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="A3_Question", Storage="_Question", ThisKey="A3No", OtherKey="QNo", IsUnique=true, IsForeignKey=false)]
		public Question Question
		{
			get
			{
				return this._Question.Entity;
			}
			set
			{
				Question previousValue = this._Question.Entity;
				if (((previousValue != value) 
							|| (this._Question.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Question.Entity = null;
						previousValue.A3 = null;
					}
					this._Question.Entity = value;
					if ((value != null))
					{
						value.A3 = this;
					}
					this.SendPropertyChanged("Question");
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