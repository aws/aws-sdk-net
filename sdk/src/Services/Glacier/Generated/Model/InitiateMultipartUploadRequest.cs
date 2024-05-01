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
 * Do not modify this file. This file is generated from the glacier-2012-06-01.normal.json service model.
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
namespace Amazon.Glacier.Model
{
    /// <summary>
    /// Container for the parameters to the InitiateMultipartUpload operation.
    /// This operation initiates a multipart upload. Amazon S3 Glacier creates a multipart
    /// upload resource and returns its ID in the response. The multipart upload ID is used
    /// in subsequent requests to upload parts of an archive (see <a>UploadMultipartPart</a>).
    /// 
    ///  
    /// <para>
    /// When you initiate a multipart upload, you specify the part size in number of bytes.
    /// The part size must be a megabyte (1024 KB) multiplied by a power of 2-for example,
    /// 1048576 (1 MB), 2097152 (2 MB), 4194304 (4 MB), 8388608 (8 MB), and so on. The minimum
    /// allowable part size is 1 MB, and the maximum is 4 GB.
    /// </para>
    ///  
    /// <para>
    /// Every part you upload to this resource (see <a>UploadMultipartPart</a>), except the
    /// last one, must have the same size. The last one can be the same size or smaller. For
    /// example, suppose you want to upload a 16.2 MB file. If you initiate the multipart
    /// upload with a part size of 4 MB, you will upload four parts of 4 MB each and one part
    /// of 0.2 MB. 
    /// </para>
    ///  <note> 
    /// <para>
    /// You don't need to know the size of the archive when you start a multipart upload because
    /// Amazon S3 Glacier does not require you to specify the overall archive size.
    /// </para>
    ///  </note> 
    /// <para>
    /// After you complete the multipart upload, Amazon S3 Glacier (Glacier) removes the multipart
    /// upload resource referenced by the ID. Glacier also removes the multipart upload resource
    /// if you cancel the multipart upload or it may be removed if there is no activity for
    /// a period of 24 hours.
    /// </para>
    ///  
    /// <para>
    /// An AWS account has full permission to perform all operations (actions). However, AWS
    /// Identity and Access Management (IAM) users don't have any permissions by default.
    /// You must grant them explicit permission to perform specific actions. For more information,
    /// see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
    /// Control Using AWS Identity and Access Management (IAM)</a>.
    /// </para>
    ///  
    /// <para>
    /// For conceptual information and underlying REST API, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/uploading-archive-mpu.html">Uploading
    /// Large Archives in Parts (Multipart Upload)</a> and <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/api-multipart-initiate-upload.html">Initiate
    /// Multipart Upload</a> in the <i>Amazon Glacier Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class InitiateMultipartUploadRequest : AmazonGlacierRequest
    {
        private string _accountId;
        private string _archiveDescription;
        private long? _partSize;
        private string _vaultName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public InitiateMultipartUploadRequest() { }

        /// <summary>
        /// Instantiates InitiateMultipartUploadRequest with the parameterized properties
        /// </summary>
        /// <param name="vaultName">The name of the vault.</param>
        /// <param name="archiveDescription">The archive description that you are uploading in parts. The part size must be a megabyte (1024 KB) multiplied by a power of 2, for example 1048576 (1 MB), 2097152 (2 MB), 4194304 (4 MB), 8388608 (8 MB), and so on. The minimum allowable part size is 1 MB, and the maximum is 4 GB (4096 MB).</param>
        /// <param name="partSize">The size of each part except the last, in bytes. The last part can be smaller than this part size.</param>
        public InitiateMultipartUploadRequest(string vaultName, string archiveDescription, long? partSize)
        {
            _vaultName = vaultName;
            _archiveDescription = archiveDescription;
            _partSize = partSize;
        }

        /// <summary>
        /// Instantiates InitiateMultipartUploadRequest with the parameterized properties
        /// </summary>
        /// <param name="accountId">The <c>AccountId</c> value is the AWS account ID of the account that owns the vault. You can either specify an AWS account ID or optionally a single '<c>-</c>' (hyphen), in which case Amazon S3 Glacier uses the AWS account ID associated with the credentials used to sign the request. If you use an account ID, do not include any hyphens ('-') in the ID. </param>
        /// <param name="vaultName">The name of the vault.</param>
        /// <param name="archiveDescription">The archive description that you are uploading in parts. The part size must be a megabyte (1024 KB) multiplied by a power of 2, for example 1048576 (1 MB), 2097152 (2 MB), 4194304 (4 MB), 8388608 (8 MB), and so on. The minimum allowable part size is 1 MB, and the maximum is 4 GB (4096 MB).</param>
        /// <param name="partSize">The size of each part except the last, in bytes. The last part can be smaller than this part size.</param>
        public InitiateMultipartUploadRequest(string accountId, string vaultName, string archiveDescription, long? partSize)
        {
            _accountId = accountId;
            _vaultName = vaultName;
            _archiveDescription = archiveDescription;
            _partSize = partSize;
        }

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The <c>AccountId</c> value is the AWS account ID of the account that owns the vault.
        /// You can either specify an AWS account ID or optionally a single '<c>-</c>' (hyphen),
        /// in which case Amazon S3 Glacier uses the AWS account ID associated with the credentials
        /// used to sign the request. If you use an account ID, do not include any hyphens ('-')
        /// in the ID. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property ArchiveDescription. 
        /// <para>
        /// The archive description that you are uploading in parts.
        /// </para>
        ///  
        /// <para>
        /// The part size must be a megabyte (1024 KB) multiplied by a power of 2, for example
        /// 1048576 (1 MB), 2097152 (2 MB), 4194304 (4 MB), 8388608 (8 MB), and so on. The minimum
        /// allowable part size is 1 MB, and the maximum is 4 GB (4096 MB).
        /// </para>
        /// </summary>
        public string ArchiveDescription
        {
            get { return this._archiveDescription; }
            set { this._archiveDescription = value; }
        }

        // Check to see if ArchiveDescription property is set
        internal bool IsSetArchiveDescription()
        {
            return this._archiveDescription != null;
        }

        /// <summary>
        /// Gets and sets the property PartSize. 
        /// <para>
        /// The size of each part except the last, in bytes. The last part can be smaller than
        /// this part size.
        /// </para>
        /// </summary>
        public long? PartSize
        {
            get { return this._partSize; }
            set { this._partSize = value; }
        }

        // Check to see if PartSize property is set
        internal bool IsSetPartSize()
        {
            return this._partSize != null;
        }

        /// <summary>
        /// Gets and sets the property VaultName. 
        /// <para>
        /// The name of the vault.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string VaultName
        {
            get { return this._vaultName; }
            set { this._vaultName = value; }
        }

        // Check to see if VaultName property is set
        internal bool IsSetVaultName()
        {
            return this._vaultName != null;
        }

    }
}