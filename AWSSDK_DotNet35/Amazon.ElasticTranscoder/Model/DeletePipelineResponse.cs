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

namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// Configuration for accessing Amazon DeletePipeline service
    /// </summary>
    public partial class DeletePipelineResponse : DeletePipelineResult
    {
        /// <summary>
        /// Gets and sets the DeletePipelineResult property.
        /// Represents the output of a DeletePipeline operation.
        /// </summary>
        [Obsolete(@"This property has been deprecated. All properties of the DeletePipelineResult class are now available on the DeletePipelineResponse class. You should use the properties on DeletePipelineResponse instead of accessing them through DeletePipelineResult.")]
        public DeletePipelineResult DeletePipelineResult
        {
            get
            {
                return this;
            }
        }
    }
}