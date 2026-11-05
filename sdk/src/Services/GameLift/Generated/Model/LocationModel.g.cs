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

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Properties of a location, which can include its name, ARN (for custom locations),
    /// and ping beacon information.
    /// </summary>
    public partial class LocationModel
    {
        /// <summary>
        /// Gets and sets the property LocationArn. 
        /// <para>
        /// The Amazon Resource Name (<a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-arn-format.html">ARN</a>)
        /// that is assigned to a custom location resource and uniquely identifies it. ARNs are
        /// unique across all Regions. Format is <c>arn:aws:gamelift:&lt;region&gt;::location/location-a1234567-b8c9-0d1e-2fa3-b45c6d7e8912</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string LocationArn { get; set; }

        /// <summary>
        /// Checks to see if the LocationArn property is set.
        /// </summary>
        internal bool IsSetLocationArn() => this.LocationArn != null;

        /// <summary>
        /// Gets and sets the property LocationName. 
        /// <para>
        /// The location's name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string LocationName { get; set; }

        /// <summary>
        /// Checks to see if the LocationName property is set.
        /// </summary>
        internal bool IsSetLocationName() => this.LocationName != null;

        /// <summary>
        /// Gets and sets the property PingBeacon. 
        /// <para>
        /// Information about the UDP ping beacon for this location. Ping beacons are fixed endpoints
        /// that you can use to measure network latency between a player device and an Amazon
        /// GameLift Servers hosting location.
        /// </para>
        /// </summary>
        public PingBeacon PingBeacon { get; set; }

        /// <summary>
        /// Checks to see if the PingBeacon property is set.
        /// </summary>
        internal bool IsSetPingBeacon() => this.PingBeacon != null;
    }
}
