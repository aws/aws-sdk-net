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
    /// This is the response object from the BatchUpdateFirewallRule operation.
    /// </summary>
    public partial class BatchUpdateFirewallRuleResponse : AmazonWebServiceResponse
    {
        private List<FirewallRule> _updatedFirewallRules = AWSConfigs.InitializeCollections ? new List<FirewallRule>() : null;
        private List<BatchUpdateFirewallRuleError> _updateErrors = AWSConfigs.InitializeCollections ? new List<BatchUpdateFirewallRuleError>() : null;

        /// <summary>
        /// Gets and sets the property UpdatedFirewallRules. 
        /// <para>
        /// The firewall rules that were successfully updated by the request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FirewallRule> UpdatedFirewallRules
        {
            get { return this._updatedFirewallRules; }
            set { this._updatedFirewallRules = value; }
        }

        // Check to see if UpdatedFirewallRules property is set
        internal bool IsSetUpdatedFirewallRules()
        {
            return this._updatedFirewallRules != null && (this._updatedFirewallRules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UpdateErrors. 
        /// <para>
        /// A list of errors that occurred while updating the firewall rules.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<BatchUpdateFirewallRuleError> UpdateErrors
        {
            get { return this._updateErrors; }
            set { this._updateErrors = value; }
        }

        // Check to see if UpdateErrors property is set
        internal bool IsSetUpdateErrors()
        {
            return this._updateErrors != null && (this._updateErrors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}