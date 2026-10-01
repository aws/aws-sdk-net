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

namespace Amazon.CodeGuruSecurity.Model
{
    /// <summary>
    /// A summary of metrics for an account as of a specified date.
    /// </summary>
    public partial class MetricsSummary
    {
        /// <summary>
        /// Gets and sets the property CategoriesWithMostFindings. 
        /// <para>
        /// A list of <c>CategoryWithFindingNum</c> objects for the top 5 finding categories with
        /// the most findings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 5)]
        public List<CategoryWithFindingNum> CategoriesWithMostFindings { get; set; } = AWSConfigs.InitializeCollections ? new List<CategoryWithFindingNum>() : null;

        /// <summary>
        /// Checks to see if the CategoriesWithMostFindings property is set.
        /// </summary>
        internal bool IsSetCategoriesWithMostFindings() => this.CategoriesWithMostFindings != null && (this.CategoriesWithMostFindings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Date. 
        /// <para>
        /// The date from which the metrics summary information was retrieved.
        /// </para>
        /// </summary>
        public DateTime? Date { get; set; }

        /// <summary>
        /// Checks to see if the Date property is set.
        /// </summary>
        internal bool IsSetDate() => this.Date.HasValue;

        /// <summary>
        /// Gets and sets the property OpenFindings. 
        /// <para>
        /// The number of open findings of each severity.
        /// </para>
        /// </summary>
        public FindingMetricsValuePerSeverity OpenFindings { get; set; }

        /// <summary>
        /// Checks to see if the OpenFindings property is set.
        /// </summary>
        internal bool IsSetOpenFindings() => this.OpenFindings != null;

        /// <summary>
        /// Gets and sets the property ScansWithMostOpenCriticalFindings. 
        /// <para>
        /// A list of <c>ScanNameWithFindingNum</c> objects for the top 3 scans with the most
        /// number of open critical findings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 3)]
        public List<ScanNameWithFindingNum> ScansWithMostOpenCriticalFindings { get; set; } = AWSConfigs.InitializeCollections ? new List<ScanNameWithFindingNum>() : null;

        /// <summary>
        /// Checks to see if the ScansWithMostOpenCriticalFindings property is set.
        /// </summary>
        internal bool IsSetScansWithMostOpenCriticalFindings() => this.ScansWithMostOpenCriticalFindings != null && (this.ScansWithMostOpenCriticalFindings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ScansWithMostOpenFindings. 
        /// <para>
        /// A list of <c>ScanNameWithFindingNum</c> objects for the top 3 scans with the most
        /// number of open findings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 3)]
        public List<ScanNameWithFindingNum> ScansWithMostOpenFindings { get; set; } = AWSConfigs.InitializeCollections ? new List<ScanNameWithFindingNum>() : null;

        /// <summary>
        /// Checks to see if the ScansWithMostOpenFindings property is set.
        /// </summary>
        internal bool IsSetScansWithMostOpenFindings() => this.ScansWithMostOpenFindings != null && (this.ScansWithMostOpenFindings.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
