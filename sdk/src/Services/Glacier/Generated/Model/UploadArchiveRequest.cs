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
    /// Container for the parameters to the UploadArchive operation.
    /// This operation adds an archive to a vault. This is a synchronous operation, and for
    /// a successful upload, your data is durably persisted. Amazon S3 Glacier returns the
    /// archive ID in the <c>x-amz-archive-id</c> header of the response. 
    /// 
    ///  
    /// <para>
    /// You must use the archive ID to access your data in Amazon S3 Glacier. After you upload
    /// an archive, you should save the archive ID returned so that you can retrieve or delete
    /// the archive later. Besides saving the archive ID, you can also index it and give it
    /// a friendly name to allow for better searching. You can also use the optional archive
    /// description field to specify how the archive is referred to in an external index of
    /// archives, such as you might create in Amazon DynamoDB. You can also get the vault
    /// inventory to obtain a list of archive IDs in a vault. For more information, see <a>InitiateJob</a>.
    /// 
    /// </para>
    ///  
    /// <para>
    /// You must provide a SHA256 tree hash of the data you are uploading. For information
    /// about computing a SHA256 tree hash, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/checksum-calculations.html">Computing
    /// Checksums</a>. 
    /// </para>
    ///  
    /// <para>
    /// You can optionally specify an archive description of up to 1,024 printable ASCII characters.
    /// You can get the archive description when you either retrieve the archive or get the
    /// vault inventory. For more information, see <a>InitiateJob</a>. Amazon Glacier does
    /// not interpret the description in any way. An archive description does not need to
    /// be unique. You cannot use the description to retrieve or sort the archive list. 
    /// </para>
    ///  
    /// <para>
    /// Archives are immutable. After you upload an archive, you cannot edit the archive or
    /// its description.
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
    ///  For conceptual information and underlying REST API, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/uploading-an-archive.html">Uploading
    /// an Archive in Amazon Glacier</a> and <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/api-archive-post.html">Upload
    /// Archive</a> in the <i>Amazon Glacier Developer Guide</i>. 
    /// </para>
    /// </summary>
    public partial class UploadArchiveRequest : AmazonGlacierRequest
    {
        private string _accountId;
        private string _archiveDescription;
        private Stream _body;
        private string _checksum;
        private string _vaultName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public UploadArchiveRequest() { }

        /// <summary>
        /// Instantiates UploadArchiveRequest with the parameterized properties
        /// </summary>
        /// <param name="vaultName">The name of the vault.</param>
        /// <param name="archiveDescription">The optional description of the archive you are uploading.</param>
        /// <param name="checksum">The SHA256 tree hash of the data being uploaded.</param>
        /// <param name="body">The data to upload.</param>
        public UploadArchiveRequest(string vaultName, string archiveDescription, string checksum, Stream body)
        {
            _vaultName = vaultName;
            _archiveDescription = archiveDescription;
            _checksum = checksum;
            _body = body;
        }

        /// <summary>
        /// Instantiates UploadArchiveRequest with the parameterized properties
        /// </summary>
        /// <param name="accountId">The <c>AccountId</c> value is the AWS account ID of the account that owns the vault. You can either specify an AWS account ID or optionally a single '<c>-</c>' (hyphen), in which case Amazon S3 Glacier uses the AWS account ID associated with the credentials used to sign the request. If you use an account ID, do not include any hyphens ('-') in the ID. </param>
        /// <param name="vaultName">The name of the vault.</param>
        /// <param name="archiveDescription">The optional description of the archive you are uploading.</param>
        /// <param name="checksum">The SHA256 tree hash of the data being uploaded.</param>
        /// <param name="body">The data to upload.</param>
        public UploadArchiveRequest(string accountId, string vaultName, string archiveDescription, string checksum, Stream body)
        {
            _accountId = accountId;
            _vaultName = vaultName;
            _archiveDescription = archiveDescription;
            _checksum = checksum;
            _body = body;
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
        /// The optional description of the archive you are uploading.
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
        /// Gets and sets the property Body. 
        /// <para>
        /// The data to upload.
        /// </para>
        /// </summary>
        public Stream Body
        {
            get { return this._body; }
            set { this._body = value; }
        }

        // Check to see if Body property is set
        internal bool IsSetBody()
        {
            return this._body != null;
        }

        /// <summary>
        /// Gets and sets the property Checksum. 
        /// <para>
        /// The SHA256 tree hash of the data being uploaded.
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