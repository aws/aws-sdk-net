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

namespace Amazon.VPCLattice.Model
{
    /// <summary>
    /// Container for the parameters to the CreateServiceNetworkServiceAssociation operation.
    /// Associates a service with a service network.
    /// 
    ///  
    /// <para>
    /// You can't use this operation if the service and service network are already associated
    /// or if there is a disassociation or deletion in progress. If the association fails,
    /// you can retry the operation by deleting the association and recreating it.
    /// </para>
    ///  
    /// <para>
    /// You cannot associate a service and service network that are shared with a caller.
    /// The caller must own either the service or the service network.
    /// </para>
    ///  
    /// <para>
    /// As a result of this operation, the association is created in the service network account
    /// and the association owner account.
    /// </para>
    /// </summary>
    public partial class CreateServiceNetworkServiceAssociationRequest : AmazonVPCLatticeRequest
    {
        private string _clientToken;
        private string _serviceIdentifier;
        private string _serviceNetworkIdentifier;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. If you retry a request that completed successfully using the same client
        /// token and parameters, the retry succeeds without performing any actions. If the parameters
        /// aren't identical, the retry fails.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// Gets and sets the property ServiceIdentifier. 
        /// <para>
        /// The ID or Amazon Resource Name (ARN) of the service.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=17, Max=2048)]
        public string ServiceIdentifier
        {
            get { return this._serviceIdentifier; }
            set { this._serviceIdentifier = value; }
        }

        // Check to see if ServiceIdentifier property is set
        internal bool IsSetServiceIdentifier()
        {
            return this._serviceIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceNetworkIdentifier. 
        /// <para>
        /// The ID or Amazon Resource Name (ARN) of the service network. You must use the ARN
        /// if the resources specified in the operation are in different accounts.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=2048)]
        public string ServiceNetworkIdentifier
        {
            get { return this._serviceNetworkIdentifier; }
            set { this._serviceNetworkIdentifier = value; }
        }

        // Check to see if ServiceNetworkIdentifier property is set
        internal bool IsSetServiceNetworkIdentifier()
        {
            return this._serviceNetworkIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags for the association.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}