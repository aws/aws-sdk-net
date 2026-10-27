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

namespace Amazon.CloudHSMV2.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyCluster operation. Modifies CloudHSM cluster.
    /// <para> <b>Cross-account use:</b> No. You cannot perform this operation on an CloudHSM
    /// cluster in a different Amazon Web Services account. </para>
    /// </summary>
    public partial class ModifyClusterRequest : AmazonCloudHSMV2Request
    {
        /// <summary>
        /// Gets and sets the property BackupRetentionPolicy. 
        /// <para>
        /// A policy that defines how the service retains backups.
        /// </para>
        /// </summary>
        public BackupRetentionPolicy BackupRetentionPolicy { get; set; }

        /// <summary>
        /// Checks to see if the BackupRetentionPolicy property is set.
        /// </summary>
        internal bool IsSetBackupRetentionPolicy() => this.BackupRetentionPolicy != null;

        /// <summary>
        /// Gets and sets the property ClusterId. 
        /// <para>
        /// The identifier (ID) of the cluster that you want to modify. To find the cluster ID,
        /// use <a>DescribeClusters</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ClusterId { get; set; }

        /// <summary>
        /// Checks to see if the ClusterId property is set.
        /// </summary>
        internal bool IsSetClusterId() => this.ClusterId != null;

        /// <summary>
        /// Gets and sets the property HsmType. 
        /// <para>
        /// The desired HSM type of the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 32)]
        public string HsmType { get; set; }

        /// <summary>
        /// Checks to see if the HsmType property is set.
        /// </summary>
        internal bool IsSetHsmType() => this.HsmType != null;
    }
}
