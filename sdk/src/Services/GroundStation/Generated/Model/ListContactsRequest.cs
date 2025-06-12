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
    /// Container for the parameters to the ListContacts operation.
    /// Returns a list of contacts.
    /// 
    ///  
    /// <para>
    /// If <c>statusList</c> contains AVAILABLE, the request must include <c>groundStation</c>,
    /// <c>missionprofileArn</c>, and <c>satelliteArn</c>. 
    /// </para>
    /// </summary>
    public partial class ListContactsRequest : AmazonGroundStationRequest
    {
        private DateTime? _endTime;
        private string _groundStation;
        private int? _maxResults;
        private string _missionProfileArn;
        private string _nextToken;
        private string _satelliteArn;
        private DateTime? _startTime;
        private List<string> _statusList = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// End time of a contact in UTC.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property GroundStation. 
        /// <para>
        /// Name of a ground station.
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=500)]
        public string GroundStation
        {
            get { return this._groundStation; }
            set { this._groundStation = value; }
        }

        // Check to see if GroundStation property is set
        internal bool IsSetGroundStation()
        {
            return this._groundStation != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Maximum number of contacts returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MissionProfileArn. 
        /// <para>
        /// ARN of a mission profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min=89, Max=138)]
        public string MissionProfileArn
        {
            get { return this._missionProfileArn; }
            set { this._missionProfileArn = value; }
        }

        // Check to see if MissionProfileArn property is set
        internal bool IsSetMissionProfileArn()
        {
            return this._missionProfileArn != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Next token returned in the request of a previous <c>ListContacts</c> call. Used to
        /// get the next page of results.
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
        /// Gets and sets the property SatelliteArn. 
        /// <para>
        /// ARN of a satellite.
        /// </para>
        /// </summary>
        [AWSProperty(Min=82, Max=132)]
        public string SatelliteArn
        {
            get { return this._satelliteArn; }
            set { this._satelliteArn = value; }
        }

        // Check to see if SatelliteArn property is set
        internal bool IsSetSatelliteArn()
        {
            return this._satelliteArn != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// Start time of a contact in UTC.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property StatusList. 
        /// <para>
        /// Status of a contact reservation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=500)]
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