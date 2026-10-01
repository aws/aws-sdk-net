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

namespace Amazon.TaxSettings.Model
{
    /// <summary>
    /// The jurisdiction details of the TRN information of the customers. This doesn't contain
    /// full legal address, and contains only country code and state/region/province.
    /// </summary>
    public partial class Jurisdiction
    {
        /// <summary>
        /// Gets and sets the property CountryCode. 
        /// <para>
        ///  The country code of the jurisdiction. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 2)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Checks to see if the CountryCode property is set.
        /// </summary>
        internal bool IsSetCountryCode() => this.CountryCode != null;

        /// <summary>
        /// Gets and sets the property StateOrRegion. 
        /// <para>
        ///  The state, region, or province associated with the country of the jurisdiction, if
        /// applicable. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public string StateOrRegion { get; set; }

        /// <summary>
        /// Checks to see if the StateOrRegion property is set.
        /// </summary>
        internal bool IsSetStateOrRegion() => this.StateOrRegion != null;
    }
}
