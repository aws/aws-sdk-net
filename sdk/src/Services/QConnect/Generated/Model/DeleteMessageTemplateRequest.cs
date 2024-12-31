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
    /// Container for the parameters to the DeleteMessageTemplate operation.
    /// Deletes an Amazon Q in Connect message template entirely or a specific version of
    /// the message template if version is supplied in the request. You can provide the message
    /// template identifier as <c>&lt;message-template-id&gt;:&lt;versionNumber&gt;</c> to
    /// delete a specific version of the message template. If it is not supplied, the message
    /// template and all available versions will be deleted.
    /// </summary>
    public partial class DeleteMessageTemplateRequest : AmazonQConnectRequest
    {
        private string _knowledgeBaseId;
        private string _messageTemplateId;

        /// <summary>
        /// Gets and sets the property KnowledgeBaseId. 
        /// <para>
        /// The identifier of the knowledge base. Can be either the ID or the ARN. URLs cannot
        /// contain the ARN.
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
        /// Gets and sets the property MessageTemplateId. 
        /// <para>
        /// The identifier of the message template. Can be either the ID or the ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string MessageTemplateId
        {
            get { return this._messageTemplateId; }
            set { this._messageTemplateId = value; }
        }

        // Check to see if MessageTemplateId property is set
        internal bool IsSetMessageTemplateId()
        {
            return this._messageTemplateId != null;
        }

    }
}