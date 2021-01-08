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

namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeConnectionsOnInterconnect operation.
    /// Deprecated. Use <a>DescribeHostedConnections</a> instead.
    /// 
    ///  
    /// <para>
    /// Lists the connections that have been provisioned on the specified interconnect.
    /// </para>
    ///  <note> 
    /// <para>
    /// Intended for use by AWS Direct Connect Partners only.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DescribeConnectionsOnInterconnectRequest : AmazonDirectConnectRequest
    {
        private string _interconnectId;

        /// <summary>
        /// Gets and sets the property InterconnectId. 
        /// <para>
        /// The ID of the interconnect.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string InterconnectId
        {
            get { return this._interconnectId; }
            set { this._interconnectId = value; }
        }

        // Check to see if InterconnectId property is set
        internal bool IsSetInterconnectId()
        {
            return this._interconnectId != null;
        }

    }
}