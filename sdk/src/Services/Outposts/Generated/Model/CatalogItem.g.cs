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

namespace Amazon.Outposts.Model
{
    /// <summary>
    /// Information about a catalog item.
    /// </summary>
    public partial class CatalogItem
    {
        /// <summary>
        /// Gets and sets the property CatalogItemId. 
        /// <para>
        ///  The ID of the catalog item. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public string CatalogItemId { get; set; }

        /// <summary>
        /// Checks to see if the CatalogItemId property is set.
        /// </summary>
        internal bool IsSetCatalogItemId() => this.CatalogItemId != null;

        /// <summary>
        /// Gets and sets the property EC2Capacities. 
        /// <para>
        ///  Information about the EC2 capacity of an item. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EC2Capacity> EC2Capacities { get; set; } = AWSConfigs.InitializeCollections ? new List<EC2Capacity>() : null;

        /// <summary>
        /// Checks to see if the EC2Capacities property is set.
        /// </summary>
        internal bool IsSetEC2Capacities() => this.EC2Capacities != null && (this.EC2Capacities.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ItemStatus. 
        /// <para>
        ///  The status of a catalog item. 
        /// </para>
        /// </summary>
        public CatalogItemStatus ItemStatus { get; set; }

        /// <summary>
        /// Checks to see if the ItemStatus property is set.
        /// </summary>
        internal bool IsSetItemStatus() => this.ItemStatus != null;

        /// <summary>
        /// Gets and sets the property PowerKva. 
        /// <para>
        ///  Information about the power draw of an item. 
        /// </para>
        /// </summary>
        public float? PowerKva { get; set; }

        /// <summary>
        /// Checks to see if the PowerKva property is set.
        /// </summary>
        internal bool IsSetPowerKva() => this.PowerKva.HasValue;

        /// <summary>
        /// Gets and sets the property RackScalingType. 
        /// <para>
        /// The rack scaling type supported by the catalog item. Valid values are <c>SINGLE_RACK</c>
        /// and <c>MULTI_RACK</c>.
        /// </para>
        /// </summary>
        public RackScalingType RackScalingType { get; set; }

        /// <summary>
        /// Checks to see if the RackScalingType property is set.
        /// </summary>
        internal bool IsSetRackScalingType() => this.RackScalingType != null;

        /// <summary>
        /// Gets and sets the property SupportedStorage. 
        /// <para>
        ///  The supported storage options for the catalog item. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedStorage { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SupportedStorage property is set.
        /// </summary>
        internal bool IsSetSupportedStorage() => this.SupportedStorage != null && (this.SupportedStorage.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SupportedUplinkGbps. 
        /// <para>
        ///  The uplink speed this catalog item requires for the connection to the Region. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> SupportedUplinkGbps { get; set; } = AWSConfigs.InitializeCollections ? new List<int>() : null;

        /// <summary>
        /// Checks to see if the SupportedUplinkGbps property is set.
        /// </summary>
        internal bool IsSetSupportedUplinkGbps() => this.SupportedUplinkGbps != null && (this.SupportedUplinkGbps.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property WeightLbs. 
        /// <para>
        ///  The weight of the item in pounds. 
        /// </para>
        /// </summary>
        public int? WeightLbs { get; set; }

        /// <summary>
        /// Checks to see if the WeightLbs property is set.
        /// </summary>
        internal bool IsSetWeightLbs() => this.WeightLbs.HasValue;
    }
}
