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

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Represents an insight returned by the <c>ListInsights</c> operation. An insight is
    /// a notification about a domain event or recommendation that helps you optimize your
    /// Amazon OpenSearch Service domain.
    /// </summary>
    public partial class Insight
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The timestamp when the insight was created, in epoch milliseconds.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The display name of the insight.
        /// </para>
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property InsightId. 
        /// <para>
        /// The unique identifier of the insight.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string InsightId { get; set; }

        /// <summary>
        /// Checks to see if the InsightId property is set.
        /// </summary>
        internal bool IsSetInsightId() => this.InsightId != null;

        /// <summary>
        /// Gets and sets the property IsExperimental. 
        /// <para>
        /// Indicates whether the insight is experimental.
        /// </para>
        /// </summary>
        public bool? IsExperimental { get; set; }

        /// <summary>
        /// Checks to see if the IsExperimental property is set.
        /// </summary>
        internal bool IsSetIsExperimental() => this.IsExperimental.HasValue;

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// The priority level of the insight. Possible values are <c>CRITICAL</c>, <c>HIGH</c>,
        /// <c>MEDIUM</c>, and <c>LOW</c>.
        /// </para>
        /// </summary>
        public InsightPriorityLevel Priority { get; set; }

        /// <summary>
        /// Checks to see if the Priority property is set.
        /// </summary>
        internal bool IsSetPriority() => this.Priority != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the insight. Possible values are <c>ACTIVE</c>, <c>RESOLVED</c>,
        /// and <c>DISMISSED</c>.
        /// </para>
        /// </summary>
        public InsightStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the insight. Possible values are <c>EVENT</c> and <c>RECOMMENDATION</c>.
        /// </para>
        /// </summary>
        public InsightType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property UpdateTime. 
        /// <para>
        /// The timestamp when the insight was last updated, in epoch milliseconds.
        /// </para>
        /// </summary>
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Checks to see if the UpdateTime property is set.
        /// </summary>
        internal bool IsSetUpdateTime() => this.UpdateTime.HasValue;
    }
}
