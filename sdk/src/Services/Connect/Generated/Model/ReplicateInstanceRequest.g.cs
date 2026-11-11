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
    /// Container for the parameters to the ReplicateInstance operation. Replicates an Connect
    /// Customer instance in the specified Amazon Web Services Region and copies configuration
    /// information for Connect Customer resources across Amazon Web Services Regions. <para>
    /// For more information about replicating an Connect Customer instance, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/create-replica-connect-instance.html">Create
    /// a replica of your existing Connect Customer instance</a> in the <i>Connect Customer
    /// Administrator Guide</i>. </para>
    /// </summary>
    public partial class ReplicateInstanceRequest : AmazonConnectRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. If not provided, the Amazon Web Services SDK populates this field. For
        /// more information about idempotency, see <a href="https://aws.amazon.com/builders-library/making-retries-safe-with-idempotent-APIs/">Making
        /// retries safe with idempotent APIs</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 500)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Connect Customer instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance. You can provide
        /// the <c>InstanceId</c>, or the entire ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 250)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property ReplicaAlias. 
        /// <para>
        /// The alias for the replicated instance. The <c>ReplicaAlias</c> must be unique.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 45)]
        public string ReplicaAlias { get; set; }

        /// <summary>
        /// Checks to see if the ReplicaAlias property is set.
        /// </summary>
        internal bool IsSetReplicaAlias() => this.ReplicaAlias != null;

        /// <summary>
        /// Gets and sets the property ReplicaRegion. 
        /// <para>
        /// The Amazon Web Services Region where to replicate the Connect Customer instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 8, Max = 31)]
        public string ReplicaRegion { get; set; }

        /// <summary>
        /// Checks to see if the ReplicaRegion property is set.
        /// </summary>
        internal bool IsSetReplicaRegion() => this.ReplicaRegion != null;
    }
}
