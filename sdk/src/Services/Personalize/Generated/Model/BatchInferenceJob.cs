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
 * Do not modify this file. This file is generated from the personalize-2018-05-22.normal.json service model.
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
        private string _batchInferenceJobArn;
        private BatchInferenceJobConfig _batchInferenceJobConfig;
        private BatchInferenceJobMode _batchInferenceJobMode;
        private DateTime? _creationDateTime;
        private string _failureReason;
        private string _filterArn;
        private BatchInferenceJobInput _jobInput;
        private string _jobName;
        private BatchInferenceJobOutput _jobOutput;
        private DateTime? _lastUpdatedDateTime;
        private int? _numResults;
        private string _roleArn;
        private string _solutionVersionArn;
        private string _status;
        private ThemeGenerationConfig _themeGenerationConfig;

        /// <summary>
        /// Gets and sets the property BatchInferenceJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the batch inference job.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string BatchInferenceJobArn
        {
            get { return this._batchInferenceJobArn; }
            set { this._batchInferenceJobArn = value; }
        }

        // Check to see if BatchInferenceJobArn property is set
        internal bool IsSetBatchInferenceJobArn()
        {
            return this._batchInferenceJobArn != null;
        }

        /// <summary>
        /// Gets and sets the property BatchInferenceJobConfig. 
        /// <para>
        /// A string to string map of the configuration details of a batch inference job.
        /// </para>
        /// </summary>
        public BatchInferenceJobConfig BatchInferenceJobConfig
        {
            get { return this._batchInferenceJobConfig; }
            set { this._batchInferenceJobConfig = value; }
        }

        // Check to see if BatchInferenceJobConfig property is set
        internal bool IsSetBatchInferenceJobConfig()
        {
            return this._batchInferenceJobConfig != null;
        }

        /// <summary>
        /// Gets and sets the property BatchInferenceJobMode. 
        /// <para>
        /// The job's mode.
        /// </para>
        /// </summary>
        public BatchInferenceJobMode BatchInferenceJobMode
        {
            get { return this._batchInferenceJobMode; }
            set { this._batchInferenceJobMode = value; }
        }

        // Check to see if BatchInferenceJobMode property is set
        internal bool IsSetBatchInferenceJobMode()
        {
            return this._batchInferenceJobMode != null;
        }

        /// <summary>
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// The time at which the batch inference job was created.
        /// </para>
        /// </summary>
        public DateTime? CreationDateTime
        {
            get { return this._creationDateTime; }
            set { this._creationDateTime = value; }
        }

        // Check to see if CreationDateTime property is set
        internal bool IsSetCreationDateTime()
        {
            return this._creationDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// If the batch inference job failed, the reason for the failure.
        /// </para>
        /// </summary>
        public string FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property FilterArn. 
        /// <para>
        /// The ARN of the filter used on the batch inference job.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string FilterArn
        {
            get { return this._filterArn; }
            set { this._filterArn = value; }
        }

        // Check to see if FilterArn property is set
        internal bool IsSetFilterArn()
        {
            return this._filterArn != null;
        }

        /// <summary>
        /// Gets and sets the property JobInput. 
        /// <para>
        /// The Amazon S3 path that leads to the input data used to generate the batch inference
        /// job.
        /// </para>
        /// </summary>
        public BatchInferenceJobInput JobInput
        {
            get { return this._jobInput; }
            set { this._jobInput = value; }
        }

        // Check to see if JobInput property is set
        internal bool IsSetJobInput()
        {
            return this._jobInput != null;
        }

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The name of the batch inference job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string JobName
        {
            get { return this._jobName; }
            set { this._jobName = value; }
        }

        // Check to see if JobName property is set
        internal bool IsSetJobName()
        {
            return this._jobName != null;
        }

        /// <summary>
        /// Gets and sets the property JobOutput. 
        /// <para>
        /// The Amazon S3 bucket that contains the output data generated by the batch inference
        /// job.
        /// </para>
        /// </summary>
        public BatchInferenceJobOutput JobOutput
        {
            get { return this._jobOutput; }
            set { this._jobOutput = value; }
        }

        // Check to see if JobOutput property is set
        internal bool IsSetJobOutput()
        {
            return this._jobOutput != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedDateTime. 
        /// <para>
        /// The time at which the batch inference job was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedDateTime
        {
            get { return this._lastUpdatedDateTime; }
            set { this._lastUpdatedDateTime = value; }
        }

        // Check to see if LastUpdatedDateTime property is set
        internal bool IsSetLastUpdatedDateTime()
        {
            return this._lastUpdatedDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumResults. 
        /// <para>
        /// The number of recommendations generated by the batch inference job. This number includes
        /// the error messages generated for failed input records.
        /// </para>
        /// </summary>
        public int? NumResults
        {
            get { return this._numResults; }
            set { this._numResults = value; }
        }

        // Check to see if NumResults property is set
        internal bool IsSetNumResults()
        {
            return this._numResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the Amazon Identity and Access Management (IAM) role that requested the
        /// batch inference job.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
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
        /// Gets and sets the property SolutionVersionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the solution version from which the batch inference
        /// job was created.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string SolutionVersionArn
        {
            get { return this._solutionVersionArn; }
            set { this._solutionVersionArn = value; }
        }

        // Check to see if SolutionVersionArn property is set
        internal bool IsSetSolutionVersionArn()
        {
            return this._solutionVersionArn != null;
        }

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
        [AWSProperty(Max=256)]
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property ThemeGenerationConfig. 
        /// <para>
        /// The job's theme generation settings.
        /// </para>
        /// </summary>
        public ThemeGenerationConfig ThemeGenerationConfig
        {
            get { return this._themeGenerationConfig; }
            set { this._themeGenerationConfig = value; }
        }

        // Check to see if ThemeGenerationConfig property is set
        internal bool IsSetThemeGenerationConfig()
        {
            return this._themeGenerationConfig != null;
        }

    }
}