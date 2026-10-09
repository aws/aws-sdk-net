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
    /// Container for the parameters to the StartPlanExecution operation. Starts the execution
    /// of a Region switch plan. You can execute a plan in either <c>graceful</c> or <c>ungraceful</c>
    /// mode. <para> Specifing <c>ungraceful</c> mode either changes the behavior of the execution
    /// blocks in a workflow or skips specific execution blocks. </para>
    /// </summary>
    public partial class StartPlanExecutionRequest : AmazonARCRegionswitchRequest
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action to perform. Valid values are <c>activate</c> (to shift traffic to the target
        /// Region) or <c>deactivate</c> (to shift traffic away from the target Region).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ExecutionAction Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure that the operation completes no more
        /// than one time. If this token matches a previous request, the service ignores the request
        /// and returns the result of the original successful request. If you don't provide a
        /// client token, the service automatically generates one. For more information about
        /// idempotency, see <a href="https://aws.amazon.com/builders-library/making-retries-safe-with-idempotent-APIs/">Making
        /// retries safe with idempotent APIs</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// An optional comment explaining why the plan execution is being started.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 1024)]
        public string Comment { get; set; }

        /// <summary>
        /// Checks to see if the Comment property is set.
        /// </summary>
        internal bool IsSetComment() => this.Comment != null;

        /// <summary>
        /// Gets and sets the property LatestVersion. 
        /// <para>
        /// A boolean value indicating whether to use the latest version of the plan. If set to
        /// false, you must specify a specific version.
        /// </para>
        /// </summary>
        public string LatestVersion { get; set; }

        /// <summary>
        /// Checks to see if the LatestVersion property is set.
        /// </summary>
        internal bool IsSetLatestVersion() => this.LatestVersion != null;

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// The plan execution mode. Valid values are <c>graceful</c>, for starting the execution
        /// in graceful mode, or <c>ungraceful</c>, for starting the execution in ungraceful mode.
        /// </para>
        /// </summary>
        public ExecutionMode Mode { get; set; }

        /// <summary>
        /// Checks to see if the Mode property is set.
        /// </summary>
        internal bool IsSetMode() => this.Mode != null;

        /// <summary>
        /// Gets and sets the property PlanArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the plan to execute.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string PlanArn { get; set; }

        /// <summary>
        /// Checks to see if the PlanArn property is set.
        /// </summary>
        internal bool IsSetPlanArn() => this.PlanArn != null;

        /// <summary>
        /// Gets and sets the property RecoveryExecutionId. 
        /// <para>
        /// The execution identifier of the recovery execution that ran in the opposite region
        /// post-recovery is ran in. Required when starting a post-recovery execution.
        /// </para>
        /// </summary>
        public string RecoveryExecutionId { get; set; }

        /// <summary>
        /// Checks to see if the RecoveryExecutionId property is set.
        /// </summary>
        internal bool IsSetRecoveryExecutionId() => this.RecoveryExecutionId != null;

        /// <summary>
        /// Gets and sets the property TargetRegion. 
        /// <para>
        /// The Amazon Web Services Region to target with this execution. This is the Region that
        /// traffic will be shifted to or from, depending on the action.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TargetRegion { get; set; }

        /// <summary>
        /// Checks to see if the TargetRegion property is set.
        /// </summary>
        internal bool IsSetTargetRegion() => this.TargetRegion != null;
    }
}
