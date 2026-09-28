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

namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// Provides aggregate statistics about the findings for the specified unused access analyzer.
    /// </summary>
    public partial class UnusedAccessFindingsStatistics
    {
        /// <summary>
        /// Gets and sets the property TopAccounts. 
        /// <para>
        /// A list of one to ten Amazon Web Services accounts that have the most active findings
        /// for the unused access analyzer.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<FindingAggregationAccountDetails> TopAccounts { get; set; } = AWSConfigs.InitializeCollections ? new List<FindingAggregationAccountDetails>() : null;

        /// <summary>
        /// Checks to see if the TopAccounts property is set.
        /// </summary>
        internal bool IsSetTopAccounts() => this.TopAccounts != null && (this.TopAccounts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TotalActiveFindings. 
        /// <para>
        /// The total number of active findings for the unused access analyzer.
        /// </para>
        /// </summary>
        public int? TotalActiveFindings { get; set; }

        /// <summary>
        /// Checks to see if the TotalActiveFindings property is set.
        /// </summary>
        internal bool IsSetTotalActiveFindings() => this.TotalActiveFindings.HasValue;

        /// <summary>
        /// Gets and sets the property TotalArchivedFindings. 
        /// <para>
        /// The total number of archived findings for the unused access analyzer.
        /// </para>
        /// </summary>
        public int? TotalArchivedFindings { get; set; }

        /// <summary>
        /// Checks to see if the TotalArchivedFindings property is set.
        /// </summary>
        internal bool IsSetTotalArchivedFindings() => this.TotalArchivedFindings.HasValue;

        /// <summary>
        /// Gets and sets the property TotalResolvedFindings. 
        /// <para>
        /// The total number of resolved findings for the unused access analyzer.
        /// </para>
        /// </summary>
        public int? TotalResolvedFindings { get; set; }

        /// <summary>
        /// Checks to see if the TotalResolvedFindings property is set.
        /// </summary>
        internal bool IsSetTotalResolvedFindings() => this.TotalResolvedFindings.HasValue;

        /// <summary>
        /// Gets and sets the property UnusedAccessTypeStatistics. 
        /// <para>
        /// A list of details about the total number of findings for each type of unused access
        /// for the analyzer. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<UnusedAccessTypeStatistics> UnusedAccessTypeStatistics { get; set; } = AWSConfigs.InitializeCollections ? new List<UnusedAccessTypeStatistics>() : null;

        /// <summary>
        /// Checks to see if the UnusedAccessTypeStatistics property is set.
        /// </summary>
        internal bool IsSetUnusedAccessTypeStatistics() => this.UnusedAccessTypeStatistics != null && (this.UnusedAccessTypeStatistics.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
