namespace SoftServe.BookingSectors.Native.iOS.AppStart
{
	/// <summary>
	/// Init Bootstrapper instance for iOS app
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