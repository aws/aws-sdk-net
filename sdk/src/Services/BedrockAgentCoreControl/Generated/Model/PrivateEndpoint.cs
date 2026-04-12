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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// The private endpoint configuration for a gateway target. Defines how the gateway connects
    /// to private resources in your VPC.
    /// </summary>
    public partial class PrivateEndpoint
    {
        private ManagedLatticeResource _managedLatticeResource;
        private SelfManagedLatticeResource _selfManagedLatticeResource;

        /// <summary>
        /// Gets and sets the property ManagedLatticeResource. 
        /// <para>
        /// Configuration for connecting to a private resource using a managed VPC Lattice resource.
        /// The gateway creates and manages the VPC Lattice resources on your behalf.
        /// </para>
        /// </summary>
        public ManagedLatticeResource ManagedLatticeResource
        {
            get { return this._managedLatticeResource; }
            set { this._managedLatticeResource = value; }
        }

        // Check to see if ManagedLatticeResource property is set
        internal bool IsSetManagedLatticeResource()
        {
            return this._managedLatticeResource != null;
        }

        /// <summary>
        /// Gets and sets the property SelfManagedLatticeResource. 
        /// <para>
        /// Configuration for connecting to a private resource using a self-managed VPC Lattice
        /// resource configuration.
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