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

namespace Amazon.EndUserMessaging.Model
{
    /// <summary>
    /// Container for the parameters to the SendNotifyCodeVerification operation. Generates
    /// a one-time passcode and delivers it to a recipient over the requested channel. The
    /// passcode policy is captured from the referenced notify code configuration at the time
    /// of the request, so later updates to the configuration do not affect verifications
    /// that are already in progress.
    /// </summary>
    public partial class SendNotifyCodeVerificationRequest : AmazonEndUserMessagingRequest
    {
        /// <summary>
        /// Gets and sets the property Channel. 
        /// <para>
        /// The channel used to deliver the one-time passcode to the recipient.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public NotifyChannel Channel { get; set; }

        /// <summary>
        /// Checks to see if the Channel property is set.
        /// </summary>
        internal bool IsSetChannel() => this.Channel != null;

        /// <summary>
        /// Gets and sets the property ConfigurationSetName. 
        /// <para>
        /// The name of the configuration set used to control how delivery events for the message
        /// are handled.
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
        /// A map of custom key and value pairs that are propagated to the delivery events for
        /// this verification.
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
        /// Gets and sets the property DestinationIdentity. 
        /// <para>
        /// The recipient identifier. For the TEXT and VOICE channels, specify an E.164 phone
        /// number. For the WhatsApp channel, specify a WhatsApp address.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 20)]
        public string DestinationIdentity { get; set; }

        /// <summary>
        /// Checks to see if the DestinationIdentity property is set.
        /// </summary>
        internal bool IsSetDestinationIdentity() => this.DestinationIdentity != null;

        /// <summary>
        /// Gets and sets the property NotifyCodeConfiguration. 
        /// <para>
        /// The identifier or Amazon Resource Name (ARN) of the notify code configuration that
        /// supplies the passcode policy and template defaults. When you do not specify a configuration,
        /// you must supply the template in the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string NotifyCodeConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the NotifyCodeConfiguration property is set.
        /// </summary>
        internal bool IsSetNotifyCodeConfiguration() => this.NotifyCodeConfiguration != null;

        /// <summary>
        /// Gets and sets the property OriginationIdentity. 
        /// <para>
        /// The identity used to send the message, such as a phone number, sender ID, or pool
        /// that is owned by your account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string OriginationIdentity { get; set; }

        /// <summary>
        /// Checks to see if the OriginationIdentity property is set.
        /// </summary>
        internal bool IsSetOriginationIdentity() => this.OriginationIdentity != null;

        /// <summary>
        /// Gets and sets the property OverrideChannelParameters. 
        /// <para>
        /// The channel-specific parameters used to render and deliver the one-time passcode for
        /// this request. The route that is derived from the channel and the origination identity
        /// selects the matching channel. When you do not specify channel parameters, the service
        /// uses the parameters from the referenced notify code configuration.
        /// </para>
        /// </summary>
        public ChannelParameters OverrideChannelParameters { get; set; }

        /// <summary>
        /// Checks to see if the OverrideChannelParameters property is set.
        /// </summary>
        internal bool IsSetOverrideChannelParameters() => this.OverrideChannelParameters != null;

        /// <summary>
        /// Gets and sets the property OverrideCodeConfigurationParameters. 
        /// <para>
        /// The per-send overrides for the passcode policy parameters, including the code type,
        /// length, validity period, and maximum number of attempts. These values override the
        /// values from the referenced notify code configuration. When you do not specify a value,
        /// the value from the configuration is used, and if neither is set, the service default
        /// applies.
        /// </para>
        /// </summary>
        public CodeConfigurationParameters OverrideCodeConfigurationParameters { get; set; }

        /// <summary>
        /// Checks to see if the OverrideCodeConfigurationParameters property is set.
        /// </summary>
        internal bool IsSetOverrideCodeConfigurationParameters() => this.OverrideCodeConfigurationParameters != null;

        /// <summary>
        /// Gets and sets the property ReferenceId. 
        /// <para>
        /// A caller-supplied reference identifier that binds a send request to a later validate
        /// request. Specify the same value in both requests.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ReferenceId { get; set; }

        /// <summary>
        /// Checks to see if the ReferenceId property is set.
        /// </summary>
        internal bool IsSetReferenceId() => this.ReferenceId != null;
    }
}
