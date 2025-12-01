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
 * Do not modify this file. This file is generated from the partnercentral-benefits-2018-05-10.normal.json service model.
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
namespace Amazon.PartnerCentralBenefits.Model
{
    /// <summary>
    /// Represents detailed information about a file attached to a benefit application.
    /// </summary>
    public partial class FileDetail
    {
        private string _businessUseCase;
        private DateTime? _createdAt;
        private string _createdBy;
        private string _fileName;
        private string _fileStatus;
        private string _fileStatusReason;
        private FileType _fileType;
        private string _fileURI;

        /// <summary>
        /// Gets and sets the property BusinessUseCase. 
        /// <para>
        /// The business purpose or use case that this file supports in the benefit application.
        /// </para>
        /// </summary>
        public string BusinessUseCase
        {
            get { return this._businessUseCase; }
            set { this._businessUseCase = value; }
        }

        // Check to see if BusinessUseCase property is set
        internal bool IsSetBusinessUseCase()
        {
            return this._businessUseCase != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the file was uploaded.
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The identifier of the user who uploaded the file.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string CreatedBy
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
        /// Gets and sets the property FileName. 
        /// <para>
        /// The original name of the uploaded file.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property FileStatus. 
        /// <para>
        /// The current processing status of the file (e.g., uploaded, processing, approved, rejected).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public string FileStatus
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
        /// Gets and sets the property FileStatusReason. 
        /// <para>
        /// The reason for that particulat file status.
        /// </para>
        /// </summary>
        public string FileStatusReason
        {
            get { return this._fileStatusReason; }
            set { this._fileStatusReason = value; }
        }

        // Check to see if FileStatusReason property is set
        internal bool IsSetFileStatusReason()
        {
            return this._fileStatusReason != null;
        }

        /// <summary>
        /// Gets and sets the property FileType. 
        /// <para>
        /// The type or category of the file (e.g., document, image, spreadsheet).
        /// </para>
        /// </summary>
        public FileType FileType
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
        /// Gets and sets the property FileURI. 
        /// <para>
        /// The URI or location where the file is stored.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2000)]
        public string FileURI
        {
            get { return this._fileURI; }
            set { this._fileURI = value; }
        }

        // Check to see if FileURI property is set
        internal bool IsSetFileURI()
        {
            return this._fileURI != null;
        }

    }
}