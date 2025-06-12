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
    /// Represents information about the state of the stage.
    /// </summary>
    public partial class StageState
    {
        private List<ActionState> _actionStates = AWSConfigs.InitializeCollections ? new List<ActionState>() : null;
        private StageConditionState _beforeEntryConditionState;
        private StageExecution _inboundExecution;
        private List<StageExecution> _inboundExecutions = AWSConfigs.InitializeCollections ? new List<StageExecution>() : null;
        private TransitionState _inboundTransitionState;
        private StageExecution _latestExecution;
        private StageConditionState _onFailureConditionState;
        private StageConditionState _onSuccessConditionState;
        private RetryStageMetadata _retryStageMetadata;
        private string _stageName;

        /// <summary>
        /// Gets and sets the property ActionStates. 
        /// <para>
        /// The state of the stage.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ActionState> ActionStates
        {
            get { return this._actionStates; }
            set { this._actionStates = value; }
        }

        // Check to see if ActionStates property is set
        internal bool IsSetActionStates()
        {
            return this._actionStates != null && (this._actionStates.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property BeforeEntryConditionState. 
        /// <para>
        /// The state of the entry conditions for a stage.
        /// </para>
        /// </summary>
        public StageConditionState BeforeEntryConditionState
        {
            get { return this._beforeEntryConditionState; }
            set { this._beforeEntryConditionState = value; }
        }

        // Check to see if BeforeEntryConditionState property is set
        internal bool IsSetBeforeEntryConditionState()
        {
            return this._beforeEntryConditionState != null;
        }

        /// <summary>
        /// Gets and sets the property InboundExecution.
        /// </summary>
        public StageExecution InboundExecution
        {
            get { return this._inboundExecution; }
            set { this._inboundExecution = value; }
        }

        // Check to see if InboundExecution property is set
        internal bool IsSetInboundExecution()
        {
            return this._inboundExecution != null;
        }

        /// <summary>
        /// Gets and sets the property InboundExecutions. 
        /// <para>
        /// The inbound executions for a stage.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StageExecution> InboundExecutions
        {
            get { return this._inboundExecutions; }
            set { this._inboundExecutions = value; }
        }

        // Check to see if InboundExecutions property is set
        internal bool IsSetInboundExecutions()
        {
            return this._inboundExecutions != null && (this._inboundExecutions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InboundTransitionState. 
        /// <para>
        /// The state of the inbound transition, which is either enabled or disabled.
        /// </para>
        /// </summary>
        public TransitionState InboundTransitionState
        {
            get { return this._inboundTransitionState; }
            set { this._inboundTransitionState = value; }
        }

        // Check to see if InboundTransitionState property is set
        internal bool IsSetInboundTransitionState()
        {
            return this._inboundTransitionState != null;
        }

        /// <summary>
        /// Gets and sets the property LatestExecution. 
        /// <para>
        /// Information about the latest execution in the stage, including its ID and status.
        /// </para>
        /// </summary>
        public StageExecution LatestExecution
        {
            get { return this._latestExecution; }
            set { this._latestExecution = value; }
        }

        // Check to see if LatestExecution property is set
        internal bool IsSetLatestExecution()
        {
            return this._latestExecution != null;
        }

        /// <summary>
        /// Gets and sets the property OnFailureConditionState. 
        /// <para>
        /// The state of the failure conditions for a stage.
        /// </para>
        /// </summary>
        public StageConditionState OnFailureConditionState
        {
            get { return this._onFailureConditionState; }
            set { this._onFailureConditionState = value; }
        }

        // Check to see if OnFailureConditionState property is set
        internal bool IsSetOnFailureConditionState()
        {
            return this._onFailureConditionState != null;
        }

        /// <summary>
        /// Gets and sets the property OnSuccessConditionState. 
        /// <para>
        /// The state of the success conditions for a stage.
        /// </para>
        /// </summary>
        public StageConditionState OnSuccessConditionState
        {
            get { return this._onSuccessConditionState; }
            set { this._onSuccessConditionState = value; }
        }

        // Check to see if OnSuccessConditionState property is set
        internal bool IsSetOnSuccessConditionState()
        {
            return this._onSuccessConditionState != null;
        }

        /// <summary>
        /// Gets and sets the property RetryStageMetadata. 
        /// <para>
        /// he details of a specific automatic retry on stage failure, including the attempt number
        /// and trigger.
        /// </para>
        /// </summary>
        public RetryStageMetadata RetryStageMetadata
        {
            get { return this._retryStageMetadata; }
            set { this._retryStageMetadata = value; }
        }

        // Check to see if RetryStageMetadata property is set
        internal bool IsSetRetryStageMetadata()
        {
            return this._retryStageMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property StageName. 
        /// <para>
        /// The name of the stage.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string StageName
        {
            get { return this._stageName; }
            set { this._stageName = value; }
        }

        // Check to see if StageName property is set
        internal bool IsSetStageName()
        {
            return this._stageName != null;
        }

    }
}