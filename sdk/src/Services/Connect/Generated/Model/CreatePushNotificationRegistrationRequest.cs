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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the CreatePushNotificationRegistration operation.
    /// Creates registration for a device token and a chat contact to receive real-time push
    /// notifications. For more information about push notifications, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/enable-push-notifications-for-mobile-chat.html">Set
    /// up push notifications in Amazon Connect for mobile chat</a> in the <i>Amazon Connect
    /// Administrator Guide</i>.
    /// </summary>
    public partial class CreatePushNotificationRegistrationRequest : AmazonConnectRequest
    {
        private string _clientToken;
        private ContactConfiguration _contactConfiguration;
        private string _deviceToken;
        private DeviceType _deviceType;
        private string _instanceId;
        private string _pinpointAppArn;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. If not provided, the Amazon Web Services SDK populates this field. For
        /// more information about idempotency, see <a href="https://aws.amazon.com/builders-library/making-retries-safe-with-idempotent-APIs/">Making
        /// retries safe with idempotent APIs</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=500)]
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
        /// Gets and sets the property ContactConfiguration. 
        /// <para>
        /// The contact configuration for push notification registration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ContactConfiguration ContactConfiguration
        {
            get { return this._contactConfiguration; }
            set { this._contactConfiguration = value; }
        }

        // Check to see if ContactConfiguration property is set
        internal bool IsSetContactConfiguration()
        {
            return this._contactConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceToken. 
        /// <para>
        /// The push notification token issued by the Apple or Google gateways.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=500)]
        public string DeviceToken
        {
            get { return this._deviceToken; }
            set { this._deviceToken = value; }
        }

        // Check to see if DeviceToken property is set
        internal bool IsSetDeviceToken()
        {
            return this._deviceToken != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceType. 
        /// <para>
        /// The device type to use when sending the message.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DeviceType DeviceType
        {
            get { return this._deviceType; }
            set { this._deviceType = value; }
        }

        // Check to see if DeviceType property is set
        internal bool IsSetDeviceType()
        {
            return this._deviceType != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Amazon Connect instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property PinpointAppArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Pinpoint application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PinpointAppArn
        {
            get { return this._pinpointAppArn; }
            set { this._pinpointAppArn = value; }
        }

        // Check to see if PinpointAppArn property is set
        internal bool IsSetPinpointAppArn()
        {
            return this._pinpointAppArn != null;
        }

    }
}