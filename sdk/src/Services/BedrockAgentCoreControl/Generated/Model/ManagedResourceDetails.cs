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
    /// Details of a resource created and managed by the gateway for private endpoint connectivity.
    /// </summary>
    public partial class ManagedResourceDetails
    {
        private string _domain;
        private string _resourceAssociationArn;
        private string _resourceGatewayArn;

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The domain associated with this managed resource.
        /// </para>
        /// </summary>
        public string Domain
        {
            get { return this._domain; }
            set { this._domain = value; }
        }

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this._domain != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceAssociationArn. 
        /// <para>
        /// The ARN of the service network resource association.
        /// </para>
        /// </summary>
        public string ResourceAssociationArn
        {
            get { return this._resourceAssociationArn; }
            set { this._resourceAssociationArn = value; }
        }

        // Check to see if ResourceAssociationArn property is set
        internal bool IsSetResourceAssociationArn()
        {
            return this._resourceAssociationArn != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceGatewayArn. 
        /// <para>
        /// The ARN of the VPC Lattice resource gateway created in your account.
        /// </para>
        /// </summary>
        public string ResourceGatewayArn
        {
            get { return this._resourceGatewayArn; }
            set { this._resourceGatewayArn = value; }
        }

        // Check to see if ResourceGatewayArn property is set
        internal bool IsSetResourceGatewayArn()
        {
            return this._resourceGatewayArn != null;
        }

    }
}