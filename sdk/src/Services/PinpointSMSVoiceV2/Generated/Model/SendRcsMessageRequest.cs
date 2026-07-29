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
    /// Container for the parameters to the SendRcsMessage operation.
    /// Creates a new RCS message and sends it to a recipient's phone number. RCS messages
    /// support rich content including text, files, rich cards, and carousels with interactive
    /// suggested actions.
    /// </summary>
    public partial class SendRcsMessageRequest : AmazonPinpointSMSVoiceV2Request
    {
        private string _configurationSetName;
        private Dictionary<string, string> _context = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _destinationPhoneNumber;
        private bool? _dryRun;
        private RcsFallbackConfiguration _fallbackConfiguration;
        private string _maxPrice;
        private bool? _messageFeedbackEnabled;
        private string _messageTrafficType;
        private string _originationIdentity;
        private string _protectConfigurationId;
        private RcsMessageContent _rcsMessageContent;
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
        /// Gets and sets the property FallbackConfiguration. 
        /// <para>
        /// Configuration for SMS or MMS fallback when RCS delivery fails. If provided, the service
        /// sends a fallback message via the specified channel when the RCS message fails or the
        /// TimeToLive expires.
        /// </para>
        /// </summary>
        public RcsFallbackConfiguration FallbackConfiguration
        {
            get { return this._fallbackConfiguration; }
            set { this._fallbackConfiguration = value; }
        }

        // Check to see if FallbackConfiguration property is set
        internal bool IsSetFallbackConfiguration()
        {
            return this._fallbackConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property MaxPrice. 
        /// <para>
        /// The maximum amount that you want to spend, in US dollars, per each RCS message.
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
        /// Gets and sets the property MessageTrafficType. 
        /// <para>
        /// The traffic type of the RCS message. Valid values are AUTHENTICATION, TRANSACTION,
        /// PROMOTION, SERVICE_REQUEST, and ACKNOWLEDGEMENT. This field is reserved for future
        /// use.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public string MessageTrafficType
        {
            get { return this._messageTrafficType; }
            set { this._messageTrafficType = value; }
        }

        // Check to see if MessageTrafficType property is set
        internal bool IsSetMessageTrafficType()
        {
            return this._messageTrafficType != null;
        }

        /// <summary>
        /// Gets and sets the property OriginationIdentity. 
        /// <para>
        /// The origination identity of the message. This can be either the RcsAgentId, RcsAgentArn,
        /// PoolId, or PoolArn.
        /// </para>
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
        /// The unique identifier of the protect configuration to use.
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
        /// Gets and sets the property RcsMessageContent. 
        /// <para>
        /// The content of the RCS message. Contains the message content (text, file, rich card,
        /// or carousel) and optional message-level suggested actions.
        /// </para>
        /// </summary>
        public RcsMessageContent RcsMessageContent
        {
            get { return this._rcsMessageContent; }
            set { this._rcsMessageContent = value; }
        }

        // Check to see if RcsMessageContent property is set
        internal bool IsSetRcsMessageContent()
        {
            return this._rcsMessageContent != null;
        }

        /// <summary>
        /// Gets and sets the property TimeToLive. 
        /// <para>
        /// The duration in seconds that the RCS message is valid for delivery. If the message
        /// cannot be delivered within this duration, it is considered expired. Valid values are
        /// 1 to 172800 (48 hours). If a FallbackConfiguration is provided, the fallback is triggered
        /// when the duration expires without delivery confirmation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=172800)]
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