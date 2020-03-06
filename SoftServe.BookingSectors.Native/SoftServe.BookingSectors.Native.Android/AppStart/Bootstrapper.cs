namespace SoftServe.BookingSectors.Native.Droid.AppStart
{
	/// <summary>
	/// Init Bootstrapper instance for Android app
	/// </summary>
	public class Bootstrapper : Native.AppStart.Bootstrapper
	{
		/// <summary>
		/// Create Bootstrapper instance
		/// </summary>
		public static void Init()
		{
			var instance = new Bootstrapper();
		}
	}
}