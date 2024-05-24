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
 * Do not modify this file. This file is generated from the networkmanager-2019-07-05.normal.json service model.
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
        private string _address;
        private string _latitude;
        private string _longitude;

        /// <summary>
        /// Gets and sets the property Address. 
        /// <para>
        /// The physical address.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string Address
        {
            get { return this._address; }
            set { this._address = value; }
        }

        // Check to see if Address property is set
        internal bool IsSetAddress()
        {
            return this._address != null;
        }

        /// <summary>
        /// Gets and sets the property Latitude. 
        /// <para>
        /// The latitude.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string Latitude
        {
            get { return this._latitude; }
            set { this._latitude = value; }
        }

        // Check to see if Latitude property is set
        internal bool IsSetLatitude()
        {
            return this._latitude != null;
        }

        /// <summary>
        /// Gets and sets the property Longitude. 
        /// <para>
        /// The longitude.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string Longitude
        {
            get { return this._longitude; }
            set { this._longitude = value; }
        }

        // Check to see if Longitude property is set
        internal bool IsSetLongitude()
        {
            return this._longitude != null;
        }

    }
}