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

namespace Amazon.GeoRoutes.Model
{
    /// <summary>
    /// Span computed for the requested SpanAdditionalFeatures.
    /// </summary>
    public partial class RoutePedestrianSpan
    {
        /// <summary>
        /// Gets and sets the property BestCaseDuration. 
        /// <para>
        /// Duration of the computed span without traffic congestion.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>seconds</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 4294967295)]
        public long? BestCaseDuration { get; set; }

        /// <summary>
        /// Checks to see if the BestCaseDuration property is set.
        /// </summary>
        internal bool IsSetBestCaseDuration() => this.BestCaseDuration.HasValue;

        /// <summary>
        /// Gets and sets the property Country. 
        /// <para>
        /// 3 letter Country code corresponding to the Span.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 3, Max = 3)]
        public string Country { get; set; }

        /// <summary>
        /// Checks to see if the Country property is set.
        /// </summary>
        internal bool IsSetCountry() => this.Country != null;

        /// <summary>
        /// Gets and sets the property Distance. 
        /// <para>
        /// Distance of the computed span. This feature doesn't split a span, but is always computed
        /// on a span split by other properties.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 4294967295)]
        public long? Distance { get; set; }

        /// <summary>
        /// Checks to see if the Distance property is set.
        /// </summary>
        internal bool IsSetDistance() => this.Distance.HasValue;

        /// <summary>
        /// Gets and sets the property Duration. 
        /// <para>
        /// Duration of the computed span. This feature doesn't split a span, but is always computed
        /// on a span split by other properties.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>seconds</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 4294967295)]
        public long? Duration { get; set; }

        /// <summary>
        /// Checks to see if the Duration property is set.
        /// </summary>
        internal bool IsSetDuration() => this.Duration.HasValue;

        /// <summary>
        /// Gets and sets the property DynamicSpeed. 
        /// <para>
        /// Dynamic speed details corresponding to the span.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>kilometers per hour</c> 
        /// </para>
        /// </summary>
        public RouteSpanDynamicSpeedDetails DynamicSpeed { get; set; }

        /// <summary>
        /// Checks to see if the DynamicSpeed property is set.
        /// </summary>
        internal bool IsSetDynamicSpeed() => this.DynamicSpeed != null;

        /// <summary>
        /// Gets and sets the property FunctionalClassification. 
        /// <para>
        /// A numerical value indicating the functional classification of the road segment corresponding
        /// to the span.
        /// </para>
        ///  
        /// <para>
        /// Classification values are part of the hierarchical network that helps determine a
        /// logical and efficient route, and have the following definitions:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Roads that allow for high volume, maximum speed traffic movement between and through
        /// major metropolitan areas.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Roads that are used to channel traffic to functional class 1 roads for travel between
        /// and through cities in the shortest amount of time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Roads that intersect functional class 2 roads and provide a high volume of traffic
        /// movement at a lower level of mobility than functional class 2 roads.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Roads that provide for a high volume of traffic movement at moderate speeds between
        /// neighborhoods.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Roads with volume and traffic movement below the level of any other functional class.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 5)]
        public int? FunctionalClassification { get; set; }

        /// <summary>
        /// Checks to see if the FunctionalClassification property is set.
        /// </summary>
        internal bool IsSetFunctionalClassification() => this.FunctionalClassification.HasValue;

        /// <summary>
        /// Gets and sets the property GeometryOffset. 
        /// <para>
        /// Offset in the leg geometry corresponding to the start of this span.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? GeometryOffset { get; set; }

        /// <summary>
        /// Checks to see if the GeometryOffset property is set.
        /// </summary>
        internal bool IsSetGeometryOffset() => this.GeometryOffset.HasValue;

        /// <summary>
        /// Gets and sets the property Incidents. 
        /// <para>
        /// Incidents corresponding to the span. These index into the Incidents in the parent
        /// Leg.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> Incidents { get; set; } = AWSConfigs.InitializeCollections ? new List<int>() : null;

        /// <summary>
        /// Checks to see if the Incidents property is set.
        /// </summary>
        internal bool IsSetIncidents() => this.Incidents != null && (this.Incidents.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Names. 
        /// <para>
        /// Provides an array of names of the pedestrian span in available languages.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LocalizedString> Names { get; set; } = AWSConfigs.InitializeCollections ? new List<LocalizedString>() : null;

        /// <summary>
        /// Checks to see if the Names property is set.
        /// </summary>
        internal bool IsSetNames() => this.Names != null && (this.Names.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PedestrianAccess. 
        /// <para>
        /// Access attributes for a pedestrian corresponding to the span.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 6)]
        public List<string> PedestrianAccess { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PedestrianAccess property is set.
        /// </summary>
        internal bool IsSetPedestrianAccess() => this.PedestrianAccess != null && (this.PedestrianAccess.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// 2-3 letter Region code corresponding to the Span. This is either a province or a state.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 3)]
        public string Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;

        /// <summary>
        /// Gets and sets the property RoadAttributes. 
        /// <para>
        /// Attributes for the road segment corresponding to the span. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 12)]
        public List<string> RoadAttributes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RoadAttributes property is set.
        /// </summary>
        internal bool IsSetRoadAttributes() => this.RoadAttributes != null && (this.RoadAttributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RouteNumbers. 
        /// <para>
        /// Designated route name or number corresponding to the span.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RouteNumber> RouteNumbers { get; set; } = AWSConfigs.InitializeCollections ? new List<RouteNumber>() : null;

        /// <summary>
        /// Checks to see if the RouteNumbers property is set.
        /// </summary>
        internal bool IsSetRouteNumbers() => this.RouteNumbers != null && (this.RouteNumbers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SpeedLimit. 
        /// <para>
        /// Speed limit details corresponding to the span.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>kilometers per hour</c> 
        /// </para>
        /// </summary>
        public RouteSpanSpeedLimitDetails SpeedLimit { get; set; }

        /// <summary>
        /// Checks to see if the SpeedLimit property is set.
        /// </summary>
        internal bool IsSetSpeedLimit() => this.SpeedLimit != null;

        /// <summary>
        /// Gets and sets the property TypicalDuration. 
        /// <para>
        /// Duration of the computed span under typical traffic congestion.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>seconds</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 4294967295)]
        public long? TypicalDuration { get; set; }

        /// <summary>
        /// Checks to see if the TypicalDuration property is set.
        /// </summary>
        internal bool IsSetTypicalDuration() => this.TypicalDuration.HasValue;
    }
}
