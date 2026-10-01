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

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// This is the response object from the DescribeDatasetExportJob operation.
    /// </summary>
    public partial class DescribeDatasetExportJobResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CompletedAt. 
        /// <para>
        /// The timestamp when the job completed, or null if the job is still running.
        /// </para>
        /// </summary>
        public DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Checks to see if the CompletedAt property is set.
        /// </summary>
        internal bool IsSetCompletedAt() => this.CompletedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DestinationS3Uri. 
        /// <para>
        /// The S3 URI where output clips are written.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string DestinationS3Uri { get; set; }

        /// <summary>
        /// Checks to see if the DestinationS3Uri property is set.
        /// </summary>
        internal bool IsSetDestinationS3Uri() => this.DestinationS3Uri != null;

        /// <summary>
        /// Gets and sets the property ErrorReportLocation. 
        /// <para>
        /// The location where the error report will be written on failure.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ExportErrorReportLocation ErrorReportLocation { get; set; }

        /// <summary>
        /// Checks to see if the ErrorReportLocation property is set.
        /// </summary>
        internal bool IsSetErrorReportLocation() => this.ErrorReportLocation != null;

        /// <summary>
        /// Gets and sets the property Input. 
        /// <para>
        /// The processing input that was provided in the CreateDatasetExportJob request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ProcessingInput Input { get; set; }

        /// <summary>
        /// Checks to see if the Input property is set.
        /// </summary>
        internal bool IsSetInput() => this.Input != null;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The unique identifier for the dataset export job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string JobId { get; set; }

        /// <summary>
        /// Checks to see if the JobId property is set.
        /// </summary>
        internal bool IsSetJobId() => this.JobId != null;

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The timestamp when the job started processing.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StartedAt { get; set; }

        /// <summary>
        /// Checks to see if the StartedAt property is set.
        /// </summary>
        internal bool IsSetStartedAt() => this.StartedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the dataset export job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DatasetExportJobStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property WorkspaceName. 
        /// <para>
        /// The name of the workspace that contains the dataset export job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string WorkspaceName { get; set; }

        /// <summary>
        /// Checks to see if the WorkspaceName property is set.
        /// </summary>
        internal bool IsSetWorkspaceName() => this.WorkspaceName != null;
    }
}
