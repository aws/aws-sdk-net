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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Provides summary information about a labeling job.
    /// </summary>
    public partial class LabelingJobSummary
    {
        private string _annotationConsolidationLambdaArn;
        private DateTime? _creationTime;
        private string _failureReason;
        private LabelingJobInputConfig _inputConfig;
        private LabelCounters _labelCounters;
        private string _labelingJobArn;
        private string _labelingJobName;
        private LabelingJobOutput _labelingJobOutput;
        private LabelingJobStatus _labelingJobStatus;
        private DateTime? _lastModifiedTime;
        private string _preHumanTaskLambdaArn;
        private string _workteamArn;

        /// <summary>
        /// Gets and sets the property AnnotationConsolidationLambdaArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Lambda function used to consolidate the annotations
        /// from individual workers into a label for a data object. For more information, see
        /// <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sms-annotation-consolidation.html">Annotation
        /// Consolidation</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string AnnotationConsolidationLambdaArn
        {
            get { return this._annotationConsolidationLambdaArn; }
            set { this._annotationConsolidationLambdaArn = value; }
        }

        // Check to see if AnnotationConsolidationLambdaArn property is set
        internal bool IsSetAnnotationConsolidationLambdaArn()
        {
            return this._annotationConsolidationLambdaArn != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time that the job was created (timestamp).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// If the <c>LabelingJobStatus</c> field is <c>Failed</c>, this field contains a description
        /// of the error.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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
        /// Gets and sets the property InputConfig. 
        /// <para>
        /// Input configuration for the labeling job.
        /// </para>
        /// </summary>
        public LabelingJobInputConfig InputConfig
        {
            get { return this._inputConfig; }
            set { this._inputConfig = value; }
        }

        // Check to see if InputConfig property is set
        internal bool IsSetInputConfig()
        {
            return this._inputConfig != null;
        }

        /// <summary>
        /// Gets and sets the property LabelCounters. 
        /// <para>
        /// Counts showing the progress of the labeling job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LabelCounters LabelCounters
        {
            get { return this._labelCounters; }
            set { this._labelCounters = value; }
        }

        // Check to see if LabelCounters property is set
        internal bool IsSetLabelCounters()
        {
            return this._labelCounters != null;
        }

        /// <summary>
        /// Gets and sets the property LabelingJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) assigned to the labeling job when it was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
        public string LabelingJobArn
        {
            get { return this._labelingJobArn; }
            set { this._labelingJobArn = value; }
        }

        // Check to see if LabelingJobArn property is set
        internal bool IsSetLabelingJobArn()
        {
            return this._labelingJobArn != null;
        }

        /// <summary>
        /// Gets and sets the property LabelingJobName. 
        /// <para>
        /// The name of the labeling job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string LabelingJobName
        {
            get { return this._labelingJobName; }
            set { this._labelingJobName = value; }
        }

        // Check to see if LabelingJobName property is set
        internal bool IsSetLabelingJobName()
        {
            return this._labelingJobName != null;
        }

        /// <summary>
        /// Gets and sets the property LabelingJobOutput. 
        /// <para>
        /// The location of the output produced by the labeling job.
        /// </para>
        /// </summary>
        public LabelingJobOutput LabelingJobOutput
        {
            get { return this._labelingJobOutput; }
            set { this._labelingJobOutput = value; }
        }

        // Check to see if LabelingJobOutput property is set
        internal bool IsSetLabelingJobOutput()
        {
            return this._labelingJobOutput != null;
        }

        /// <summary>
        /// Gets and sets the property LabelingJobStatus. 
        /// <para>
        /// The current status of the labeling job. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LabelingJobStatus LabelingJobStatus
        {
            get { return this._labelingJobStatus; }
            set { this._labelingJobStatus = value; }
        }

        // Check to see if LabelingJobStatus property is set
        internal bool IsSetLabelingJobStatus()
        {
            return this._labelingJobStatus != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The date and time that the job was last modified (timestamp).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PreHumanTaskLambdaArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a Lambda function. The function is run before each
        /// data object is sent to a worker.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string PreHumanTaskLambdaArn
        {
            get { return this._preHumanTaskLambdaArn; }
            set { this._preHumanTaskLambdaArn = value; }
        }

        // Check to see if PreHumanTaskLambdaArn property is set
        internal bool IsSetPreHumanTaskLambdaArn()
        {
            return this._preHumanTaskLambdaArn != null;
        }

        /// <summary>
        /// Gets and sets the property WorkteamArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the work team assigned to the job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string WorkteamArn
        {
            get { return this._workteamArn; }
            set { this._workteamArn = value; }
        }

        // Check to see if WorkteamArn property is set
        internal bool IsSetWorkteamArn()
        {
            return this._workteamArn != null;
        }

    }
}