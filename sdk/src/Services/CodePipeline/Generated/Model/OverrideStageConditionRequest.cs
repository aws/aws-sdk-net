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
    /// Container for the parameters to the OverrideStageCondition operation.
    /// Used to override a stage condition. For more information about conditions, see <a
    /// href="https://docs.aws.amazon.com/codepipeline/latest/userguide/stage-conditions.html">Stage
    /// conditions</a> and <a href="https://docs.aws.amazon.com/codepipeline/latest/userguide/concepts-how-it-works-conditions.html">How
    /// do stage conditions work?</a>.
    /// </summary>
    public partial class OverrideStageConditionRequest : AmazonCodePipelineRequest
    {
        private ConditionType _conditionType;
        private string _pipelineExecutionId;
        private string _pipelineName;
        private string _stageName;

        /// <summary>
        /// Gets and sets the property ConditionType. 
        /// <para>
        /// The type of condition to override for the stage, such as entry conditions, failure
        /// conditions, or success conditions.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConditionType ConditionType
        {
            get { return this._conditionType; }
            set { this._conditionType = value; }
        }

        // Check to see if ConditionType property is set
        internal bool IsSetConditionType()
        {
            return this._conditionType != null;
        }

        /// <summary>
        /// Gets and sets the property PipelineExecutionId. 
        /// <para>
        /// The ID of the pipeline execution for the override.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property PipelineName. 
        /// <para>
        /// The name of the pipeline with the stage that will override the condition.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string PipelineName
        {
            get { return this._pipelineName; }
            set { this._pipelineName = value; }
        }

        // Check to see if PipelineName property is set
        internal bool IsSetPipelineName()
        {
            return this._pipelineName != null;
        }

        /// <summary>
        /// Gets and sets the property StageName. 
        /// <para>
        /// The name of the stage for the override.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
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

    }
}