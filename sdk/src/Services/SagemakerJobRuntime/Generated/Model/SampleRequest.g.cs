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

namespace Amazon.SagemakerJobRuntime.Model
{
    /// <summary>
    /// Container for the parameters to the Sample operation. Sends an inference request to
    /// the model during a job execution. The request and response bodies are forwarded to
    /// and from the model without modification. Each turn (prompt and response) is captured
    /// for later use.
    /// </summary>
    public partial class SampleRequest : AmazonSagemakerJobRuntimeRequest
    {
        /// <summary>
        /// Gets and sets the property Body. The raw inference request body in OpenAI-compatible
        /// JSON format.
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public MemoryStream Body { get; set; }

        /// <summary>
        /// Checks to see if the Body property is set.
        /// </summary>
        internal bool IsSetBody() => this.Body != null;

        /// <summary>
        /// Gets and sets the property JobArn. The job ARN that identifies which model session
        /// to route the inference request to.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string JobArn { get; set; }

        /// <summary>
        /// Checks to see if the JobArn property is set.
        /// </summary>
        internal bool IsSetJobArn() => this.JobArn != null;

        /// <summary>
        /// Gets and sets the property TrajectoryId. The trajectory ID for grouping turns into
        /// a single rollout. Each turn (prompt and response) is captured for later use.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string TrajectoryId { get; set; }

        /// <summary>
        /// Checks to see if the TrajectoryId property is set.
        /// </summary>
        internal bool IsSetTrajectoryId() => this.TrajectoryId != null;
    }
}
