// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.AcceptanceTestsAzureCompositeModelClient.Models
{
    using System.Linq;

    public partial class ArrayWrapperInner
    {
        /// <summary>
        /// Initializes a new instance of the ArrayWrapperInner class.
        /// </summary>
        public ArrayWrapperInner() { }

        /// <summary>
        /// Initializes a new instance of the ArrayWrapperInner class.
        /// </summary>
        public ArrayWrapperInner(System.Collections.Generic.IList<string> array = default(System.Collections.Generic.IList<string>))
        {
            Array = array;
        }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "array")]
        public System.Collections.Generic.IList<string> Array { get; set; }

    }
}
