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

namespace Amazon.Glacier.Model
{
    /// <summary>
    /// Container for the parameters to the UploadMultipartPart operation. This operation
    /// uploads a part of an archive. You can upload archive parts in any order. You can also
    /// upload them in parallel. You can upload up to 10,000 parts for a multipart upload.
    /// <para> Amazon Glacier rejects your upload part request if any of the following conditions
    /// is true: </para> <ul> <li> <para> <b>SHA256 tree hash does not match</b>To ensure
    /// that part data is not corrupted in transmission, you compute a SHA256 tree hash of
    /// the part and include it in your request. Upon receiving the part data, Amazon Glacier
    /// also computes a SHA256 tree hash. If these hash values don't match, the operation
    /// fails. For information about computing a SHA256 tree hash, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/checksum-calculations.html">Computing
    /// Checksums</a>. </para> </li> <li> <para> <b>Part size does not match</b>The size of
    /// each part except the last must match the size specified in the corresponding <a>InitiateMultipartUpload</a>
    /// request. The size of the last part must be the same size as, or smaller than, the
    /// specified size. </para> <note> <para> If you upload a part whose size is smaller than
    /// the part size you specified in your initiate multipart upload request and that part
    /// is not the last part, then the upload part request will succeed. However, the subsequent
    /// Complete Multipart Upload request will fail. </para> </note> </li> <li> <para> <b>Range
    /// does not align</b>The byte range value in the request does not align with the part
    /// size specified in the corresponding initiate request. For example, if you specify
    /// a part size of 4194304 bytes (4 MB), then 0 to 4194303 bytes (4 MB - 1) and 4194304
    /// (4 MB) to 8388607 (8 MB - 1) are valid part ranges. However, if you set a range value
    /// of 2 MB to 6 MB, the range does not align with the part size and the upload will fail.
    /// </para> </li> </ul> <para> This operation is idempotent. If you upload the same part
    /// multiple times, the data included in the most recent request overwrites the previously
    /// uploaded data. </para> <para> An AWS account has full permission to perform all operations
    /// (actions). However, AWS Identity and Access Management (IAM) users don't have any
    /// permissions by default. You must grant them explicit permission to perform specific
    /// actions. For more information, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
    /// Control Using AWS Identity and Access Management (IAM)</a>. </para> <para> For conceptual
    /// information and underlying REST API, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/uploading-archive-mpu.html">Uploading
    /// Large Archives in Parts (Multipart Upload)</a> and <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/api-upload-part.html">Upload
    /// Part </a> in the <i>Amazon Glacier Developer Guide</i>. </para>
    /// </summary>
    public partial class UploadMultipartPartRequest : AmazonGlacierRequest
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public UploadMultipartPartRequest() { }

        /// <summary>
        /// Instantiates UploadMultipartPartRequest with the parameterized properties
        /// </summary>
        /// <param name="vaultName">The name of the vault.</param>
        /// <param name="uploadId">The upload ID of the multipart upload.</param>
        /// <param name="checksum">The SHA256 tree hash of the data being uploaded.</param>
        /// <param name="range">Identifies the range of bytes in the assembled archive that will be uploaded in this   part. Amazon Glacier uses this information to assemble the archive in the proper sequence.   The format of this header follows RFC 2616. An example header is Content-Range:bytes   0-4194303/*.</param>
        /// <param name="body">The data to upload.</param>
        public UploadMultipartPartRequest(string vaultName, string uploadId, string checksum, string range, Stream body)
        {
            this.VaultName = vaultName;
            this.UploadId = uploadId;
            this.Checksum = checksum;
            this.Range = range;
            this.Body = body;
        }

        /// <summary>
        /// Instantiates UploadMultipartPartRequest with the parameterized properties
        /// </summary>
        /// <param name="accountId">The <c>AccountId</c> value is the AWS account ID of the account that owns the   vault. You can either specify an AWS account ID or optionally a single '<c>-</c>'   (hyphen), in which case Amazon Glacier uses the AWS account ID associated with the   credentials used to sign the request. If you use an account ID, do not include any hyphens   ('-') in the ID. </param>
        /// <param name="vaultName">The name of the vault.</param>
        /// <param name="uploadId">The upload ID of the multipart upload.</param>
        /// <param name="checksum">The SHA256 tree hash of the data being uploaded.</param>
        /// <param name="range">Identifies the range of bytes in the assembled archive that will be uploaded in this   part. Amazon Glacier uses this information to assemble the archive in the proper sequence.   The format of this header follows RFC 2616. An example header is Content-Range:bytes   0-4194303/*.</param>
        /// <param name="body">The data to upload.</param>
        public UploadMultipartPartRequest(string accountId, string vaultName, string uploadId, string checksum, string range, Stream body)
        {
            this.AccountId = accountId;
            this.VaultName = vaultName;
            this.UploadId = uploadId;
            this.Checksum = checksum;
            this.Range = range;
            this.Body = body;
        }

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The <c>AccountId</c> value is the AWS account ID of the account that owns the vault.
        /// You can either specify an AWS account ID or optionally a single '<c>-</c>' (hyphen),
        /// in which case Amazon Glacier uses the AWS account ID associated with the credentials
        /// used to sign the request. If you use an account ID, do not include any hyphens ('-')
        /// in the ID. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property Body. 
        /// <para>
        /// The data to upload.
        /// </para>
        /// </summary>
        public Stream Body { get; set; }

        /// <summary>
        /// Checks to see if the Body property is set.
        /// </summary>
        internal bool IsSetBody() => this.Body != null;

        /// <summary>
        /// Gets and sets the property Checksum. 
        /// <para>
        /// The SHA256 tree hash of the data being uploaded.
        /// </para>
        /// </summary>
        public string Checksum { get; set; }

        /// <summary>
        /// Checks to see if the Checksum property is set.
        /// </summary>
        internal bool IsSetChecksum() => this.Checksum != null;

        /// <summary>
        /// Gets and sets the property Range. 
        /// <para>
        /// Identifies the range of bytes in the assembled archive that will be uploaded in this
        /// part. Amazon Glacier uses this information to assemble the archive in the proper sequence.
        /// The format of this header follows RFC 2616. An example header is Content-Range:bytes
        /// 0-4194303/*.
        /// </para>
        /// </summary>
        public string Range { get; set; }

        /// <summary>
        /// Checks to see if the Range property is set.
        /// </summary>
        internal bool IsSetRange() => this.Range != null;

        /// <summary>
        /// Gets and sets the property UploadId. 
        /// <para>
        /// The upload ID of the multipart upload.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string UploadId { get; set; }

        /// <summary>
        /// Checks to see if the UploadId property is set.
        /// </summary>
        internal bool IsSetUploadId() => this.UploadId != null;

        /// <summary>
        /// Gets and sets the property VaultName. 
        /// <para>
        /// The name of the vault.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string VaultName { get; set; }

        /// <summary>
        /// Checks to see if the VaultName property is set.
        /// </summary>
        internal bool IsSetVaultName() => this.VaultName != null;
    }
}
