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
    /// Container for the parameters to the CreateUser operation.
    /// Creates a user account for the specified Amazon Connect instance.
    /// 
    ///  <important> 
    /// <para>
    /// Certain <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_UserIdentityInfo.html">UserIdentityInfo</a>
    /// parameters are required in some situations. For example, <c>Email</c>, <c>FirstName</c>
    /// and <c>LastName</c> are required if you are using Amazon Connect or SAML for identity
    /// management.
    /// </para>
    ///  </important> <note> 
    /// <para>
    /// Fields in <c>PhoneConfig</c> cannot be set simultaneously with their corresponding
    /// channel-specific configuration parameters. Specifically:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>PhoneConfig.AutoAccept</c> conflicts with <c>AutoAcceptConfigs</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>PhoneConfig.AfterContactWorkTimeLimit</c> conflicts with <c>AfterContactWorkConfigs</c>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>PhoneConfig.PhoneType</c> and <c>PhoneConfig.PhoneNumber</c> conflict with <c>PhoneNumberConfigs</c>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>PhoneConfig.PersistentConnection</c> conflicts with <c>PersistentConnectionConfigs</c>
    /// 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// We recommend using channel-specific parameters such as <c>AutoAcceptConfigs</c>, <c>AfterContactWorkConfigs</c>,
    /// <c>PhoneNumberConfigs</c>, <c>PersistentConnectionConfigs</c>, and <c>VoiceEnhancementConfigs</c>
    /// for per-channel configuration.
    /// </para>
    ///  </note> 
    /// <para>
    /// For information about how to create users using the Amazon Connect admin website,
    /// see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/user-management.html">Add
    /// Users</a> in the <i>Amazon Connect Administrator Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateUserRequest : AmazonConnectRequest
    {
        private List<AfterContactWorkConfigPerChannel> _afterContactWorkConfigs = AWSConfigs.InitializeCollections ? new List<AfterContactWorkConfigPerChannel>() : null;
        private List<AutoAcceptConfig> _autoAcceptConfigs = AWSConfigs.InitializeCollections ? new List<AutoAcceptConfig>() : null;
        private string _directoryUserId;
        private string _hierarchyGroupId;
        private UserIdentityInfo _identityInfo;
        private string _instanceId;
        private string _password;
        private List<PersistentConnectionConfig> _persistentConnectionConfigs = AWSConfigs.InitializeCollections ? new List<PersistentConnectionConfig>() : null;
        private UserPhoneConfig _phoneConfig;
        private List<PhoneNumberConfig> _phoneNumberConfigs = AWSConfigs.InitializeCollections ? new List<PhoneNumberConfig>() : null;
        private string _routingProfileId;
        private List<string> _securityProfileIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _username;
        private List<VoiceEnhancementConfig> _voiceEnhancementConfigs = AWSConfigs.InitializeCollections ? new List<VoiceEnhancementConfig>() : null;

        /// <summary>
        /// Gets and sets the property AfterContactWorkConfigs. 
        /// <para>
        /// The list of after contact work (ACW) timeout configuration settings for each channel.
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
        /// The list of auto-accept configuration settings for each channel.
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
        /// Gets and sets the property DirectoryUserId. 
        /// <para>
        /// The identifier of the user account in the directory used for identity management.
        /// If Amazon Connect cannot access the directory, you can specify this identifier to
        /// authenticate users. If you include the identifier, we assume that Amazon Connect cannot
        /// access the directory. Otherwise, the identity information is used to authenticate
        /// users from your directory.
        /// </para>
        ///  
        /// <para>
        /// This parameter is required if you are using an existing directory for identity management
        /// in Amazon Connect when Amazon Connect cannot access your directory to authenticate
        /// users. If you are using SAML for identity management and include this parameter, an
        /// error is returned.
        /// </para>
        /// </summary>
        public string DirectoryUserId
        {
            get { return this._directoryUserId; }
            set { this._directoryUserId = value; }
        }

        // Check to see if DirectoryUserId property is set
        internal bool IsSetDirectoryUserId()
        {
            return this._directoryUserId != null;
        }

        /// <summary>
        /// Gets and sets the property HierarchyGroupId. 
        /// <para>
        /// The identifier of the hierarchy group for the user.
        /// </para>
        /// </summary>
        public string HierarchyGroupId
        {
            get { return this._hierarchyGroupId; }
            set { this._hierarchyGroupId = value; }
        }

        // Check to see if HierarchyGroupId property is set
        internal bool IsSetHierarchyGroupId()
        {
            return this._hierarchyGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityInfo. 
        /// <para>
        /// The information about the identity of the user.
        /// </para>
        /// </summary>
        public UserIdentityInfo IdentityInfo
        {
            get { return this._identityInfo; }
            set { this._identityInfo = value; }
        }

        // Check to see if IdentityInfo property is set
        internal bool IsSetIdentityInfo()
        {
            return this._identityInfo != null;
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
        /// Gets and sets the property Password. 
        /// <para>
        /// The password for the user account. A password is required if you are using Amazon
        /// Connect for identity management. Otherwise, it is an error to include a password.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string Password
        {
            get { return this._password; }
            set { this._password = value; }
        }

        // Check to see if Password property is set
        internal bool IsSetPassword()
        {
            return this._password != null;
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
        /// Gets and sets the property PhoneConfig. 
        /// <para>
        /// The phone settings for the user. This parameter is optional. If not provided, the
        /// user can be configured using channel-specific parameters such as <c>AutoAcceptConfigs</c>,
        /// <c>AfterContactWorkConfigs</c>, <c>PhoneNumberConfigs</c>, <c>PersistentConnectionConfigs</c>,
        /// and <c>VoiceEnhancementConfigs</c>.
        /// </para>
        /// </summary>
        public UserPhoneConfig PhoneConfig
        {
            get { return this._phoneConfig; }
            set { this._phoneConfig = value; }
        }

        // Check to see if PhoneConfig property is set
        internal bool IsSetPhoneConfig()
        {
            return this._phoneConfig != null;
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
        /// Gets and sets the property RoutingProfileId. 
        /// <para>
        /// The identifier of the routing profile for the user.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RoutingProfileId
        {
            get { return this._routingProfileId; }
            set { this._routingProfileId = value; }
        }

        // Check to see if RoutingProfileId property is set
        internal bool IsSetRoutingProfileId()
        {
            return this._routingProfileId != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityProfileIds. 
        /// <para>
        /// The identifier of the security profile for the user.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public List<string> SecurityProfileIds
        {
            get { return this._securityProfileIds; }
            set { this._securityProfileIds = value; }
        }

        // Check to see if SecurityProfileIds property is set
        internal bool IsSetSecurityProfileIds()
        {
            return this._securityProfileIds != null && (this._securityProfileIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags used to organize, track, or control access for this resource. For example,
        /// { "Tags": {"key1":"value1", "key2":"value2"} }.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string Username
        {
            get { return this._username; }
            set { this._username = value; }
        }

        // Check to see if Username property is set
        internal bool IsSetUsername()
        {
            return this._username != null;
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