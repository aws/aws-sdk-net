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

namespace Amazon.Route53GlobalResolver.Model
{
    /// <summary>
    /// Information about the result of creating a DNS Firewall rule in a batch operation.
    /// </summary>
    public partial class BatchCreateFirewallRuleOutputItem
    {
        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// The HTTP response code for the batch operation result.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? Code { get; set; }

        /// <summary>
        /// Checks to see if the Code property is set.
        /// </summary>
        internal bool IsSetCode() => this.Code.HasValue;

        /// <summary>
        /// Gets and sets the property FirewallRule. 
        /// <para>
        /// The firewall rule that was created in the batch operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public BatchCreateFirewallRuleResult FirewallRule { get; set; }

        /// <summary>
        /// Checks to see if the FirewallRule property is set.
        /// </summary>
        internal bool IsSetFirewallRule() => this.FirewallRule != null;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A message describing the result of the batch operation, including error details if
        /// applicable.
        /// </para>
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;
    }
}
