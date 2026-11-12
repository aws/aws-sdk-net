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

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Container for the parameters to the CheckSubdomainAvailability operation. Checks whether
    /// a Lightsail subdomain is available to create. Optionally, reserves the subdomain for
    /// your account for 15 minutes. <para> If you don't reserve the subdomain, another account
    /// can create it before you do. </para>
    /// </summary>
    public partial class CheckSubdomainAvailabilityRequest : AmazonLightsailRequest
    {
        /// <summary>
        /// Gets and sets the property Reserve. 
        /// <para>
        /// Specifies whether to reserve the subdomain for your account if it's available. A reservation
        /// holds the subdomain for 15 minutes so that other accounts can't create it. Checking
        /// the subdomain again doesn't extend the reservation.
        /// </para>
        ///  
        /// <para>
        /// For a nested subdomain, such as <c>blog.mysite</c>, the top-level subdomain (<c>mysite</c>)
        /// is reserved.
        /// </para>
        ///  
        /// <para>
        /// You can have up to 5 active reservations at a time.
        /// </para>
        /// </summary>
        public bool? Reserve { get; set; }

        /// <summary>
        /// Checks to see if the Reserve property is set.
        /// </summary>
        internal bool IsSetReserve() => this.Reserve.HasValue;

        /// <summary>
        /// Gets and sets the property SubdomainName. 
        /// <para>
        /// The subdomain to check (for example, <c>mysite</c> or <c>blog.mysite</c>).
        /// </para>
        ///  
        /// <para>
        /// A subdomain can contain one or two labels separated by a period (<c>.</c>). Each label
        /// must start and end with a lowercase letter or a number, and can contain only lowercase
        /// letters, numbers, and hyphens (<c>-</c>). The name can be up to 39 characters long,
        /// including periods. Labels that start with <c>xn--</c> aren't supported, and some names
        /// are reserved.
        /// </para>
        ///  
        /// <para>
        /// Specify only the subdomain. A web address, such as <c>mysite.amazonlightsail.com</c>,
        /// isn't accepted.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SubdomainName { get; set; }

        /// <summary>
        /// Checks to see if the SubdomainName property is set.
        /// </summary>
        internal bool IsSetSubdomainName() => this.SubdomainName != null;
    }
}
