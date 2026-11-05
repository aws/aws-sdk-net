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

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// A compliance score is the percentage of the number of compliant rule-resource combinations
    /// in a conformance pack compared to the number of total possible rule-resource combinations
    /// in the conformance pack. This metric provides you with a high-level view of the compliance
    /// state of your conformance packs. You can use it to identify, investigate, and understand
    /// the level of compliance in your conformance packs.
    /// </summary>
    public partial class ConformancePackComplianceScore
    {
        /// <summary>
        /// Gets and sets the property ConformancePackName. 
        /// <para>
        /// The name of the conformance pack.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ConformancePackName { get; set; }

        /// <summary>
        /// Checks to see if the ConformancePackName property is set.
        /// </summary>
        internal bool IsSetConformancePackName() => this.ConformancePackName != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The time that the conformance pack compliance score was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTime() => this.LastUpdatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Score. 
        /// <para>
        /// Compliance score for the conformance pack. Conformance packs with no evaluation results
        /// will have a compliance score of <c>INSUFFICIENT_DATA</c>.
        /// </para>
        /// </summary>
        public string Score { get; set; }

        /// <summary>
        /// Checks to see if the Score property is set.
        /// </summary>
        internal bool IsSetScore() => this.Score != null;
    }
}
