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
    /// Contains a list of value updates for an asset property in the list of asset entries
    /// consumed by the <a href="https://docs.aws.amazon.com/iot-sitewise/latest/APIReference/API_BatchPutAssetPropertyValue.html">BatchPutAssetPropertyValue</a>
    /// API operation.
    /// </summary>
    public partial class PutAssetPropertyValueEntry
    {
        private string _assetId;
        private string _entryId;
        private string _propertyAlias;
        private string _propertyId;
        private List<AssetPropertyValue> _propertyValues = AWSConfigs.InitializeCollections ? new List<AssetPropertyValue>() : null;

        /// <summary>
        /// Gets and sets the property AssetId. 
        /// <para>
        /// The ID of the asset to update.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string AssetId
        {
            get { return this._assetId; }
            set { this._assetId = value; }
        }

        // Check to see if AssetId property is set
        internal bool IsSetAssetId()
        {
            return this._assetId != null;
        }

        /// <summary>
        /// Gets and sets the property EntryId. 
        /// <para>
        /// The user specified ID for the entry. You can use this ID to identify which entries
        /// failed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string EntryId
        {
            get { return this._entryId; }
            set { this._entryId = value; }
        }

        // Check to see if EntryId property is set
        internal bool IsSetEntryId()
        {
            return this._entryId != null;
        }

        /// <summary>
        /// Gets and sets the property PropertyAlias. 
        /// <para>
        /// The alias that identifies the property, such as an OPC-UA server data stream path
        /// (for example, <c>/company/windfarm/3/turbine/7/temperature</c>). For more information,
        /// see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/connect-data-streams.html">Mapping
        /// industrial data streams to asset properties</a> in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string PropertyAlias
        {
            get { return this._propertyAlias; }
            set { this._propertyAlias = value; }
        }

        // Check to see if PropertyAlias property is set
        internal bool IsSetPropertyAlias()
        {
            return this._propertyAlias != null;
        }

        /// <summary>
        /// Gets and sets the property PropertyId. 
        /// <para>
        /// The ID of the asset property for this entry.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string PropertyId
        {
            get { return this._propertyId; }
            set { this._propertyId = value; }
        }

        // Check to see if PropertyId property is set
        internal bool IsSetPropertyId()
        {
            return this._propertyId != null;
        }

        /// <summary>
        /// Gets and sets the property PropertyValues. 
        /// <para>
        /// The list of property values to upload. You can specify up to 10 <c>propertyValues</c>
        /// array elements. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<AssetPropertyValue> PropertyValues
        {
            get { return this._propertyValues; }
            set { this._propertyValues = value; }
        }

        // Check to see if PropertyValues property is set
        internal bool IsSetPropertyValues()
        {
            return this._propertyValues != null && (this._propertyValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}