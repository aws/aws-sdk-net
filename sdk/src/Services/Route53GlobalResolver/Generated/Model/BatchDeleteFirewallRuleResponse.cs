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
 * Do not modify this file. This file is generated from the route53globalresolver-2022-09-27.normal.json service model.
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
    /// This is the response object from the BatchDeleteFirewallRule operation.
    /// </summary>
    public partial class BatchDeleteFirewallRuleResponse : AmazonWebServiceResponse
    {
        private List<BatchDeleteFirewallRuleOutputItem> _failures = AWSConfigs.InitializeCollections ? new List<BatchDeleteFirewallRuleOutputItem>() : null;
        private List<BatchDeleteFirewallRuleOutputItem> _successes = AWSConfigs.InitializeCollections ? new List<BatchDeleteFirewallRuleOutputItem>() : null;

        /// <summary>
        /// Gets and sets the property Failures. 
        /// <para>
        /// High level information about the DNS Firewall rules that failed to delete.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<BatchDeleteFirewallRuleOutputItem> Failures
        {
            get { return this._failures; }
            set { this._failures = value; }
        }

        // Check to see if Failures property is set
        internal bool IsSetFailures()
        {
            return this._failures != null && (this._failures.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Successes. 
        /// <para>
        /// High level information about the DNS Firewall rules that were deleted successfully.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<BatchDeleteFirewallRuleOutputItem> Successes
        {
            get { return this._successes; }
            set { this._successes = value; }
        }

        // Check to see if Successes property is set
        internal bool IsSetSuccesses()
        {
            return this._successes != null && (this._successes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}