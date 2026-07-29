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
 * Do not modify this file. This file is generated from the route53resolver-2018-04-01.normal.json service model.
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
namespace Amazon.Route53Resolver.Model
{
    /// <summary>
    /// Identifies the AWS Marketplace product that backs a partner-managed rule type. Returned
    /// as part of <a>FirewallRuleTypeDefinition</a> when the rule type variant requires an
    /// active customer subscription to the named product.
    /// </summary>
    public partial class SubscriptionInfo
    {
        private string _productId;
        private string _vendorName;

        /// <summary>
        /// Gets and sets the property ProductId. 
        /// <para>
        /// The AWS Marketplace product identifier of the partner threat-protection product. Use
        /// this value to verify or manage the calling account's subscription in AWS Marketplace.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
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
        /// Gets and sets the property VendorName. 
        /// <para>
        /// The name of the AWS Marketplace seller (vendor) that publishes the partner threat-protection
        /// product (for example, <c>Palo Alto Networks</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string VendorName
        {
            get { return this._vendorName; }
            set { this._vendorName = value; }
        }

        // Check to see if VendorName property is set
        internal bool IsSetVendorName()
        {
            return this._vendorName != null;
        }

    }
}