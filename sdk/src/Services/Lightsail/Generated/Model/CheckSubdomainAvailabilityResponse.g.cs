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
    /// This is the response object from the CheckSubdomainAvailability operation.
    /// </summary>
    public partial class CheckSubdomainAvailabilityResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Available. 
        /// <para>
        /// A Boolean value that indicates whether the subdomain is available to create.
        /// </para>
        /// </summary>
        public bool? Available { get; set; }

        /// <summary>
        /// Checks to see if the Available property is set.
        /// </summary>
        internal bool IsSetAvailable() => this.Available.HasValue;

        /// <summary>
        /// Gets and sets the property ReservationExpiresAt. 
        /// <para>
        /// The timestamp when the reservation of the subdomain expires.
        /// </para>
        ///  
        /// <para>
        /// The expiry is returned only when your account holds an active reservation for the
        /// subdomain.
        /// </para>
        /// </summary>
        public DateTime? ReservationExpiresAt { get; set; }

        /// <summary>
        /// Checks to see if the ReservationExpiresAt property is set.
        /// </summary>
        internal bool IsSetReservationExpiresAt() => this.ReservationExpiresAt.HasValue;

        /// <summary>
        /// Gets and sets the property SubdomainName. 
        /// <para>
        /// The subdomain that was checked.
        /// </para>
        /// </summary>
        public string SubdomainName { get; set; }

        /// <summary>
        /// Checks to see if the SubdomainName property is set.
        /// </summary>
        internal bool IsSetSubdomainName() => this.SubdomainName != null;
    }
}
