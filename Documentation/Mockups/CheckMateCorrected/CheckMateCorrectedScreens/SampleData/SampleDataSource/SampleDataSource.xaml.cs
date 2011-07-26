﻿//      *********    DO NOT MODIFY THIS FILE     *********
//      This file is regenerated by a design tool. Making
//      changes to this file can cause errors.
namespace Expression.Blend.SampleData.SampleDataSource
{
	using System; 

// To significantly reduce the sample data footprint in your production application, you can set
// the DISABLE_SAMPLE_DATA conditional compilation constant and disable sample data at runtime.
#if DISABLE_SAMPLE_DATA
	internal class SampleDataSource { }
#else

	public class SampleDataSource : System.ComponentModel.INotifyPropertyChanged
	{
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		public SampleDataSource()
		{
			try
			{
				System.Uri resourceUri = new System.Uri("/CheckMateCorrected.Screens;component/SampleData/SampleDataSource/SampleDataSource.xaml", System.UriKind.Relative);
				if (System.Windows.Application.GetResourceStream(resourceUri) != null)
				{
					System.Windows.Application.LoadComponent(this, resourceUri);
				}
			}
			catch (System.Exception)
			{
			}
		}

		private Questions _Questions = new Questions();

		public Questions Questions
		{
			get
			{
				return this._Questions;
			}
		}
	}

	public class QuestionsItem : System.ComponentModel.INotifyPropertyChanged
	{
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		private string _Categories = string.Empty;

		public string Categories
		{
			get
			{
				return this._Categories;
			}

			set
			{
				if (this._Categories != value)
				{
					this._Categories = value;
					this.OnPropertyChanged("Categories");
				}
			}
		}

		private Questions _Questions = new Questions();

		public Questions Questions
		{
			get
			{
				return this._Questions;
			}
		}
	}

	public class Questions : System.Collections.ObjectModel.ObservableCollection<QuestionsItem>
	{ 
	}

	public class CollectionItem : System.ComponentModel.INotifyPropertyChanged
	{
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		private CollectionItemCollection _Collection = new CollectionItemCollection();

		public CollectionItemCollection Collection
		{
			get
			{
				return this._Collection;
			}
		}
	}

	public class CollectionItemCollection : System.Collections.ObjectModel.ObservableCollection<CollectionItem>
	{ 
	}
#endif
}
