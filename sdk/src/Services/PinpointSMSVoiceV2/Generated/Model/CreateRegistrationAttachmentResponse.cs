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
    /// This is the response object from the CreateRegistrationAttachment operation.
    /// </summary>
    public partial class CreateRegistrationAttachmentResponse : AmazonWebServiceResponse
    {
        private AttachmentStatus _attachmentStatus;
        private DateTime? _createdTimestamp;
        private string _registrationAttachmentArn;
        private string _registrationAttachmentId;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property AttachmentStatus. 
        /// <para>
        /// The status of the registration attachment. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>UPLOAD_IN_PROGRESS</c> The attachment is being uploaded.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPLOAD_COMPLETE</c> The attachment has been uploaded.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPLOAD_FAILED</c> The attachment failed to uploaded.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETED</c> The attachment has been deleted..
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public AttachmentStatus AttachmentStatus
        {
            get { return this._attachmentStatus; }
            set { this._attachmentStatus = value; }
        }

        // Check to see if AttachmentStatus property is set
        internal bool IsSetAttachmentStatus()
        {
            return this._attachmentStatus != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The time when the registration attachment was created, in <a href="https://www.epochconverter.com/">UNIX
        /// epoch time</a> format.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedTimestamp
        {
            get { return this._createdTimestamp; }
            set { this._createdTimestamp = value; }
        }

        // Check to see if CreatedTimestamp property is set
        internal bool IsSetCreatedTimestamp()
        {
            return this._createdTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RegistrationAttachmentArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the registration attachment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RegistrationAttachmentArn
        {
            get { return this._registrationAttachmentArn; }
            set { this._registrationAttachmentArn = value; }
        }

        // Check to see if RegistrationAttachmentArn property is set
        internal bool IsSetRegistrationAttachmentArn()
        {
            return this._registrationAttachmentArn != null;
        }

        /// <summary>
        /// Gets and sets the property RegistrationAttachmentId. 
        /// <para>
        /// The unique identifier for the registration attachment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RegistrationAttachmentId
        {
            get { return this._registrationAttachmentId; }
            set { this._registrationAttachmentId = value; }
        }

        // Check to see if RegistrationAttachmentId property is set
        internal bool IsSetRegistrationAttachmentId()
        {
            return this._registrationAttachmentId != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of tags (key and value pairs) to associate with the registration attachment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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