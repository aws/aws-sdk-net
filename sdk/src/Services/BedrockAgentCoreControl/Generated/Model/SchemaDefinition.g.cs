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

namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// A schema definition for a gateway target. This structure defines the structure of
    /// the API that the target exposes.
    /// </summary>
    public partial class SchemaDefinition
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the schema definition. This description provides information about
        /// the purpose and usage of the schema.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Items. 
        /// <para>
        /// The items in the schema definition. This field is used for array types to define the
        /// structure of the array elements.
        /// </para>
        /// </summary>
        public SchemaDefinition Items { get; set; }

        /// <summary>
        /// Checks to see if the Items property is set.
        /// </summary>
        internal bool IsSetItems() => this.Items != null;

        /// <summary>
        /// Gets and sets the property Properties. 
        /// <para>
        /// The properties of the schema definition. These properties define the fields in the
        /// schema.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, SchemaDefinition> Properties { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, SchemaDefinition>() : null;

        /// <summary>
        /// Checks to see if the Properties property is set.
        /// </summary>
        internal bool IsSetProperties() => this.Properties != null && (this.Properties.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Required. 
        /// <para>
        /// The required fields in the schema definition. These fields must be provided when using
        /// the schema.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Required { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Required property is set.
        /// </summary>
        internal bool IsSetRequired() => this.Required != null && (this.Required.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the schema definition. This field specifies the data type of the schema.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SchemaType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
