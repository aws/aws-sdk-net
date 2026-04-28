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
    /// Configuration for a self-managed VPC Lattice resource. You create and manage the VPC
    /// Lattice resource gateway and resource configuration, then provide the resource configuration
    /// identifier.
    /// </summary>
    public partial class SelfManagedLatticeResource
    {
        private string _resourceConfigurationIdentifier;

        /// <summary>
        /// Gets and sets the property ResourceConfigurationIdentifier. 
        /// <para>
        /// The ARN or ID of the VPC Lattice resource configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string ResourceConfigurationIdentifier
        {
            get { return this._resourceConfigurationIdentifier; }
            set { this._resourceConfigurationIdentifier = value; }
        }

        // Check to see if ResourceConfigurationIdentifier property is set
        internal bool IsSetResourceConfigurationIdentifier()
        {
            return this._resourceConfigurationIdentifier != null;
        }

    }
}