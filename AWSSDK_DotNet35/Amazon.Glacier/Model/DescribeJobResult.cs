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

namespace Amazon.Glacier.Model
{
    /// <summary>
    /// <para>Describes an Amazon Glacier job.</para>
    /// </summary>
    public partial class DescribeJobResult : AmazonWebServiceResponse
    {
        
        private string jobId;
        private string jobDescription;
        private ActionCode action;
        private string archiveId;
        private string vaultARN;
        private DateTime? creationDate;
        private bool? completed;
        private StatusCode statusCode;
        private string statusMessage;
        private long? archiveSizeInBytes;
        private long? inventorySizeInBytes;
        private string sNSTopic;
        private DateTime? completionDate;
        private string sHA256TreeHash;
        private string archiveSHA256TreeHash;
        private string retrievalByteRange;

        /// <summary>
        /// An opaque string that identifies an Amazon Glacier job.
        ///  
        /// </summary>
        public string JobId
        {
            get { return this.jobId; }
            set { this.jobId = value; }
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
        public ActionCode Action
        {
            get { return this.action; }
            set { this.action = value; }
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
        public StatusCode StatusCode
        {
            get { return this.statusCode; }
            set { this.statusCode = value; }
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

        // Check to see if CompletionDate property is set
        internal bool IsSetCompletionDate()
        {
            return this.completionDate.HasValue;
        }

        /// <summary>
        /// For an ArchiveRetrieval job, it is the checksum of the archive. Otherwise, the value is null. The SHA256 tree hash value for the requested
        /// range of an archive. If the Initiate a Job request for an archive specified a tree-hash aligned range, then this field returns a value. For
        /// the specific case when the whole archive is retrieved, this value is the same as the ArchiveSHA256TreeHash value. This field is null in the
        /// following situations: <ul> <li>Archive retrieval jobs that specify a range that is not tree-hash aligned.</li> </ul> <ul> <li>Archival jobs
        /// that specify a range that is equal to the whole archive and the job status is InProgress.</li> </ul> <ul> <li>Inventory jobs.</li> </ul>
        ///  
        /// </summary>
        public string SHA256TreeHash
        {
            get { return this.sHA256TreeHash; }
            set { this.sHA256TreeHash = value; }
        }

        // Check to see if SHA256TreeHash property is set
        internal bool IsSetSHA256TreeHash()
        {
            return this.sHA256TreeHash != null;
        }

        /// <summary>
        /// The SHA256 tree hash of the entire archive for an archive retrieval. For inventory retrieval jobs, this field is null.
        ///  
        /// </summary>
        public string ArchiveSHA256TreeHash
        {
            get { return this.archiveSHA256TreeHash; }
            set { this.archiveSHA256TreeHash = value; }
        }

        // Check to see if ArchiveSHA256TreeHash property is set
        internal bool IsSetArchiveSHA256TreeHash()
        {
            return this.archiveSHA256TreeHash != null;
        }

        /// <summary>
        /// The retrieved byte range for archive retrieval jobs in the form "<i>StartByteValue</i>-<i>EndByteValue</i>" If no range was specified in the
        /// archive retrieval, then the whole archive is retrieved and <i>StartByteValue</i> equals 0 and <i>EndByteValue</i> equals the size of the
        /// archive minus 1. For inventory retrieval jobs this field is null.
        ///  
        /// </summary>
        public string RetrievalByteRange
        {
            get { return this.retrievalByteRange; }
            set { this.retrievalByteRange = value; }
        }

        // Check to see if RetrievalByteRange property is set
        internal bool IsSetRetrievalByteRange()
        {
            return this.retrievalByteRange != null;
        }
    }
}
