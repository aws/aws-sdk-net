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
    /// An incident describes disruptions on the transit route.
    /// </summary>
    public partial class RouteTransitIncident
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A human readable description of the incident.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Effect. 
        /// <para>
        /// The effect of the incident on the transit service.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public RouteTransitIncidentEffect Effect { get; set; }

        /// <summary>
        /// Checks to see if the Effect property is set.
        /// </summary>
        internal bool IsSetEffect() => this.Effect != null;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end time of the incident.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start time of the incident.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Type of the incident.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public RouteTransitIncidentType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// URL to the original incident published at the agency website.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string Url { get; set; }

        /// <summary>
        /// Checks to see if the Url property is set.
        /// </summary>
        internal bool IsSetUrl() => this.Url != null;
    }
}
