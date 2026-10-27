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

namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// The result from the inspection of the web request for a valid challenge token.
    /// </summary>
    public partial class ChallengeResponse
    {
        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The reason for failure, populated when the evaluation of the token fails.
        /// </para>
        /// </summary>
        public FailureReason FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property ResponseCode. 
        /// <para>
        /// The HTTP response code indicating the status of the challenge token in the web request.
        /// If the token is missing, invalid, or expired, this code is <c>202 Request Accepted</c>.
        /// </para>
        /// </summary>
        public int? ResponseCode { get; set; }

        /// <summary>
        /// Checks to see if the ResponseCode property is set.
        /// </summary>
        internal bool IsSetResponseCode() => this.ResponseCode.HasValue;

        /// <summary>
        /// Gets and sets the property SolveTimestamp. 
        /// <para>
        /// The time that the challenge was last solved for the supplied token. 
        /// </para>
        /// </summary>
        public long? SolveTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the SolveTimestamp property is set.
        /// </summary>
        internal bool IsSetSolveTimestamp() => this.SolveTimestamp.HasValue;
    }
}
