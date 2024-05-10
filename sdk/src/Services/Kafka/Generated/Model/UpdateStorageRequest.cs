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
 * Do not modify this file. This file is generated from the kafka-2018-11-14.normal.json service model.
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
    /// Container for the parameters to the UpdateStorage operation.
    /// Updates cluster broker volume size (or) sets cluster storage mode to TIERED.
    /// </summary>
    public partial class UpdateStorageRequest : AmazonKafkaRequest
    {
        private string _clusterArn;
        private string _currentVersion;
        private ProvisionedThroughput _provisionedThroughput;
        private StorageMode _storageMode;
        private int? _volumeSizeGB;

        /// <summary>
        /// Gets and sets the property ClusterArn.             
        /// <para>
        /// The Amazon Resource Name (ARN) of the cluster to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ClusterArn
        {
            get { return this._clusterArn; }
            set { this._clusterArn = value; }
        }

        // Check to see if ClusterArn property is set
        internal bool IsSetClusterArn()
        {
            return this._clusterArn != null;
        }

        /// <summary>
        /// Gets and sets the property CurrentVersion.             
        /// <para>
        /// The version of cluster to update from. A successful operation will then generate a
        /// new version.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CurrentVersion
        {
            get { return this._currentVersion; }
            set { this._currentVersion = value; }
        }

        // Check to see if CurrentVersion property is set
        internal bool IsSetCurrentVersion()
        {
            return this._currentVersion != null;
        }

        /// <summary>
        /// Gets and sets the property ProvisionedThroughput.             
        /// <para>
        /// EBS volume provisioned throughput information.
        /// </para>
        /// </summary>
        public ProvisionedThroughput ProvisionedThroughput
        {
            get { return this._provisionedThroughput; }
            set { this._provisionedThroughput = value; }
        }

        // Check to see if ProvisionedThroughput property is set
        internal bool IsSetProvisionedThroughput()
        {
            return this._provisionedThroughput != null;
        }

        /// <summary>
        /// Gets and sets the property StorageMode.             
        /// <para>
        /// Controls storage mode for supported storage tiers.
        /// </para>
        /// </summary>
        public StorageMode StorageMode
        {
            get { return this._storageMode; }
            set { this._storageMode = value; }
        }

        // Check to see if StorageMode property is set
        internal bool IsSetStorageMode()
        {
            return this._storageMode != null;
        }

        /// <summary>
        /// Gets and sets the property VolumeSizeGB.             
        /// <para>
        /// size of the EBS volume to update.
        /// </para>
        /// </summary>
        public int? VolumeSizeGB
        {
            get { return this._volumeSizeGB; }
            set { this._volumeSizeGB = value; }
        }

        // Check to see if VolumeSizeGB property is set
        internal bool IsSetVolumeSizeGB()
        {
            return this._volumeSizeGB.HasValue; 
        }

    }
}