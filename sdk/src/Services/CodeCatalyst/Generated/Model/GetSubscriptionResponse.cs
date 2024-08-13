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
 * Do not modify this file. This file is generated from the codecatalyst-2022-09-28.normal.json service model.
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
namespace Amazon.CodeCatalyst.Model
{
    /// <summary>
    /// This is the response object from the GetSubscription operation.
    /// </summary>
    public partial class GetSubscriptionResponse : AmazonWebServiceResponse
    {
        private string _awsAccountName;
        private DateTime? _pendingSubscriptionStartTime;
        private string _pendingSubscriptionType;
        private string _subscriptionType;

        /// <summary>
        /// Gets and sets the property AwsAccountName. 
        /// <para>
        /// The display name of the Amazon Web Services account used for billing for the space.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=63)]
        public string AwsAccountName
        {
            get { return this._awsAccountName; }
            set { this._awsAccountName = value; }
        }

        // Check to see if AwsAccountName property is set
        internal bool IsSetAwsAccountName()
        {
            return this._awsAccountName != null;
        }

        /// <summary>
        /// Gets and sets the property PendingSubscriptionStartTime. 
        /// <para>
        /// The day and time the pending change will be applied to the space, in coordinated universal
        /// time (UTC) timestamp format as specified in <a href="https://www.rfc-editor.org/rfc/rfc3339#section-5.6">RFC
        /// 3339</a>.
        /// </para>
        /// </summary>
        public DateTime? PendingSubscriptionStartTime
        {
            get { return this._pendingSubscriptionStartTime; }
            set { this._pendingSubscriptionStartTime = value; }
        }

        // Check to see if PendingSubscriptionStartTime property is set
        internal bool IsSetPendingSubscriptionStartTime()
        {
            return this._pendingSubscriptionStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PendingSubscriptionType. 
        /// <para>
        /// The type of the billing plan that the space will be changed to at the start of the
        /// next billing cycle. This applies only to changes that reduce the functionality available
        /// for the space. Billing plan changes that increase functionality are applied immediately.
        /// For more information, see <a href="https://codecatalyst.aws/explore/pricing">Pricing</a>.
        /// </para>
        /// </summary>
        public string PendingSubscriptionType
        {
            get { return this._pendingSubscriptionType; }
            set { this._pendingSubscriptionType = value; }
        }

        // Check to see if PendingSubscriptionType property is set
        internal bool IsSetPendingSubscriptionType()
        {
            return this._pendingSubscriptionType != null;
        }

        /// <summary>
        /// Gets and sets the property SubscriptionType. 
        /// <para>
        /// The type of the billing plan for the space.
        /// </para>
        /// </summary>
        public string SubscriptionType
        {
            get { return this._subscriptionType; }
            set { this._subscriptionType = value; }
        }

        // Check to see if SubscriptionType property is set
        internal bool IsSetSubscriptionType()
        {
            return this._subscriptionType != null;
        }

    }
}