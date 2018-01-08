/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the discovery-2015-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ApplicationDiscoveryService.Model
{
    /// <summary>
    /// Container for the parameters to the StartExportTask operation.
    /// Begins the export of discovered data to an S3 bucket.
    /// 
    ///  
    /// <para>
    ///  If you specify <code>agentIds</code> in a filter, the task exports up to 72 hours
    /// of detailed data collected by the identified Application Discovery Agent, including
    /// network, process, and performance details. A time range for exported agent data may
    /// be set by using <code>startTime</code> and <code>endTime</code>. Export of detailed
    /// agent data is limited to five concurrently running exports. 
    /// </para>
    ///  
    /// <para>
    ///  If you do not include an <code>agentIds</code> filter, summary data is exported that
    /// includes both AWS Agentless Discovery Connector data and summary data from AWS Discovery
    /// Agents. Export of summary data is limited to two exports per day. 
    /// </para>
    /// </summary>
    public partial class StartExportTaskRequest : AmazonApplicationDiscoveryServiceRequest
    {
        private DateTime? _endTime;
        private List<string> _exportDataFormat = new List<string>();
        private List<ExportFilter> _filters = new List<ExportFilter>();
        private DateTime? _startTime;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end timestamp for exported data from the single Application Discovery Agent selected
        /// in the filters. If no value is specified, exported data includes the most recent data
        /// collected by the agent.
        /// </para>
        /// </summary>
        public DateTime EndTime
        {
            get { return this._endTime.GetValueOrDefault(); }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExportDataFormat. 
        /// <para>
        /// The file format for the returned export data. Default value is <code>CSV</code>. <b>Note:</b>
        /// <i>The</i> <code>GRAPHML</code> <i>option has been deprecated.</i> 
        /// </para>
        /// </summary>
        public List<string> ExportDataFormat
        {
            get { return this._exportDataFormat; }
            set { this._exportDataFormat = value; }
        }

        // Check to see if ExportDataFormat property is set
        internal bool IsSetExportDataFormat()
        {
            return this._exportDataFormat != null && this._exportDataFormat.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// If a filter is present, it selects the single <code>agentId</code> of the Application
        /// Discovery Agent for which data is exported. The <code>agentId</code> can be found
        /// in the results of the <code>DescribeAgents</code> API or CLI. If no filter is present,
        /// <code>startTime</code> and <code>endTime</code> are ignored and exported data includes
        /// both Agentless Discovery Connector data and summary data from Application Discovery
        /// agents. 
        /// </para>
        /// </summary>
        public List<ExportFilter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start timestamp for exported data from the single Application Discovery Agent
        /// selected in the filters. If no value is specified, data is exported starting from
        /// the first data collected by the agent.
        /// </para>
        /// </summary>
        public DateTime StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

    }
}