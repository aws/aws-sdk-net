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
 * Do not modify this file. This file is generated from the xray-2016-04-12.normal.json service model.
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
namespace Amazon.XRay.Model
{
    /// <summary>
    /// Information about a connection between two services. An edge can be a synchronous
    /// connection, such as typical call between client and service, or an asynchronous link,
    /// such as a Lambda function which retrieves an event from an SNS queue.
    /// </summary>
    public partial class Edge
    {
        private List<Alias> _aliases = AWSConfigs.InitializeCollections ? new List<Alias>() : null;
        private string _edgeType;
        private DateTime? _endTime;
        private List<HistogramEntry> _receivedEventAgeHistogram = AWSConfigs.InitializeCollections ? new List<HistogramEntry>() : null;
        private int? _referenceId;
        private List<HistogramEntry> _responseTimeHistogram = AWSConfigs.InitializeCollections ? new List<HistogramEntry>() : null;
        private DateTime? _startTime;
        private EdgeStatistics _summaryStatistics;

        /// <summary>
        /// Gets and sets the property Aliases. 
        /// <para>
        /// Aliases for the edge.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Alias> Aliases
        {
            get { return this._aliases; }
            set { this._aliases = value; }
        }

        // Check to see if Aliases property is set
        internal bool IsSetAliases()
        {
            return this._aliases != null && (this._aliases.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EdgeType. 
        /// <para>
        /// Describes an asynchronous connection, with a value of <c>link</c>.
        /// </para>
        /// </summary>
        public string EdgeType
        {
            get { return this._edgeType; }
            set { this._edgeType = value; }
        }

        // Check to see if EdgeType property is set
        internal bool IsSetEdgeType()
        {
            return this._edgeType != null;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end time of the last segment on the edge.
        /// </para>
        /// </summary>
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReceivedEventAgeHistogram. 
        /// <para>
        /// A histogram that maps the spread of event age when received by consumers. Age is calculated
        /// each time an event is received. Only populated when <i>EdgeType</i> is <c>link</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<HistogramEntry> ReceivedEventAgeHistogram
        {
            get { return this._receivedEventAgeHistogram; }
            set { this._receivedEventAgeHistogram = value; }
        }

        // Check to see if ReceivedEventAgeHistogram property is set
        internal bool IsSetReceivedEventAgeHistogram()
        {
            return this._receivedEventAgeHistogram != null && (this._receivedEventAgeHistogram.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ReferenceId. 
        /// <para>
        /// Identifier of the edge. Unique within a service map.
        /// </para>
        /// </summary>
        public int? ReferenceId
        {
            get { return this._referenceId; }
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
        /// A histogram that maps the spread of client response times on an edge. Only populated
        /// for synchronous edges.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<HistogramEntry> ResponseTimeHistogram
        {
            get { return this._responseTimeHistogram; }
            set { this._responseTimeHistogram = value; }
        }

        // Check to see if ResponseTimeHistogram property is set
        internal bool IsSetResponseTimeHistogram()
        {
            return this._responseTimeHistogram != null && (this._responseTimeHistogram.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start time of the first segment on the edge.
        /// </para>
        /// </summary>
        public DateTime? StartTime
        {
            get { return this._startTime; }
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