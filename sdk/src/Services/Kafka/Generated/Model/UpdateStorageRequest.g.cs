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

namespace Amazon.Kafka.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateStorage operation. Updates cluster broker
    /// volume size (or) sets cluster storage mode to TIERED.
    /// </summary>
    public partial class UpdateStorageRequest : AmazonKafkaRequest
    {
        /// <summary>
        /// Gets and sets the property ClusterArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the cluster to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ClusterArn { get; set; }

        /// <summary>
        /// Checks to see if the ClusterArn property is set.
        /// </summary>
        internal bool IsSetClusterArn() => this.ClusterArn != null;

        /// <summary>
        /// Gets and sets the property CurrentVersion. 
        /// <para>
        /// The version of cluster to update from. A successful operation will then generate a
        /// new version.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CurrentVersion { get; set; }

        /// <summary>
        /// Checks to see if the CurrentVersion property is set.
        /// </summary>
        internal bool IsSetCurrentVersion() => this.CurrentVersion != null;

        /// <summary>
        /// Gets and sets the property ProvisionedThroughput. 
        /// <para>
        /// EBS volume provisioned throughput information.
        /// </para>
        /// </summary>
        public ProvisionedThroughput ProvisionedThroughput { get; set; }

        /// <summary>
        /// Checks to see if the ProvisionedThroughput property is set.
        /// </summary>
        internal bool IsSetProvisionedThroughput() => this.ProvisionedThroughput != null;

        /// <summary>
        /// Gets and sets the property StorageMode. 
        /// <para>
        /// Controls storage mode for supported storage tiers.
        /// </para>
        /// </summary>
        public StorageMode StorageMode { get; set; }

        /// <summary>
        /// Checks to see if the StorageMode property is set.
        /// </summary>
        internal bool IsSetStorageMode() => this.StorageMode != null;

        /// <summary>
        /// Gets and sets the property VolumeSizeGB. 
        /// <para>
        /// size of the EBS volume to update.
        /// </para>
        /// </summary>
        public int? VolumeSizeGB { get; set; }

        /// <summary>
        /// Checks to see if the VolumeSizeGB property is set.
        /// </summary>
        internal bool IsSetVolumeSizeGB() => this.VolumeSizeGB.HasValue;
    }
}
