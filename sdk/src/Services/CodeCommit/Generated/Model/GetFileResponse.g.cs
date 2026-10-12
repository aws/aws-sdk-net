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

namespace Amazon.CodeCommit.Model
{
    /// <summary>
    /// This is the response object from the GetFile operation.
    /// </summary>
    public partial class GetFileResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property BlobId. 
        /// <para>
        /// The blob ID of the object that represents the file content.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string BlobId { get; set; }

        /// <summary>
        /// Checks to see if the BlobId property is set.
        /// </summary>
        internal bool IsSetBlobId() => this.BlobId != null;

        /// <summary>
        /// Gets and sets the property CommitId. 
        /// <para>
        /// The full commit ID of the commit that contains the content returned by GetFile.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CommitId { get; set; }

        /// <summary>
        /// Checks to see if the CommitId property is set.
        /// </summary>
        internal bool IsSetCommitId() => this.CommitId != null;

        /// <summary>
        /// Gets and sets the property FileContent. 
        /// <para>
        /// The base-64 encoded binary data object that represents the content of the file.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 6291456)]
        public MemoryStream FileContent { get; set; }

        /// <summary>
        /// Checks to see if the FileContent property is set.
        /// </summary>
        internal bool IsSetFileContent() => this.FileContent != null;

        /// <summary>
        /// Gets and sets the property FileMode. 
        /// <para>
        /// The extrapolated file mode permissions of the blob. Valid values include strings such
        /// as EXECUTABLE and not numeric values.
        /// </para>
        ///  <note> 
        /// <para>
        /// The file mode permissions returned by this API are not the standard file mode permission
        /// values, such as 100644, but rather extrapolated values. See the supported return values.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required = true)]
        public FileModeTypeEnum FileMode { get; set; }

        /// <summary>
        /// Checks to see if the FileMode property is set.
        /// </summary>
        internal bool IsSetFileMode() => this.FileMode != null;

        /// <summary>
        /// Gets and sets the property FilePath. 
        /// <para>
        /// The fully qualified path to the specified file. Returns the name and extension of
        /// the file.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string FilePath { get; set; }

        /// <summary>
        /// Checks to see if the FilePath property is set.
        /// </summary>
        internal bool IsSetFilePath() => this.FilePath != null;

        /// <summary>
        /// Gets and sets the property FileSize. 
        /// <para>
        /// The size of the contents of the file, in bytes.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? FileSize { get; set; }

        /// <summary>
        /// Checks to see if the FileSize property is set.
        /// </summary>
        internal bool IsSetFileSize() => this.FileSize.HasValue;
    }
}
