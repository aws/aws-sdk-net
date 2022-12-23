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
 * Do not modify this file. This file is generated from the connectparticipant-2018-09-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConnectParticipant.Model
{
    /// <summary>
    /// Container for the parameters to the StartAttachmentUpload operation.
    /// Provides a pre-signed Amazon S3 URL in response for uploading the file directly to
    /// S3.
    /// 
    ///  <note> 
    /// <para>
    ///  <code>ConnectionToken</code> is used for invoking this API instead of <code>ParticipantToken</code>.
    /// </para>
    ///  </note> 
    /// <para>
    /// The Amazon Connect Participant Service APIs do not use <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
    /// Version 4 authentication</a>.
    /// </para>
    /// </summary>
    public partial class StartAttachmentUploadRequest : AmazonConnectParticipantRequest
    {
        private string _attachmentName;
        private long? _attachmentSizeInBytes;
        private string _clientToken;
        private string _connectionToken;
        private string _contentType;

        /// <summary>
        /// Gets and sets the property AttachmentName. 
        /// <para>
        /// A case-sensitive name of the attachment being uploaded.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string AttachmentName
        {
            get { return this._attachmentName; }
            set { this._attachmentName = value; }
        }

        // Check to see if AttachmentName property is set
        internal bool IsSetAttachmentName()
        {
            return this._attachmentName != null;
        }

        /// <summary>
        /// Gets and sets the property AttachmentSizeInBytes. 
        /// <para>
        /// The size of the attachment in bytes.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public long AttachmentSizeInBytes
        {
            get { return this._attachmentSizeInBytes.GetValueOrDefault(); }
            set { this._attachmentSizeInBytes = value; }
        }

        // Check to see if AttachmentSizeInBytes property is set
        internal bool IsSetAttachmentSizeInBytes()
        {
            return this._attachmentSizeInBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. If not provided, the Amazon Web Services SDK populates this field. For
        /// more information about idempotency, see <a href="https://aws.amazon.com/builders-library/making-retries-safe-with-idempotent-APIs/">Making
        /// retries safe with idempotent APIs</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
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
        /// Gets and sets the property ConnectionToken. 
        /// <para>
        /// The authentication token associated with the participant's connection.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1000)]
        public string ConnectionToken
        {
            get { return this._connectionToken; }
            set { this._connectionToken = value; }
        }

        // Check to see if ConnectionToken property is set
        internal bool IsSetConnectionToken()
        {
            return this._connectionToken != null;
        }

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// Describes the MIME file type of the attachment. For a list of supported file types,
        /// see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/feature-limits.html">Feature
        /// specifications</a> in the <i>Amazon Connect Administrator Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string ContentType
        {
            get { return this._contentType; }
            set { this._contentType = value; }
        }

        // Check to see if ContentType property is set
        internal bool IsSetContentType()
        {
            return this._contentType != null;
        }

    }
}