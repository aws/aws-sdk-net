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

namespace Amazon.CodeGuruSecurity.Model
{
    /// <summary>
    /// Information about summary metrics in an account.
    /// </summary>
    public partial class MetricsSummary
    {
        private List<CategoryWithFindingNum> _categoriesWithMostFindings = new List<CategoryWithFindingNum>();
        private DateTime? _date;
        private FindingMetricsValuePerSeverity _openFindings;
        private List<ScanNameWithFindingNum> _scansWithMostOpenCriticalFindings = new List<ScanNameWithFindingNum>();
        private List<ScanNameWithFindingNum> _scansWithMostOpenFindings = new List<ScanNameWithFindingNum>();

        /// <summary>
        /// Gets and sets the property CategoriesWithMostFindings. 
        /// <para>
        /// A list of <code>CategoryWithFindingNum</code> objects for the top 5 finding categories
        /// with the most open findings in an account.
        /// </para>
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
            return this._categoriesWithMostFindings != null && this._categoriesWithMostFindings.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Date. 
        /// <para>
        /// The date from which the metrics summary information was retrieved.
        /// </para>
        /// </summary>
        public DateTime Date
        {
            get { return this._date.GetValueOrDefault(); }
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
        /// The number of open findings of each severity in an account.
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
        /// A list of <code>ScanNameWithFindingNum</code> objects for the top 3 scans with the
        /// most number of open findings in an account.
        /// </para>
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
            return this._scansWithMostOpenCriticalFindings != null && this._scansWithMostOpenCriticalFindings.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ScansWithMostOpenFindings. 
        /// <para>
        /// A list of <code>ScanNameWithFindingNum</code> objects for the top 3 scans with the
        /// most number of open critical findings in an account.
        /// </para>
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
            return this._scansWithMostOpenFindings != null && this._scansWithMostOpenFindings.Count > 0; 
        }

    }
}