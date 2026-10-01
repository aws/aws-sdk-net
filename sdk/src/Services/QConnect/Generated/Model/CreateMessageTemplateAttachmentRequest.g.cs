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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the CreateMessageTemplateAttachment operation. Uploads
    /// an attachment file to the specified Amazon Q in Connect message template. The name
    /// of the message template attachment has to be unique for each message template referenced
    /// by the <c>$LATEST</c> qualifier. The body of the attachment file should be encoded
    /// using base64 encoding. After the file is uploaded, you can use the pre-signed Amazon
    /// S3 URL returned in response to download the uploaded file.
    /// </summary>
    public partial class CreateMessageTemplateAttachmentRequest : AmazonQConnectRequest
    {
        /// <summary>
        /// Gets and sets the property Body. 
        /// <para>
        /// The body of the attachment file being uploaded. It should be encoded using base64
        /// encoding.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1)]
        public string Body { get; set; }

        /// <summary>
        /// Checks to see if the Body property is set.
        /// </summary>
        internal bool IsSetBody() => this.Body != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. If not provided, the Amazon Web Services SDK populates this field. For
        /// more information about idempotency, see <a href="http://aws.amazon.com/builders-library/making-retries-safe-with-idempotent-APIs/">Making
        /// retries safe with idempotent APIs</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property ContentDisposition. 
        /// <para>
        /// The presentation information for the attachment file.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ContentDisposition ContentDisposition { get; set; }

        /// <summary>
        /// Checks to see if the ContentDisposition property is set.
        /// </summary>
        internal bool IsSetContentDisposition() => this.ContentDisposition != null;

        /// <summary>
        /// Gets and sets the property KnowledgeBaseId. 
        /// <para>
        /// The identifier of the knowledge base. Can be either the ID or the ARN. URLs cannot
        /// contain the ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string KnowledgeBaseId { get; set; }

        /// <summary>
        /// Checks to see if the KnowledgeBaseId property is set.
        /// </summary>
        internal bool IsSetKnowledgeBaseId() => this.KnowledgeBaseId != null;

        /// <summary>
        /// Gets and sets the property MessageTemplateId. 
        /// <para>
        /// The identifier of the message template. Can be either the ID or the ARN. It cannot
        /// contain any qualifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string MessageTemplateId { get; set; }

        /// <summary>
        /// Checks to see if the MessageTemplateId property is set.
        /// </summary>
        internal bool IsSetMessageTemplateId() => this.MessageTemplateId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the attachment file being uploaded. The name should include the file extension.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
