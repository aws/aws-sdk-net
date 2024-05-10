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
 * Do not modify this file. This file is generated from the machinelearning-2014-12-12.normal.json service model.
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
namespace Amazon.MachineLearning.Model
{
    /// <summary>
    /// Represents the output of a <c>GetBatchPrediction</c> operation and describes a <c>BatchPrediction</c>.
    /// </summary>
    public partial class GetBatchPredictionResponse : AmazonWebServiceResponse
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
        private string _logUri;
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
        /// The ID of the <c>DataSource</c> that was used to create the <c>BatchPrediction</c>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// An ID assigned to the <c>BatchPrediction</c> at creation. This value should be identical
        /// to the value of the <c>BatchPredictionID</c> in the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// <para>
        /// The approximate CPU time in milliseconds that Amazon Machine Learning spent processing
        /// the <c>BatchPrediction</c>, normalized and scaled on computation resources. <c>ComputeTime</c>
        /// is only available if the <c>BatchPrediction</c> is in the <c>COMPLETED</c> state.
        /// </para>
        /// </summary>
        public long? ComputeTime
        {
            get { return this._computeTime; }
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
        /// The time when the <c>BatchPrediction</c> was created. The time is expressed in epoch
        /// time.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
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
        /// The AWS user account that invoked the <c>BatchPrediction</c>. The account type can
        /// be either an AWS root account or an AWS Identity and Access Management (IAM) user
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
        /// <para>
        /// The epoch time when Amazon Machine Learning marked the <c>BatchPrediction</c> as <c>COMPLETED</c>
        /// or <c>FAILED</c>. <c>FinishedAt</c> is only available when the <c>BatchPrediction</c>
        /// is in the <c>COMPLETED</c> or <c>FAILED</c> state.
        /// </para>
        /// </summary>
        public DateTime? FinishedAt
        {
            get { return this._finishedAt; }
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
        [AWSProperty(Max=2048)]
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
        /// <para>
        /// The number of invalid records that Amazon Machine Learning saw while processing the
        /// <c>BatchPrediction</c>.
        /// </para>
        /// </summary>
        public long? InvalidRecordCount
        {
            get { return this._invalidRecordCount; }
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
        /// The time of the most recent edit to <c>BatchPrediction</c>. The time is expressed
        /// in epoch time.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt
        {
            get { return this._lastUpdatedAt; }
            set { this._lastUpdatedAt = value; }
        }

        // Check to see if LastUpdatedAt property is set
        internal bool IsSetLastUpdatedAt()
        {
            return this._lastUpdatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LogUri. 
        /// <para>
        /// A link to the file that contains logs of the <c>CreateBatchPrediction</c> operation.
        /// </para>
        /// </summary>
        public string LogUri
        {
            get { return this._logUri; }
            set { this._logUri = value; }
        }

        // Check to see if LogUri property is set
        internal bool IsSetLogUri()
        {
            return this._logUri != null;
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A description of the most recent details about processing the batch prediction request.
        /// </para>
        /// </summary>
        [AWSProperty(Max=10240)]
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
        /// The ID of the <c>MLModel</c> that generated predictions for the <c>BatchPrediction</c>
        /// request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// A user-supplied name or description of the <c>BatchPrediction</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
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
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
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
        /// <para>
        /// The epoch time when Amazon Machine Learning marked the <c>BatchPrediction</c> as <c>INPROGRESS</c>.
        /// <c>StartedAt</c> isn't available if the <c>BatchPrediction</c> is in the <c>PENDING</c>
        /// state.
        /// </para>
        /// </summary>
        public DateTime? StartedAt
        {
            get { return this._startedAt; }
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
        /// The status of the <c>BatchPrediction</c>, which can be one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PENDING</c> - Amazon Machine Learning (Amazon ML) submitted a request to generate
        /// batch predictions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INPROGRESS</c> - The batch predictions are in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> - The request to perform a batch prediction did not run to completion.
        /// It is not usable.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>COMPLETED</c> - The batch prediction process completed successfully.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETED</c> - The <c>BatchPrediction</c> is marked as deleted. It is not usable.
        /// </para>
        ///  </li> </ul>
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
        /// <para>
        /// The number of total records that Amazon Machine Learning saw while processing the
        /// <c>BatchPrediction</c>.
        /// </para>
        /// </summary>
        public long? TotalRecordCount
        {
            get { return this._totalRecordCount; }
            set { this._totalRecordCount = value; }
        }

        // Check to see if TotalRecordCount property is set
        internal bool IsSetTotalRecordCount()
        {
            return this._totalRecordCount.HasValue; 
        }

    }
}