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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.MQ.Model
{
    /// <summary>
    /// Optional. The metadata of the LDAP server used to authenticate and authorize connections
    /// to the broker.
    /// 
    ///  <important>
    /// <para>
    /// Does not apply to RabbitMQ brokers.
    /// </para>
    /// </important>
    /// </summary>
    public partial class LdapServerMetadataInput
    {
        private List<string> _hosts = AWSConfigs.InitializeCollections ? new List<string>() : null;
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
        /// Gets and sets the property Hosts. 
        /// <para>
        /// Specifies the location of the LDAP server such as Directory Service for Microsoft
        /// Active Directory. Optional failover server.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> Hosts
        {
            get { return this._hosts; }
            set { this._hosts = value; }
        }

        // Check to see if Hosts property is set
        internal bool IsSetHosts()
        {
            return this._hosts != null && (this._hosts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RoleBase. 
        /// <para>
        /// The distinguished name of the node in the directory information tree (DIT) to search
        /// for roles or groups. For example, ou=group, ou=corp, dc=corp,                  dc=example,
        /// dc=com.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property RoleName. 
        /// <para>
        /// Specifies the LDAP attribute that identifies the group name attribute in the object
        /// returned from the group membership query.
        /// </para>
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
        /// Gets and sets the property RoleSearchMatching. 
        /// <para>
        /// The LDAP search filter used to find roles within the roleBase. The distinguished name
        /// of the user matched by userSearchMatching is substituted into the {0} placeholder
        /// in the search filter. The client's username is substituted into the {1} placeholder.
        /// For example, if you set this option to (member=uid={1})for the user janedoe, the search
        /// filter becomes (member=uid=janedoe) after string substitution. It matches all role
        /// entries that have a member attribute equal to uid=janedoe under the subtree selected
        /// by the roleBase.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property RoleSearchSubtree. 
        /// <para>
        /// The directory search scope for the role. If set to true, scope is to search the entire
        /// subtree.
        /// </para>
        /// </summary>
        public bool? RoleSearchSubtree
        {
            get { return this._roleSearchSubtree; }
            set { this._roleSearchSubtree = value; }
        }

        // Check to see if RoleSearchSubtree property is set
        internal bool IsSetRoleSearchSubtree()
        {
            return this._roleSearchSubtree.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServiceAccountPassword. 
        /// <para>
        /// Service account password. A service account is an account in your LDAP server that
        /// has access to initiate a connection. For example, cn=admin,dc=corp, dc=example,  
        ///                dc=com.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property ServiceAccountUsername. 
        /// <para>
        /// Service account username. A service account is an account in your LDAP server that
        /// has access to initiate a connection. For example, cn=admin,dc=corp, dc=example,  
        ///                dc=com.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property UserBase. 
        /// <para>
        /// Select a particular subtree of the directory information tree (DIT) to search for
        /// user entries. The subtree is specified by a DN, which specifies the base node of the
        /// subtree. For example, by setting this option to ou=Users,ou=corp, dc=corp,       
        ///           dc=example, dc=com, the search for user entries is restricted to the subtree
        /// beneath ou=Users, ou=corp, dc=corp, dc=example, dc=com.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property UserRoleName. 
        /// <para>
        /// Specifies the name of the LDAP attribute for the user group membership.
        /// </para>
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
        /// Gets and sets the property UserSearchMatching. 
        /// <para>
        /// The LDAP search filter used to find users within the userBase. The client's username
        /// is substituted into the {0} placeholder in the search filter. For example, if this
        /// option is set to (uid={0}) and the received username is janedoe, the search filter
        /// becomes (uid=janedoe) after string substitution. It will result in matching an entry
        /// like uid=janedoe, ou=Users,ou=corp, dc=corp, dc=example,                  dc=com.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property UserSearchSubtree. 
        /// <para>
        /// The directory search scope for the user. If set to true, scope is to search the entire
        /// subtree.
        /// </para>
        /// </summary>
        public bool? UserSearchSubtree
        {
            get { return this._userSearchSubtree; }
            set { this._userSearchSubtree = value; }
        }

        // Check to see if UserSearchSubtree property is set
        internal bool IsSetUserSearchSubtree()
        {
            return this._userSearchSubtree.HasValue; 
        }

    }
}