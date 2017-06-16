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
    /// Information about an application that processed requests, users that made requests,
    /// or downstream services, resources and applications that an application used.
    /// </summary>
    public partial class Service
    {
        private string _accountId;
        private List<HistogramEntry> _durationHistogram = new List<HistogramEntry>();
        private List<Edge> _edges = new List<Edge>();
        private DateTime? _endTime;
        private string _name;
        private List<string> _names = new List<string>();
        private int? _referenceId;
        private List<HistogramEntry> _responseTimeHistogram = new List<HistogramEntry>();
        private bool? _root;
        private DateTime? _startTime;
        private string _state;
        private ServiceStatistics _summaryStatistics;
        private string _type;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// Identifier of the AWS account in which the service runs.
        /// </para>
        /// </summary>
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property DurationHistogram. 
        /// <para>
        /// A histogram that maps the spread of service durations.
        /// </para>
        /// </summary>
        public List<HistogramEntry> DurationHistogram
        {
            get { return this._durationHistogram; }
            set { this._durationHistogram = value; }
        }

        // Check to see if DurationHistogram property is set
        internal bool IsSetDurationHistogram()
        {
            return this._durationHistogram != null && this._durationHistogram.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Edges. 
        /// <para>
        /// Connections to downstream services.
        /// </para>
        /// </summary>
        public List<Edge> Edges
        {
            get { return this._edges; }
            set { this._edges = value; }
        }

        // Check to see if Edges property is set
        internal bool IsSetEdges()
        {
            return this._edges != null && this._edges.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end time of the last segment that the service generated.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The canonical name of the service.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Names. 
        /// <para>
        /// A list of names for the service, including the canonical name.
        /// </para>
        /// </summary>
        public List<string> Names
        {
            get { return this._names; }
            set { this._names = value; }
        }

        // Check to see if Names property is set
        internal bool IsSetNames()
        {
            return this._names != null && this._names.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ReferenceId. 
        /// <para>
        /// Identifier for the service. Unique within the service map.
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
        /// A histogram that maps the spread of service response times.
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
        /// Gets and sets the property Root. 
        /// <para>
        /// Indicates that the service was the first service to process a request.
        /// </para>
        /// </summary>
        public bool Root
        {
            get { return this._root.GetValueOrDefault(); }
            set { this._root = value; }
        }

        // Check to see if Root property is set
        internal bool IsSetRoot()
        {
            return this._root.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start time of the first segment that the service generated.
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
        /// Gets and sets the property State. 
        /// <para>
        /// The service's state.
        /// </para>
        /// </summary>
        public string State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property SummaryStatistics. 
        /// <para>
        /// Aggregated statistics for the service.
        /// </para>
        /// </summary>
        public ServiceStatistics SummaryStatistics
        {
            get { return this._summaryStatistics; }
            set { this._summaryStatistics = value; }
        }

        // Check to see if SummaryStatistics property is set
        internal bool IsSetSummaryStatistics()
        {
            return this._summaryStatistics != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of service.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// AWS Resource - The type of an AWS resource. For example, <code>AWS::EC2::Instance</code>
        /// for a application running on Amazon EC2 or <code>AWS::DynamoDB::Table</code> for an
        /// Amazon DynamoDB table that the application used.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AWS Service - The type of an AWS service. For example, <code>AWS::DynamoDB</code>
        /// for downstream calls to Amazon DynamoDB that didn't target a specific table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>client</code> - Represents the clients that sent requests to a root service.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>remote</code> - A downstream service of indeterminate type.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}