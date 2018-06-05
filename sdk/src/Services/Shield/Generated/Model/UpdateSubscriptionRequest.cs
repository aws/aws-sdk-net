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
 * Do not modify this file. This file is generated from the shield-2016-06-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Shield.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateSubscription operation.
    /// Updates the details of an existing subscription. Only enter values for parameters
    /// you want to change. Empty parameters are not updated.
    /// </summary>
    public partial class UpdateSubscriptionRequest : AmazonShieldRequest
    {
        private AutoRenew _autoRenew;

        /// <summary>
        /// Gets and sets the property AutoRenew. 
        /// <para>
        /// When you initally create a subscription, <code>AutoRenew</code> is set to <code>ENABLED</code>.
        /// If <code>ENABLED</code>, the subscription will be automatically renewed at the end
        /// of the existing subscription period. You can change this by submitting an <code>UpdateSubscription</code>
        /// request. If the <code>UpdateSubscription</code> request does not included a value
        /// for <code>AutoRenew</code>, the existing value for <code>AutoRenew</code> remains
        /// unchanged.
        /// </para>
        /// </summary>
        public AutoRenew AutoRenew
        {
            get { return this._autoRenew; }
            set { this._autoRenew = value; }
        }

        // Check to see if AutoRenew property is set
        internal bool IsSetAutoRenew()
        {
            return this._autoRenew != null;
        }

    }
}