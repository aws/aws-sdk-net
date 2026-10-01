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

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Contains a summary of a property associated with a model. This includes information
    /// about which interfaces the property belongs to, if any.
    /// </summary>
    public partial class AssetModelPropertySummary
    {
        /// <summary>
        /// Gets and sets the property AssetModelCompositeModelId. 
        /// <para>
        ///  The ID of the composite model that contains the asset model property. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string AssetModelCompositeModelId { get; set; }

        /// <summary>
        /// Checks to see if the AssetModelCompositeModelId property is set.
        /// </summary>
        internal bool IsSetAssetModelCompositeModelId() => this.AssetModelCompositeModelId != null;

        /// <summary>
        /// Gets and sets the property DataType. 
        /// <para>
        /// The data type of the property.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PropertyDataType DataType { get; set; }

        /// <summary>
        /// Checks to see if the DataType property is set.
        /// </summary>
        internal bool IsSetDataType() => this.DataType != null;

        /// <summary>
        /// Gets and sets the property DataTypeSpec. 
        /// <para>
        /// The data type of the structure for this property. This parameter exists on properties
        /// that have the <c>STRUCT</c> data type.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string DataTypeSpec { get; set; }

        /// <summary>
        /// Checks to see if the DataTypeSpec property is set.
        /// </summary>
        internal bool IsSetDataTypeSpec() => this.DataTypeSpec != null;

        /// <summary>
        /// Gets and sets the property ExternalId. 
        /// <para>
        /// The external ID of the property. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/object-ids.html#external-ids">Using
        /// external IDs</a> in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 128)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Checks to see if the ExternalId property is set.
        /// </summary>
        internal bool IsSetExternalId() => this.ExternalId != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the property.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property InterfaceSummaries. 
        /// <para>
        /// A list of interface summaries that describe which interfaces this property belongs
        /// to, including the interface asset model ID and the corresponding property ID in the
        /// interface.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InterfaceSummary> InterfaceSummaries { get; set; } = AWSConfigs.InitializeCollections ? new List<InterfaceSummary>() : null;

        /// <summary>
        /// Checks to see if the InterfaceSummaries property is set.
        /// </summary>
        internal bool IsSetInterfaceSummaries() => this.InterfaceSummaries != null && (this.InterfaceSummaries.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the property.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The structured path to the property from the root of the asset model.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AssetModelPropertyPathSegment> Path { get; set; } = AWSConfigs.InitializeCollections ? new List<AssetModelPropertyPathSegment>() : null;

        /// <summary>
        /// Checks to see if the Path property is set.
        /// </summary>
        internal bool IsSetPath() => this.Path != null && (this.Path.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Type.
        /// </summary>
        [AWSProperty(Required = true)]
        public PropertyType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        /// The unit (such as <c>Newtons</c> or <c>RPM</c>) of the property.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Unit { get; set; }

        /// <summary>
        /// Checks to see if the Unit property is set.
        /// </summary>
        internal bool IsSetUnit() => this.Unit != null;
    }
}
