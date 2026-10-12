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
    /// Container for the parameters to the SendDestinationNumberVerificationCode operation.
    /// Before you can send test messages to a verified destination phone number you need
    /// to opt-in the verified destination phone number. Creates a new text message with a
    /// verification code and send it to a verified destination phone number. Once you have
    /// the verification code use <a>VerifyDestinationNumber</a> to opt-in the verified destination
    /// phone number to receive messages.
    /// </summary>
    public partial class SendDestinationNumberVerificationCodeRequest : AmazonPinpointSMSVoiceV2Request
    {
        /// <summary>
        /// Gets and sets the property ConfigurationSetName. 
        /// <para>
        /// The name of the configuration set to use. This can be either the ConfigurationSetName
        /// or ConfigurationSetArn.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ConfigurationSetName { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationSetName property is set.
        /// </summary>
        internal bool IsSetConfigurationSetName() => this.ConfigurationSetName != null;

        /// <summary>
        /// Gets and sets the property Context. 
        /// <para>
        /// You can specify custom data in this field. If you do, that data is logged to the event
        /// destination.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 5)]
        public Dictionary<string, string> Context { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Context property is set.
        /// </summary>
        internal bool IsSetContext() => this.Context != null && (this.Context.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DestinationCountryParameters. 
        /// <para>
        /// This field is used for any country-specific registration requirements. Currently,
        /// this setting is only used when you send messages to recipients in India using a sender
        /// ID. For more information see <a href="https://docs.aws.amazon.com/pinpoint/latest/userguide/channels-sms-senderid-india.html">Special
        /// requirements for sending SMS messages to recipients in India</a>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 10)]
        public Dictionary<string, string> DestinationCountryParameters { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the DestinationCountryParameters property is set.
        /// </summary>
        internal bool IsSetDestinationCountryParameters() => this.DestinationCountryParameters != null && (this.DestinationCountryParameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// Choose the language to use for the message.
        /// </para>
        /// </summary>
        public LanguageCode LanguageCode { get; set; }

        /// <summary>
        /// Checks to see if the LanguageCode property is set.
        /// </summary>
        internal bool IsSetLanguageCode() => this.LanguageCode != null;

        /// <summary>
        /// Gets and sets the property OriginationIdentity. 
        /// <para>
        /// The origination identity of the message. This can be either the PhoneNumber, PhoneNumberId,
        /// PhoneNumberArn, SenderId, SenderIdArn, PoolId, or PoolArn.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you are using a shared End User Messaging SMS resource then you must use the full
        /// Amazon Resource Name(ARN).
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string OriginationIdentity { get; set; }

        /// <summary>
        /// Checks to see if the OriginationIdentity property is set.
        /// </summary>
        internal bool IsSetOriginationIdentity() => this.OriginationIdentity != null;

        /// <summary>
        /// Gets and sets the property VerificationChannel. 
        /// <para>
        /// Choose to send the verification code as an SMS or voice message.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public VerificationChannel VerificationChannel { get; set; }

        /// <summary>
        /// Checks to see if the VerificationChannel property is set.
        /// </summary>
        internal bool IsSetVerificationChannel() => this.VerificationChannel != null;

        /// <summary>
        /// Gets and sets the property VerifiedDestinationNumberId. 
        /// <para>
        /// The unique identifier for the verified destination phone number.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string VerifiedDestinationNumberId { get; set; }

        /// <summary>
        /// Checks to see if the VerifiedDestinationNumberId property is set.
        /// </summary>
        internal bool IsSetVerifiedDestinationNumberId() => this.VerifiedDestinationNumberId != null;
    }
}
