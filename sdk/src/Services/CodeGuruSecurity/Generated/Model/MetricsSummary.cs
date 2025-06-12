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
 * Do not modify this file. This file is generated from the codeguru-security-2018-05-10.normal.json service model.
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
        private List<CategoryWithFindingNum> _categoriesWithMostFindings = AWSConfigs.InitializeCollections ? new List<CategoryWithFindingNum>() : null;
        private DateTime? _date;
        private FindingMetricsValuePerSeverity _openFindings;
        private List<ScanNameWithFindingNum> _scansWithMostOpenCriticalFindings = AWSConfigs.InitializeCollections ? new List<ScanNameWithFindingNum>() : null;
        private List<ScanNameWithFindingNum> _scansWithMostOpenFindings = AWSConfigs.InitializeCollections ? new List<ScanNameWithFindingNum>() : null;

        /// <summary>
        /// Gets and sets the property CategoriesWithMostFindings. 
        /// <para>
        /// A list of <c>CategoryWithFindingNum</c> objects for the top 5 finding categories with
        /// the most findings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<CategoryWithFindingNum> CategoriesWithMostFindings
        {
            get { return this._categoriesWithMostFindings; }
            set { this._categoriesWithMostFindings = value; }
        }

        // Check to see if CategoriesWithMostFindings property is set
        internal bool IsSetCategoriesWithMostFindings()
        {
            return this._categoriesWithMostFindings != null && (this._categoriesWithMostFindings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Date. 
        /// <para>
        /// The date from which the metrics summary information was retrieved.
        /// </para>
        /// </summary>
        public DateTime? Date
        {
            get { return this._date; }
            set { this._date = value; }
        }

        // Check to see if Date property is set
        internal bool IsSetDate()
        {
            return this._date.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OpenFindings. 
        /// <para>
        /// The number of open findings of each severity.
        /// </para>
        /// </summary>
        public FindingMetricsValuePerSeverity OpenFindings
        {
            get { return this._openFindings; }
            set { this._openFindings = value; }
        }

        // Check to see if OpenFindings property is set
        internal bool IsSetOpenFindings()
        {
            return this._openFindings != null;
        }

        /// <summary>
        /// Gets and sets the property ScansWithMostOpenCriticalFindings. 
        /// <para>
        /// A list of <c>ScanNameWithFindingNum</c> objects for the top 3 scans with the most
        /// number of open critical findings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=3)]
        public List<ScanNameWithFindingNum> ScansWithMostOpenCriticalFindings
        {
            get { return this._scansWithMostOpenCriticalFindings; }
            set { this._scansWithMostOpenCriticalFindings = value; }
        }

        // Check to see if ScansWithMostOpenCriticalFindings property is set
        internal bool IsSetScansWithMostOpenCriticalFindings()
        {
            return this._scansWithMostOpenCriticalFindings != null && (this._scansWithMostOpenCriticalFindings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ScansWithMostOpenFindings. 
        /// <para>
        /// A list of <c>ScanNameWithFindingNum</c> objects for the top 3 scans with the most
        /// number of open findings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=3)]
        public List<ScanNameWithFindingNum> ScansWithMostOpenFindings
        {
            get { return this._scansWithMostOpenFindings; }
            set { this._scansWithMostOpenFindings = value; }
        }

        // Check to see if ScansWithMostOpenFindings property is set
        internal bool IsSetScansWithMostOpenFindings()
        {
            return this._scansWithMostOpenFindings != null && (this._scansWithMostOpenFindings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}