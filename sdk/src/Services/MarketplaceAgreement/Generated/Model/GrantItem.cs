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
 * Do not modify this file. This file is generated from the marketplace-agreement-2020-03-01.normal.json service model.
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
namespace Amazon.MarketplaceAgreement.Model
{
    /// <summary>
    /// Entitlements granted to the acceptor of fixed upfront as part of agreement execution.
    /// </summary>
    public partial class GrantItem
    {
        private string _dimensionKey;
        private int? _maxQuantity;

        /// <summary>
        /// Gets and sets the property DimensionKey. 
        /// <para>
        /// Unique dimension key defined in the product document. Dimensions represent categories
        /// of capacity in a product and are specified when the product is listed in AWS Marketplace.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
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
        /// Gets and sets the property MaxQuantity. 
        /// <para>
        /// Maximum amount of capacity that the buyer can be entitled to the given dimension of
        /// the product. If <c>MaxQuantity</c> is not provided, the buyer will be able to use
        /// an unlimited amount of the given dimension. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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

    }
}