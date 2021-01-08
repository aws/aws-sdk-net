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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// A pipeline execution summary.
    /// </summary>
    public partial class PipelineExecutionSummary
    {
        private string _pipelineExecutionArn;
        private string _pipelineExecutionDescription;
        private string _pipelineExecutionDisplayName;
        private PipelineExecutionStatus _pipelineExecutionStatus;
        private DateTime? _startTime;

        /// <summary>
        /// Gets and sets the property PipelineExecutionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the pipeline execution.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string PipelineExecutionArn
        {
            get { return this._pipelineExecutionArn; }
            set { this._pipelineExecutionArn = value; }
        }

        // Check to see if PipelineExecutionArn property is set
        internal bool IsSetPipelineExecutionArn()
        {
            return this._pipelineExecutionArn != null;
        }

        /// <summary>
        /// Gets and sets the property PipelineExecutionDescription. 
        /// <para>
        /// The description of the pipeline execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=3072)]
        public string PipelineExecutionDescription
        {
            get { return this._pipelineExecutionDescription; }
            set { this._pipelineExecutionDescription = value; }
        }

        // Check to see if PipelineExecutionDescription property is set
        internal bool IsSetPipelineExecutionDescription()
        {
            return this._pipelineExecutionDescription != null;
        }

        /// <summary>
        /// Gets and sets the property PipelineExecutionDisplayName. 
        /// <para>
        /// The display name of the pipeline execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=82)]
        public string PipelineExecutionDisplayName
        {
            get { return this._pipelineExecutionDisplayName; }
            set { this._pipelineExecutionDisplayName = value; }
        }

        // Check to see if PipelineExecutionDisplayName property is set
        internal bool IsSetPipelineExecutionDisplayName()
        {
            return this._pipelineExecutionDisplayName != null;
        }

        /// <summary>
        /// Gets and sets the property PipelineExecutionStatus. 
        /// <para>
        /// The status of the pipeline execution.
        /// </para>
        /// </summary>
        public PipelineExecutionStatus PipelineExecutionStatus
        {
            get { return this._pipelineExecutionStatus; }
            set { this._pipelineExecutionStatus = value; }
        }

        // Check to see if PipelineExecutionStatus property is set
        internal bool IsSetPipelineExecutionStatus()
        {
            return this._pipelineExecutionStatus != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start time of the pipeline execution.
        /// </para>
        /// </summary>
        public DateTime StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

    }
}