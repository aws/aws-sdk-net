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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
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
        private PropertyDataType _dataType;
        private string _dataTypeSpec;
        private string _externalId;
        private string _id;
        private string _name;
        private List<AssetModelPropertyPathSegment> _path = AWSConfigs.InitializeCollections ? new List<AssetModelPropertyPathSegment>() : null;
        private PropertyType _type;
        private string _unit;

        /// <summary>
        /// Gets and sets the property DataType. 
        /// <para>
        /// The data type of the asset model property.
        /// </para>
        ///  
        /// <para>
        /// If you specify <c>STRUCT</c>, you must also specify <c>dataTypeSpec</c> to identify
        /// the type of the structure for this property.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PropertyDataType DataType
        {
            get { return this._dataType; }
            set { this._dataType = value; }
        }

        // Check to see if DataType property is set
        internal bool IsSetDataType()
        {
            return this._dataType != null;
        }

        /// <summary>
        /// Gets and sets the property DataTypeSpec. 
        /// <para>
        /// The data type of the structure for this property. This parameter exists on properties
        /// that have the <c>STRUCT</c> data type.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string DataTypeSpec
        {
            get { return this._dataTypeSpec; }
            set { this._dataTypeSpec = value; }
        }

        // Check to see if DataTypeSpec property is set
        internal bool IsSetDataTypeSpec()
        {
            return this._dataTypeSpec != null;
        }

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
        [AWSProperty(Min=2, Max=128)]
        public string ExternalId
        {
            get { return this._externalId; }
            set { this._externalId = value; }
        }

        // Check to see if ExternalId property is set
        internal bool IsSetExternalId()
        {
            return this._externalId != null;
        }

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
        [AWSProperty(Min=13, Max=139)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the asset model property.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The structured path to the property from the root of the asset model.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AssetModelPropertyPathSegment> Path
        {
            get { return this._path; }
            set { this._path = value; }
        }

        // Check to see if Path property is set
        internal bool IsSetPath()
        {
            return this._path != null && (this._path.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The property type (see <c>PropertyType</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PropertyType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        /// The unit of the asset model property, such as <c>Newtons</c> or <c>RPM</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Unit
        {
            get { return this._unit; }
            set { this._unit = value; }
        }

        // Check to see if Unit property is set
        internal bool IsSetUnit()
        {
            return this._unit != null;
        }

    }
}