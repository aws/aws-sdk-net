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
    /// Container for the parameters to the SendVoiceMessage operation. Allows you to send
    /// a request that sends a voice message. This operation uses <a href="http://aws.amazon.com/polly/">Amazon
    /// Polly</a> to convert a text script into a voice message.
    /// </summary>
    public partial class SendVoiceMessageRequest : AmazonPinpointSMSVoiceV2Request
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
        /// Gets and sets the property MaxPricePerMinute. 
        /// <para>
        /// The maximum amount to spend per voice message, in US dollars.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 8)]
        public string MaxPricePerMinute { get; set; }

        /// <summary>
        /// Checks to see if the MaxPricePerMinute property is set.
        /// </summary>
        internal bool IsSetMaxPricePerMinute() => this.MaxPricePerMinute != null;

        /// <summary>
        /// Gets and sets the property MessageBody. 
        /// <para>
        /// The text to convert to a voice message.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 6000)]
        public string MessageBody { get; set; }

        /// <summary>
        /// Checks to see if the MessageBody property is set.
        /// </summary>
        internal bool IsSetMessageBody() => this.MessageBody != null;

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
        public VoiceMessageBodyTextType MessageBodyTextType { get; set; }

        /// <summary>
        /// Checks to see if the MessageBodyTextType property is set.
        /// </summary>
        internal bool IsSetMessageBodyTextType() => this.MessageBodyTextType != null;

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
        /// Gets and sets the property OriginationIdentity. 
        /// <para>
        /// The origination identity to use for the voice call. This can be the PhoneNumber, PhoneNumberId,
        /// PhoneNumberArn, PoolId, or PoolArn.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you are using a shared End User Messaging SMS resource then you must use the full
        /// Amazon Resource Name(ARN).
        /// </para>
        ///  </important>
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
        /// The unique identifier for the protect configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ProtectConfigurationId { get; set; }

        /// <summary>
        /// Checks to see if the ProtectConfigurationId property is set.
        /// </summary>
        internal bool IsSetProtectConfigurationId() => this.ProtectConfigurationId != null;

        /// <summary>
        /// Gets and sets the property TimeToLive. 
        /// <para>
        /// How long the voice message is valid for. By default this is 72 hours.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 5, Max = 259200)]
        public int? TimeToLive { get; set; }

        /// <summary>
        /// Checks to see if the TimeToLive property is set.
        /// </summary>
        internal bool IsSetTimeToLive() => this.TimeToLive.HasValue;

        /// <summary>
        /// Gets and sets the property VoiceId. 
        /// <para>
        /// The voice for the <a href="https://docs.aws.amazon.com/polly/latest/dg/what-is.html">Amazon
        /// Polly</a> service to use. By default this is set to "MATTHEW".
        /// </para>
        /// </summary>
        public VoiceId VoiceId { get; set; }

        /// <summary>
        /// Checks to see if the VoiceId property is set.
        /// </summary>
        internal bool IsSetVoiceId() => this.VoiceId != null;
    }
}
