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
    /// A signal indicating a detected failure within a span.
    /// </summary>
    public partial class InsightsFailureSignal
    {
        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// The failure category classification for this signal.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public InsightsFailureCategory Category { get; set; }

        /// <summary>
        /// Checks to see if the Category property is set.
        /// </summary>
        internal bool IsSetCategory() => this.Category != null;

        /// <summary>
        /// Gets and sets the property Confidence. 
        /// <para>
        /// The confidence score of the failure detection.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public double? Confidence { get; set; }

        /// <summary>
        /// Checks to see if the Confidence property is set.
        /// </summary>
        internal bool IsSetConfidence() => this.Confidence.HasValue;

        /// <summary>
        /// Gets and sets the property Evidence. 
        /// <para>
        /// The evidence supporting the failure detection.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Evidence { get; set; }

        /// <summary>
        /// Checks to see if the Evidence property is set.
        /// </summary>
        internal bool IsSetEvidence() => this.Evidence != null;
    }
}
