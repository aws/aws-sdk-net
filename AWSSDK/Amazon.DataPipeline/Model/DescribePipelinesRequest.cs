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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DataPipeline.Model
{
    /// <summary>
    /// Container for the parameters to the DescribePipelines operation.
    /// <para> Retrieve metadata about one or more pipelines. The information retrieved includes the name of the pipeline, the pipeline identifier,
    /// its current state, and the user account that owns the pipeline. Using account credentials, you can retrieve metadata about pipelines that
    /// you or your IAM users have created. If you are using an IAM user account, you can retrieve metadata about only those pipelines you have read
    /// permission for. </para> <para> To retrieve the full pipeline definition instead of metadata about the pipeline, call the
    /// GetPipelineDefinition action. </para>
    /// </summary>
    /// <seealso cref="Amazon.DataPipeline.AmazonDataPipeline.DescribePipelines"/>
    public class DescribePipelinesRequest : AmazonWebServiceRequest
    {
        private List<string> pipelineIds = new List<string>();

        /// <summary>
        /// Identifiers of the pipelines to describe. You can pass as many as 25 identifiers in a single call to DescribePipelines. You can obtain
        /// pipeline identifiers by calling ListPipelines.
        ///  
        /// </summary>
        public List<string> PipelineIds
        {
            get { return this.pipelineIds; }
            set { this.pipelineIds = value; }
        }
        /// <summary>
        /// Adds elements to the PipelineIds collection
        /// </summary>
        /// <param name="pipelineIds">The values to add to the PipelineIds collection </param>
        /// <returns>this instance</returns>
        public DescribePipelinesRequest WithPipelineIds(params string[] pipelineIds)
        {
            foreach (string element in pipelineIds)
            {
                this.pipelineIds.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the PipelineIds collection
        /// </summary>
        /// <param name="pipelineIds">The values to add to the PipelineIds collection </param>
        /// <returns>this instance</returns>
        public DescribePipelinesRequest WithPipelineIds(IEnumerable<string> pipelineIds)
        {
            foreach (string element in pipelineIds)
            {
                this.pipelineIds.Add(element);
            }

            return this;
        }

        // Check to see if PipelineIds property is set
        internal bool IsSetPipelineIds()
        {
            return this.pipelineIds.Count > 0;
        }
    }
}
    
