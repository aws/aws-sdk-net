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
    /// Container for the parameters to the ValidatePipelineDefinition operation.
    /// <para>Tests the pipeline definition with a set of validation checks to ensure that it is well formed and can run without error. </para>
    /// </summary>
    /// <seealso cref="Amazon.DataPipeline.AmazonDataPipeline.ValidatePipelineDefinition"/>
    public class ValidatePipelineDefinitionRequest : AmazonWebServiceRequest
    {
        private string pipelineId;
        private List<PipelineObject> pipelineObjects = new List<PipelineObject>();

        /// <summary>
        /// Identifies the pipeline whose definition is to be validated.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 1024</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string PipelineId
        {
            get { return this.pipelineId; }
            set { this.pipelineId = value; }
        }

        /// <summary>
        /// Sets the PipelineId property
        /// </summary>
        /// <param name="pipelineId">The value to set for the PipelineId property </param>
        /// <returns>this instance</returns>
        public ValidatePipelineDefinitionRequest WithPipelineId(string pipelineId)
        {
            this.pipelineId = pipelineId;
            return this;
        }
            

        // Check to see if PipelineId property is set
        internal bool IsSetPipelineId()
        {
            return this.pipelineId != null;
        }

        /// <summary>
        /// A list of objects that define the pipeline changes to validate against the pipeline.
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
        public ValidatePipelineDefinitionRequest WithPipelineObjects(params PipelineObject[] pipelineObjects)
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
        public ValidatePipelineDefinitionRequest WithPipelineObjects(IEnumerable<PipelineObject> pipelineObjects)
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
    
