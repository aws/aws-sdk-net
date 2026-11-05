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

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Specifies demographic information about an endpoint, such as the applicable time zone
    /// and platform.
    /// </summary>
    public partial class EndpointDemographic
    {
        /// <summary>
        /// Gets and sets the property AppVersion. 
        /// <para>
        /// The version of the app that's associated with the endpoint.
        /// </para>
        /// </summary>
        public string AppVersion { get; set; }

        /// <summary>
        /// Checks to see if the AppVersion property is set.
        /// </summary>
        internal bool IsSetAppVersion() => this.AppVersion != null;

        /// <summary>
        /// Gets and sets the property Locale. 
        /// <para>
        /// The locale of the endpoint, in the following format: the ISO 639-1 alpha-2 code, followed
        /// by an underscore (_), followed by an ISO 3166-1 alpha-2 value.
        /// </para>
        /// </summary>
        public string Locale { get; set; }

        /// <summary>
        /// Checks to see if the Locale property is set.
        /// </summary>
        internal bool IsSetLocale() => this.Locale != null;

        /// <summary>
        /// Gets and sets the property Make. 
        /// <para>
        /// The manufacturer of the endpoint device, such as apple or samsung.
        /// </para>
        /// </summary>
        public string Make { get; set; }

        /// <summary>
        /// Checks to see if the Make property is set.
        /// </summary>
        internal bool IsSetMake() => this.Make != null;

        /// <summary>
        /// Gets and sets the property Model. 
        /// <para>
        /// The model name or number of the endpoint device, such as iPhone or SM-G900F.
        /// </para>
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// Checks to see if the Model property is set.
        /// </summary>
        internal bool IsSetModel() => this.Model != null;

        /// <summary>
        /// Gets and sets the property ModelVersion. 
        /// <para>
        /// The model version of the endpoint device.
        /// </para>
        /// </summary>
        public string ModelVersion { get; set; }

        /// <summary>
        /// Checks to see if the ModelVersion property is set.
        /// </summary>
        internal bool IsSetModelVersion() => this.ModelVersion != null;

        /// <summary>
        /// Gets and sets the property Platform. 
        /// <para>
        /// The platform of the endpoint device, such as ios.
        /// </para>
        /// </summary>
        public string Platform { get; set; }

        /// <summary>
        /// Checks to see if the Platform property is set.
        /// </summary>
        internal bool IsSetPlatform() => this.Platform != null;

        /// <summary>
        /// Gets and sets the property PlatformVersion. 
        /// <para>
        /// The platform version of the endpoint device.
        /// </para>
        /// </summary>
        public string PlatformVersion { get; set; }

        /// <summary>
        /// Checks to see if the PlatformVersion property is set.
        /// </summary>
        internal bool IsSetPlatformVersion() => this.PlatformVersion != null;

        /// <summary>
        /// Gets and sets the property Timezone. 
        /// <para>
        /// The time zone of the endpoint, specified as a tz database name value, such as America/Los_Angeles.
        /// </para>
        /// </summary>
        public string Timezone { get; set; }

        /// <summary>
        /// Checks to see if the Timezone property is set.
        /// </summary>
        internal bool IsSetTimezone() => this.Timezone != null;
    }
}
