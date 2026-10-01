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
    /// Filters for querying memory extraction jobs based on various criteria.
    /// </summary>
    public partial class ExtractionJobFilterInput
    {
        /// <summary>
        /// Gets and sets the property ActorId. 
        /// <para>
        /// The identifier of the actor. If specified, only extraction jobs with this actor ID
        /// are returned.
        /// </para>
        /// </summary>
        public string ActorId { get; set; }

        /// <summary>
        /// Checks to see if the ActorId property is set.
        /// </summary>
        internal bool IsSetActorId() => this.ActorId != null;

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The unique identifier of the session. If specified, only extraction jobs with this
        /// session ID are returned.
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
        /// The status of the extraction job. If specified, only extraction jobs with this status
        /// are returned.
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
        /// The memory strategy identifier to filter extraction jobs by. If specified, only extraction
        /// jobs with this strategy ID are returned.
        /// </para>
        /// </summary>
        public string StrategyId { get; set; }

        /// <summary>
        /// Checks to see if the StrategyId property is set.
        /// </summary>
        internal bool IsSetStrategyId() => this.StrategyId != null;
    }
}
