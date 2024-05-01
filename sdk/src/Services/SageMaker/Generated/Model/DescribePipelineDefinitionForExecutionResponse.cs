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
    /// This is the response object from the DescribePipelineDefinitionForExecution operation.
    /// </summary>
    public partial class DescribePipelineDefinitionForExecutionResponse : AmazonWebServiceResponse
    {
        private DateTime? _creationTime;
        private string _pipelineDefinition;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time when the pipeline was created.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property PipelineDefinition. 
        /// <para>
        /// The JSON pipeline definition.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1048576)]
        public string PipelineDefinition
        {
            get { return this._pipelineDefinition; }
            set { this._pipelineDefinition = value; }
        }

        // Check to see if PipelineDefinition property is set
        internal bool IsSetPipelineDefinition()
        {
            return this._pipelineDefinition != null;
        }

    }
}