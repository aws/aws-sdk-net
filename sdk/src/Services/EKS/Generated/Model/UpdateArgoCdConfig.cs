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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
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
namespace Amazon.EKS.Model
{
    /// <summary>
    /// Configuration updates for an Argo CD capability. You only need to specify the fields
    /// you want to update.
    /// </summary>
    public partial class UpdateArgoCdConfig
    {
        private ArgoCdNetworkAccessConfigRequest _networkAccess;
        private UpdateRoleMappings _rbacRoleMappings;

        /// <summary>
        /// Gets and sets the property NetworkAccess. 
        /// <para>
        /// Updated network access configuration for the Argo CD capability's managed API server
        /// endpoint. You can add or remove VPC endpoint associations to control which VPCs have
        /// private access to the Argo CD server.
        /// </para>
        /// </summary>
        public ArgoCdNetworkAccessConfigRequest NetworkAccess
        {
            get { return this._networkAccess; }
            set { this._networkAccess = value; }
        }

        // Check to see if NetworkAccess property is set
        internal bool IsSetNetworkAccess()
        {
            return this._networkAccess != null;
        }

        /// <summary>
        /// Gets and sets the property RbacRoleMappings. 
        /// <para>
        /// Updated RBAC role mappings for the Argo CD capability. You can add, update, or remove
        /// role mappings.
        /// </para>
        /// </summary>
        public UpdateRoleMappings RbacRoleMappings
        {
            get { return this._rbacRoleMappings; }
            set { this._rbacRoleMappings = value; }
        }

        // Check to see if RbacRoleMappings property is set
        internal bool IsSetRbacRoleMappings()
        {
            return this._rbacRoleMappings != null;
        }

    }
}