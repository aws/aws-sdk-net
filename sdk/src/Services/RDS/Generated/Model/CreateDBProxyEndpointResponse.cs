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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
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
namespace Amazon.RDS.Model
{
    /// <summary>
    /// This is the response object from the CreateDBProxyEndpoint operation.
    /// </summary>
    public partial class CreateDBProxyEndpointResponse : AmazonWebServiceResponse
    {
        private DBProxyEndpoint _dbProxyEndpoint;

        /// <summary>
        /// Gets and sets the property DBProxyEndpoint. 
        /// <para>
        /// The <c>DBProxyEndpoint</c> object that is created by the API operation. The DB proxy
        /// endpoint that you create might provide capabilities such as read/write or read-only
        /// operations, or using a different VPC than the proxy's default VPC.
        /// </para>
        /// </summary>
        public DBProxyEndpoint DBProxyEndpoint
        {
            get { return this._dbProxyEndpoint; }
            set { this._dbProxyEndpoint = value; }
        }

        // Check to see if DBProxyEndpoint property is set
        internal bool IsSetDBProxyEndpoint()
        {
            return this._dbProxyEndpoint != null;
        }

    }
}