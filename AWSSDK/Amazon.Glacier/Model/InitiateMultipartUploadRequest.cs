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
    /// Container for the parameters to the InitiateMultipartUpload operation.
    /// <para>This operation initiates a multipart upload. Amazon Glacier creates a multipart upload resource and returns its ID in the response.
    /// The multipart upload ID is used in subsequent requests to upload parts of an archive (see UploadMultipartPart).</para> <para>When you
    /// initiate a multipart upload, you specify the part size in number of bytes. The part size must be a megabyte (1024 KB) multiplied by a power
    /// of 2-for example, 1048576 (1 MB), 2097152 (2 MB), 4194304 (4 MB), 8388608 (8 MB), and so on. The minimum allowable part size is 1 MB, and
    /// the maximum is 4 GB.</para> <para>Every part you upload to this resource (see UploadMultipartPart), except the last one, must have the same
    /// size. The last one can be the same size or smaller. For example, suppose you want to upload a 16.2 MB file. If you initiate the multipart
    /// upload with a part size of 4 MB, you will upload four parts of 4 MB each and one part of 0.2 MB. </para> <para><b>NOTE:</b> You don't need
    /// to know the size of the archive when you start a multipart upload because Amazon Glacier does not require you to specify the overall archive
    /// size. </para> <para>After you complete the multipart upload, Amazon Glacier removes the multipart upload resource referenced by the ID.
    /// Amazon Glacier also removes the multipart upload resource if you cancel the multipart upload or it may be removed if there is no activity
    /// for a period of 24 hours.</para> <para>An AWS account has full permission to perform all operations (actions). However, AWS Identity and
    /// Access Management (IAM) users don't have any permissions by default. You must grant them explicit permission to perform specific actions.
    /// For more information, see Access Control Using AWS Identity and Access Management (IAM).</para> <para>For conceptual information and
    /// underlying REST API, go to Uploading Large Archives in Parts (Multipart Upload) and Initiate Multipart Upload in the <i>Amazon Glacier
    /// Developer Guide</i> .</para>
    /// </summary>
    /// <seealso cref="Amazon.Glacier.AmazonGlacier.InitiateMultipartUpload"/>
    public class InitiateMultipartUploadRequest : AmazonWebServiceRequest
    {
        private string accountId;
        private string vaultName;
        private string archiveDescription;
        private long? partSize;

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

        /// <summary>
        /// Sets the AccountId property
        /// </summary>
        /// <param name="accountId">The value to set for the AccountId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InitiateMultipartUploadRequest WithAccountId(string accountId)
        {
            this.accountId = accountId;
            return this;
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

        /// <summary>
        /// Sets the VaultName property
        /// </summary>
        /// <param name="vaultName">The value to set for the VaultName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InitiateMultipartUploadRequest WithVaultName(string vaultName)
        {
            this.vaultName = vaultName;
            return this;
        }
            

        // Check to see if VaultName property is set
        internal bool IsSetVaultName()
        {
            return this.vaultName != null;       
        }

        /// <summary>
        /// The archive description that you are uploading in parts. The part size must be a megabyte (1024 KB) multiplied by a power of 2—for example,
        /// 1048576 (1 MB), 2097152 (2 MB), 4194304 (4 MB), 8388608 (8 MB), and so on. The minimum allowable part size is 1 MB, and the maximum is 4 GB
        /// (4096 MB).
        ///  
        /// </summary>
        public string ArchiveDescription
        {
            get { return this.archiveDescription; }
            set { this.archiveDescription = value; }
        }

        /// <summary>
        /// Sets the ArchiveDescription property
        /// </summary>
        /// <param name="archiveDescription">The value to set for the ArchiveDescription property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InitiateMultipartUploadRequest WithArchiveDescription(string archiveDescription)
        {
            this.archiveDescription = archiveDescription;
            return this;
        }
            

        // Check to see if ArchiveDescription property is set
        internal bool IsSetArchiveDescription()
        {
            return this.archiveDescription != null;       
        }

        /// <summary>
        /// The size of each part except the last, in bytes. The last part can be smaller than this part size.
        ///  
        /// </summary>
        public long PartSize
        {
            get { return this.partSize ?? default(long); }
            set { this.partSize = value; }
        }

        /// <summary>
        /// Sets the PartSize property
        /// </summary>
        /// <param name="partSize">The value to set for the PartSize property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InitiateMultipartUploadRequest WithPartSize(long partSize)
        {
            this.partSize = partSize;
            return this;
        }
            

        // Check to see if PartSize property is set
        internal bool IsSetPartSize()
        {
            return this.partSize.HasValue;       
        }
    }
}
    
