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
 * Do not modify this file. This file is generated from the pinpoint-sms-voice-v2-2022-03-31.normal.json service model.
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
    /// Container for the parameters to the UpdatePhoneNumber operation.
    /// Updates the configuration of an existing origination phone number. You can update
    /// the opt-out list, enable or disable two-way messaging, change the TwoWayChannelArn,
    /// enable or disable self-managed opt-outs, and enable or disable deletion protection.
    /// 
    ///  
    /// <para>
    /// If the origination phone number is associated with a pool, an error is returned.
    /// </para>
    /// </summary>
    public partial class UpdatePhoneNumberRequest : AmazonPinpointSMSVoiceV2Request
    {
        private bool? _deletionProtectionEnabled;
        private bool? _internationalSendingEnabled;
        private string _optOutListName;
        private string _phoneNumberId;
        private bool? _selfManagedOptOutsEnabled;
        private string _twoWayChannelArn;
        private string _twoWayChannelRole;
        private bool? _twoWayEnabled;

        /// <summary>
        /// Gets and sets the property DeletionProtectionEnabled. 
        /// <para>
        /// By default this is set to false. When set to true the phone number can't be deleted.
        /// 
        /// </para>
        /// </summary>
        public bool? DeletionProtectionEnabled
        {
            get { return this._deletionProtectionEnabled; }
            set { this._deletionProtectionEnabled = value; }
        }

        // Check to see if DeletionProtectionEnabled property is set
        internal bool IsSetDeletionProtectionEnabled()
        {
            return this._deletionProtectionEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InternationalSendingEnabled. 
        /// <para>
        /// By default this is set to false. When set to true the international sending of phone
        /// number is Enabled. 
        /// </para>
        /// </summary>
        public bool? InternationalSendingEnabled
        {
            get { return this._internationalSendingEnabled; }
            set { this._internationalSendingEnabled = value; }
        }

        // Check to see if InternationalSendingEnabled property is set
        internal bool IsSetInternationalSendingEnabled()
        {
            return this._internationalSendingEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OptOutListName. 
        /// <para>
        /// The OptOutList to add the phone number to. Valid values for this field can be either
        /// the OutOutListName or OutOutListArn.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string OptOutListName
        {
            get { return this._optOutListName; }
            set { this._optOutListName = value; }
        }

        // Check to see if OptOutListName property is set
        internal bool IsSetOptOutListName()
        {
            return this._optOutListName != null;
        }

        /// <summary>
        /// Gets and sets the property PhoneNumberId. 
        /// <para>
        /// The unique identifier of the phone number. Valid values for this field can be either
        /// the PhoneNumberId or PhoneNumberArn.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you are using a shared AWS End User Messaging SMS and Voice resource then you must
        /// use the full Amazon Resource Name(ARN).
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string PhoneNumberId
        {
            get { return this._phoneNumberId; }
            set { this._phoneNumberId = value; }
        }

        // Check to see if PhoneNumberId property is set
        internal bool IsSetPhoneNumberId()
        {
            return this._phoneNumberId != null;
        }

        /// <summary>
        /// Gets and sets the property SelfManagedOptOutsEnabled. 
        /// <para>
        /// By default this is set to false. When an end recipient sends a message that begins
        /// with HELP or STOP to one of your dedicated numbers, AWS End User Messaging SMS and
        /// Voice automatically replies with a customizable message and adds the end recipient
        /// to the OptOutList. When set to true you're responsible for responding to HELP and
        /// STOP requests. You're also responsible for tracking and honoring opt-out requests.
        /// </para>
        /// </summary>
        public bool? SelfManagedOptOutsEnabled
        {
            get { return this._selfManagedOptOutsEnabled; }
            set { this._selfManagedOptOutsEnabled = value; }
        }

        // Check to see if SelfManagedOptOutsEnabled property is set
        internal bool IsSetSelfManagedOptOutsEnabled()
        {
            return this._selfManagedOptOutsEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TwoWayChannelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the two way channel.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string TwoWayChannelArn
        {
            get { return this._twoWayChannelArn; }
            set { this._twoWayChannelArn = value; }
        }

        // Check to see if TwoWayChannelArn property is set
        internal bool IsSetTwoWayChannelArn()
        {
            return this._twoWayChannelArn != null;
        }

        /// <summary>
        /// Gets and sets the property TwoWayChannelRole. 
        /// <para>
        /// An optional IAM Role Arn for a service to assume, to be able to post inbound SMS messages.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string TwoWayChannelRole
        {
            get { return this._twoWayChannelRole; }
            set { this._twoWayChannelRole = value; }
        }

        // Check to see if TwoWayChannelRole property is set
        internal bool IsSetTwoWayChannelRole()
        {
            return this._twoWayChannelRole != null;
        }

        /// <summary>
        /// Gets and sets the property TwoWayEnabled. 
        /// <para>
        /// By default this is set to false. When set to true you can receive incoming text messages
        /// from your end recipients.
        /// </para>
        /// </summary>
        public bool? TwoWayEnabled
        {
            get { return this._twoWayEnabled; }
            set { this._twoWayEnabled = value; }
        }

        // Check to see if TwoWayEnabled property is set
        internal bool IsSetTwoWayEnabled()
        {
            return this._twoWayEnabled.HasValue; 
        }

    }
}