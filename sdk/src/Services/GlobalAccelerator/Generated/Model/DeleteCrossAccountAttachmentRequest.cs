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
 * Do not modify this file. This file is generated from the globalaccelerator-2018-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GlobalAccelerator.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteCrossAccountAttachment operation.
    /// Delete a cross-account attachment. When you delete an attachment, Global Accelerator
    /// revokes the permission to use the resources in the attachment from all principals
    /// in the list of principals. Global Accelerator revokes the permission for specific
    /// resources by doing the following:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// If the principal is an account ID, Global Accelerator reviews every accelerator in
    /// the account and removes cross-account endpoints from all accelerators.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If the principal is an accelerator, Global Accelerator reviews just that accelerator
    /// and removes cross-account endpoints from it.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// If there are overlapping permissions provided by multiple cross-account attachments,
    /// Global Accelerator only removes endpoints if there are no current cross-account attachments
    /// that provide access permission. For example, if you delete a cross-account attachment
    /// that lists an accelerator as a principal, but another cross-account attachment includes
    /// the account ID that owns that accelerator, endpoints will not be removed from the
    /// accelerator.
    /// </para>
    /// </summary>
    public partial class DeleteCrossAccountAttachmentRequest : AmazonGlobalAcceleratorRequest
    {
        private string _attachmentArn;

        /// <summary>
        /// Gets and sets the property AttachmentArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the cross-account attachment to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=255)]
        public string AttachmentArn
        {
            get { return this._attachmentArn; }
            set { this._attachmentArn = value; }
        }

        // Check to see if AttachmentArn property is set
        internal bool IsSetAttachmentArn()
        {
            return this._attachmentArn != null;
        }

    }
}