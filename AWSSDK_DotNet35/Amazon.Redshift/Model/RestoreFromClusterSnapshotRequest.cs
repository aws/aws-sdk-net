/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Container for the parameters to the RestoreFromClusterSnapshot operation.
    /// <para> Creates a new cluster from a snapshot. Amazon Redshift creates the resulting cluster with the same configuration as the original
    /// cluster from which the snapshot was created, except that the new cluster is created with the default cluster security and parameter group.
    /// After Amazon Redshift creates the cluster you can use the ModifyCluster API to associate a different security group and different parameter
    /// group with the restored cluster. </para> <para> If a snapshot is taken of a cluster in VPC, you can restore it only in VPC. In this case,
    /// you must provide a cluster subnet group where you want the cluster restored. If snapshot is taken of a cluster outside VPC, then you can
    /// restore it only outside VPC.</para> <para> For more information about working with snapshots, go to <a
    /// href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-snapshots.html" >Amazon Redshift Snapshots</a> in the <i>Amazon Redshift
    /// Management Guide</i> .
    /// </para>
    /// </summary>
    public partial class RestoreFromClusterSnapshotRequest : AmazonRedshiftRequest
    {
        private string clusterIdentifier;
        private string snapshotIdentifier;
        private string snapshotClusterIdentifier;
        private int? port;
        private string availabilityZone;
        private bool? allowVersionUpgrade;
        private string clusterSubnetGroupName;
        private bool? publiclyAccessible;
        private string ownerAccount;
        private string hsmClientCertificateIdentifier;
        private string hsmConfigurationIdentifier;
        private string elasticIp;


        /// <summary>
        /// The identifier of the cluster that will be created from restoring the snapshot. Constraints: <ul> <li>Must contain from 1 to 63 alphanumeric
        /// characters or hyphens.</li> <li>Alphabetic characters must be lowercase.</li> <li>First character must be a letter.</li> <li>Cannot end with
        /// a hyphen or contain two consecutive hyphens.</li> <li>Must be unique for all clusters within an AWS account.</li> </ul>
        ///  
        /// </summary>
        public string ClusterIdentifier
        {
            get { return this.clusterIdentifier; }
            set { this.clusterIdentifier = value; }
        }

        // Check to see if ClusterIdentifier property is set
        internal bool IsSetClusterIdentifier()
        {
            return this.clusterIdentifier != null;
        }

        /// <summary>
        /// The name of the snapshot from which to create the new cluster. This parameter isn't case sensitive. Example: <c>my-snapshot-id</c>
        ///  
        /// </summary>
        public string SnapshotIdentifier
        {
            get { return this.snapshotIdentifier; }
            set { this.snapshotIdentifier = value; }
        }

        // Check to see if SnapshotIdentifier property is set
        internal bool IsSetSnapshotIdentifier()
        {
            return this.snapshotIdentifier != null;
        }

        /// <summary>
        /// The name of the cluster the source snapshot was created from. This parameter is required if your IAM user has a policy containing a snapshot
        /// resource element that specifies anything other than * for the cluster name.
        ///  
        /// </summary>
        public string SnapshotClusterIdentifier
        {
            get { return this.snapshotClusterIdentifier; }
            set { this.snapshotClusterIdentifier = value; }
        }

        // Check to see if SnapshotClusterIdentifier property is set
        internal bool IsSetSnapshotClusterIdentifier()
        {
            return this.snapshotClusterIdentifier != null;
        }

        /// <summary>
        /// The port number on which the cluster accepts connections. Default: The same port as the original cluster. Constraints: Must be between
        /// <c>1115</c> and <c>65535</c>.
        ///  
        /// </summary>
        public int Port
        {
            get { return this.port ?? default(int); }
            set { this.port = value; }
        }

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this.port.HasValue;
        }

        /// <summary>
        /// The Amazon EC2 Availability Zone in which to restore the cluster. Default: A random, system-chosen Availability Zone. Example:
        /// <c>us-east-1a</c>
        ///  
        /// </summary>
        public string AvailabilityZone
        {
            get { return this.availabilityZone; }
            set { this.availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this.availabilityZone != null;
        }

        /// <summary>
        /// If <c>true</c>, upgrades can be applied during the maintenance window to the Amazon Redshift engine that is running on the cluster. Default:
        /// <c>true</c>
        ///  
        /// </summary>
        public bool AllowVersionUpgrade
        {
            get { return this.allowVersionUpgrade ?? default(bool); }
            set { this.allowVersionUpgrade = value; }
        }

        // Check to see if AllowVersionUpgrade property is set
        internal bool IsSetAllowVersionUpgrade()
        {
            return this.allowVersionUpgrade.HasValue;
        }

        /// <summary>
        /// The name of the subnet group where you want to cluster restored. A snapshot of cluster in VPC can be restored only in VPC. Therefore, you
        /// must provide subnet group name where you want the cluster restored.
        ///  
        /// </summary>
        public string ClusterSubnetGroupName
        {
            get { return this.clusterSubnetGroupName; }
            set { this.clusterSubnetGroupName = value; }
        }

        // Check to see if ClusterSubnetGroupName property is set
        internal bool IsSetClusterSubnetGroupName()
        {
            return this.clusterSubnetGroupName != null;
        }

        /// <summary>
        /// If <c>true</c>, the cluster can be accessed from a public network.
        ///  
        /// </summary>
        public bool PubliclyAccessible
        {
            get { return this.publiclyAccessible ?? default(bool); }
            set { this.publiclyAccessible = value; }
        }

        // Check to see if PubliclyAccessible property is set
        internal bool IsSetPubliclyAccessible()
        {
            return this.publiclyAccessible.HasValue;
        }

        /// <summary>
        /// The AWS customer account used to create or copy the snapshot. Required if you are restoring a snapshot you do not own, optional if you own
        /// the snapshot.
        ///  
        /// </summary>
        public string OwnerAccount
        {
            get { return this.ownerAccount; }
            set { this.ownerAccount = value; }
        }

        // Check to see if OwnerAccount property is set
        internal bool IsSetOwnerAccount()
        {
            return this.ownerAccount != null;
        }

        /// <summary>
        /// Specifies the name of the HSM client certificate the Amazon Redshift cluster uses to retrieve the data encryption keys stored in an HSM.
        ///  
        /// </summary>
        public string HsmClientCertificateIdentifier
        {
            get { return this.hsmClientCertificateIdentifier; }
            set { this.hsmClientCertificateIdentifier = value; }
        }

        // Check to see if HsmClientCertificateIdentifier property is set
        internal bool IsSetHsmClientCertificateIdentifier()
        {
            return this.hsmClientCertificateIdentifier != null;
        }

        /// <summary>
        /// Specifies the name of the HSM configuration that contains the information the Amazon Redshift cluster can use to retrieve and store keys in
        /// an HSM.
        ///  
        /// </summary>
        public string HsmConfigurationIdentifier
        {
            get { return this.hsmConfigurationIdentifier; }
            set { this.hsmConfigurationIdentifier = value; }
        }

        // Check to see if HsmConfigurationIdentifier property is set
        internal bool IsSetHsmConfigurationIdentifier()
        {
            return this.hsmConfigurationIdentifier != null;
        }

        /// <summary>
        /// The elastic IP (EIP) address for the cluster.
        ///  
        /// </summary>
        public string ElasticIp
        {
            get { return this.elasticIp; }
            set { this.elasticIp = value; }
        }

        // Check to see if ElasticIp property is set
        internal bool IsSetElasticIp()
        {
            return this.elasticIp != null;
        }

    }
}
    
