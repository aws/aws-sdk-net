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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EKS.Model
{
    /// <summary>
    /// Information about an Amazon EKS add-on from the Amazon Web Services Marketplace.
    /// </summary>
    public partial class MarketplaceInformation
    {
        private string _productId;
        private string _productUrl;

        /// <summary>
        /// Gets and sets the property ProductId. 
        /// <para>
        /// The product ID from the Amazon Web Services Marketplace.
        /// </para>
        /// </summary>
        public string ProductId
        {
            get { return this._productId; }
            set { this._productId = value; }
        }

        // Check to see if ProductId property is set
        internal bool IsSetProductId()
        {
            return this._productId != null;
        }

        /// <summary>
        /// Gets and sets the property ProductUrl. 
        /// <para>
        /// The product URL from the Amazon Web Services Marketplace.
        /// </para>
        /// </summary>
        public string ProductUrl
        {
            get { return this._productUrl; }
            set { this._productUrl = value; }
        }

        // Check to see if ProductUrl property is set
        internal bool IsSetProductUrl()
        {
            return this._productUrl != null;
        }

    }
}