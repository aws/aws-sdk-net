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

namespace Amazon.Outposts.Model
{
    /// <summary>
    /// Information about a line item.
    /// </summary>
    public partial class LineItem
    {
        private string _catalogItemId;
        private string _lineItemId;
        private int? _quantity;
        private LineItemStatus _status;

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
        /// Gets and sets the property LineItemId. 
        /// <para>
        /// The ID of the line item.
        /// </para>
        /// </summary>
        public string LineItemId
        {
            get { return this._lineItemId; }
            set { this._lineItemId = value; }
        }

        // Check to see if LineItemId property is set
        internal bool IsSetLineItemId()
        {
            return this._lineItemId != null;
        }

        /// <summary>
        /// Gets and sets the property Quantity. 
        /// <para>
        /// The quantity of the line item.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public int Quantity
        {
            get { return this._quantity.GetValueOrDefault(); }
            set { this._quantity = value; }
        }

        // Check to see if Quantity property is set
        internal bool IsSetQuantity()
        {
            return this._quantity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the line item.
        /// </para>
        /// </summary>
        public LineItemStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}