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
    /// Container for the parameters to the SendTextMessage operation.
    /// Creates a new text message and sends it to a recipient's phone number. SendTextMessage
    /// only sends an SMS message to one recipient each time it is invoked.
    /// 
    ///  
    /// <para>
    /// SMS throughput limits are measured in Message Parts per Second (MPS). Your MPS limit
    /// depends on the destination country of your messages, as well as the type of phone
    /// number (origination number) that you use to send the message. For more information
    /// about MPS, see <a href="https://docs.aws.amazon.com/sms-voice/latest/userguide/sms-limitations-mps.html">Message
    /// Parts per Second (MPS) limits</a> in the <i>AWS End User Messaging SMS User Guide</i>.
    /// </para>
    /// </summary>
    public partial class SendTextMessageRequest : AmazonPinpointSMSVoiceV2Request
    {
        private string _configurationSetName;
        private Dictionary<string, string> _context = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private Dictionary<string, string> _destinationCountryParameters = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _destinationPhoneNumber;
        private bool? _dryRun;
        private string _keyword;
        private string _maxPrice;
        private string _messageBody;
        private bool? _messageFeedbackEnabled;
        private MessageType _messageType;
        private string _originationIdentity;
        private string _protectConfigurationId;
        private int? _timeToLive;

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
        ///  <ul> <li> 
        /// <para>
        ///  <c>IN_ENTITY_ID</c> The entity ID or Principal Entity (PE) ID that you received after
        /// completing the sender ID registration process.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IN_TEMPLATE_ID</c> The template ID that you received after completing the sender
        /// ID registration process.
        /// </para>
        ///  <important> 
        /// <para>
        /// Make sure that the Template ID that you specify matches your message template exactly.
        /// If your message doesn't match the template that you provided during the registration
        /// process, the mobile carriers might reject your message.
        /// </para>
        ///  </important> </li> </ul>
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
        /// recipient. You are not charged for using <c>DryRun</c>.
        /// </para>
        ///  
        /// <para>
        /// The Message Parts per Second (MPS) limit when using <c>DryRun</c> is five. If your
        /// origination identity has a lower MPS limit then the lower MPS limit is used. For more
        /// information about MPS limits, see <a href="https://docs.aws.amazon.com/sms-voice/latest/userguide/sms-limitations-mps.html">Message
        /// Parts per Second (MPS) limits</a> in the <i>AWS End User Messaging SMS User Guide</i>..
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
        /// Gets and sets the property Keyword. 
        /// <para>
        /// When you register a short code in the US, you must specify a program name. If you
        /// don’t have a US short code, omit this attribute.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=30)]
        public string Keyword
        {
            get { return this._keyword; }
            set { this._keyword = value; }
        }

        // Check to see if Keyword property is set
        internal bool IsSetKeyword()
        {
            return this._keyword != null;
        }

        /// <summary>
        /// Gets and sets the property MaxPrice. 
        /// <para>
        /// The maximum amount that you want to spend, in US dollars, per each text message. If
        /// the calculated amount to send the text message is greater than <c>MaxPrice</c>, the
        /// message is not sent and an error is returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=8)]
        public string MaxPrice
        {
            get { return this._maxPrice; }
            set { this._maxPrice = value; }
        }

        // Check to see if MaxPrice property is set
        internal bool IsSetMaxPrice()
        {
            return this._maxPrice != null;
        }

        /// <summary>
        /// Gets and sets the property MessageBody. 
        /// <para>
        /// The body of the text message.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
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
        /// Gets and sets the property MessageType. 
        /// <para>
        /// The type of message. Valid values are for messages that are critical or time-sensitive
        /// and PROMOTIONAL for messages that aren't critical or time-sensitive.
        /// </para>
        /// </summary>
        public MessageType MessageType
        {
            get { return this._messageType; }
            set { this._messageType = value; }
        }

        // Check to see if MessageType property is set
        internal bool IsSetMessageType()
        {
            return this._messageType != null;
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
        /// How long the text message is valid for, in seconds. By default this is 72 hours. If
        /// the messages isn't handed off before the TTL expires we stop attempting to hand off
        /// the message and return <c>TTL_EXPIRED</c> event.
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

    }
}