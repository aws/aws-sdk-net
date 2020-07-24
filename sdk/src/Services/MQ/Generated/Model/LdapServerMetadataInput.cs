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
 * Do not modify this file. This file is generated from the mq-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MQ.Model
{
    /// <summary>
    /// The metadata of the LDAP server used to authenticate and authorize connections to
    /// the broker.
    /// </summary>
    public partial class LdapServerMetadataInput
    {
        private List<string> _hosts = new List<string>();
        private string _roleBase;
        private string _roleName;
        private string _roleSearchMatching;
        private bool? _roleSearchSubtree;
        private string _serviceAccountPassword;
        private string _serviceAccountUsername;
        private string _userBase;
        private string _userRoleName;
        private string _userSearchMatching;
        private bool? _userSearchSubtree;

        /// <summary>
        /// Gets and sets the property Hosts. Fully qualified domain name of the LDAP server.
        /// Optional failover server.
        /// </summary>
        public List<string> Hosts
        {
            get { return this._hosts; }
            set { this._hosts = value; }
        }

        // Check to see if Hosts property is set
        internal bool IsSetHosts()
        {
            return this._hosts != null && this._hosts.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RoleBase. Fully qualified name of the directory to search
        /// for a user’s groups.
        /// </summary>
        public string RoleBase
        {
            get { return this._roleBase; }
            set { this._roleBase = value; }
        }

        // Check to see if RoleBase property is set
        internal bool IsSetRoleBase()
        {
            return this._roleBase != null;
        }

        /// <summary>
        /// Gets and sets the property RoleName. Specifies the LDAP attribute that identifies
        /// the group name attribute in the object returned from the group membership query.
        /// </summary>
        public string RoleName
        {
            get { return this._roleName; }
            set { this._roleName = value; }
        }

        // Check to see if RoleName property is set
        internal bool IsSetRoleName()
        {
            return this._roleName != null;
        }

        /// <summary>
        /// Gets and sets the property RoleSearchMatching. The search criteria for groups.
        /// </summary>
        public string RoleSearchMatching
        {
            get { return this._roleSearchMatching; }
            set { this._roleSearchMatching = value; }
        }

        // Check to see if RoleSearchMatching property is set
        internal bool IsSetRoleSearchMatching()
        {
            return this._roleSearchMatching != null;
        }

        /// <summary>
        /// Gets and sets the property RoleSearchSubtree. The directory search scope for the role.
        /// If set to true, scope is to search the entire sub-tree.
        /// </summary>
        public bool RoleSearchSubtree
        {
            get { return this._roleSearchSubtree.GetValueOrDefault(); }
            set { this._roleSearchSubtree = value; }
        }

        // Check to see if RoleSearchSubtree property is set
        internal bool IsSetRoleSearchSubtree()
        {
            return this._roleSearchSubtree.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServiceAccountPassword. Service account password.
        /// </summary>
        public string ServiceAccountPassword
        {
            get { return this._serviceAccountPassword; }
            set { this._serviceAccountPassword = value; }
        }

        // Check to see if ServiceAccountPassword property is set
        internal bool IsSetServiceAccountPassword()
        {
            return this._serviceAccountPassword != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceAccountUsername. Service account username.
        /// </summary>
        public string ServiceAccountUsername
        {
            get { return this._serviceAccountUsername; }
            set { this._serviceAccountUsername = value; }
        }

        // Check to see if ServiceAccountUsername property is set
        internal bool IsSetServiceAccountUsername()
        {
            return this._serviceAccountUsername != null;
        }

        /// <summary>
        /// Gets and sets the property UserBase. Fully qualified name of the directory where you
        /// want to search for users.
        /// </summary>
        public string UserBase
        {
            get { return this._userBase; }
            set { this._userBase = value; }
        }

        // Check to see if UserBase property is set
        internal bool IsSetUserBase()
        {
            return this._userBase != null;
        }

        /// <summary>
        /// Gets and sets the property UserRoleName. Specifies the name of the LDAP attribute
        /// for the user group membership.
        /// </summary>
        public string UserRoleName
        {
            get { return this._userRoleName; }
            set { this._userRoleName = value; }
        }

        // Check to see if UserRoleName property is set
        internal bool IsSetUserRoleName()
        {
            return this._userRoleName != null;
        }

        /// <summary>
        /// Gets and sets the property UserSearchMatching. The search criteria for users.
        /// </summary>
        public string UserSearchMatching
        {
            get { return this._userSearchMatching; }
            set { this._userSearchMatching = value; }
        }

        // Check to see if UserSearchMatching property is set
        internal bool IsSetUserSearchMatching()
        {
            return this._userSearchMatching != null;
        }

        /// <summary>
        /// Gets and sets the property UserSearchSubtree. The directory search scope for the user.
        /// If set to true, scope is to search the entire sub-tree.
        /// </summary>
        public bool UserSearchSubtree
        {
            get { return this._userSearchSubtree.GetValueOrDefault(); }
            set { this._userSearchSubtree = value; }
        }

        // Check to see if UserSearchSubtree property is set
        internal bool IsSetUserSearchSubtree()
        {
            return this._userSearchSubtree.HasValue; 
        }

    }
}