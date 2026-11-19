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

namespace Amazon.Kafka.Model
{
    /// <summary>
    /// Summary of assessment findings broken down by category and severity.
    /// </summary>
    public partial class AssessmentSummary
    {
        /// <summary>
        /// Gets and sets the property ByCategory. 
        /// <para>
        /// Count of findings grouped by category.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, int> ByCategory { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, int>() : null;

        /// <summary>
        /// Checks to see if the ByCategory property is set.
        /// </summary>
        internal bool IsSetByCategory() => this.ByCategory != null && (this.ByCategory.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property BySeverity. 
        /// <para>
        /// Count of findings grouped by severity.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, int> BySeverity { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, int>() : null;

        /// <summary>
        /// Checks to see if the BySeverity property is set.
        /// </summary>
        internal bool IsSetBySeverity() => this.BySeverity != null && (this.BySeverity.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FindingsCapped. 
        /// <para>
        /// True when the assessment detected more findings than it stores. Resolve the reported
        /// findings and re-run the assessment to surface the remaining ones.
        /// </para>
        /// </summary>
        public bool? FindingsCapped { get; set; }

        /// <summary>
        /// Checks to see if the FindingsCapped property is set.
        /// </summary>
        internal bool IsSetFindingsCapped() => this.FindingsCapped.HasValue;

        /// <summary>
        /// Gets and sets the property HasBlockingFindings. 
        /// <para>
        /// True when the assessment detected at least one ERROR-severity finding. ERROR findings
        /// block the migration until resolved.
        /// </para>
        /// </summary>
        public bool? HasBlockingFindings { get; set; }

        /// <summary>
        /// Checks to see if the HasBlockingFindings property is set.
        /// </summary>
        internal bool IsSetHasBlockingFindings() => this.HasBlockingFindings.HasValue;

        /// <summary>
        /// Gets and sets the property TotalFindings. 
        /// <para>
        /// The total number of findings detected by the assessment, including any findings beyond
        /// the stored-findings cap.
        /// </para>
        /// </summary>
        public int? TotalFindings { get; set; }

        /// <summary>
        /// Checks to see if the TotalFindings property is set.
        /// </summary>
        internal bool IsSetTotalFindings() => this.TotalFindings.HasValue;
    }
}
