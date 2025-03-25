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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
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
        private string _city;
        private string _country;
        private string _deviceName;
        private string _ipAddress;
        private string _timezone;

        /// <summary>
        /// Gets and sets the property City. 
        /// <para>
        /// The user's city.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=131072)]
        public string City
        {
            get { return this._city; }
            set { this._city = value; }
        }

        // Check to see if City property is set
        internal bool IsSetCity()
        {
            return this._city != null;
        }

        /// <summary>
        /// Gets and sets the property Country. 
        /// <para>
        /// The user's country.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=131072)]
        public string Country
        {
            get { return this._country; }
            set { this._country = value; }
        }

        // Check to see if Country property is set
        internal bool IsSetCountry()
        {
            return this._country != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceName. 
        /// <para>
        /// The user's device name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=131072)]
        public string DeviceName
        {
            get { return this._deviceName; }
            set { this._deviceName = value; }
        }

        // Check to see if DeviceName property is set
        internal bool IsSetDeviceName()
        {
            return this._deviceName != null;
        }

        /// <summary>
        /// Gets and sets the property IpAddress. 
        /// <para>
        /// The source IP address of your user's device.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=131072)]
        public string IpAddress
        {
            get { return this._ipAddress; }
            set { this._ipAddress = value; }
        }

        // Check to see if IpAddress property is set
        internal bool IsSetIpAddress()
        {
            return this._ipAddress != null;
        }

        /// <summary>
        /// Gets and sets the property Timezone. 
        /// <para>
        /// The user's time zone.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=131072)]
        public string Timezone
        {
            get { return this._timezone; }
            set { this._timezone = value; }
        }

        // Check to see if Timezone property is set
        internal bool IsSetTimezone()
        {
            return this._timezone != null;
        }

    }
}