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
 * Do not modify this file. This file is generated from the directconnect-2012-10-25.normal.json service model.
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
namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateConnectionsToResiliencyGroup operation.
    /// Associates one or more connections with the specified resiliency group. This operation
    /// is atomic: either all of the specified connections are associated, or the operation
    /// fails and no changes are made.
    /// </summary>
    public partial class AssociateConnectionsToResiliencyGroupRequest : AmazonDirectConnectRequest
    {
        private string _clientToken;
        private List<string> _connectionIdentifiers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _resiliencyGroupId;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// Gets and sets the property ConnectionIdentifiers. 
        /// <para>
        /// The IDs or ARNs of the connections to associate with the resiliency group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public List<string> ConnectionIdentifiers
        {
            get { return this._connectionIdentifiers; }
            set { this._connectionIdentifiers = value; }
        }

        // Check to see if ConnectionIdentifiers property is set
        internal bool IsSetConnectionIdentifiers()
        {
            return this._connectionIdentifiers != null && (this._connectionIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResiliencyGroupId. 
        /// <para>
        /// The ID of the resiliency group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=22, Max=22)]
        public string ResiliencyGroupId
        {
            get { return this._resiliencyGroupId; }
            set { this._resiliencyGroupId = value; }
        }

        // Check to see if ResiliencyGroupId property is set
        internal bool IsSetResiliencyGroupId()
        {
            return this._resiliencyGroupId != null;
        }

    }
}