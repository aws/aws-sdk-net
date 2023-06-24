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
 * Do not modify this file. This file is generated from the docdb-elastic-2022-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DocDBElastic.Model
{
    /// <summary>
    /// Container for the parameters to the RestoreClusterFromSnapshot operation.
    /// Restores a Elastic DocumentDB cluster from a snapshot.
    /// </summary>
    public partial class RestoreClusterFromSnapshotRequest : AmazonDocDBElasticRequest
    {
        private string _clusterName;
        private string _kmsKeyId;
        private string _snapshotArn;
        private List<string> _subnetIds = new List<string>();
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private List<string> _vpcSecurityGroupIds = new List<string>();

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of the Elastic DocumentDB cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ClusterName
        {
            get { return this._clusterName; }
            set { this._clusterName = value; }
        }

        // Check to see if ClusterName property is set
        internal bool IsSetClusterName()
        {
            return this._clusterName != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The KMS key identifier to use to encrypt the new Elastic DocumentDB cluster.
        /// </para>
        ///  
        /// <para>
        /// The KMS key identifier is the Amazon Resource Name (ARN) for the KMS encryption key.
        /// If you are creating a cluster using the same Amazon account that owns this KMS encryption
        /// key, you can use the KMS key alias instead of the ARN as the KMS encryption key.
        /// </para>
        ///  
        /// <para>
        /// If an encryption key is not specified here, Elastic DocumentDB uses the default encryption
        /// key that KMS creates for your account. Your account has a different default encryption
        /// key for each Amazon Region.
        /// </para>
        /// </summary>
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotArn. 
        /// <para>
        /// The arn of the Elastic DocumentDB snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SnapshotArn
        {
            get { return this._snapshotArn; }
            set { this._snapshotArn = value; }
        }

        // Check to see if SnapshotArn property is set
        internal bool IsSetSnapshotArn()
        {
            return this._snapshotArn != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// The Amazon EC2 subnet IDs for the Elastic DocumentDB cluster.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of the tag names to be assigned to the restored DB cluster, in the form of
        /// an array of key-value pairs in which the key is the tag name and the value is the
        /// key value.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VpcSecurityGroupIds. 
        /// <para>
        /// A list of EC2 VPC security groups to associate with the Elastic DocumentDB cluster.
        /// </para>
        /// </summary>
        public List<string> VpcSecurityGroupIds
        {
            get { return this._vpcSecurityGroupIds; }
            set { this._vpcSecurityGroupIds = value; }
        }

        // Check to see if VpcSecurityGroupIds property is set
        internal bool IsSetVpcSecurityGroupIds()
        {
            return this._vpcSecurityGroupIds != null && this._vpcSecurityGroupIds.Count > 0; 
        }

    }
}