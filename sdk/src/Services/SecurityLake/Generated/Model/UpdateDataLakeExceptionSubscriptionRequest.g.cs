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

namespace Amazon.SecurityLake.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDataLakeExceptionSubscription operation.
    /// Updates the specified notification subscription in Amazon Security Lake for the organization
    /// you specify.
    /// </summary>
    public partial class UpdateDataLakeExceptionSubscriptionRequest : AmazonSecurityLakeRequest
    {
        /// <summary>
        /// Gets and sets the property ExceptionTimeToLive. 
        /// <para>
        /// The time-to-live (TTL) for the exception message to remain. It is the duration of
        /// time until which the exception message remains. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public long? ExceptionTimeToLive { get; set; }

        /// <summary>
        /// Checks to see if the ExceptionTimeToLive property is set.
        /// </summary>
        internal bool IsSetExceptionTimeToLive() => this.ExceptionTimeToLive.HasValue;

        /// <summary>
        /// Gets and sets the property NotificationEndpoint. 
        /// <para>
        /// The account that is subscribed to receive exception notifications.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string NotificationEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the NotificationEndpoint property is set.
        /// </summary>
        internal bool IsSetNotificationEndpoint() => this.NotificationEndpoint != null;

        /// <summary>
        /// Gets and sets the property SubscriptionProtocol. 
        /// <para>
        /// The subscription protocol to which exception messages are posted.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SubscriptionProtocol { get; set; }

        /// <summary>
        /// Checks to see if the SubscriptionProtocol property is set.
        /// </summary>
        internal bool IsSetSubscriptionProtocol() => this.SubscriptionProtocol != null;
    }
}
