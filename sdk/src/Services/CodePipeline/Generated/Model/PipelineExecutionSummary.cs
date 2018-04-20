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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// Summary information about a pipeline execution.
    /// </summary>
    public partial class PipelineExecutionSummary
    {
        private DateTime? _lastUpdateTime;
        private string _pipelineExecutionId;
        private List<SourceRevision> _sourceRevisions = new List<SourceRevision>();
        private DateTime? _startTime;
        private PipelineExecutionStatus _status;

        /// <summary>
        /// Gets and sets the property LastUpdateTime. 
        /// <para>
        /// The date and time of the last change to the pipeline execution, in timestamp format.
        /// </para>
        /// </summary>
        public DateTime LastUpdateTime
        {
            get { return this._lastUpdateTime.GetValueOrDefault(); }
            set { this._lastUpdateTime = value; }
        }

        // Check to see if LastUpdateTime property is set
        internal bool IsSetLastUpdateTime()
        {
            return this._lastUpdateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PipelineExecutionId. 
        /// <para>
        /// The ID of the pipeline execution.
        /// </para>
        /// </summary>
        public string PipelineExecutionId
        {
            get { return this._pipelineExecutionId; }
            set { this._pipelineExecutionId = value; }
        }

        // Check to see if PipelineExecutionId property is set
        internal bool IsSetPipelineExecutionId()
        {
            return this._pipelineExecutionId != null;
        }

        /// <summary>
        /// Gets and sets the property SourceRevisions.
        /// </summary>
        public List<SourceRevision> SourceRevisions
        {
            get { return this._sourceRevisions; }
            set { this._sourceRevisions = value; }
        }

        // Check to see if SourceRevisions property is set
        internal bool IsSetSourceRevisions()
        {
            return this._sourceRevisions != null && this._sourceRevisions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The date and time when the pipeline execution began, in timestamp format.
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

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the pipeline execution.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// InProgress: The pipeline execution is currently running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Succeeded: The pipeline execution was completed successfully. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Superseded: While this pipeline execution was waiting for the next stage to be completed,
        /// a newer pipeline execution advanced and continued through the pipeline instead. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Failed: The pipeline execution was not completed successfully.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public PipelineExecutionStatus Status
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