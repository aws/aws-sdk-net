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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the CreatePushNotificationRegistration operation.
    /// Creates registration for a device token and a chat contact to receive real-time push
    /// notifications. For more information about push notifications, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/enable-push-notifications-for-mobile-chat.html">Set
    /// up push notifications in Connect Customer for mobile chat</a> in the <i>Connect Customer
    /// Administrator Guide</i>.
    /// </summary>
    public partial class CreatePushNotificationRegistrationRequest : AmazonConnectRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. If not provided, the Amazon Web Services SDK populates this field. For
        /// more information about idempotency, see <a href="https://aws.amazon.com/builders-library/making-retries-safe-with-idempotent-APIs/">Making
        /// retries safe with idempotent APIs</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 500)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property ContactConfiguration. 
        /// <para>
        /// The contact configuration for push notification registration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ContactConfiguration ContactConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ContactConfiguration property is set.
        /// </summary>
        internal bool IsSetContactConfiguration() => this.ContactConfiguration != null;

        /// <summary>
        /// Gets and sets the property DeviceToken. 
        /// <para>
        /// The push notification token issued by the Apple or Google gateways.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 500)]
        public string DeviceToken { get; set; }

        /// <summary>
        /// Checks to see if the DeviceToken property is set.
        /// </summary>
        internal bool IsSetDeviceToken() => this.DeviceToken != null;

        /// <summary>
        /// Gets and sets the property DeviceType. 
        /// <para>
        /// The device type to use when sending the message.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DeviceType DeviceType { get; set; }

        /// <summary>
        /// Checks to see if the DeviceType property is set.
        /// </summary>
        internal bool IsSetDeviceType() => this.DeviceType != null;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Amazon Connect instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property PinpointAppArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Pinpoint application.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string PinpointAppArn { get; set; }

        /// <summary>
        /// Checks to see if the PinpointAppArn property is set.
        /// </summary>
        internal bool IsSetPinpointAppArn() => this.PinpointAppArn != null;
    }
}
