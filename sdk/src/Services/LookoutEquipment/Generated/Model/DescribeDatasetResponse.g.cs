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
    /// This is the response object from the DescribeDataset operation.
    /// </summary>
    public partial class DescribeDatasetResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// Specifies the time the dataset was created in Lookout for Equipment. 
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
        /// during the most recent ingestion of this particular dataset. 
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
        ///  Gives statistics associated with the given dataset for the latest successful associated
        /// ingestion job id. These statistics primarily relate to quantifying incorrect data
        /// such as MissingCompleteSensorData, MissingSensorData, UnsupportedDateFormats, InsufficientSensorData,
        /// and DuplicateTimeStamps. 
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
        /// during the most recent ingestion of this particular dataset. 
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
        /// The Amazon Resource Name (ARN) of the dataset being described. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string DatasetArn { get; set; }

        /// <summary>
        /// Checks to see if the DatasetArn property is set.
        /// </summary>
        internal bool IsSetDatasetArn() => this.DatasetArn != null;

        /// <summary>
        /// Gets and sets the property DatasetName. 
        /// <para>
        /// The name of the dataset being described. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string DatasetName { get; set; }

        /// <summary>
        /// Checks to see if the DatasetName property is set.
        /// </summary>
        internal bool IsSetDatasetName() => this.DatasetName != null;

        /// <summary>
        /// Gets and sets the property IngestedFilesSummary. 
        /// <para>
        /// IngestedFilesSummary associated with the given dataset for the latest successful associated
        /// ingestion job id. 
        /// </para>
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
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// Specifies the time the dataset was last updated, if it was. 
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedAt property is set.
        /// </summary>
        internal bool IsSetLastUpdatedAt() => this.LastUpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the IAM role that you are using for this the data
        /// ingestion job. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property Schema. 
        /// <para>
        /// A JSON description of the data that is in each time series dataset, including names,
        /// column names, and data types. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000000)]
        public string Schema { get; set; }

        /// <summary>
        /// Checks to see if the Schema property is set.
        /// </summary>
        internal bool IsSetSchema() => this.Schema != null;

        /// <summary>
        /// Gets and sets the property ServerSideKmsKeyId. 
        /// <para>
        /// Provides the identifier of the KMS key used to encrypt dataset data by Amazon Lookout
        /// for Equipment. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string ServerSideKmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the ServerSideKmsKeyId property is set.
        /// </summary>
        internal bool IsSetServerSideKmsKeyId() => this.ServerSideKmsKeyId != null;

        /// <summary>
        /// Gets and sets the property SourceDatasetArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the source dataset from which the current data being
        /// described was imported from.
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
        /// Indicates the status of the dataset. 
        /// </para>
        /// </summary>
        public DatasetStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
