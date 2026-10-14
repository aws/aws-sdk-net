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
 * Do not modify this file. This file is generated from the endusermessaging-2026-09-21.normal.json service model.
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
    /// Container for the parameters to the SendNotifyCodeVerification operation.
    /// Generates a one-time passcode and delivers it to a recipient over the requested channel.
    /// The passcode policy is captured from the referenced notify code configuration at the
    /// time of the request, so later updates to the configuration do not affect verifications
    /// that are already in progress.
    /// </summary>
    public partial class SendNotifyCodeVerificationRequest : AmazonEndUserMessagingRequest
    {
        private NotifyChannel _channel;
        private string _configurationSetName;
        private Dictionary<string, string> _context = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _destinationIdentity;
        private string _notifyCodeConfiguration;
        private string _originationIdentity;
        private ChannelParameters _overrideChannelParameters;
        private CodeConfigurationParameters _overrideCodeConfigurationParameters;
        private string _referenceId;

        /// <summary>
        /// Gets and sets the property Channel. 
        /// <para>
        /// The channel used to deliver the one-time passcode to the recipient.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public NotifyChannel Channel
        {
            get { return this._channel; }
            set { this._channel = value; }
        }

        // Check to see if Channel property is set
        internal bool IsSetChannel()
        {
            return this._channel != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigurationSetName. 
        /// <para>
        /// The name of the configuration set used to control how delivery events for the message
        /// are handled.
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
        /// A map of custom key and value pairs that are propagated to the delivery events for
        /// this verification.
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
        /// Gets and sets the property DestinationIdentity. 
        /// <para>
        /// The recipient identifier. For the TEXT and VOICE channels, specify an E.164 phone
        /// number. For the WhatsApp channel, specify a WhatsApp address.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=20)]
        public string DestinationIdentity
        {
            get { return this._destinationIdentity; }
            set { this._destinationIdentity = value; }
        }

        // Check to see if DestinationIdentity property is set
        internal bool IsSetDestinationIdentity()
        {
            return this._destinationIdentity != null;
        }

        /// <summary>
        /// Gets and sets the property NotifyCodeConfiguration. 
        /// <para>
        /// The identifier or Amazon Resource Name (ARN) of the notify code configuration that
        /// supplies the passcode policy and template defaults. When you do not specify a configuration,
        /// you must supply the template in the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string NotifyCodeConfiguration
        {
            get { return this._notifyCodeConfiguration; }
            set { this._notifyCodeConfiguration = value; }
        }

        // Check to see if NotifyCodeConfiguration property is set
        internal bool IsSetNotifyCodeConfiguration()
        {
            return this._notifyCodeConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property OriginationIdentity. 
        /// <para>
        /// The identity used to send the message, such as a phone number, sender ID, or pool
        /// that is owned by your account.
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
        /// Gets and sets the property OverrideChannelParameters. 
        /// <para>
        /// The channel-specific parameters used to render and deliver the one-time passcode for
        /// this request. The route that is derived from the channel and the origination identity
        /// selects the matching channel. When you do not specify channel parameters, the service
        /// uses the parameters from the referenced notify code configuration.
        /// </para>
        /// </summary>
        public ChannelParameters OverrideChannelParameters
        {
            get { return this._overrideChannelParameters; }
            set { this._overrideChannelParameters = value; }
        }

        // Check to see if OverrideChannelParameters property is set
        internal bool IsSetOverrideChannelParameters()
        {
            return this._overrideChannelParameters != null;
        }

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
        public CodeConfigurationParameters OverrideCodeConfigurationParameters
        {
            get { return this._overrideCodeConfigurationParameters; }
            set { this._overrideCodeConfigurationParameters = value; }
        }

        // Check to see if OverrideCodeConfigurationParameters property is set
        internal bool IsSetOverrideCodeConfigurationParameters()
        {
            return this._overrideCodeConfigurationParameters != null;
        }

        /// <summary>
        /// Gets and sets the property ReferenceId. 
        /// <para>
        /// A caller-supplied reference identifier that binds a send request to a later validate
        /// request. Specify the same value in both requests.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ReferenceId
        {
            get { return this._referenceId; }
            set { this._referenceId = value; }
        }

        // Check to see if ReferenceId property is set
        internal bool IsSetReferenceId()
        {
            return this._referenceId != null;
        }

    }
}