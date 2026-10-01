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
    /// Container for the parameters to the ListAntennas operation. Returns a list of antennas
    /// at a specified ground station.
    /// </summary>
    public partial class ListAntennasRequest : AmazonGroundStationRequest
    {
        /// <summary>
        /// Gets and sets the property GroundStationId. 
        /// <para>
        /// ID of a ground station.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 4, Max = 97)]
        public string GroundStationId { get; set; }

        /// <summary>
        /// Checks to see if the GroundStationId property is set.
        /// </summary>
        internal bool IsSetGroundStationId() => this.GroundStationId != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Maximum number of antennas returned.
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
        /// Next token returned in the request of a previous <c>ListAntennas</c> call. Used to
        /// get the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 1000)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
