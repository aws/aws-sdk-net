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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
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
namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// Represents a condition in the document's ACL, specifying access rules for users and
    /// groups.
    /// </summary>
    public partial class DocumentAclCondition
    {
        private List<DocumentAclGroup> _groups = AWSConfigs.InitializeCollections ? new List<DocumentAclGroup>() : null;
        private MemberRelation _memberRelation;
        private List<DocumentAclUser> _users = AWSConfigs.InitializeCollections ? new List<DocumentAclUser>() : null;

        /// <summary>
        /// Gets and sets the property Groups. 
        /// <para>
        /// An array of group identifiers that this condition applies to. Groups listed here are
        /// subject to the access rule defined by this condition.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DocumentAclGroup> Groups
        {
            get { return this._groups; }
            set { this._groups = value; }
        }

        // Check to see if Groups property is set
        internal bool IsSetGroups()
        {
            return this._groups != null && (this._groups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MemberRelation. 
        /// <para>
        /// The logical relation between members in the condition, determining how multiple user
        /// or group conditions are combined.
        /// </para>
        /// </summary>
        public MemberRelation MemberRelation
        {
            get { return this._memberRelation; }
            set { this._memberRelation = value; }
        }

        // Check to see if MemberRelation property is set
        internal bool IsSetMemberRelation()
        {
            return this._memberRelation != null;
        }

        /// <summary>
        /// Gets and sets the property Users. 
        /// <para>
        /// An array of user identifiers that this condition applies to. Users listed here are
        /// subject to the access rule defined by this condition.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DocumentAclUser> Users
        {
            get { return this._users; }
            set { this._users = value; }
        }

        // Check to see if Users property is set
        internal bool IsSetUsers()
        {
            return this._users != null && (this._users.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}