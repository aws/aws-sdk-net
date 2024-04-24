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
 * Do not modify this file. This file is generated from the outposts-2019-12-03.normal.json service model.
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
namespace Amazon.Outposts.Model
{
    /// <summary>
    /// This is the response object from the GetConnection operation.
    /// </summary>
    public partial class GetConnectionResponse : AmazonWebServiceResponse
    {
        private ConnectionDetails _connectionDetails;
        private string _connectionId;

        /// <summary>
        /// Gets and sets the property ConnectionDetails. 
        /// <para>
        ///  Information about the connection. 
        /// </para>
        /// </summary>
        public ConnectionDetails ConnectionDetails
        {
            get { return this._connectionDetails; }
            set { this._connectionDetails = value; }
        }

        // Check to see if ConnectionDetails property is set
        internal bool IsSetConnectionDetails()
        {
            return this._connectionDetails != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectionId. 
        /// <para>
        ///  The ID of the connection. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string ConnectionId
        {
            get { return this._connectionId; }
            set { this._connectionId = value; }
        }

        // Check to see if ConnectionId property is set
        internal bool IsSetConnectionId()
        {
            return this._connectionId != null;
        }

    }
}