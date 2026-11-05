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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateUserConfig operation. Updates the configuration
    /// settings for the specified user, including per-channel auto-accept and after contact
    /// work (ACW) timeout settings. <note> <para> This operation replaces the UpdateUserPhoneConfig
    /// API. While UpdateUserPhoneConfig applies the same ACW timeout to all channels, UpdateUserConfig
    /// allows you to set different auto-accept and ACW timeout values for each channel type.
    /// </para> </note>
    /// </summary>
    public partial class UpdateUserConfigRequest : AmazonConnectRequest
    {
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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AfterContactWorkConfigPerChannel> AfterContactWorkConfigs { get; set; } = AWSConfigs.InitializeCollections ? new List<AfterContactWorkConfigPerChannel>() : null;

        /// <summary>
        /// Checks to see if the AfterContactWorkConfigs property is set.
        /// </summary>
        internal bool IsSetAfterContactWorkConfigs() => this.AfterContactWorkConfigs != null && (this.AfterContactWorkConfigs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AutoAcceptConfigs. 
        /// <para>
        /// The list of auto-accept configuration settings for each channel. When auto-accept
        /// is enabled for a channel, available agents are automatically connected to contacts
        /// from that channel without needing to manually accept. Auto-accept connects agents
        /// to contacts in less than one second.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AutoAcceptConfig> AutoAcceptConfigs { get; set; } = AWSConfigs.InitializeCollections ? new List<AutoAcceptConfig>() : null;

        /// <summary>
        /// Checks to see if the AutoAcceptConfigs property is set.
        /// </summary>
        internal bool IsSetAutoAcceptConfigs() => this.AutoAcceptConfigs != null && (this.AutoAcceptConfigs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Connect Customer instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property PersistentConnectionConfigs. 
        /// <para>
        /// The list of persistent connection configuration settings for each channel.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PersistentConnectionConfig> PersistentConnectionConfigs { get; set; } = AWSConfigs.InitializeCollections ? new List<PersistentConnectionConfig>() : null;

        /// <summary>
        /// Checks to see if the PersistentConnectionConfigs property is set.
        /// </summary>
        internal bool IsSetPersistentConnectionConfigs() => this.PersistentConnectionConfigs != null && (this.PersistentConnectionConfigs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PhoneNumberConfigs. 
        /// <para>
        /// The list of phone number configuration settings for each channel.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PhoneNumberConfig> PhoneNumberConfigs { get; set; } = AWSConfigs.InitializeCollections ? new List<PhoneNumberConfig>() : null;

        /// <summary>
        /// Checks to see if the PhoneNumberConfigs property is set.
        /// </summary>
        internal bool IsSetPhoneNumberConfigs() => this.PhoneNumberConfigs != null && (this.PhoneNumberConfigs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The identifier of the user account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string UserId { get; set; }

        /// <summary>
        /// Checks to see if the UserId property is set.
        /// </summary>
        internal bool IsSetUserId() => this.UserId != null;

        /// <summary>
        /// Gets and sets the property VoiceEnhancementConfigs. 
        /// <para>
        /// The list of voice enhancement configuration settings for each channel.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<VoiceEnhancementConfig> VoiceEnhancementConfigs { get; set; } = AWSConfigs.InitializeCollections ? new List<VoiceEnhancementConfig>() : null;

        /// <summary>
        /// Checks to see if the VoiceEnhancementConfigs property is set.
        /// </summary>
        internal bool IsSetVoiceEnhancementConfigs() => this.VoiceEnhancementConfigs != null && (this.VoiceEnhancementConfigs.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
