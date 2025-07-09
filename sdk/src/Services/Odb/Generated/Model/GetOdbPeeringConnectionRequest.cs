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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
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
namespace Amazon.Odb.Model
{
    /// <summary>
    /// Container for the parameters to the GetOdbPeeringConnection operation.
    /// Retrieves information about an ODB peering connection.
    /// </summary>
    public partial class GetOdbPeeringConnectionRequest : AmazonOdbRequest
    {
        private string _odbPeeringConnectionId;

        /// <summary>
        /// Gets and sets the property OdbPeeringConnectionId. 
        /// <para>
        /// The unique identifier of the ODB peering connection to retrieve information about.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=6, Max=2048)]
        public string OdbPeeringConnectionId
        {
            get { return this._odbPeeringConnectionId; }
            set { this._odbPeeringConnectionId = value; }
        }

        // Check to see if OdbPeeringConnectionId property is set
        internal bool IsSetOdbPeeringConnectionId()
        {
            return this._odbPeeringConnectionId != null;
        }

    }
}