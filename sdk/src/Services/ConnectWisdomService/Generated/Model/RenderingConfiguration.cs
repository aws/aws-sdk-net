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
    /// Information about how to render the content.
    /// </summary>
    public partial class RenderingConfiguration
    {
        private string _templateUri;

        /// <summary>
        /// Gets and sets the property TemplateUri. 
        /// <para>
        /// A URI template containing exactly one variable in <code>${variableName} </code>format.
        /// This can only be set for <code>EXTERNAL</code> knowledge bases. For Salesforce, ServiceNow,
        /// and Zendesk, the variable must be one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Salesforce: <code>Id</code>, <code>ArticleNumber</code>, <code>VersionNumber</code>,
        /// <code>Title</code>, <code>PublishStatus</code>, or <code>IsDeleted</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ServiceNow: <code>number</code>, <code>short_description</code>, <code>sys_mod_count</code>,
        /// <code>workflow_state</code>, or <code>active</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Zendesk: <code>id</code>, <code>title</code>, <code>updated_at</code>, or <code>draft</code>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The variable is replaced with the actual value for a piece of content when calling
        /// <a href="https://docs.aws.amazon.com/wisdom/latest/APIReference/API_GetContent.html">GetContent</a>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string TemplateUri
        {
            get { return this._templateUri; }
            set { this._templateUri = value; }
        }

        // Check to see if TemplateUri property is set
        internal bool IsSetTemplateUri()
        {
            return this._templateUri != null;
        }

    }
}