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
 * Do not modify this file. This file is generated from the apigatewaymanagementapi-2018-11-29.normal.json service model.
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
namespace Amazon.ApiGatewayManagementApi.Model
{
    /// <summary>
    /// This is the response object from the GetConnection operation.
    /// </summary>
    public partial class GetConnectionResponse : AmazonWebServiceResponse
    {
        private DateTime? _connectedAt;
        private Identity _identity;
        private DateTime? _lastActiveAt;

        /// <summary>
        /// Gets and sets the property ConnectedAt. 
        /// <para>
        /// The time in ISO 8601 format for when the connection was established.
        /// </para>
        /// </summary>
        public DateTime? ConnectedAt
        {
            get { return this._connectedAt; }
            set { this._connectedAt = value; }
        }

        // Check to see if ConnectedAt property is set
        internal bool IsSetConnectedAt()
        {
            return this._connectedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Identity.
        /// </summary>
        public Identity Identity
        {
            get { return this._identity; }
            set { this._identity = value; }
        }

        // Check to see if Identity property is set
        internal bool IsSetIdentity()
        {
            return this._identity != null;
        }

        /// <summary>
        /// Gets and sets the property LastActiveAt. 
        /// <para>
        /// The time in ISO 8601 format for when the connection was last active.
        /// </para>
        /// </summary>
        public DateTime? LastActiveAt
        {
            get { return this._lastActiveAt; }
            set { this._lastActiveAt = value; }
        }

        // Check to see if LastActiveAt property is set
        internal bool IsSetLastActiveAt()
        {
            return this._lastActiveAt.HasValue; 
        }

    }
}