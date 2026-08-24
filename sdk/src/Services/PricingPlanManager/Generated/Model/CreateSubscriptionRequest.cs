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
    /// Container for the parameters to the CreateSubscription operation.
    /// Creates a flat-rate pricing subscription for the specified resources.
    /// 
    ///  <note> 
    /// <para>
    /// When <c>approvalMode</c> is set to <c>MANUAL</c>, paid-tier subscriptions are created
    /// in <c>PENDING_APPROVAL</c> status and require a separate <c>ApprovePaidSubscription</c>
    /// call before billing starts. Free-tier subscriptions are always activated immediately
    /// regardless of approval mode.
    /// </para>
    ///  
    /// <para>
    /// When <c>approvalMode</c> is set to <c>IMMEDIATE</c> or is not specified, the subscription
    /// is activated immediately.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateSubscriptionRequest : AmazonPricingPlanManagerRequest
    {
        private ApprovalMode _approvalMode;
        private string _clientToken;
        private string _planFamily;
        private string _planTier;
        private List<string> _resourceArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _usageLevel;

        /// <summary>
        /// Gets and sets the property ApprovalMode. 
        /// <para>
        /// Determines whether the subscription requires explicit approval before billing starts.
        /// Set to <c>MANUAL</c> to require a separate <c>ApprovePaidSubscription</c> call, or
        /// <c>IMMEDIATE</c> to activate the subscription right away. Defaults to <c>IMMEDIATE</c>
        /// if not specified.
        /// </para>
        /// </summary>
        public ApprovalMode ApprovalMode
        {
            get { return this._approvalMode; }
            set { this._approvalMode = value; }
        }

        // Check to see if ApprovalMode property is set
        internal bool IsSetApprovalMode()
        {
            return this._approvalMode != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure that the request is
        /// handled only once. If you send the same request with the same client token, the API
        /// returns the original response without creating a duplicate subscription.
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
        /// Gets and sets the property PlanFamily. 
        /// <para>
        /// The pricing plan family to subscribe to, such as <c>CloudFront</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PlanFamily
        {
            get { return this._planFamily; }
            set { this._planFamily = value; }
        }

        // Check to see if PlanFamily property is set
        internal bool IsSetPlanFamily()
        {
            return this._planFamily != null;
        }

        /// <summary>
        /// Gets and sets the property PlanTier. 
        /// <para>
        /// The tier level for the subscription, such as <c>FREE</c>, <c>PRO</c>, <c>BUSINESS</c>,
        /// or <c>PREMIUM</c>.
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
        /// Gets and sets the property ResourceArns. 
        /// <para>
        /// The ARNs of the AWS resources to include in the subscription. Specify one or more
        /// supported resources.
        /// </para>
        ///  <note> 
        /// <para>
        /// For subscriptions in the CloudFront plan family, the resources must include exactly
        /// one Amazon CloudFront distribution and exactly one AWS WAF web ACL. You can also include
        /// other supported resources, such as Amazon Route 53 hosted zones and CloudFront KeyValueStores.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public List<string> ResourceArns
        {
            get { return this._resourceArns; }
            set { this._resourceArns = value; }
        }

        // Check to see if ResourceArns property is set
        internal bool IsSetResourceArns()
        {
            return this._resourceArns != null && (this._resourceArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UsageLevel. 
        /// <para>
        /// The usage level within the plan tier. Specify <c>DEFAULT</c> for the base configuration,
        /// or a higher level if your plan tier supports it.
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