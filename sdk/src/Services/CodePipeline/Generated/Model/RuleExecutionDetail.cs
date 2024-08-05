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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
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
namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// The details of the runs for a rule and the results produced on an artifact as it passes
    /// through stages in the pipeline.
    /// </summary>
    public partial class RuleExecutionDetail
    {
        private RuleExecutionInput _input;
        private DateTime? _lastUpdateTime;
        private RuleExecutionOutput _output;
        private string _pipelineExecutionId;
        private int? _pipelineVersion;
        private string _ruleExecutionId;
        private string _ruleName;
        private string _stageName;
        private DateTime? _startTime;
        private RuleExecutionStatus _status;
        private string _updatedBy;

        /// <summary>
        /// Gets and sets the property Input. 
        /// <para>
        /// Input details for the rule execution, such as role ARN, Region, and input artifacts.
        /// </para>
        /// </summary>
        public RuleExecutionInput Input
        {
            get { return this._input; }
            set { this._input = value; }
        }

        // Check to see if Input property is set
        internal bool IsSetInput()
        {
            return this._input != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdateTime. 
        /// <para>
        /// The date and time of the last change to the rule execution, in timestamp format.
        /// </para>
        /// </summary>
        public DateTime? LastUpdateTime
        {
            get { return this._lastUpdateTime; }
            set { this._lastUpdateTime = value; }
        }

        // Check to see if LastUpdateTime property is set
        internal bool IsSetLastUpdateTime()
        {
            return this._lastUpdateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Output. 
        /// <para>
        /// Output details for the rule execution, such as the rule execution result.
        /// </para>
        /// </summary>
        public RuleExecutionOutput Output
        {
            get { return this._output; }
            set { this._output = value; }
        }

        // Check to see if Output property is set
        internal bool IsSetOutput()
        {
            return this._output != null;
        }

        /// <summary>
        /// Gets and sets the property PipelineExecutionId. 
        /// <para>
        /// The ID of the pipeline execution in the stage where the rule was run. Use the <a>GetPipelineState</a>
        /// action to retrieve the current pipelineExecutionId of the stage.
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
        /// Gets and sets the property PipelineVersion. 
        /// <para>
        /// The version number of the pipeline with the stage where the rule was run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? PipelineVersion
        {
            get { return this._pipelineVersion; }
            set { this._pipelineVersion = value; }
        }

        // Check to see if PipelineVersion property is set
        internal bool IsSetPipelineVersion()
        {
            return this._pipelineVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RuleExecutionId. 
        /// <para>
        /// The ID of the run for the rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string RuleExecutionId
        {
            get { return this._ruleExecutionId; }
            set { this._ruleExecutionId = value; }
        }

        // Check to see if RuleExecutionId property is set
        internal bool IsSetRuleExecutionId()
        {
            return this._ruleExecutionId != null;
        }

        /// <summary>
        /// Gets and sets the property RuleName. 
        /// <para>
        /// The name of the rule that was run in the stage.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string RuleName
        {
            get { return this._ruleName; }
            set { this._ruleName = value; }
        }

        // Check to see if RuleName property is set
        internal bool IsSetRuleName()
        {
            return this._ruleName != null;
        }

        /// <summary>
        /// Gets and sets the property StageName. 
        /// <para>
        /// The name of the stage where the rule was run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string StageName
        {
            get { return this._stageName; }
            set { this._stageName = value; }
        }

        // Check to see if StageName property is set
        internal bool IsSetStageName()
        {
            return this._stageName != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start time of the rule execution.
        /// </para>
        /// </summary>
        public DateTime? StartTime
        {
            get { return this._startTime; }
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
        /// The status of the rule execution. Status categories are <c>InProgress</c>, <c>Succeeded</c>,
        /// and <c>Failed</c>. 
        /// </para>
        /// </summary>
        public RuleExecutionStatus Status
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
        /// Gets and sets the property UpdatedBy. 
        /// <para>
        /// The ARN of the user who changed the rule execution details.
        /// </para>
        /// </summary>
        public string UpdatedBy
        {
            get { return this._updatedBy; }
            set { this._updatedBy = value; }
        }

        // Check to see if UpdatedBy property is set
        internal bool IsSetUpdatedBy()
        {
            return this._updatedBy != null;
        }

    }
}