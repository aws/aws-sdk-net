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
    /// The state of a run of a condition for a stage.
    /// </summary>
    public partial class StageConditionState
    {
        private List<ConditionState> _conditionStates = AWSConfigs.InitializeCollections ? new List<ConditionState>() : null;
        private StageConditionsExecution _latestExecution;

        /// <summary>
        /// Gets and sets the property ConditionStates. 
        /// <para>
        /// The states of the conditions for a run of a condition for a stage.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ConditionState> ConditionStates
        {
            get { return this._conditionStates; }
            set { this._conditionStates = value; }
        }

        // Check to see if ConditionStates property is set
        internal bool IsSetConditionStates()
        {
            return this._conditionStates != null && (this._conditionStates.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LatestExecution. 
        /// <para>
        /// Represents information about the latest run of a condition for a stage.
        /// </para>
        /// </summary>
        public StageConditionsExecution LatestExecution
        {
            get { return this._latestExecution; }
            set { this._latestExecution = value; }
        }

        // Check to see if LatestExecution property is set
        internal bool IsSetLatestExecution()
        {
            return this._latestExecution != null;
        }

    }
}