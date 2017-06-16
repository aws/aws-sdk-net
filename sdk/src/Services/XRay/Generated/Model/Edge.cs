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
 * Do not modify this file. This file is generated from the xray-2016-04-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.XRay.Model
{
    /// <summary>
    /// Information about a connection between two services.
    /// </summary>
    public partial class Edge
    {
        private List<Alias> _aliases = new List<Alias>();
        private DateTime? _endTime;
        private int? _referenceId;
        private List<HistogramEntry> _responseTimeHistogram = new List<HistogramEntry>();
        private DateTime? _startTime;
        private EdgeStatistics _summaryStatistics;

        /// <summary>
        /// Gets and sets the property Aliases. 
        /// <para>
        /// Aliases for the edge.
        /// </para>
        /// </summary>
        public List<Alias> Aliases
        {
            get { return this._aliases; }
            set { this._aliases = value; }
        }

        // Check to see if Aliases property is set
        internal bool IsSetAliases()
        {
            return this._aliases != null && this._aliases.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end time of the last segment on the edge.
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
        /// Gets and sets the property ReferenceId. 
        /// <para>
        /// Identifier of the edge. Unique within a service map.
        /// </para>
        /// </summary>
        public int ReferenceId
        {
            get { return this._referenceId.GetValueOrDefault(); }
            set { this._referenceId = value; }
        }

        // Check to see if ReferenceId property is set
        internal bool IsSetReferenceId()
        {
            return this._referenceId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResponseTimeHistogram. 
        /// <para>
        /// A histogram that maps the spread of client response times on an edge.
        /// </para>
        /// </summary>
        public List<HistogramEntry> ResponseTimeHistogram
        {
            get { return this._responseTimeHistogram; }
            set { this._responseTimeHistogram = value; }
        }

        // Check to see if ResponseTimeHistogram property is set
        internal bool IsSetResponseTimeHistogram()
        {
            return this._responseTimeHistogram != null && this._responseTimeHistogram.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start time of the first segment on the edge.
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

        /// <summary>
        /// Gets and sets the property SummaryStatistics. 
        /// <para>
        /// Response statistics for segments on the edge.
        /// </para>
        /// </summary>
        public EdgeStatistics SummaryStatistics
        {
            get { return this._summaryStatistics; }
            set { this._summaryStatistics = value; }
        }

        // Check to see if SummaryStatistics property is set
        internal bool IsSetSummaryStatistics()
        {
            return this._summaryStatistics != null;
        }

    }
}