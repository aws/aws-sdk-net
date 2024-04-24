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
    /// Container for the parameters to the AbortMultipartUpload operation.
    /// This operation aborts a multipart upload identified by the upload ID.
    /// 
    ///  
    /// <para>
    /// After the Abort Multipart Upload request succeeds, you cannot upload any more parts
    /// to the multipart upload or complete the multipart upload. Aborting a completed upload
    /// fails. However, aborting an already-aborted upload will succeed, for a short time.
    /// For more information about uploading a part and completing a multipart upload, see
    /// <a>UploadMultipartPart</a> and <a>CompleteMultipartUpload</a>.
    /// </para>
    ///  
    /// <para>
    /// This operation is idempotent.
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
    ///  For conceptual information and underlying REST API, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/working-with-archives.html">Working
    /// with Archives in Amazon S3 Glacier</a> and <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/api-multipart-abort-upload.html">Abort
    /// Multipart Upload</a> in the <i>Amazon Glacier Developer Guide</i>. 
    /// </para>
    /// </summary>
    public partial class AbortMultipartUploadRequest : AmazonGlacierRequest
    {
        private string _accountId;
        private string _uploadId;
        private string _vaultName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public AbortMultipartUploadRequest() { }

        /// <summary>
        /// Instantiates AbortMultipartUploadRequest with the parameterized properties
        /// </summary>
        /// <param name="vaultName">The name of the vault.</param>
        /// <param name="uploadId">The upload ID of the multipart upload to delete.</param>
        public AbortMultipartUploadRequest(string vaultName, string uploadId)
        {
            _vaultName = vaultName;
            _uploadId = uploadId;
        }

        /// <summary>
        /// Instantiates AbortMultipartUploadRequest with the parameterized properties
        /// </summary>
        /// <param name="accountId">The <c>AccountId</c> value is the AWS account ID of the account that owns the vault. You can either specify an AWS account ID or optionally a single '<c>-</c>' (hyphen), in which case Amazon S3 Glacier uses the AWS account ID associated with the credentials used to sign the request. If you use an account ID, do not include any hyphens ('-') in the ID.</param>
        /// <param name="vaultName">The name of the vault.</param>
        /// <param name="uploadId">The upload ID of the multipart upload to delete.</param>
        public AbortMultipartUploadRequest(string accountId, string vaultName, string uploadId)
        {
            _accountId = accountId;
            _vaultName = vaultName;
            _uploadId = uploadId;
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
        /// Gets and sets the property UploadId. 
        /// <para>
        /// The upload ID of the multipart upload to delete.
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