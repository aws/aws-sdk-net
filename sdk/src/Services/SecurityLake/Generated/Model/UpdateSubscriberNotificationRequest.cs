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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SecurityLake.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateSubscriberNotification operation.
    /// Updates an existing notification method for the subscription (SQS or HTTPs endpoint)
    /// or switches the notification subscription endpoint for a subscriber.
    /// </summary>
    public partial class UpdateSubscriberNotificationRequest : AmazonSecurityLakeRequest
    {
        private NotificationConfiguration _configuration;
        private string _subscriberId;

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The configuration for subscriber notification.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public NotificationConfiguration Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

        /// <summary>
        /// Gets and sets the property SubscriberId. 
        /// <para>
        /// The subscription ID for which the subscription notification is specified.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SubscriberId
        {
            get { return this._subscriberId; }
            set { this._subscriberId = value; }
        }

        // Check to see if SubscriberId property is set
        internal bool IsSetSubscriberId()
        {
            return this._subscriberId != null;
        }

    }
}