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

namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Contains the configuration of a single custom metadata field in a knowledge base,
    /// including its name, data type, and whether the field is searchable.
    /// </summary>
    public partial class MetadataConfiguration
    {
        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the custom metadata field.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 200)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Searchability. 
        /// <para>
        /// Specifies whether the custom metadata field is searchable. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ENABLED</c> – The field is searchable.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DISABLED</c> – The field is not searchable.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public SearchableStatus Searchability { get; set; }

        /// <summary>
        /// Checks to see if the Searchability property is set.
        /// </summary>
        internal bool IsSetSearchability() => this.Searchability != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The data type of the custom metadata field. Valid values are <c>STRING</c> and <c>STRING_LIST</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FieldType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
