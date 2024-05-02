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
 * Do not modify this file. This file is generated from the lookoutequipment-2020-12-15.normal.json service model.
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
namespace Amazon.LookoutEquipment.Model
{
    /// <summary>
    /// This is the response object from the DescribeDataIngestionJob operation.
    /// </summary>
    public partial class DescribeDataIngestionJobResponse : AmazonWebServiceResponse
    {
        private DateTime? _createdAt;
        private DateTime? _dataEndTime;
        private DataQualitySummary _dataQualitySummary;
        private string _datasetArn;
        private DateTime? _dataStartTime;
        private string _failedReason;
        private long? _ingestedDataSize;
        private IngestedFilesSummary _ingestedFilesSummary;
        private IngestionInputConfiguration _ingestionInputConfiguration;
        private string _jobId;
        private string _roleArn;
        private string _sourceDatasetArn;
        private IngestionJobStatus _status;
        private string _statusDetail;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time at which the data ingestion job was created. 
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
        /// Gets and sets the property DataEndTime. 
        /// <para>
        ///  Indicates the latest timestamp corresponding to data that was successfully ingested
        /// during this specific ingestion job. 
        /// </para>
        /// </summary>
        public DateTime? DataEndTime
        {
            get { return this._dataEndTime; }
            set { this._dataEndTime = value; }
        }

        // Check to see if DataEndTime property is set
        internal bool IsSetDataEndTime()
        {
            return this._dataEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataQualitySummary. 
        /// <para>
        ///  Gives statistics about a completed ingestion job. These statistics primarily relate
        /// to quantifying incorrect data such as MissingCompleteSensorData, MissingSensorData,
        /// UnsupportedDateFormats, InsufficientSensorData, and DuplicateTimeStamps. 
        /// </para>
        /// </summary>
        public DataQualitySummary DataQualitySummary
        {
            get { return this._dataQualitySummary; }
            set { this._dataQualitySummary = value; }
        }

        // Check to see if DataQualitySummary property is set
        internal bool IsSetDataQualitySummary()
        {
            return this._dataQualitySummary != null;
        }

        /// <summary>
        /// Gets and sets the property DatasetArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the dataset being used in the data ingestion job.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string DatasetArn
        {
            get { return this._datasetArn; }
            set { this._datasetArn = value; }
        }

        // Check to see if DatasetArn property is set
        internal bool IsSetDatasetArn()
        {
            return this._datasetArn != null;
        }

        /// <summary>
        /// Gets and sets the property DataStartTime. 
        /// <para>
        ///  Indicates the earliest timestamp corresponding to data that was successfully ingested
        /// during this specific ingestion job. 
        /// </para>
        /// </summary>
        public DateTime? DataStartTime
        {
            get { return this._dataStartTime; }
            set { this._dataStartTime = value; }
        }

        // Check to see if DataStartTime property is set
        internal bool IsSetDataStartTime()
        {
            return this._dataStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FailedReason. 
        /// <para>
        /// Specifies the reason for failure when a data ingestion job has failed. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5000)]
        public string FailedReason
        {
            get { return this._failedReason; }
            set { this._failedReason = value; }
        }

        // Check to see if FailedReason property is set
        internal bool IsSetFailedReason()
        {
            return this._failedReason != null;
        }

        /// <summary>
        /// Gets and sets the property IngestedDataSize. 
        /// <para>
        ///  Indicates the size of the ingested dataset. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? IngestedDataSize
        {
            get { return this._ingestedDataSize; }
            set { this._ingestedDataSize = value; }
        }

        // Check to see if IngestedDataSize property is set
        internal bool IsSetIngestedDataSize()
        {
            return this._ingestedDataSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IngestedFilesSummary.
        /// </summary>
        public IngestedFilesSummary IngestedFilesSummary
        {
            get { return this._ingestedFilesSummary; }
            set { this._ingestedFilesSummary = value; }
        }

        // Check to see if IngestedFilesSummary property is set
        internal bool IsSetIngestedFilesSummary()
        {
            return this._ingestedFilesSummary != null;
        }

        /// <summary>
        /// Gets and sets the property IngestionInputConfiguration. 
        /// <para>
        /// Specifies the S3 location configuration for the data input for the data ingestion
        /// job. 
        /// </para>
        /// </summary>
        public IngestionInputConfiguration IngestionInputConfiguration
        {
            get { return this._ingestionInputConfiguration; }
            set { this._ingestionInputConfiguration = value; }
        }

        // Check to see if IngestionInputConfiguration property is set
        internal bool IsSetIngestionInputConfiguration()
        {
            return this._ingestionInputConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// Indicates the job ID of the data ingestion job. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=32)]
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
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an IAM role with permission to access the data source
        /// being ingested. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property SourceDatasetArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the source dataset from which the data used for
        /// the data ingestion job was imported from.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string SourceDatasetArn
        {
            get { return this._sourceDatasetArn; }
            set { this._sourceDatasetArn = value; }
        }

        // Check to see if SourceDatasetArn property is set
        internal bool IsSetSourceDatasetArn()
        {
            return this._sourceDatasetArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Indicates the status of the <c>DataIngestionJob</c> operation. 
        /// </para>
        /// </summary>
        public IngestionJobStatus Status
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
        /// Gets and sets the property StatusDetail. 
        /// <para>
        ///  Provides details about status of the ingestion job that is currently in progress.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5000)]
        public string StatusDetail
        {
            get { return this._statusDetail; }
            set { this._statusDetail = value; }
        }

        // Check to see if StatusDetail property is set
        internal bool IsSetStatusDetail()
        {
            return this._statusDetail != null;
        }

    }
}