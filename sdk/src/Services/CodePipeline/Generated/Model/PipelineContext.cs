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
    /// Represents information about a pipeline to a job worker.
    /// 
    ///  <note> 
    /// <para>
    /// PipelineContext contains <c>pipelineArn</c> and <c>pipelineExecutionId</c> for custom
    /// action jobs. The <c>pipelineArn</c> and <c>pipelineExecutionId</c> fields are not
    /// populated for ThirdParty action jobs.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class PipelineContext
    {
        private ActionContext _action;
        private string _pipelineArn;
        private string _pipelineExecutionId;
        private string _pipelineName;
        private StageContext _stage;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The context of an action to a job worker in the stage of a pipeline.
        /// </para>
        /// </summary>
        public ActionContext Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property PipelineArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the pipeline.
        /// </para>
        /// </summary>
        public string PipelineArn
        {
            get { return this._pipelineArn; }
            set { this._pipelineArn = value; }
        }

        // Check to see if PipelineArn property is set
        internal bool IsSetPipelineArn()
        {
            return this._pipelineArn != null;
        }

        /// <summary>
        /// Gets and sets the property PipelineExecutionId. 
        /// <para>
        /// The execution ID of the pipeline.
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
        /// Gets and sets the property PipelineName. 
        /// <para>
        /// The name of the pipeline. This is a user-specified value. Pipeline names must be unique
        /// across all pipeline names under an Amazon Web Services account.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// Gets and sets the property Stage. 
        /// <para>
        /// The stage of the pipeline.
        /// </para>
        /// </summary>
        public StageContext Stage
        {
            get { return this._stage; }
            set { this._stage = value; }
        }

        // Check to see if Stage property is set
        internal bool IsSetStage()
        {
            return this._stage != null;
        }

    }
}