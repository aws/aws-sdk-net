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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property ActionStates. 
        /// <para>
        /// The state of the stage.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ActionState> ActionStates { get; set; } = AWSConfigs.InitializeCollections ? new List<ActionState>() : null;

        /// <summary>
        /// Checks to see if the ActionStates property is set.
        /// </summary>
        internal bool IsSetActionStates() => this.ActionStates != null && (this.ActionStates.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property BeforeEntryConditionState. 
        /// <para>
        /// The state of the entry conditions for a stage.
        /// </para>
        /// </summary>
        public StageConditionState BeforeEntryConditionState { get; set; }

        /// <summary>
        /// Checks to see if the BeforeEntryConditionState property is set.
        /// </summary>
        internal bool IsSetBeforeEntryConditionState() => this.BeforeEntryConditionState != null;

        /// <summary>
        /// Gets and sets the property InboundExecution.
        /// </summary>
        public StageExecution InboundExecution { get; set; }

        /// <summary>
        /// Checks to see if the InboundExecution property is set.
        /// </summary>
        internal bool IsSetInboundExecution() => this.InboundExecution != null;

        /// <summary>
        /// Gets and sets the property InboundExecutions. 
        /// <para>
        /// The inbound executions for a stage.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StageExecution> InboundExecutions { get; set; } = AWSConfigs.InitializeCollections ? new List<StageExecution>() : null;

        /// <summary>
        /// Checks to see if the InboundExecutions property is set.
        /// </summary>
        internal bool IsSetInboundExecutions() => this.InboundExecutions != null && (this.InboundExecutions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InboundTransitionState. 
        /// <para>
        /// The state of the inbound transition, which is either enabled or disabled.
        /// </para>
        /// </summary>
        public TransitionState InboundTransitionState { get; set; }

        /// <summary>
        /// Checks to see if the InboundTransitionState property is set.
        /// </summary>
        internal bool IsSetInboundTransitionState() => this.InboundTransitionState != null;

        /// <summary>
        /// Gets and sets the property LatestExecution. 
        /// <para>
        /// Information about the latest execution in the stage, including its ID and status.
        /// </para>
        /// </summary>
        public StageExecution LatestExecution { get; set; }

        /// <summary>
        /// Checks to see if the LatestExecution property is set.
        /// </summary>
        internal bool IsSetLatestExecution() => this.LatestExecution != null;

        /// <summary>
        /// Gets and sets the property OnFailureConditionState. 
        /// <para>
        /// The state of the failure conditions for a stage.
        /// </para>
        /// </summary>
        public StageConditionState OnFailureConditionState { get; set; }

        /// <summary>
        /// Checks to see if the OnFailureConditionState property is set.
        /// </summary>
        internal bool IsSetOnFailureConditionState() => this.OnFailureConditionState != null;

        /// <summary>
        /// Gets and sets the property OnSuccessConditionState. 
        /// <para>
        /// The state of the success conditions for a stage.
        /// </para>
        /// </summary>
        public StageConditionState OnSuccessConditionState { get; set; }

        /// <summary>
        /// Checks to see if the OnSuccessConditionState property is set.
        /// </summary>
        internal bool IsSetOnSuccessConditionState() => this.OnSuccessConditionState != null;

        /// <summary>
        /// Gets and sets the property RetryStageMetadata. 
        /// <para>
        /// he details of a specific automatic retry on stage failure, including the attempt number
        /// and trigger.
        /// </para>
        /// </summary>
        public RetryStageMetadata RetryStageMetadata { get; set; }

        /// <summary>
        /// Checks to see if the RetryStageMetadata property is set.
        /// </summary>
        internal bool IsSetRetryStageMetadata() => this.RetryStageMetadata != null;

        /// <summary>
        /// Gets and sets the property StageName. 
        /// <para>
        /// The name of the stage.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string StageName { get; set; }

        /// <summary>
        /// Checks to see if the StageName property is set.
        /// </summary>
        internal bool IsSetStageName() => this.StageName != null;
    }
}
