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

namespace Amazon.AWSSupport.Model
{
    /// <summary>
    /// This is the response object from the AddAttachmentsToSet operation.
    /// </summary>
    public partial class AddAttachmentsToSetResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AttachmentSetId. 
        /// <para>
        /// The ID of the attachment set. If an <c>attachmentSetId</c> was not specified, a new
        /// attachment set is created, and the ID of the set is returned in the response. If an
        /// <c>attachmentSetId</c> was specified, the attachments are added to the specified set,
        /// if it exists.
        /// </para>
        /// </summary>
        public string AttachmentSetId { get; set; }

        /// <summary>
        /// Checks to see if the AttachmentSetId property is set.
        /// </summary>
        internal bool IsSetAttachmentSetId() => this.AttachmentSetId != null;

        /// <summary>
        /// Gets and sets the property ExpiryTime. 
        /// <para>
        /// The time and date when the attachment set expires.
        /// </para>
        /// </summary>
        public string ExpiryTime { get; set; }

        /// <summary>
        /// Checks to see if the ExpiryTime property is set.
        /// </summary>
        internal bool IsSetExpiryTime() => this.ExpiryTime != null;
    }
}
