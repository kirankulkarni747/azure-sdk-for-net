// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Language.LUIS.Authoring.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Object model for creating a Pattern feature.
    /// </summary>
    public partial class PatternCreateObject
    {
        /// <summary>
        /// Initializes a new instance of the PatternCreateObject class.
        /// </summary>
        public PatternCreateObject()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PatternCreateObject class.
        /// </summary>
        /// <param name="pattern">The Regular Expression to match.</param>
        /// <param name="name">Name of the feature.</param>
        public PatternCreateObject(string pattern = default(string), string name = default(string))
        {
            Pattern = pattern;
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Regular Expression to match.
        /// </summary>
        [JsonProperty(PropertyName = "pattern")]
        public string Pattern { get; set; }

        /// <summary>
        /// Gets or sets name of the feature.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

    }
}
