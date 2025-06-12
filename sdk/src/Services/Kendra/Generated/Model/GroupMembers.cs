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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
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
namespace Amazon.Kendra.Model
{
    /// <summary>
    /// A list of users that belong to a group. This is useful for user context filtering,
    /// where search results are filtered based on the user or their group access to documents.
    /// </summary>
    public partial class GroupMembers
    {
        private List<MemberGroup> _memberGroups = AWSConfigs.InitializeCollections ? new List<MemberGroup>() : null;
        private List<MemberUser> _memberUsers = AWSConfigs.InitializeCollections ? new List<MemberUser>() : null;
        private S3Path _s3PathforGroupMembers;

        /// <summary>
        /// Gets and sets the property MemberGroups. 
        /// <para>
        /// A list of users that belong to a group. This can also include sub groups. For example,
        /// the sub groups "Research", "Engineering", and "Sales and Marketing" all belong to
        /// the group "Company A".
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
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
        [AWSProperty(Min=1, Max=1000)]
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
        /// Gets and sets the property S3PathforGroupMembers. 
        /// <para>
        /// If you have more than 1000 users and/or sub groups for a single group, you need to
        /// provide the path to the S3 file that lists your users and sub groups for a group.
        /// Your sub groups can contain more than 1000 users, but the list of sub groups that
        /// belong to a group (and/or users) must be no more than 1000.
        /// </para>
        ///  
        /// <para>
        /// You can download this <a href="https://docs.aws.amazon.com/kendra/latest/dg/samples/group_members.zip">example
        /// S3 file</a> that uses the correct format for listing group members. Note, <c>dataSourceId</c>
        /// is optional. The value of <c>type</c> for a group is always <c>GROUP</c> and for a
        /// user it is always <c>USER</c>.
        /// </para>
        /// </summary>
        public S3Path S3PathforGroupMembers
        {
            get { return this._s3PathforGroupMembers; }
            set { this._s3PathforGroupMembers = value; }
        }

        // Check to see if S3PathforGroupMembers property is set
        internal bool IsSetS3PathforGroupMembers()
        {
            return this._s3PathforGroupMembers != null;
        }

    }
}