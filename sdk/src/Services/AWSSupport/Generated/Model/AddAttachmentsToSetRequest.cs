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
 * Do not modify this file. This file is generated from the support-2013-04-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AWSSupport.Model
{
    /// <summary>
    /// Container for the parameters to the AddAttachmentsToSet operation.
    /// Adds one or more attachments to an attachment set. 
    /// 
    ///  
    /// <para>
    /// An attachment set is a temporary container for attachments that you add to a case
    /// or case communication. The set is available for 1 hour after it's created. The <code>expiryTime</code>
    /// returned in the response is when the set expires. 
    /// </para>
    ///  <note> <ul> <li> 
    /// <para>
    /// You must have a Business, Enterprise On-Ramp, or Enterprise Support plan to use the
    /// Amazon Web Services Support API. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you call the Amazon Web Services Support API from an account that doesn't have
    /// a Business, Enterprise On-Ramp, or Enterprise Support plan, the <code>SubscriptionRequiredException</code>
    /// error message appears. For information about changing your support plan, see <a href="http://aws.amazon.com/premiumsupport/">Amazon
    /// Web Services Support</a>.
    /// </para>
    ///  </li> </ul> </note>
    /// </summary>
    public partial class AddAttachmentsToSetRequest : AmazonAWSSupportRequest
    {
        private List<Attachment> _attachments = new List<Attachment>();
        private string _attachmentSetId;

        /// <summary>
        /// Gets and sets the property Attachments. 
        /// <para>
        /// One or more attachments to add to the set. You can add up to three attachments per
        /// set. The size limit is 5 MB per attachment.
        /// </para>
        ///  
        /// <para>
        /// In the <code>Attachment</code> object, use the <code>data</code> parameter to specify
        /// the contents of the attachment file. In the previous request syntax, the value for
        /// <code>data</code> appear as <code>blob</code>, which is represented as a base64-encoded
        /// string. The value for <code>fileName</code> is the name of the attachment, such as
        /// <code>troubleshoot-screenshot.png</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The ID of the attachment set. If an <code>attachmentSetId</code> is not specified,
        /// a new attachment set is created, and the ID of the set is returned in the response.
        /// If an <code>attachmentSetId</code> is specified, the attachments are added to the
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