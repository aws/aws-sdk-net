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
        /// <summary>
        /// Gets and sets the property ComputeStatistics. 
        /// <para>
        ///  The parameter is <c>true</c> if statistics need to be generated from the observation
        /// data. 
        /// </para>
        /// </summary>
        public bool? ComputeStatistics { get; set; }

        /// <summary>
        /// Checks to see if the ComputeStatistics property is set.
        /// </summary>
        internal bool IsSetComputeStatistics() => this.ComputeStatistics.HasValue;

        /// <summary>
        /// Gets and sets the property ComputeTime.
        /// </summary>
        public long? ComputeTime { get; set; }

        /// <summary>
        /// Checks to see if the ComputeTime property is set.
        /// </summary>
        internal bool IsSetComputeTime() => this.ComputeTime.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time that the <c>DataSource</c> was created. The time is expressed in epoch time.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedByIamUser. 
        /// <para>
        /// The AWS user account from which the <c>DataSource</c> was created. The account type
        /// can be either an AWS root account or an AWS Identity and Access Management (IAM) user
        /// account.
        /// </para>
        /// </summary>
        public string CreatedByIamUser { get; set; }

        /// <summary>
        /// Checks to see if the CreatedByIamUser property is set.
        /// </summary>
        internal bool IsSetCreatedByIamUser() => this.CreatedByIamUser != null;

        /// <summary>
        /// Gets and sets the property DataLocationS3. 
        /// <para>
        /// The location and name of the data in Amazon Simple Storage Service (Amazon S3) that
        /// is used by a <c>DataSource</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string DataLocationS3 { get; set; }

        /// <summary>
        /// Checks to see if the DataLocationS3 property is set.
        /// </summary>
        internal bool IsSetDataLocationS3() => this.DataLocationS3 != null;

        /// <summary>
        /// Gets and sets the property DataRearrangement. 
        /// <para>
        /// A JSON string that represents the splitting and rearrangement requirement used when
        /// this <c>DataSource</c> was created.
        /// </para>
        /// </summary>
        public string DataRearrangement { get; set; }

        /// <summary>
        /// Checks to see if the DataRearrangement property is set.
        /// </summary>
        internal bool IsSetDataRearrangement() => this.DataRearrangement != null;

        /// <summary>
        /// Gets and sets the property DataSizeInBytes. 
        /// <para>
        /// The total number of observations contained in the data files that the <c>DataSource</c>
        /// references.
        /// </para>
        /// </summary>
        public long? DataSizeInBytes { get; set; }

        /// <summary>
        /// Checks to see if the DataSizeInBytes property is set.
        /// </summary>
        internal bool IsSetDataSizeInBytes() => this.DataSizeInBytes.HasValue;

        /// <summary>
        /// Gets and sets the property DataSourceId. 
        /// <para>
        /// The ID that is assigned to the <c>DataSource</c> during creation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string DataSourceId { get; set; }

        /// <summary>
        /// Checks to see if the DataSourceId property is set.
        /// </summary>
        internal bool IsSetDataSourceId() => this.DataSourceId != null;

        /// <summary>
        /// Gets and sets the property FinishedAt.
        /// </summary>
        public DateTime? FinishedAt { get; set; }

        /// <summary>
        /// Checks to see if the FinishedAt property is set.
        /// </summary>
        internal bool IsSetFinishedAt() => this.FinishedAt.HasValue;

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The time of the most recent edit to the <c>BatchPrediction</c>. The time is expressed
        /// in epoch time.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedAt property is set.
        /// </summary>
        internal bool IsSetLastUpdatedAt() => this.LastUpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A description of the most recent details about creating the <c>DataSource</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10240)]
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A user-supplied name or description of the <c>DataSource</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NumberOfFiles. 
        /// <para>
        /// The number of data files referenced by the <c>DataSource</c>.
        /// </para>
        /// </summary>
        public long? NumberOfFiles { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfFiles property is set.
        /// </summary>
        internal bool IsSetNumberOfFiles() => this.NumberOfFiles.HasValue;

        /// <summary>
        /// Gets and sets the property RDSMetadata.
        /// </summary>
        public RDSMetadata RDSMetadata { get; set; }

        /// <summary>
        /// Checks to see if the RDSMetadata property is set.
        /// </summary>
        internal bool IsSetRDSMetadata() => this.RDSMetadata != null;

        /// <summary>
        /// Gets and sets the property RedshiftMetadata.
        /// </summary>
        public RedshiftMetadata RedshiftMetadata { get; set; }

        /// <summary>
        /// Checks to see if the RedshiftMetadata property is set.
        /// </summary>
        internal bool IsSetRedshiftMetadata() => this.RedshiftMetadata != null;

        /// <summary>
        /// Gets and sets the property RoleARN.
        /// </summary>
        [AWSProperty(Min = 1, Max = 110)]
        public string RoleARN { get; set; }

        /// <summary>
        /// Checks to see if the RoleARN property is set.
        /// </summary>
        internal bool IsSetRoleARN() => this.RoleARN != null;

        /// <summary>
        /// Gets and sets the property StartedAt.
        /// </summary>
        public DateTime? StartedAt { get; set; }

        /// <summary>
        /// Checks to see if the StartedAt property is set.
        /// </summary>
        internal bool IsSetStartedAt() => this.StartedAt.HasValue;

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
        public EntityStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
