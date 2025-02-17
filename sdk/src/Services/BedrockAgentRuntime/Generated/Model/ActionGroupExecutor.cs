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
 * Do not modify this file. This file is generated from the bedrock-agent-runtime-2023-07-26.normal.json service model.
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
namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// Contains details about the Lambda function containing the business logic that is
    /// carried out upon invoking the action or the custom control method for handling the
    /// information elicited from the user.
    /// </summary>
    public partial class ActionGroupExecutor
    {
        private CustomControlMethod _customControl;
        private string _lambda;

        /// <summary>
        /// Gets and sets the property CustomControl. 
        /// <para>
        ///  To return the action group invocation results directly in the <c>InvokeInlineAgent</c>
        /// response, specify <c>RETURN_CONTROL</c>. 
        /// </para>
        /// </summary>
        public CustomControlMethod CustomControl
        {
            get { return this._customControl; }
            set { this._customControl = value; }
        }

        // Check to see if CustomControl property is set
        internal bool IsSetCustomControl()
        {
            return this._customControl != null;
        }

        /// <summary>
        /// Gets and sets the property Lambda. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the Lambda function containing the business logic
        /// that is carried out upon invoking the action. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string Lambda
        {
            get { return this._lambda; }
            set { this._lambda = value; }
        }

        // Check to see if Lambda property is set
        internal bool IsSetLambda()
        {
            return this._lambda != null;
        }

    }
}