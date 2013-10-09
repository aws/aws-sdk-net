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
    /// Container for the parameters to the UploadArchive operation.
    /// <para>This operation adds an archive to a vault. This is a synchronous operation, and for a successful upload, your data is durably
    /// persisted. Amazon Glacier returns the archive ID in the <c>x-amz-archive-id</c> header of the response. </para> <para>You must use the
    /// archive ID to access your data in Amazon Glacier. After you upload an archive, you should save the archive ID returned so that you can
    /// retrieve or delete the archive later. Besides saving the archive ID, you can also index it and give it a friendly name to allow for better
    /// searching. You can also use the optional archive description field to specify how the archive is referred to in an external index of
    /// archives, such as you might create in Amazon DynamoDB. You can also get the vault inventory to obtain a list of archive IDs in a vault. For
    /// more information, see InitiateJob. </para> <para>You must provide a SHA256 tree hash of the data you are uploading. For information about
    /// computing a SHA256 tree hash, see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/checksum-calculations.html"> Computing
    /// Checksums </a> . </para> <para>You can optionally specify an archive description of up to 1,024 printable ASCII characters. You can get the
    /// archive description when you either retrieve the archive or get the vault inventory. For more information, see InitiateJob. Amazon Glacier
    /// does not interpret the description in any way. An archive description does not need to be unique. You cannot use the description to retrieve
    /// or sort the archive list. </para> <para>Archives are immutable. After you upload an archive, you cannot edit the archive or its description.
    /// </para> <para>An AWS account has full permission to perform all operations (actions). However, AWS Identity and Access Management (IAM)
    /// users don't have any permissions by default. You must grant them explicit permission to perform specific actions. For more information, see
    /// <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html"> Access Control Using AWS Identity and
    /// Access Management (IAM) </a> .</para> <para> For conceptual information and underlying REST API, go to <a
    /// href="http://docs.aws.amazon.com/amazonglacier/latest/dev/uploading-an-archive.html"> Uploading an Archive in Amazon Glacier </a> and <a
    /// href="http://docs.aws.amazon.com/amazonglacier/latest/dev/api-archive-post.html"> Upload Archive </a> in the <i>Amazon Glacier Developer
    /// Guide</i> .
    /// </para>
    /// </summary>
    /// <seealso cref="Amazon.Glacier.AmazonGlacier.UploadArchive"/>
    public class UploadArchiveRequest : AmazonWebServiceRequest
    {
        private string vaultName;
        private string accountId;
        private string archiveDescription;
        private string checksum;
        private Stream body;

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
        public UploadArchiveRequest WithVaultName(string vaultName)
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
        public UploadArchiveRequest WithAccountId(string accountId)
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
        /// The optional description of the archive you are uploading.
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
        public UploadArchiveRequest WithArchiveDescription(string archiveDescription)
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
        /// The SHA256 checksum (a linear hash) of the payload.
        ///  
        /// </summary>
        public string Checksum
        {
            get { return this.checksum; }
            set { this.checksum = value; }
        }

        /// <summary>
        /// Sets the Checksum property
        /// </summary>
        /// <param name="checksum">The value to set for the Checksum property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UploadArchiveRequest WithChecksum(string checksum)
        {
            this.checksum = checksum;
            return this;
        }
            

        // Check to see if Checksum property is set
        internal bool IsSetChecksum()
        {
            return this.checksum != null;
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

        /// <summary>
        /// Sets the Body property
        /// </summary>
        /// <param name="body">The value to set for the Body property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UploadArchiveRequest WithBody(Stream body)
        {
            this.body = body;
            return this;
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
    
