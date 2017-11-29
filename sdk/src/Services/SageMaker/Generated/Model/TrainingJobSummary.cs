/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Provides summary information about a training job.
    /// </summary>
    public partial class TrainingJobSummary
    {
        private DateTime? _creationTime;
        private DateTime? _lastModifiedTime;
        private DateTime? _trainingEndTime;
        private string _trainingJobArn;
        private string _trainingJobName;
        private TrainingJobStatus _trainingJobStatus;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// A timestamp that shows when the training job was created.
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        ///  Timestamp when the training job was last modified. 
        /// </para>
        /// </summary>
        public DateTime LastModifiedTime
        {
            get { return this._lastModifiedTime.GetValueOrDefault(); }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TrainingEndTime. 
        /// <para>
        /// A timestamp that shows when the training job ended. This field is set only if the
        /// training job has one of the terminal statuses (<code>Completed</code>, <code>Failed</code>,
        /// or <code>Stopped</code>). 
        /// </para>
        /// </summary>
        public DateTime TrainingEndTime
        {
            get { return this._trainingEndTime.GetValueOrDefault(); }
            set { this._trainingEndTime = value; }
        }

        // Check to see if TrainingEndTime property is set
        internal bool IsSetTrainingEndTime()
        {
            return this._trainingEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TrainingJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the training job.
        /// </para>
        /// </summary>
        public string TrainingJobArn
        {
            get { return this._trainingJobArn; }
            set { this._trainingJobArn = value; }
        }

        // Check to see if TrainingJobArn property is set
        internal bool IsSetTrainingJobArn()
        {
            return this._trainingJobArn != null;
        }

        /// <summary>
        /// Gets and sets the property TrainingJobName. 
        /// <para>
        /// The name of the training job that you want a summary for.
        /// </para>
        /// </summary>
        public string TrainingJobName
        {
            get { return this._trainingJobName; }
            set { this._trainingJobName = value; }
        }

        // Check to see if TrainingJobName property is set
        internal bool IsSetTrainingJobName()
        {
            return this._trainingJobName != null;
        }

        /// <summary>
        /// Gets and sets the property TrainingJobStatus. 
        /// <para>
        /// The status of the training job.
        /// </para>
        /// </summary>
        public TrainingJobStatus TrainingJobStatus
        {
            get { return this._trainingJobStatus; }
            set { this._trainingJobStatus = value; }
        }

        // Check to see if TrainingJobStatus property is set
        internal bool IsSetTrainingJobStatus()
        {
            return this._trainingJobStatus != null;
        }

    }
}