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
    /// The number of session and trace IDs a dataset generation was started with.
    /// </summary>
    public partial class GenerationIdentifierCounts
    {
        /// <summary>
        /// Gets and sets the property SessionIdCount. 
        /// <para>
        /// The number of session IDs in the request.
        /// </para>
        /// </summary>
        public int? SessionIdCount { get; set; }

        /// <summary>
        /// Checks to see if the SessionIdCount property is set.
        /// </summary>
        internal bool IsSetSessionIdCount() => this.SessionIdCount.HasValue;

        /// <summary>
        /// Gets and sets the property TraceIdCount. 
        /// <para>
        /// The number of trace IDs in the request.
        /// </para>
        /// </summary>
        public int? TraceIdCount { get; set; }

        /// <summary>
        /// Checks to see if the TraceIdCount property is set.
        /// </summary>
        internal bool IsSetTraceIdCount() => this.TraceIdCount.HasValue;
    }
}
