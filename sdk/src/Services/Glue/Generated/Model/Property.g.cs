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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// An object that defines a connection type for a compute environment.
    /// </summary>
    public partial class Property
    {
        /// <summary>
        /// Gets and sets the property AllowedValues. 
        /// <para>
        /// A list of <c>AllowedValue</c> objects representing the values allowed for the property.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AllowedValue> AllowedValues { get; set; } = AWSConfigs.InitializeCollections ? new List<AllowedValue>() : null;

        /// <summary>
        /// Checks to see if the AllowedValues property is set.
        /// </summary>
        internal bool IsSetAllowedValues() => this.AllowedValues != null && (this.AllowedValues.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DataOperationScopes. 
        /// <para>
        /// Indicates which data operations are applicable to the property.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DataOperationScopes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the DataOperationScopes property is set.
        /// </summary>
        internal bool IsSetDataOperationScopes() => this.DataOperationScopes != null && (this.DataOperationScopes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DefaultValue. 
        /// <para>
        /// The default value for the property.
        /// </para>
        /// </summary>
        public string DefaultValue { get; set; }

        /// <summary>
        /// Checks to see if the DefaultValue property is set.
        /// </summary>
        internal bool IsSetDefaultValue() => this.DefaultValue != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the property.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property KeyOverride. 
        /// <para>
        /// A key name to use when sending this property in API requests, if different from the
        /// display name.
        /// </para>
        /// </summary>
        public string KeyOverride { get; set; }

        /// <summary>
        /// Checks to see if the KeyOverride property is set.
        /// </summary>
        internal bool IsSetKeyOverride() => this.KeyOverride != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the property.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PropertyLocation. 
        /// <para>
        /// Specifies where this property should be included in REST requests, such as in headers,
        /// query parameters, or request body.
        /// </para>
        /// </summary>
        public PropertyLocation PropertyLocation { get; set; }

        /// <summary>
        /// Checks to see if the PropertyLocation property is set.
        /// </summary>
        internal bool IsSetPropertyLocation() => this.PropertyLocation != null;

        /// <summary>
        /// Gets and sets the property PropertyTypes. 
        /// <para>
        /// Describes the type of property.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> PropertyTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PropertyTypes property is set.
        /// </summary>
        internal bool IsSetPropertyTypes() => this.PropertyTypes != null && (this.PropertyTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Required. 
        /// <para>
        /// Indicates whether the property is required.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? Required { get; set; }

        /// <summary>
        /// Checks to see if the Required property is set.
        /// </summary>
        internal bool IsSetRequired() => this.Required.HasValue;
    }
}
