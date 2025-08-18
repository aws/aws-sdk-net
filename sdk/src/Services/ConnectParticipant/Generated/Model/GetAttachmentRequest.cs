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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ConnectParticipant.Model
{
    /// <summary>
    /// Container for the parameters to the GetAttachment operation.
    /// Provides a pre-signed URL for download of a completed attachment. This is an asynchronous
    /// API for use with active contacts.
    /// 
    ///  
    /// <para>
    /// For security recommendations, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/security-best-practices.html#bp-security-chat">Amazon
    /// Connect Chat security best practices</a>. 
    /// </para>
    ///  <note> <ul> <li> 
    /// <para>
    /// The participant role <c>CUSTOM_BOT</c> is not permitted to access attachments customers
    /// may upload. An <c>AccessDeniedException</c> can indicate that the participant may
    /// be a CUSTOM_BOT, and it doesn't have access to attachments.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ConnectionToken</c> is used for invoking this API instead of <c>ParticipantToken</c>.
    /// </para>
    ///  </li> </ul> </note> 
    /// <para>
    /// The Amazon Connect Participant Service APIs do not use <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
    /// Version 4 authentication</a>.
    /// </para>
    /// </summary>
    public partial class GetAttachmentRequest : AmazonConnectParticipantRequest
    {
        private string _attachmentId;
        private string _connectionToken;
        private int? _urlExpiryInSeconds;

        /// <summary>
        /// Gets and sets the property AttachmentId. 
        /// <para>
        /// A unique identifier for the attachment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string AttachmentId
        {
            get { return this._attachmentId; }
            set { this._attachmentId = value; }
        }

        // Check to see if AttachmentId property is set
        internal bool IsSetAttachmentId()
        {
            return this._attachmentId != null;
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
        /// Gets and sets the property UrlExpiryInSeconds. 
        /// <para>
        /// The expiration time of the URL in ISO timestamp. It's specified in ISO 8601 format:
        /// yyyy-MM-ddThh:mm:ss.SSSZ. For example, 2019-11-08T02:41:28.172Z.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=300)]
        public int? UrlExpiryInSeconds
        {
            get { return this._urlExpiryInSeconds; }
            set { this._urlExpiryInSeconds = value; }
        }

        // Check to see if UrlExpiryInSeconds property is set
        internal bool IsSetUrlExpiryInSeconds()
        {
            return this._urlExpiryInSeconds.HasValue; 
        }

    }
}