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

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// The context data that your application submitted in an authentication request with
    /// threat protection, as displayed in an <c>AdminListUserAuthEvents</c> response.
    /// </summary>
    public partial class EventContextDataType
    {
        /// <summary>
        /// Gets and sets the property City. 
        /// <para>
        /// The user's city.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 131072)]
        public string City { get; set; }

        /// <summary>
        /// Checks to see if the City property is set.
        /// </summary>
        internal bool IsSetCity() => this.City != null;

        /// <summary>
        /// Gets and sets the property Country. 
        /// <para>
        /// The user's country.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 131072)]
        public string Country { get; set; }

        /// <summary>
        /// Checks to see if the Country property is set.
        /// </summary>
        internal bool IsSetCountry() => this.Country != null;

        /// <summary>
        /// Gets and sets the property DeviceName. 
        /// <para>
        /// The user's device name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 131072)]
        public string DeviceName { get; set; }

        /// <summary>
        /// Checks to see if the DeviceName property is set.
        /// </summary>
        internal bool IsSetDeviceName() => this.DeviceName != null;

        /// <summary>
        /// Gets and sets the property IpAddress. 
        /// <para>
        /// The source IP address of your user's device.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 131072)]
        public string IpAddress { get; set; }

        /// <summary>
        /// Checks to see if the IpAddress property is set.
        /// </summary>
        internal bool IsSetIpAddress() => this.IpAddress != null;

        /// <summary>
        /// Gets and sets the property Timezone. 
        /// <para>
        /// The user's time zone.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 131072)]
        public string Timezone { get; set; }

        /// <summary>
        /// Checks to see if the Timezone property is set.
        /// </summary>
        internal bool IsSetTimezone() => this.Timezone != null;
    }
}
