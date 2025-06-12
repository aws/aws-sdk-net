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
 * Do not modify this file. This file is generated from the location-2020-11-19.normal.json service model.
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
        private DistanceUnit _distanceUnit;
        private List<ForecastedEvent> _forecastedEvents = AWSConfigs.InitializeCollections ? new List<ForecastedEvent>() : null;
        private string _nextToken;
        private SpeedUnit _speedUnit;

        /// <summary>
        /// Gets and sets the property DistanceUnit. 
        /// <para>
        /// The distance unit for the forecasted events.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DistanceUnit DistanceUnit
        {
            get { return this._distanceUnit; }
            set { this._distanceUnit = value; }
        }

        // Check to see if DistanceUnit property is set
        internal bool IsSetDistanceUnit()
        {
            return this._distanceUnit != null;
        }

        /// <summary>
        /// Gets and sets the property ForecastedEvents. 
        /// <para>
        /// The list of forecasted events.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ForecastedEvent> ForecastedEvents
        {
            get { return this._forecastedEvents; }
            set { this._forecastedEvents = value; }
        }

        // Check to see if ForecastedEvents property is set
        internal bool IsSetForecastedEvents()
        {
            return this._forecastedEvents != null && (this._forecastedEvents.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token specifying which page of results to return in the response. If
        /// no token is provided, the default page is the first page. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=60000)]
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
        /// Gets and sets the property SpeedUnit. 
        /// <para>
        /// The speed unit for the forecasted events.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SpeedUnit SpeedUnit
        {
            get { return this._speedUnit; }
            set { this._speedUnit = value; }
        }

        // Check to see if SpeedUnit property is set
        internal bool IsSetSpeedUnit()
        {
            return this._speedUnit != null;
        }

    }
}