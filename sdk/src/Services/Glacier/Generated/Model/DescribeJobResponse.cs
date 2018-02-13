/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glacier.Model
{
    /// <summary>
    /// Contains the description of an Amazon Glacier job.
    /// </summary>
    public partial class DescribeJobResponse : AmazonWebServiceResponse
    {
        private ActionCode _action;
        private string _archiveId;
        private string _archiveSHA256TreeHash;
        private long? _archiveSizeInBytes;
        private bool? _completed;
        private DateTime? _completionDate;
        private DateTime? _creationDate;
        private InventoryRetrievalJobDescription _inventoryRetrievalParameters;
        private long? _inventorySizeInBytes;
        private string _jobDescription;
        private string _jobId;
        private string _jobOutputPath;
        private OutputLocation _outputLocation;
        private string _retrievalByteRange;
        private SelectParameters _selectParameters;
        private string _sha256TreeHash;
        private string _snsTopic;
        private StatusCode _statusCode;
        private string _statusMessage;
        private string _tier;
        private string _vaultARN;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The job type. This value is either <code>ArchiveRetrieval</code>, <code>InventoryRetrieval</code>,
        /// or <code>Select</code>. 
        /// </para>
        /// </summary>
        public ActionCode Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property ArchiveId. 
        /// <para>
        /// The archive ID requested for a select job or archive retrieval. Otherwise, this field
        /// is null.
        /// </para>
        /// </summary>
        public string ArchiveId
        {
            get { return this._archiveId; }
            set { this._archiveId = value; }
        }

        // Check to see if ArchiveId property is set
        internal bool IsSetArchiveId()
        {
            return this._archiveId != null;
        }

        /// <summary>
        /// Gets and sets the property ArchiveSHA256TreeHash. 
        /// <para>
        /// The SHA256 tree hash of the entire archive for an archive retrieval. For inventory
        /// retrieval or select jobs, this field is null.
        /// </para>
        /// </summary>
        public string ArchiveSHA256TreeHash
        {
            get { return this._archiveSHA256TreeHash; }
            set { this._archiveSHA256TreeHash = value; }
        }

        // Check to see if ArchiveSHA256TreeHash property is set
        internal bool IsSetArchiveSHA256TreeHash()
        {
            return this._archiveSHA256TreeHash != null;
        }

        /// <summary>
        /// Gets and sets the property ArchiveSizeInBytes. 
        /// <para>
        /// For an archive retrieval job, this value is the size in bytes of the archive being
        /// requested for download. For an inventory retrieval or select job, this value is null.
        /// </para>
        /// </summary>
        public long ArchiveSizeInBytes
        {
            get { return this._archiveSizeInBytes.GetValueOrDefault(); }
            set { this._archiveSizeInBytes = value; }
        }

        // Check to see if ArchiveSizeInBytes property is set
        internal bool IsSetArchiveSizeInBytes()
        {
            return this._archiveSizeInBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Completed. 
        /// <para>
        /// The job status. When a job is completed, you get the job's output using Get Job Output
        /// (GET output).
        /// </para>
        /// </summary>
        public bool Completed
        {
            get { return this._completed.GetValueOrDefault(); }
            set { this._completed = value; }
        }

        // Check to see if Completed property is set
        internal bool IsSetCompleted()
        {
            return this._completed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CompletionDate. 
        /// <para>
        /// The UTC time that the job request completed. While the job is in progress, the value
        /// is null.
        /// </para>
        /// </summary>
        public DateTime CompletionDate
        {
            get { return this._completionDate.GetValueOrDefault(); }
            set { this._completionDate = value; }
        }

        // Check to see if CompletionDate property is set
        internal bool IsSetCompletionDate()
        {
            return this._completionDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The UTC date when the job was created. This value is a string representation of ISO
        /// 8601 date format, for example <code>"2012-03-20T17:03:43.221Z"</code>.
        /// </para>
        /// </summary>
        public DateTime CreationDate
        {
            get { return this._creationDate.GetValueOrDefault(); }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InventoryRetrievalParameters. 
        /// <para>
        /// Parameters used for range inventory retrieval.
        /// </para>
        /// </summary>
        public InventoryRetrievalJobDescription InventoryRetrievalParameters
        {
            get { return this._inventoryRetrievalParameters; }
            set { this._inventoryRetrievalParameters = value; }
        }

        // Check to see if InventoryRetrievalParameters property is set
        internal bool IsSetInventoryRetrievalParameters()
        {
            return this._inventoryRetrievalParameters != null;
        }

        /// <summary>
        /// Gets and sets the property InventorySizeInBytes. 
        /// <para>
        /// For an inventory retrieval job, this value is the size in bytes of the inventory requested
        /// for download. For an archive retrieval or select job, this value is null.
        /// </para>
        /// </summary>
        public long InventorySizeInBytes
        {
            get { return this._inventorySizeInBytes.GetValueOrDefault(); }
            set { this._inventorySizeInBytes = value; }
        }

        // Check to see if InventorySizeInBytes property is set
        internal bool IsSetInventorySizeInBytes()
        {
            return this._inventorySizeInBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JobDescription. 
        /// <para>
        /// The job description provided when initiating the job.
        /// </para>
        /// </summary>
        public string JobDescription
        {
            get { return this._jobDescription; }
            set { this._jobDescription = value; }
        }

        // Check to see if JobDescription property is set
        internal bool IsSetJobDescription()
        {
            return this._jobDescription != null;
        }

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// An opaque string that identifies an Amazon Glacier job.
        /// </para>
        /// </summary>
        public string JobId
        {
            get { return this._jobId; }
            set { this._jobId = value; }
        }

        // Check to see if JobId property is set
        internal bool IsSetJobId()
        {
            return this._jobId != null;
        }

        /// <summary>
        /// Gets and sets the property JobOutputPath. 
        /// <para>
        /// Contains the job output location.
        /// </para>
        /// </summary>
        public string JobOutputPath
        {
            get { return this._jobOutputPath; }
            set { this._jobOutputPath = value; }
        }

        // Check to see if JobOutputPath property is set
        internal bool IsSetJobOutputPath()
        {
            return this._jobOutputPath != null;
        }

        /// <summary>
        /// Gets and sets the property OutputLocation. 
        /// <para>
        /// Contains the location where the data from the select job is stored.
        /// </para>
        /// </summary>
        public OutputLocation OutputLocation
        {
            get { return this._outputLocation; }
            set { this._outputLocation = value; }
        }

        // Check to see if OutputLocation property is set
        internal bool IsSetOutputLocation()
        {
            return this._outputLocation != null;
        }

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
        public string RetrievalByteRange
        {
            get { return this._retrievalByteRange; }
            set { this._retrievalByteRange = value; }
        }

        // Check to see if RetrievalByteRange property is set
        internal bool IsSetRetrievalByteRange()
        {
            return this._retrievalByteRange != null;
        }

        /// <summary>
        /// Gets and sets the property SelectParameters. 
        /// <para>
        /// Contains the parameters used for a select.
        /// </para>
        /// </summary>
        public SelectParameters SelectParameters
        {
            get { return this._selectParameters; }
            set { this._selectParameters = value; }
        }

        // Check to see if SelectParameters property is set
        internal bool IsSetSelectParameters()
        {
            return this._selectParameters != null;
        }

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
        /// status is <code>InProgress</code> 
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
        public string SHA256TreeHash
        {
            get { return this._sha256TreeHash; }
            set { this._sha256TreeHash = value; }
        }

        // Check to see if SHA256TreeHash property is set
        internal bool IsSetSHA256TreeHash()
        {
            return this._sha256TreeHash != null;
        }

        /// <summary>
        /// Gets and sets the property SNSTopic. 
        /// <para>
        /// An Amazon SNS topic that receives notification.
        /// </para>
        /// </summary>
        public string SNSTopic
        {
            get { return this._snsTopic; }
            set { this._snsTopic = value; }
        }

        // Check to see if SNSTopic property is set
        internal bool IsSetSNSTopic()
        {
            return this._snsTopic != null;
        }

        /// <summary>
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// The status code can be <code>InProgress</code>, <code>Succeeded</code>, or <code>Failed</code>,
        /// and indicates the status of the job.
        /// </para>
        /// </summary>
        public StatusCode StatusCode
        {
            get { return this._statusCode; }
            set { this._statusCode = value; }
        }

        // Check to see if StatusCode property is set
        internal bool IsSetStatusCode()
        {
            return this._statusCode != null;
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A friendly message that describes the job status.
        /// </para>
        /// </summary>
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property Tier. 
        /// <para>
        /// The tier to use for a select or an archive retrieval. Valid values are <code>Expedited</code>,
        /// <code>Standard</code>, or <code>Bulk</code>. <code>Standard</code> is the default.
        /// </para>
        /// </summary>
        public string Tier
        {
            get { return this._tier; }
            set { this._tier = value; }
        }

        // Check to see if Tier property is set
        internal bool IsSetTier()
        {
            return this._tier != null;
        }

        /// <summary>
        /// Gets and sets the property VaultARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the vault from which an archive retrieval was requested.
        /// </para>
        /// </summary>
        public string VaultARN
        {
            get { return this._vaultARN; }
            set { this._vaultARN = value; }
        }

        // Check to see if VaultARN property is set
        internal bool IsSetVaultARN()
        {
            return this._vaultARN != null;
        }

    }
}