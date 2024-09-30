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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// This is the response object from the DescribeInstance operation.
    /// </summary>
    public partial class DescribeInstanceResponse : AmazonWebServiceResponse
    {
        private Instance _instance;
        private ReplicationConfiguration _replicationConfiguration;

        /// <summary>
        /// Gets and sets the property Instance. 
        /// <para>
        /// The name of the instance.
        /// </para>
        /// </summary>
        public Instance Instance
        {
            get { return this._instance; }
            set { this._instance = value; }
        }

        // Check to see if Instance property is set
        internal bool IsSetInstance()
        {
            return this._instance != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationConfiguration. 
        /// <para>
        /// Status information about the replication process. This field is included only when
        /// you are using the <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_ReplicateInstance.html">ReplicateInstance</a>
        /// API to replicate an Amazon Connect instance across Amazon Web Services Regions. For
        /// information about replicating Amazon Connect instances, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/create-replica-connect-instance.html">Create
        /// a replica of your existing Amazon Connect instance</a> in the <i>Amazon Connect Administrator
        /// Guide</i>.
        /// </para>
        /// </summary>
        public ReplicationConfiguration ReplicationConfiguration
        {
            get { return this._replicationConfiguration; }
            set { this._replicationConfiguration = value; }
        }

        // Check to see if ReplicationConfiguration property is set
        internal bool IsSetReplicationConfiguration()
        {
            return this._replicationConfiguration != null;
        }

    }
}