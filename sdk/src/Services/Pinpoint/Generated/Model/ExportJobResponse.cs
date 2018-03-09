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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ExportJobResponse
    {
        private string _applicationId;
        private int? _completedPieces;
        private string _completionDate;
        private string _creationDate;
        private ExportJobResource _definition;
        private int? _failedPieces;
        private List<string> _failures = new List<string>();
        private string _id;
        private JobStatus _jobStatus;
        private int? _totalFailures;
        private int? _totalPieces;
        private int? _totalProcessed;
        private string _type;

        /// <summary>
        /// Gets and sets the property ApplicationId. The unique ID of the application to which
        /// the job applies.
        /// </summary>
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

        /// <summary>
        /// Gets and sets the property CompletedPieces. The number of pieces that have successfully
        /// completed as of the time of the request.
        /// </summary>
        public int CompletedPieces
        {
            get { return this._completedPieces.GetValueOrDefault(); }
            set { this._completedPieces = value; }
        }

        // Check to see if CompletedPieces property is set
        internal bool IsSetCompletedPieces()
        {
            return this._completedPieces.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CompletionDate. The date the job completed in ISO 8601
        /// format.
        /// </summary>
        public string CompletionDate
        {
            get { return this._completionDate; }
            set { this._completionDate = value; }
        }

        // Check to see if CompletionDate property is set
        internal bool IsSetCompletionDate()
        {
            return this._completionDate != null;
        }

        /// <summary>
        /// Gets and sets the property CreationDate. The date the job was created in ISO 8601
        /// format.
        /// </summary>
        public string CreationDate
        {
            get { return this._creationDate; }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate != null;
        }

        /// <summary>
        /// Gets and sets the property Definition. The export job settings.
        /// </summary>
        public ExportJobResource Definition
        {
            get { return this._definition; }
            set { this._definition = value; }
        }

        // Check to see if Definition property is set
        internal bool IsSetDefinition()
        {
            return this._definition != null;
        }

        /// <summary>
        /// Gets and sets the property FailedPieces. The number of pieces that failed to be processed
        /// as of the time of the request.
        /// </summary>
        public int FailedPieces
        {
            get { return this._failedPieces.GetValueOrDefault(); }
            set { this._failedPieces = value; }
        }

        // Check to see if FailedPieces property is set
        internal bool IsSetFailedPieces()
        {
            return this._failedPieces.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Failures. Provides up to 100 of the first failed entries
        /// for the job, if any exist.
        /// </summary>
        public List<string> Failures
        {
            get { return this._failures; }
            set { this._failures = value; }
        }

        // Check to see if Failures property is set
        internal bool IsSetFailures()
        {
            return this._failures != null && this._failures.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Id. The unique ID of the job.
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property JobStatus. The status of the job.Valid values: CREATED,
        /// INITIALIZING, PROCESSING, COMPLETING, COMPLETED, FAILING, FAILEDThe job status is
        /// FAILED if one or more pieces failed.
        /// </summary>
        public JobStatus JobStatus
        {
            get { return this._jobStatus; }
            set { this._jobStatus = value; }
        }

        // Check to see if JobStatus property is set
        internal bool IsSetJobStatus()
        {
            return this._jobStatus != null;
        }

        /// <summary>
        /// Gets and sets the property TotalFailures. The number of endpoints that were not processed;
        /// for example, because of syntax errors.
        /// </summary>
        public int TotalFailures
        {
            get { return this._totalFailures.GetValueOrDefault(); }
            set { this._totalFailures = value; }
        }

        // Check to see if TotalFailures property is set
        internal bool IsSetTotalFailures()
        {
            return this._totalFailures.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalPieces. The total number of pieces that must be processed
        /// to finish the job. Each piece is an approximately equal portion of the endpoints.
        /// </summary>
        public int TotalPieces
        {
            get { return this._totalPieces.GetValueOrDefault(); }
            set { this._totalPieces = value; }
        }

        // Check to see if TotalPieces property is set
        internal bool IsSetTotalPieces()
        {
            return this._totalPieces.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalProcessed. The number of endpoints that were processed
        /// by the job.
        /// </summary>
        public int TotalProcessed
        {
            get { return this._totalProcessed.GetValueOrDefault(); }
            set { this._totalProcessed = value; }
        }

        // Check to see if TotalProcessed property is set
        internal bool IsSetTotalProcessed()
        {
            return this._totalProcessed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. The job type. Will be 'EXPORT'.
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}