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

namespace Amazon.RedshiftServerless.Model
{
    /// <summary>
    /// Container for the parameters to the CreateSnapshotCopyConfiguration operation. Creates
    /// a snapshot copy configuration that lets you copy snapshots to another Amazon Web Services
    /// Region.
    /// </summary>
    public partial class CreateSnapshotCopyConfigurationRequest : AmazonRedshiftServerlessRequest
    {
        /// <summary>
        /// Gets and sets the property DestinationKmsKeyId. 
        /// <para>
        /// The KMS key to use to encrypt your snapshots in the destination Amazon Web Services
        /// Region.
        /// </para>
        /// </summary>
        public string DestinationKmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the DestinationKmsKeyId property is set.
        /// </summary>
        internal bool IsSetDestinationKmsKeyId() => this.DestinationKmsKeyId != null;

        /// <summary>
        /// Gets and sets the property DestinationRegion. 
        /// <para>
        /// The destination Amazon Web Services Region that you want to copy snapshots to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DestinationRegion { get; set; }

        /// <summary>
        /// Checks to see if the DestinationRegion property is set.
        /// </summary>
        internal bool IsSetDestinationRegion() => this.DestinationRegion != null;

        /// <summary>
        /// Gets and sets the property NamespaceName. 
        /// <para>
        /// The name of the namespace to copy snapshots from.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 64)]
        public string NamespaceName { get; set; }

        /// <summary>
        /// Checks to see if the NamespaceName property is set.
        /// </summary>
        internal bool IsSetNamespaceName() => this.NamespaceName != null;

        /// <summary>
        /// Gets and sets the property SnapshotRetentionPeriod. 
        /// <para>
        /// The retention period of the snapshots that you copy to the destination Amazon Web
        /// Services Region.
        /// </para>
        /// </summary>
        public int? SnapshotRetentionPeriod { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotRetentionPeriod property is set.
        /// </summary>
        internal bool IsSetSnapshotRetentionPeriod() => this.SnapshotRetentionPeriod.HasValue;
    }
}
