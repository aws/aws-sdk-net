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
    /// This is the response object from the ForecastGeofenceEvents operation.
    /// </summary>
    public partial class ForecastGeofenceEventsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property DistanceUnit. 
        /// <para>
        /// The distance unit for the forecasted events.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DistanceUnit DistanceUnit { get; set; }

        /// <summary>
        /// Checks to see if the DistanceUnit property is set.
        /// </summary>
        internal bool IsSetDistanceUnit() => this.DistanceUnit != null;

        /// <summary>
        /// Gets and sets the property ForecastedEvents. 
        /// <para>
        /// The list of forecasted events.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<ForecastedEvent> ForecastedEvents { get; set; } = AWSConfigs.InitializeCollections ? new List<ForecastedEvent>() : null;

        /// <summary>
        /// Checks to see if the ForecastedEvents property is set.
        /// </summary>
        internal bool IsSetForecastedEvents() => this.ForecastedEvents != null && (this.ForecastedEvents.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token specifying which page of results to return in the response. If
        /// no token is provided, the default page is the first page. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 60000)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property SpeedUnit. 
        /// <para>
        /// The speed unit for the forecasted events.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SpeedUnit SpeedUnit { get; set; }

        /// <summary>
        /// Checks to see if the SpeedUnit property is set.
        /// </summary>
        internal bool IsSetSpeedUnit() => this.SpeedUnit != null;
    }
}
