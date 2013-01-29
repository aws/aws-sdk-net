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
using System.IO;

namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdatePipelineStatusResult
    {
        
        private Pipeline pipeline;

        /// <summary>
        /// A section of the response body that provides information about the pipeline.
        ///  
        /// </summary>
        public Pipeline Pipeline
        {
            get { return this.pipeline; }
            set { this.pipeline = value; }
        }

        /// <summary>
        /// Sets the Pipeline property
        /// </summary>
        /// <param name="pipeline">The value to set for the Pipeline property </param>
        /// <returns>this instance</returns>
        public UpdatePipelineStatusResult WithPipeline(Pipeline pipeline)
        {
            this.pipeline = pipeline;
            return this;
        }
            

        // Check to see if Pipeline property is set
        internal bool IsSetPipeline()
        {
            return this.pipeline != null;
        }
    }
}
