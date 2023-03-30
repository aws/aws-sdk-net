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

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Container for the parameters to the PutPrincipalMapping operation.
    /// Maps users to their groups so that you only need to provide the user ID when you issue
    /// the query.
    /// 
    ///  
    /// <para>
    /// You can also map sub groups to groups. For example, the group "Company Intellectual
    /// Property Teams" includes sub groups "Research" and "Engineering". These sub groups
    /// include their own list of users or people who work in these teams. Only users who
    /// work in research and engineering, and therefore belong in the intellectual property
    /// group, can see top-secret company documents in their search results.
    /// </para>
    ///  
    /// <para>
    /// This is useful for user context filtering, where search results are filtered based
    /// on the user or their group access to documents. For more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/user-context-filter.html">Filtering
    /// on user context</a>.
    /// </para>
    ///  
    /// <para>
    /// If more than five <code>PUT</code> actions for a group are currently processing, a
    /// validation exception is thrown.
    /// </para>
    /// </summary>
    public partial class PutPrincipalMappingRequest : AmazonKendraRequest
    {
        private string _dataSourceId;
        private string _groupId;
        private GroupMembers _groupMembers;
        private string _indexId;
        private long? _orderingId;
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property DataSourceId. 
        /// <para>
        /// The identifier of the data source you want to map users to their groups.
        /// </para>
        ///  
        /// <para>
        /// This is useful if a group is tied to multiple data sources, but you only want the
        /// group to access documents of a certain data source. For example, the groups "Research",
        /// "Engineering", and "Sales and Marketing" are all tied to the company's documents stored
        /// in the data sources Confluence and Salesforce. However, "Sales and Marketing" team
        /// only needs access to customer-related documents stored in Salesforce.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// Gets and sets the property GroupId. 
        /// <para>
        /// The identifier of the group you want to map its users to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string GroupId
        {
            get { return this._groupId; }
            set { this._groupId = value; }
        }

        // Check to see if GroupId property is set
        internal bool IsSetGroupId()
        {
            return this._groupId != null;
        }

        /// <summary>
        /// Gets and sets the property GroupMembers. 
        /// <para>
        /// The list that contains your users or sub groups that belong the same group.
        /// </para>
        ///  
        /// <para>
        /// For example, the group "Company" includes the user "CEO" and the sub groups "Research",
        /// "Engineering", and "Sales and Marketing".
        /// </para>
        ///  
        /// <para>
        /// If you have more than 1000 users and/or sub groups for a single group, you need to
        /// provide the path to the S3 file that lists your users and sub groups for a group.
        /// Your sub groups can contain more than 1000 users, but the list of sub groups that
        /// belong to a group (and/or users) must be no more than 1000.
        /// </para>
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
        /// Gets and sets the property IndexId. 
        /// <para>
        /// The identifier of the index you want to map users to their groups.
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
        /// Gets and sets the property OrderingId. 
        /// <para>
        /// The timestamp identifier you specify to ensure Amazon Kendra does not override the
        /// latest <code>PUT</code> action with previous actions. The highest number ID, which
        /// is the ordering ID, is the latest action you want to process and apply on top of other
        /// actions with lower number IDs. This prevents previous actions with lower number IDs
        /// from possibly overriding the latest action.
        /// </para>
        ///  
        /// <para>
        /// The ordering ID can be the Unix time of the last update you made to a group members
        /// list. You would then provide this list when calling <code>PutPrincipalMapping</code>.
        /// This ensures your <code>PUT</code> action for that updated group with the latest members
        /// list doesn't get overwritten by earlier <code>PUT</code> actions for the same group
        /// which are yet to be processed.
        /// </para>
        ///  
        /// <para>
        /// The default ordering ID is the current Unix time in milliseconds that the action was
        /// received by Amazon Kendra.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=32535158400000)]
        public long OrderingId
        {
            get { return this._orderingId.GetValueOrDefault(); }
            set { this._orderingId = value; }
        }

        // Check to see if OrderingId property is set
        internal bool IsSetOrderingId()
        {
            return this._orderingId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a role that has access to the S3 file that contains
        /// your list of users or sub groups that belong to a group.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/iam-roles.html#iam-roles-ds">IAM
        /// roles for Amazon Kendra</a>.
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

    }
}