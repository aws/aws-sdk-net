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
    /// A list of users or sub groups that belong to a group. This is for generating Amazon
    /// Q Business chat results only from document a user has access to.
    /// </summary>
    public partial class GroupMembers
    {
        private List<MemberGroup> _memberGroups = AWSConfigs.InitializeCollections ? new List<MemberGroup>() : null;
        private List<MemberUser> _memberUsers = AWSConfigs.InitializeCollections ? new List<MemberUser>() : null;
        private S3 _s3PathForGroupMembers;

        /// <summary>
        /// Gets and sets the property MemberGroups. 
        /// <para>
        /// A list of sub groups that belong to a group. For example, the sub groups "Research",
        /// "Engineering", and "Sales and Marketing" all belong to the group "Company".
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MemberGroup> MemberGroups
        {
            get { return this._memberGroups; }
            set { this._memberGroups = value; }
        }

        // Check to see if MemberGroups property is set
        internal bool IsSetMemberGroups()
        {
            return this._memberGroups != null && (this._memberGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MemberUsers. 
        /// <para>
        /// A list of users that belong to a group. For example, a list of interns all belong
        /// to the "Interns" group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MemberUser> MemberUsers
        {
            get { return this._memberUsers; }
            set { this._memberUsers = value; }
        }

        // Check to see if MemberUsers property is set
        internal bool IsSetMemberUsers()
        {
            return this._memberUsers != null && (this._memberUsers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property S3PathForGroupMembers.
        /// </summary>
        public S3 S3PathForGroupMembers
        {
            get { return this._s3PathForGroupMembers; }
            set { this._s3PathForGroupMembers = value; }
        }

        // Check to see if S3PathForGroupMembers property is set
        internal bool IsSetS3PathForGroupMembers()
        {
            return this._s3PathForGroupMembers != null;
        }

    }
}