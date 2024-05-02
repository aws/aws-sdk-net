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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ConnectWisdomService.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateKnowledgeBaseTemplateUri operation.
    /// Updates the template URI of a knowledge base. This is only supported for knowledge
    /// bases of type EXTERNAL. Include a single variable in <c>${variable}</c> format; this
    /// interpolated by Wisdom using ingested content. For example, if you ingest a Salesforce
    /// article, it has an <c>Id</c> value, and you can set the template URI to <c>https://myInstanceName.lightning.force.com/lightning/r/Knowledge__kav/*${Id}*/view</c>.
    /// </summary>
    public partial class UpdateKnowledgeBaseTemplateUriRequest : AmazonConnectWisdomServiceRequest
    {
        private string _knowledgeBaseId;
        private string _templateUri;

        /// <summary>
        /// Gets and sets the property KnowledgeBaseId. 
        /// <para>
        /// The identifier of the knowledge base. This should not be a QUICK_RESPONSES type knowledge
        /// base if you're storing Wisdom Content resource to it. Can be either the ID or the
        /// ARN. URLs cannot contain the ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string KnowledgeBaseId
        {
            get { return this._knowledgeBaseId; }
            set { this._knowledgeBaseId = value; }
        }

        // Check to see if KnowledgeBaseId property is set
        internal bool IsSetKnowledgeBaseId()
        {
            return this._knowledgeBaseId != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateUri. 
        /// <para>
        /// The template URI to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=4096)]
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