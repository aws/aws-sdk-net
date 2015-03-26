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
    /// Container for the parameters to the ValidatePipelineDefinition operation.
    /// Tests the pipeline definition with a set of validation checks to ensure that it is
    /// well formed and can run without error.
    /// </summary>
    public partial class ValidatePipelineDefinitionRequest : AmazonDataPipelineRequest
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
        /// Identifies the pipeline whose definition is to be validated.
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
        /// A list of objects that define the pipeline changes to validate against the pipeline.
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