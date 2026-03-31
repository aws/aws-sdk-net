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
    /// Container for the parameters to the SendNotifyVoiceMessage operation.
    /// Sends a templated voice message through a notify configuration to a recipient's phone
    /// number.
    /// </summary>
    public partial class SendNotifyVoiceMessageRequest : AmazonPinpointSMSVoiceV2Request
    {
        private string _configurationSetName;
        private Dictionary<string, string> _context = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _destinationPhoneNumber;
        private bool? _dryRun;
        private bool? _messageFeedbackEnabled;
        private string _notifyConfigurationId;
        private string _templateId;
        private Dictionary<string, string> _templateVariables = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
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
        /// Gets and sets the property NotifyConfigurationId. 
        /// <para>
        /// The unique identifier of the notify configuration to use for sending the message.
        /// This can be either the NotifyConfigurationId or NotifyConfigurationArn.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string NotifyConfigurationId
        {
            get { return this._notifyConfigurationId; }
            set { this._notifyConfigurationId = value; }
        }

        // Check to see if NotifyConfigurationId property is set
        internal bool IsSetNotifyConfigurationId()
        {
            return this._notifyConfigurationId != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateId. 
        /// <para>
        /// The unique identifier of the template to use for the message.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string TemplateId
        {
            get { return this._templateId; }
            set { this._templateId = value; }
        }

        // Check to see if TemplateId property is set
        internal bool IsSetTemplateId()
        {
            return this._templateId != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateVariables. 
        /// <para>
        /// A map of template variable names and their values. All variable values are passed
        /// as strings regardless of the declared variable type. For example, pass <c>INTEGER</c>
        /// values as <c>"42"</c> and <c>BOOLEAN</c> values as <c>"true"</c> or <c>"false"</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=20)]
        public Dictionary<string, string> TemplateVariables
        {
            get { return this._templateVariables; }
            set { this._templateVariables = value; }
        }

        // Check to see if TemplateVariables property is set
        internal bool IsSetTemplateVariables()
        {
            return this._templateVariables != null && (this._templateVariables.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TimeToLive. 
        /// <para>
        /// How long the voice message is valid for, in seconds. By default this is 72 hours.
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
        /// The voice ID to use for the voice message.
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