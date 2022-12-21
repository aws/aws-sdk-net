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
 * Do not modify this file. This file is generated from the route53domains-2014-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

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
        /// You can register only domains designated as <code>AVAILABLE</code>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Valid values:
        /// </para>
        ///  <dl> <dt>AVAILABLE</dt> <dd> 
        /// <para>
        /// The domain name is available.
        /// </para>
        ///  </dd> <dt>AVAILABLE_RESERVED</dt> <dd> 
        /// <para>
        /// The domain name is reserved under specific conditions.
        /// </para>
        ///  </dd> <dt>AVAILABLE_PREORDER</dt> <dd> 
        /// <para>
        /// The domain name is available and can be preordered.
        /// </para>
        ///  </dd> <dt>DONT_KNOW</dt> <dd> 
        /// <para>
        /// The TLD registry didn't reply with a definitive answer about whether the domain name
        /// is available. Route 53 can return this response for a variety of reasons, for example,
        /// the registry is performing maintenance. Try again later.
        /// </para>
        ///  </dd> <dt>PENDING</dt> <dd> 
        /// <para>
        /// The TLD registry didn't return a response in the expected amount of time. When the
        /// response is delayed, it usually takes just a few extra seconds. You can resubmit the
        /// request immediately.
        /// </para>
        ///  </dd> <dt>RESERVED</dt> <dd> 
        /// <para>
        /// The domain name has been reserved for another person or organization.
        /// </para>
        ///  </dd> <dt>UNAVAILABLE</dt> <dd> 
        /// <para>
        /// The domain name is not available.
        /// </para>
        ///  </dd> <dt>UNAVAILABLE_PREMIUM</dt> <dd> 
        /// <para>
        /// The domain name is not available.
        /// </para>
        ///  </dd> <dt>UNAVAILABLE_RESTRICTED</dt> <dd> 
        /// <para>
        /// The domain name is forbidden.
        /// </para>
        ///  </dd> </dl>
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