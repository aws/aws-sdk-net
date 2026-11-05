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

namespace Amazon.ApplicationDiscoveryService.Model
{
    /// <summary>
    /// Container for the parameters to the StartExportTask operation. Begins the export of
    /// a discovered data report to an Amazon S3 bucket managed by Amazon Web Services. <note>
    /// <para> Exports might provide an estimate of fees and savings based on certain information
    /// that you provide. Fee estimates do not include any taxes that might apply. Your actual
    /// fees and savings depend on a variety of factors, including your actual usage of Amazon
    /// Web Services services, which might vary from the estimates provided in this report.
    /// </para> </note> <para> If you do not specify <c>preferences</c> or <c>agentIds</c>
    /// in the filter, a summary of all servers, applications, tags, and performance is generated.
    /// This data is an aggregation of all server data collected through on-premises tooling,
    /// file import, application grouping and applying tags. </para> <para> If you specify
    /// <c>agentIds</c> in a filter, the task exports up to 72 hours of detailed data collected
    /// by the identified Application Discovery Agent, including network, process, and performance
    /// details. A time range for exported agent data may be set by using <c>startTime</c>
    /// and <c>endTime</c>. Export of detailed agent data is limited to five concurrently
    /// running exports. Export of detailed agent data is limited to two exports per day.
    /// </para> <para> If you enable <c>ec2RecommendationsPreferences</c> in <c>preferences</c>
    /// , an Amazon EC2 instance matching the characteristics of each server in Application
    /// Discovery Service is generated. Changing the attributes of the <c>ec2RecommendationsPreferences</c>
    /// changes the criteria of the recommendation. </para>
    /// </summary>
    public partial class StartExportTaskRequest : AmazonApplicationDiscoveryServiceRequest
    {
        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end timestamp for exported data from the single Application Discovery Agent selected
        /// in the filters. If no value is specified, exported data includes the most recent data
        /// collected by the agent.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property ExportDataFormat. 
        /// <para>
        /// The file format for the returned export data. Default value is <c>CSV</c>. <b>Note:</b>
        /// <i>The</i> <c>GRAPHML</c> <i>option has been deprecated.</i> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ExportDataFormat { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ExportDataFormat property is set.
        /// </summary>
        internal bool IsSetExportDataFormat() => this.ExportDataFormat != null && (this.ExportDataFormat.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// If a filter is present, it selects the single <c>agentId</c> of the Application Discovery
        /// Agent for which data is exported. The <c>agentId</c> can be found in the results of
        /// the <c>DescribeAgents</c> API or CLI. If no filter is present, <c>startTime</c> and
        /// <c>endTime</c> are ignored and exported data includes both Amazon Web Services Application
        /// Discovery Service Agentless Collector collectors data and summary data from Application
        /// Discovery Agent agents. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ExportFilter> Filters { get; set; } = AWSConfigs.InitializeCollections ? new List<ExportFilter>() : null;

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null && (this.Filters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Preferences. 
        /// <para>
        ///  Indicates the type of data that needs to be exported. Only one <a href="https://docs.aws.amazon.com/application-discovery/latest/APIReference/API_ExportPreferences.html">ExportPreferences</a>
        /// can be enabled at any time. 
        /// </para>
        /// </summary>
        public ExportPreferences Preferences { get; set; }

        /// <summary>
        /// Checks to see if the Preferences property is set.
        /// </summary>
        internal bool IsSetPreferences() => this.Preferences != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start timestamp for exported data from the single Application Discovery Agent
        /// selected in the filters. If no value is specified, data is exported starting from
        /// the first data collected by the agent.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;
    }
}
