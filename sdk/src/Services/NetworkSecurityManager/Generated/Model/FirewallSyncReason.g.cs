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

namespace Amazon.NetworkSecurityManager.Model
{
    /// <summary>
    /// Describes why a firewall is out of sync. Exactly one of <c>missingFirewall</c> or
    /// <c>invalidFirewall</c> is set.
    /// </summary>
    public partial class FirewallSyncReason
    {
        /// <summary>
        /// Gets and sets the property InvalidFirewall. 
        /// <para>
        /// Details about a firewall whose configuration does not match the intended configuration.
        /// </para>
        /// </summary>
        public InvalidFirewallReasons InvalidFirewall { get; set; }

        /// <summary>
        /// Checks to see if the InvalidFirewall property is set.
        /// </summary>
        internal bool IsSetInvalidFirewall() => this.InvalidFirewall != null;

        /// <summary>
        /// Gets and sets the property MissingFirewall. 
        /// <para>
        /// Indicates that an expected firewall is missing. The value describes the missing firewall.
        /// </para>
        /// </summary>
        public string MissingFirewall { get; set; }

        /// <summary>
        /// Checks to see if the MissingFirewall property is set.
        /// </summary>
        internal bool IsSetMissingFirewall() => this.MissingFirewall != null;
    }
}
