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
    /// Represents the output of a <c>GetBatchPrediction</c> operation.
    /// 
    ///  
    /// <para>
    ///  The content consists of the detailed metadata, the status, and the data file information
    /// of a <c>Batch Prediction</c>.
    /// </para>
    /// </summary>
    public partial class BatchPrediction
    {
        /// <summary>
        /// Gets and sets the property BatchPredictionDataSourceId. 
        /// <para>
        /// The ID of the <c>DataSource</c> that points to the group of observations to predict.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string BatchPredictionDataSourceId { get; set; }

        /// <summary>
        /// Checks to see if the BatchPredictionDataSourceId property is set.
        /// </summary>
        internal bool IsSetBatchPredictionDataSourceId() => this.BatchPredictionDataSourceId != null;

        /// <summary>
        /// Gets and sets the property BatchPredictionId. 
        /// <para>
        /// The ID assigned to the <c>BatchPrediction</c> at creation. This value should be identical
        /// to the value of the <c>BatchPredictionID</c> in the request. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string BatchPredictionId { get; set; }

        /// <summary>
        /// Checks to see if the BatchPredictionId property is set.
        /// </summary>
        internal bool IsSetBatchPredictionId() => this.BatchPredictionId != null;

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
        /// The time that the <c>BatchPrediction</c> was created. The time is expressed in epoch
        /// time.
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
        /// The AWS user account that invoked the <c>BatchPrediction</c>. The account type can
        /// be either an AWS root account or an AWS Identity and Access Management (IAM) user
        /// account.
        /// </para>
        /// </summary>
        public string CreatedByIamUser { get; set; }

        /// <summary>
        /// Checks to see if the CreatedByIamUser property is set.
        /// </summary>
        internal bool IsSetCreatedByIamUser() => this.CreatedByIamUser != null;

        /// <summary>
        /// Gets and sets the property FinishedAt.
        /// </summary>
        public DateTime? FinishedAt { get; set; }

        /// <summary>
        /// Checks to see if the FinishedAt property is set.
        /// </summary>
        internal bool IsSetFinishedAt() => this.FinishedAt.HasValue;

        /// <summary>
        /// Gets and sets the property InputDataLocationS3. 
        /// <para>
        /// The location of the data file or directory in Amazon Simple Storage Service (Amazon
        /// S3).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string InputDataLocationS3 { get; set; }

        /// <summary>
        /// Checks to see if the InputDataLocationS3 property is set.
        /// </summary>
        internal bool IsSetInputDataLocationS3() => this.InputDataLocationS3 != null;

        /// <summary>
        /// Gets and sets the property InvalidRecordCount.
        /// </summary>
        public long? InvalidRecordCount { get; set; }

        /// <summary>
        /// Checks to see if the InvalidRecordCount property is set.
        /// </summary>
        internal bool IsSetInvalidRecordCount() => this.InvalidRecordCount.HasValue;

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
        /// Gets and sets the property MLModelId. 
        /// <para>
        /// The ID of the <c>MLModel</c> that generated predictions for the <c>BatchPrediction</c>
        /// request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string MLModelId { get; set; }

        /// <summary>
        /// Checks to see if the MLModelId property is set.
        /// </summary>
        internal bool IsSetMLModelId() => this.MLModelId != null;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A description of the most recent details about processing the batch prediction request.
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
        /// A user-supplied name or description of the <c>BatchPrediction</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OutputUri. 
        /// <para>
        /// The location of an Amazon S3 bucket or directory to receive the operation results.
        /// The following substrings are not allowed in the <c>s3 key</c> portion of the <c>outputURI</c>
        /// field: ':', '//', '/./', '/../'.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string OutputUri { get; set; }

        /// <summary>
        /// Checks to see if the OutputUri property is set.
        /// </summary>
        internal bool IsSetOutputUri() => this.OutputUri != null;

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
        /// The status of the <c>BatchPrediction</c>. This element can have one of the following
        /// values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PENDING</c> - Amazon Machine Learning (Amazon ML) submitted a request to generate
        /// predictions for a batch of observations.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INPROGRESS</c> - The process is underway.
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
        public EntityStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TotalRecordCount.
        /// </summary>
        public long? TotalRecordCount { get; set; }

        /// <summary>
        /// Checks to see if the TotalRecordCount property is set.
        /// </summary>
        internal bool IsSetTotalRecordCount() => this.TotalRecordCount.HasValue;
    }
}
