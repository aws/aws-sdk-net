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
    /// The object that you configure to copy snapshots from one namespace to a namespace
    /// in another Amazon Web Services Region.
    /// </summary>
    public partial class SnapshotCopyConfiguration
    {
        /// <summary>
        /// Gets and sets the property DestinationKmsKeyId. 
        /// <para>
        /// The ID of the KMS key to use to encrypt your snapshots in the destination Amazon Web
        /// Services Region.
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
        /// The destination Amazon Web Services Region to copy snapshots to.
        /// </para>
        /// </summary>
        public string DestinationRegion { get; set; }

        /// <summary>
        /// Checks to see if the DestinationRegion property is set.
        /// </summary>
        internal bool IsSetDestinationRegion() => this.DestinationRegion != null;

        /// <summary>
        /// Gets and sets the property NamespaceName. 
        /// <para>
        /// The name of the namespace to copy snapshots from in the source Amazon Web Services
        /// Region.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 64)]
        public string NamespaceName { get; set; }

        /// <summary>
        /// Checks to see if the NamespaceName property is set.
        /// </summary>
        internal bool IsSetNamespaceName() => this.NamespaceName != null;

        /// <summary>
        /// Gets and sets the property SnapshotCopyConfigurationArn. 
        /// <para>
        /// The ARN of the snapshot copy configuration object.
        /// </para>
        /// </summary>
        public string SnapshotCopyConfigurationArn { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotCopyConfigurationArn property is set.
        /// </summary>
        internal bool IsSetSnapshotCopyConfigurationArn() => this.SnapshotCopyConfigurationArn != null;

        /// <summary>
        /// Gets and sets the property SnapshotCopyConfigurationId. 
        /// <para>
        /// The ID of the snapshot copy configuration object.
        /// </para>
        /// </summary>
        public string SnapshotCopyConfigurationId { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotCopyConfigurationId property is set.
        /// </summary>
        internal bool IsSetSnapshotCopyConfigurationId() => this.SnapshotCopyConfigurationId != null;

        /// <summary>
        /// Gets and sets the property SnapshotRetentionPeriod. 
        /// <para>
        /// The retention period of snapshots that are copied to the destination Amazon Web Services
        /// Region.
        /// </para>
        /// </summary>
        public int? SnapshotRetentionPeriod { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotRetentionPeriod property is set.
        /// </summary>
        internal bool IsSetSnapshotRetentionPeriod() => this.SnapshotRetentionPeriod.HasValue;
    }
}
