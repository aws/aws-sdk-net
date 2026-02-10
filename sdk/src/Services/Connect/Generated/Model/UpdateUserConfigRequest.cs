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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateUserConfig operation.
    /// Updates the configuration settings for the specified user, including per-channel auto-accept
    /// and after contact work (ACW) timeout settings.
    /// 
    ///  <note> 
    /// <para>
    /// This operation replaces the UpdateUserPhoneConfig API. While UpdateUserPhoneConfig
    /// applies the same ACW timeout to all channels, UpdateUserConfig allows you to set different
    /// auto-accept and ACW timeout values for each channel type.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class UpdateUserConfigRequest : AmazonConnectRequest
    {
        private List<AfterContactWorkConfigPerChannel> _afterContactWorkConfigs = AWSConfigs.InitializeCollections ? new List<AfterContactWorkConfigPerChannel>() : null;
        private List<AutoAcceptConfig> _autoAcceptConfigs = AWSConfigs.InitializeCollections ? new List<AutoAcceptConfig>() : null;
        private string _instanceId;
        private List<PersistentConnectionConfig> _persistentConnectionConfigs = AWSConfigs.InitializeCollections ? new List<PersistentConnectionConfig>() : null;
        private List<PhoneNumberConfig> _phoneNumberConfigs = AWSConfigs.InitializeCollections ? new List<PhoneNumberConfig>() : null;
        private string _userId;
        private List<VoiceEnhancementConfig> _voiceEnhancementConfigs = AWSConfigs.InitializeCollections ? new List<VoiceEnhancementConfig>() : null;

        /// <summary>
        /// Gets and sets the property AfterContactWorkConfigs. 
        /// <para>
        /// The list of after contact work (ACW) timeout configuration settings for each channel.
        /// ACW timeout specifies how many seconds agents have for after contact work, such as
        /// entering notes about the contact. The minimum setting is 1 second, and the maximum
        /// is 2,000,000 seconds (24 days). Enter 0 for an indefinite amount of time, meaning
        /// agents must manually choose to end ACW.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AfterContactWorkConfigPerChannel> AfterContactWorkConfigs
        {
            get { return this._afterContactWorkConfigs; }
            set { this._afterContactWorkConfigs = value; }
        }

        // Check to see if AfterContactWorkConfigs property is set
        internal bool IsSetAfterContactWorkConfigs()
        {
            return this._afterContactWorkConfigs != null && (this._afterContactWorkConfigs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AutoAcceptConfigs. 
        /// <para>
        /// The list of auto-accept configuration settings for each channel. When auto-accept
        /// is enabled for a channel, available agents are automatically connected to contacts
        /// from that channel without needing to manually accept. Auto-accept connects agents
        /// to contacts in less than one second.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AutoAcceptConfig> AutoAcceptConfigs
        {
            get { return this._autoAcceptConfigs; }
            set { this._autoAcceptConfigs = value; }
        }

        // Check to see if AutoAcceptConfigs property is set
        internal bool IsSetAutoAcceptConfigs()
        {
            return this._autoAcceptConfigs != null && (this._autoAcceptConfigs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Amazon Connect instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property PersistentConnectionConfigs. 
        /// <para>
        /// The list of persistent connection configuration settings for each channel.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PersistentConnectionConfig> PersistentConnectionConfigs
        {
            get { return this._persistentConnectionConfigs; }
            set { this._persistentConnectionConfigs = value; }
        }

        // Check to see if PersistentConnectionConfigs property is set
        internal bool IsSetPersistentConnectionConfigs()
        {
            return this._persistentConnectionConfigs != null && (this._persistentConnectionConfigs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PhoneNumberConfigs. 
        /// <para>
        /// The list of phone number configuration settings for each channel.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PhoneNumberConfig> PhoneNumberConfigs
        {
            get { return this._phoneNumberConfigs; }
            set { this._phoneNumberConfigs = value; }
        }

        // Check to see if PhoneNumberConfigs property is set
        internal bool IsSetPhoneNumberConfigs()
        {
            return this._phoneNumberConfigs != null && (this._phoneNumberConfigs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The identifier of the user account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        // Check to see if UserId property is set
        internal bool IsSetUserId()
        {
            return this._userId != null;
        }

        /// <summary>
        /// Gets and sets the property VoiceEnhancementConfigs. 
        /// <para>
        /// The list of voice enhancement configuration settings for each channel.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<VoiceEnhancementConfig> VoiceEnhancementConfigs
        {
            get { return this._voiceEnhancementConfigs; }
            set { this._voiceEnhancementConfigs = value; }
        }

        // Check to see if VoiceEnhancementConfigs property is set
        internal bool IsSetVoiceEnhancementConfigs()
        {
            return this._voiceEnhancementConfigs != null && (this._voiceEnhancementConfigs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}