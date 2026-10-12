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

namespace Amazon.CloudControlApi.Model
{
    /// <summary>
    /// Represents the current status of applicable Hooks for a resource operation request.
    /// It contains list of Hook invocation information for the resource specified in the
    /// request since the same target can invoke multiple Hooks. For more information, see
    /// <a href="https://docs.aws.amazon.com/cloudcontrolapi/latest/userguide/resource-operations-manage-requests.html">Managing
    /// resource operation requests with Amazon Web Services Cloud Control API </a>.
    /// </summary>
    public partial class HookProgressEvent
    {
        /// <summary>
        /// Gets and sets the property FailureMode. 
        /// <para>
        /// The failure mode of the invocation. The following are the potential statuses:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>FAIL</c>: This will fail the Hook invocation and the request associated with it.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>WARN</c>: This will fail the Hook invocation, but not the request associated with
        /// it.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string FailureMode { get; set; }

        /// <summary>
        /// Checks to see if the FailureMode property is set.
        /// </summary>
        internal bool IsSetFailureMode() => this.FailureMode != null;

        /// <summary>
        /// Gets and sets the property HookEventTime. 
        /// <para>
        /// The time that the Hook invocation request initiated.
        /// </para>
        /// </summary>
        public DateTime? HookEventTime { get; set; }

        /// <summary>
        /// Checks to see if the HookEventTime property is set.
        /// </summary>
        internal bool IsSetHookEventTime() => this.HookEventTime.HasValue;

        /// <summary>
        /// Gets and sets the property HookStatus. 
        /// <para>
        /// The status of the Hook invocation. The following are potential statuses:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>HOOK_PENDING</c>: The Hook was added to the invocation plan, but not yet invoked.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>HOOK_IN_PROGRESS</c>: The Hook was invoked, but hasn't completed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>HOOK_COMPLETE_SUCCEEDED</c>: The Hook invocation is complete with a successful
        /// result.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>HOOK_COMPLETE_FAILED</c>: The Hook invocation is complete with a failed result.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>HOOK_FAILED</c>: The Hook invocation didn't complete successfully.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string HookStatus { get; set; }

        /// <summary>
        /// Checks to see if the HookStatus property is set.
        /// </summary>
        internal bool IsSetHookStatus() => this.HookStatus != null;

        /// <summary>
        /// Gets and sets the property HookStatusMessage. 
        /// <para>
        /// The message explaining the current Hook status.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string HookStatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the HookStatusMessage property is set.
        /// </summary>
        internal bool IsSetHookStatusMessage() => this.HookStatusMessage != null;

        /// <summary>
        /// Gets and sets the property HookTypeArn. 
        /// <para>
        /// The ARN of the Hook being invoked.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string HookTypeArn { get; set; }

        /// <summary>
        /// Checks to see if the HookTypeArn property is set.
        /// </summary>
        internal bool IsSetHookTypeArn() => this.HookTypeArn != null;

        /// <summary>
        /// Gets and sets the property HookTypeName. 
        /// <para>
        /// The type name of the Hook being invoked.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 196)]
        public string HookTypeName { get; set; }

        /// <summary>
        /// Checks to see if the HookTypeName property is set.
        /// </summary>
        internal bool IsSetHookTypeName() => this.HookTypeName != null;

        /// <summary>
        /// Gets and sets the property HookTypeVersionId. 
        /// <para>
        /// The type version of the Hook being invoked.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string HookTypeVersionId { get; set; }

        /// <summary>
        /// Checks to see if the HookTypeVersionId property is set.
        /// </summary>
        internal bool IsSetHookTypeVersionId() => this.HookTypeVersionId != null;

        /// <summary>
        /// Gets and sets the property InvocationPoint. 
        /// <para>
        /// States whether the Hook is invoked before or after resource provisioning.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string InvocationPoint { get; set; }

        /// <summary>
        /// Checks to see if the InvocationPoint property is set.
        /// </summary>
        internal bool IsSetInvocationPoint() => this.InvocationPoint != null;
    }
}
