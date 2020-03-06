using Autofac;

namespace SoftServe.BookingSectors.Native.AppStart
{
	/// <summary>
	/// The resolver is responsible for creating our objects for us based on the type that we request
	/// </summary>
	public static class Resolver
	{
		private static IContainer _container;

		public static void Initialize(IContainer container)
		{
			_container = container;
		}

		public static T Resolve<T>()
		{
			return _container.Resolve<T>();
		}
	}
}
