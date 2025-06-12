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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
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
namespace Amazon.QConnect.Model
{
    /// <summary>
    /// Configuration information for Amazon AppIntegrations to automatically ingest content.
    /// </summary>
    public partial class AppIntegrationsConfiguration
    {
        private string _appIntegrationArn;
        private List<string> _objectFields = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AppIntegrationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the AppIntegrations DataIntegration to use for ingesting
        /// content.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  For <a href="https://developer.salesforce.com/docs/atlas.en-us.knowledge_dev.meta/knowledge_dev/sforce_api_objects_knowledge__kav.htm">
        /// Salesforce</a>, your AppIntegrations DataIntegration must have an ObjectConfiguration
        /// if objectFields is not provided, including at least <c>Id</c>, <c>ArticleNumber</c>,
        /// <c>VersionNumber</c>, <c>Title</c>, <c>PublishStatus</c>, and <c>IsDeleted</c> as
        /// source fields. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  For <a href="https://developer.servicenow.com/dev.do#!/reference/api/rome/rest/knowledge-management-api">
        /// ServiceNow</a>, your AppIntegrations DataIntegration must have an ObjectConfiguration
        /// if objectFields is not provided, including at least <c>number</c>, <c>short_description</c>,
        /// <c>sys_mod_count</c>, <c>workflow_state</c>, and <c>active</c> as source fields. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  For <a href="https://developer.zendesk.com/api-reference/help_center/help-center-api/articles/">
        /// Zendesk</a>, your AppIntegrations DataIntegration must have an ObjectConfiguration
        /// if <c>objectFields</c> is not provided, including at least <c>id</c>, <c>title</c>,
        /// <c>updated_at</c>, and <c>draft</c> as source fields. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  For <a href="https://learn.microsoft.com/en-us/sharepoint/dev/sp-add-ins/sharepoint-net-server-csom-jsom-and-rest-api-index">SharePoint</a>,
        /// your AppIntegrations DataIntegration must have a FileConfiguration, including only
        /// file extensions that are among <c>docx</c>, <c>pdf</c>, <c>html</c>, <c>htm</c>, and
        /// <c>txt</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  For <a href="http://aws.amazon.com/s3/">Amazon S3</a>, the ObjectConfiguration and
        /// FileConfiguration of your AppIntegrations DataIntegration must be null. The <c>SourceURI</c>
        /// of your DataIntegration must use the following format: <c>s3://your_s3_bucket_name</c>.
        /// </para>
        ///  <important> 
        /// <para>
        /// The bucket policy of the corresponding S3 bucket must allow the Amazon Web Services
        /// principal <c>app-integrations.amazonaws.com</c> to perform <c>s3:ListBucket</c>, <c>s3:GetObject</c>,
        /// and <c>s3:GetBucketLocation</c> against the bucket.
        /// </para>
        ///  </important> </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string AppIntegrationArn
        {
            get { return this._appIntegrationArn; }
            set { this._appIntegrationArn = value; }
        }

        // Check to see if AppIntegrationArn property is set
        internal bool IsSetAppIntegrationArn()
        {
            return this._appIntegrationArn != null;
        }

        /// <summary>
        /// Gets and sets the property ObjectFields. 
        /// <para>
        /// The fields from the source that are made available to your agents in Amazon Q in Connect.
        /// Optional if ObjectConfiguration is included in the provided DataIntegration. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  For <a href="https://developer.salesforce.com/docs/atlas.en-us.knowledge_dev.meta/knowledge_dev/sforce_api_objects_knowledge__kav.htm">
        /// Salesforce</a>, you must include at least <c>Id</c>, <c>ArticleNumber</c>, <c>VersionNumber</c>,
        /// <c>Title</c>, <c>PublishStatus</c>, and <c>IsDeleted</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <a href="https://developer.servicenow.com/dev.do#!/reference/api/rome/rest/knowledge-management-api">
        /// ServiceNow</a>, you must include at least <c>number</c>, <c>short_description</c>,
        /// <c>sys_mod_count</c>, <c>workflow_state</c>, and <c>active</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <a href="https://developer.zendesk.com/api-reference/help_center/help-center-api/articles/">
        /// Zendesk</a>, you must include at least <c>id</c>, <c>title</c>, <c>updated_at</c>,
        /// and <c>draft</c>. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Make sure to include additional fields. These fields are indexed and used to source
        /// recommendations. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> ObjectFields
        {
            get { return this._objectFields; }
            set { this._objectFields = value; }
        }

        // Check to see if ObjectFields property is set
        internal bool IsSetObjectFields()
        {
            return this._objectFields != null && (this._objectFields.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}