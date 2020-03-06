using Autofac;
using System.Linq;
using System.Reflection;
using SoftServe.BookingSectors.Native.ViewModels;
using Xamarin.Forms;

namespace SoftServe.BookingSectors.Native.AppStart
{
	/// <summary>
	/// Bootstrapper class responsible for application initialization
	/// </summary>
	public abstract class Bootstrapper
	{
		/// <summary>
		/// Instance of ContainerBuilder;
		/// </summary>
		protected ContainerBuilder ContainerBuilder { get; set; }

		/// <summary>
		/// Register all of dependencies and initialize Bootstrapper
		/// </summary>
		public Bootstrapper()
		{
			Initialize();
			FinishInitialization();
		}

		/// <summary>
		/// Registers the infrastructure dependencies.
		/// </summary>
		protected virtual void Initialize()
		{
			var currentAssembly = Assembly.GetExecutingAssembly();
			ContainerBuilder = new ContainerBuilder();
			foreach (var type in currentAssembly.DefinedTypes
					  .Where(e=>
							 e.IsSubclassOf(typeof(Page)) || 
							 e.IsSubclassOf(typeof(ViewModel))))
			{
				ContainerBuilder.RegisterType(type.AsType());
			}

			// <-- Here will be register other types using ContainerBuilder.RegisterType() method -->
		}

		/// <summary>
		/// Build and resolve dependency container.
		/// </summary>
		private void FinishInitialization()
		{
			var container = ContainerBuilder.Build();
			Resolver.Initialize(container);
		}
	}
}
