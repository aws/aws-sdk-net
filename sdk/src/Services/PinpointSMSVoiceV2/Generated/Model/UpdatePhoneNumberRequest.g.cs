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

namespace Amazon.PinpointSMSVoiceV2.Model
{
    /// <summary>
    /// Container for the parameters to the UpdatePhoneNumber operation. Updates the configuration
    /// of an existing origination phone number. You can update the opt-out list, enable or
    /// disable two-way messaging, change the TwoWayChannelArn, enable or disable self-managed
    /// opt-outs, and enable or disable deletion protection. <para> If the origination phone
    /// number is associated with a pool, an error is returned. </para>
    /// </summary>
    public partial class UpdatePhoneNumberRequest : AmazonPinpointSMSVoiceV2Request
    {
        /// <summary>
        /// Gets and sets the property DeletionProtectionEnabled. 
        /// <para>
        /// By default this is set to false. When set to true the phone number can't be deleted.
        /// 
        /// </para>
        /// </summary>
        public bool? DeletionProtectionEnabled { get; set; }

        /// <summary>
        /// Checks to see if the DeletionProtectionEnabled property is set.
        /// </summary>
        internal bool IsSetDeletionProtectionEnabled() => this.DeletionProtectionEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property InternationalSendingEnabled. 
        /// <para>
        /// By default this is set to false. When set to true the international sending of phone
        /// number is Enabled. 
        /// </para>
        /// </summary>
        public bool? InternationalSendingEnabled { get; set; }

        /// <summary>
        /// Checks to see if the InternationalSendingEnabled property is set.
        /// </summary>
        internal bool IsSetInternationalSendingEnabled() => this.InternationalSendingEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property OptOutListName. 
        /// <para>
        /// The OptOutList to add the phone number to. You can use either the opt out list name
        /// or the opt out list ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string OptOutListName { get; set; }

        /// <summary>
        /// Checks to see if the OptOutListName property is set.
        /// </summary>
        internal bool IsSetOptOutListName() => this.OptOutListName != null;

        /// <summary>
        /// Gets and sets the property PhoneNumberId. 
        /// <para>
        /// The unique identifier of the phone number. Valid values for this field can be either
        /// the PhoneNumberId or PhoneNumberArn.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you are using a shared End User Messaging SMS resource then you must use the full
        /// Amazon Resource Name(ARN).
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string PhoneNumberId { get; set; }

        /// <summary>
        /// Checks to see if the PhoneNumberId property is set.
        /// </summary>
        internal bool IsSetPhoneNumberId() => this.PhoneNumberId != null;

        /// <summary>
        /// Gets and sets the property SelfManagedOptOutsEnabled. 
        /// <para>
        /// By default this is set to false. When set to false and an end recipient sends a message
        /// that begins with HELP or STOP to one of your dedicated numbers, End User Messaging
        /// SMS automatically replies with a customizable message and adds the end recipient to
        /// the OptOutList. When set to true you're responsible for responding to HELP and STOP
        /// requests. You're also responsible for tracking and honoring opt-out requests.
        /// </para>
        /// </summary>
        public bool? SelfManagedOptOutsEnabled { get; set; }

        /// <summary>
        /// Checks to see if the SelfManagedOptOutsEnabled property is set.
        /// </summary>
        internal bool IsSetSelfManagedOptOutsEnabled() => this.SelfManagedOptOutsEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property TwoWayChannelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the two way channel.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string TwoWayChannelArn { get; set; }

        /// <summary>
        /// Checks to see if the TwoWayChannelArn property is set.
        /// </summary>
        internal bool IsSetTwoWayChannelArn() => this.TwoWayChannelArn != null;

        /// <summary>
        /// Gets and sets the property TwoWayChannelRole. 
        /// <para>
        /// An optional IAM Role Arn for a service to assume, to be able to post inbound SMS messages.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string TwoWayChannelRole { get; set; }

        /// <summary>
        /// Checks to see if the TwoWayChannelRole property is set.
        /// </summary>
        internal bool IsSetTwoWayChannelRole() => this.TwoWayChannelRole != null;

        /// <summary>
        /// Gets and sets the property TwoWayEnabled. 
        /// <para>
        /// By default this is set to false. When set to true you can receive incoming text messages
        /// from your end recipients.
        /// </para>
        /// </summary>
        public bool? TwoWayEnabled { get; set; }

        /// <summary>
        /// Checks to see if the TwoWayEnabled property is set.
        /// </summary>
        internal bool IsSetTwoWayEnabled() => this.TwoWayEnabled.HasValue;
    }
}
