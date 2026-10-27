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
    /// This is the response object from the GetAnalysisReportResults operation.
    /// </summary>
    public partial class GetAnalysisReportResultsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AnalysisReportResults. 
        /// <para>
        /// Retrieves the results of a traffic analysis report.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AnalysisTypeReportResult> AnalysisReportResults { get; set; } = AWSConfigs.InitializeCollections ? new List<AnalysisTypeReportResult>() : null;

        /// <summary>
        /// Checks to see if the AnalysisReportResults property is set.
        /// </summary>
        internal bool IsSetAnalysisReportResults() => this.AnalysisReportResults != null && (this.AnalysisReportResults.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The date and time, up to the current date, from which to stop retrieving analysis
        /// data, in UTC format (for example, <c>YYYY-MM-DDTHH:MM:SSZ</c>). 
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// When you request a list of objects with a <c>MaxResults</c> setting, if the number
        /// of objects that are still available for retrieval exceeds the maximum you requested,
        /// Network Firewall returns a <c>NextToken</c> value in the response. To retrieve the
        /// next batch of objects, use the token returned from the prior request in your next
        /// request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

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
        /// Gets and sets the property StartTime. 
        /// <para>
        ///  The date and time within the last 30 days from which to start retrieving analysis
        /// data, in UTC format (for example, <c>YYYY-MM-DDTHH:MM:SSZ</c>. 
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

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
