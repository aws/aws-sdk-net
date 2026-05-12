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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// Configuration for a Lambda function used as a code-based evaluator.
    /// </summary>
    public partial class LambdaEvaluatorConfig
    {
        private string _lambdaArn;
        private int? _lambdaTimeoutInSeconds;

        /// <summary>
        /// Gets and sets the property LambdaArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the Lambda function that implements the evaluation
        /// logic. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string LambdaArn
        {
            get { return this._lambdaArn; }
            set { this._lambdaArn = value; }
        }

        // Check to see if LambdaArn property is set
        internal bool IsSetLambdaArn()
        {
            return this._lambdaArn != null;
        }

        /// <summary>
        /// Gets and sets the property LambdaTimeoutInSeconds. 
        /// <para>
        ///  The timeout in seconds for the Lambda function invocation. Defaults to 60. Must be
        /// between 1 and 300. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=300)]
        public int? LambdaTimeoutInSeconds
        {
            get { return this._lambdaTimeoutInSeconds; }
            set { this._lambdaTimeoutInSeconds = value; }
        }

        // Check to see if LambdaTimeoutInSeconds property is set
        internal bool IsSetLambdaTimeoutInSeconds()
        {
            return this._lambdaTimeoutInSeconds.HasValue; 
        }

    }
}