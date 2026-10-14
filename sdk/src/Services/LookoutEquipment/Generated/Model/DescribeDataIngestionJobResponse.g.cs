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

namespace Amazon.LookoutEquipment.Model
{
    /// <summary>
    /// This is the response object from the DescribeDataIngestionJob operation.
    /// </summary>
    public partial class DescribeDataIngestionJobResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time at which the data ingestion job was created. 
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DataEndTime. 
        /// <para>
        ///  Indicates the latest timestamp corresponding to data that was successfully ingested
        /// during this specific ingestion job. 
        /// </para>
        /// </summary>
        public DateTime? DataEndTime { get; set; }

        /// <summary>
        /// Checks to see if the DataEndTime property is set.
        /// </summary>
        internal bool IsSetDataEndTime() => this.DataEndTime.HasValue;

        /// <summary>
        /// Gets and sets the property DataQualitySummary. 
        /// <para>
        ///  Gives statistics about a completed ingestion job. These statistics primarily relate
        /// to quantifying incorrect data such as MissingCompleteSensorData, MissingSensorData,
        /// UnsupportedDateFormats, InsufficientSensorData, and DuplicateTimeStamps. 
        /// </para>
        /// </summary>
        public DataQualitySummary DataQualitySummary { get; set; }

        /// <summary>
        /// Checks to see if the DataQualitySummary property is set.
        /// </summary>
        internal bool IsSetDataQualitySummary() => this.DataQualitySummary != null;

        /// <summary>
        /// Gets and sets the property DataStartTime. 
        /// <para>
        ///  Indicates the earliest timestamp corresponding to data that was successfully ingested
        /// during this specific ingestion job. 
        /// </para>
        /// </summary>
        public DateTime? DataStartTime { get; set; }

        /// <summary>
        /// Checks to see if the DataStartTime property is set.
        /// </summary>
        internal bool IsSetDataStartTime() => this.DataStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property DatasetArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the dataset being used in the data ingestion job.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string DatasetArn { get; set; }

        /// <summary>
        /// Checks to see if the DatasetArn property is set.
        /// </summary>
        internal bool IsSetDatasetArn() => this.DatasetArn != null;

        /// <summary>
        /// Gets and sets the property FailedReason. 
        /// <para>
        /// Specifies the reason for failure when a data ingestion job has failed. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 5000)]
        public string FailedReason { get; set; }

        /// <summary>
        /// Checks to see if the FailedReason property is set.
        /// </summary>
        internal bool IsSetFailedReason() => this.FailedReason != null;

        /// <summary>
        /// Gets and sets the property IngestedDataSize. 
        /// <para>
        ///  Indicates the size of the ingested dataset. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? IngestedDataSize { get; set; }

        /// <summary>
        /// Checks to see if the IngestedDataSize property is set.
        /// </summary>
        internal bool IsSetIngestedDataSize() => this.IngestedDataSize.HasValue;

        /// <summary>
        /// Gets and sets the property IngestedFilesSummary.
        /// </summary>
        public IngestedFilesSummary IngestedFilesSummary { get; set; }

        /// <summary>
        /// Checks to see if the IngestedFilesSummary property is set.
        /// </summary>
        internal bool IsSetIngestedFilesSummary() => this.IngestedFilesSummary != null;

        /// <summary>
        /// Gets and sets the property IngestionInputConfiguration. 
        /// <para>
        /// Specifies the S3 location configuration for the data input for the data ingestion
        /// job. 
        /// </para>
        /// </summary>
        public IngestionInputConfiguration IngestionInputConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the IngestionInputConfiguration property is set.
        /// </summary>
        internal bool IsSetIngestionInputConfiguration() => this.IngestionInputConfiguration != null;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// Indicates the job ID of the data ingestion job. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 32)]
        public string JobId { get; set; }

        /// <summary>
        /// Checks to see if the JobId property is set.
        /// </summary>
        internal bool IsSetJobId() => this.JobId != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an IAM role with permission to access the data source
        /// being ingested. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property SourceDatasetArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the source dataset from which the data used for
        /// the data ingestion job was imported from.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string SourceDatasetArn { get; set; }

        /// <summary>
        /// Checks to see if the SourceDatasetArn property is set.
        /// </summary>
        internal bool IsSetSourceDatasetArn() => this.SourceDatasetArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Indicates the status of the <c>DataIngestionJob</c> operation. 
        /// </para>
        /// </summary>
        public IngestionJobStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusDetail. 
        /// <para>
        ///  Provides details about status of the ingestion job that is currently in progress.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 5000)]
        public string StatusDetail { get; set; }

        /// <summary>
        /// Checks to see if the StatusDetail property is set.
        /// </summary>
        internal bool IsSetStatusDetail() => this.StatusDetail != null;
    }
}
