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
    /// Container for the parameters to the FailoverAutonomousDatabase operation.
    /// Initiates a failover of the specified Autonomous Database to a standby peer database.
    /// </summary>
    public partial class FailoverAutonomousDatabaseRequest : AmazonOdbRequest
    {
        private string _autonomousDatabaseId;
        private string _peerDbArn;

        /// <summary>
        /// Gets and sets the property AutonomousDatabaseId. 
        /// <para>
        /// The unique identifier of the Autonomous Database to fail over.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=6, Max=2048)]
        public string AutonomousDatabaseId
        {
            get { return this._autonomousDatabaseId; }
            set { this._autonomousDatabaseId = value; }
        }

        // Check to see if AutonomousDatabaseId property is set
        internal bool IsSetAutonomousDatabaseId()
        {
            return this._autonomousDatabaseId != null;
        }

        /// <summary>
        /// Gets and sets the property PeerDbArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the peer Autonomous Database to fail over to.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string PeerDbArn
        {
            get { return this._peerDbArn; }
            set { this._peerDbArn = value; }
        }

        // Check to see if PeerDbArn property is set
        internal bool IsSetPeerDbArn()
        {
            return this._peerDbArn != null;
        }

    }
}