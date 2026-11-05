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

namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// The target that receives lifecycle hook events. Specify one target type.
    /// </summary>
    public partial class HarnessHookTarget
    {
        /// <summary>
        /// Gets and sets the property EventBridge. 
        /// <para>
        /// An Amazon EventBridge hook target that sends the hook event without waiting for a
        /// response.
        /// </para>
        /// </summary>
        public HarnessHookEventBridgeTarget EventBridge { get; set; }

        /// <summary>
        /// Checks to see if the EventBridge property is set.
        /// </summary>
        internal bool IsSetEventBridge() => this.EventBridge != null;

        /// <summary>
        /// Gets and sets the property Lambda. 
        /// <para>
        /// A Lambda hook target that invokes an Amazon Web Services Lambda function synchronously
        /// and waits for its response.
        /// </para>
        /// </summary>
        public HarnessHookLambdaTarget Lambda { get; set; }

        /// <summary>
        /// Checks to see if the Lambda property is set.
        /// </summary>
        internal bool IsSetLambda() => this.Lambda != null;

        /// <summary>
        /// Gets and sets the property Sns. 
        /// <para>
        /// An Amazon SNS hook target that publishes the hook event without waiting for a response.
        /// </para>
        /// </summary>
        public HarnessHookSnsTarget Sns { get; set; }

        /// <summary>
        /// Checks to see if the Sns property is set.
        /// </summary>
        internal bool IsSetSns() => this.Sns != null;
    }
}
