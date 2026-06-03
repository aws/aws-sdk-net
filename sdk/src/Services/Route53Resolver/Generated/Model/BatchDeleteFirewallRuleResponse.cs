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
    /// This is the response object from the BatchDeleteFirewallRule operation.
    /// </summary>
    public partial class BatchDeleteFirewallRuleResponse : AmazonWebServiceResponse
    {
        private List<FirewallRule> _deletedFirewallRules = AWSConfigs.InitializeCollections ? new List<FirewallRule>() : null;
        private List<BatchDeleteFirewallRuleError> _deleteErrors = AWSConfigs.InitializeCollections ? new List<BatchDeleteFirewallRuleError>() : null;

        /// <summary>
        /// Gets and sets the property DeletedFirewallRules. 
        /// <para>
        /// The firewall rules that were successfully deleted by the request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FirewallRule> DeletedFirewallRules
        {
            get { return this._deletedFirewallRules; }
            set { this._deletedFirewallRules = value; }
        }

        // Check to see if DeletedFirewallRules property is set
        internal bool IsSetDeletedFirewallRules()
        {
            return this._deletedFirewallRules != null && (this._deletedFirewallRules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DeleteErrors. 
        /// <para>
        /// A list of errors that occurred while deleting the firewall rules.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<BatchDeleteFirewallRuleError> DeleteErrors
        {
            get { return this._deleteErrors; }
            set { this._deleteErrors = value; }
        }

        // Check to see if DeleteErrors property is set
        internal bool IsSetDeleteErrors()
        {
            return this._deleteErrors != null && (this._deleteErrors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}