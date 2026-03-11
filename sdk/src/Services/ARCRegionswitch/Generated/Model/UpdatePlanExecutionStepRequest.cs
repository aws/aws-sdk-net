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
 * Do not modify this file. This file is generated from the arc-region-switch-2022-07-26.normal.json service model.
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
namespace Amazon.ARCRegionswitch.Model
{
    /// <summary>
    /// Container for the parameters to the UpdatePlanExecutionStep operation.
    /// Updates a specific step in an in-progress plan execution. This operation allows you
    /// to modify the step's comment or action.
    /// </summary>
    public partial class UpdatePlanExecutionStepRequest : AmazonARCRegionswitchRequest
    {
        private UpdatePlanExecutionStepAction _actionToTake;
        private string _comment;
        private string _executionId;
        private string _planArn;
        private string _stepName;

        /// <summary>
        /// Gets and sets the property ActionToTake. 
        /// <para>
        /// The updated action to take for the step. This can be used to skip or retry a step.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public UpdatePlanExecutionStepAction ActionToTake
        {
            get { return this._actionToTake; }
            set { this._actionToTake = value; }
        }

        // Check to see if ActionToTake property is set
        internal bool IsSetActionToTake()
        {
            return this._actionToTake != null;
        }

        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// An optional comment about the plan execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1024)]
        public string Comment
        {
            get { return this._comment; }
            set { this._comment = value; }
        }

        // Check to see if Comment property is set
        internal bool IsSetComment()
        {
            return this._comment != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionId. 
        /// <para>
        /// The unique identifier of the plan execution containing the step to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ExecutionId
        {
            get { return this._executionId; }
            set { this._executionId = value; }
        }

        // Check to see if ExecutionId property is set
        internal bool IsSetExecutionId()
        {
            return this._executionId != null;
        }

        /// <summary>
        /// Gets and sets the property PlanArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the plan containing the execution step to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PlanArn
        {
            get { return this._planArn; }
            set { this._planArn = value; }
        }

        // Check to see if PlanArn property is set
        internal bool IsSetPlanArn()
        {
            return this._planArn != null;
        }

        /// <summary>
        /// Gets and sets the property StepName. 
        /// <para>
        /// The name of the execution step to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string StepName
        {
            get { return this._stepName; }
            set { this._stepName = value; }
        }

        // Check to see if StepName property is set
        internal bool IsSetStepName()
        {
            return this._stepName != null;
        }

    }
}