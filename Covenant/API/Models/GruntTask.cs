// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Covenant.API.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class GruntTask
    {
        /// <summary>
        /// Initializes a new instance of the GruntTask class.
        /// </summary>
        public GruntTask()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GruntTask class.
        /// </summary>
        /// <param name="language">Possible values include: 'CSharp'</param>
        public GruntTask(string name, int? id = default(int?), IList<string> alternateNames = default(IList<string>), string description = default(string), string help = default(string), ImplantLanguage? language = default(ImplantLanguage?), string code = default(string), bool? compiled = default(bool?), IList<ReferenceSourceLibrary> referenceSourceLibraries = default(IList<ReferenceSourceLibrary>), IList<ReferenceAssembly> referenceAssemblies = default(IList<ReferenceAssembly>), IList<EmbeddedResource> embeddedResources = default(IList<EmbeddedResource>), bool? unsafeCompile = default(bool?), bool? tokenTask = default(bool?), IList<GruntTaskOption> options = default(IList<GruntTaskOption>))
        {
            Id = id;
            Name = name;
            AlternateNames = alternateNames;
            Description = description;
            Help = help;
            Language = language;
            Code = code;
            Compiled = compiled;
            ReferenceSourceLibraries = referenceSourceLibraries;
            ReferenceAssemblies = referenceAssemblies;
            EmbeddedResources = embeddedResources;
            UnsafeCompile = unsafeCompile;
            TokenTask = tokenTask;
            Options = options;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "alternateNames")]
        public IList<string> AlternateNames { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "help")]
        public string Help { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'CSharp'
        /// </summary>
        [JsonProperty(PropertyName = "language")]
        public ImplantLanguage? Language { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "compiled")]
        public bool? Compiled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "referenceSourceLibraries")]
        public IList<ReferenceSourceLibrary> ReferenceSourceLibraries { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "referenceAssemblies")]
        public IList<ReferenceAssembly> ReferenceAssemblies { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "embeddedResources")]
        public IList<EmbeddedResource> EmbeddedResources { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "unsafeCompile")]
        public bool? UnsafeCompile { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tokenTask")]
        public bool? TokenTask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "options")]
        public IList<GruntTaskOption> Options { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Options != null)
            {
                foreach (var element in Options)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
