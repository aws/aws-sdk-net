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
        /// Choose from the following options.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>RequestResponse</code> (default) - Invoke the function synchronously. Keep
        /// the connection open until the function returns a response or times out. The API response
        /// includes the function response and additional data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Event</code> - Invoke the function asynchronously. Send events that fail multiple
        /// times to the function's dead-letter queue (if it's configured). The API response only
        /// includes a status code.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DryRun</code> - Validate parameter values and verify that the user or role
        /// has permission to invoke the function.
        /// </para>
        ///  </li> </ul>
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