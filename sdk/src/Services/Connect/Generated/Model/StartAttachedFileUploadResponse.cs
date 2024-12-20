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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Response from StartAttachedFileUpload API.
    /// </summary>
    public partial class StartAttachedFileUploadResponse : AmazonWebServiceResponse
    {
        private CreatedByInfo _createdBy;
        private string _creationTime;
        private string _fileArn;
        private string _fileId;
        private FileStatusType _fileStatus;
        private UploadUrlMetadata _uploadUrlMetadata;

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// Represents the identity that created the file.
        /// </para>
        /// </summary>
        public CreatedByInfo CreatedBy
        {
            get { return this._createdBy; }
            set { this._createdBy = value; }
        }

        // Check to see if CreatedBy property is set
        internal bool IsSetCreatedBy()
        {
            return this._createdBy != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time of Creation of the file resource as an ISO timestamp. It's specified in ISO
        /// 8601 format: <c>yyyy-MM-ddThh:mm:ss.SSSZ</c>. For example, <c>2024-05-03T02:41:28.172Z</c>.
        /// </para>
        /// </summary>
        public string CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime != null;
        }

        /// <summary>
        /// Gets and sets the property FileArn. 
        /// <para>
        /// The unique identifier of the attached file resource (ARN).
        /// </para>
        /// </summary>
        public string FileArn
        {
            get { return this._fileArn; }
            set { this._fileArn = value; }
        }

        // Check to see if FileArn property is set
        internal bool IsSetFileArn()
        {
            return this._fileArn != null;
        }

        /// <summary>
        /// Gets and sets the property FileId. 
        /// <para>
        /// The unique identifier of the attached file resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string FileId
        {
            get { return this._fileId; }
            set { this._fileId = value; }
        }

        // Check to see if FileId property is set
        internal bool IsSetFileId()
        {
            return this._fileId != null;
        }

        /// <summary>
        /// Gets and sets the property FileStatus. 
        /// <para>
        /// The current status of the attached file.
        /// </para>
        /// </summary>
        public FileStatusType FileStatus
        {
            get { return this._fileStatus; }
            set { this._fileStatus = value; }
        }

        // Check to see if FileStatus property is set
        internal bool IsSetFileStatus()
        {
            return this._fileStatus != null;
        }

        /// <summary>
        /// Gets and sets the property UploadUrlMetadata. 
        /// <para>
        /// The headers to be provided while uploading the file to the URL.
        /// </para>
        /// </summary>
        public UploadUrlMetadata UploadUrlMetadata
        {
            get { return this._uploadUrlMetadata; }
            set { this._uploadUrlMetadata = value; }
        }

        // Check to see if UploadUrlMetadata property is set
        internal bool IsSetUploadUrlMetadata()
        {
            return this._uploadUrlMetadata != null;
        }

    }
}