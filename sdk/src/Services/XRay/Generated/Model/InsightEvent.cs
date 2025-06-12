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
 * Do not modify this file. This file is generated from the xray-2016-04-12.normal.json service model.
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
namespace Amazon.XRay.Model
{
    /// <summary>
    /// X-Ray reevaluates insights periodically until they are resolved, and records each
    /// intermediate state in an event. You can review incident events in the Impact Timeline
    /// on the Inspect page in the X-Ray console.
    /// </summary>
    public partial class InsightEvent
    {
        private RequestImpactStatistics _clientRequestImpactStatistics;
        private DateTime? _eventTime;
        private RequestImpactStatistics _rootCauseServiceRequestImpactStatistics;
        private string _summary;
        private List<AnomalousService> _topAnomalousServices = AWSConfigs.InitializeCollections ? new List<AnomalousService>() : null;

        /// <summary>
        /// Gets and sets the property ClientRequestImpactStatistics. 
        /// <para>
        /// The impact statistics of the client side service. This includes the number of requests
        /// to the client service and whether the requests were faults or okay.
        /// </para>
        /// </summary>
        public RequestImpactStatistics ClientRequestImpactStatistics
        {
            get { return this._clientRequestImpactStatistics; }
            set { this._clientRequestImpactStatistics = value; }
        }

        // Check to see if ClientRequestImpactStatistics property is set
        internal bool IsSetClientRequestImpactStatistics()
        {
            return this._clientRequestImpactStatistics != null;
        }

        /// <summary>
        /// Gets and sets the property EventTime. 
        /// <para>
        /// The time, in Unix seconds, at which the event was recorded.
        /// </para>
        /// </summary>
        public DateTime? EventTime
        {
            get { return this._eventTime; }
            set { this._eventTime = value; }
        }

        // Check to see if EventTime property is set
        internal bool IsSetEventTime()
        {
            return this._eventTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RootCauseServiceRequestImpactStatistics. 
        /// <para>
        /// The impact statistics of the root cause service. This includes the number of requests
        /// to the client service and whether the requests were faults or okay.
        /// </para>
        /// </summary>
        public RequestImpactStatistics RootCauseServiceRequestImpactStatistics
        {
            get { return this._rootCauseServiceRequestImpactStatistics; }
            set { this._rootCauseServiceRequestImpactStatistics = value; }
        }

        // Check to see if RootCauseServiceRequestImpactStatistics property is set
        internal bool IsSetRootCauseServiceRequestImpactStatistics()
        {
            return this._rootCauseServiceRequestImpactStatistics != null;
        }

        /// <summary>
        /// Gets and sets the property Summary. 
        /// <para>
        /// A brief description of the event.
        /// </para>
        /// </summary>
        public string Summary
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
        /// Gets and sets the property TopAnomalousServices. 
        /// <para>
        /// The service during the event that is most impacted by the incident.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AnomalousService> TopAnomalousServices
        {
            get { return this._topAnomalousServices; }
            set { this._topAnomalousServices = value; }
        }

        // Check to see if TopAnomalousServices property is set
        internal bool IsSetTopAnomalousServices()
        {
            return this._topAnomalousServices != null && (this._topAnomalousServices.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}