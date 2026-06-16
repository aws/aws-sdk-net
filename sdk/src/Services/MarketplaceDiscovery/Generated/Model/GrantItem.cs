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
 * Do not modify this file. This file is generated from the marketplace-discovery-2026-02-05.normal.json service model.
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
namespace Amazon.MarketplaceDiscovery.Model
{
    /// <summary>
    /// An entitlement granted to the buyer as part of a pricing term.
    /// </summary>
    public partial class GrantItem
    {
        private string _description;
        private string _dimensionKey;
        private List<DimensionLabel> _dimensionLabels = AWSConfigs.InitializeCollections ? new List<DimensionLabel>() : null;
        private string _displayName;
        private int? _maxQuantity;
        private string _unit;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the entitlement.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DimensionKey. 
        /// <para>
        /// The machine-readable key identifying the entitlement dimension.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=4096)]
        public string DimensionKey
        {
            get { return this._dimensionKey; }
            set { this._dimensionKey = value; }
        }

        // Check to see if DimensionKey property is set
        internal bool IsSetDimensionKey()
        {
            return this._dimensionKey != null;
        }

        /// <summary>
        /// Gets and sets the property DimensionLabels. 
        /// <para>
        /// Labels used to categorize this entitlement, such as by region.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DimensionLabel> DimensionLabels
        {
            get { return this._dimensionLabels; }
            set { this._dimensionLabels = value; }
        }

        // Check to see if DimensionLabels property is set
        internal bool IsSetDimensionLabels()
        {
            return this._dimensionLabels != null && (this._dimensionLabels.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The human-readable name of the entitlement dimension.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=4096)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property MaxQuantity. 
        /// <para>
        /// The maximum quantity of the entitlement that can be granted.
        /// </para>
        /// </summary>
        public int? MaxQuantity
        {
            get { return this._maxQuantity; }
            set { this._maxQuantity = value; }
        }

        // Check to see if MaxQuantity property is set
        internal bool IsSetMaxQuantity()
        {
            return this._maxQuantity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        /// The unit of measurement for the entitlement.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=4096)]
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