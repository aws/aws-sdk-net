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
    /// Information about the attached file.
    /// </summary>
    public partial class AttachedFile
    {
        private string _associatedResourceArn;
        private CreatedByInfo _createdBy;
        private string _creationTime;
        private string _fileArn;
        private string _fileId;
        private string _fileName;
        private long? _fileSizeInBytes;
        private FileStatusType _fileStatus;
        private FileUseCaseType _fileUseCaseType;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property AssociatedResourceArn. 
        /// <para>
        /// The resource to which the attached file is (being) uploaded to. <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_connect-cases_CreateCase.html">Cases</a>
        /// are the only current supported resource.
        /// </para>
        ///  <note> 
        /// <para>
        /// This value must be a valid ARN.
        /// </para>
        ///  </note>
        /// </summary>
        public string AssociatedResourceArn
        {
            get { return this._associatedResourceArn; }
            set { this._associatedResourceArn = value; }
        }

        // Check to see if AssociatedResourceArn property is set
        internal bool IsSetAssociatedResourceArn()
        {
            return this._associatedResourceArn != null;
        }

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
        [AWSProperty(Required=true)]
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
        [AWSProperty(Required=true)]
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
        [AWSProperty(Required=true, Min=1, Max=256)]
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
        /// Gets and sets the property FileName. 
        /// <para>
        /// A case-sensitive name of the attached file being uploaded.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string FileName
        {
            get { return this._fileName; }
            set { this._fileName = value; }
        }

        // Check to see if FileName property is set
        internal bool IsSetFileName()
        {
            return this._fileName != null;
        }

        /// <summary>
        /// Gets and sets the property FileSizeInBytes. 
        /// <para>
        /// The size of the attached file in bytes.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public long? FileSizeInBytes
        {
            get { return this._fileSizeInBytes; }
            set { this._fileSizeInBytes = value; }
        }

        // Check to see if FileSizeInBytes property is set
        internal bool IsSetFileSizeInBytes()
        {
            return this._fileSizeInBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FileStatus. 
        /// <para>
        /// The current status of the attached file.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property FileUseCaseType. 
        /// <para>
        /// The use case for the file.
        /// </para>
        /// </summary>
        public FileUseCaseType FileUseCaseType
        {
            get { return this._fileUseCaseType; }
            set { this._fileUseCaseType = value; }
        }

        // Check to see if FileUseCaseType property is set
        internal bool IsSetFileUseCaseType()
        {
            return this._fileUseCaseType != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags used to organize, track, or control access for this resource. For example,
        /// <c>{ "Tags": {"key1":"value1", "key2":"value2"} }</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
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