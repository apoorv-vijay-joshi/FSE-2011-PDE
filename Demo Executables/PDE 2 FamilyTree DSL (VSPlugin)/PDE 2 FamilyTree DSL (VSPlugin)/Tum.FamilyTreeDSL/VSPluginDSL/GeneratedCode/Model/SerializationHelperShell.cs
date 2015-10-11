 
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DslModeling = global::Microsoft.VisualStudio.Modeling;
using DslValidation = global::Microsoft.VisualStudio.Modeling.Validation;

namespace Tum.FamilyTreeDSL
{
	
	public abstract partial class FamilyTreeDSLSerializationHelperBase
	{
		/// <summary>
		/// Loads a MetaModel instance into the default partition of the given store.
		/// </summary>
		/// <param name="serializationResult">Stores serialization result from the load operation.</param>
		/// <param name="store">The new MetaModel instance will be created into the default partition of this store.</param>
		/// <param name="fileName">Name of the file from which the MetaModel instance will be deserialized.</param>
		/// <param name="schemaResolver">
		/// An ISchemaResolver that allows the serializer to do schema validation on the root element (and everything inside it).
		/// If null is passed, schema validation will not be performed.
		/// </param>
		/// <param name="validationController">
		/// A ValidationController that will be used to do load-time validation (validations with validation category "Load"). If null
		/// is passed, load-time validation will not be performed.
		/// </param>
		/// <param name="serializerLocator">
		/// An ISerializerLocator that will be used to locate any additional domain model types required to load the model. Can be null.
		/// </param>
		/// <returns>The loaded MetaModel instance.</returns>
		public virtual global::Tum.FamilyTreeDSL.FamilyTreeModel LoadModel(DslModeling::SerializationResult serializationResult, DslModeling::Store store, string fileName, DslModeling::ISchemaResolver schemaResolver, DslValidation::ValidationController validationController, DslModeling::ISerializerLocator serializerLocator)
		{
			#region Check Parameters
			if (store == null) 
				throw new global::System.ArgumentNullException("store");
			#endregion
			
			return this.LoadModelFamilyTreeModel(serializationResult, store.DefaultPartition, fileName, schemaResolver, validationController, serializerLocator);
		}
	}
				
}
