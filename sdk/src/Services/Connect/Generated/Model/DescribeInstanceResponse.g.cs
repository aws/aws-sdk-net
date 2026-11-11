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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property Instance. 
        /// <para>
        /// The name of the instance.
        /// </para>
        /// </summary>
        public Instance Instance { get; set; }

        /// <summary>
        /// Checks to see if the Instance property is set.
        /// </summary>
        internal bool IsSetInstance() => this.Instance != null;

        /// <summary>
        /// Gets and sets the property ReplicationConfiguration. 
        /// <para>
        /// Status information about the replication process. This field is included only when
        /// you are using the <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_ReplicateInstance.html">ReplicateInstance</a>
        /// API to replicate an Connect Customer instance across Amazon Web Services Regions.
        /// For information about replicating Connect Customer instances, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/create-replica-connect-instance.html">Create
        /// a replica of your existing Connect Customer instance</a> in the <i>Connect Customer
        /// Administrator Guide</i>.
        /// </para>
        /// </summary>
        public ReplicationConfiguration ReplicationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationConfiguration property is set.
        /// </summary>
        internal bool IsSetReplicationConfiguration() => this.ReplicationConfiguration != null;
    }
}
