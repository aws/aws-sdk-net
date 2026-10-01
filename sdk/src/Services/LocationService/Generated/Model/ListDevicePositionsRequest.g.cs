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

namespace Amazon.LocationService.Model
{
    /// <summary>
    /// Container for the parameters to the ListDevicePositions operation. A batch request
    /// to retrieve all device positions.
    /// </summary>
    public partial class ListDevicePositionsRequest : AmazonLocationServiceRequest
    {
        /// <summary>
        /// Gets and sets the property FilterGeometry. 
        /// <para>
        /// The geometry used to filter device positions.
        /// </para>
        /// </summary>
        public TrackingFilterGeometry FilterGeometry { get; set; }

        /// <summary>
        /// Checks to see if the FilterGeometry property is set.
        /// </summary>
        internal bool IsSetFilterGeometry() => this.FilterGeometry != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// An optional limit for the number of entries returned in a single call.
        /// </para>
        ///  
        /// <para>
        /// Default value: <c>100</c> 
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
        /// The pagination token specifying which page of results to return in the response. If
        /// no token is provided, the default page is the first page.
        /// </para>
        ///  
        /// <para>
        /// Default value: <c>null</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2000)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property TrackerName. 
        /// <para>
        /// The tracker resource containing the requested devices.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string TrackerName { get; set; }

        /// <summary>
        /// Checks to see if the TrackerName property is set.
        /// </summary>
        internal bool IsSetTrackerName() => this.TrackerName != null;
    }
}
