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
    /// The target that receives lifecycle hook events. Specify one target type.
    /// </summary>
    public partial class HarnessHookTarget
    {
        private HarnessHookEventBridgeTarget _eventBridge;
        private HarnessHookLambdaTarget _lambda;
        private HarnessHookSnsTarget _sns;

        /// <summary>
        /// Gets and sets the property EventBridge. 
        /// <para>
        /// An Amazon EventBridge hook target that sends the hook event without waiting for a
        /// response.
        /// </para>
        /// </summary>
        public HarnessHookEventBridgeTarget EventBridge
        {
            get { return this._eventBridge; }
            set { this._eventBridge = value; }
        }

        // Check to see if EventBridge property is set
        internal bool IsSetEventBridge()
        {
            return this._eventBridge != null;
        }

        /// <summary>
        /// Gets and sets the property Lambda. 
        /// <para>
        /// A Lambda hook target that invokes an AWS Lambda function synchronously and waits for
        /// its response.
        /// </para>
        /// </summary>
        public HarnessHookLambdaTarget Lambda
        {
            get { return this._lambda; }
            set { this._lambda = value; }
        }

        // Check to see if Lambda property is set
        internal bool IsSetLambda()
        {
            return this._lambda != null;
        }

        /// <summary>
        /// Gets and sets the property Sns. 
        /// <para>
        /// An Amazon SNS hook target that publishes the hook event without waiting for a response.
        /// </para>
        /// </summary>
        public HarnessHookSnsTarget Sns
        {
            get { return this._sns; }
            set { this._sns = value; }
        }

        // Check to see if Sns property is set
        internal bool IsSetSns()
        {
            return this._sns != null;
        }

    }
}