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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
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
namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// Container for the parameters to the PutAccountPricingAttributes operation.
    /// Set the pricing plan for your Amazon SES account. Use this operation to choose a billing
    /// plan that packages multiple Amazon SES features at a single rate.
    /// </summary>
    public partial class PutAccountPricingAttributesRequest : AmazonSimpleEmailServiceV2Request
    {
        private PricingPlan _plan;

        /// <summary>
        /// Gets and sets the property Plan. 
        /// <para>
        /// The pricing plan to apply to your Amazon SES account. Can be one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>NONE</c> – No pricing plan is applied; billing follows per-feature pricing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ESSENTIALS</c> – Baseline Amazon SES capabilities and select premium features.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PRO</c> – Includes everything in <c>ESSENTIALS</c>, plus additional premium features
        /// for growing senders.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ENTERPRISE</c> – Includes everything in <c>PRO</c>, plus features intended for
        /// large-scale senders.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public PricingPlan Plan
        {
            get { return this._plan; }
            set { this._plan = value; }
        }

        // Check to see if Plan property is set
        internal bool IsSetPlan()
        {
            return this._plan != null;
        }

    }
}