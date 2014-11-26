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

/*
 * Do not modify this file. This file is generated from the datapipeline-2012-10-29.normal.json service model.
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
    /// Adds tasks, schedules, and preconditions that control the behavior of the pipeline.
    /// You can use PutPipelineDefinition to populate a new pipeline. 
    /// 
    ///  
    /// <para>
    ///  <a>PutPipelineDefinition</a> also validates the configuration as it adds it to the
    /// pipeline. Changes to the pipeline are saved unless one of the following three validation
    /// errors exists in the pipeline. <ol> <li>An object is missing a name or identifier
    /// field.</li> <li>A string or reference field is empty.</li> <li>The number of objects
    /// in the pipeline exceeds the maximum allowed objects.</li> <li>The pipeline is in a
    /// FINISHED state.</li> </ol> 
    /// </para>
    ///  
    /// <para>
    ///  Pipeline object definitions are passed to the <a>PutPipelineDefinition</a> action
    /// and returned by the <a>GetPipelineDefinition</a> action. 
    /// </para>
    /// </summary>
    public partial class PutPipelineDefinitionRequest : AmazonDataPipelineRequest
    {
        private List<ParameterObject> _parameterObjects = new List<ParameterObject>();
        private List<ParameterValue> _parameterValues = new List<ParameterValue>();
        private string _pipelineId;
        private List<PipelineObject> _pipelineObjects = new List<PipelineObject>();

        /// <summary>
        /// Gets and sets the property ParameterObjects. 
        /// <para>
        /// A list of parameter objects used with the pipeline.
        /// </para>
        /// </summary>
        public List<ParameterObject> ParameterObjects
        {
            get { return this._parameterObjects; }
            set { this._parameterObjects = value; }
        }

        // Check to see if ParameterObjects property is set
        internal bool IsSetParameterObjects()
        {
            return this._parameterObjects != null && this._parameterObjects.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ParameterValues. 
        /// <para>
        /// A list of parameter values used with the pipeline.
        /// </para>
        /// </summary>
        public List<ParameterValue> ParameterValues
        {
            get { return this._parameterValues; }
            set { this._parameterValues = value; }
        }

        // Check to see if ParameterValues property is set
        internal bool IsSetParameterValues()
        {
            return this._parameterValues != null && this._parameterValues.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PipelineId. 
        /// <para>
        /// The identifier of the pipeline to be configured.
        /// </para>
        /// </summary>
        public string PipelineId
        {
            get { return this._pipelineId; }
            set { this._pipelineId = value; }
        }

        // Check to see if PipelineId property is set
        internal bool IsSetPipelineId()
        {
            return this._pipelineId != null;
        }

        /// <summary>
        /// Gets and sets the property PipelineObjects. 
        /// <para>
        /// The objects that define the pipeline. These will overwrite the existing pipeline definition.
        /// </para>
        /// </summary>
        public List<PipelineObject> PipelineObjects
        {
            get { return this._pipelineObjects; }
            set { this._pipelineObjects = value; }
        }

        // Check to see if PipelineObjects property is set
        internal bool IsSetPipelineObjects()
        {
            return this._pipelineObjects != null && this._pipelineObjects.Count > 0; 
        }

    }
}