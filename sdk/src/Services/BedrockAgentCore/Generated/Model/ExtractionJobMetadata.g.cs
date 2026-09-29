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

namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// Metadata information associated with this extraction job.
    /// </summary>
    public partial class ExtractionJobMetadata
    {
        /// <summary>
        /// Gets and sets the property ActorId. 
        /// <para>
        /// The identifier of the actor for this extraction job.
        /// </para>
        /// </summary>
        public string ActorId { get; set; }

        /// <summary>
        /// Checks to see if the ActorId property is set.
        /// </summary>
        internal bool IsSetActorId() => this.ActorId != null;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The cause of failure, if the job did not complete successfully.
        /// </para>
        /// </summary>
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property JobID. 
        /// <para>
        /// The unique identifier for the extraction job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string JobID { get; set; }

        /// <summary>
        /// Checks to see if the JobID property is set.
        /// </summary>
        internal bool IsSetJobID() => this.JobID != null;

        /// <summary>
        /// Gets and sets the property Messages. 
        /// <para>
        /// The messages associated with the extraction job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ExtractionJobMessages Messages { get; set; }

        /// <summary>
        /// Checks to see if the Messages property is set.
        /// </summary>
        internal bool IsSetMessages() => this.Messages != null;

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The identifier of the session for this extraction job.
        /// </para>
        /// </summary>
        public string SessionId { get; set; }

        /// <summary>
        /// Checks to see if the SessionId property is set.
        /// </summary>
        internal bool IsSetSessionId() => this.SessionId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the extraction job.
        /// </para>
        /// </summary>
        public ExtractionJobStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StrategyId. 
        /// <para>
        /// The identifier of the memory strategy for this extraction job.
        /// </para>
        /// </summary>
        public string StrategyId { get; set; }

        /// <summary>
        /// Checks to see if the StrategyId property is set.
        /// </summary>
        internal bool IsSetStrategyId() => this.StrategyId != null;
    }
}
