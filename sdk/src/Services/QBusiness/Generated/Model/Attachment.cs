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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
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
namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// An attachment in an Amazon Q Business conversation.
    /// </summary>
    public partial class Attachment
    {
        private string _attachmentId;
        private string _conversationId;
        private CopyFromSource _copyFrom;
        private DateTime? _createdAt;
        private ErrorDetail _error;
        private int? _fileSize;
        private string _fileType;
        private string _md5chksum;
        private string _name;
        private AttachmentStatus _status;

        /// <summary>
        /// Gets and sets the property AttachmentId. 
        /// <para>
        /// The identifier of the Amazon Q Business attachment.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ConversationId. 
        /// <para>
        /// The identifier of the Amazon Q Business conversation the attachment is associated
        /// with.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string ConversationId
        {
            get { return this._conversationId; }
            set { this._conversationId = value; }
        }

        // Check to see if ConversationId property is set
        internal bool IsSetConversationId()
        {
            return this._conversationId != null;
        }

        /// <summary>
        /// Gets and sets the property CopyFrom. 
        /// <para>
        /// A CopyFromSource containing a reference to the original source of the Amazon Q Business
        /// attachment.
        /// </para>
        /// </summary>
        public CopyFromSource CopyFrom
        {
            get { return this._copyFrom; }
            set { this._copyFrom = value; }
        }

        // Check to see if CopyFrom property is set
        internal bool IsSetCopyFrom()
        {
            return this._copyFrom != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The Unix timestamp when the Amazon Q Business attachment was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// ErrorDetail providing information about a Amazon Q Business attachment error. 
        /// </para>
        /// </summary>
        public ErrorDetail Error
        {
            get { return this._error; }
            set { this._error = value; }
        }

        // Check to see if Error property is set
        internal bool IsSetError()
        {
            return this._error != null;
        }

        /// <summary>
        /// Gets and sets the property FileSize. 
        /// <para>
        /// Size in bytes of the Amazon Q Business attachment.
        /// </para>
        /// </summary>
        public int? FileSize
        {
            get { return this._fileSize; }
            set { this._fileSize = value; }
        }

        // Check to see if FileSize property is set
        internal bool IsSetFileSize()
        {
            return this._fileSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FileType. 
        /// <para>
        /// Filetype of the Amazon Q Business attachment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string FileType
        {
            get { return this._fileType; }
            set { this._fileType = value; }
        }

        // Check to see if FileType property is set
        internal bool IsSetFileType()
        {
            return this._fileType != null;
        }

        /// <summary>
        /// Gets and sets the property Md5chksum. 
        /// <para>
        /// MD5 checksum of the Amazon Q Business attachment contents.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string Md5chksum
        {
            get { return this._md5chksum; }
            set { this._md5chksum = value; }
        }

        // Check to see if Md5chksum property is set
        internal bool IsSetMd5chksum()
        {
            return this._md5chksum != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Filename of the Amazon Q Business attachment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
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

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// AttachmentStatus of the Amazon Q Business attachment.
        /// </para>
        /// </summary>
        public AttachmentStatus Status
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