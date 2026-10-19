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
    /// A root cause that contributes to an insight.
    /// </summary>
    public partial class InsightRootCause
    {
        /// <summary>
        /// Gets and sets the property AffectedSessionCount. 
        /// <para>
        /// The number of distinct sessions affected by the root cause. A session can be affected
        /// by more than one root cause of the same insight.
        /// </para>
        /// </summary>
        public int? AffectedSessionCount { get; set; }

        /// <summary>
        /// Checks to see if the AffectedSessionCount property is set.
        /// </summary>
        internal bool IsSetAffectedSessionCount() => this.AffectedSessionCount.HasValue;

        /// <summary>
        /// Gets and sets the property Explanation. 
        /// <para>
        /// An explanation of how the root cause leads to the failures in the insight.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 4000)]
        public string Explanation { get; set; }

        /// <summary>
        /// Checks to see if the Explanation property is set.
        /// </summary>
        internal bool IsSetExplanation() => this.Explanation != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A generated label for the root cause.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 200)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property SampleSessions. 
        /// <para>
        /// A sample of up to 10 sessions affected by the root cause.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<SampleSession> SampleSessions { get; set; } = AWSConfigs.InitializeCollections ? new List<SampleSession>() : null;

        /// <summary>
        /// Checks to see if the SampleSessions property is set.
        /// </summary>
        internal bool IsSetSampleSessions() => this.SampleSessions != null && (this.SampleSessions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SuggestedFix. 
        /// <para>
        /// A suggested change to the agent that addresses the root cause.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 4000)]
        public string SuggestedFix { get; set; }

        /// <summary>
        /// Checks to see if the SuggestedFix property is set.
        /// </summary>
        internal bool IsSetSuggestedFix() => this.SuggestedFix != null;
    }
}
