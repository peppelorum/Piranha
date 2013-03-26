﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Piranha.Extend
{
	/// <summary>
	/// Base class for extensions that can be inherited for simplicity. Provides empty virtual
	/// implementations of all methods except for GetContent() that returns this.
	/// </summary>
	public abstract class Extension : IExtension
	{
		/// <summary>
		/// This method is called at application start when the ExtensionManager has 
		/// loaded all of the imports. It should be used to perform one time initialization
		/// like setting database tables, adding meta data and so on.
		/// <param name="db">An authenticated data context</param>
		public virtual void Ensure(DataContext db) {}

		/// <summary>
		/// This method is called when then extension is loaded by the client API. The
		/// model provided is the current entity that the extension is attached to. For example
		/// an extension attached to a Post will get a PostModel object as a parameter.
		/// </summary>
		/// <param name="model">The model of the entity</param>
		public virtual void Init(object model) {}

		/// <summary>
		/// This method is called when the extension is loaded by the manager interface. This
		/// usually happens when an entity of the extension type is open for edit in the manager
		/// interface.
		/// </summary>
		/// <param name="model">The edit model of the entity</param>
		public virtual void InitManager(object model) {}

		/// <summary>
		/// This method is called when the client model tries to populate the data of it's
		/// extensions. This is very useful when the extension data is in fact only meta 
		/// data for retrieving other information.
		/// </summary>
		/// <param name="model">The model of the entity</param>
		/// <returns>The extension data</returns>
		public virtual object GetContent(object model) {
			return this ;
		}
	}
}