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

namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// An attachment in an Amazon Q Business conversation.
    /// </summary>
    public partial class Attachment
    {
        /// <summary>
        /// Gets and sets the property AttachmentId. 
        /// <para>
        /// The identifier of the Amazon Q Business attachment.
        /// </para>
        /// </summary>
        public string AttachmentId { get; set; }

        /// <summary>
        /// Checks to see if the AttachmentId property is set.
        /// </summary>
        internal bool IsSetAttachmentId() => this.AttachmentId != null;

        /// <summary>
        /// Gets and sets the property ConversationId. 
        /// <para>
        /// The identifier of the Amazon Q Business conversation the attachment is associated
        /// with.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string ConversationId { get; set; }

        /// <summary>
        /// Checks to see if the ConversationId property is set.
        /// </summary>
        internal bool IsSetConversationId() => this.ConversationId != null;

        /// <summary>
        /// Gets and sets the property CopyFrom. 
        /// <para>
        /// A CopyFromSource containing a reference to the original source of the Amazon Q Business
        /// attachment.
        /// </para>
        /// </summary>
        public CopyFromSource CopyFrom { get; set; }

        /// <summary>
        /// Checks to see if the CopyFrom property is set.
        /// </summary>
        internal bool IsSetCopyFrom() => this.CopyFrom != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The Unix timestamp when the Amazon Q Business attachment was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// ErrorDetail providing information about a Amazon Q Business attachment error. 
        /// </para>
        /// </summary>
        public ErrorDetail Error { get; set; }

        /// <summary>
        /// Checks to see if the Error property is set.
        /// </summary>
        internal bool IsSetError() => this.Error != null;

        /// <summary>
        /// Gets and sets the property FileSize. 
        /// <para>
        /// Size in bytes of the Amazon Q Business attachment.
        /// </para>
        /// </summary>
        public int? FileSize { get; set; }

        /// <summary>
        /// Checks to see if the FileSize property is set.
        /// </summary>
        internal bool IsSetFileSize() => this.FileSize.HasValue;

        /// <summary>
        /// Gets and sets the property FileType. 
        /// <para>
        /// Filetype of the Amazon Q Business attachment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string FileType { get; set; }

        /// <summary>
        /// Checks to see if the FileType property is set.
        /// </summary>
        internal bool IsSetFileType() => this.FileType != null;

        /// <summary>
        /// Gets and sets the property Md5chksum. 
        /// <para>
        /// MD5 checksum of the Amazon Q Business attachment contents.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string Md5chksum { get; set; }

        /// <summary>
        /// Checks to see if the Md5chksum property is set.
        /// </summary>
        internal bool IsSetMd5chksum() => this.Md5chksum != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Filename of the Amazon Q Business attachment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// AttachmentStatus of the Amazon Q Business attachment.
        /// </para>
        /// </summary>
        public AttachmentStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
