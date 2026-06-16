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
 * Do not modify this file. This file is generated from the route53resolver-2018-04-01.normal.json service model.
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
namespace Amazon.Route53Resolver.Model
{
    /// <summary>
    /// An error that occurred while updating a firewall rule in a batch operation.
    /// </summary>
    public partial class BatchUpdateFirewallRuleError
    {
        private string _code;
        private UpdateFirewallRuleEntry _firewallRule;
        private string _message;

        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// The error code for the failure.
        /// </para>
        /// </summary>
        public string Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        // Check to see if Code property is set
        internal bool IsSetCode()
        {
            return this._code != null;
        }

        /// <summary>
        /// Gets and sets the property FirewallRule. 
        /// <para>
        /// The firewall rule entry that caused the error.
        /// </para>
        /// </summary>
        public UpdateFirewallRuleEntry FirewallRule
        {
            get { return this._firewallRule; }
            set { this._firewallRule = value; }
        }

        // Check to see if FirewallRule property is set
        internal bool IsSetFirewallRule()
        {
            return this._firewallRule != null;
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A message that provides details about the error.
        /// </para>
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

    }
}