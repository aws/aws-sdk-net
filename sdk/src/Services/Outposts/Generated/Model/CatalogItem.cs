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
 * Do not modify this file. This file is generated from the outposts-2019-12-03.normal.json service model.
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
namespace Amazon.Outposts.Model
{
    /// <summary>
    /// Information about a catalog item.
    /// </summary>
    public partial class CatalogItem
    {
        private string _catalogItemId;
        private List<EC2Capacity> _ec2Capacities = AWSConfigs.InitializeCollections ? new List<EC2Capacity>() : null;
        private CatalogItemStatus _itemStatus;
        private float? _powerKva;
        private List<string> _supportedStorage = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<int> _supportedUplinkGbps = AWSConfigs.InitializeCollections ? new List<int>() : null;
        private int? _weightLbs;

        /// <summary>
        /// Gets and sets the property CatalogItemId. 
        /// <para>
        ///  The ID of the catalog item. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public string CatalogItemId
        {
            get { return this._catalogItemId; }
            set { this._catalogItemId = value; }
        }

        // Check to see if CatalogItemId property is set
        internal bool IsSetCatalogItemId()
        {
            return this._catalogItemId != null;
        }

        /// <summary>
        /// Gets and sets the property EC2Capacities. 
        /// <para>
        ///  Information about the EC2 capacity of an item. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EC2Capacity> EC2Capacities
        {
            get { return this._ec2Capacities; }
            set { this._ec2Capacities = value; }
        }

        // Check to see if EC2Capacities property is set
        internal bool IsSetEC2Capacities()
        {
            return this._ec2Capacities != null && (this._ec2Capacities.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ItemStatus. 
        /// <para>
        ///  The status of a catalog item. 
        /// </para>
        /// </summary>
        public CatalogItemStatus ItemStatus
        {
            get { return this._itemStatus; }
            set { this._itemStatus = value; }
        }

        // Check to see if ItemStatus property is set
        internal bool IsSetItemStatus()
        {
            return this._itemStatus != null;
        }

        /// <summary>
        /// Gets and sets the property PowerKva. 
        /// <para>
        ///  Information about the power draw of an item. 
        /// </para>
        /// </summary>
        public float? PowerKva
        {
            get { return this._powerKva; }
            set { this._powerKva = value; }
        }

        // Check to see if PowerKva property is set
        internal bool IsSetPowerKva()
        {
            return this._powerKva.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SupportedStorage. 
        /// <para>
        ///  The supported storage options for the catalog item. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedStorage
        {
            get { return this._supportedStorage; }
            set { this._supportedStorage = value; }
        }

        // Check to see if SupportedStorage property is set
        internal bool IsSetSupportedStorage()
        {
            return this._supportedStorage != null && (this._supportedStorage.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SupportedUplinkGbps. 
        /// <para>
        ///  The uplink speed this catalog item requires for the connection to the Region. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> SupportedUplinkGbps
        {
            get { return this._supportedUplinkGbps; }
            set { this._supportedUplinkGbps = value; }
        }

        // Check to see if SupportedUplinkGbps property is set
        internal bool IsSetSupportedUplinkGbps()
        {
            return this._supportedUplinkGbps != null && (this._supportedUplinkGbps.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property WeightLbs. 
        /// <para>
        ///  The weight of the item in pounds. 
        /// </para>
        /// </summary>
        public int? WeightLbs
        {
            get { return this._weightLbs; }
            set { this._weightLbs = value; }
        }

        // Check to see if WeightLbs property is set
        internal bool IsSetWeightLbs()
        {
            return this._weightLbs.HasValue; 
        }

    }
}