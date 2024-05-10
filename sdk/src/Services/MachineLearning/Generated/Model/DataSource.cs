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
    /// Represents the output of the <c>GetDataSource</c> operation. 
    /// 
    ///  
    /// <para>
    ///  The content consists of the detailed metadata and data file information and the current
    /// status of the <c>DataSource</c>. 
    /// </para>
    /// </summary>
    public partial class DataSource
    {
        private bool? _computeStatistics;
        private long? _computeTime;
        private DateTime? _createdAt;
        private string _createdByIamUser;
        private string _dataLocationS3;
        private string _dataRearrangement;
        private long? _dataSizeInBytes;
        private string _dataSourceId;
        private DateTime? _finishedAt;
        private DateTime? _lastUpdatedAt;
        private string _message;
        private string _name;
        private long? _numberOfFiles;
        private RDSMetadata _rdsMetadata;
        private RedshiftMetadata _redshiftMetadata;
        private string _roleARN;
        private DateTime? _startedAt;
        private EntityStatus _status;

        /// <summary>
        /// Gets and sets the property ComputeStatistics. 
        /// <para>
        ///  The parameter is <c>true</c> if statistics need to be generated from the observation
        /// data. 
        /// </para>
        /// </summary>
        public bool? ComputeStatistics
        {
            get { return this._computeStatistics; }
            set { this._computeStatistics = value; }
        }

        // Check to see if ComputeStatistics property is set
        internal bool IsSetComputeStatistics()
        {
            return this._computeStatistics.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ComputeTime.
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
        /// The time that the <c>DataSource</c> was created. The time is expressed in epoch time.
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
        /// The AWS user account from which the <c>DataSource</c> was created. The account type
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
        /// Gets and sets the property DataLocationS3. 
        /// <para>
        /// The location and name of the data in Amazon Simple Storage Service (Amazon S3) that
        /// is used by a <c>DataSource</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
        public string DataLocationS3
        {
            get { return this._dataLocationS3; }
            set { this._dataLocationS3 = value; }
        }

        // Check to see if DataLocationS3 property is set
        internal bool IsSetDataLocationS3()
        {
            return this._dataLocationS3 != null;
        }

        /// <summary>
        /// Gets and sets the property DataRearrangement. 
        /// <para>
        /// A JSON string that represents the splitting and rearrangement requirement used when
        /// this <c>DataSource</c> was created.
        /// </para>
        /// </summary>
        public string DataRearrangement
        {
            get { return this._dataRearrangement; }
            set { this._dataRearrangement = value; }
        }

        // Check to see if DataRearrangement property is set
        internal bool IsSetDataRearrangement()
        {
            return this._dataRearrangement != null;
        }

        /// <summary>
        /// Gets and sets the property DataSizeInBytes. 
        /// <para>
        /// The total number of observations contained in the data files that the <c>DataSource</c>
        /// references.
        /// </para>
        /// </summary>
        public long? DataSizeInBytes
        {
            get { return this._dataSizeInBytes; }
            set { this._dataSizeInBytes = value; }
        }

        // Check to see if DataSizeInBytes property is set
        internal bool IsSetDataSizeInBytes()
        {
            return this._dataSizeInBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataSourceId. 
        /// <para>
        /// The ID that is assigned to the <c>DataSource</c> during creation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string DataSourceId
        {
            get { return this._dataSourceId; }
            set { this._dataSourceId = value; }
        }

        // Check to see if DataSourceId property is set
        internal bool IsSetDataSourceId()
        {
            return this._dataSourceId != null;
        }

        /// <summary>
        /// Gets and sets the property FinishedAt.
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
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The time of the most recent edit to the <c>BatchPrediction</c>. The time is expressed
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
        /// Gets and sets the property Message. 
        /// <para>
        /// A description of the most recent details about creating the <c>DataSource</c>.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// A user-supplied name or description of the <c>DataSource</c>.
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
        /// Gets and sets the property NumberOfFiles. 
        /// <para>
        /// The number of data files referenced by the <c>DataSource</c>.
        /// </para>
        /// </summary>
        public long? NumberOfFiles
        {
            get { return this._numberOfFiles; }
            set { this._numberOfFiles = value; }
        }

        // Check to see if NumberOfFiles property is set
        internal bool IsSetNumberOfFiles()
        {
            return this._numberOfFiles.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RDSMetadata.
        /// </summary>
        public RDSMetadata RDSMetadata
        {
            get { return this._rdsMetadata; }
            set { this._rdsMetadata = value; }
        }

        // Check to see if RDSMetadata property is set
        internal bool IsSetRDSMetadata()
        {
            return this._rdsMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property RedshiftMetadata.
        /// </summary>
        public RedshiftMetadata RedshiftMetadata
        {
            get { return this._redshiftMetadata; }
            set { this._redshiftMetadata = value; }
        }

        // Check to see if RedshiftMetadata property is set
        internal bool IsSetRedshiftMetadata()
        {
            return this._redshiftMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property RoleARN.
        /// </summary>
        [AWSProperty(Min=1, Max=110)]
        public string RoleARN
        {
            get { return this._roleARN; }
            set { this._roleARN = value; }
        }

        // Check to see if RoleARN property is set
        internal bool IsSetRoleARN()
        {
            return this._roleARN != null;
        }

        /// <summary>
        /// Gets and sets the property StartedAt.
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
        /// The current status of the <c>DataSource</c>. This element can have one of the following
        /// values: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// PENDING - Amazon Machine Learning (Amazon ML) submitted a request to create a <c>DataSource</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPROGRESS - The creation process is underway.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// FAILED - The request to create a <c>DataSource</c> did not run to completion. It is
        /// not usable.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// COMPLETED - The creation process completed successfully.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELETED - The <c>DataSource</c> is marked as deleted. It is not usable.
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

    }
}