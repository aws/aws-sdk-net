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
    /// Container for the parameters to the ApprovePlanExecutionStep operation.
    /// Approves a step in a plan execution that requires manual approval. When you create
    /// a plan, you can include approval steps that require manual intervention before the
    /// execution can proceed. This operation allows you to provide that approval.
    /// 
    ///  
    /// <para>
    /// You must specify the plan ARN, execution ID, step name, and approval status. You can
    /// also provide an optional comment explaining the approval decision.
    /// </para>
    /// </summary>
    public partial class ApprovePlanExecutionStepRequest : AmazonARCRegionswitchRequest
    {
        private Approval _approval;
        private string _comment;
        private string _executionId;
        private string _planArn;
        private string _stepName;

        /// <summary>
        /// Gets and sets the property Approval. 
        /// <para>
        /// The status of approval for a plan execution step. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Approval Approval
        {
            get { return this._approval; }
            set { this._approval = value; }
        }

        // Check to see if Approval property is set
        internal bool IsSetApproval()
        {
            return this._approval != null;
        }

        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// A comment that you can enter about a plan execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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
        /// The execution identifier of a plan execution.
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
        /// The Amazon Resource Name (ARN) of the plan.
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
        /// The name of a step in a plan execution.
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