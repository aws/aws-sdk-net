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

namespace Amazon.Personalize.Model
{
    /// <summary>
    /// Contains information on a batch inference job.
    /// </summary>
    public partial class BatchInferenceJob
    {
        /// <summary>
        /// Gets and sets the property BatchInferenceJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the batch inference job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string BatchInferenceJobArn { get; set; }

        /// <summary>
        /// Checks to see if the BatchInferenceJobArn property is set.
        /// </summary>
        internal bool IsSetBatchInferenceJobArn() => this.BatchInferenceJobArn != null;

        /// <summary>
        /// Gets and sets the property BatchInferenceJobConfig. 
        /// <para>
        /// A string to string map of the configuration details of a batch inference job.
        /// </para>
        /// </summary>
        public BatchInferenceJobConfig BatchInferenceJobConfig { get; set; }

        /// <summary>
        /// Checks to see if the BatchInferenceJobConfig property is set.
        /// </summary>
        internal bool IsSetBatchInferenceJobConfig() => this.BatchInferenceJobConfig != null;

        /// <summary>
        /// Gets and sets the property BatchInferenceJobMode. 
        /// <para>
        /// The job's mode.
        /// </para>
        /// </summary>
        public BatchInferenceJobMode BatchInferenceJobMode { get; set; }

        /// <summary>
        /// Checks to see if the BatchInferenceJobMode property is set.
        /// </summary>
        internal bool IsSetBatchInferenceJobMode() => this.BatchInferenceJobMode != null;

        /// <summary>
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// The time at which the batch inference job was created.
        /// </para>
        /// </summary>
        public DateTime? CreationDateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationDateTime property is set.
        /// </summary>
        internal bool IsSetCreationDateTime() => this.CreationDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// If the batch inference job failed, the reason for the failure.
        /// </para>
        /// </summary>
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property FilterArn. 
        /// <para>
        /// The ARN of the filter used on the batch inference job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string FilterArn { get; set; }

        /// <summary>
        /// Checks to see if the FilterArn property is set.
        /// </summary>
        internal bool IsSetFilterArn() => this.FilterArn != null;

        /// <summary>
        /// Gets and sets the property JobInput. 
        /// <para>
        /// The Amazon S3 path that leads to the input data used to generate the batch inference
        /// job.
        /// </para>
        /// </summary>
        public BatchInferenceJobInput JobInput { get; set; }

        /// <summary>
        /// Checks to see if the JobInput property is set.
        /// </summary>
        internal bool IsSetJobInput() => this.JobInput != null;

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The name of the batch inference job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string JobName { get; set; }

        /// <summary>
        /// Checks to see if the JobName property is set.
        /// </summary>
        internal bool IsSetJobName() => this.JobName != null;

        /// <summary>
        /// Gets and sets the property JobOutput. 
        /// <para>
        /// The Amazon S3 bucket that contains the output data generated by the batch inference
        /// job.
        /// </para>
        /// </summary>
        public BatchInferenceJobOutput JobOutput { get; set; }

        /// <summary>
        /// Checks to see if the JobOutput property is set.
        /// </summary>
        internal bool IsSetJobOutput() => this.JobOutput != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedDateTime. 
        /// <para>
        /// The time at which the batch inference job was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedDateTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedDateTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedDateTime() => this.LastUpdatedDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property NumResults. 
        /// <para>
        /// The number of recommendations generated by the batch inference job. This number includes
        /// the error messages generated for failed input records.
        /// </para>
        /// </summary>
        public int? NumResults { get; set; }

        /// <summary>
        /// Checks to see if the NumResults property is set.
        /// </summary>
        internal bool IsSetNumResults() => this.NumResults.HasValue;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the Amazon Identity and Access Management (IAM) role that requested the
        /// batch inference job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property SolutionVersionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the solution version from which the batch inference
        /// job was created.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string SolutionVersionArn { get; set; }

        /// <summary>
        /// Checks to see if the SolutionVersionArn property is set.
        /// </summary>
        internal bool IsSetSolutionVersionArn() => this.SolutionVersionArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the batch inference job. The status is one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// PENDING
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IN PROGRESS
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACTIVE
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CREATE FAILED
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property ThemeGenerationConfig. 
        /// <para>
        /// The job's theme generation settings.
        /// </para>
        /// </summary>
        public ThemeGenerationConfig ThemeGenerationConfig { get; set; }

        /// <summary>
        /// Checks to see if the ThemeGenerationConfig property is set.
        /// </summary>
        internal bool IsSetThemeGenerationConfig() => this.ThemeGenerationConfig != null;
    }
}
