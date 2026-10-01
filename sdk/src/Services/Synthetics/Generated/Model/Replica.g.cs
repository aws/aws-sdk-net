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

namespace Amazon.Synthetics.Model
{
    /// <summary>
    /// A structure that contains information about a canary replica in a specific location.
    /// </summary>
    public partial class Replica
    {
        /// <summary>
        /// Gets and sets the property CanaryState. 
        /// <para>
        /// The current state of the canary in this replica location.
        /// </para>
        /// </summary>
        public CanaryState CanaryState { get; set; }

        /// <summary>
        /// Checks to see if the CanaryState property is set.
        /// </summary>
        internal bool IsSetCanaryState() => this.CanaryState != null;

        /// <summary>
        /// Gets and sets the property LastModified. 
        /// <para>
        /// The date and time that the replica was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModified { get; set; }

        /// <summary>
        /// Checks to see if the LastModified property is set.
        /// </summary>
        internal bool IsSetLastModified() => this.LastModified.HasValue;

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The Amazon Web Services Region where this replica is located.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public string Location { get; set; }

        /// <summary>
        /// Checks to see if the Location property is set.
        /// </summary>
        internal bool IsSetLocation() => this.Location != null;

        /// <summary>
        /// Gets and sets the property ReplicationStatus. 
        /// <para>
        /// A structure that contains information about the replication status of this replica.
        /// </para>
        /// </summary>
        public ReplicationStatus ReplicationStatus { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationStatus property is set.
        /// </summary>
        internal bool IsSetReplicationStatus() => this.ReplicationStatus != null;

        /// <summary>
        /// Gets and sets the property VpcConfig. 
        /// <para>
        /// The VPC configuration for the canary replica in this location.
        /// </para>
        /// </summary>
        public VpcConfigOutput VpcConfig { get; set; }

        /// <summary>
        /// Checks to see if the VpcConfig property is set.
        /// </summary>
        internal bool IsSetVpcConfig() => this.VpcConfig != null;
    }
}
