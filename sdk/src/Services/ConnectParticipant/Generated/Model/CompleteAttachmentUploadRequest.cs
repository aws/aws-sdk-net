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
    /// Container for the parameters to the CompleteAttachmentUpload operation.
    /// Allows you to confirm that the attachment has been uploaded using the pre-signed URL
    /// provided in StartAttachmentUpload API. 
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
    public partial class CompleteAttachmentUploadRequest : AmazonConnectParticipantRequest
    {
        private List<string> _attachmentIds = new List<string>();
        private string _clientToken;
        private string _connectionToken;

        /// <summary>
        /// Gets and sets the property AttachmentIds. 
        /// <para>
        /// A list of unique identifiers for the attachments.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<string> AttachmentIds
        {
            get { return this._attachmentIds; }
            set { this._attachmentIds = value; }
        }

        // Check to see if AttachmentIds property is set
        internal bool IsSetAttachmentIds()
        {
            return this._attachmentIds != null && this._attachmentIds.Count > 0; 
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

    }
}