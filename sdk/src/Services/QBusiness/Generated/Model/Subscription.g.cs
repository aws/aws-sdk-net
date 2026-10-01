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

namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// Information about an Amazon Q Business subscription.
    /// 
    ///  
    /// <para>
    /// Subscriptions are used to provide access for an IAM Identity Center user or a group
    /// to an Amazon Q Business application.
    /// </para>
    ///  
    /// <para>
    /// Amazon Q Business offers two subscription tiers: <c>Q_LITE</c> and <c>Q_BUSINESS</c>.
    /// Subscription tier determines feature access for the user. For more information on
    /// subscriptions and pricing tiers, see <a href="https://aws.amazon.com/q/business/pricing/">Amazon
    /// Q Business pricing</a>.
    /// </para>
    /// </summary>
    public partial class Subscription
    {
        /// <summary>
        /// Gets and sets the property CurrentSubscription. 
        /// <para>
        /// The type of your current Amazon Q Business subscription.
        /// </para>
        /// </summary>
        public SubscriptionDetails CurrentSubscription { get; set; }

        /// <summary>
        /// Checks to see if the CurrentSubscription property is set.
        /// </summary>
        internal bool IsSetCurrentSubscription() => this.CurrentSubscription != null;

        /// <summary>
        /// Gets and sets the property NextSubscription. 
        /// <para>
        /// The type of the Amazon Q Business subscription for the next month.
        /// </para>
        /// </summary>
        public SubscriptionDetails NextSubscription { get; set; }

        /// <summary>
        /// Checks to see if the NextSubscription property is set.
        /// </summary>
        internal bool IsSetNextSubscription() => this.NextSubscription != null;

        /// <summary>
        /// Gets and sets the property Principal. 
        /// <para>
        /// The IAM Identity Center <c>UserId</c> or <c>GroupId</c> of a user or group in the
        /// IAM Identity Center instance connected to the Amazon Q Business application.
        /// </para>
        /// </summary>
        public SubscriptionPrincipal Principal { get; set; }

        /// <summary>
        /// Checks to see if the Principal property is set.
        /// </summary>
        internal bool IsSetPrincipal() => this.Principal != null;

        /// <summary>
        /// Gets and sets the property SubscriptionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Q Business subscription that was updated.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 1224)]
        public string SubscriptionArn { get; set; }

        /// <summary>
        /// Checks to see if the SubscriptionArn property is set.
        /// </summary>
        internal bool IsSetSubscriptionArn() => this.SubscriptionArn != null;

        /// <summary>
        /// Gets and sets the property SubscriptionId. 
        /// <para>
        /// The identifier of the Amazon Q Business subscription to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1224)]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// Checks to see if the SubscriptionId property is set.
        /// </summary>
        internal bool IsSetSubscriptionId() => this.SubscriptionId != null;
    }
}
