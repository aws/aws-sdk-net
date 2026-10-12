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

namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// The address information for a lead customer, including city, state or region, postal
    /// code, and country code.
    /// </summary>
    public partial class LeadAddress
    {
        /// <summary>
        /// Gets and sets the property City. 
        /// <para>
        /// The city of the lead customer's address.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 255)]
        public string City { get; set; }

        /// <summary>
        /// Checks to see if the City property is set.
        /// </summary>
        internal bool IsSetCity() => this.City != null;

        /// <summary>
        /// Gets and sets the property CountryCode. 
        /// <para>
        /// The country code of the lead customer's address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 10)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Checks to see if the CountryCode property is set.
        /// </summary>
        internal bool IsSetCountryCode() => this.CountryCode != null;

        /// <summary>
        /// Gets and sets the property PostalCode. 
        /// <para>
        /// The postal code of the lead customer's address.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 20)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Checks to see if the PostalCode property is set.
        /// </summary>
        internal bool IsSetPostalCode() => this.PostalCode != null;

        /// <summary>
        /// Gets and sets the property StateOrRegion. 
        /// <para>
        /// The state or region of the lead customer's address.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 255)]
        public string StateOrRegion { get; set; }

        /// <summary>
        /// Checks to see if the StateOrRegion property is set.
        /// </summary>
        internal bool IsSetStateOrRegion() => this.StateOrRegion != null;
    }
}
