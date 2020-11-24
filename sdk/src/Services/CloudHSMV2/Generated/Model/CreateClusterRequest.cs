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

namespace Amazon.CloudHSMV2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateCluster operation.
    /// Creates a new AWS CloudHSM cluster.
    /// </summary>
    public partial class CreateClusterRequest : AmazonCloudHSMV2Request
    {
        private BackupRetentionPolicy _backupRetentionPolicy;
        private string _hsmType;
        private string _sourceBackupId;
        private List<string> _subnetIds = new List<string>();
        private List<Tag> _tagList = new List<Tag>();

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
        /// Gets and sets the property HsmType. 
        /// <para>
        /// The type of HSM to use in the cluster. Currently the only allowed value is <code>hsm1.medium</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

        /// <summary>
        /// Gets and sets the property SourceBackupId. 
        /// <para>
        /// The identifier (ID) of the cluster backup to restore. Use this value to restore the
        /// cluster from a backup instead of creating a new cluster. To find the backup ID, use
        /// <a>DescribeBackups</a>.
        /// </para>
        /// </summary>
        public string SourceBackupId
        {
            get { return this._sourceBackupId; }
            set { this._sourceBackupId = value; }
        }

        // Check to see if SourceBackupId property is set
        internal bool IsSetSourceBackupId()
        {
            return this._sourceBackupId != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// The identifiers (IDs) of the subnets where you are creating the cluster. You must
        /// specify at least one subnet. If you specify multiple subnets, they must meet the following
        /// criteria:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// All subnets must be in the same virtual private cloud (VPC).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can specify only one subnet per Availability Zone.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public List<string> SubnetIds
        {
            get { return this._subnetIds; }
            set { this._subnetIds = value; }
        }

        // Check to see if SubnetIds property is set
        internal bool IsSetSubnetIds()
        {
            return this._subnetIds != null && this._subnetIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TagList. 
        /// <para>
        /// Tags to apply to the CloudHSM cluster during creation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<Tag> TagList
        {
            get { return this._tagList; }
            set { this._tagList = value; }
        }

        // Check to see if TagList property is set
        internal bool IsSetTagList()
        {
            return this._tagList != null && this._tagList.Count > 0; 
        }

    }
}