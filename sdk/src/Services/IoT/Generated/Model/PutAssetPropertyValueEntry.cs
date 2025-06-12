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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// An asset property value entry containing the following information.
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
        /// The ID of the IoT SiteWise asset. You must specify either a <c>propertyAlias</c> or
        /// both an <c>aliasId</c> and a <c>propertyId</c>. Accepts substitution templates.
        /// </para>
        /// </summary>
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
        /// Optional. A unique identifier for this entry that you can define to better track which
        /// message caused an error in case of failure. Accepts substitution templates. Defaults
        /// to a new UUID.
        /// </para>
        /// </summary>
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
        /// The name of the property alias associated with your asset property. You must specify
        /// either a <c>propertyAlias</c> or both an <c>aliasId</c> and a <c>propertyId</c>. Accepts
        /// substitution templates.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// The ID of the asset's property. You must specify either a <c>propertyAlias</c> or
        /// both an <c>aliasId</c> and a <c>propertyId</c>. Accepts substitution templates.
        /// </para>
        /// </summary>
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
        /// A list of property values to insert that each contain timestamp, quality, and value
        /// (TQV) information.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
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