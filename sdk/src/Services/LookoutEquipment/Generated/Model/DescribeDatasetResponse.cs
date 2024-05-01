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
    /// This is the response object from the DescribeDataset operation.
    /// </summary>
    public partial class DescribeDatasetResponse : AmazonWebServiceResponse
    {
        private DateTime? _createdAt;
        private DateTime? _dataEndTime;
        private DataQualitySummary _dataQualitySummary;
        private string _datasetArn;
        private string _datasetName;
        private DateTime? _dataStartTime;
        private IngestedFilesSummary _ingestedFilesSummary;
        private IngestionInputConfiguration _ingestionInputConfiguration;
        private DateTime? _lastUpdatedAt;
        private string _roleArn;
        private string _schema;
        private string _serverSideKmsKeyId;
        private string _sourceDatasetArn;
        private DatasetStatus _status;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// Specifies the time the dataset was created in Lookout for Equipment. 
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
        /// during the most recent ingestion of this particular dataset. 
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
        ///  Gives statistics associated with the given dataset for the latest successful associated
        /// ingestion job id. These statistics primarily relate to quantifying incorrect data
        /// such as MissingCompleteSensorData, MissingSensorData, UnsupportedDateFormats, InsufficientSensorData,
        /// and DuplicateTimeStamps. 
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
        /// The Amazon Resource Name (ARN) of the dataset being described. 
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
        /// Gets and sets the property DatasetName. 
        /// <para>
        /// The name of the dataset being described. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string DatasetName
        {
            get { return this._datasetName; }
            set { this._datasetName = value; }
        }

        // Check to see if DatasetName property is set
        internal bool IsSetDatasetName()
        {
            return this._datasetName != null;
        }

        /// <summary>
        /// Gets and sets the property DataStartTime. 
        /// <para>
        ///  Indicates the earliest timestamp corresponding to data that was successfully ingested
        /// during the most recent ingestion of this particular dataset. 
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
        /// Gets and sets the property IngestedFilesSummary. 
        /// <para>
        /// IngestedFilesSummary associated with the given dataset for the latest successful associated
        /// ingestion job id. 
        /// </para>
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
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// Specifies the time the dataset was last updated, if it was. 
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
        /// Gets and sets the property RoleArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the IAM role that you are using for this the data
        /// ingestion job. 
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
        /// Gets and sets the property Schema. 
        /// <para>
        /// A JSON description of the data that is in each time series dataset, including names,
        /// column names, and data types. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000000)]
        public string Schema
        {
            get { return this._schema; }
            set { this._schema = value; }
        }

        // Check to see if Schema property is set
        internal bool IsSetSchema()
        {
            return this._schema != null;
        }

        /// <summary>
        /// Gets and sets the property ServerSideKmsKeyId. 
        /// <para>
        /// Provides the identifier of the KMS key used to encrypt dataset data by Amazon Lookout
        /// for Equipment. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string ServerSideKmsKeyId
        {
            get { return this._serverSideKmsKeyId; }
            set { this._serverSideKmsKeyId = value; }
        }

        // Check to see if ServerSideKmsKeyId property is set
        internal bool IsSetServerSideKmsKeyId()
        {
            return this._serverSideKmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property SourceDatasetArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the source dataset from which the current data being
        /// described was imported from.
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
        /// Indicates the status of the dataset. 
        /// </para>
        /// </summary>
        public DatasetStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}