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
    /// Container for the parameters to the SendVoiceMessage operation.
    /// Allows you to send a request that sends a voice message. This operation uses <a href="http://aws.amazon.com/polly/">Amazon
    /// Polly</a> to convert a text script into a voice message.
    /// </summary>
    public partial class SendVoiceMessageRequest : AmazonPinpointSMSVoiceV2Request
    {
        private string _configurationSetName;
        private Dictionary<string, string> _context = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _destinationPhoneNumber;
        private bool? _dryRun;
        private string _maxPricePerMinute;
        private string _messageBody;
        private VoiceMessageBodyTextType _messageBodyTextType;
        private bool? _messageFeedbackEnabled;
        private string _originationIdentity;
        private string _protectConfigurationId;
        private int? _timeToLive;
        private VoiceId _voiceId;

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
        /// Gets and sets the property DestinationPhoneNumber. 
        /// <para>
        /// The destination phone number in E.164 format.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public string DestinationPhoneNumber
        {
            get { return this._destinationPhoneNumber; }
            set { this._destinationPhoneNumber = value; }
        }

        // Check to see if DestinationPhoneNumber property is set
        internal bool IsSetDestinationPhoneNumber()
        {
            return this._destinationPhoneNumber != null;
        }

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// When set to true, the message is checked and validated, but isn't sent to the end
        /// recipient.
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
        /// Gets and sets the property MaxPricePerMinute. 
        /// <para>
        /// The maximum amount to spend per voice message, in US dollars.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=8)]
        public string MaxPricePerMinute
        {
            get { return this._maxPricePerMinute; }
            set { this._maxPricePerMinute = value; }
        }

        // Check to see if MaxPricePerMinute property is set
        internal bool IsSetMaxPricePerMinute()
        {
            return this._maxPricePerMinute != null;
        }

        /// <summary>
        /// Gets and sets the property MessageBody. 
        /// <para>
        /// The text to convert to a voice message.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=6000)]
        public string MessageBody
        {
            get { return this._messageBody; }
            set { this._messageBody = value; }
        }

        // Check to see if MessageBody property is set
        internal bool IsSetMessageBody()
        {
            return this._messageBody != null;
        }

        /// <summary>
        /// Gets and sets the property MessageBodyTextType. 
        /// <para>
        /// Specifies if the MessageBody field contains text or <a href="https://docs.aws.amazon.com/polly/latest/dg/what-is.html">speech
        /// synthesis markup language (SSML)</a>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// TEXT: This is the default value. When used the maximum character limit is 3000.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSML: When used the maximum character limit is 6000 including SSML tagging.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public VoiceMessageBodyTextType MessageBodyTextType
        {
            get { return this._messageBodyTextType; }
            set { this._messageBodyTextType = value; }
        }

        // Check to see if MessageBodyTextType property is set
        internal bool IsSetMessageBodyTextType()
        {
            return this._messageBodyTextType != null;
        }

        /// <summary>
        /// Gets and sets the property MessageFeedbackEnabled. 
        /// <para>
        /// Set to true to enable message feedback for the message. When a user receives the message
        /// you need to update the message status using <a>PutMessageFeedback</a>.
        /// </para>
        /// </summary>
        public bool? MessageFeedbackEnabled
        {
            get { return this._messageFeedbackEnabled; }
            set { this._messageFeedbackEnabled = value; }
        }

        // Check to see if MessageFeedbackEnabled property is set
        internal bool IsSetMessageFeedbackEnabled()
        {
            return this._messageFeedbackEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OriginationIdentity. 
        /// <para>
        /// The origination identity to use for the voice call. This can be the PhoneNumber, PhoneNumberId,
        /// PhoneNumberArn, PoolId, or PoolArn.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you are using a shared AWS End User Messaging SMS and Voice resource then you must
        /// use the full Amazon Resource Name(ARN).
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
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
        /// Gets and sets the property ProtectConfigurationId. 
        /// <para>
        /// The unique identifier for the protect configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ProtectConfigurationId
        {
            get { return this._protectConfigurationId; }
            set { this._protectConfigurationId = value; }
        }

        // Check to see if ProtectConfigurationId property is set
        internal bool IsSetProtectConfigurationId()
        {
            return this._protectConfigurationId != null;
        }

        /// <summary>
        /// Gets and sets the property TimeToLive. 
        /// <para>
        /// How long the voice message is valid for. By default this is 72 hours.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=259200)]
        public int? TimeToLive
        {
            get { return this._timeToLive; }
            set { this._timeToLive = value; }
        }

        // Check to see if TimeToLive property is set
        internal bool IsSetTimeToLive()
        {
            return this._timeToLive.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VoiceId. 
        /// <para>
        /// The voice for the <a href="https://docs.aws.amazon.com/polly/latest/dg/what-is.html">Amazon
        /// Polly</a> service to use. By default this is set to "MATTHEW".
        /// </para>
        /// </summary>
        public VoiceId VoiceId
        {
            get { return this._voiceId; }
            set { this._voiceId = value; }
        }

        // Check to see if VoiceId property is set
        internal bool IsSetVoiceId()
        {
            return this._voiceId != null;
        }

    }
}