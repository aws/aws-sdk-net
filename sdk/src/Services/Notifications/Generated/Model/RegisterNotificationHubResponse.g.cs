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

namespace Amazon.Notifications.Model
{
    /// <summary>
    /// This is the response object from the RegisterNotificationHub operation.
    /// </summary>
    public partial class RegisterNotificationHubResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date the resource was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastActivationTime. 
        /// <para>
        /// The date the resource was last activated.
        /// </para>
        /// </summary>
        public DateTime? LastActivationTime { get; set; }

        /// <summary>
        /// Checks to see if the LastActivationTime property is set.
        /// </summary>
        internal bool IsSetLastActivationTime() => this.LastActivationTime.HasValue;

        /// <summary>
        /// Gets and sets the property NotificationHubRegion. 
        /// <para>
        /// The Region of the <c>NotificationHub</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 25)]
        public string NotificationHubRegion { get; set; }

        /// <summary>
        /// Checks to see if the NotificationHubRegion property is set.
        /// </summary>
        internal bool IsSetNotificationHubRegion() => this.NotificationHubRegion != null;

        /// <summary>
        /// Gets and sets the property StatusSummary. 
        /// <para>
        /// Provides additional information about the current <c>NotificationHub</c> status information.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public NotificationHubStatusSummary StatusSummary { get; set; }

        /// <summary>
        /// Checks to see if the StatusSummary property is set.
        /// </summary>
        internal bool IsSetStatusSummary() => this.StatusSummary != null;
    }
}
