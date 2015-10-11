﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 10.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Tum.PDE.ToolFramework.Templates.Shell.Model
{
    using Tum.PDE.LanguageDSL;
    using Microsoft.VisualStudio.Modeling;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System;
    
    
    #line 1 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\Shell\Model\SerializationHelperGenerator.tt"
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "10.0.0.0")]
    public partial class SerializationHelperGenerator : BaseTemplate
    {
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
        public override string TransformText()
        {
            this.GenerationEnvironment = null;
            this.Write(" \r\n");
            
            #line 9 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\Shell\Model\SerializationHelperGenerator.tt"

	string dslName = this.MetaModel.Name;
	string directiveName = dslName;

            
            #line default
            #line hidden
            this.Write(@"//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DslModeling = global::Microsoft.VisualStudio.Modeling;
using DslValidation = global::Microsoft.VisualStudio.Modeling.Validation;

namespace ");
            
            #line 25 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\Shell\Model\SerializationHelperGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.MetaModel.Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n");
            
            #line 27 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\Shell\Model\SerializationHelperGenerator.tt"

	DomainClass domainModel = null;
	foreach(DomainClass domainClass in this.MetaModel.AllClasses)
	{
		if( domainClass.IsDomainModel )
		{
			domainModel = domainClass;

            
            #line default
            #line hidden
            this.Write("\t\r\n\tpublic abstract partial class ");
            
            #line 35 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\Shell\Model\SerializationHelperGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.MetaModel.Name));
            
            #line default
            #line hidden
            this.Write(@"SerializationHelperBase
	{
		/// <summary>
		/// Loads a MetaModel instance into the default partition of the given store.
		/// </summary>
		/// <param name=""serializationResult"">Stores serialization result from the load operation.</param>
		/// <param name=""store"">The new MetaModel instance will be created into the default partition of this store.</param>
		/// <param name=""fileName"">Name of the file from which the MetaModel instance will be deserialized.</param>
		/// <param name=""schemaResolver"">
		/// An ISchemaResolver that allows the serializer to do schema validation on the root element (and everything inside it).
		/// If null is passed, schema validation will not be performed.
		/// </param>
		/// <param name=""validationController"">
		/// A ValidationController that will be used to do load-time validation (validations with validation category ""Load""). If null
		/// is passed, load-time validation will not be performed.
		/// </param>
		/// <param name=""serializerLocator"">
		/// An ISerializerLocator that will be used to locate any additional domain model types required to load the model. Can be null.
		/// </param>
		/// <returns>The loaded MetaModel instance.</returns>
		public virtual ");
            
            #line 55 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\Shell\Model\SerializationHelperGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(domainClass.GetFullName(true)));
            
            #line default
            #line hidden
            this.Write(@" LoadModel(DslModeling::SerializationResult serializationResult, DslModeling::Store store, string fileName, DslModeling::ISchemaResolver schemaResolver, DslValidation::ValidationController validationController, DslModeling::ISerializerLocator serializerLocator)
		{
			#region Check Parameters
			if (store == null) 
				throw new global::System.ArgumentNullException(""store"");
			#endregion
			
			return this.LoadModel");
            
            #line 62 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\Shell\Model\SerializationHelperGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(domainModel.Name));
            
            #line default
            #line hidden
            this.Write("(serializationResult, store.DefaultPartition, fileName, schemaResolver, validatio" +
                    "nController, serializerLocator);\r\n\t\t}\r\n\t}\r\n");
            
            #line 65 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\Shell\Model\SerializationHelperGenerator.tt"

			break;
		}
	}

            
            #line default
            #line hidden
            this.Write("\t\t\t\t\r\n}\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
