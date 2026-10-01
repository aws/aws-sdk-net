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
    /// Information about a line item.
    /// </summary>
    public partial class LineItem
    {
        /// <summary>
        /// Gets and sets the property AssetInformationList. 
        /// <para>
        ///  Information about assets. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LineItemAssetInformation> AssetInformationList { get; set; } = AWSConfigs.InitializeCollections ? new List<LineItemAssetInformation>() : null;

        /// <summary>
        /// Checks to see if the AssetInformationList property is set.
        /// </summary>
        internal bool IsSetAssetInformationList() => this.AssetInformationList != null && (this.AssetInformationList.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Gets and sets the property LineItemId. 
        /// <para>
        /// The ID of the line item.
        /// </para>
        /// </summary>
        public string LineItemId { get; set; }

        /// <summary>
        /// Checks to see if the LineItemId property is set.
        /// </summary>
        internal bool IsSetLineItemId() => this.LineItemId != null;

        /// <summary>
        /// Gets and sets the property PreviousLineItemId. 
        /// <para>
        /// The ID of the previous line item.
        /// </para>
        /// </summary>
        public string PreviousLineItemId { get; set; }

        /// <summary>
        /// Checks to see if the PreviousLineItemId property is set.
        /// </summary>
        internal bool IsSetPreviousLineItemId() => this.PreviousLineItemId != null;

        /// <summary>
        /// Gets and sets the property PreviousOrderId. 
        /// <para>
        /// The ID of the previous order.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public string PreviousOrderId { get; set; }

        /// <summary>
        /// Checks to see if the PreviousOrderId property is set.
        /// </summary>
        internal bool IsSetPreviousOrderId() => this.PreviousOrderId != null;

        /// <summary>
        /// Gets and sets the property Quantity. 
        /// <para>
        /// The quantity of the line item.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? Quantity { get; set; }

        /// <summary>
        /// Checks to see if the Quantity property is set.
        /// </summary>
        internal bool IsSetQuantity() => this.Quantity.HasValue;

        /// <summary>
        /// Gets and sets the property ShipmentInformation. 
        /// <para>
        ///  Information about a line item shipment. 
        /// </para>
        /// </summary>
        public ShipmentInformation ShipmentInformation { get; set; }

        /// <summary>
        /// Checks to see if the ShipmentInformation property is set.
        /// </summary>
        internal bool IsSetShipmentInformation() => this.ShipmentInformation != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the line item.
        /// </para>
        /// </summary>
        public LineItemStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
