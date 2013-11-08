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
    /// Container for the parameters to the PutPipelineDefinition operation.
    /// <para>Adds tasks, schedules, and preconditions that control the behavior of the pipeline. You can use PutPipelineDefinition to populate a
    /// new pipeline. </para> <para> PutPipelineDefinition also validates the configuration as it adds it to the pipeline. Changes to the pipeline
    /// are saved unless one of the following three validation errors exists in the pipeline. <ol> <li>An object is missing a name or identifier
    /// field.</li>
    /// <li>A string or reference field is empty.</li>
    /// <li>The number of objects in the pipeline exceeds the maximum allowed objects.</li>
    /// </ol> </para> <para> Pipeline object definitions are passed to the PutPipelineDefinition action and returned by the GetPipelineDefinition
    /// action. </para>
    /// </summary>
    public partial class PutPipelineDefinitionRequest : AmazonWebServiceRequest
    {
        private string pipelineId;
        private List<PipelineObject> pipelineObjects = new List<PipelineObject>();

        /// <summary>
        /// The identifier of the pipeline to be configured.
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

        // Check to see if PipelineId property is set
        internal bool IsSetPipelineId()
        {
            return this.pipelineId != null;
        }

        /// <summary>
        /// The objects that define the pipeline. These will overwrite the existing pipeline definition.
        ///  
        /// </summary>
        public List<PipelineObject> PipelineObjects
        {
            get { return this.pipelineObjects; }
            set { this.pipelineObjects = value; }
        }

        // Check to see if PipelineObjects property is set
        internal bool IsSetPipelineObjects()
        {
            return this.pipelineObjects.Count > 0;
        }

    }
}
    
