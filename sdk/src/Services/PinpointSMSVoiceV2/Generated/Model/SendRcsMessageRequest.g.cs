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
    /// Container for the parameters to the SendRcsMessage operation. Creates a new RCS message
    /// and sends it to a recipient's phone number. RCS messages support rich content including
    /// text, files, rich cards, and carousels with interactive suggested actions.
    /// </summary>
    public partial class SendRcsMessageRequest : AmazonPinpointSMSVoiceV2Request
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
        /// Gets and sets the property DestinationPhoneNumber. 
        /// <para>
        /// The destination phone number in E.164 format.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 20)]
        public string DestinationPhoneNumber { get; set; }

        /// <summary>
        /// Checks to see if the DestinationPhoneNumber property is set.
        /// </summary>
        internal bool IsSetDestinationPhoneNumber() => this.DestinationPhoneNumber != null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// When set to true, the message is checked and validated, but isn't sent to the end
        /// recipient.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property FallbackConfiguration. 
        /// <para>
        /// Configuration for SMS or MMS fallback when RCS delivery fails. If provided, the service
        /// sends a fallback message via the specified channel when the RCS message fails or the
        /// TimeToLive expires.
        /// </para>
        /// </summary>
        public RcsFallbackConfiguration FallbackConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the FallbackConfiguration property is set.
        /// </summary>
        internal bool IsSetFallbackConfiguration() => this.FallbackConfiguration != null;

        /// <summary>
        /// Gets and sets the property MaxPrice. 
        /// <para>
        /// The maximum amount that you want to spend, in US dollars, per each RCS message.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 8)]
        public string MaxPrice { get; set; }

        /// <summary>
        /// Checks to see if the MaxPrice property is set.
        /// </summary>
        internal bool IsSetMaxPrice() => this.MaxPrice != null;

        /// <summary>
        /// Gets and sets the property MessageFeedbackEnabled. 
        /// <para>
        /// Set to true to enable message feedback for the message. When a user receives the message
        /// you need to update the message status using <a>PutMessageFeedback</a>.
        /// </para>
        /// </summary>
        public bool? MessageFeedbackEnabled { get; set; }

        /// <summary>
        /// Checks to see if the MessageFeedbackEnabled property is set.
        /// </summary>
        internal bool IsSetMessageFeedbackEnabled() => this.MessageFeedbackEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property MessageTrafficType. 
        /// <para>
        /// The traffic type of the RCS message. Valid values are AUTHENTICATION, TRANSACTION,
        /// PROMOTION, SERVICE_REQUEST, and ACKNOWLEDGEMENT. This field is reserved for future
        /// use.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public string MessageTrafficType { get; set; }

        /// <summary>
        /// Checks to see if the MessageTrafficType property is set.
        /// </summary>
        internal bool IsSetMessageTrafficType() => this.MessageTrafficType != null;

        /// <summary>
        /// Gets and sets the property OriginationIdentity. 
        /// <para>
        /// The origination identity of the message. This can be either the RcsAgentId, RcsAgentArn,
        /// PoolId, or PoolArn.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string OriginationIdentity { get; set; }

        /// <summary>
        /// Checks to see if the OriginationIdentity property is set.
        /// </summary>
        internal bool IsSetOriginationIdentity() => this.OriginationIdentity != null;

        /// <summary>
        /// Gets and sets the property ProtectConfigurationId. 
        /// <para>
        /// The unique identifier of the protect configuration to use.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ProtectConfigurationId { get; set; }

        /// <summary>
        /// Checks to see if the ProtectConfigurationId property is set.
        /// </summary>
        internal bool IsSetProtectConfigurationId() => this.ProtectConfigurationId != null;

        /// <summary>
        /// Gets and sets the property RcsMessageContent. 
        /// <para>
        /// The content of the RCS message. Contains the message content (text, file, rich card,
        /// or carousel) and optional message-level suggested actions.
        /// </para>
        /// </summary>
        public RcsMessageContent RcsMessageContent { get; set; }

        /// <summary>
        /// Checks to see if the RcsMessageContent property is set.
        /// </summary>
        internal bool IsSetRcsMessageContent() => this.RcsMessageContent != null;

        /// <summary>
        /// Gets and sets the property TimeToLive. 
        /// <para>
        /// The duration in seconds that the RCS message is valid for delivery. If the message
        /// cannot be delivered within this duration, it is considered expired. Valid values are
        /// 1 to 172800 (48 hours). If a FallbackConfiguration is provided, the fallback is triggered
        /// when the duration expires without delivery confirmation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 172800)]
        public int? TimeToLive { get; set; }

        /// <summary>
        /// Checks to see if the TimeToLive property is set.
        /// </summary>
        internal bool IsSetTimeToLive() => this.TimeToLive.HasValue;
    }
}
