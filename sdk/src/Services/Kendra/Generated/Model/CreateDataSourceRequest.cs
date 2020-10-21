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
    /// Container for the parameters to the CreateDataSource operation.
    /// Creates a data source that you use to with an Amazon Kendra index. 
    /// 
    ///  
    /// <para>
    /// You specify a name, data source connector type and description for your data source.
    /// You also specify configuration information such as document metadata (author, source
    /// URI, and so on) and user context information.
    /// </para>
    ///  
    /// <para>
    ///  <code>CreateDataSource</code> is a synchronous operation. The operation returns 200
    /// if the data source was successfully created. Otherwise, an exception is raised.
    /// </para>
    /// </summary>
    public partial class CreateDataSourceRequest : AmazonKendraRequest
    {
        private string _clientToken;
        private DataSourceConfiguration _configuration;
        private string _description;
        private string _indexId;
        private string _name;
        private string _roleArn;
        private string _schedule;
        private List<Tag> _tags = new List<Tag>();
        private DataSourceType _type;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A token that you provide to identify the request to create a data source. Multiple
        /// calls to the <code>CreateDataSource</code> operation with the same client token will
        /// create only one data source.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The connector configuration information that is required to access the repository.
        /// </para>
        ///  
        /// <para>
        /// You can't specify the <code>Configuration</code> parameter when the <code>Type</code>
        /// parameter is set to <code>CUSTOM</code>. If you do, you receive a <code>ValidationException</code>
        /// exception.
        /// </para>
        ///  
        /// <para>
        /// The <code>Configuration</code> parameter is required for all other data sources.
        /// </para>
        /// </summary>
        public DataSourceConfiguration Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the data source.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property IndexId. 
        /// <para>
        /// The identifier of the index that should be associated with this data source.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// A unique name for the data source. A data source name can't be changed without deleting
        /// and recreating the data source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1000)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a role with permission to access the data source.
        /// For more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/iam-roles.html">IAM
        /// Roles for Amazon Kendra</a>.
        /// </para>
        ///  
        /// <para>
        /// You can't specify the <code>RoleArn</code> parameter when the <code>Type</code> parameter
        /// is set to <code>CUSTOM</code>. If you do, you receive a <code>ValidationException</code>
        /// exception.
        /// </para>
        ///  
        /// <para>
        /// The <code>RoleArn</code> parameter is required for all other data sources.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1284)]
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
        /// Gets and sets the property Schedule. 
        /// <para>
        /// Sets the frequency that Amazon Kendra will check the documents in your repository
        /// and update the index. If you don't set a schedule Amazon Kendra will not periodically
        /// update the index. You can call the <code>StartDataSourceSyncJob</code> operation to
        /// update the index.
        /// </para>
        ///  
        /// <para>
        /// You can't specify the <code>Schedule</code> parameter when the <code>Type</code> parameter
        /// is set to <code>CUSTOM</code>. If you do, you receive a <code>ValidationException</code>
        /// exception.
        /// </para>
        /// </summary>
        public string Schedule
        {
            get { return this._schedule; }
            set { this._schedule = value; }
        }

        // Check to see if Schedule property is set
        internal bool IsSetSchedule()
        {
            return this._schedule != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of key-value pairs that identify the data source. You can use the tags to identify
        /// and organize your resources and to control access to resources.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of repository that contains the data source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DataSourceType Type
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