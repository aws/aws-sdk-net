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
 * Do not modify this file. This file is generated from the vpc-lattice-2022-11-30.normal.json service model.
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
namespace Amazon.VPCLattice.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateResourceGateway operation.
    /// Updates the specified resource gateway.
    /// </summary>
    public partial class UpdateResourceGatewayRequest : AmazonVPCLatticeRequest
    {
        private string _resourceGatewayIdentifier;
        private List<string> _securityGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ResourceGatewayIdentifier. 
        /// <para>
        /// The ID or ARN of the resource gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=17, Max=2048)]
        public string ResourceGatewayIdentifier
        {
            get { return this._resourceGatewayIdentifier; }
            set { this._resourceGatewayIdentifier = value; }
        }

        // Check to see if ResourceGatewayIdentifier property is set
        internal bool IsSetResourceGatewayIdentifier()
        {
            return this._resourceGatewayIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// The IDs of the security groups associated with the resource gateway.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<string> SecurityGroupIds
        {
            get { return this._securityGroupIds; }
            set { this._securityGroupIds = value; }
        }

        // Check to see if SecurityGroupIds property is set
        internal bool IsSetSecurityGroupIds()
        {
            return this._securityGroupIds != null && (this._securityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}