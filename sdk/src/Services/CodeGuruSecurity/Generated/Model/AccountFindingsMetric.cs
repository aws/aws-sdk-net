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
    /// A summary of findings metrics for an account on a specified date.
    /// </summary>
    public partial class AccountFindingsMetric
    {
        private FindingMetricsValuePerSeverity _closedFindings;
        private DateTime? _date;
        private FindingMetricsValuePerSeverity _meanTimeToClose;
        private FindingMetricsValuePerSeverity _newFindings;
        private FindingMetricsValuePerSeverity _openFindings;

        /// <summary>
        /// Gets and sets the property ClosedFindings. 
        /// <para>
        /// The number of closed findings of each severity on the specified date.
        /// </para>
        /// </summary>
        public FindingMetricsValuePerSeverity ClosedFindings
        {
            get { return this._closedFindings; }
            set { this._closedFindings = value; }
        }

        // Check to see if ClosedFindings property is set
        internal bool IsSetClosedFindings()
        {
            return this._closedFindings != null;
        }

        /// <summary>
        /// Gets and sets the property Date. 
        /// <para>
        /// The date from which the findings metrics were retrieved.
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
        /// Gets and sets the property MeanTimeToClose. 
        /// <para>
        /// The average time in days it takes to close findings of each severity as of a specified
        /// date.
        /// </para>
        /// </summary>
        public FindingMetricsValuePerSeverity MeanTimeToClose
        {
            get { return this._meanTimeToClose; }
            set { this._meanTimeToClose = value; }
        }

        // Check to see if MeanTimeToClose property is set
        internal bool IsSetMeanTimeToClose()
        {
            return this._meanTimeToClose != null;
        }

        /// <summary>
        /// Gets and sets the property NewFindings. 
        /// <para>
        /// The number of new findings of each severity on the specified date.
        /// </para>
        /// </summary>
        public FindingMetricsValuePerSeverity NewFindings
        {
            get { return this._newFindings; }
            set { this._newFindings = value; }
        }

        // Check to see if NewFindings property is set
        internal bool IsSetNewFindings()
        {
            return this._newFindings != null;
        }

        /// <summary>
        /// Gets and sets the property OpenFindings. 
        /// <para>
        /// The number of open findings of each severity as of the specified date.
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

    }
}