/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glacier.Model
{
    /// <summary>
    /// Container for the parameters to the UploadMultipartPart operation.
    /// <para>This operation uploads a part of an archive. You can upload archive parts in any order. You can also upload them in parallel. You can
    /// upload up to 10,000 parts for a multipart upload.</para> <para>Amazon Glacier rejects your upload part request if any of the following
    /// conditions is true:</para>
    /// <ul>
    /// <li> <para> <b>SHA256 tree hash does not match</b> To ensure that part data is not corrupted in transmission, you compute a SHA256 tree
    /// hash of the part and include it in your request. Upon receiving the part data, Amazon Glacier also computes a SHA256 tree hash. If these
    /// hash values don't match, the operation fails. For information about computing a SHA256 tree hash, see <a
    /// href="http://docs.aws.amazon.com/amazonglacier/latest/dev/checksum-calculations.html" >Computing Checksums</a> .</para> </li>
    /// <li> <para> <b>Part size does not match</b> The size of each part except the last must match the size specified in the corresponding
    /// InitiateMultipartUpload request. The size of the last part must be the same size as, or smaller than, the specified size.</para>
    /// <para><b>NOTE:</b> If you upload a part whose size is smaller than the part size you specified in your initiate multipart upload request and
    /// that part is not the last part, then the upload part request will succeed. However, the subsequent Complete Multipart Upload request will
    /// fail. </para> </li>
    /// <li> <b>Range does not align</b> The byte range value in the request does not align with the part size specified in the corresponding
    /// initiate request. For example, if you specify a part size of 4194304 bytes (4 MB), then 0 to 4194303 bytes (4 MB - 1) and 4194304 (4 MB) to
    /// 8388607 (8 MB - 1) are valid part ranges. However, if you set a range value of 2 MB to 6 MB, the range does not align with the part size and
    /// the upload will fail. </li>
    /// 
    /// </ul>
    /// <para>This operation is idempotent. If you upload the same part multiple times, the data included in the most recent request overwrites the
    /// previously uploaded data.</para> <para>An AWS account has full permission to perform all operations (actions). However, AWS Identity and
    /// Access Management (IAM) users don't have any permissions by default. You must grant them explicit permission to perform specific actions.
    /// For more information, see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html" >Access Control
    /// Using AWS Identity and Access Management (IAM)</a> .</para> <para> For conceptual information and underlying REST API, go to <a
    /// href="http://docs.aws.amazon.com/amazonglacier/latest/dev/uploading-archive-mpu.html" >Uploading Large Archives in Parts (Multipart
    /// Upload)</a> and <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/api-upload-part.html" >Upload Part </a> in the <i>Amazon
    /// Glacier Developer Guide</i> .</para>
    /// </summary>
    public partial class UploadMultipartPartRequest : AmazonGlacierRequest
    {
        private string accountId;
        private string vaultName;
        private string uploadId;
        private string checksum;
        private string range;
        private Stream body;


        /// <summary>
        /// The <c>AccountId</c> is the AWS Account ID. You can specify either the AWS Account ID or optionally a '-', in which case Amazon Glacier uses
        /// the AWS Account ID associated with the credentials used to sign the request. If you specify your Account ID, do not include hyphens in it.
        ///  
        /// </summary>
        public string AccountId
        {
            get { return this.accountId; }
            set { this.accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this.accountId != null;
        }

        /// <summary>
        /// The name of the vault.
        ///  
        /// </summary>
        public string VaultName
        {
            get { return this.vaultName; }
            set { this.vaultName = value; }
        }

        // Check to see if VaultName property is set
        internal bool IsSetVaultName()
        {
            return this.vaultName != null;
        }

        /// <summary>
        /// The upload ID of the multipart upload.
        ///  
        /// </summary>
        public string UploadId
        {
            get { return this.uploadId; }
            set { this.uploadId = value; }
        }

        // Check to see if UploadId property is set
        internal bool IsSetUploadId()
        {
            return this.uploadId != null;
        }

        /// <summary>
        /// The SHA256 tree hash of the data being uploaded.
        ///  
        /// </summary>
        public string Checksum
        {
            get { return this.checksum; }
            set { this.checksum = value; }
        }

        // Check to see if Checksum property is set
        internal bool IsSetChecksum()
        {
            return this.checksum != null;
        }

        /// <summary>
        /// Identifies the range of bytes in the assembled archive that will be uploaded in this part. Amazon Glacier uses this information to assemble
        /// the archive in the proper sequence. The format of this header follows RFC 2616. An example header is Content-Range:bytes 0-4194303/*.
        ///  
        /// </summary>
        public string Range
        {
            get { return this.range; }
            set { this.range = value; }
        }

        // Check to see if Range property is set
        internal bool IsSetRange()
        {
            return this.range != null;
        }

        /// <summary>
        /// The data to upload.
        ///  
        /// </summary>
        public Stream Body
        {
            get { return this.body; }
            set { this.body = value; }
        }

        // Check to see if Body property is set
        internal bool IsSetBody()
        {
            return this.body != null;
        }

        /// <summary>
        /// Attach a callback that will be called as data is being sent to the AWS Service.
        /// </summary>
        public EventHandler<Amazon.Runtime.StreamTransferProgressArgs> StreamTransferProgress
        {
            get
            {
                return this.StreamUploadProgressCallback;
            }
            set
            {
                this.StreamUploadProgressCallback = value;
            }
        }

        

    }
}
    
