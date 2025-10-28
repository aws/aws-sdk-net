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
 * Do not modify this file. This file is generated from the groundstation-2019-05-23.normal.json service model.
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
namespace Amazon.GroundStation.Model
{
    /// <summary>
    /// Container for the parameters to the ListEphemerides operation.
    /// List your existing ephemerides.
    /// </summary>
    public partial class ListEphemeridesRequest : AmazonGroundStationRequest
    {
        private DateTime? _endTime;
        private EphemerisType _ephemerisType;
        private int? _maxResults;
        private string _nextToken;
        private string _satelliteId;
        private DateTime? _startTime;
        private List<string> _statusList = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end time for the list operation in UTC. Returns ephemerides with expiration times
        /// within your specified time range.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property EphemerisType. 
        /// <para>
        /// Filter ephemerides by type. If not specified, all ephemeris types will be returned.
        /// </para>
        /// </summary>
        public EphemerisType EphemerisType
        {
            get { return this._ephemerisType; }
            set { this._ephemerisType = value; }
        }

        // Check to see if EphemerisType property is set
        internal bool IsSetEphemerisType()
        {
            return this._ephemerisType != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Maximum number of ephemerides to return.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Pagination token.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=1000)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property SatelliteId. 
        /// <para>
        /// The AWS Ground Station satellite ID to list ephemeris for.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string SatelliteId
        {
            get { return this._satelliteId; }
            set { this._satelliteId = value; }
        }

        // Check to see if SatelliteId property is set
        internal bool IsSetSatelliteId()
        {
            return this._satelliteId != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start time for the list operation in UTC. Returns ephemerides with expiration
        /// times within your specified time range.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property StatusList. 
        /// <para>
        /// The list of ephemeris status to return.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
        public List<string> StatusList
        {
            get { return this._statusList; }
            set { this._statusList = value; }
        }

        // Check to see if StatusList property is set
        internal bool IsSetStatusList()
        {
            return this._statusList != null && (this._statusList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}