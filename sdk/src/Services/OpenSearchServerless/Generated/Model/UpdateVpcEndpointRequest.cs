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
 * Do not modify this file. This file is generated from the opensearchserverless-2021-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpenSearchServerless.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateVpcEndpoint operation.
    /// Updates an OpenSearch Serverless-managed interface endpoint. For more information,
    /// see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-vpc.html">Access
    /// Amazon OpenSearch Serverless using an interface endpoint</a>.
    /// </summary>
    public partial class UpdateVpcEndpointRequest : AmazonOpenSearchServerlessRequest
    {
        private List<string> _addSecurityGroupIds = new List<string>();
        private List<string> _addSubnetIds = new List<string>();
        private string _clientToken;
        private string _id;
        private List<string> _removeSecurityGroupIds = new List<string>();
        private List<string> _removeSubnetIds = new List<string>();

        /// <summary>
        /// Gets and sets the property AddSecurityGroupIds. 
        /// <para>
        /// The unique identifiers of the security groups to add to the endpoint. Security groups
        /// define the ports, protocols, and sources for inbound traffic that you are authorizing
        /// into your endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public List<string> AddSecurityGroupIds
        {
            get { return this._addSecurityGroupIds; }
            set { this._addSecurityGroupIds = value; }
        }

        // Check to see if AddSecurityGroupIds property is set
        internal bool IsSetAddSecurityGroupIds()
        {
            return this._addSecurityGroupIds != null && this._addSecurityGroupIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AddSubnetIds. 
        /// <para>
        /// The ID of one or more subnets to add to the endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=6)]
        public List<string> AddSubnetIds
        {
            get { return this._addSubnetIds; }
            set { this._addSubnetIds = value; }
        }

        // Check to see if AddSubnetIds property is set
        internal bool IsSetAddSubnetIds()
        {
            return this._addSubnetIds != null && this._addSubnetIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier to ensure idempotency of the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the interface endpoint to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property RemoveSecurityGroupIds. 
        /// <para>
        /// The unique identifiers of the security groups to remove from the endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public List<string> RemoveSecurityGroupIds
        {
            get { return this._removeSecurityGroupIds; }
            set { this._removeSecurityGroupIds = value; }
        }

        // Check to see if RemoveSecurityGroupIds property is set
        internal bool IsSetRemoveSecurityGroupIds()
        {
            return this._removeSecurityGroupIds != null && this._removeSecurityGroupIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RemoveSubnetIds. 
        /// <para>
        /// The unique identifiers of the subnets to remove from the endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=6)]
        public List<string> RemoveSubnetIds
        {
            get { return this._removeSubnetIds; }
            set { this._removeSubnetIds = value; }
        }

        // Check to see if RemoveSubnetIds property is set
        internal bool IsSetRemoveSubnetIds()
        {
            return this._removeSubnetIds != null && this._removeSubnetIds.Count > 0; 
        }

    }
}