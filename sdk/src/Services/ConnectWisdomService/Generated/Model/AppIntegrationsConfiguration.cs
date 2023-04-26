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
 * Do not modify this file. This file is generated from the wisdom-2020-10-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConnectWisdomService.Model
{
    /// <summary>
    /// Configuration information for Amazon AppIntegrations to automatically ingest content.
    /// </summary>
    public partial class AppIntegrationsConfiguration
    {
        private string _appIntegrationArn;
        private List<string> _objectFields = new List<string>();

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
        /// if objectFields is not provided, including at least <code>Id</code>, <code>ArticleNumber</code>,
        /// <code>VersionNumber</code>, <code>Title</code>, <code>PublishStatus</code>, and <code>IsDeleted</code>
        /// as source fields. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  For <a href="https://developer.servicenow.com/dev.do#!/reference/api/rome/rest/knowledge-management-api">
        /// ServiceNow</a>, your AppIntegrations DataIntegration must have an ObjectConfiguration
        /// if objectFields is not provided, including at least <code>number</code>, <code>short_description</code>,
        /// <code>sys_mod_count</code>, <code>workflow_state</code>, and <code>active</code> as
        /// source fields. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  For <a href="https://developer.zendesk.com/api-reference/help_center/help-center-api/articles/">
        /// Zendesk</a>, your AppIntegrations DataIntegration must have an ObjectConfiguration
        /// if <code>objectFields</code> is not provided, including at least <code>id</code>,
        /// <code>title</code>, <code>updated_at</code>, and <code>draft</code> as source fields.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  For <a href="https://learn.microsoft.com/en-us/sharepoint/dev/sp-add-ins/sharepoint-net-server-csom-jsom-and-rest-api-index">
        /// SharePoint</a>, your AppIntegrations DataIntegration must have a FileConfiguration,
        /// including only file extensions that are among <code>docx</code>, <code>pdf</code>,
        /// <code>html</code>, <code>htm</code>, and <code>txt</code>. 
        /// </para>
        ///  </li> </ul>
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
        /// The fields from the source that are made available to your agents in Wisdom. Optional
        /// if ObjectConfiguration is included in the provided DataIntegration. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  For <a href="https://developer.salesforce.com/docs/atlas.en-us.knowledge_dev.meta/knowledge_dev/sforce_api_objects_knowledge__kav.htm">
        /// Salesforce</a>, you must include at least <code>Id</code>, <code>ArticleNumber</code>,
        /// <code>VersionNumber</code>, <code>Title</code>, <code>PublishStatus</code>, and <code>IsDeleted</code>.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <a href="https://developer.servicenow.com/dev.do#!/reference/api/rome/rest/knowledge-management-api">
        /// ServiceNow</a>, you must include at least <code>number</code>, <code>short_description</code>,
        /// <code>sys_mod_count</code>, <code>workflow_state</code>, and <code>active</code>.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <a href="https://developer.zendesk.com/api-reference/help_center/help-center-api/articles/">
        /// Zendesk</a>, you must include at least <code>id</code>, <code>title</code>, <code>updated_at</code>,
        /// and <code>draft</code>. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Make sure to include additional fields. These fields are indexed and used to source
        /// recommendations. 
        /// </para>
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
            return this._objectFields != null && this._objectFields.Count > 0; 
        }

    }
}