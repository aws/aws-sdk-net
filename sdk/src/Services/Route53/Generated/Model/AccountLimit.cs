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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
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
namespace Amazon.Route53.Model
{
    /// <summary>
    /// A complex type that contains the type of limit that you specified in the request and
    /// the current value for that limit.
    /// </summary>
    public partial class AccountLimit
    {
        private AccountLimitType _type;
        private long? _value;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The limit that you requested. Valid values include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>MAX_HEALTH_CHECKS_BY_OWNER</b>: The maximum number of health checks that you can
        /// create using the current account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MAX_HOSTED_ZONES_BY_OWNER</b>: The maximum number of hosted zones that you can
        /// create using the current account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MAX_REUSABLE_DELEGATION_SETS_BY_OWNER</b>: The maximum number of reusable delegation
        /// sets that you can create using the current account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MAX_TRAFFIC_POLICIES_BY_OWNER</b>: The maximum number of traffic policies that
        /// you can create using the current account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MAX_TRAFFIC_POLICY_INSTANCES_BY_OWNER</b>: The maximum number of traffic policy
        /// instances that you can create using the current account. (Traffic policy instances
        /// are referred to as traffic flow policy records in the Amazon Route 53 console.)
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public AccountLimitType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The current value for the limit that is specified by <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_AccountLimit.html#Route53-Type-AccountLimit-Type">Type</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public long? Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value.HasValue; 
        }

    }
}