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

namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// Invocation output from a routing classifier model.
    /// </summary>
    public partial class RoutingClassifierModelInvocationOutput
    {
        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// The invocation's metadata.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Metadata Metadata { get; set; }

        /// <summary>
        /// Checks to see if the Metadata property is set.
        /// </summary>
        internal bool IsSetMetadata() => this.Metadata != null;

        /// <summary>
        /// Gets and sets the property RawResponse. 
        /// <para>
        /// The invocation's raw response.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public RawResponse RawResponse { get; set; }

        /// <summary>
        /// Checks to see if the RawResponse property is set.
        /// </summary>
        internal bool IsSetRawResponse() => this.RawResponse != null;

        /// <summary>
        /// Gets and sets the property TraceId. 
        /// <para>
        /// The invocation's trace ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 16)]
        public string TraceId { get; set; }

        /// <summary>
        /// Checks to see if the TraceId property is set.
        /// </summary>
        internal bool IsSetTraceId() => this.TraceId != null;
    }
}
