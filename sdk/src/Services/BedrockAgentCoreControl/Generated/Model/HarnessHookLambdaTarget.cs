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
    /// The configuration for an AWS Lambda hook target.
    /// </summary>
    public partial class HarnessHookLambdaTarget
    {
        private string _arn;
        private HarnessHookFailureMode _failureMode;
        private int? _timeoutSeconds;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the Lambda function to invoke.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property FailureMode. 
        /// <para>
        /// The behavior when the Lambda function times out, returns an error, or returns an invalid
        /// response. The default is <c>DENY</c>.
        /// </para>
        /// </summary>
        public HarnessHookFailureMode FailureMode
        {
            get { return this._failureMode; }
            set { this._failureMode = value; }
        }

        // Check to see if FailureMode property is set
        internal bool IsSetFailureMode()
        {
            return this._failureMode != null;
        }

        /// <summary>
        /// Gets and sets the property TimeoutSeconds. 
        /// <para>
        /// The maximum number of seconds to wait for the Lambda function response. The default
        /// is 60 seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=900)]
        public int? TimeoutSeconds
        {
            get { return this._timeoutSeconds; }
            set { this._timeoutSeconds = value; }
        }

        // Check to see if TimeoutSeconds property is set
        internal bool IsSetTimeoutSeconds()
        {
            return this._timeoutSeconds.HasValue; 
        }

    }
}