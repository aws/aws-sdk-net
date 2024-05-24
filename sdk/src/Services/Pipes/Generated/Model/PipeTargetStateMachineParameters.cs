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
 * Do not modify this file. This file is generated from the pipes-2015-10-07.normal.json service model.
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
namespace Amazon.Pipes.Model
{
    /// <summary>
    /// The parameters for using a Step Functions state machine as a target.
    /// </summary>
    public partial class PipeTargetStateMachineParameters
    {
        private PipeTargetInvocationType _invocationType;

        /// <summary>
        /// Gets and sets the property InvocationType. 
        /// <para>
        /// Specify whether to invoke the Step Functions state machine synchronously or asynchronously.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>REQUEST_RESPONSE</c> (default) - Invoke synchronously. For more information, see
        /// <a href="https://docs.aws.amazon.com/step-functions/latest/apireference/API_StartSyncExecution.html">StartSyncExecution</a>
        /// in the <i>Step Functions API Reference</i>.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>REQUEST_RESPONSE</c> is not supported for <c>STANDARD</c> state machine workflows.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        ///  <c>FIRE_AND_FORGET</c> - Invoke asynchronously. For more information, see <a href="https://docs.aws.amazon.com/step-functions/latest/apireference/API_StartExecution.html">StartExecution</a>
        /// in the <i>Step Functions API Reference</i>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-pipes.html#pipes-invocation">Invocation
        /// types</a> in the <i>Amazon EventBridge User Guide</i>.
        /// </para>
        /// </summary>
        public PipeTargetInvocationType InvocationType
        {
            get { return this._invocationType; }
            set { this._invocationType = value; }
        }

        // Check to see if InvocationType property is set
        internal bool IsSetInvocationType()
        {
            return this._invocationType != null;
        }

    }
}