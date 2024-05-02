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
    /// Container for the parameters to the CompleteMultipartUpload operation.
    /// You call this operation to inform Amazon S3 Glacier (Glacier) that all the archive
    /// parts have been uploaded and that Glacier can now assemble the archive from the uploaded
    /// parts. After assembling and saving the archive to the vault, Glacier returns the URI
    /// path of the newly created archive resource. Using the URI path, you can then access
    /// the archive. After you upload an archive, you should save the archive ID returned
    /// to retrieve the archive at a later point. You can also get the vault inventory to
    /// obtain a list of archive IDs in a vault. For more information, see <a>InitiateJob</a>.
    /// 
    ///  
    /// <para>
    /// In the request, you must include the computed SHA256 tree hash of the entire archive
    /// you have uploaded. For information about computing a SHA256 tree hash, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/checksum-calculations.html">Computing
    /// Checksums</a>. On the server side, Glacier also constructs the SHA256 tree hash of
    /// the assembled archive. If the values match, Glacier saves the archive to the vault;
    /// otherwise, it returns an error, and the operation fails. The <a>ListParts</a> operation
    /// returns a list of parts uploaded for a specific multipart upload. It includes checksum
    /// information for each uploaded part that can be used to debug a bad checksum issue.
    /// </para>
    ///  
    /// <para>
    /// Additionally, Glacier also checks for any missing content ranges when assembling the
    /// archive, if missing content ranges are found, Glacier returns an error and the operation
    /// fails.
    /// </para>
    ///  
    /// <para>
    /// Complete Multipart Upload is an idempotent operation. After your first successful
    /// complete multipart upload, if you call the operation again within a short period,
    /// the operation will succeed and return the same archive ID. This is useful in the event
    /// you experience a network issue that causes an aborted connection or receive a 500
    /// server error, in which case you can repeat your Complete Multipart Upload request
    /// and get the same archive ID without creating duplicate archives. Note, however, that
    /// after the multipart upload completes, you cannot call the List Parts operation and
    /// the multipart upload will not appear in List Multipart Uploads response, even if idempotent
    /// complete is possible.
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
    ///  For conceptual information and underlying REST API, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/uploading-archive-mpu.html">Uploading
    /// Large Archives in Parts (Multipart Upload)</a> and <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/api-multipart-complete-upload.html">Complete
    /// Multipart Upload</a> in the <i>Amazon Glacier Developer Guide</i>. 
    /// </para>
    /// </summary>
    public partial class CompleteMultipartUploadRequest : AmazonGlacierRequest
    {
        private string _accountId;
        private string _archiveSize;
        private string _checksum;
        private string _uploadId;
        private string _vaultName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CompleteMultipartUploadRequest() { }

        /// <summary>
        /// Instantiates CompleteMultipartUploadRequest with the parameterized properties
        /// </summary>
        /// <param name="vaultName">The name of the vault.</param>
        /// <param name="uploadId">The upload ID of the multipart upload.</param>
        /// <param name="archiveSize">The total size, in bytes, of the entire archive. This value should be the sum of all the sizes of the individual parts that you uploaded.</param>
        /// <param name="checksum">The SHA256 tree hash of the entire archive. It is the tree hash of SHA256 tree hash of the individual parts. If the value you specify in the request does not match the SHA256 tree hash of the final assembled archive as computed by Amazon S3 Glacier (Glacier), Glacier returns an error and the request fails.</param>
        public CompleteMultipartUploadRequest(string vaultName, string uploadId, string archiveSize, string checksum)
        {
            _vaultName = vaultName;
            _uploadId = uploadId;
            _archiveSize = archiveSize;
            _checksum = checksum;
        }

        /// <summary>
        /// Instantiates CompleteMultipartUploadRequest with the parameterized properties
        /// </summary>
        /// <param name="accountId">The <c>AccountId</c> value is the AWS account ID of the account that owns the vault. You can either specify an AWS account ID or optionally a single '<c>-</c>' (hyphen), in which case Amazon S3 Glacier uses the AWS account ID associated with the credentials used to sign the request. If you use an account ID, do not include any hyphens ('-') in the ID.</param>
        /// <param name="vaultName">The name of the vault.</param>
        /// <param name="uploadId">The upload ID of the multipart upload.</param>
        /// <param name="archiveSize">The total size, in bytes, of the entire archive. This value should be the sum of all the sizes of the individual parts that you uploaded.</param>
        /// <param name="checksum">The SHA256 tree hash of the entire archive. It is the tree hash of SHA256 tree hash of the individual parts. If the value you specify in the request does not match the SHA256 tree hash of the final assembled archive as computed by Amazon S3 Glacier (Glacier), Glacier returns an error and the request fails.</param>
        public CompleteMultipartUploadRequest(string accountId, string vaultName, string uploadId, string archiveSize, string checksum)
        {
            _accountId = accountId;
            _vaultName = vaultName;
            _uploadId = uploadId;
            _archiveSize = archiveSize;
            _checksum = checksum;
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
        /// Gets and sets the property ArchiveSize. 
        /// <para>
        /// The total size, in bytes, of the entire archive. This value should be the sum of all
        /// the sizes of the individual parts that you uploaded.
        /// </para>
        /// </summary>
        public string ArchiveSize
        {
            get { return this._archiveSize; }
            set { this._archiveSize = value; }
        }

        // Check to see if ArchiveSize property is set
        internal bool IsSetArchiveSize()
        {
            return this._archiveSize != null;
        }

        /// <summary>
        /// Gets and sets the property Checksum. 
        /// <para>
        /// The SHA256 tree hash of the entire archive. It is the tree hash of SHA256 tree hash
        /// of the individual parts. If the value you specify in the request does not match the
        /// SHA256 tree hash of the final assembled archive as computed by Amazon S3 Glacier (Glacier),
        /// Glacier returns an error and the request fails.
        /// </para>
        /// </summary>
        public string Checksum
        {
            get { return this._checksum; }
            set { this._checksum = value; }
        }

        // Check to see if Checksum property is set
        internal bool IsSetChecksum()
        {
            return this._checksum != null;
        }

        /// <summary>
        /// Gets and sets the property UploadId. 
        /// <para>
        /// The upload ID of the multipart upload.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string UploadId
        {
            get { return this._uploadId; }
            set { this._uploadId = value; }
        }

        // Check to see if UploadId property is set
        internal bool IsSetUploadId()
        {
            return this._uploadId != null;
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