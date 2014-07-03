/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Creates a new cluster from a snapshot. Amazon Redshift creates the resulting
    /// cluster         with the same configuration as the original cluster from which the
    /// snapshot was created,         except that the new cluster        is created with the
    /// default cluster security and parameter group.                 After Amazon Redshift
    /// creates the cluster you can use the <a>ModifyCluster</a>             API to associate
    /// a different security group and different parameter group with the            restored
    /// cluster.        
    /// 
    ///         
    /// <para>
    ///  If you restore a cluster into a VPC, you must provide a cluster subnet group where
    /// you want the cluster             restored.        
    /// </para>
    ///         
    /// <para>
    /// For more information about working with snapshots, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-snapshots.html">Amazon
    /// Redshift Snapshots</a> in the <i>Amazon Redshift Management Guide</i>.
    /// </para>
    /// </summary>
    public partial class RestoreFromClusterSnapshotRequest : AmazonRedshiftRequest
    {
        private bool? _allowVersionUpgrade;
        private int? _automatedSnapshotRetentionPeriod;
        private string _availabilityZone;
        private string _clusterIdentifier;
        private string _clusterParameterGroupName;
        private List<string> _clusterSecurityGroups = new List<string>();
        private string _clusterSubnetGroupName;
        private string _elasticIp;
        private string _hsmClientCertificateIdentifier;
        private string _hsmConfigurationIdentifier;
        private string _ownerAccount;
        private int? _port;
        private string _preferredMaintenanceWindow;
        private bool? _publiclyAccessible;
        private string _snapshotClusterIdentifier;
        private string _snapshotIdentifier;
        private List<string> _vpcSecurityGroupIds = new List<string>();


        /// <summary>
        /// Gets and sets the property AllowVersionUpgrade. 
        /// <para>
        ///         If <code>true</code>, upgrades can be applied during the maintenance window
        /// to the         Amazon Redshift engine that is running on the cluster.    
        /// </para>
        ///        
        /// <para>
        /// Default: <code>true</code>
        /// </para>
        /// </summary>
        public bool AllowVersionUpgrade
        {
            get { return this._allowVersionUpgrade.GetValueOrDefault(); }
            set { this._allowVersionUpgrade = value; }
        }

        // Check to see if AllowVersionUpgrade property is set
        internal bool IsSetAllowVersionUpgrade()
        {
            return this._allowVersionUpgrade.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property AutomatedSnapshotRetentionPeriod. 
        /// <para>
        ///             The number of days that automated snapshots are retained.            If
        /// the value is 0, automated snapshots are disabled. Even if            automated snapshots
        /// are disabled, you can still create            manual snapshots when you want with
        /// <a>CreateClusterSnapshot</a>.        
        /// </para>
        ///         
        /// <para>
        ///             Default: The value selected for the cluster from which the snapshot was
        /// taken.        
        /// </para>
        ///         
        /// <para>
        /// Constraints: Must be a value from 0 to 35.
        /// </para>
        /// </summary>
        public int AutomatedSnapshotRetentionPeriod
        {
            get { return this._automatedSnapshotRetentionPeriod.GetValueOrDefault(); }
            set { this._automatedSnapshotRetentionPeriod = value; }
        }

        // Check to see if AutomatedSnapshotRetentionPeriod property is set
        internal bool IsSetAutomatedSnapshotRetentionPeriod()
        {
            return this._automatedSnapshotRetentionPeriod.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        ///         The Amazon EC2 Availability Zone in which to restore the cluster.        
        /// </para>
        ///         
        /// <para>
        /// Default: A random, system-chosen Availability Zone.
        /// </para>
        ///         
        /// <para>
        /// Example: <code>us-east-1a</code>
        /// </para>
        /// </summary>
        public string AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }


        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        ///         The identifier of the cluster that will be created from restoring the snapshot.
        ///        
        /// </para>
        ///         
        /// <para>
        ///             
        /// <para>
        /// Constraints:
        /// </para>
        /// <ul><li>Must contain from 1 to 63 alphanumeric characters or hyphens.</li><li>Alphabetic
        /// characters must be lowercase.</li><li>First character must be a letter.</li><li>Cannot
        /// end with a hyphen or contain two consecutive hyphens.</li><li>Must be unique for all
        /// clusters within an AWS account.</li></ul>        
        /// </para>
        /// </summary>
        public string ClusterIdentifier
        {
            get { return this._clusterIdentifier; }
            set { this._clusterIdentifier = value; }
        }

        // Check to see if ClusterIdentifier property is set
        internal bool IsSetClusterIdentifier()
        {
            return this._clusterIdentifier != null;
        }


        /// <summary>
        /// Gets and sets the property ClusterParameterGroupName. 
        /// <para>
        ///             The name of the parameter group to be associated            with this
        /// cluster.         
        /// </para>
        ///         
        /// <para>
        /// Default: The default Amazon Redshift             cluster parameter group. For information
        /// about the default parameter group,            go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html">Working
        /// with Amazon Redshift Parameter Groups</a>.
        /// </para>
        ///         
        /// <para>
        ///             Constraints:        
        /// </para>
        ///         <ul>            <li>Must be 1 to 255 alphanumeric characters or hyphens.</li>
        ///            <li>First character must be a letter.</li>            <li>Cannot end with
        /// a hyphen or contain two consecutive hyphens.</li>        </ul>
        /// </summary>
        public string ClusterParameterGroupName
        {
            get { return this._clusterParameterGroupName; }
            set { this._clusterParameterGroupName = value; }
        }

        // Check to see if ClusterParameterGroupName property is set
        internal bool IsSetClusterParameterGroupName()
        {
            return this._clusterParameterGroupName != null;
        }


        /// <summary>
        /// Gets and sets the property ClusterSecurityGroups. 
        /// <para>
        ///             A list of security groups to be associated            with this cluster.
        ///        
        /// </para>
        ///         
        /// <para>
        ///             Default: The default cluster security group for Amazon Redshift.     
        ///    
        /// </para>
        ///         
        /// <para>
        /// Cluster security groups only apply to clusters outside of VPCs.
        /// </para>
        /// </summary>
        public List<string> ClusterSecurityGroups
        {
            get { return this._clusterSecurityGroups; }
            set { this._clusterSecurityGroups = value; }
        }

        // Check to see if ClusterSecurityGroups property is set
        internal bool IsSetClusterSecurityGroups()
        {
            return this._clusterSecurityGroups != null && this._clusterSecurityGroups.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property ClusterSubnetGroupName. 
        /// <para>
        ///             The name of the subnet group where you want to cluster restored.     
        ///    
        /// </para>
        ///         
        /// <para>
        ///             A snapshot of cluster in VPC can be restored only in VPC. Therefore, 
        ///            you must provide subnet group name where you want the cluster restored.
        ///        
        /// </para>
        /// </summary>
        public string ClusterSubnetGroupName
        {
            get { return this._clusterSubnetGroupName; }
            set { this._clusterSubnetGroupName = value; }
        }

        // Check to see if ClusterSubnetGroupName property is set
        internal bool IsSetClusterSubnetGroupName()
        {
            return this._clusterSubnetGroupName != null;
        }


        /// <summary>
        /// Gets and sets the property ElasticIp. 
        /// <para>
        /// The elastic IP (EIP) address for the cluster.
        /// </para>
        /// </summary>
        public string ElasticIp
        {
            get { return this._elasticIp; }
            set { this._elasticIp = value; }
        }

        // Check to see if ElasticIp property is set
        internal bool IsSetElasticIp()
        {
            return this._elasticIp != null;
        }


        /// <summary>
        /// Gets and sets the property HsmClientCertificateIdentifier. 
        /// <para>
        /// Specifies the name of the HSM client certificate the Amazon Redshift cluster uses
        /// to retrieve the data            encryption keys stored in an HSM.
        /// </para>
        /// </summary>
        public string HsmClientCertificateIdentifier
        {
            get { return this._hsmClientCertificateIdentifier; }
            set { this._hsmClientCertificateIdentifier = value; }
        }

        // Check to see if HsmClientCertificateIdentifier property is set
        internal bool IsSetHsmClientCertificateIdentifier()
        {
            return this._hsmClientCertificateIdentifier != null;
        }


        /// <summary>
        /// Gets and sets the property HsmConfigurationIdentifier. 
        /// <para>
        /// Specifies the name of the HSM configuration that contains the information the Amazon
        /// Redshift cluster            can use to retrieve and store keys in an HSM.
        /// </para>
        /// </summary>
        public string HsmConfigurationIdentifier
        {
            get { return this._hsmConfigurationIdentifier; }
            set { this._hsmConfigurationIdentifier = value; }
        }

        // Check to see if HsmConfigurationIdentifier property is set
        internal bool IsSetHsmConfigurationIdentifier()
        {
            return this._hsmConfigurationIdentifier != null;
        }


        /// <summary>
        /// Gets and sets the property OwnerAccount. 
        /// <para>
        ///             The AWS customer account used to create or copy the snapshot. Required
        /// if you are restoring a snapshot you do not own, optional if you own the snapshot.
        ///         
        /// </para>
        /// </summary>
        public string OwnerAccount
        {
            get { return this._ownerAccount; }
            set { this._ownerAccount = value; }
        }

        // Check to see if OwnerAccount property is set
        internal bool IsSetOwnerAccount()
        {
            return this._ownerAccount != null;
        }


        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        ///         The port number on which the cluster accepts connections.        
        /// </para>
        ///         
        /// <para>
        /// Default: The same port as the original cluster.
        /// </para>
        ///         
        /// <para>
        /// Constraints: Must be between <code>1115</code> and <code>65535</code>.
        /// </para>
        /// </summary>
        public int Port
        {
            get { return this._port.GetValueOrDefault(); }
            set { this._port = value; }
        }

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this._port.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property PreferredMaintenanceWindow. 
        /// <para>
        ///             The weekly time range (in UTC) during which automated cluster maintenance
        /// can occur.        
        /// </para>
        ///         
        /// <para>
        ///             Format: <code>ddd:hh24:mi-ddd:hh24:mi</code>        
        /// </para>
        ///         
        /// <para>
        ///             Default: The value selected for the cluster from which the snapshot was
        /// taken.             The following list shows the time blocks for each region      
        ///       from which the default maintenance windows are assigned.        
        /// </para>
        ///         <ul>            <li><b>US-East (Northern Virginia) Region:</b> 03:00-11:00
        /// UTC</li>            <li><b>US-West (Oregon) Region</b> 06:00-14:00 UTC</li>      
        ///      <li><b>EU (Ireland) Region</b> 22:00-06:00 UTC</li>            <li><b>Asia Pacific
        /// (Singapore) Region</b> 14:00-22:00 UTC</li>            <li><b>Asia Pacific (Sydney)
        /// Region</b> 12:00-20:00 UTC</li>            <li><b>Asia Pacific (Tokyo) Region</b>
        /// 17:00-03:00 UTC</li>        </ul>        
        /// <para>
        /// Valid Days: Mon | Tue | Wed | Thu | Fri | Sat | Sun
        /// </para>
        ///         
        /// <para>
        /// Constraints: Minimum 30-minute window.
        /// </para>
        /// </summary>
        public string PreferredMaintenanceWindow
        {
            get { return this._preferredMaintenanceWindow; }
            set { this._preferredMaintenanceWindow = value; }
        }

        // Check to see if PreferredMaintenanceWindow property is set
        internal bool IsSetPreferredMaintenanceWindow()
        {
            return this._preferredMaintenanceWindow != null;
        }


        /// <summary>
        /// Gets and sets the property PubliclyAccessible. 
        /// <para>
        ///             If <code>true</code>, the cluster can be accessed from a public network.
        ///        
        /// </para>
        /// </summary>
        public bool PubliclyAccessible
        {
            get { return this._publiclyAccessible.GetValueOrDefault(); }
            set { this._publiclyAccessible = value; }
        }

        // Check to see if PubliclyAccessible property is set
        internal bool IsSetPubliclyAccessible()
        {
            return this._publiclyAccessible.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property SnapshotClusterIdentifier. 
        /// <para>
        ///             The name of the cluster the source snapshot was created from. This parameter
        /// is required if your IAM user has a policy containing a snapshot resource element that
        /// specifies anything other than * for the cluster name.        
        /// </para>
        /// </summary>
        public string SnapshotClusterIdentifier
        {
            get { return this._snapshotClusterIdentifier; }
            set { this._snapshotClusterIdentifier = value; }
        }

        // Check to see if SnapshotClusterIdentifier property is set
        internal bool IsSetSnapshotClusterIdentifier()
        {
            return this._snapshotClusterIdentifier != null;
        }


        /// <summary>
        /// Gets and sets the property SnapshotIdentifier. 
        /// <para>
        ///         The name of the snapshot from which to create the new cluster.        This
        /// parameter isn't case sensitive.         
        /// </para>
        ///         
        /// <para>
        /// Example: <code>my-snapshot-id</code>
        /// </para>
        /// </summary>
        public string SnapshotIdentifier
        {
            get { return this._snapshotIdentifier; }
            set { this._snapshotIdentifier = value; }
        }

        // Check to see if SnapshotIdentifier property is set
        internal bool IsSetSnapshotIdentifier()
        {
            return this._snapshotIdentifier != null;
        }


        /// <summary>
        /// Gets and sets the property VpcSecurityGroupIds. 
        /// <para>
        ///             A list of Virtual Private Cloud (VPC) security groups to be associated
        /// with the cluster.        
        /// </para>
        ///         
        /// <para>
        ///             Default: The default VPC security group is associated with the cluster.
        ///        
        /// </para>
        ///         
        /// <para>
        ///             VPC security groups only apply to clusters in VPCs.        
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