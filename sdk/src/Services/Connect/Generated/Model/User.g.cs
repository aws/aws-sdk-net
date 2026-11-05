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
    /// Contains information about a user account for an Connect Customer instance.
    /// </summary>
    public partial class User
    {
        /// <summary>
        /// Gets and sets the property AfterContactWorkConfigs. 
        /// <para>
        /// The list of after contact work (ACW) timeout configuration settings for each channel.
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
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the user account.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property AutoAcceptConfigs. 
        /// <para>
        /// The list of auto-accept configuration settings for each channel.
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
        /// Gets and sets the property DirectoryUserId. 
        /// <para>
        /// The identifier of the user account in the directory used for identity management.
        /// </para>
        /// </summary>
        public string DirectoryUserId { get; set; }

        /// <summary>
        /// Checks to see if the DirectoryUserId property is set.
        /// </summary>
        internal bool IsSetDirectoryUserId() => this.DirectoryUserId != null;

        /// <summary>
        /// Gets and sets the property HierarchyGroupId. 
        /// <para>
        /// The identifier of the hierarchy group for the user.
        /// </para>
        /// </summary>
        public string HierarchyGroupId { get; set; }

        /// <summary>
        /// Checks to see if the HierarchyGroupId property is set.
        /// </summary>
        internal bool IsSetHierarchyGroupId() => this.HierarchyGroupId != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the user account.
        /// </para>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property IdentityInfo. 
        /// <para>
        /// Information about the user identity.
        /// </para>
        /// </summary>
        public UserIdentityInfo IdentityInfo { get; set; }

        /// <summary>
        /// Checks to see if the IdentityInfo property is set.
        /// </summary>
        internal bool IsSetIdentityInfo() => this.IdentityInfo != null;

        /// <summary>
        /// Gets and sets the property LastModifiedRegion. 
        /// <para>
        /// The Amazon Web Services Region where this resource was last modified.
        /// </para>
        /// </summary>
        public string LastModifiedRegion { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedRegion property is set.
        /// </summary>
        internal bool IsSetLastModifiedRegion() => this.LastModifiedRegion != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The timestamp when this resource was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

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
        /// Gets and sets the property PhoneConfig. 
        /// <para>
        /// Information about the phone configuration for the user.
        /// </para>
        /// </summary>
        public UserPhoneConfig PhoneConfig { get; set; }

        /// <summary>
        /// Checks to see if the PhoneConfig property is set.
        /// </summary>
        internal bool IsSetPhoneConfig() => this.PhoneConfig != null;

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
        /// Gets and sets the property RoutingProfileId. 
        /// <para>
        /// The identifier of the routing profile for the user.
        /// </para>
        /// </summary>
        public string RoutingProfileId { get; set; }

        /// <summary>
        /// Checks to see if the RoutingProfileId property is set.
        /// </summary>
        internal bool IsSetRoutingProfileId() => this.RoutingProfileId != null;

        /// <summary>
        /// Gets and sets the property SecurityProfileIds. 
        /// <para>
        /// The identifiers of the security profiles for the user.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<string> SecurityProfileIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SecurityProfileIds property is set.
        /// </summary>
        internal bool IsSetSecurityProfileIds() => this.SecurityProfileIds != null && (this.SecurityProfileIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// The user name assigned to the user account.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string Username { get; set; }

        /// <summary>
        /// Checks to see if the Username property is set.
        /// </summary>
        internal bool IsSetUsername() => this.Username != null;

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
