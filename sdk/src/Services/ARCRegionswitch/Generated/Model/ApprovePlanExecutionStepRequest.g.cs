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

namespace Amazon.ARCRegionswitch.Model
{
    /// <summary>
    /// Container for the parameters to the ApprovePlanExecutionStep operation. Approves a
    /// step in a plan execution that requires manual approval. When you create a plan, you
    /// can include approval steps that require manual intervention before the execution can
    /// proceed. This operation allows you to provide that approval. <para> You must specify
    /// the plan ARN, execution ID, step name, and approval status. You can also provide an
    /// optional comment explaining the approval decision. </para>
    /// </summary>
    public partial class ApprovePlanExecutionStepRequest : AmazonARCRegionswitchRequest
    {
        /// <summary>
        /// Gets and sets the property Approval. 
        /// <para>
        /// The status of approval for a plan execution step. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Approval Approval { get; set; }

        /// <summary>
        /// Checks to see if the Approval property is set.
        /// </summary>
        internal bool IsSetApproval() => this.Approval != null;

        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// A comment that you can enter about a plan execution.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 1024)]
        public string Comment { get; set; }

        /// <summary>
        /// Checks to see if the Comment property is set.
        /// </summary>
        internal bool IsSetComment() => this.Comment != null;

        /// <summary>
        /// Gets and sets the property ExecutionId. 
        /// <para>
        /// The execution identifier of a plan execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ExecutionId { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionId property is set.
        /// </summary>
        internal bool IsSetExecutionId() => this.ExecutionId != null;

        /// <summary>
        /// Gets and sets the property PlanArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string PlanArn { get; set; }

        /// <summary>
        /// Checks to see if the PlanArn property is set.
        /// </summary>
        internal bool IsSetPlanArn() => this.PlanArn != null;

        /// <summary>
        /// Gets and sets the property StepName. 
        /// <para>
        /// The name of a step in a plan execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string StepName { get; set; }

        /// <summary>
        /// Checks to see if the StepName property is set.
        /// </summary>
        internal bool IsSetStepName() => this.StepName != null;
    }
}
