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
    /// Incidents corresponding to this leg of the route.
    /// </summary>
    public partial class RouteVehicleIncident
    {
        private string _description;
        private string _endTime;
        private RouteVehicleIncidentSeverity _severity;
        private string _startTime;
        private RouteVehicleIncidentType _type;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Brief readable description of the incident.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// End timestamp of the incident.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime != null;
        }

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// Severity of the incident Critical - The part of the route the incident affects is
        /// unusable. Major- Major impact on the leg duration, for example stop and go Minor-
        /// Minor impact on the leg duration, for example traffic jam Low - Low on duration, for
        /// example slightly increased traffic
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public RouteVehicleIncidentSeverity Severity
        {
            get { return this._severity; }
            set { this._severity = value; }
        }

        // Check to see if Severity property is set
        internal bool IsSetSeverity()
        {
            return this._severity != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// Start time of the incident.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Type of the incident.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public RouteVehicleIncidentType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}