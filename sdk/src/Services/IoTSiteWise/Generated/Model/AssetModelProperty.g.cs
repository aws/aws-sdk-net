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
    /// Contains information about an asset model property.
    /// </summary>
    public partial class AssetModelProperty
    {
        /// <summary>
        /// Gets and sets the property DataType. 
        /// <para>
        /// The data type of the asset model property.
        /// </para>
        ///  
        /// <para>
        /// The <c>VIDEO</c>, <c>ANNOTATION</c>, and <c>JSON</c> data types aren't supported for
        /// asset model properties. These types are used only by time series that store data for
        /// datasets in a workspace.
        /// </para>
        ///  
        /// <para>
        /// If you specify <c>STRUCT</c>, you must also specify <c>dataTypeSpec</c> to identify
        /// the type of the structure for this property.
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
        /// The external ID (if any) provided in the <a href="https://docs.aws.amazon.com/iot-sitewise/latest/APIReference/API_CreateAssetModel.html">CreateAssetModel</a>
        /// or <a href="https://docs.aws.amazon.com/iot-sitewise/latest/APIReference/API_UpdateAssetModel.html">UpdateAssetModel</a>
        /// operation. You can assign an external ID by specifying this value as part of a call
        /// to <a href="https://docs.aws.amazon.com/iot-sitewise/latest/APIReference/API_UpdateAssetModel.html">UpdateAssetModel</a>.
        /// However, you can't change the external ID if one is already assigned. For more information,
        /// see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/object-ids.html#external-ids">Using
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
        /// The ID of the asset model property.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you are callling <a href="https://docs.aws.amazon.com/iot-sitewise/latest/APIReference/API_UpdateAssetModel.html">UpdateAssetModel</a>
        /// to create a <i>new</i> property: You can specify its ID here, if desired. IoT SiteWise
        /// automatically generates a unique ID for you, so this parameter is never required.
        /// However, if you prefer to supply your own ID instead, you can specify it here in UUID
        /// format. If you specify your own ID, it must be globally unique.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you are calling UpdateAssetModel to modify an <i>existing</i> property: This can
        /// be either the actual ID in UUID format, or else <c>externalId:</c> followed by the
        /// external ID, if it has one. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/object-ids.html#external-id-references">Referencing
        /// objects with external IDs</a> in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 13, Max = 139)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the asset model property.
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
        /// <para>
        /// The property type (see <c>PropertyType</c>).
        /// </para>
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
        /// The unit of the asset model property, such as <c>Newtons</c> or <c>RPM</c>.
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
