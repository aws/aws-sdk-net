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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
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
namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// Represents the output of a <c>GetPipelineState</c> action.
    /// </summary>
    public partial class GetPipelineStateResponse : AmazonWebServiceResponse
    {
        private DateTime? _created;
        private string _pipelineName;
        private int? _pipelineVersion;
        private List<StageState> _stageStates = AWSConfigs.InitializeCollections ? new List<StageState>() : null;
        private DateTime? _updated;

        /// <summary>
        /// Gets and sets the property Created. 
        /// <para>
        /// The date and time the pipeline was created, in timestamp format.
        /// </para>
        /// </summary>
        public DateTime? Created
        {
            get { return this._created; }
            set { this._created = value; }
        }

        // Check to see if Created property is set
        internal bool IsSetCreated()
        {
            return this._created.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PipelineName. 
        /// <para>
        /// The name of the pipeline for which you want to get the state.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string PipelineName
        {
            get { return this._pipelineName; }
            set { this._pipelineName = value; }
        }

        // Check to see if PipelineName property is set
        internal bool IsSetPipelineName()
        {
            return this._pipelineName != null;
        }

        /// <summary>
        /// Gets and sets the property PipelineVersion. 
        /// <para>
        /// The version number of the pipeline.
        /// </para>
        ///  <note> 
        /// <para>
        /// A newly created pipeline is always assigned a version number of <c>1</c>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? PipelineVersion
        {
            get { return this._pipelineVersion; }
            set { this._pipelineVersion = value; }
        }

        // Check to see if PipelineVersion property is set
        internal bool IsSetPipelineVersion()
        {
            return this._pipelineVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StageStates. 
        /// <para>
        /// A list of the pipeline stage output information, including stage name, state, most
        /// recent run details, whether the stage is disabled, and other data.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StageState> StageStates
        {
            get { return this._stageStates; }
            set { this._stageStates = value; }
        }

        // Check to see if StageStates property is set
        internal bool IsSetStageStates()
        {
            return this._stageStates != null && (this._stageStates.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Updated. 
        /// <para>
        /// The date and time the pipeline was last updated, in timestamp format.
        /// </para>
        /// </summary>
        public DateTime? Updated
        {
            get { return this._updated; }
            set { this._updated = value; }
        }

        // Check to see if Updated property is set
        internal bool IsSetUpdated()
        {
            return this._updated.HasValue; 
        }

    }
}