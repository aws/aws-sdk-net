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
    /// A session affected by a detected failure pattern, including root cause details.
    /// </summary>
    public partial class AffectedSession
    {
        /// <summary>
        /// Gets and sets the property Explanation. 
        /// <para>
        /// An explanation of how the failure manifested in this session.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Explanation { get; set; }

        /// <summary>
        /// Checks to see if the Explanation property is set.
        /// </summary>
        internal bool IsSetExplanation() => this.Explanation != null;

        /// <summary>
        /// Gets and sets the property FailureSpans. 
        /// <para>
        /// The list of spans where failures were detected in this session.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public List<FailureSpanDetail> FailureSpans { get; set; } = AWSConfigs.InitializeCollections ? new List<FailureSpanDetail>() : null;

        /// <summary>
        /// Checks to see if the FailureSpans property is set.
        /// </summary>
        internal bool IsSetFailureSpans() => this.FailureSpans != null && (this.FailureSpans.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FixType. 
        /// <para>
        /// The type of fix recommended for this failure.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string FixType { get; set; }

        /// <summary>
        /// Checks to see if the FixType property is set.
        /// </summary>
        internal bool IsSetFixType() => this.FixType != null;

        /// <summary>
        /// Gets and sets the property Recommendation. 
        /// <para>
        /// The specific fix recommendation for this session.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Recommendation { get; set; }

        /// <summary>
        /// Checks to see if the Recommendation property is set.
        /// </summary>
        internal bool IsSetRecommendation() => this.Recommendation != null;

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The unique identifier of the affected session.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SessionId { get; set; }

        /// <summary>
        /// Checks to see if the SessionId property is set.
        /// </summary>
        internal bool IsSetSessionId() => this.SessionId != null;
    }
}
