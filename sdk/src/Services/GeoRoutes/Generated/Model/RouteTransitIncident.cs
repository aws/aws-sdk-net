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
    /// An incident describes disruptions on the transit route.
    /// </summary>
    public partial class RouteTransitIncident
    {
        private string _description;
        private RouteTransitIncidentEffect _effect;
        private string _endTime;
        private string _startTime;
        private RouteTransitIncidentType _type;
        private string _url;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A human readable description of the incident.
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
        /// Gets and sets the property Effect. 
        /// <para>
        /// The effect of the incident on the transit service.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public RouteTransitIncidentEffect Effect
        {
            get { return this._effect; }
            set { this._effect = value; }
        }

        // Check to see if Effect property is set
        internal bool IsSetEffect()
        {
            return this._effect != null;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end time of the incident.
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
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start time of the incident.
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
        [AWSProperty(Required=true, Sensitive=true)]
        public RouteTransitIncidentType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// URL to the original incident published at the agency website.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string Url
        {
            get { return this._url; }
            set { this._url = value; }
        }

        // Check to see if Url property is set
        internal bool IsSetUrl()
        {
            return this._url != null;
        }

    }
}