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
    /// Output details listed for an action execution, such as the action execution result.
    /// </summary>
    public partial class ActionExecutionOutput
    {
        private ActionExecutionResult _executionResult;
        private List<ArtifactDetail> _outputArtifacts = AWSConfigs.InitializeCollections ? new List<ArtifactDetail>() : null;
        private Dictionary<string, string> _outputVariables = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ExecutionResult. 
        /// <para>
        /// Execution result information listed in the output details for an action execution.
        /// </para>
        /// </summary>
        public ActionExecutionResult ExecutionResult
        {
            get { return this._executionResult; }
            set { this._executionResult = value; }
        }

        // Check to see if ExecutionResult property is set
        internal bool IsSetExecutionResult()
        {
            return this._executionResult != null;
        }

        /// <summary>
        /// Gets and sets the property OutputArtifacts. 
        /// <para>
        /// Details of output artifacts of the action that correspond to the action execution.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ArtifactDetail> OutputArtifacts
        {
            get { return this._outputArtifacts; }
            set { this._outputArtifacts = value; }
        }

        // Check to see if OutputArtifacts property is set
        internal bool IsSetOutputArtifacts()
        {
            return this._outputArtifacts != null && (this._outputArtifacts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OutputVariables. 
        /// <para>
        /// The outputVariables field shows the key-value pairs that were output as part of that
        /// execution.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> OutputVariables
        {
            get { return this._outputVariables; }
            set { this._outputVariables = value; }
        }

        // Check to see if OutputVariables property is set
        internal bool IsSetOutputVariables()
        {
            return this._outputVariables != null && (this._outputVariables.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}