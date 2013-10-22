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
    /// Container for the parameters to the CompleteMultipartUpload operation.
    /// <para>You call this operation to inform Amazon Glacier that all the archive parts have been uploaded and that Amazon Glacier can now
    /// assemble the archive from the uploaded parts. After assembling and saving the archive to the vault, Amazon Glacier returns the URI path of
    /// the newly created archive resource. Using the URI path, you can then access the archive. After you upload an archive, you should save the
    /// archive ID returned to retrieve the archive at a later point. You can also get the vault inventory to obtain a list of archive IDs in a
    /// vault. For more information, see InitiateJob.</para> <para>In the request, you must include the computed SHA256 tree hash of the entire
    /// archive you have uploaded. For information about computing a SHA256 tree hash, see <a
    /// href="http://docs.aws.amazon.com/amazonglacier/latest/dev/checksum-calculations.html" >Computing Checksums</a> . On the server side, Amazon
    /// Glacier also constructs the SHA256 tree hash of the assembled archive. If the values match, Amazon Glacier saves the archive to the vault;
    /// otherwise, it returns an error, and the operation fails. The ListParts operation returns a list of parts uploaded for a specific multipart
    /// upload. It includes checksum information for each uploaded part that can be used to debug a bad checksum issue.</para> <para>Additionally,
    /// Amazon Glacier also checks for any missing content ranges when assembling the archive, if missing content ranges are found, Amazon Glacier
    /// returns an error and the operation fails. </para> <para>Complete Multipart Upload is an idempotent operation. After your first successful
    /// complete multipart upload, if you call the operation again within a short period, the operation will succeed and return the same archive ID.
    /// This is useful in the event you experience a network issue that causes an aborted connection or receive a 500 server error, in which case
    /// you can repeat your Complete Multipart Upload request and get the same archive ID without creating duplicate archives. Note, however, that
    /// after the multipart upload completes, you cannot call the List Parts operation and the multipart upload will not appear in List Multipart
    /// Uploads response, even if idempotent complete is possible.</para> <para>An AWS account has full permission to perform all operations
    /// (actions). However, AWS Identity and Access Management (IAM) users don't have any permissions by default. You must grant them explicit
    /// permission to perform specific actions. For more information, see <a
    /// href="http://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html" >Access Control Using AWS Identity and Access
    /// Management (IAM)</a> .</para> <para> For conceptual information and underlying REST API, go to <a
    /// href="http://docs.aws.amazon.com/amazonglacier/latest/dev/uploading-archive-mpu.html" >Uploading Large Archives in Parts (Multipart
    /// Upload)</a> and <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/api-multipart-complete-upload.html" >Complete Multipart
    /// Upload</a> in the <i>Amazon Glacier Developer Guide</i> .
    /// </para>
    /// </summary>
    public partial class CompleteMultipartUploadRequest : AmazonWebServiceRequest
    {
        private string accountId;
        private string vaultName;
        private string uploadId;
        private string archiveSize;
        private string checksum;

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
        /// The total size, in bytes, of the entire archive. This value should be the sum of all the sizes of the individual parts that you uploaded.
        ///  
        /// </summary>
        public string ArchiveSize
        {
            get { return this.archiveSize; }
            set { this.archiveSize = value; }
        }

        // Check to see if ArchiveSize property is set
        internal bool IsSetArchiveSize()
        {
            return this.archiveSize != null;
        }

        /// <summary>
        /// The SHA256 tree hash of the entire archive. It is the tree hash of SHA256 tree hash of the individual parts. If the value you specify in the
        /// request does not match the SHA256 tree hash of the final assembled archive as computed by Amazon Glacier, Amazon Glacier returns an error
        /// and the request fails.
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

    }
}
    
