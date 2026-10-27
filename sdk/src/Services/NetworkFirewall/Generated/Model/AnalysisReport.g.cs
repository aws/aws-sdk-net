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

namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// A report that captures key activity from the last 30 days of network traffic monitored
    /// by your firewall.
    /// 
    ///  
    /// <para>
    /// You can generate up to one report per traffic type, per 30 day period. For example,
    /// when you successfully create an HTTP traffic report, you cannot create another HTTP
    /// traffic report until 30 days pass. Alternatively, if you generate a report that combines
    /// metrics on both HTTP and HTTPS traffic, you cannot create another report for either
    /// traffic type until 30 days pass.
    /// </para>
    /// </summary>
    public partial class AnalysisReport
    {
        /// <summary>
        /// Gets and sets the property AnalysisReportId. 
        /// <para>
        /// The unique ID of the query that ran when you requested an analysis report. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string AnalysisReportId { get; set; }

        /// <summary>
        /// Checks to see if the AnalysisReportId property is set.
        /// </summary>
        internal bool IsSetAnalysisReportId() => this.AnalysisReportId != null;

        /// <summary>
        /// Gets and sets the property AnalysisType. 
        /// <para>
        /// The type of traffic that will be used to generate a report. 
        /// </para>
        /// </summary>
        public EnabledAnalysisType AnalysisType { get; set; }

        /// <summary>
        /// Checks to see if the AnalysisType property is set.
        /// </summary>
        internal bool IsSetAnalysisType() => this.AnalysisType != null;

        /// <summary>
        /// Gets and sets the property ReportTime. 
        /// <para>
        /// The date and time the analysis report was ran. 
        /// </para>
        /// </summary>
        public DateTime? ReportTime { get; set; }

        /// <summary>
        /// Checks to see if the ReportTime property is set.
        /// </summary>
        internal bool IsSetReportTime() => this.ReportTime.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the analysis report you specify. Statuses include <c>RUNNING</c>, <c>COMPLETED</c>,
        /// or <c>FAILED</c>.
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
