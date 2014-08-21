using System;

namespace ApplicationContext
{
	/// <summary>
	/// Clase que muestra como usar Spring .NET
	/// </summary>
	public class AppContext
	{
		private Spring.Context.IApplicationContext _SpringContext = null;
		private static AppContext _AppContext;

		public AppContext ()
		{
			try
			{
				_SpringContext = Spring.Context.Support.ContextRegistry.GetContext();
			}
			catch {
				throw new Exception ("Error al cargar el contexto");
			}
		}

		public static AppContext Instance
		{
			get{
				if (_AppContext == null)
				{
					_AppContext = new AppContext();
				}
				return _AppContext;
			}
		}

		public object GetObject(string objectName)
		{
			return _SpringContext.GetObject (objectName);
		}


	}
}

