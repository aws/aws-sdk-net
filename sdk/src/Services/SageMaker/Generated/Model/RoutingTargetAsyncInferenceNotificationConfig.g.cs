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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The Amazon SNS topics that the inference router publishes to. The router publishes
    /// one notification for each request. The notification contains the location of the result,
    /// not the result itself. The destination endpoints also send their own notifications,
    /// if they're configured to.
    /// </summary>
    public partial class RoutingTargetAsyncInferenceNotificationConfig
    {
        /// <summary>
        /// Gets and sets the property ErrorTopic. 
        /// <para>
        /// The ARN of the Amazon SNS topic to publish to when a request fails, or when the router
        /// can't place it on any destination. The topic must be a standard topic, and can be
        /// in any Amazon Web Services Region.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ErrorTopic { get; set; }

        /// <summary>
        /// Checks to see if the ErrorTopic property is set.
        /// </summary>
        internal bool IsSetErrorTopic() => this.ErrorTopic != null;

        /// <summary>
        /// Gets and sets the property SuccessTopic. 
        /// <para>
        /// The ARN of the Amazon SNS topic to publish to when a request completes. The topic
        /// must be a standard topic, and can be in any Amazon Web Services Region.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string SuccessTopic { get; set; }

        /// <summary>
        /// Checks to see if the SuccessTopic property is set.
        /// </summary>
        internal bool IsSetSuccessTopic() => this.SuccessTopic != null;
    }
}
