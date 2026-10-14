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
    /// Container for the parameters to the UpdatePlanExecution operation. Updates an in-progress
    /// plan execution. This operation allows you to modify certain aspects of the execution,
    /// such as adding a comment or changing the action.
    /// </summary>
    public partial class UpdatePlanExecutionRequest : AmazonARCRegionswitchRequest
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action specified for a plan execution, for example, Switch to Graceful or Pause.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public UpdatePlanExecutionAction Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// An optional comment about the plan execution.
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
        /// The Amazon Resource Name (ARN) of the plan with the execution to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string PlanArn { get; set; }

        /// <summary>
        /// Checks to see if the PlanArn property is set.
        /// </summary>
        internal bool IsSetPlanArn() => this.PlanArn != null;
    }
}
