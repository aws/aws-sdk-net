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
    /// Container for the parameters to the CreateMessageTemplateVersion operation.
    /// Creates a new Amazon Q in Connect message template version from the current content
    /// and configuration of a message template. Versions are immutable and monotonically
    /// increasing. Once a version is created, you can reference a specific version of the
    /// message template by passing in <c>&lt;message-template-id&gt;:&lt;versionNumber&gt;</c>
    /// as the message template identifier. An error is displayed if the supplied <c>messageTemplateContentSha256</c>
    /// is different from the <c>messageTemplateContentSha256</c> of the message template
    /// with <c>$LATEST</c> qualifier. If multiple <c>CreateMessageTemplateVersion</c> requests
    /// are made while the message template remains the same, only the first invocation creates
    /// a new version and the succeeding requests will return the same response as the first
    /// invocation.
    /// </summary>
    public partial class CreateMessageTemplateVersionRequest : AmazonQConnectRequest
    {
        private string _knowledgeBaseId;
        private string _messageTemplateContentSha256;
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
        /// Gets and sets the property MessageTemplateContentSha256. 
        /// <para>
        /// The checksum value of the message template content that is referenced by the <c>$LATEST</c>
        /// qualifier. It can be returned in <c>MessageTemplateData</c> or <c>ExtendedMessageTemplateData</c>.
        /// It’s calculated by content, language, <c>defaultAttributes</c> and <c>Attachments</c>
        /// of the message template. If not supplied, the message template version will be created
        /// based on the message template content that is referenced by the <c>$LATEST</c> qualifier
        /// by default.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string MessageTemplateContentSha256
        {
            get { return this._messageTemplateContentSha256; }
            set { this._messageTemplateContentSha256 = value; }
        }

        // Check to see if MessageTemplateContentSha256 property is set
        internal bool IsSetMessageTemplateContentSha256()
        {
            return this._messageTemplateContentSha256 != null;
        }

        /// <summary>
        /// Gets and sets the property MessageTemplateId. 
        /// <para>
        /// The identifier of the message template. Can be either the ID or the ARN. It cannot
        /// contain any qualifier.
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