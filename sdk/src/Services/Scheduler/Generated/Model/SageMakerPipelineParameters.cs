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
 * Do not modify this file. This file is generated from the scheduler-2021-06-30.normal.json service model.
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
namespace Amazon.Scheduler.Model
{
    /// <summary>
    /// The templated target type for the Amazon SageMaker <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_StartPipelineExecution.html">
    /// <c>StartPipelineExecution</c> </a> API operation.
    /// </summary>
    public partial class SageMakerPipelineParameters
    {
        private List<SageMakerPipelineParameter> _pipelineParameterList = AWSConfigs.InitializeCollections ? new List<SageMakerPipelineParameter>() : null;

        /// <summary>
        /// Gets and sets the property PipelineParameterList. 
        /// <para>
        /// List of parameter names and values to use when executing the SageMaker Model Building
        /// Pipeline.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._pipelineParameterList != null && (this._pipelineParameterList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}