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
    /// Container for the parameters to the SendDestinationNumberVerificationCode operation.
    /// Before you can send test messages to a verified destination phone number you need
    /// to opt-in the verified destination phone number. Creates a new text message with a
    /// verification code and send it to a verified destination phone number. Once you have
    /// the verification code use <a>VerifyDestinationNumber</a> to opt-in the verified destination
    /// phone number to receive messages.
    /// </summary>
    public partial class SendDestinationNumberVerificationCodeRequest : AmazonPinpointSMSVoiceV2Request
    {
        private string _configurationSetName;
        private Dictionary<string, string> _context = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private Dictionary<string, string> _destinationCountryParameters = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private LanguageCode _languageCode;
        private string _originationIdentity;
        private VerificationChannel _verificationChannel;
        private string _verifiedDestinationNumberId;

        /// <summary>
        /// Gets and sets the property ConfigurationSetName. 
        /// <para>
        /// The name of the configuration set to use. This can be either the ConfigurationSetName
        /// or ConfigurationSetArn.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ConfigurationSetName
        {
            get { return this._configurationSetName; }
            set { this._configurationSetName = value; }
        }

        // Check to see if ConfigurationSetName property is set
        internal bool IsSetConfigurationSetName()
        {
            return this._configurationSetName != null;
        }

        /// <summary>
        /// Gets and sets the property Context. 
        /// <para>
        /// You can specify custom data in this field. If you do, that data is logged to the event
        /// destination.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public Dictionary<string, string> Context
        {
            get { return this._context; }
            set { this._context = value; }
        }

        // Check to see if Context property is set
        internal bool IsSetContext()
        {
            return this._context != null && (this._context.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DestinationCountryParameters. 
        /// <para>
        /// This field is used for any country-specific registration requirements. Currently,
        /// this setting is only used when you send messages to recipients in India using a sender
        /// ID. For more information see <a href="https://docs.aws.amazon.com/pinpoint/latest/userguide/channels-sms-senderid-india.html">Special
        /// requirements for sending SMS messages to recipients in India</a>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public Dictionary<string, string> DestinationCountryParameters
        {
            get { return this._destinationCountryParameters; }
            set { this._destinationCountryParameters = value; }
        }

        // Check to see if DestinationCountryParameters property is set
        internal bool IsSetDestinationCountryParameters()
        {
            return this._destinationCountryParameters != null && (this._destinationCountryParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// Choose the language to use for the message.
        /// </para>
        /// </summary>
        public LanguageCode LanguageCode
        {
            get { return this._languageCode; }
            set { this._languageCode = value; }
        }

        // Check to see if LanguageCode property is set
        internal bool IsSetLanguageCode()
        {
            return this._languageCode != null;
        }

        /// <summary>
        /// Gets and sets the property OriginationIdentity. 
        /// <para>
        /// The origination identity of the message. This can be either the PhoneNumber, PhoneNumberId,
        /// PhoneNumberArn, SenderId, SenderIdArn, PoolId, or PoolArn.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you are using a shared AWS End User Messaging SMS and Voice resource then you must
        /// use the full Amazon Resource Name(ARN).
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string OriginationIdentity
        {
            get { return this._originationIdentity; }
            set { this._originationIdentity = value; }
        }

        // Check to see if OriginationIdentity property is set
        internal bool IsSetOriginationIdentity()
        {
            return this._originationIdentity != null;
        }

        /// <summary>
        /// Gets and sets the property VerificationChannel. 
        /// <para>
        /// Choose to send the verification code as an SMS or voice message.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public VerificationChannel VerificationChannel
        {
            get { return this._verificationChannel; }
            set { this._verificationChannel = value; }
        }

        // Check to see if VerificationChannel property is set
        internal bool IsSetVerificationChannel()
        {
            return this._verificationChannel != null;
        }

        /// <summary>
        /// Gets and sets the property VerifiedDestinationNumberId. 
        /// <para>
        /// The unique identifier for the verified destination phone number.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string VerifiedDestinationNumberId
        {
            get { return this._verifiedDestinationNumberId; }
            set { this._verifiedDestinationNumberId = value; }
        }

        // Check to see if VerifiedDestinationNumberId property is set
        internal bool IsSetVerifiedDestinationNumberId()
        {
            return this._verifiedDestinationNumberId != null;
        }

    }
}