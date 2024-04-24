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
    /// Container for the parameters to the DeleteGroup operation.
    /// Deletes a group so that all users and sub groups that belong to the group can no longer
    /// access documents only available to that group. For example, after deleting the group
    /// "Summer Interns", all interns who belonged to that group no longer see intern-only
    /// documents in their chat results. 
    /// 
    ///  
    /// <para>
    /// If you want to delete, update, or replace users or sub groups of a group, you need
    /// to use the <c>PutGroup</c> operation. For example, if a user in the group "Engineering"
    /// leaves the engineering team and another user takes their place, you provide an updated
    /// list of users or sub groups that belong to the "Engineering" group when calling <c>PutGroup</c>.
    /// </para>
    /// </summary>
    public partial class DeleteGroupRequest : AmazonQBusinessRequest
    {
        private string _applicationId;
        private string _dataSourceId;
        private string _groupName;
        private string _indexId;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The identifier of the application in which the group mapping belongs.
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
        /// The identifier of the data source linked to the group
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
        /// Gets and sets the property GroupName. 
        /// <para>
        /// The name of the group you want to delete.
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
        /// The identifier of the index you want to delete the group from.
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

    }
}