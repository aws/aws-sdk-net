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
    /// Container for the parameters to the DeletePrincipalMapping operation.
    /// Deletes a group so that all users and sub groups that belong to the group can no longer
    /// access documents only available to that group.
    /// 
    ///  
    /// <para>
    /// For example, after deleting the group "Summer Interns", all interns who belonged to
    /// that group no longer see intern-only documents in their search results.
    /// </para>
    ///  
    /// <para>
    /// If you want to delete or replace users or sub groups of a group, you need to use the
    /// <code>PutPrincipalMapping</code> operation. For example, if a user in the group "Engineering"
    /// leaves the engineering team and another user takes their place, you provide an updated
    /// list of users or sub groups that belong to the "Engineering" group when calling <code>PutPrincipalMapping</code>.
    /// You can update your internal list of users or sub groups and input this list when
    /// calling <code>PutPrincipalMapping</code>.
    /// </para>
    ///  
    /// <para>
    ///  <code>DeletePrincipalMapping</code> is currently not supported in the Amazon Web
    /// Services GovCloud (US-West) region.
    /// </para>
    /// </summary>
    public partial class DeletePrincipalMappingRequest : AmazonKendraRequest
    {
        private string _dataSourceId;
        private string _groupId;
        private string _indexId;
        private long? _orderingId;

        /// <summary>
        /// Gets and sets the property DataSourceId. 
        /// <para>
        /// The identifier of the data source you want to delete a group from.
        /// </para>
        ///  
        /// <para>
        /// A group can be tied to multiple data sources. You can delete a group from accessing
        /// documents in a certain data source. For example, the groups "Research", "Engineering",
        /// and "Sales and Marketing" are all tied to the company's documents stored in the data
        /// sources Confluence and Salesforce. You want to delete "Research" and "Engineering"
        /// groups from Salesforce, so that these groups cannot access customer-related documents
        /// stored in Salesforce. Only "Sales and Marketing" should access documents in the Salesforce
        /// data source.
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
        /// The identifier of the group you want to delete.
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
        /// Gets and sets the property IndexId. 
        /// <para>
        /// The identifier of the index you want to delete a group from.
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
        /// latest <code>DELETE</code> action with previous actions. The highest number ID, which
        /// is the ordering ID, is the latest action you want to process and apply on top of other
        /// actions with lower number IDs. This prevents previous actions with lower number IDs
        /// from possibly overriding the latest action.
        /// </para>
        ///  
        /// <para>
        /// The ordering ID can be the Unix time of the last update you made to a group members
        /// list. You would then provide this list when calling <code>PutPrincipalMapping</code>.
        /// This ensures your <code>DELETE</code> action for that updated group with the latest
        /// members list doesn't get overwritten by earlier <code>DELETE</code> actions for the
        /// same group which are yet to be processed.
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

    }
}