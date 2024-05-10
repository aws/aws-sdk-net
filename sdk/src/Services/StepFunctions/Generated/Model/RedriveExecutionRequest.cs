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
 * Do not modify this file. This file is generated from the states-2016-11-23.normal.json service model.
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
namespace Amazon.StepFunctions.Model
{
    /// <summary>
    /// Container for the parameters to the RedriveExecution operation.
    /// Restarts unsuccessful executions of Standard workflows that didn't complete successfully
    /// in the last 14 days. These include failed, aborted, or timed out executions. When
    /// you <a href="https://docs.aws.amazon.com/step-functions/latest/dg/redrive-executions.html">redrive</a>
    /// an execution, it continues the failed execution from the unsuccessful step and uses
    /// the same input. Step Functions preserves the results and execution history of the
    /// successful steps, and doesn't rerun these steps when you redrive an execution. Redriven
    /// executions use the same state machine definition and execution ARN as the original
    /// execution attempt.
    /// 
    ///  
    /// <para>
    /// For workflows that include an <a href="https://docs.aws.amazon.com/step-functions/latest/dg/amazon-states-language-map-state.html">Inline
    /// Map</a> or <a href="https://docs.aws.amazon.com/step-functions/latest/dg/amazon-states-language-parallel-state.html">Parallel</a>
    /// state, <c>RedriveExecution</c> API action reschedules and redrives only the iterations
    /// and branches that failed or aborted.
    /// </para>
    ///  
    /// <para>
    /// To redrive a workflow that includes a Distributed Map state whose Map Run failed,
    /// you must redrive the <a href="https://docs.aws.amazon.com/step-functions/latest/dg/use-dist-map-orchestrate-large-scale-parallel-workloads.html#dist-map-orchestrate-parallel-workloads-key-terms">parent
    /// workflow</a>. The parent workflow redrives all the unsuccessful states, including
    /// a failed Map Run. If a Map Run was not started in the original execution attempt,
    /// the redriven parent workflow starts the Map Run.
    /// </para>
    ///  <note> 
    /// <para>
    /// This API action is not supported by <c>EXPRESS</c> state machines.
    /// </para>
    ///  
    /// <para>
    /// However, you can restart the unsuccessful executions of Express child workflows in
    /// a Distributed Map by redriving its Map Run. When you redrive a Map Run, the Express
    /// child workflows are rerun using the <a>StartExecution</a> API action. For more information,
    /// see <a href="https://docs.aws.amazon.com/step-functions/latest/dg/redrive-map-run.html">Redriving
    /// Map Runs</a>.
    /// </para>
    ///  </note> 
    /// <para>
    /// You can redrive executions if your original execution meets the following conditions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The execution status isn't <c>SUCCEEDED</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Your workflow execution has not exceeded the redrivable period of 14 days. Redrivable
    /// period refers to the time during which you can redrive a given execution. This period
    /// starts from the day a state machine completes its execution.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The workflow execution has not exceeded the maximum open time of one year. For more
    /// information about state machine quotas, see <a href="https://docs.aws.amazon.com/step-functions/latest/dg/limits-overview.html#service-limits-state-machine-executions">Quotas
    /// related to state machine executions</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The execution event history count is less than 24,999. Redriven executions append
    /// their event history to the existing event history. Make sure your workflow execution
    /// contains less than 24,999 events to accommodate the <c>ExecutionRedriven</c> history
    /// event and at least one other history event.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class RedriveExecutionRequest : AmazonStepFunctionsRequest
    {
        private string _clientToken;
        private string _executionArn;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. If you don’t specify a client token, the Amazon Web Services SDK automatically
        /// generates a client token and uses it for the request to ensure idempotency. The API
        /// will return idempotent responses for the last 10 client tokens used to successfully
        /// redrive the execution. These client tokens are valid for up to 15 minutes after they
        /// are first used.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the execution to be redriven.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ExecutionArn
        {
            get { return this._executionArn; }
            set { this._executionArn = value; }
        }

        // Check to see if ExecutionArn property is set
        internal bool IsSetExecutionArn()
        {
            return this._executionArn != null;
        }

    }
}