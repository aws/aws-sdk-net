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

namespace Amazon.ChimeSDKVoice.Model
{
    /// <summary>
    /// A validated address.
    /// </summary>
    public partial class Address
    {
        /// <summary>
        /// Gets and sets the property City. 
        /// <para>
        /// The city of an address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string City { get; set; }

        /// <summary>
        /// Checks to see if the City property is set.
        /// </summary>
        internal bool IsSetCity() => this.City != null;

        /// <summary>
        /// Gets and sets the property Country. 
        /// <para>
        /// The country of an address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string Country { get; set; }

        /// <summary>
        /// Checks to see if the Country property is set.
        /// </summary>
        internal bool IsSetCountry() => this.Country != null;

        /// <summary>
        /// Gets and sets the property PostDirectional. 
        /// <para>
        /// An address suffix location, such as the <c>S. Unit A</c> in <c>Central Park S. Unit
        /// A</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string PostDirectional { get; set; }

        /// <summary>
        /// Checks to see if the PostDirectional property is set.
        /// </summary>
        internal bool IsSetPostDirectional() => this.PostDirectional != null;

        /// <summary>
        /// Gets and sets the property PostalCode. 
        /// <para>
        /// The postal code of an address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Checks to see if the PostalCode property is set.
        /// </summary>
        internal bool IsSetPostalCode() => this.PostalCode != null;

        /// <summary>
        /// Gets and sets the property PostalCodePlus4. 
        /// <para>
        /// The zip + 4 or postal code + 4 of an address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string PostalCodePlus4 { get; set; }

        /// <summary>
        /// Checks to see if the PostalCodePlus4 property is set.
        /// </summary>
        internal bool IsSetPostalCodePlus4() => this.PostalCodePlus4 != null;

        /// <summary>
        /// Gets and sets the property PreDirectional. 
        /// <para>
        /// An address prefix location, such as the <c>N</c> in <c>N. Third St.</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string PreDirectional { get; set; }

        /// <summary>
        /// Checks to see if the PreDirectional property is set.
        /// </summary>
        internal bool IsSetPreDirectional() => this.PreDirectional != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of an address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property StreetName. 
        /// <para>
        /// The address street, such as <c>8th Avenue</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string StreetName { get; set; }

        /// <summary>
        /// Checks to see if the StreetName property is set.
        /// </summary>
        internal bool IsSetStreetName() => this.StreetName != null;

        /// <summary>
        /// Gets and sets the property StreetNumber. 
        /// <para>
        /// The numeric portion of an address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string StreetNumber { get; set; }

        /// <summary>
        /// Checks to see if the StreetNumber property is set.
        /// </summary>
        internal bool IsSetStreetNumber() => this.StreetNumber != null;

        /// <summary>
        /// Gets and sets the property StreetSuffix. 
        /// <para>
        /// The address suffix, such as the <c>N</c> in <c>8th Avenue N</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string StreetSuffix { get; set; }

        /// <summary>
        /// Checks to see if the StreetSuffix property is set.
        /// </summary>
        internal bool IsSetStreetSuffix() => this.StreetSuffix != null;
    }
}
