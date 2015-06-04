/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the route53domains-2014-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53Domains.Model
{
    /// <summary>
    /// The CheckDomainAvailability response includes the following elements.
    /// </summary>
    public partial class CheckDomainAvailabilityResponse : AmazonWebServiceResponse
    {
        private DomainAvailability _availability;

        /// <summary>
        /// Gets and sets the property Availability. 
        /// <para>
        /// Whether the domain name is available for registering.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can only register domains designated as <code>AVAILABLE</code>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Type: String
        /// </para>
        ///  
        /// <para>
        /// Valid values:
        /// </para>
        ///  <ul> <li> <code>AVAILABLE</code> – The domain name is available.</li> <li> <code>AVAILABLE_RESERVED</code>
        /// – The domain name is reserved under specific conditions.</li> <li> <code>AVAILABLE_PREORDER</code>
        /// – The domain name is available and can be preordered.</li> <li> <code>UNAVAILABLE</code>
        /// – The domain name is not available.</li> <li> <code>UNAVAILABLE_PREMIUM</code> – The
        /// domain name is not available.</li> <li> <code>UNAVAILABLE_RESTRICTED</code> – The
        /// domain name is forbidden.</li> <li> <code>RESERVED</code> – The domain name has been
        /// reserved for another person or organization.</li> <li> <code>DONT_KNOW</code> – The
        /// TLD registry didn't reply with a definitive answer about whether the domain name is
        /// available. Amazon Route 53 can return this response for a variety of reasons, for
        /// example, the registry is performing maintenance. Try again later.</li> </ul>
        /// </summary>
        public DomainAvailability Availability
        {
            get { return this._availability; }
            set { this._availability = value; }
        }

        // Check to see if Availability property is set
        internal bool IsSetAvailability()
        {
            return this._availability != null;
        }

    }
}