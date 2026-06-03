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
 * Do not modify this file. This file is generated from the sagemakerjobruntime-2026-02-01.normal.json service model.
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
    /// Container for the parameters to the Sample operation.
    /// Sends an inference request to the model during a job execution. The request and response
    /// bodies are forwarded to and from the model without modification. Each turn (prompt
    /// and response) is captured for later use.
    /// </summary>
    public partial class SampleRequest : AmazonSagemakerJobRuntimeRequest
    {
        private MemoryStream _body;
        private string _jobArn;
        private string _trajectoryId;

        /// <summary>
        /// Gets and sets the property Body. 
        /// <para>
        /// The raw inference request body in OpenAI-compatible JSON format.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public MemoryStream Body
        {
            get { return this._body; }
            set { this._body = value; }
        }

        // Check to see if Body property is set
        internal bool IsSetBody()
        {
            return this._body != null;
        }

        /// <summary>
        /// Gets and sets the property JobArn. 
        /// <para>
        /// The job ARN that identifies which model session to route the inference request to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string JobArn
        {
            get { return this._jobArn; }
            set { this._jobArn = value; }
        }

        // Check to see if JobArn property is set
        internal bool IsSetJobArn()
        {
            return this._jobArn != null;
        }

        /// <summary>
        /// Gets and sets the property TrajectoryId. 
        /// <para>
        /// The trajectory ID for grouping turns into a single rollout. Each turn (prompt and
        /// response) is captured for later use.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string TrajectoryId
        {
            get { return this._trajectoryId; }
            set { this._trajectoryId = value; }
        }

        // Check to see if TrajectoryId property is set
        internal bool IsSetTrajectoryId()
        {
            return this._trajectoryId != null;
        }

    }
}