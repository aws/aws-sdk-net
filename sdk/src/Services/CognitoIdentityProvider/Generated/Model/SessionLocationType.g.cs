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
    /// The geographic location of the most recent activity on a session, derived from the
    /// IP address.
    /// </summary>
    public partial class SessionLocationType
    {
        /// <summary>
        /// Gets and sets the property City. 
        /// <para>
        /// The city of the most recent activity on the session, derived from the IP address.
        /// This value can be null if geo-IP resolution fails. The maximum length is 256 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string City { get; set; }

        /// <summary>
        /// Checks to see if the City property is set.
        /// </summary>
        internal bool IsSetCity() => this.City != null;

        /// <summary>
        /// Gets and sets the property Country. 
        /// <para>
        /// The country of the most recent activity on the session, derived from the IP address
        /// and returned in English (for example, <c>United States</c>). This is a country name
        /// as returned by the geo-IP database, not an ISO country code, and can be <c>unknown</c>
        /// if geo-IP resolution fails.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Country { get; set; }

        /// <summary>
        /// Checks to see if the Country property is set.
        /// </summary>
        internal bool IsSetCountry() => this.Country != null;
    }
}
