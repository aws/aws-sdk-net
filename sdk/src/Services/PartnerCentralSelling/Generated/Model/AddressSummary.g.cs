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
    /// An object that contains an <c>Address</c> object's subset of fields.
    /// </summary>
    public partial class AddressSummary
    {
        /// <summary>
        /// Gets and sets the property City. 
        /// <para>
        /// Specifies the end <c>Customer</c>'s city associated with the <c>Opportunity</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string City { get; set; }

        /// <summary>
        /// Checks to see if the City property is set.
        /// </summary>
        internal bool IsSetCity() => this.City != null;

        /// <summary>
        /// Gets and sets the property CountryCode. 
        /// <para>
        /// Specifies the end <c>Customer</c>'s country associated with the <c>Opportunity</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public CountryCode CountryCode { get; set; }

        /// <summary>
        /// Checks to see if the CountryCode property is set.
        /// </summary>
        internal bool IsSetCountryCode() => this.CountryCode != null;

        /// <summary>
        /// Gets and sets the property PostalCode. 
        /// <para>
        /// Specifies the end <c>Customer</c>'s postal code associated with the <c>Opportunity</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Checks to see if the PostalCode property is set.
        /// </summary>
        internal bool IsSetPostalCode() => this.PostalCode != null;

        /// <summary>
        /// Gets and sets the property StateOrRegion. 
        /// <para>
        /// Specifies the end <c>Customer</c>'s state or region associated with the <c>Opportunity</c>.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>Alabama | Alaska | American Samoa | Arizona | Arkansas | California
        /// | Colorado | Connecticut | Delaware | Dist. of Columbia | Federated States of Micronesia
        /// | Florida | Georgia | Guam | Hawaii | Idaho | Illinois | Indiana | Iowa | Kansas |
        /// Kentucky | Louisiana | Maine | Marshall Islands | Maryland | Massachusetts | Michigan
        /// | Minnesota | Mississippi | Missouri | Montana | Nebraska | Nevada | New Hampshire
        /// | New Jersey | New Mexico | New York | North Carolina | North Dakota | Northern Mariana
        /// Islands | Ohio | Oklahoma | Oregon | Palau | Pennsylvania | Puerto Rico | Rhode Island
        /// | South Carolina | South Dakota | Tennessee | Texas | Utah | Vermont | Virginia |
        /// Virgin Islands | Washington | West Virginia | Wisconsin | Wyoming | APO/AE | AFO/FPO
        /// | FPO, AP</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string StateOrRegion { get; set; }

        /// <summary>
        /// Checks to see if the StateOrRegion property is set.
        /// </summary>
        internal bool IsSetStateOrRegion() => this.StateOrRegion != null;
    }
}
