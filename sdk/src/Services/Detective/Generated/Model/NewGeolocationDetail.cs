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
 * Do not modify this file. This file is generated from the detective-2018-10-26.normal.json service model.
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
namespace Amazon.Detective.Model
{
    /// <summary>
    /// Details new geolocations used either at the resource or account level. For example,
    /// lists an observed geolocation that is an infrequent or unused location based on previous
    /// user activity.
    /// </summary>
    public partial class NewGeolocationDetail
    {
        private string _ipAddress;
        private bool? _isNewForEntireAccount;
        private string _location;

        /// <summary>
        /// Gets and sets the property IpAddress. 
        /// <para>
        /// IP address using which the resource was accessed.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property IsNewForEntireAccount. 
        /// <para>
        /// Checks if the geolocation is new for the entire account.
        /// </para>
        /// </summary>
        public bool? IsNewForEntireAccount
        {
            get { return this._isNewForEntireAccount; }
            set { this._isNewForEntireAccount = value; }
        }

        // Check to see if IsNewForEntireAccount property is set
        internal bool IsSetIsNewForEntireAccount()
        {
            return this._isNewForEntireAccount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// Location where the resource was accessed.
        /// </para>
        /// </summary>
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

    }
}