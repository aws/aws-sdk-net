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
    /// Container for the parameters to the CreateNotifyCodeConfiguration operation.
    /// Creates a notify code configuration. A notify code configuration is a reusable policy
    /// that defines how one-time passcodes are generated and rendered, including the code
    /// type, length, validity period, maximum number of attempts, and channel templates.
    /// </summary>
    public partial class CreateNotifyCodeConfigurationRequest : AmazonEndUserMessagingRequest
    {
        private ChannelParameters _channelParameters;
        private string _clientToken;
        private CodeConfigurationParameters _codeConfigurationParameters;
        private bool? _deletionProtectionEnabled;
        private string _notifyCodeConfigurationName;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property ChannelParameters. 
        /// <para>
        /// The channel-specific parameters used to render and deliver the one-time passcode.
        /// Provide parameters for any subset of channels. Each member configures one delivery
        /// route, and the route that is selected at send time uses the matching channel.
        /// </para>
        /// </summary>
        public ChannelParameters ChannelParameters
        {
            get { return this._channelParameters; }
            set { this._channelParameters = value; }
        }

        // Check to see if ChannelParameters property is set
        internal bool IsSetChannelParameters()
        {
            return this._channelParameters != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. If you do not specify a client token, the AWS SDK automatically generates
        /// one.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=128)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property CodeConfigurationParameters. 
        /// <para>
        /// The passcode policy parameters, including the code type, length, validity period,
        /// and maximum number of attempts. Each member is optional. When you omit a member, no
        /// value is applied at create time and the default is applied when a passcode is sent.
        /// </para>
        /// </summary>
        public CodeConfigurationParameters CodeConfigurationParameters
        {
            get { return this._codeConfigurationParameters; }
            set { this._codeConfigurationParameters = value; }
        }

        // Check to see if CodeConfigurationParameters property is set
        internal bool IsSetCodeConfigurationParameters()
        {
            return this._codeConfigurationParameters != null;
        }

        /// <summary>
        /// Gets and sets the property DeletionProtectionEnabled. 
        /// <para>
        /// Specifies whether deletion protection is enabled. When enabled, the resource cannot
        /// be deleted until deletion protection is turned off.
        /// </para>
        /// </summary>
        public bool? DeletionProtectionEnabled
        {
            get { return this._deletionProtectionEnabled; }
            set { this._deletionProtectionEnabled = value; }
        }

        // Check to see if DeletionProtectionEnabled property is set
        internal bool IsSetDeletionProtectionEnabled()
        {
            return this._deletionProtectionEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NotifyCodeConfigurationName. 
        /// <para>
        /// The name of the notify code configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string NotifyCodeConfigurationName
        {
            get { return this._notifyCodeConfigurationName; }
            set { this._notifyCodeConfigurationName = value; }
        }

        // Check to see if NotifyCodeConfigurationName property is set
        internal bool IsSetNotifyCodeConfigurationName()
        {
            return this._notifyCodeConfigurationName != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of key and value pair tags that are associated with the resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}