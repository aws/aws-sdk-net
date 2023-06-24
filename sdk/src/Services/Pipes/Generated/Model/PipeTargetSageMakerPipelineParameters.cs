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
 * Do not modify this file. This file is generated from the pipes-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pipes.Model
{
    /// <summary>
    /// The parameters for using a SageMaker pipeline as a target.
    /// </summary>
    public partial class PipeTargetSageMakerPipelineParameters
    {
        private List<SageMakerPipelineParameter> _pipelineParameterList = new List<SageMakerPipelineParameter>();

        /// <summary>
        /// Gets and sets the property PipelineParameterList. 
        /// <para>
        /// List of Parameter names and values for SageMaker Model Building Pipeline execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<SageMakerPipelineParameter> PipelineParameterList
        {
            get { return this._pipelineParameterList; }
            set { this._pipelineParameterList = value; }
        }

        // Check to see if PipelineParameterList property is set
        internal bool IsSetPipelineParameterList()
        {
            return this._pipelineParameterList != null && this._pipelineParameterList.Count > 0; 
        }

    }
}