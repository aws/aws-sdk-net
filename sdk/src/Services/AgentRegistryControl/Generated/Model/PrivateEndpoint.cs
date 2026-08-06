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
 * Do not modify this file. This file is generated from the agent-registry-control-2025-12-01.normal.json service model.
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
namespace Amazon.AgentRegistryControl.Model
{
    /// <summary>
    /// A private network endpoint used to reach a resource over a private path. Exactly one
    /// member is set.
    /// </summary>
    public partial class PrivateEndpoint
    {
        private ManagedVpcResource _managedVpcResource;
        private SelfManagedLatticeResource _selfManagedLatticeResource;

        /// <summary>
        /// Gets and sets the property ManagedVpcResource. 
        /// <para>
        /// A private endpoint backed by a service-managed VPC resource.
        /// </para>
        /// </summary>
        public ManagedVpcResource ManagedVpcResource
        {
            get { return this._managedVpcResource; }
            set { this._managedVpcResource = value; }
        }

        // Check to see if ManagedVpcResource property is set
        internal bool IsSetManagedVpcResource()
        {
            return this._managedVpcResource != null;
        }

        /// <summary>
        /// Gets and sets the property SelfManagedLatticeResource. 
        /// <para>
        /// A private endpoint backed by a self-managed VPC Lattice resource configuration.
        /// </para>
        /// </summary>
        public SelfManagedLatticeResource SelfManagedLatticeResource
        {
            get { return this._selfManagedLatticeResource; }
            set { this._selfManagedLatticeResource = value; }
        }

        // Check to see if SelfManagedLatticeResource property is set
        internal bool IsSetSelfManagedLatticeResource()
        {
            return this._selfManagedLatticeResource != null;
        }

    }
}