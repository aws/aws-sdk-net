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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
    /// Container for the parameters to the ModifyVpcEndpointConnectionNotification operation.
    /// Modifies a connection notification for VPC endpoint or VPC endpoint service. You can
    /// change the SNS topic for the notification, or the events for which to be notified.
    /// </summary>
    public partial class ModifyVpcEndpointConnectionNotificationRequest : AmazonEC2Request
    {
        private List<string> _connectionEvents = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _connectionNotificationArn;
        private string _connectionNotificationId;
        private bool? _dryRun;

        /// <summary>
        /// Gets and sets the property ConnectionEvents. 
        /// <para>
        /// The events for the endpoint. Valid values are <c>Accept</c>, <c>Connect</c>, <c>Delete</c>,
        /// and <c>Reject</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ConnectionEvents
        {
            get { return this._connectionEvents; }
            set { this._connectionEvents = value; }
        }

        // Check to see if ConnectionEvents property is set
        internal bool IsSetConnectionEvents()
        {
            return this._connectionEvents != null && (this._connectionEvents.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ConnectionNotificationArn. 
        /// <para>
        /// The ARN for the SNS topic for the notification.
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
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

    }
}