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

namespace Amazon.ConnectParticipant.Model
{
    /// <summary>
    /// Container for the parameters to the StartAttachmentUpload operation. Provides a pre-signed
    /// Amazon S3 URL in response for uploading the file directly to S3. <para> For security
    /// recommendations, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/security-best-practices.html#bp-security-chat">Connect
    /// Customer Chat security best practices</a>. </para> <note> <para> <c>ConnectionToken</c>
    /// is used for invoking this API instead of <c>ParticipantToken</c>. </para> </note>
    /// <para> The Amazon Connect Participant Service APIs do not use <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
    /// Version 4 authentication</a>. </para>
    /// </summary>
    public partial class StartAttachmentUploadRequest : AmazonConnectParticipantRequest
    {
        /// <summary>
        /// Gets and sets the property AttachmentName. 
        /// <para>
        /// A case-sensitive name of the attachment being uploaded.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string AttachmentName { get; set; }

        /// <summary>
        /// Checks to see if the AttachmentName property is set.
        /// </summary>
        internal bool IsSetAttachmentName() => this.AttachmentName != null;

        /// <summary>
        /// Gets and sets the property AttachmentSizeInBytes. 
        /// <para>
        /// The size of the attachment in bytes.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public long? AttachmentSizeInBytes { get; set; }

        /// <summary>
        /// Checks to see if the AttachmentSizeInBytes property is set.
        /// </summary>
        internal bool IsSetAttachmentSizeInBytes() => this.AttachmentSizeInBytes.HasValue;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. If not provided, the Amazon Web Services SDK populates this field. For
        /// more information about idempotency, see <a href="https://aws.amazon.com/builders-library/making-retries-safe-with-idempotent-APIs/">Making
        /// retries safe with idempotent APIs</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 500)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property ConnectionToken. 
        /// <para>
        /// The authentication token associated with the participant's connection.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1000)]
        public string ConnectionToken { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionToken property is set.
        /// </summary>
        internal bool IsSetConnectionToken() => this.ConnectionToken != null;

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// Describes the MIME file type of the attachment. For a list of supported file types,
        /// see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/feature-limits.html">Feature
        /// specifications</a> in the <i>Amazon Connect Administrator Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string ContentType { get; set; }

        /// <summary>
        /// Checks to see if the ContentType property is set.
        /// </summary>
        internal bool IsSetContentType() => this.ContentType != null;
    }
}
