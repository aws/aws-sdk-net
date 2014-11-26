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
 * Do not modify this file. This file is generated from the datapipeline-2012-10-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DataPipeline.Model
{
    /// <summary>
    /// Container for the parameters to the ActivatePipeline operation.
    /// Validates a pipeline and initiates processing. If the pipeline does not pass validation,
    /// activation fails. You cannot perform this operation on FINISHED pipelines and attempting
    /// to do so will return an InvalidRequestException. 
    /// 
    ///  
    /// <para>
    ///  Call this action to start processing pipeline tasks of a pipeline you've created
    /// using the <a>CreatePipeline</a> and <a>PutPipelineDefinition</a> actions. A pipeline
    /// cannot be modified after it has been successfully activated. 
    /// </para>
    /// </summary>
    public partial class ActivatePipelineRequest : AmazonDataPipelineRequest
    {
        private List<ParameterValue> _parameterValues = new List<ParameterValue>();
        private string _pipelineId;

        /// <summary>
        /// Gets and sets the property ParameterValues. 
        /// <para>
        /// Returns a list of parameter values to pass to the pipeline at activation.
        /// </para>
        /// </summary>
        public List<ParameterValue> ParameterValues
        {
            get { return this._parameterValues; }
            set { this._parameterValues = value; }
        }

        // Check to see if ParameterValues property is set
        internal bool IsSetParameterValues()
        {
            return this._parameterValues != null && this._parameterValues.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PipelineId. 
        /// <para>
        /// The identifier of the pipeline to activate. 
        /// </para>
        /// </summary>
        public string PipelineId
        {
            get { return this._pipelineId; }
            set { this._pipelineId = value; }
        }

        // Check to see if PipelineId property is set
        internal bool IsSetPipelineId()
        {
            return this._pipelineId != null;
        }

    }
}