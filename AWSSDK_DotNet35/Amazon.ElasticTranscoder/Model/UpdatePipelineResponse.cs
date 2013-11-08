/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.Runtime;

namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// Returns information about the  UpdatePipeline response and response metadata.
    /// </summary>
    public class UpdatePipelineResponse : UpdatePipelineResult
    {
        /// <summary>
        /// Gets and sets the UpdatePipelineResult property.
        /// When you update a pipeline, Elastic Transcoder returns the values that you specified in the request.
        /// </summary>
        [Obsolete(@"This property has been deprecated. All properties of the UpdatePipelineResult class are now available on the UpdatePipelineResponse class. You should use the properties on UpdatePipelineResponse instead of accessing them through UpdatePipelineResult.")]
        public UpdatePipelineResult UpdatePipelineResult
        {
            get
            {
                return this;
            }
        }
    }
}
    
