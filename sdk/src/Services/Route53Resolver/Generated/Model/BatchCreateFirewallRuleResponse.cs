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
    /// This is the response object from the BatchCreateFirewallRule operation.
    /// </summary>
    public partial class BatchCreateFirewallRuleResponse : AmazonWebServiceResponse
    {
        private List<FirewallRule> _createdFirewallRules = AWSConfigs.InitializeCollections ? new List<FirewallRule>() : null;
        private List<BatchCreateFirewallRuleError> _createErrors = AWSConfigs.InitializeCollections ? new List<BatchCreateFirewallRuleError>() : null;

        /// <summary>
        /// Gets and sets the property CreatedFirewallRules. 
        /// <para>
        /// The firewall rules that were successfully created by the request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FirewallRule> CreatedFirewallRules
        {
            get { return this._createdFirewallRules; }
            set { this._createdFirewallRules = value; }
        }

        // Check to see if CreatedFirewallRules property is set
        internal bool IsSetCreatedFirewallRules()
        {
            return this._createdFirewallRules != null && (this._createdFirewallRules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CreateErrors. 
        /// <para>
        /// A list of errors that occurred while creating the firewall rules.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<BatchCreateFirewallRuleError> CreateErrors
        {
            get { return this._createErrors; }
            set { this._createErrors = value; }
        }

        // Check to see if CreateErrors property is set
        internal bool IsSetCreateErrors()
        {
            return this._createErrors != null && (this._createErrors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}