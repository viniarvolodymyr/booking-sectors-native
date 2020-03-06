using SoftServe.BookingSectors.Native.Annotations;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace SoftServe.BookingSectors.Native.ViewModels
{
	/// <summary>
	///  ViewModel base class
	/// </summary>
	public abstract class ViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		[NotifyPropertyChangedInvocator]
		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		public void RaisePropertyChanged(params string[] propertyNames)
		{
			foreach (var propertyName in propertyNames)
			{
				PropertyChanged?.Invoke(this, new
					PropertyChangedEventArgs(propertyName));
			}
		}

		public INavigation Navigation { get; set; }
	}
}
