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
    /// Contains the description of an Amazon S3 Glacier job.
    /// </summary>
    public partial class GlacierJobDescription
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The job type. This value is either <c>ArchiveRetrieval</c>, <c>InventoryRetrieval</c>,
        /// or <c>Select</c>. 
        /// </para>
        /// </summary>
        public ActionCode Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property ArchiveId. 
        /// <para>
        /// The archive ID requested for a select job or archive retrieval. Otherwise, this field
        /// is null.
        /// </para>
        /// </summary>
        public string ArchiveId { get; set; }

        /// <summary>
        /// Checks to see if the ArchiveId property is set.
        /// </summary>
        internal bool IsSetArchiveId() => this.ArchiveId != null;

        /// <summary>
        /// Gets and sets the property ArchiveSHA256TreeHash. 
        /// <para>
        /// The SHA256 tree hash of the entire archive for an archive retrieval. For inventory
        /// retrieval or select jobs, this field is null.
        /// </para>
        /// </summary>
        public string ArchiveSHA256TreeHash { get; set; }

        /// <summary>
        /// Checks to see if the ArchiveSHA256TreeHash property is set.
        /// </summary>
        internal bool IsSetArchiveSHA256TreeHash() => this.ArchiveSHA256TreeHash != null;

        /// <summary>
        /// Gets and sets the property ArchiveSizeInBytes. 
        /// <para>
        /// For an archive retrieval job, this value is the size in bytes of the archive being
        /// requested for download. For an inventory retrieval or select job, this value is null.
        /// </para>
        /// </summary>
        public long? ArchiveSizeInBytes { get; set; }

        /// <summary>
        /// Checks to see if the ArchiveSizeInBytes property is set.
        /// </summary>
        internal bool IsSetArchiveSizeInBytes() => this.ArchiveSizeInBytes.HasValue;

        /// <summary>
        /// Gets and sets the property Completed. 
        /// <para>
        /// The job status. When a job is completed, you get the job's output using Get Job Output
        /// (GET output).
        /// </para>
        /// </summary>
        public bool? Completed { get; set; }

        /// <summary>
        /// Checks to see if the Completed property is set.
        /// </summary>
        internal bool IsSetCompleted() => this.Completed.HasValue;

        /// <summary>
        /// Gets and sets the property CompletionDate. 
        /// <para>
        /// The UTC time that the job request completed. While the job is in progress, the value
        /// is null.
        /// </para>
        /// </summary>
        public DateTime? CompletionDate { get; set; }

        /// <summary>
        /// Checks to see if the CompletionDate property is set.
        /// </summary>
        internal bool IsSetCompletionDate() => this.CompletionDate.HasValue;

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The UTC date when the job was created. This value is a string representation of ISO
        /// 8601 date format, for example <c>"2012-03-20T17:03:43.221Z"</c>.
        /// </para>
        /// </summary>
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate.HasValue;

        /// <summary>
        /// Gets and sets the property InventoryRetrievalParameters. 
        /// <para>
        /// Parameters used for range inventory retrieval.
        /// </para>
        /// </summary>
        public InventoryRetrievalJobDescription InventoryRetrievalParameters { get; set; }

        /// <summary>
        /// Checks to see if the InventoryRetrievalParameters property is set.
        /// </summary>
        internal bool IsSetInventoryRetrievalParameters() => this.InventoryRetrievalParameters != null;

        /// <summary>
        /// Gets and sets the property InventorySizeInBytes. 
        /// <para>
        /// For an inventory retrieval job, this value is the size in bytes of the inventory requested
        /// for download. For an archive retrieval or select job, this value is null.
        /// </para>
        /// </summary>
        public long? InventorySizeInBytes { get; set; }

        /// <summary>
        /// Checks to see if the InventorySizeInBytes property is set.
        /// </summary>
        internal bool IsSetInventorySizeInBytes() => this.InventorySizeInBytes.HasValue;

        /// <summary>
        /// Gets and sets the property JobDescription. 
        /// <para>
        /// The job description provided when initiating the job.
        /// </para>
        /// </summary>
        public string JobDescription { get; set; }

        /// <summary>
        /// Checks to see if the JobDescription property is set.
        /// </summary>
        internal bool IsSetJobDescription() => this.JobDescription != null;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// An opaque string that identifies an Amazon S3 Glacier job.
        /// </para>
        /// </summary>
        public string JobId { get; set; }

        /// <summary>
        /// Checks to see if the JobId property is set.
        /// </summary>
        internal bool IsSetJobId() => this.JobId != null;

        /// <summary>
        /// Gets and sets the property JobOutputPath. 
        /// <para>
        /// Contains the job output location.
        /// </para>
        /// </summary>
        public string JobOutputPath { get; set; }

        /// <summary>
        /// Checks to see if the JobOutputPath property is set.
        /// </summary>
        internal bool IsSetJobOutputPath() => this.JobOutputPath != null;

        /// <summary>
        /// Gets and sets the property OutputLocation. 
        /// <para>
        /// Contains the location where the data from the select job is stored.
        /// </para>
        /// </summary>
        public OutputLocation OutputLocation { get; set; }

        /// <summary>
        /// Checks to see if the OutputLocation property is set.
        /// </summary>
        internal bool IsSetOutputLocation() => this.OutputLocation != null;

        /// <summary>
        /// Gets and sets the property RetrievalByteRange. 
        /// <para>
        /// The retrieved byte range for archive retrieval jobs in the form <i>StartByteValue</i>-<i>EndByteValue</i>.
        /// If no range was specified in the archive retrieval, then the whole archive is retrieved.
        /// In this case, <i>StartByteValue</i> equals 0 and <i>EndByteValue</i> equals the size
        /// of the archive minus 1. For inventory retrieval or select jobs, this field is null.
        /// 
        /// </para>
        /// </summary>
        public string RetrievalByteRange { get; set; }

        /// <summary>
        /// Checks to see if the RetrievalByteRange property is set.
        /// </summary>
        internal bool IsSetRetrievalByteRange() => this.RetrievalByteRange != null;

        /// <summary>
        /// Gets and sets the property SHA256TreeHash. 
        /// <para>
        /// For an archive retrieval job, this value is the checksum of the archive. Otherwise,
        /// this value is null.
        /// </para>
        ///  
        /// <para>
        /// The SHA256 tree hash value for the requested range of an archive. If the <b>InitiateJob</b>
        /// request for an archive specified a tree-hash aligned range, then this field returns
        /// a value.
        /// </para>
        ///  
        /// <para>
        /// If the whole archive is retrieved, this value is the same as the ArchiveSHA256TreeHash
        /// value.
        /// </para>
        ///  
        /// <para>
        /// This field is null for the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Archive retrieval jobs that specify a range that is not tree-hash aligned
        /// </para>
        ///  </li> </ul> <ul> <li> 
        /// <para>
        /// Archival jobs that specify a range that is equal to the whole archive, when the job
        /// status is <c>InProgress</c> 
        /// </para>
        ///  </li> </ul> <ul> <li> 
        /// <para>
        /// Inventory jobs
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Select jobs
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string SHA256TreeHash { get; set; }

        /// <summary>
        /// Checks to see if the SHA256TreeHash property is set.
        /// </summary>
        internal bool IsSetSHA256TreeHash() => this.SHA256TreeHash != null;

        /// <summary>
        /// Gets and sets the property SNSTopic. 
        /// <para>
        /// An Amazon SNS topic that receives notification.
        /// </para>
        /// </summary>
        public string SNSTopic { get; set; }

        /// <summary>
        /// Checks to see if the SNSTopic property is set.
        /// </summary>
        internal bool IsSetSNSTopic() => this.SNSTopic != null;

        /// <summary>
        /// Gets and sets the property SelectParameters. 
        /// <para>
        /// Contains the parameters used for a select.
        /// </para>
        /// </summary>
        public SelectParameters SelectParameters { get; set; }

        /// <summary>
        /// Checks to see if the SelectParameters property is set.
        /// </summary>
        internal bool IsSetSelectParameters() => this.SelectParameters != null;

        /// <summary>
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// The status code can be <c>InProgress</c>, <c>Succeeded</c>, or <c>Failed</c>, and
        /// indicates the status of the job.
        /// </para>
        /// </summary>
        public StatusCode StatusCode { get; set; }

        /// <summary>
        /// Checks to see if the StatusCode property is set.
        /// </summary>
        internal bool IsSetStatusCode() => this.StatusCode != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A friendly message that describes the job status.
        /// </para>
        /// </summary>
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

        /// <summary>
        /// Gets and sets the property Tier. 
        /// <para>
        /// The tier to use for a select or an archive retrieval. Valid values are <c>Expedited</c>,
        /// <c>Standard</c>, or <c>Bulk</c>. <c>Standard</c> is the default.
        /// </para>
        /// </summary>
        public string Tier { get; set; }

        /// <summary>
        /// Checks to see if the Tier property is set.
        /// </summary>
        internal bool IsSetTier() => this.Tier != null;

        /// <summary>
        /// Gets and sets the property VaultARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the vault from which an archive retrieval was requested.
        /// </para>
        /// </summary>
        public string VaultARN { get; set; }

        /// <summary>
        /// Checks to see if the VaultARN property is set.
        /// </summary>
        internal bool IsSetVaultARN() => this.VaultARN != null;
    }
}
