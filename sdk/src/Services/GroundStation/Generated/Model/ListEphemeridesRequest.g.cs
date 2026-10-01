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

namespace Amazon.GroundStation.Model
{
    /// <summary>
    /// Container for the parameters to the ListEphemerides operation. List your existing
    /// ephemerides.
    /// </summary>
    public partial class ListEphemeridesRequest : AmazonGroundStationRequest
    {
        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end time for the list operation in UTC. Returns ephemerides with expiration times
        /// within your specified time range.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property EphemerisType. 
        /// <para>
        /// Filter ephemerides by type. If not specified, all ephemeris types will be returned.
        /// </para>
        /// </summary>
        public EphemerisType EphemerisType { get; set; }

        /// <summary>
        /// Checks to see if the EphemerisType property is set.
        /// </summary>
        internal bool IsSetEphemerisType() => this.EphemerisType != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Maximum number of ephemerides to return.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Pagination token.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 1000)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property SatelliteId. 
        /// <para>
        /// The AWS Ground Station satellite ID to list ephemeris for.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string SatelliteId { get; set; }

        /// <summary>
        /// Checks to see if the SatelliteId property is set.
        /// </summary>
        internal bool IsSetSatelliteId() => this.SatelliteId != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start time for the list operation in UTC. Returns ephemerides with expiration
        /// times within your specified time range.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property StatusList. 
        /// <para>
        /// The list of ephemeris status to return.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 500)]
        public List<string> StatusList { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the StatusList property is set.
        /// </summary>
        internal bool IsSetStatusList() => this.StatusList != null && (this.StatusList.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
