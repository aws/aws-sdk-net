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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains information about the city associated with the IP address.
    /// </summary>
    public partial class City
    {
        private string _cityName;

        /// <summary>
        /// Gets and sets the property CityName. 
        /// <para>
        /// The city name of the remote IP address.
        /// </para>
        /// </summary>
        public string CityName
        {
            get { return this._cityName; }
            set { this._cityName = value; }
        }

        // Check to see if CityName property is set
        internal bool IsSetCityName()
        {
            return this._cityName != null;
        }

    }
}