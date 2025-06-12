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
    /// Container for the parameters to the CreateVpcEndpointConnectionNotification operation.
    /// Creates a connection notification for a specified VPC endpoint or VPC endpoint service.
    /// A connection notification notifies you of specific endpoint events. You must create
    /// an SNS topic to receive notifications. For more information, see <a href="https://docs.aws.amazon.com/sns/latest/dg/CreateTopic.html">Creating
    /// an Amazon SNS topic</a> in the <i>Amazon SNS Developer Guide</i>.
    /// 
    ///  
    /// <para>
    /// You can create a connection notification for interface endpoints only.
    /// </para>
    /// </summary>
    public partial class CreateVpcEndpointConnectionNotificationRequest : AmazonEC2Request
    {
        private string _clientToken;
        private List<string> _connectionEvents = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _connectionNotificationArn;
        private bool? _dryRun;
        private string _serviceId;
        private string _vpcEndpointId;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request. For more information, see <a href="https://docs.aws.amazon.com/ec2/latest/devguide/ec2-api-idempotency.html">How
        /// to ensure idempotency</a>.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectionEvents. 
        /// <para>
        /// The endpoint events for which to receive notifications. Valid values are <c>Accept</c>,
        /// <c>Connect</c>, <c>Delete</c>, and <c>Reject</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The ARN of the SNS topic for the notifications.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The ID of the endpoint.
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