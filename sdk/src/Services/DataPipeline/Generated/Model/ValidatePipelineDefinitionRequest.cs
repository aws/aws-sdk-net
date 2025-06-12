/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.DataPipeline.Model
{
    /// <summary>
    /// Container for the parameters to the ValidatePipelineDefinition operation.
    /// Validates the specified pipeline definition to ensure that it is well formed and can
    /// be run without error.
    /// </summary>
    public partial class ValidatePipelineDefinitionRequest : AmazonDataPipelineRequest
    {
        private List<ParameterObject> _parameterObjects = AWSConfigs.InitializeCollections ? new List<ParameterObject>() : null;
        private List<ParameterValue> _parameterValues = AWSConfigs.InitializeCollections ? new List<ParameterValue>() : null;
        private string _pipelineId;
        private List<PipelineObject> _pipelineObjects = AWSConfigs.InitializeCollections ? new List<PipelineObject>() : null;

        /// <summary>
        /// Gets and sets the property ParameterObjects. 
        /// <para>
        /// The parameter objects used with the pipeline.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ParameterObject> ParameterObjects
        {
            get { return this._parameterObjects; }
            set { this._parameterObjects = value; }
        }

        // Check to see if ParameterObjects property is set
        internal bool IsSetParameterObjects()
        {
            return this._parameterObjects != null && (this._parameterObjects.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ParameterValues. 
        /// <para>
        /// The parameter values used with the pipeline.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ParameterValue> ParameterValues
        {
            get { return this._parameterValues; }
            set { this._parameterValues = value; }
        }

        // Check to see if ParameterValues property is set
        internal bool IsSetParameterValues()
        {
            return this._parameterValues != null && (this._parameterValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PipelineId. 
        /// <para>
        /// The ID of the pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
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
        /// The objects that define the pipeline changes to validate against the pipeline.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<PipelineObject> PipelineObjects
        {
            get { return this._pipelineObjects; }
            set { this._pipelineObjects = value; }
        }

        // Check to see if PipelineObjects property is set
        internal bool IsSetPipelineObjects()
        {
            return this._pipelineObjects != null && (this._pipelineObjects.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}