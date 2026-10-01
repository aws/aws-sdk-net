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
    /// This is the response object from the GetDataLakeExceptionSubscription operation.
    /// </summary>
    public partial class GetDataLakeExceptionSubscriptionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ExceptionTimeToLive. 
        /// <para>
        /// The expiration period and time-to-live (TTL). It is the duration of time until which
        /// the exception message remains.
        /// </para>
        /// </summary>
        public long? ExceptionTimeToLive { get; set; }

        /// <summary>
        /// Checks to see if the ExceptionTimeToLive property is set.
        /// </summary>
        internal bool IsSetExceptionTimeToLive() => this.ExceptionTimeToLive.HasValue;

        /// <summary>
        /// Gets and sets the property NotificationEndpoint. 
        /// <para>
        /// The Amazon Web Services account where you receive exception notifications.
        /// </para>
        /// </summary>
        public string NotificationEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the NotificationEndpoint property is set.
        /// </summary>
        internal bool IsSetNotificationEndpoint() => this.NotificationEndpoint != null;

        /// <summary>
        /// Gets and sets the property SubscriptionProtocol. 
        /// <para>
        /// The subscription protocol to which exception notifications are posted.
        /// </para>
        /// </summary>
        public string SubscriptionProtocol { get; set; }

        /// <summary>
        /// Checks to see if the SubscriptionProtocol property is set.
        /// </summary>
        internal bool IsSetSubscriptionProtocol() => this.SubscriptionProtocol != null;
    }
}
