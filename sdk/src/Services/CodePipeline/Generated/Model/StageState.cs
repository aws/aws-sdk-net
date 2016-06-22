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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// Represents information about the state of the stage.
    /// </summary>
    public partial class StageState
    {
        private List<ActionState> _actionStates = new List<ActionState>();
        private TransitionState _inboundTransitionState;
        private StageExecution _latestExecution;
        private string _stageName;

        /// <summary>
        /// Gets and sets the property ActionStates. 
        /// <para>
        /// The state of the stage.
        /// </para>
        /// </summary>
        public List<ActionState> ActionStates
        {
            get { return this._actionStates; }
            set { this._actionStates = value; }
        }

        // Check to see if ActionStates property is set
        internal bool IsSetActionStates()
        {
            return this._actionStates != null && this._actionStates.Count > 0; 
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
        /// Gets and sets the property StageName. 
        /// <para>
        /// The name of the stage.
        /// </para>
        /// </summary>
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