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

namespace Amazon.PartnerCentralBenefits.Model
{
    /// <summary>
    /// Represents detailed information about a file attached to a benefit application.
    /// </summary>
    public partial class FileDetail
    {
        /// <summary>
        /// Gets and sets the property BusinessUseCase. 
        /// <para>
        /// The business purpose or use case that this file supports in the benefit application.
        /// </para>
        /// </summary>
        public string BusinessUseCase { get; set; }

        /// <summary>
        /// Checks to see if the BusinessUseCase property is set.
        /// </summary>
        internal bool IsSetBusinessUseCase() => this.BusinessUseCase != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the file was uploaded.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The identifier of the user who uploaded the file.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property FileName. 
        /// <para>
        /// The original name of the uploaded file.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string FileName { get; set; }

        /// <summary>
        /// Checks to see if the FileName property is set.
        /// </summary>
        internal bool IsSetFileName() => this.FileName != null;

        /// <summary>
        /// Gets and sets the property FileStatus. 
        /// <para>
        /// The current processing status of the file (e.g., uploaded, processing, approved, rejected).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public string FileStatus { get; set; }

        /// <summary>
        /// Checks to see if the FileStatus property is set.
        /// </summary>
        internal bool IsSetFileStatus() => this.FileStatus != null;

        /// <summary>
        /// Gets and sets the property FileStatusReason. 
        /// <para>
        /// The reason for that particulat file status.
        /// </para>
        /// </summary>
        public string FileStatusReason { get; set; }

        /// <summary>
        /// Checks to see if the FileStatusReason property is set.
        /// </summary>
        internal bool IsSetFileStatusReason() => this.FileStatusReason != null;

        /// <summary>
        /// Gets and sets the property FileType. 
        /// <para>
        /// The type or category of the file (e.g., document, image, spreadsheet).
        /// </para>
        /// </summary>
        public FileType FileType { get; set; }

        /// <summary>
        /// Checks to see if the FileType property is set.
        /// </summary>
        internal bool IsSetFileType() => this.FileType != null;

        /// <summary>
        /// Gets and sets the property FileURI. 
        /// <para>
        /// The URI or location where the file is stored.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2000)]
        public string FileURI { get; set; }

        /// <summary>
        /// Checks to see if the FileURI property is set.
        /// </summary>
        internal bool IsSetFileURI() => this.FileURI != null;
    }
}
