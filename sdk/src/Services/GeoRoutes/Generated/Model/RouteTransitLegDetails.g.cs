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
    /// Populated when the Leg type is Transit, and provides additional information that is
    /// specific to public transit travel.
    /// </summary>
    public partial class RouteTransitLegDetails
    {
        /// <summary>
        /// Gets and sets the property AfterTravelSteps. 
        /// <para>
        /// Steps of a leg that must be performed after the travel portion of the leg.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<RouteTransitAfterTravelStep> AfterTravelSteps { get; set; } = AWSConfigs.InitializeCollections ? new List<RouteTransitAfterTravelStep>() : null;

        /// <summary>
        /// Checks to see if the AfterTravelSteps property is set.
        /// </summary>
        internal bool IsSetAfterTravelSteps() => this.AfterTravelSteps != null && (this.AfterTravelSteps.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Agency. 
        /// <para>
        /// Details about the transit agency.
        /// </para>
        /// </summary>
        public RouteTransitAgency Agency { get; set; }

        /// <summary>
        /// Checks to see if the Agency property is set.
        /// </summary>
        internal bool IsSetAgency() => this.Agency != null;

        /// <summary>
        /// Gets and sets the property Arrival. 
        /// <para>
        /// Details corresponding to the arrival for the leg.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RouteTransitArrival Arrival { get; set; }

        /// <summary>
        /// Checks to see if the Arrival property is set.
        /// </summary>
        internal bool IsSetArrival() => this.Arrival != null;

        /// <summary>
        /// Gets and sets the property Attributions. 
        /// <para>
        /// List of required attributions to display.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<RouteAttribution> Attributions { get; set; } = AWSConfigs.InitializeCollections ? new List<RouteAttribution>() : null;

        /// <summary>
        /// Checks to see if the Attributions property is set.
        /// </summary>
        internal bool IsSetAttributions() => this.Attributions != null && (this.Attributions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property BeforeTravelSteps. 
        /// <para>
        /// Steps of a leg that must be performed before the travel portion of the leg.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<RouteTransitBeforeTravelStep> BeforeTravelSteps { get; set; } = AWSConfigs.InitializeCollections ? new List<RouteTransitBeforeTravelStep>() : null;

        /// <summary>
        /// Checks to see if the BeforeTravelSteps property is set.
        /// </summary>
        internal bool IsSetBeforeTravelSteps() => this.BeforeTravelSteps != null && (this.BeforeTravelSteps.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property BookingWebLinks. 
        /// <para>
        /// Web links to external ticket booking services for the transit.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<RouteWebLink> BookingWebLinks { get; set; } = AWSConfigs.InitializeCollections ? new List<RouteWebLink>() : null;

        /// <summary>
        /// Checks to see if the BookingWebLinks property is set.
        /// </summary>
        internal bool IsSetBookingWebLinks() => this.BookingWebLinks != null && (this.BookingWebLinks.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Departure. 
        /// <para>
        /// Details corresponding to the departure for the leg.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RouteTransitDeparture Departure { get; set; }

        /// <summary>
        /// Checks to see if the Departure property is set.
        /// </summary>
        internal bool IsSetDeparture() => this.Departure != null;

        /// <summary>
        /// Gets and sets the property Incidents. 
        /// <para>
        /// Incidents affecting this leg of the transit route.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<RouteTransitIncident> Incidents { get; set; } = AWSConfigs.InitializeCollections ? new List<RouteTransitIncident>() : null;

        /// <summary>
        /// Checks to see if the Incidents property is set.
        /// </summary>
        internal bool IsSetIncidents() => this.Incidents != null && (this.Incidents.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IntermediateStops. 
        /// <para>
        /// Intermediate stops between departure and destination of the transit route.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<RouteTransitIntermediateStop> IntermediateStops { get; set; } = AWSConfigs.InitializeCollections ? new List<RouteTransitIntermediateStop>() : null;

        /// <summary>
        /// Checks to see if the IntermediateStops property is set.
        /// </summary>
        internal bool IsSetIntermediateStops() => this.IntermediateStops != null && (this.IntermediateStops.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NextDepartures. 
        /// <para>
        /// List of next departures that cover the same section of the route.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<RouteTransitNextDeparture> NextDepartures { get; set; } = AWSConfigs.InitializeCollections ? new List<RouteTransitNextDeparture>() : null;

        /// <summary>
        /// Checks to see if the NextDepartures property is set.
        /// </summary>
        internal bool IsSetNextDepartures() => this.NextDepartures != null && (this.NextDepartures.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Notices. 
        /// <para>
        /// List of notices that indicate issues that occurred during route calculation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<RouteTransitNotice> Notices { get; set; } = AWSConfigs.InitializeCollections ? new List<RouteTransitNotice>() : null;

        /// <summary>
        /// Checks to see if the Notices property is set.
        /// </summary>
        internal bool IsSetNotices() => this.Notices != null && (this.Notices.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PassThroughWaypoints. 
        /// <para>
        /// Waypoints that were passed through during the leg. This includes the waypoints that
        /// were configured with the PassThrough option. Not populated when the TravelMode is
        /// <c>Transit</c> or <c>Intermodal</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<RoutePassThroughWaypoint> PassThroughWaypoints { get; set; } = AWSConfigs.InitializeCollections ? new List<RoutePassThroughWaypoint>() : null;

        /// <summary>
        /// Checks to see if the PassThroughWaypoints property is set.
        /// </summary>
        internal bool IsSetPassThroughWaypoints() => this.PassThroughWaypoints != null && (this.PassThroughWaypoints.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Spans. 
        /// <para>
        /// Spans that were computed for the requested SpanAdditionalFeatures. Not populated when
        /// the TravelMode is <c>Transit</c> or <c>Intermodal</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<RouteTransitSpan> Spans { get; set; } = AWSConfigs.InitializeCollections ? new List<RouteTransitSpan>() : null;

        /// <summary>
        /// Checks to see if the Spans property is set.
        /// </summary>
        internal bool IsSetSpans() => this.Spans != null && (this.Spans.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Summary. 
        /// <para>
        /// Summary of the transit leg.
        /// </para>
        /// </summary>
        public RouteTransitSummary Summary { get; set; }

        /// <summary>
        /// Checks to see if the Summary property is set.
        /// </summary>
        internal bool IsSetSummary() => this.Summary != null;

        /// <summary>
        /// Gets and sets the property Transport. 
        /// <para>
        /// Transport mode details for the transit leg.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RouteTransitTransportModeDetails Transport { get; set; }

        /// <summary>
        /// Checks to see if the Transport property is set.
        /// </summary>
        internal bool IsSetTransport() => this.Transport != null;

        /// <summary>
        /// Gets and sets the property TravelSteps. 
        /// <para>
        /// Steps of a leg that must be performed during the travel portion of the leg.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<RouteTransitTravelStep> TravelSteps { get; set; } = AWSConfigs.InitializeCollections ? new List<RouteTransitTravelStep>() : null;

        /// <summary>
        /// Checks to see if the TravelSteps property is set.
        /// </summary>
        internal bool IsSetTravelSteps() => this.TravelSteps != null && (this.TravelSteps.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
