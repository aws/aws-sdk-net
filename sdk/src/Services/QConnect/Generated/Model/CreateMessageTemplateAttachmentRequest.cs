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
    /// Container for the parameters to the CreateMessageTemplateAttachment operation.
    /// Uploads an attachment file to the specified Amazon Q in Connect message template.
    /// The name of the message template attachment has to be unique for each message template
    /// referenced by the <c>$LATEST</c> qualifier. The body of the attachment file should
    /// be encoded using base64 encoding. After the file is uploaded, you can use the pre-signed
    /// Amazon S3 URL returned in response to download the uploaded file.
    /// </summary>
    public partial class CreateMessageTemplateAttachmentRequest : AmazonQConnectRequest
    {
        private string _body;
        private string _clientToken;
        private ContentDisposition _contentDisposition;
        private string _knowledgeBaseId;
        private string _messageTemplateId;
        private string _name;

        /// <summary>
        /// Gets and sets the property Body. 
        /// <para>
        /// The body of the attachment file being uploaded. It should be encoded using base64
        /// encoding.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1)]
        public string Body
        {
            get { return this._body; }
            set { this._body = value; }
        }

        // Check to see if Body property is set
        internal bool IsSetBody()
        {
            return this._body != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. If not provided, the Amazon Web Services SDK populates this field. For
        /// more information about idempotency, see <a href="http://aws.amazon.com/builders-library/making-retries-safe-with-idempotent-APIs/">Making
        /// retries safe with idempotent APIs</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
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
        /// Gets and sets the property ContentDisposition. 
        /// <para>
        /// The presentation information for the attachment file.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ContentDisposition ContentDisposition
        {
            get { return this._contentDisposition; }
            set { this._contentDisposition = value; }
        }

        // Check to see if ContentDisposition property is set
        internal bool IsSetContentDisposition()
        {
            return this._contentDisposition != null;
        }

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

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the attachment file being uploaded. The name should include the file extension.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=256)]
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

    }
}