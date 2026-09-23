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
 * Do not modify this file. This file is generated from the network-security-manager-2025-10-30.normal.json service model.
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
    /// Defines which accounts and resources are in scope.
    /// </summary>
    public partial class ScopeConfiguration
    {
        private AccountFilter _accountFilter;
        private Dictionary<string, ResourceScope> _resourceScopes = AWSConfigs.InitializeCollections ? new Dictionary<string, ResourceScope>() : null;

        /// <summary>
        /// Gets and sets the property AccountFilter. 
        /// <para>
        /// The account filter that determines which accounts are in scope. When set, exactly
        /// one of <c>includeAll</c>, <c>include</c>, or <c>exclude</c> is set.
        /// </para>
        ///  
        /// <para>
        /// Organization administrators must include an account filter in every scope configuration.
        /// Single-account administrators must omit it: a scope without an account filter applies
        /// only to the administrator's own account. The presence of an account filter is fixed
        /// when the scope is created: an update can't add an account filter to a scope that was
        /// created without one, or remove the account filter from a scope that was created with
        /// one.
        /// </para>
        /// </summary>
        public AccountFilter AccountFilter
        {
            get { return this._accountFilter; }
            set { this._accountFilter = value; }
        }

        // Check to see if AccountFilter property is set
        internal bool IsSetAccountFilter()
        {
            return this._accountFilter != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceScopes. 
        /// <para>
        /// The resource-level scoping configuration, keyed by resource type, that defines which
        /// resources within the selected accounts are in scope.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=20)]
        public Dictionary<string, ResourceScope> ResourceScopes
        {
            get { return this._resourceScopes; }
            set { this._resourceScopes = value; }
        }

        // Check to see if ResourceScopes property is set
        internal bool IsSetResourceScopes()
        {
            return this._resourceScopes != null && (this._resourceScopes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}