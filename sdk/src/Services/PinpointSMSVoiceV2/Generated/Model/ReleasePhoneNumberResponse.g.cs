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
    /// This is the response object from the ReleasePhoneNumber operation.
    /// </summary>
    public partial class ReleasePhoneNumberResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The time when the phone number was created, in <a href="https://www.epochconverter.com/">UNIX
        /// epoch time</a> format.
        /// </para>
        /// </summary>
        public DateTime? CreatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTimestamp property is set.
        /// </summary>
        internal bool IsSetCreatedTimestamp() => this.CreatedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property IsoCountryCode. 
        /// <para>
        /// The two-character code, in ISO 3166-1 alpha-2 format, for the country or region.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 2)]
        public string IsoCountryCode { get; set; }

        /// <summary>
        /// Checks to see if the IsoCountryCode property is set.
        /// </summary>
        internal bool IsSetIsoCountryCode() => this.IsoCountryCode != null;

        /// <summary>
        /// Gets and sets the property MessageType. 
        /// <para>
        /// The message type that was associated with the phone number.
        /// </para>
        /// </summary>
        public MessageType MessageType { get; set; }

        /// <summary>
        /// Checks to see if the MessageType property is set.
        /// </summary>
        internal bool IsSetMessageType() => this.MessageType != null;

        /// <summary>
        /// Gets and sets the property MonthlyLeasingPrice. 
        /// <para>
        /// The monthly price of the phone number, in US dollars.
        /// </para>
        /// </summary>
        public string MonthlyLeasingPrice { get; set; }

        /// <summary>
        /// Checks to see if the MonthlyLeasingPrice property is set.
        /// </summary>
        internal bool IsSetMonthlyLeasingPrice() => this.MonthlyLeasingPrice != null;

        /// <summary>
        /// Gets and sets the property NumberCapabilities. 
        /// <para>
        /// Specifies if the number could be used for text messages, voice, or both.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 4)]
        public List<string> NumberCapabilities { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the NumberCapabilities property is set.
        /// </summary>
        internal bool IsSetNumberCapabilities() => this.NumberCapabilities != null && (this.NumberCapabilities.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NumberType. 
        /// <para>
        /// The type of number that was released.
        /// </para>
        /// </summary>
        public NumberType NumberType { get; set; }

        /// <summary>
        /// Checks to see if the NumberType property is set.
        /// </summary>
        internal bool IsSetNumberType() => this.NumberType != null;

        /// <summary>
        /// Gets and sets the property OptOutListName. 
        /// <para>
        /// The name of the OptOutList that was associated with the phone number.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string OptOutListName { get; set; }

        /// <summary>
        /// Checks to see if the OptOutListName property is set.
        /// </summary>
        internal bool IsSetOptOutListName() => this.OptOutListName != null;

        /// <summary>
        /// Gets and sets the property PhoneNumber. 
        /// <para>
        /// The phone number that was released.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Checks to see if the PhoneNumber property is set.
        /// </summary>
        internal bool IsSetPhoneNumber() => this.PhoneNumber != null;

        /// <summary>
        /// Gets and sets the property PhoneNumberArn. 
        /// <para>
        /// The PhoneNumberArn of the phone number that was released.
        /// </para>
        /// </summary>
        public string PhoneNumberArn { get; set; }

        /// <summary>
        /// Checks to see if the PhoneNumberArn property is set.
        /// </summary>
        internal bool IsSetPhoneNumberArn() => this.PhoneNumberArn != null;

        /// <summary>
        /// Gets and sets the property PhoneNumberId. 
        /// <para>
        /// The PhoneNumberId of the phone number that was released.
        /// </para>
        /// </summary>
        public string PhoneNumberId { get; set; }

        /// <summary>
        /// Checks to see if the PhoneNumberId property is set.
        /// </summary>
        internal bool IsSetPhoneNumberId() => this.PhoneNumberId != null;

        /// <summary>
        /// Gets and sets the property RegistrationId. 
        /// <para>
        /// The unique identifier for the registration.
        /// </para>
        /// </summary>
        public string RegistrationId { get; set; }

        /// <summary>
        /// Checks to see if the RegistrationId property is set.
        /// </summary>
        internal bool IsSetRegistrationId() => this.RegistrationId != null;

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
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the request.
        /// </para>
        /// </summary>
        public NumberStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TwoWayChannelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the TwoWayChannel.
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
