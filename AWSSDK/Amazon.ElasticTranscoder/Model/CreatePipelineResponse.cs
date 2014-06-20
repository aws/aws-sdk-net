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

using System;
using Amazon.Runtime;

namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// Returns information about the CreatePipelineResult response and response metadata.
    /// </summary>
    public class CreatePipelineResponse : AmazonWebServiceResponse
    {
        private CreatePipelineResult _createPipelineResult;

        /// <summary>
        /// Gets and sets the CreatePipelineResult property.
        /// Represents the output of a CreatePipeline operation.
        /// </summary>
        public CreatePipelineResult CreatePipelineResult
        {
            get
            {
                if(this._createPipelineResult == null)
                {
                    this._createPipelineResult = new CreatePipelineResult();
                }
                return this._createPipelineResult;
            }
            set { this._createPipelineResult = value; }
        }
    }
}