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
 * Do not modify this file. This file is generated from the machinelearning-2014-12-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MachineLearning.Model
{
    /// <summary>
    /// Represents the output of a <code>GetBatchPrediction</code> operation.
    /// 
    ///  
    /// <para>
    ///  The content consists of the detailed metadata, the status, and the data file information
    /// of a <code>Batch Prediction</code>.
    /// </para>
    /// </summary>
    public partial class BatchPrediction
    {
        private string _batchPredictionDataSourceId;
        private string _batchPredictionId;
        private long? _computeTime;
        private DateTime? _createdAt;
        private string _createdByIamUser;
        private DateTime? _finishedAt;
        private string _inputDataLocationS3;
        private long? _invalidRecordCount;
        private DateTime? _lastUpdatedAt;
        private string _message;
        private string _mlModelId;
        private string _name;
        private string _outputUri;
        private DateTime? _startedAt;
        private EntityStatus _status;
        private long? _totalRecordCount;

        /// <summary>
        /// Gets and sets the property BatchPredictionDataSourceId. 
        /// <para>
        /// The ID of the <code>DataSource</code> that points to the group of observations to
        /// predict.
        /// </para>
        /// </summary>
        public string BatchPredictionDataSourceId
        {
            get { return this._batchPredictionDataSourceId; }
            set { this._batchPredictionDataSourceId = value; }
        }

        // Check to see if BatchPredictionDataSourceId property is set
        internal bool IsSetBatchPredictionDataSourceId()
        {
            return this._batchPredictionDataSourceId != null;
        }

        /// <summary>
        /// Gets and sets the property BatchPredictionId. 
        /// <para>
        /// The ID assigned to the <code>BatchPrediction</code> at creation. This value should
        /// be identical to the value of the <code>BatchPredictionID</code> in the request. 
        /// </para>
        /// </summary>
        public string BatchPredictionId
        {
            get { return this._batchPredictionId; }
            set { this._batchPredictionId = value; }
        }

        // Check to see if BatchPredictionId property is set
        internal bool IsSetBatchPredictionId()
        {
            return this._batchPredictionId != null;
        }

        /// <summary>
        /// Gets and sets the property ComputeTime.
        /// </summary>
        public long ComputeTime
        {
            get { return this._computeTime.GetValueOrDefault(); }
            set { this._computeTime = value; }
        }

        // Check to see if ComputeTime property is set
        internal bool IsSetComputeTime()
        {
            return this._computeTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time that the <code>BatchPrediction</code> was created. The time is expressed
        /// in epoch time.
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedByIamUser. 
        /// <para>
        /// The AWS user account that invoked the <code>BatchPrediction</code>. The account type
        /// can be either an AWS root account or an AWS Identity and Access Management (IAM) user
        /// account.
        /// </para>
        /// </summary>
        public string CreatedByIamUser
        {
            get { return this._createdByIamUser; }
            set { this._createdByIamUser = value; }
        }

        // Check to see if CreatedByIamUser property is set
        internal bool IsSetCreatedByIamUser()
        {
            return this._createdByIamUser != null;
        }

        /// <summary>
        /// Gets and sets the property FinishedAt.
        /// </summary>
        public DateTime FinishedAt
        {
            get { return this._finishedAt.GetValueOrDefault(); }
            set { this._finishedAt = value; }
        }

        // Check to see if FinishedAt property is set
        internal bool IsSetFinishedAt()
        {
            return this._finishedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InputDataLocationS3. 
        /// <para>
        /// The location of the data file or directory in Amazon Simple Storage Service (Amazon
        /// S3).
        /// </para>
        /// </summary>
        public string InputDataLocationS3
        {
            get { return this._inputDataLocationS3; }
            set { this._inputDataLocationS3 = value; }
        }

        // Check to see if InputDataLocationS3 property is set
        internal bool IsSetInputDataLocationS3()
        {
            return this._inputDataLocationS3 != null;
        }

        /// <summary>
        /// Gets and sets the property InvalidRecordCount.
        /// </summary>
        public long InvalidRecordCount
        {
            get { return this._invalidRecordCount.GetValueOrDefault(); }
            set { this._invalidRecordCount = value; }
        }

        // Check to see if InvalidRecordCount property is set
        internal bool IsSetInvalidRecordCount()
        {
            return this._invalidRecordCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The time of the most recent edit to the <code>BatchPrediction</code>. The time is
        /// expressed in epoch time.
        /// </para>
        /// </summary>
        public DateTime LastUpdatedAt
        {
            get { return this._lastUpdatedAt.GetValueOrDefault(); }
            set { this._lastUpdatedAt = value; }
        }

        // Check to see if LastUpdatedAt property is set
        internal bool IsSetLastUpdatedAt()
        {
            return this._lastUpdatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A description of the most recent details about processing the batch prediction request.
        /// </para>
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property MLModelId. 
        /// <para>
        /// The ID of the <code>MLModel</code> that generated predictions for the <code>BatchPrediction</code>
        /// request.
        /// </para>
        /// </summary>
        public string MLModelId
        {
            get { return this._mlModelId; }
            set { this._mlModelId = value; }
        }

        // Check to see if MLModelId property is set
        internal bool IsSetMLModelId()
        {
            return this._mlModelId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A user-supplied name or description of the <code>BatchPrediction</code>.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property OutputUri. 
        /// <para>
        /// The location of an Amazon S3 bucket or directory to receive the operation results.
        /// The following substrings are not allowed in the <code>s3 key</code> portion of the
        /// <code>outputURI</code> field: ':', '//', '/./', '/../'.
        /// </para>
        /// </summary>
        public string OutputUri
        {
            get { return this._outputUri; }
            set { this._outputUri = value; }
        }

        // Check to see if OutputUri property is set
        internal bool IsSetOutputUri()
        {
            return this._outputUri != null;
        }

        /// <summary>
        /// Gets and sets the property StartedAt.
        /// </summary>
        public DateTime StartedAt
        {
            get { return this._startedAt.GetValueOrDefault(); }
            set { this._startedAt = value; }
        }

        // Check to see if StartedAt property is set
        internal bool IsSetStartedAt()
        {
            return this._startedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the <code>BatchPrediction</code>. This element can have one of the following
        /// values:
        /// </para>
        ///  <ul> <li> <code>PENDING</code> - Amazon Machine Learning (Amazon ML) submitted a
        /// request to generate predictions for a batch of observations.</li> <li> <code>INPROGRESS</code>
        /// - The process is underway.</li> <li> <code>FAILED</code> - The request to perform
        /// a batch prediction did not run to completion. It is not usable.</li> <li> <code>COMPLETED</code>
        /// - The batch prediction process completed successfully.</li> <li> <code>DELETED</code>
        /// - The <code>BatchPrediction</code> is marked as deleted. It is not usable.</li> </ul>
        /// </summary>
        public EntityStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TotalRecordCount.
        /// </summary>
        public long TotalRecordCount
        {
            get { return this._totalRecordCount.GetValueOrDefault(); }
            set { this._totalRecordCount = value; }
        }

        // Check to see if TotalRecordCount property is set
        internal bool IsSetTotalRecordCount()
        {
            return this._totalRecordCount.HasValue; 
        }

    }
}