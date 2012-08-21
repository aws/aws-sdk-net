/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.Glacier.Model
{
    /// <summary>
    /// <para>Describes an Amazon Glacier job.</para>
    /// </summary>
    public class DescribeJobResult  
    {
        
        private string jobId;
        private string jobDescription;
        private string action;
        private string archiveId;
        private string vaultARN;
        private DateTime? creationDate;
        private bool? completed;
        private string statusCode;
        private string statusMessage;
        private long? archiveSizeInBytes;
        private long? inventorySizeInBytes;
        private string sNSTopic;
        private DateTime? completionDate;
        private string sHA256TreeHash;

        /// <summary>
        /// An opaque string that identifies an Amazon Glacier job.
        ///  
        /// </summary>
        public string JobId
        {
            get { return this.jobId; }
            set { this.jobId = value; }
        }

        /// <summary>
        /// Sets the JobId property
        /// </summary>
        /// <param name="jobId">The value to set for the JobId property </param>
        /// <returns>this instance</returns>
        public DescribeJobResult WithJobId(string jobId)
        {
            this.jobId = jobId;
            return this;
        }
            

        // Check to see if JobId property is set
        internal bool IsSetJobId()
        {
            return this.jobId != null;       
        }

        /// <summary>
        /// The job description you provided when you initiated the job.
        ///  
        /// </summary>
        public string JobDescription
        {
            get { return this.jobDescription; }
            set { this.jobDescription = value; }
        }

        /// <summary>
        /// Sets the JobDescription property
        /// </summary>
        /// <param name="jobDescription">The value to set for the JobDescription property </param>
        /// <returns>this instance</returns>
        public DescribeJobResult WithJobDescription(string jobDescription)
        {
            this.jobDescription = jobDescription;
            return this;
        }
            

        // Check to see if JobDescription property is set
        internal bool IsSetJobDescription()
        {
            return this.jobDescription != null;       
        }

        /// <summary>
        /// The job type. It is either ArchiveRetrieval or InventoryRetrieval.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>ArchiveRetrieval, InventoryRetrieval</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Action
        {
            get { return this.action; }
            set { this.action = value; }
        }

        /// <summary>
        /// Sets the Action property
        /// </summary>
        /// <param name="action">The value to set for the Action property </param>
        /// <returns>this instance</returns>
        public DescribeJobResult WithAction(string action)
        {
            this.action = action;
            return this;
        }
            

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this.action != null;       
        }

        /// <summary>
        /// For an ArchiveRetrieval job, this is the archive ID requested for download. Otherwise, this field is null.
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
        public DescribeJobResult WithArchiveId(string archiveId)
        {
            this.archiveId = archiveId;
            return this;
        }
            

        // Check to see if ArchiveId property is set
        internal bool IsSetArchiveId()
        {
            return this.archiveId != null;       
        }

        /// <summary>
        /// The Amazon Resource Name (ARN) of the vault from which the archive retrieval was requested.
        ///  
        /// </summary>
        public string VaultARN
        {
            get { return this.vaultARN; }
            set { this.vaultARN = value; }
        }

        /// <summary>
        /// Sets the VaultARN property
        /// </summary>
        /// <param name="vaultARN">The value to set for the VaultARN property </param>
        /// <returns>this instance</returns>
        public DescribeJobResult WithVaultARN(string vaultARN)
        {
            this.vaultARN = vaultARN;
            return this;
        }
            

        // Check to see if VaultARN property is set
        internal bool IsSetVaultARN()
        {
            return this.vaultARN != null;       
        }

        /// <summary>
        /// The UTC date when the job was created. A string representation of ISO 8601 date format, for example, "2012-03-20T17:03:43.221Z".
        ///  
        /// </summary>
        public DateTime CreationDate
        {
            get { return this.creationDate ?? default(DateTime); }
            set { this.creationDate = value; }
        }

        /// <summary>
        /// Sets the CreationDate property
        /// </summary>
        /// <param name="creationDate">The value to set for the CreationDate property </param>
        /// <returns>this instance</returns>
        public DescribeJobResult WithCreationDate(DateTime creationDate)
        {
            this.creationDate = creationDate;
            return this;
        }
            

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this.creationDate.HasValue;       
        }

        /// <summary>
        /// The job status. When a job is completed, you get the job's output.
        ///  
        /// </summary>
        public bool Completed
        {
            get { return this.completed ?? default(bool); }
            set { this.completed = value; }
        }

        /// <summary>
        /// Sets the Completed property
        /// </summary>
        /// <param name="completed">The value to set for the Completed property </param>
        /// <returns>this instance</returns>
        public DescribeJobResult WithCompleted(bool completed)
        {
            this.completed = completed;
            return this;
        }
            

        // Check to see if Completed property is set
        internal bool IsSetCompleted()
        {
            return this.completed.HasValue;       
        }

        /// <summary>
        /// The status code can be InProgress, Succeeded, or Failed, and indicates the status of the job.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>InProgress, Succeeded, Failed</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string StatusCode
        {
            get { return this.statusCode; }
            set { this.statusCode = value; }
        }

        /// <summary>
        /// Sets the StatusCode property
        /// </summary>
        /// <param name="statusCode">The value to set for the StatusCode property </param>
        /// <returns>this instance</returns>
        public DescribeJobResult WithStatusCode(string statusCode)
        {
            this.statusCode = statusCode;
            return this;
        }
            

        // Check to see if StatusCode property is set
        internal bool IsSetStatusCode()
        {
            return this.statusCode != null;       
        }

        /// <summary>
        /// A friendly message that describes the job status.
        ///  
        /// </summary>
        public string StatusMessage
        {
            get { return this.statusMessage; }
            set { this.statusMessage = value; }
        }

        /// <summary>
        /// Sets the StatusMessage property
        /// </summary>
        /// <param name="statusMessage">The value to set for the StatusMessage property </param>
        /// <returns>this instance</returns>
        public DescribeJobResult WithStatusMessage(string statusMessage)
        {
            this.statusMessage = statusMessage;
            return this;
        }
            

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this.statusMessage != null;       
        }

        /// <summary>
        /// For an ArchiveRetrieval job, this is the size in bytes of the archive being requested for download. For the InventoryRetrieval job, the
        /// value is null.
        ///  
        /// </summary>
        public long ArchiveSizeInBytes
        {
            get { return this.archiveSizeInBytes ?? default(long); }
            set { this.archiveSizeInBytes = value; }
        }

        /// <summary>
        /// Sets the ArchiveSizeInBytes property
        /// </summary>
        /// <param name="archiveSizeInBytes">The value to set for the ArchiveSizeInBytes property </param>
        /// <returns>this instance</returns>
        public DescribeJobResult WithArchiveSizeInBytes(long archiveSizeInBytes)
        {
            this.archiveSizeInBytes = archiveSizeInBytes;
            return this;
        }
            

        // Check to see if ArchiveSizeInBytes property is set
        internal bool IsSetArchiveSizeInBytes()
        {
            return this.archiveSizeInBytes.HasValue;       
        }

        /// <summary>
        /// For an InventoryRetrieval job, this is the size in bytes of the inventory requested for download. For the ArchiveRetrieval job, the value is
        /// null.
        ///  
        /// </summary>
        public long InventorySizeInBytes
        {
            get { return this.inventorySizeInBytes ?? default(long); }
            set { this.inventorySizeInBytes = value; }
        }

        /// <summary>
        /// Sets the InventorySizeInBytes property
        /// </summary>
        /// <param name="inventorySizeInBytes">The value to set for the InventorySizeInBytes property </param>
        /// <returns>this instance</returns>
        public DescribeJobResult WithInventorySizeInBytes(long inventorySizeInBytes)
        {
            this.inventorySizeInBytes = inventorySizeInBytes;
            return this;
        }
            

        // Check to see if InventorySizeInBytes property is set
        internal bool IsSetInventorySizeInBytes()
        {
            return this.inventorySizeInBytes.HasValue;       
        }

        /// <summary>
        /// An Amazon Simple Notification Service (Amazon SNS) topic that receives notification.
        ///  
        /// </summary>
        public string SNSTopic
        {
            get { return this.sNSTopic; }
            set { this.sNSTopic = value; }
        }

        /// <summary>
        /// Sets the SNSTopic property
        /// </summary>
        /// <param name="sNSTopic">The value to set for the SNSTopic property </param>
        /// <returns>this instance</returns>
        public DescribeJobResult WithSNSTopic(string sNSTopic)
        {
            this.sNSTopic = sNSTopic;
            return this;
        }
            

        // Check to see if SNSTopic property is set
        internal bool IsSetSNSTopic()
        {
            return this.sNSTopic != null;       
        }

        /// <summary>
        /// The UTC time that the archive retrieval request completed. While the job is in progress, the value will be null.
        ///  
        /// </summary>
        public DateTime CompletionDate
        {
            get { return this.completionDate ?? default(DateTime); }
            set { this.completionDate = value; }
        }

        /// <summary>
        /// Sets the CompletionDate property
        /// </summary>
        /// <param name="completionDate">The value to set for the CompletionDate property </param>
        /// <returns>this instance</returns>
        public DescribeJobResult WithCompletionDate(DateTime completionDate)
        {
            this.completionDate = completionDate;
            return this;
        }
            

        // Check to see if CompletionDate property is set
        internal bool IsSetCompletionDate()
        {
            return this.completionDate.HasValue;       
        }

        /// <summary>
        /// For an ArchiveRetrieval job, it is the checksum of the archive. Otherwise, the value is null.
        ///  
        /// </summary>
        public string SHA256TreeHash
        {
            get { return this.sHA256TreeHash; }
            set { this.sHA256TreeHash = value; }
        }

        /// <summary>
        /// Sets the SHA256TreeHash property
        /// </summary>
        /// <param name="sHA256TreeHash">The value to set for the SHA256TreeHash property </param>
        /// <returns>this instance</returns>
        public DescribeJobResult WithSHA256TreeHash(string sHA256TreeHash)
        {
            this.sHA256TreeHash = sHA256TreeHash;
            return this;
        }
            

        // Check to see if SHA256TreeHash property is set
        internal bool IsSetSHA256TreeHash()
        {
            return this.sHA256TreeHash != null;       
        }
    }
}
