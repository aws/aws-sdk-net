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
 * Do not modify this file. This file is generated from the cloudhsmv2-2017-04-28.normal.json service model.
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
    /// Container for the parameters to the ModifyCluster operation.
    /// Modifies CloudHSM cluster.
    /// 
    ///  
    /// <para>
    ///  <b>Cross-account use:</b> No. You cannot perform this operation on an CloudHSM cluster
    /// in a different Amazon Web Services account.
    /// </para>
    /// </summary>
    public partial class ModifyClusterRequest : AmazonCloudHSMV2Request
    {
        private BackupRetentionPolicy _backupRetentionPolicy;
        private string _clusterId;
        private string _hsmType;

        /// <summary>
        /// Gets and sets the property BackupRetentionPolicy. 
        /// <para>
        /// A policy that defines how the service retains backups.
        /// </para>
        /// </summary>
        public BackupRetentionPolicy BackupRetentionPolicy
        {
            get { return this._backupRetentionPolicy; }
            set { this._backupRetentionPolicy = value; }
        }

        // Check to see if BackupRetentionPolicy property is set
        internal bool IsSetBackupRetentionPolicy()
        {
            return this._backupRetentionPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterId. 
        /// <para>
        /// The identifier (ID) of the cluster that you want to modify. To find the cluster ID,
        /// use <a>DescribeClusters</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ClusterId
        {
            get { return this._clusterId; }
            set { this._clusterId = value; }
        }

        // Check to see if ClusterId property is set
        internal bool IsSetClusterId()
        {
            return this._clusterId != null;
        }

        /// <summary>
        /// Gets and sets the property HsmType. 
        /// <para>
        /// The desired HSM type of the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Max=32)]
        public string HsmType
        {
            get { return this._hsmType; }
            set { this._hsmType = value; }
        }

        // Check to see if HsmType property is set
        internal bool IsSetHsmType()
        {
            return this._hsmType != null;
        }

    }
}