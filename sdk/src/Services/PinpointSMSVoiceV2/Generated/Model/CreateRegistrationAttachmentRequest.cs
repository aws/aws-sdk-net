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
 * Do not modify this file. This file is generated from the pinpoint-sms-voice-v2-2022-03-31.normal.json service model.
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
namespace Amazon.PinpointSMSVoiceV2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateRegistrationAttachment operation.
    /// Create a new registration attachment to use for uploading a file or a URL to a file.
    /// The maximum file size is 1MiB and valid file extensions are PDF, JPEG and PNG. For
    /// example, many sender ID registrations require a signed “letter of authorization” (LOA)
    /// to be submitted.
    /// </summary>
    public partial class CreateRegistrationAttachmentRequest : AmazonPinpointSMSVoiceV2Request
    {
        private MemoryStream _attachmentBody;
        private string _attachmentUrl;
        private string _clientToken;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property AttachmentBody. 
        /// <para>
        /// The registration file to upload. The maximum file size is 1MiB and valid file extensions
        /// are PDF, JPEG and PNG.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1572864)]
        public MemoryStream AttachmentBody
        {
            get { return this._attachmentBody; }
            set { this._attachmentBody = value; }
        }

        // Check to see if AttachmentBody property is set
        internal bool IsSetAttachmentBody()
        {
            return this._attachmentBody != null;
        }

        /// <summary>
        /// Gets and sets the property AttachmentUrl. 
        /// <para>
        /// A URL to the required registration file. For example, you can provide the S3 object
        /// URL.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string AttachmentUrl
        {
            get { return this._attachmentUrl; }
            set { this._attachmentUrl = value; }
        }

        // Check to see if AttachmentUrl property is set
        internal bool IsSetAttachmentUrl()
        {
            return this._attachmentUrl != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request. If you don't specify a client token, a randomly generated token is used for
        /// the request to ensure idempotency.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of tags (key and value pairs) to associate with the registration attachment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}