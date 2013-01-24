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
    /// <para>Contains the output from the GetPipelineDefinition action.</para>
    /// </summary>
    public class GetPipelineDefinitionResult
    {
        
        private List<PipelineObject> pipelineObjects = new List<PipelineObject>();

        /// <summary>
        /// An array of objects defined in the pipeline.
        ///  
        /// </summary>
        public List<PipelineObject> PipelineObjects
        {
            get { return this.pipelineObjects; }
            set { this.pipelineObjects = value; }
        }
        /// <summary>
        /// Adds elements to the PipelineObjects collection
        /// </summary>
        /// <param name="pipelineObjects">The values to add to the PipelineObjects collection </param>
        /// <returns>this instance</returns>
        public GetPipelineDefinitionResult WithPipelineObjects(params PipelineObject[] pipelineObjects)
        {
            foreach (PipelineObject element in pipelineObjects)
            {
                this.pipelineObjects.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the PipelineObjects collection
        /// </summary>
        /// <param name="pipelineObjects">The values to add to the PipelineObjects collection </param>
        /// <returns>this instance</returns>
        public GetPipelineDefinitionResult WithPipelineObjects(IEnumerable<PipelineObject> pipelineObjects)
        {
            foreach (PipelineObject element in pipelineObjects)
            {
                this.pipelineObjects.Add(element);
            }

            return this;
        }

        // Check to see if PipelineObjects property is set
        internal bool IsSetPipelineObjects()
        {
            return this.pipelineObjects.Count > 0;
        }
    }
}
