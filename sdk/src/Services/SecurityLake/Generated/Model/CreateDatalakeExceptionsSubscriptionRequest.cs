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
 * Do not modify this file. This file is generated from the securitylake-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityLake.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDatalakeExceptionsSubscription operation.
    /// Creates the specified notification subscription in Amazon Security Lake for the organization
    /// you specify.
    /// </summary>
    public partial class CreateDatalakeExceptionsSubscriptionRequest : AmazonSecurityLakeRequest
    {
        private string _notificationEndpoint;
        private SubscriptionProtocolType _subscriptionProtocol;

        /// <summary>
        /// Gets and sets the property NotificationEndpoint. 
        /// <para>
        /// The Amazon Web Services account where you want to receive exception notifications.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string NotificationEndpoint
        {
            get { return this._notificationEndpoint; }
            set { this._notificationEndpoint = value; }
        }

        // Check to see if NotificationEndpoint property is set
        internal bool IsSetNotificationEndpoint()
        {
            return this._notificationEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property SubscriptionProtocol. 
        /// <para>
        /// The subscription protocol to which exception notifications are posted. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SubscriptionProtocolType SubscriptionProtocol
        {
            get { return this._subscriptionProtocol; }
            set { this._subscriptionProtocol = value; }
        }

        // Check to see if SubscriptionProtocol property is set
        internal bool IsSetSubscriptionProtocol()
        {
            return this._subscriptionProtocol != null;
        }

    }
}