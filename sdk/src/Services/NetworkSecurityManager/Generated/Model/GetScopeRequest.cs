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
    /// Container for the parameters to the GetScope operation.
    /// Retrieves the details of the specified scope.
    /// </summary>
    public partial class GetScopeRequest : AmazonNetworkSecurityManagerRequest
    {
        private string _scopeIdentifier;

        /// <summary>
        /// Gets and sets the property ScopeIdentifier. 
        /// <para>
        /// The identifier of the scope. This is the scope's Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1010)]
        public string ScopeIdentifier
        {
            get { return this._scopeIdentifier; }
            set { this._scopeIdentifier = value; }
        }

        // Check to see if ScopeIdentifier property is set
        internal bool IsSetScopeIdentifier()
        {
            return this._scopeIdentifier != null;
        }

    }
}