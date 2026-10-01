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

namespace Amazon.NetworkManager.Model
{
    /// <summary>
    /// Describes a location.
    /// </summary>
    public partial class Location
    {
        /// <summary>
        /// Gets and sets the property Address. 
        /// <para>
        /// The physical address.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Address { get; set; }

        /// <summary>
        /// Checks to see if the Address property is set.
        /// </summary>
        internal bool IsSetAddress() => this.Address != null;

        /// <summary>
        /// Gets and sets the property Latitude. 
        /// <para>
        /// The latitude.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Latitude { get; set; }

        /// <summary>
        /// Checks to see if the Latitude property is set.
        /// </summary>
        internal bool IsSetLatitude() => this.Latitude != null;

        /// <summary>
        /// Gets and sets the property Longitude. 
        /// <para>
        /// The longitude.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Longitude { get; set; }

        /// <summary>
        /// Checks to see if the Longitude property is set.
        /// </summary>
        internal bool IsSetLongitude() => this.Longitude != null;
    }
}
