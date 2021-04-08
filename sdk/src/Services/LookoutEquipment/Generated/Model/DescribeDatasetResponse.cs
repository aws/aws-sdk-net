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

namespace Amazon.LookoutEquipment.Model
{
    /// <summary>
    /// This is the response object from the DescribeDataset operation.
    /// </summary>
    public partial class DescribeDatasetResponse : AmazonWebServiceResponse
    {
        private DateTime? _createdAt;
        private string _datasetArn;
        private string _datasetName;
        private IngestionInputConfiguration _ingestionInputConfiguration;
        private DateTime? _lastUpdatedAt;
        private string _schema;
        private string _serverSideKmsKeyId;
        private DatasetStatus _status;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// Specifies the time the dataset was created in Amazon Lookout for Equipment. 
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
        /// Provides the identifier of the AWS KMS customer master key (CMK) used to encrypt dataset
        /// data by Amazon Lookout for Equipment. 
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