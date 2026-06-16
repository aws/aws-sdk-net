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
 * Do not modify this file. This file is generated from the geo-routes-2020-11-19.normal.json service model.
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
    /// Populated when the Leg type is Taxi, and provides additional information that is specific
    /// to taxi travel.
    /// </summary>
    public partial class RouteTaxiLegDetails
    {
        private List<RouteTaxiAfterTravelStep> _afterTravelSteps = AWSConfigs.InitializeCollections ? new List<RouteTaxiAfterTravelStep>() : null;
        private RouteTaxiAgency _agency;
        private RouteTaxiArrival _arrival;
        private List<RouteAttribution> _attributions = AWSConfigs.InitializeCollections ? new List<RouteAttribution>() : null;
        private List<RouteTaxiBeforeTravelStep> _beforeTravelSteps = AWSConfigs.InitializeCollections ? new List<RouteTaxiBeforeTravelStep>() : null;
        private List<RouteWebLink> _bookingWebLinks = AWSConfigs.InitializeCollections ? new List<RouteWebLink>() : null;
        private RouteTaxiDeparture _departure;
        private List<RouteTaxiNotice> _notices = AWSConfigs.InitializeCollections ? new List<RouteTaxiNotice>() : null;
        private RouteTaxiSummary _summary;
        private RouteTaxiTransportModeDetails _transport;
        private List<RouteTaxiTravelStep> _travelSteps = AWSConfigs.InitializeCollections ? new List<RouteTaxiTravelStep>() : null;

        /// <summary>
        /// Gets and sets the property AfterTravelSteps. 
        /// <para>
        /// Steps of a leg that must be performed after the travel portion of the leg.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<RouteTaxiAfterTravelStep> AfterTravelSteps
        {
            get { return this._afterTravelSteps; }
            set { this._afterTravelSteps = value; }
        }

        // Check to see if AfterTravelSteps property is set
        internal bool IsSetAfterTravelSteps()
        {
            return this._afterTravelSteps != null && (this._afterTravelSteps.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Agency. 
        /// <para>
        /// Details about the taxi agency.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RouteTaxiAgency Agency
        {
            get { return this._agency; }
            set { this._agency = value; }
        }

        // Check to see if Agency property is set
        internal bool IsSetAgency()
        {
            return this._agency != null;
        }

        /// <summary>
        /// Gets and sets the property Arrival. 
        /// <para>
        /// Details corresponding to the arrival for the leg.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RouteTaxiArrival Arrival
        {
            get { return this._arrival; }
            set { this._arrival = value; }
        }

        // Check to see if Arrival property is set
        internal bool IsSetArrival()
        {
            return this._arrival != null;
        }

        /// <summary>
        /// Gets and sets the property Attributions. 
        /// <para>
        /// List of required attributions to display.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<RouteAttribution> Attributions
        {
            get { return this._attributions; }
            set { this._attributions = value; }
        }

        // Check to see if Attributions property is set
        internal bool IsSetAttributions()
        {
            return this._attributions != null && (this._attributions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property BeforeTravelSteps. 
        /// <para>
        /// Steps of a leg that must be performed before the travel portion of the leg.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<RouteTaxiBeforeTravelStep> BeforeTravelSteps
        {
            get { return this._beforeTravelSteps; }
            set { this._beforeTravelSteps = value; }
        }

        // Check to see if BeforeTravelSteps property is set
        internal bool IsSetBeforeTravelSteps()
        {
            return this._beforeTravelSteps != null && (this._beforeTravelSteps.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property BookingWebLinks. 
        /// <para>
        /// Web links to external ticket booking services for the taxi.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<RouteWebLink> BookingWebLinks
        {
            get { return this._bookingWebLinks; }
            set { this._bookingWebLinks = value; }
        }

        // Check to see if BookingWebLinks property is set
        internal bool IsSetBookingWebLinks()
        {
            return this._bookingWebLinks != null && (this._bookingWebLinks.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Departure. 
        /// <para>
        /// Details corresponding to the departure for the leg.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RouteTaxiDeparture Departure
        {
            get { return this._departure; }
            set { this._departure = value; }
        }

        // Check to see if Departure property is set
        internal bool IsSetDeparture()
        {
            return this._departure != null;
        }

        /// <summary>
        /// Gets and sets the property Notices. 
        /// <para>
        /// List of notices that indicate issues that occurred during route calculation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<RouteTaxiNotice> Notices
        {
            get { return this._notices; }
            set { this._notices = value; }
        }

        // Check to see if Notices property is set
        internal bool IsSetNotices()
        {
            return this._notices != null && (this._notices.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Summary. 
        /// <para>
        /// Summary of the taxi leg.
        /// </para>
        /// </summary>
        public RouteTaxiSummary Summary
        {
            get { return this._summary; }
            set { this._summary = value; }
        }

        // Check to see if Summary property is set
        internal bool IsSetSummary()
        {
            return this._summary != null;
        }

        /// <summary>
        /// Gets and sets the property Transport. 
        /// <para>
        /// Transport mode details for the taxi leg.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RouteTaxiTransportModeDetails Transport
        {
            get { return this._transport; }
            set { this._transport = value; }
        }

        // Check to see if Transport property is set
        internal bool IsSetTransport()
        {
            return this._transport != null;
        }

        /// <summary>
        /// Gets and sets the property TravelSteps. 
        /// <para>
        /// Steps of a leg that must be performed during the travel portion of the leg.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<RouteTaxiTravelStep> TravelSteps
        {
            get { return this._travelSteps; }
            set { this._travelSteps = value; }
        }

        // Check to see if TravelSteps property is set
        internal bool IsSetTravelSteps()
        {
            return this._travelSteps != null && (this._travelSteps.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}