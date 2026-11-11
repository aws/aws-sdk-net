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
    /// Container for the parameters to the CreateUser operation. Creates a user account for
    /// the specified Connect Customer instance. <important> <para> Certain <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_UserIdentityInfo.html">UserIdentityInfo</a>
    /// parameters are required in some situations. For example, <c>Email</c>, <c>FirstName</c>
    /// and <c>LastName</c> are required if you are using Connect Customer or SAML for identity
    /// management. </para> </important> <note> <para> Fields in <c>PhoneConfig</c> cannot
    /// be set simultaneously with their corresponding channel-specific configuration parameters.
    /// Specifically: </para> <ul> <li> <para> <c>PhoneConfig.AutoAccept</c> conflicts with
    /// <c>AutoAcceptConfigs</c> </para> </li> <li> <para> <c>PhoneConfig.AfterContactWorkTimeLimit</c>
    /// conflicts with <c>AfterContactWorkConfigs</c> </para> </li> <li> <para> <c>PhoneConfig.PhoneType</c>
    /// and <c>PhoneConfig.PhoneNumber</c> conflict with <c>PhoneNumberConfigs</c> </para>
    /// </li> <li> <para> <c>PhoneConfig.PersistentConnection</c> conflicts with <c>PersistentConnectionConfigs</c>
    /// </para> </li> </ul> <para> We recommend using channel-specific parameters such as
    /// <c>AutoAcceptConfigs</c>, <c>AfterContactWorkConfigs</c>, <c>PhoneNumberConfigs</c>,
    /// <c>PersistentConnectionConfigs</c>, and <c>VoiceEnhancementConfigs</c> for per-channel
    /// configuration. </para> </note> <para> For information about how to create users using
    /// the Connect Customer admin website, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/user-management.html">Add
    /// Users</a> in the <i>Connect Customer Administrator Guide</i>. </para>
    /// </summary>
    public partial class CreateUserRequest : AmazonConnectRequest
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
        /// If Connect Customer cannot access the directory, you can specify this identifier to
        /// authenticate users. If you include the identifier, we assume that Connect Customer
        /// cannot access the directory. Otherwise, the identity information is used to authenticate
        /// users from your directory.
        /// </para>
        ///  
        /// <para>
        /// This parameter is required if you are using an existing directory for identity management
        /// in Connect Customer when Connect Customer cannot access your directory to authenticate
        /// users. If you are using SAML for identity management and include this parameter, an
        /// error is returned.
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
        /// Gets and sets the property IdentityInfo. 
        /// <para>
        /// The information about the identity of the user.
        /// </para>
        /// </summary>
        public UserIdentityInfo IdentityInfo { get; set; }

        /// <summary>
        /// Checks to see if the IdentityInfo property is set.
        /// </summary>
        internal bool IsSetIdentityInfo() => this.IdentityInfo != null;

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
        /// Gets and sets the property Password. 
        /// <para>
        /// The password for the user account. A password is required if you are using Connect
        /// Customer for identity management. Otherwise, it is an error to include a password.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string Password { get; set; }

        /// <summary>
        /// Checks to see if the Password property is set.
        /// </summary>
        internal bool IsSetPassword() => this.Password != null;

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
        /// The phone settings for the user. This parameter is optional. If not provided, the
        /// user can be configured using channel-specific parameters such as <c>AutoAcceptConfigs</c>,
        /// <c>AfterContactWorkConfigs</c>, <c>PhoneNumberConfigs</c>, <c>PersistentConnectionConfigs</c>,
        /// and <c>VoiceEnhancementConfigs</c>.
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
        [AWSProperty(Required = true)]
        public string RoutingProfileId { get; set; }

        /// <summary>
        /// Checks to see if the RoutingProfileId property is set.
        /// </summary>
        internal bool IsSetRoutingProfileId() => this.RoutingProfileId != null;

        /// <summary>
        /// Gets and sets the property SecurityProfileIds. 
        /// <para>
        /// The identifier of the security profile for the user.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 10)]
        public List<string> SecurityProfileIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SecurityProfileIds property is set.
        /// </summary>
        internal bool IsSetSecurityProfileIds() => this.SecurityProfileIds != null && (this.SecurityProfileIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags used to organize, track, or control access for this resource. For example,
        /// { "Tags": {"key1":"value1", "key2":"value2"} }.
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
        /// The user name for the account. For instances not using SAML for identity management,
        /// the user name can include up to 20 characters. If you are using SAML for identity
        /// management, the user name can include up to 64 characters from [a-zA-Z0-9_-.\@]+.
        /// </para>
        ///  
        /// <para>
        /// Username can include @ only if used in an email format. For example:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Correct: testuser
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Correct: testuser@example.com
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Incorrect: testuser@example
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
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
