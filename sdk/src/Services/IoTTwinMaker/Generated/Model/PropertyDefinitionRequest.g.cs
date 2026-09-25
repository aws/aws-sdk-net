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

namespace Amazon.IoTTwinMaker.Model
{
    /// <summary>
    /// An object that sets information about a property.
    /// </summary>
    public partial class PropertyDefinitionRequest
    {
        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// A mapping that specifies configuration information about the property. Use this field
        /// to specify information that you read from and write to an external source.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Configuration { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Configuration property is set.
        /// </summary>
        internal bool IsSetConfiguration() => this.Configuration != null && (this.Configuration.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DataType. 
        /// <para>
        /// An object that contains information about the data type.
        /// </para>
        /// </summary>
        public DataType DataType { get; set; }

        /// <summary>
        /// Checks to see if the DataType property is set.
        /// </summary>
        internal bool IsSetDataType() => this.DataType != null;

        /// <summary>
        /// Gets and sets the property DefaultValue. 
        /// <para>
        /// An object that contains the default value.
        /// </para>
        /// </summary>
        public DataValue DefaultValue { get; set; }

        /// <summary>
        /// Checks to see if the DefaultValue property is set.
        /// </summary>
        internal bool IsSetDefaultValue() => this.DefaultValue != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// A friendly name for the property.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property IsExternalId. 
        /// <para>
        /// A Boolean value that specifies whether the property ID comes from an external data
        /// store.
        /// </para>
        /// </summary>
        public bool? IsExternalId { get; set; }

        /// <summary>
        /// Checks to see if the IsExternalId property is set.
        /// </summary>
        internal bool IsSetIsExternalId() => this.IsExternalId.HasValue;

        /// <summary>
        /// Gets and sets the property IsRequiredInEntity. 
        /// <para>
        /// A Boolean value that specifies whether the property is required.
        /// </para>
        /// </summary>
        public bool? IsRequiredInEntity { get; set; }

        /// <summary>
        /// Checks to see if the IsRequiredInEntity property is set.
        /// </summary>
        internal bool IsSetIsRequiredInEntity() => this.IsRequiredInEntity.HasValue;

        /// <summary>
        /// Gets and sets the property IsStoredExternally. 
        /// <para>
        /// A Boolean value that specifies whether the property is stored externally.
        /// </para>
        /// </summary>
        public bool? IsStoredExternally { get; set; }

        /// <summary>
        /// Checks to see if the IsStoredExternally property is set.
        /// </summary>
        internal bool IsSetIsStoredExternally() => this.IsStoredExternally.HasValue;

        /// <summary>
        /// Gets and sets the property IsTimeSeries. 
        /// <para>
        /// A Boolean value that specifies whether the property consists of time series data.
        /// </para>
        /// </summary>
        public bool? IsTimeSeries { get; set; }

        /// <summary>
        /// Checks to see if the IsTimeSeries property is set.
        /// </summary>
        internal bool IsSetIsTimeSeries() => this.IsTimeSeries.HasValue;
    }
}
