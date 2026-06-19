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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
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
namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// Specifies the monetize action settings for a rule. When WAF applies this action, it
    /// returns an HTTP 402 Payment Required response containing pricing information that
    /// the requesting client uses to complete payment and gain access to the resource. This
    /// is a terminating action-if the client does not complete the 402 payment flow, the
    /// request is blocked. This action is available only for web ACLs associated with Amazon
    /// CloudFront distributions. You must configure a <c>MonetizationConfig</c> on the web
    /// ACL or rule group before adding rules that use this action. You cannot use the Monetize
    /// action for rate-based rules.
    /// </summary>
    public partial class MonetizeAction
    {
        private string _priceMultiplier;

        /// <summary>
        /// Gets and sets the property PriceMultiplier. 
        /// <para>
        /// An integer multiplier applied to the base price defined in the web ACL's <c>MonetizationConfig</c>.
        /// The effective price for the request is the base price multiplied by this value. Specify
        /// as a string. Valid values: 1 to 100.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=3)]
        public string PriceMultiplier
        {
            get { return this._priceMultiplier; }
            set { this._priceMultiplier = value; }
        }

        // Check to see if PriceMultiplier property is set
        internal bool IsSetPriceMultiplier()
        {
            return this._priceMultiplier != null;
        }

    }
}