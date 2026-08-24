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
 * Do not modify this file. This file is generated from the pricing-plan-manager-2025-08-05.normal.json service model.
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
namespace Amazon.PricingPlanManager.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateSubscription operation.
    /// Changes the plan tier of an existing subscription.
    /// 
    ///  <note> 
    /// <para>
    /// Upgrades take effect immediately. Downgrades are scheduled and the current tier remains
    /// unchanged until the end of the billing cycle (calendar month). You cannot update a
    /// subscription while a scheduled change is pending. To make a new change, first cancel
    /// the pending change using <c>CancelSubscriptionChange</c>.
    /// </para>
    ///  
    /// <para>
    /// This operation replaces the plan tier value. If you omit the optional <c>usageLevel</c>
    /// field, it is reset to the default.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class UpdateSubscriptionRequest : AmazonPricingPlanManagerRequest
    {
        private string _arn;
        private string _clientToken;
        private string _ifMatch;
        private string _planTier;
        private string _usageLevel;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the subscription to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the request is handled
        /// only once.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property IfMatch. 
        /// <para>
        /// The <c>ETag</c> value from a previous <c>GetSubscription</c> or <c>ListSubscriptions</c>
        /// response. This ensures you are updating the expected version of the subscription.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string IfMatch
        {
            get { return this._ifMatch; }
            set { this._ifMatch = value; }
        }

        // Check to see if IfMatch property is set
        internal bool IsSetIfMatch()
        {
            return this._ifMatch != null;
        }

        /// <summary>
        /// Gets and sets the property PlanTier. 
        /// <para>
        /// The new tier level for the subscription.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PlanTier
        {
            get { return this._planTier; }
            set { this._planTier = value; }
        }

        // Check to see if PlanTier property is set
        internal bool IsSetPlanTier()
        {
            return this._planTier != null;
        }

        /// <summary>
        /// Gets and sets the property UsageLevel. 
        /// <para>
        /// The usage level within the plan tier. Specify <c>DEFAULT</c> for the base configuration.
        /// If omitted, the usage level is reset to the default.
        /// </para>
        /// </summary>
        public string UsageLevel
        {
            get { return this._usageLevel; }
            set { this._usageLevel = value; }
        }

        // Check to see if UsageLevel property is set
        internal bool IsSetUsageLevel()
        {
            return this._usageLevel != null;
        }

    }
}