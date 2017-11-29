/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a connection notification for a VPC endpoint or VPC endpoint service.
    /// </summary>
    public partial class ConnectionNotification
    {
        private List<string> _connectionEvents = new List<string>();
        private string _connectionNotificationArn;
        private string _connectionNotificationId;
        private ConnectionNotificationState _connectionNotificationState;
        private ConnectionNotificationType _connectionNotificationType;
        private string _serviceId;
        private string _vpcEndpointId;

        /// <summary>
        /// Gets and sets the property ConnectionEvents. 
        /// <para>
        /// The events for the notification. Valid values are <code>Accept</code>, <code>Connect</code>,
        /// <code>Delete</code>, and <code>Reject</code>.
        /// </para>
        /// </summary>
        public List<string> ConnectionEvents
        {
            get { return this._connectionEvents; }
            set { this._connectionEvents = value; }
        }

        // Check to see if ConnectionEvents property is set
        internal bool IsSetConnectionEvents()
        {
            return this._connectionEvents != null && this._connectionEvents.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ConnectionNotificationArn. 
        /// <para>
        /// The ARN of the SNS topic for the notification.
        /// </para>
        /// </summary>
        public string ConnectionNotificationArn
        {
            get { return this._connectionNotificationArn; }
            set { this._connectionNotificationArn = value; }
        }

        // Check to see if ConnectionNotificationArn property is set
        internal bool IsSetConnectionNotificationArn()
        {
            return this._connectionNotificationArn != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectionNotificationId. 
        /// <para>
        /// The ID of the notification.
        /// </para>
        /// </summary>
        public string ConnectionNotificationId
        {
            get { return this._connectionNotificationId; }
            set { this._connectionNotificationId = value; }
        }

        // Check to see if ConnectionNotificationId property is set
        internal bool IsSetConnectionNotificationId()
        {
            return this._connectionNotificationId != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectionNotificationState. 
        /// <para>
        /// The state of the notification.
        /// </para>
        /// </summary>
        public ConnectionNotificationState ConnectionNotificationState
        {
            get { return this._connectionNotificationState; }
            set { this._connectionNotificationState = value; }
        }

        // Check to see if ConnectionNotificationState property is set
        internal bool IsSetConnectionNotificationState()
        {
            return this._connectionNotificationState != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectionNotificationType. 
        /// <para>
        /// The type of notification.
        /// </para>
        /// </summary>
        public ConnectionNotificationType ConnectionNotificationType
        {
            get { return this._connectionNotificationType; }
            set { this._connectionNotificationType = value; }
        }

        // Check to see if ConnectionNotificationType property is set
        internal bool IsSetConnectionNotificationType()
        {
            return this._connectionNotificationType != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceId. 
        /// <para>
        /// The ID of the endpoint service.
        /// </para>
        /// </summary>
        public string ServiceId
        {
            get { return this._serviceId; }
            set { this._serviceId = value; }
        }

        // Check to see if ServiceId property is set
        internal bool IsSetServiceId()
        {
            return this._serviceId != null;
        }

        /// <summary>
        /// Gets and sets the property VpcEndpointId. 
        /// <para>
        /// The ID of the VPC endpoint.
        /// </para>
        /// </summary>
        public string VpcEndpointId
        {
            get { return this._vpcEndpointId; }
            set { this._vpcEndpointId = value; }
        }

        // Check to see if VpcEndpointId property is set
        internal bool IsSetVpcEndpointId()
        {
            return this._vpcEndpointId != null;
        }

    }
}