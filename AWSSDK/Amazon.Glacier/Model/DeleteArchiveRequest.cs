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
    /// Container for the parameters to the DeleteArchive operation.
    /// <para>This operation deletes an archive from a vault. Subsequent requests to initiate a retrieval of this archive will fail. Archive
    /// retrievals that are in progress for this archive ID may or may not succeed according to the following scenarios:</para>
    /// <ul>
    /// <li>If the archive retrieval job is actively preparing the data for download when Amazon Glacier receives the delete archive request, the
    /// archival retrieval operation might fail. </li>
    /// <li>If the archive retrieval job has successfully prepared the archive for download when Amazon Glacier receives the delete archive
    /// request, you will be able to download the output. </li>
    /// 
    /// </ul>
    /// <para>This operation is idempotent. Attempting to delete an already-deleted archive does not result in an error. </para> <para>An AWS
    /// account has full permission to perform all operations (actions). However, AWS Identity and Access Management (IAM) users don't have any
    /// permissions by default. You must grant them explicit permission to perform specific actions. For more information, see Access Control Using
    /// AWS Identity and Access Management (IAM).</para> <para> For conceptual information and underlying REST API, go to Deleting an Archive in
    /// Amazon Glacier and Delete Archive in the <i>Amazon Glacier Developer Guide</i> .
    /// </para>
    /// </summary>
    /// <seealso cref="Amazon.Glacier.AmazonGlacier.DeleteArchive"/>
    public class DeleteArchiveRequest : AmazonWebServiceRequest
    {
        private string accountId;
        private string vaultName;
        private string archiveId;

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
        public DeleteArchiveRequest WithAccountId(string accountId)
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
        public DeleteArchiveRequest WithVaultName(string vaultName)
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
        /// The ID of the archive to delete.
        ///  
        /// </summary>
        public string ArchiveId
        {
            get { return this.archiveId; }
            set { this.archiveId = value; }
        }

        /// <summary>
        /// Sets the ArchiveId property
        /// </summary>
        /// <param name="archiveId">The value to set for the ArchiveId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DeleteArchiveRequest WithArchiveId(string archiveId)
        {
            this.archiveId = archiveId;
            return this;
        }
            

        // Check to see if ArchiveId property is set
        internal bool IsSetArchiveId()
        {
            return this.archiveId != null;       
        }
    }
}
    
