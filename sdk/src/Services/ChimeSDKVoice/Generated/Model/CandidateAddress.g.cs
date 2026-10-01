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
    /// A suggested address.
    /// </summary>
    public partial class CandidateAddress
    {
        /// <summary>
        /// Gets and sets the property City. 
        /// <para>
        /// The city of the candidate address.
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
        /// The country of the candidate address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string Country { get; set; }

        /// <summary>
        /// Checks to see if the Country property is set.
        /// </summary>
        internal bool IsSetCountry() => this.Country != null;

        /// <summary>
        /// Gets and sets the property PostalCode. 
        /// <para>
        /// The postal code of the candidate address.
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
        /// The zip + 4 or postal code +4 of the candidate address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string PostalCodePlus4 { get; set; }

        /// <summary>
        /// Checks to see if the PostalCodePlus4 property is set.
        /// </summary>
        internal bool IsSetPostalCodePlus4() => this.PostalCodePlus4 != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the candidate address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property StreetInfo. 
        /// <para>
        /// The street information of the candidate address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string StreetInfo { get; set; }

        /// <summary>
        /// Checks to see if the StreetInfo property is set.
        /// </summary>
        internal bool IsSetStreetInfo() => this.StreetInfo != null;

        /// <summary>
        /// Gets and sets the property StreetNumber. 
        /// <para>
        /// The numeric portion of the candidate address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string StreetNumber { get; set; }

        /// <summary>
        /// Checks to see if the StreetNumber property is set.
        /// </summary>
        internal bool IsSetStreetNumber() => this.StreetNumber != null;
    }
}
