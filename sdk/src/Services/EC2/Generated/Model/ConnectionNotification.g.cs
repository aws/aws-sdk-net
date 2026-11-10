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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a connection notification for a VPC endpoint or VPC endpoint service.
    /// </summary>
    public partial class ConnectionNotification
    {
        /// <summary>
        /// Gets and sets the property ConnectionEvents. 
        /// <para>
        /// The events for the notification. Valid values are <c>Accept</c>, <c>Connect</c>, <c>Delete</c>,
        /// and <c>Reject</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ConnectionEvents { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ConnectionEvents property is set.
        /// </summary>
        internal bool IsSetConnectionEvents() => this.ConnectionEvents != null && (this.ConnectionEvents.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ConnectionNotificationArn. 
        /// <para>
        /// The ARN of the SNS topic for the notification.
        /// </para>
        /// </summary>
        public string ConnectionNotificationArn { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionNotificationArn property is set.
        /// </summary>
        internal bool IsSetConnectionNotificationArn() => this.ConnectionNotificationArn != null;

        /// <summary>
        /// Gets and sets the property ConnectionNotificationId. 
        /// <para>
        /// The ID of the notification.
        /// </para>
        /// </summary>
        public string ConnectionNotificationId { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionNotificationId property is set.
        /// </summary>
        internal bool IsSetConnectionNotificationId() => this.ConnectionNotificationId != null;

        /// <summary>
        /// Gets and sets the property ConnectionNotificationState. 
        /// <para>
        /// The state of the notification.
        /// </para>
        /// </summary>
        public ConnectionNotificationState ConnectionNotificationState { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionNotificationState property is set.
        /// </summary>
        internal bool IsSetConnectionNotificationState() => this.ConnectionNotificationState != null;

        /// <summary>
        /// Gets and sets the property ConnectionNotificationType. 
        /// <para>
        /// The type of notification.
        /// </para>
        /// </summary>
        public ConnectionNotificationType ConnectionNotificationType { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionNotificationType property is set.
        /// </summary>
        internal bool IsSetConnectionNotificationType() => this.ConnectionNotificationType != null;

        /// <summary>
        /// Gets and sets the property ServiceId. 
        /// <para>
        /// The ID of the endpoint service.
        /// </para>
        /// </summary>
        public string ServiceId { get; set; }

        /// <summary>
        /// Checks to see if the ServiceId property is set.
        /// </summary>
        internal bool IsSetServiceId() => this.ServiceId != null;

        /// <summary>
        /// Gets and sets the property ServiceRegion. 
        /// <para>
        /// The Region for the endpoint service.
        /// </para>
        /// </summary>
        public string ServiceRegion { get; set; }

        /// <summary>
        /// Checks to see if the ServiceRegion property is set.
        /// </summary>
        internal bool IsSetServiceRegion() => this.ServiceRegion != null;

        /// <summary>
        /// Gets and sets the property VpcEndpointId. 
        /// <para>
        /// The ID of the VPC endpoint.
        /// </para>
        /// </summary>
        public string VpcEndpointId { get; set; }

        /// <summary>
        /// Checks to see if the VpcEndpointId property is set.
        /// </summary>
        internal bool IsSetVpcEndpointId() => this.VpcEndpointId != null;
    }
}
