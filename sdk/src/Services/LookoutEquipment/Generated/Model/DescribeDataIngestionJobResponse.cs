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
    /// This is the response object from the DescribeDataIngestionJob operation.
    /// </summary>
    public partial class DescribeDataIngestionJobResponse : AmazonWebServiceResponse
    {
        private DateTime? _createdAt;
        private string _datasetArn;
        private string _failedReason;
        private IngestionInputConfiguration _ingestionInputConfiguration;
        private string _jobId;
        private string _roleArn;
        private IngestionJobStatus _status;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time at which the data ingestion job was created. 
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
        /// Gets and sets the property Status. 
        /// <para>
        /// Indicates the status of the <code>DataIngestionJob</code> operation. 
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

    }
}