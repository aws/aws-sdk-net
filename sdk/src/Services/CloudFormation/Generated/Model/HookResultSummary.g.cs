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

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// A <c>ListHookResults</c> call returns a summary of a Hook invocation.
    /// </summary>
    public partial class HookResultSummary
    {
        /// <summary>
        /// Gets and sets the property FailureMode. 
        /// <para>
        /// The failure mode of the invocation.
        /// </para>
        /// </summary>
        public HookFailureMode FailureMode { get; set; }

        /// <summary>
        /// Checks to see if the FailureMode property is set.
        /// </summary>
        internal bool IsSetFailureMode() => this.FailureMode != null;

        /// <summary>
        /// Gets and sets the property HookExecutionTarget. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the target stack or request token of the Cloud Control
        /// API operation.
        /// </para>
        ///  
        /// <para>
        /// Only shown in responses when the request does not specify <c>TargetType</c> and <c>TargetId</c>
        /// filters.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1600)]
        public string HookExecutionTarget { get; set; }

        /// <summary>
        /// Checks to see if the HookExecutionTarget property is set.
        /// </summary>
        internal bool IsSetHookExecutionTarget() => this.HookExecutionTarget != null;

        /// <summary>
        /// Gets and sets the property HookResultId. 
        /// <para>
        /// The unique identifier for this Hook invocation result.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string HookResultId { get; set; }

        /// <summary>
        /// Checks to see if the HookResultId property is set.
        /// </summary>
        internal bool IsSetHookResultId() => this.HookResultId != null;

        /// <summary>
        /// Gets and sets the property HookStatusReason. 
        /// <para>
        /// A description of the Hook results status. For example, if the Hook result is in a
        /// failed state, this may contain additional information for the failed state.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string HookStatusReason { get; set; }

        /// <summary>
        /// Checks to see if the HookStatusReason property is set.
        /// </summary>
        internal bool IsSetHookStatusReason() => this.HookStatusReason != null;

        /// <summary>
        /// Gets and sets the property InvocationPoint. 
        /// <para>
        /// The specific point in the provisioning process where the Hook is invoked.
        /// </para>
        /// </summary>
        public HookInvocationPoint InvocationPoint { get; set; }

        /// <summary>
        /// Checks to see if the InvocationPoint property is set.
        /// </summary>
        internal bool IsSetInvocationPoint() => this.InvocationPoint != null;

        /// <summary>
        /// Gets and sets the property InvokedAt. 
        /// <para>
        /// The timestamp when the Hook was invoked.
        /// </para>
        ///  
        /// <para>
        /// Only shown in responses when the request does not specify <c>TargetType</c> and <c>TargetId</c>
        /// filters.
        /// </para>
        /// </summary>
        public DateTime? InvokedAt { get; set; }

        /// <summary>
        /// Checks to see if the InvokedAt property is set.
        /// </summary>
        internal bool IsSetInvokedAt() => this.InvokedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the Hook invocation. The following statuses are possible:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>HOOK_IN_PROGRESS</c>: The Hook is currently running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>HOOK_COMPLETE_SUCCEEDED</c>: The Hook completed successfully.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>HOOK_COMPLETE_FAILED</c>: The Hook completed but failed validation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>HOOK_FAILED</c>: The Hook encountered an error during execution.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public HookStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TargetId. 
        /// <para>
        /// The unique identifier of the Hook invocation target.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1600)]
        public string TargetId { get; set; }

        /// <summary>
        /// Checks to see if the TargetId property is set.
        /// </summary>
        internal bool IsSetTargetId() => this.TargetId != null;

        /// <summary>
        /// Gets and sets the property TargetType. 
        /// <para>
        /// The target type that the Hook was invoked against.
        /// </para>
        /// </summary>
        public ListHookResultsTargetType TargetType { get; set; }

        /// <summary>
        /// Checks to see if the TargetType property is set.
        /// </summary>
        internal bool IsSetTargetType() => this.TargetType != null;

        /// <summary>
        /// Gets and sets the property TypeArn. 
        /// <para>
        /// The ARN of the Hook that was invoked.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string TypeArn { get; set; }

        /// <summary>
        /// Checks to see if the TypeArn property is set.
        /// </summary>
        internal bool IsSetTypeArn() => this.TypeArn != null;

        /// <summary>
        /// Gets and sets the property TypeConfigurationVersionId. 
        /// <para>
        /// The version of the Hook configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string TypeConfigurationVersionId { get; set; }

        /// <summary>
        /// Checks to see if the TypeConfigurationVersionId property is set.
        /// </summary>
        internal bool IsSetTypeConfigurationVersionId() => this.TypeConfigurationVersionId != null;

        /// <summary>
        /// Gets and sets the property TypeName. 
        /// <para>
        /// The name of the Hook that was invoked.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 196)]
        public string TypeName { get; set; }

        /// <summary>
        /// Checks to see if the TypeName property is set.
        /// </summary>
        internal bool IsSetTypeName() => this.TypeName != null;

        /// <summary>
        /// Gets and sets the property TypeVersionId. 
        /// <para>
        /// The version of the Hook that was invoked.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string TypeVersionId { get; set; }

        /// <summary>
        /// Checks to see if the TypeVersionId property is set.
        /// </summary>
        internal bool IsSetTypeVersionId() => this.TypeVersionId != null;
    }
}
