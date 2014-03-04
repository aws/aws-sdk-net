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

namespace Amazon.DataPipeline.Model
{
    /// <summary>
    /// <para>Contains the output from the DescribePipelines action.</para>
    /// </summary>
    public class DescribePipelinesResult
    {
        
        private List<PipelineDescription> pipelineDescriptionList = new List<PipelineDescription>();

        /// <summary>
        /// An array of descriptions returned for the specified pipelines.
        ///  
        /// </summary>
        public List<PipelineDescription> PipelineDescriptionList
        {
            get { return this.pipelineDescriptionList; }
            set { this.pipelineDescriptionList = value; }
        }
        /// <summary>
        /// Adds elements to the PipelineDescriptionList collection
        /// </summary>
        /// <param name="pipelineDescriptionList">The values to add to the PipelineDescriptionList collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribePipelinesResult WithPipelineDescriptionList(params PipelineDescription[] pipelineDescriptionList)
        {
            foreach (PipelineDescription element in pipelineDescriptionList)
            {
                this.pipelineDescriptionList.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the PipelineDescriptionList collection
        /// </summary>
        /// <param name="pipelineDescriptionList">The values to add to the PipelineDescriptionList collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribePipelinesResult WithPipelineDescriptionList(IEnumerable<PipelineDescription> pipelineDescriptionList)
        {
            foreach (PipelineDescription element in pipelineDescriptionList)
            {
                this.pipelineDescriptionList.Add(element);
            }

            return this;
        }

        // Check to see if PipelineDescriptionList property is set
        internal bool IsSetPipelineDescriptionList()
        {
            return this.pipelineDescriptionList.Count > 0;
        }
    }
}
