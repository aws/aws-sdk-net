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

namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// A generic address associated with the customer that is not mailing, shipping, or billing.
    /// </summary>
    public partial class Address
    {
        /// <summary>
        /// Gets and sets the property Address1. 
        /// <para>
        /// The first line of a customer address.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Address1 { get; set; }

        /// <summary>
        /// Checks to see if the Address1 property is set.
        /// </summary>
        internal bool IsSetAddress1() => this.Address1 != null;

        /// <summary>
        /// Gets and sets the property Address2. 
        /// <para>
        /// The second line of a customer address.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Address2 { get; set; }

        /// <summary>
        /// Checks to see if the Address2 property is set.
        /// </summary>
        internal bool IsSetAddress2() => this.Address2 != null;

        /// <summary>
        /// Gets and sets the property Address3. 
        /// <para>
        /// The third line of a customer address.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Address3 { get; set; }

        /// <summary>
        /// Checks to see if the Address3 property is set.
        /// </summary>
        internal bool IsSetAddress3() => this.Address3 != null;

        /// <summary>
        /// Gets and sets the property Address4. 
        /// <para>
        /// The fourth line of a customer address.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Address4 { get; set; }

        /// <summary>
        /// Checks to see if the Address4 property is set.
        /// </summary>
        internal bool IsSetAddress4() => this.Address4 != null;

        /// <summary>
        /// Gets and sets the property City. 
        /// <para>
        /// The city in which a customer lives.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string City { get; set; }

        /// <summary>
        /// Checks to see if the City property is set.
        /// </summary>
        internal bool IsSetCity() => this.City != null;

        /// <summary>
        /// Gets and sets the property Country. 
        /// <para>
        /// The country in which a customer lives.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Country { get; set; }

        /// <summary>
        /// Checks to see if the Country property is set.
        /// </summary>
        internal bool IsSetCountry() => this.Country != null;

        /// <summary>
        /// Gets and sets the property County. 
        /// <para>
        /// The county in which a customer lives.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string County { get; set; }

        /// <summary>
        /// Checks to see if the County property is set.
        /// </summary>
        internal bool IsSetCounty() => this.County != null;

        /// <summary>
        /// Gets and sets the property PostalCode. 
        /// <para>
        /// The postal code of a customer address.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Checks to see if the PostalCode property is set.
        /// </summary>
        internal bool IsSetPostalCode() => this.PostalCode != null;

        /// <summary>
        /// Gets and sets the property Province. 
        /// <para>
        /// The province in which a customer lives.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Province { get; set; }

        /// <summary>
        /// Checks to see if the Province property is set.
        /// </summary>
        internal bool IsSetProvince() => this.Province != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state in which a customer lives.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
