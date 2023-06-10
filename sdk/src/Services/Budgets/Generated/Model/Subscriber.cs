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
 * Do not modify this file. This file is generated from the budgets-2016-10-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Budgets.Model
{
    /// <summary>
    /// The subscriber to a budget notification. The subscriber consists of a subscription
    /// type and either an Amazon SNS topic or an email address.
    /// 
    ///  
    /// <para>
    /// For example, an email subscriber has the following parameters:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// A <code>subscriptionType</code> of <code>EMAIL</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// An <code>address</code> of <code>example@example.com</code> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class Subscriber
    {
        private string _address;
        private SubscriptionType _subscriptionType;

        /// <summary>
        /// Gets and sets the property Address. 
        /// <para>
        /// The address that Amazon Web Services sends budget notifications to, either an SNS
        /// topic or an email.
        /// </para>
        ///  
        /// <para>
        /// When you create a subscriber, the value of <code>Address</code> can't contain line
        /// breaks.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=2147483647)]
        public string Address
        {
            get { return this._address; }
            set { this._address = value; }
        }

        // Check to see if Address property is set
        internal bool IsSetAddress()
        {
            return this._address != null;
        }

        /// <summary>
        /// Gets and sets the property SubscriptionType. 
        /// <para>
        /// The type of notification that Amazon Web Services sends to a subscriber.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SubscriptionType SubscriptionType
        {
            get { return this._subscriptionType; }
            set { this._subscriptionType = value; }
        }

        // Check to see if SubscriptionType property is set
        internal bool IsSetSubscriptionType()
        {
            return this._subscriptionType != null;
        }

    }
}