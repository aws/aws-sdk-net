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
 * Do not modify this file. This file is generated from the wickr-2024-02-01.normal.json service model.
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
        private string _billingPeriod;
        private string _username;
        private string _usernameHash;

        /// <summary>
        /// Gets and sets the property BillingPeriod. 
        /// <para>
        /// The billing period when this guest user accessed the network (e.g., '2024-01').
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BillingPeriod
        {
            get { return this._billingPeriod; }
            set { this._billingPeriod = value; }
        }

        // Check to see if BillingPeriod property is set
        internal bool IsSetBillingPeriod()
        {
            return this._billingPeriod != null;
        }

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// The username of the guest user.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Username
        {
            get { return this._username; }
            set { this._username = value; }
        }

        // Check to see if Username property is set
        internal bool IsSetUsername()
        {
            return this._username != null;
        }

        /// <summary>
        /// Gets and sets the property UsernameHash. 
        /// <para>
        /// The unique username hash identifier for the guest user.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string UsernameHash
        {
            get { return this._usernameHash; }
            set { this._usernameHash = value; }
        }

        // Check to see if UsernameHash property is set
        internal bool IsSetUsernameHash()
        {
            return this._usernameHash != null;
        }

    }
}