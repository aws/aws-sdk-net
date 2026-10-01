/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.NeptuneGraph.Model
{
    /// <summary>
    /// A structure representing a property's attributes. It is a map object of outputType,
    /// sourcePropertyName and multiValueHandling.
    /// </summary>
    public partial class ExportFilterPropertyAttributes
    {
        /// <summary>
        /// Gets and sets the property MultiValueHandling. 
        /// <para>
        /// Specifies how to handle properties that have multiple values. Can be either <c>TO_LIST</c>
        /// to export all values as a list, or <c>PICK_FIRST</c> to export the first value encountered.
        /// If not specified, the default value is <c>PICK_FIRST</c>.
        /// </para>
        /// </summary>
        public MultiValueHandlingType MultiValueHandling { get; set; }

        /// <summary>
        /// Checks to see if the MultiValueHandling property is set.
        /// </summary>
        internal bool IsSetMultiValueHandling() => this.MultiValueHandling != null;

        /// <summary>
        /// Gets and sets the property OutputType. 
        /// <para>
        /// Specifies the data type to use for the property in the exported data (e.g. "String",
        /// "Int", "Float"). If a type is not provided, the export process will determine the
        /// type. If a given property is present as multiple types (e.g. one vertex has "height"
        /// stored as a double, and another edge has it stored as a string), the type will be
        /// of Any type, otherwise, it will be the type of the property as present in vertices.
        /// </para>
        /// </summary>
        public string OutputType { get; set; }

        /// <summary>
        /// Checks to see if the OutputType property is set.
        /// </summary>
        internal bool IsSetOutputType() => this.OutputType != null;

        /// <summary>
        /// Gets and sets the property SourcePropertyName. 
        /// <para>
        /// The name of the property as it exists in the original graph data. If not provided,
        /// it is assumed that the key matches the desired sourcePropertyName.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string SourcePropertyName { get; set; }

        /// <summary>
        /// Checks to see if the SourcePropertyName property is set.
        /// </summary>
        internal bool IsSetSourcePropertyName() => this.SourcePropertyName != null;
    }
}
