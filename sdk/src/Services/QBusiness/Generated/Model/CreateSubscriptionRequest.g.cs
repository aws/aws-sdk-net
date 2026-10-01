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
    /// Container for the parameters to the CreateSubscription operation. Subscribes an IAM
    /// Identity Center user or a group to a pricing tier for an Amazon Q Business application.
    /// <para> Amazon Q Business offers two subscription tiers: <c>Q_LITE</c> and <c>Q_BUSINESS</c>.
    /// Subscription tier determines feature access for the user. For more information on
    /// subscriptions and pricing tiers, see <a href="https://aws.amazon.com/q/business/pricing/">Amazon
    /// Q Business pricing</a>. </para> <note> <para> For an example IAM role policy for assigning
    /// subscriptions, see <a href="https://docs.aws.amazon.com/amazonq/latest/qbusiness-ug/setting-up.html#permissions">Set
    /// up required permissions</a> in the Amazon Q Business User Guide. </para> </note>
    /// </summary>
    public partial class CreateSubscriptionRequest : AmazonQBusinessRequest
    {
        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The identifier of the Amazon Q Business application the subscription should be added
        /// to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationId property is set.
        /// </summary>
        internal bool IsSetApplicationId() => this.ApplicationId != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A token that you provide to identify the request to create a subscription for your
        /// Amazon Q Business application.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Principal. 
        /// <para>
        /// The IAM Identity Center <c>UserId</c> or <c>GroupId</c> of a user or group in the
        /// IAM Identity Center instance connected to the Amazon Q Business application.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SubscriptionPrincipal Principal { get; set; }

        /// <summary>
        /// Checks to see if the Principal property is set.
        /// </summary>
        internal bool IsSetPrincipal() => this.Principal != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of Amazon Q Business subscription you want to create.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SubscriptionType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
