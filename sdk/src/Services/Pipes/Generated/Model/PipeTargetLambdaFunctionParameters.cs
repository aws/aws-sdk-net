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

namespace Amazon.Pipes.Model
{
    /// <summary>
    /// The parameters for using a Lambda function as a target.
    /// </summary>
    public partial class PipeTargetLambdaFunctionParameters
    {
        private PipeTargetInvocationType _invocationType;

        /// <summary>
        /// Gets and sets the property InvocationType. 
        /// <para>
        /// Specify whether to invoke the function synchronously or asynchronously.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>REQUEST_RESPONSE</code> (default) - Invoke synchronously. This corresponds
        /// to the <code>RequestResponse</code> option in the <code>InvocationType</code> parameter
        /// for the Lambda <a href="https://docs.aws.amazon.com/lambda/latest/dg/API_Invoke.html#API_Invoke_RequestSyntax">Invoke</a>
        /// API.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FIRE_AND_FORGET</code> - Invoke asynchronously. This corresponds to the <code>Event</code>
        /// option in the <code>InvocationType</code> parameter for the Lambda <a href="https://docs.aws.amazon.com/lambda/latest/dg/API_Invoke.html#API_Invoke_RequestSyntax">Invoke</a>
        /// API.
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