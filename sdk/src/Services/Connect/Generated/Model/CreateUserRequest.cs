/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the CreateUser operation.
    /// Creates a new user account in your Amazon Connect instance.
    /// </summary>
    public partial class CreateUserRequest : AmazonConnectRequest
    {
        private string _directoryUserId;
        private string _hierarchyGroupId;
        private UserIdentityInfo _identityInfo;
        private string _instanceId;
        private string _password;
        private UserPhoneConfig _phoneConfig;
        private string _routingProfileId;
        private List<string> _securityProfileIds = new List<string>();
        private string _username;

        /// <summary>
        /// Gets and sets the property DirectoryUserId. 
        /// <para>
        /// The unique identifier for the user account in the directory service directory used
        /// for identity management. If Amazon Connect is unable to access the existing directory,
        /// you can use the <code>DirectoryUserId</code> to authenticate users. If you include
        /// the parameter, it is assumed that Amazon Connect cannot access the directory. If the
        /// parameter is not included, the UserIdentityInfo is used to authenticate users from
        /// your existing directory.
        /// </para>
        ///  
        /// <para>
        /// This parameter is required if you are using an existing directory for identity management
        /// in Amazon Connect when Amazon Connect cannot access your directory to authenticate
        /// users. If you are using SAML for identity management and include this parameter, an
        /// <code>InvalidRequestException</code> is returned.
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
        /// The unique identifier for the hierarchy group to assign to the user created.
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
        /// Information about the user, including email address, first name, and last name.
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
        /// The identifier for your Amazon Connect instance. To find the ID of your instance,
        /// open the AWS console and select Amazon Connect. Select the alias of the instance in
        /// the Instance alias column. The instance ID is displayed in the Overview section of
        /// your instance settings. For example, the instance ID is the set of characters at the
        /// end of the instance ARN, after instance/, such as 10a4c4eb-f57e-4d4c-b602-bf39176ced07.
        /// </para>
        /// </summary>
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
        /// The password for the user account to create. This is required if you are using Amazon
        /// Connect for identity management. If you are using SAML for identity management and
        /// include this parameter, an <code>InvalidRequestException</code> is returned.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property PhoneConfig. 
        /// <para>
        /// Specifies the phone settings for the user, including AfterContactWorkTimeLimit, AutoAccept,
        /// DeskPhoneNumber, and PhoneType.
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
        /// Gets and sets the property RoutingProfileId. 
        /// <para>
        /// The unique identifier for the routing profile to assign to the user created.
        /// </para>
        /// </summary>
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
        /// The unique identifier of the security profile to assign to the user created.
        /// </para>
        /// </summary>
        public List<string> SecurityProfileIds
        {
            get { return this._securityProfileIds; }
            set { this._securityProfileIds = value; }
        }

        // Check to see if SecurityProfileIds property is set
        internal bool IsSetSecurityProfileIds()
        {
            return this._securityProfileIds != null && this._securityProfileIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// The user name in Amazon Connect for the account to create.
        /// </para>
        /// </summary>
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

    }
}