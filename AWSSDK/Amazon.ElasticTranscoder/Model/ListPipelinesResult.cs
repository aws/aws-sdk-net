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
    public class ListPipelinesResult
    {
        
        private List<Pipeline> pipelines = new List<Pipeline>();

        /// <summary>
        /// An array of <c>Pipeline</c> objects.
        ///  
        /// </summary>
        public List<Pipeline> Pipelines
        {
            get { return this.pipelines; }
            set { this.pipelines = value; }
        }
        /// <summary>
        /// Adds elements to the Pipelines collection
        /// </summary>
        /// <param name="pipelines">The values to add to the Pipelines collection </param>
        /// <returns>this instance</returns>
        public ListPipelinesResult WithPipelines(params Pipeline[] pipelines)
        {
            foreach (Pipeline element in pipelines)
            {
                this.pipelines.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the Pipelines collection
        /// </summary>
        /// <param name="pipelines">The values to add to the Pipelines collection </param>
        /// <returns>this instance</returns>
        public ListPipelinesResult WithPipelines(IEnumerable<Pipeline> pipelines)
        {
            foreach (Pipeline element in pipelines)
            {
                this.pipelines.Add(element);
            }

            return this;
        }

        // Check to see if Pipelines property is set
        internal bool IsSetPipelines()
        {
            return this.pipelines.Count > 0;
        }
    }
}
