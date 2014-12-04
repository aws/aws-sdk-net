/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the support-2013-04-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AWSSupport.Model
{
    /// <summary>
    /// Container for the parameters to the AddAttachmentsToSet operation.
    /// Adds one or more attachments to an attachment set. If an <code>AttachmentSetId</code>
    /// is not specified, a new attachment set is created, and the ID of the set is returned
    /// in the response. If an <code>AttachmentSetId</code> is specified, the attachments
    /// are added to the specified set, if it exists.
    /// 
    ///  
    /// <para>
    /// An attachment set is a temporary container for attachments that are to be added to
    /// a case or case communication. The set is available for one hour after it is created;
    /// the <code>ExpiryTime</code> returned in the response indicates when the set expires.
    /// The maximum number of attachments in a set is 3, and the maximum size of any attachment
    /// in the set is 5 MB.
    /// </para>
    /// </summary>
    public partial class AddAttachmentsToSetRequest : AmazonAWSSupportRequest
    {
        private List<Attachment> _attachments = new List<Attachment>();
        private string _attachmentSetId;

        /// <summary>
        /// Gets and sets the property Attachments. 
        /// <para>
        /// One or more attachments to add to the set. The limit is 3 attachments per set, and
        /// the size limit is 5 MB per attachment.
        /// </para>
        /// </summary>
        public List<Attachment> Attachments
        {
            get { return this._attachments; }
            set { this._attachments = value; }
        }

        // Check to see if Attachments property is set
        internal bool IsSetAttachments()
        {
            return this._attachments != null && this._attachments.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AttachmentSetId. 
        /// <para>
        /// The ID of the attachment set. If an <code>AttachmentSetId</code> is not specified,
        /// a new attachment set is created, and the ID of the set is returned in the response.
        /// If an <code>AttachmentSetId</code> is specified, the attachments are added to the
        /// specified set, if it exists.
        /// </para>
        /// </summary>
        public string AttachmentSetId
        {
            get { return this._attachmentSetId; }
            set { this._attachmentSetId = value; }
        }

        // Check to see if AttachmentSetId property is set
        internal bool IsSetAttachmentSetId()
        {
            return this._attachmentSetId != null;
        }

    }
}