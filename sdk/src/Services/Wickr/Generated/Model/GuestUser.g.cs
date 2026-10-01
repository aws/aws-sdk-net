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

namespace Amazon.Wickr.Model
{
    /// <summary>
    /// Represents a guest user who has accessed the network from a federated Wickr network.
    /// </summary>
    public partial class GuestUser
    {
        /// <summary>
        /// Gets and sets the property BillingPeriod. 
        /// <para>
        /// The billing period when this guest user accessed the network (e.g., '2024-01').
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string BillingPeriod { get; set; }

        /// <summary>
        /// Checks to see if the BillingPeriod property is set.
        /// </summary>
        internal bool IsSetBillingPeriod() => this.BillingPeriod != null;

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// The username of the guest user.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Username { get; set; }

        /// <summary>
        /// Checks to see if the Username property is set.
        /// </summary>
        internal bool IsSetUsername() => this.Username != null;

        /// <summary>
        /// Gets and sets the property UsernameHash. 
        /// <para>
        /// The unique username hash identifier for the guest user.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string UsernameHash { get; set; }

        /// <summary>
        /// Checks to see if the UsernameHash property is set.
        /// </summary>
        internal bool IsSetUsernameHash() => this.UsernameHash != null;
    }
}
