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
    /// The case-insensitive input to indicate standard MIME type that describes the format
    /// of the file that will be uploaded.
    /// </summary>
    public partial class AttachmentItem
    {
        private string _attachmentId;
        private string _attachmentName;
        private string _contentType;
        private ArtifactStatus _status;

        /// <summary>
        /// Gets and sets the property AttachmentId. 
        /// <para>
        /// A unique identifier for the attachment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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
        /// Gets and sets the property AttachmentName. 
        /// <para>
        /// A case-sensitive name of the attachment being uploaded.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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
        /// Gets and sets the property ContentType. 
        /// <para>
        /// Describes the MIME file type of the attachment. For a list of supported file types,
        /// see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/feature-limits.html">Feature
        /// specifications</a> in the <i>Amazon Connect Administrator Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Status of the attachment.
        /// </para>
        /// </summary>
        public ArtifactStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}