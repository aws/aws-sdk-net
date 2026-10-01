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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// The metadata of the Lightweight Directory Access Protocol (LDAP) server used to authenticate
    /// and authorize connections to the broker. This is an optional failover server.
    /// </summary>
    public partial class AwsAmazonMqBrokerLdapServerMetadataDetails
    {
        /// <summary>
        /// Gets and sets the property Hosts. 
        /// <para>
        ///  Specifies the location of the LDAP server, such as Amazon Web Services Directory
        /// Service for Microsoft Active Directory. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Hosts { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Hosts property is set.
        /// </summary>
        internal bool IsSetHosts() => this.Hosts != null && (this.Hosts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RoleBase. 
        /// <para>
        ///  The distinguished name of the node in the directory information tree (DIT) to search
        /// for roles or groups. 
        /// </para>
        /// </summary>
        public string RoleBase { get; set; }

        /// <summary>
        /// Checks to see if the RoleBase property is set.
        /// </summary>
        internal bool IsSetRoleBase() => this.RoleBase != null;

        /// <summary>
        /// Gets and sets the property RoleName. 
        /// <para>
        ///  The group name attribute in a role entry whose value is the name of that role. 
        /// </para>
        /// </summary>
        public string RoleName { get; set; }

        /// <summary>
        /// Checks to see if the RoleName property is set.
        /// </summary>
        internal bool IsSetRoleName() => this.RoleName != null;

        /// <summary>
        /// Gets and sets the property RoleSearchMatching. 
        /// <para>
        ///  The LDAP search filter used to find roles within the <c>roleBase</c>. 
        /// </para>
        /// </summary>
        public string RoleSearchMatching { get; set; }

        /// <summary>
        /// Checks to see if the RoleSearchMatching property is set.
        /// </summary>
        internal bool IsSetRoleSearchMatching() => this.RoleSearchMatching != null;

        /// <summary>
        /// Gets and sets the property RoleSearchSubtree. 
        /// <para>
        ///  The directory search scope for the role. If set to <c>true</c>, the scope is to search
        /// the entire subtree. 
        /// </para>
        /// </summary>
        public bool? RoleSearchSubtree { get; set; }

        /// <summary>
        /// Checks to see if the RoleSearchSubtree property is set.
        /// </summary>
        internal bool IsSetRoleSearchSubtree() => this.RoleSearchSubtree.HasValue;

        /// <summary>
        /// Gets and sets the property ServiceAccountUsername. 
        /// <para>
        ///  A username for the service account, which is an account in your LDAP server that
        /// has access to initiate a connection. 
        /// </para>
        /// </summary>
        public string ServiceAccountUsername { get; set; }

        /// <summary>
        /// Checks to see if the ServiceAccountUsername property is set.
        /// </summary>
        internal bool IsSetServiceAccountUsername() => this.ServiceAccountUsername != null;

        /// <summary>
        /// Gets and sets the property UserBase. 
        /// <para>
        ///  Selects a particular subtree of the directory information tree (DIT) to search for
        /// user entries. 
        /// </para>
        /// </summary>
        public string UserBase { get; set; }

        /// <summary>
        /// Checks to see if the UserBase property is set.
        /// </summary>
        internal bool IsSetUserBase() => this.UserBase != null;

        /// <summary>
        /// Gets and sets the property UserRoleName. 
        /// <para>
        ///  The name of the LDAP attribute in the user's directory entry for the user's group
        /// membership. 
        /// </para>
        /// </summary>
        public string UserRoleName { get; set; }

        /// <summary>
        /// Checks to see if the UserRoleName property is set.
        /// </summary>
        internal bool IsSetUserRoleName() => this.UserRoleName != null;

        /// <summary>
        /// Gets and sets the property UserSearchMatching. 
        /// <para>
        ///  The LDAP search filter used to find users within the <c>userBase</c>. 
        /// </para>
        /// </summary>
        public string UserSearchMatching { get; set; }

        /// <summary>
        /// Checks to see if the UserSearchMatching property is set.
        /// </summary>
        internal bool IsSetUserSearchMatching() => this.UserSearchMatching != null;

        /// <summary>
        /// Gets and sets the property UserSearchSubtree. 
        /// <para>
        ///  The directory search scope for the user. If set to true, the scope is to search the
        /// entire subtree. 
        /// </para>
        /// </summary>
        public bool? UserSearchSubtree { get; set; }

        /// <summary>
        /// Checks to see if the UserSearchSubtree property is set.
        /// </summary>
        internal bool IsSetUserSearchSubtree() => this.UserSearchSubtree.HasValue;
    }
}
