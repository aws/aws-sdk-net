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
    /// Container for the parameters to the PutGroup operation.
    /// Create, or updates, a mapping of users—who have access to a document—to groups.
    /// 
    ///  
    /// <para>
    /// You can also map sub groups to groups. For example, the group "Company Intellectual
    /// Property Teams" includes sub groups "Research" and "Engineering". These sub groups
    /// include their own list of users or people who work in these teams. Only users who
    /// work in research and engineering, and therefore belong in the intellectual property
    /// group, can see top-secret company documents in their Amazon Q Business chat results.
    /// </para>
    ///  
    /// <para>
    /// There are two options for creating groups, either passing group members inline or
    /// using an S3 file via the S3PathForGroupMembers field. For inline groups, there is
    /// a limit of 1000 members per group and for provided S3 files there is a limit of 100
    /// thousand members. When creating a group using an S3 file, you provide both an S3 file
    /// and a <c>RoleArn</c> for Amazon Q Buisness to access the file.
    /// </para>
    /// </summary>
    public partial class PutGroupRequest : AmazonQBusinessRequest
    {
        private string _applicationId;
        private string _dataSourceId;
        private GroupMembers _groupMembers;
        private string _groupName;
        private string _indexId;
        private string _roleArn;
        private MembershipType _type;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The identifier of the application in which the user and group mapping belongs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

        /// <summary>
        /// Gets and sets the property DataSourceId. 
        /// <para>
        /// The identifier of the data source for which you want to map users to their groups.
        /// This is useful if a group is tied to multiple data sources, but you only want the
        /// group to access documents of a certain data source. For example, the groups "Research",
        /// "Engineering", and "Sales and Marketing" are all tied to the company's documents stored
        /// in the data sources Confluence and Salesforce. However, "Sales and Marketing" team
        /// only needs access to customer-related documents stored in Salesforce.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string DataSourceId
        {
            get { return this._dataSourceId; }
            set { this._dataSourceId = value; }
        }

        // Check to see if DataSourceId property is set
        internal bool IsSetDataSourceId()
        {
            return this._dataSourceId != null;
        }

        /// <summary>
        /// Gets and sets the property GroupMembers.
        /// </summary>
        [AWSProperty(Required=true)]
        public GroupMembers GroupMembers
        {
            get { return this._groupMembers; }
            set { this._groupMembers = value; }
        }

        // Check to see if GroupMembers property is set
        internal bool IsSetGroupMembers()
        {
            return this._groupMembers != null;
        }

        /// <summary>
        /// Gets and sets the property GroupName. 
        /// <para>
        /// The list that contains your users or sub groups that belong the same group. For example,
        /// the group "Company" includes the user "CEO" and the sub groups "Research", "Engineering",
        /// and "Sales and Marketing".
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string GroupName
        {
            get { return this._groupName; }
            set { this._groupName = value; }
        }

        // Check to see if GroupName property is set
        internal bool IsSetGroupName()
        {
            return this._groupName != null;
        }

        /// <summary>
        /// Gets and sets the property IndexId. 
        /// <para>
        /// The identifier of the index in which you want to map users to their groups.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string IndexId
        {
            get { return this._indexId; }
            set { this._indexId = value; }
        }

        // Check to see if IndexId property is set
        internal bool IsSetIndexId()
        {
            return this._indexId != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an IAM role that has access to the S3 file that
        /// contains your list of users that belong to a group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1284)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MembershipType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}