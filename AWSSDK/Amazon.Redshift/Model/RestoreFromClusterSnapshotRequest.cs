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
    public partial class RestoreFromClusterSnapshotRequest : AmazonWebServiceRequest
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


        /// <summary>
        /// Sets the AllowVersionUpgrade property
        /// </summary>
        /// <param name="allowVersionUpgrade">The value to set for the AllowVersionUpgrade property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RestoreFromClusterSnapshotRequest WithAllowVersionUpgrade(bool allowVersionUpgrade)
        {
            this._allowVersionUpgrade = allowVersionUpgrade;
            return this;
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


        /// <summary>
        /// Sets the AutomatedSnapshotRetentionPeriod property
        /// </summary>
        /// <param name="automatedSnapshotRetentionPeriod">The value to set for the AutomatedSnapshotRetentionPeriod property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RestoreFromClusterSnapshotRequest WithAutomatedSnapshotRetentionPeriod(int automatedSnapshotRetentionPeriod)
        {
            this._automatedSnapshotRetentionPeriod = automatedSnapshotRetentionPeriod;
            return this;
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


        /// <summary>
        /// Sets the AvailabilityZone property
        /// </summary>
        /// <param name="availabilityZone">The value to set for the AvailabilityZone property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RestoreFromClusterSnapshotRequest WithAvailabilityZone(string availabilityZone)
        {
            this._availabilityZone = availabilityZone;
            return this;
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


        /// <summary>
        /// Sets the ClusterIdentifier property
        /// </summary>
        /// <param name="clusterIdentifier">The value to set for the ClusterIdentifier property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RestoreFromClusterSnapshotRequest WithClusterIdentifier(string clusterIdentifier)
        {
            this._clusterIdentifier = clusterIdentifier;
            return this;
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


        /// <summary>
        /// Sets the ClusterParameterGroupName property
        /// </summary>
        /// <param name="clusterParameterGroupName">The value to set for the ClusterParameterGroupName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RestoreFromClusterSnapshotRequest WithClusterParameterGroupName(string clusterParameterGroupName)
        {
            this._clusterParameterGroupName = clusterParameterGroupName;
            return this;
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

        /// <summary>
        /// Sets the ClusterSecurityGroups property
        /// </summary>
        /// <param name="clusterSecurityGroups">The values to add to the ClusterSecurityGroups collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RestoreFromClusterSnapshotRequest WithClusterSecurityGroups(params string[] clusterSecurityGroups)
        {
            foreach (var element in clusterSecurityGroups)
            {
                this._clusterSecurityGroups.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the ClusterSecurityGroups property
        /// </summary>
        /// <param name="clusterSecurityGroups">The values to add to the ClusterSecurityGroups collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RestoreFromClusterSnapshotRequest WithClusterSecurityGroups(IEnumerable<string> clusterSecurityGroups)
        {
            foreach (var element in clusterSecurityGroups)
            {
                this._clusterSecurityGroups.Add(element);
            }
            return this;
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


        /// <summary>
        /// Sets the ClusterSubnetGroupName property
        /// </summary>
        /// <param name="clusterSubnetGroupName">The value to set for the ClusterSubnetGroupName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RestoreFromClusterSnapshotRequest WithClusterSubnetGroupName(string clusterSubnetGroupName)
        {
            this._clusterSubnetGroupName = clusterSubnetGroupName;
            return this;
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


        /// <summary>
        /// Sets the ElasticIp property
        /// </summary>
        /// <param name="elasticIp">The value to set for the ElasticIp property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RestoreFromClusterSnapshotRequest WithElasticIp(string elasticIp)
        {
            this._elasticIp = elasticIp;
            return this;
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


        /// <summary>
        /// Sets the HsmClientCertificateIdentifier property
        /// </summary>
        /// <param name="hsmClientCertificateIdentifier">The value to set for the HsmClientCertificateIdentifier property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RestoreFromClusterSnapshotRequest WithHsmClientCertificateIdentifier(string hsmClientCertificateIdentifier)
        {
            this._hsmClientCertificateIdentifier = hsmClientCertificateIdentifier;
            return this;
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


        /// <summary>
        /// Sets the HsmConfigurationIdentifier property
        /// </summary>
        /// <param name="hsmConfigurationIdentifier">The value to set for the HsmConfigurationIdentifier property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RestoreFromClusterSnapshotRequest WithHsmConfigurationIdentifier(string hsmConfigurationIdentifier)
        {
            this._hsmConfigurationIdentifier = hsmConfigurationIdentifier;
            return this;
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


        /// <summary>
        /// Sets the OwnerAccount property
        /// </summary>
        /// <param name="ownerAccount">The value to set for the OwnerAccount property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RestoreFromClusterSnapshotRequest WithOwnerAccount(string ownerAccount)
        {
            this._ownerAccount = ownerAccount;
            return this;
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


        /// <summary>
        /// Sets the Port property
        /// </summary>
        /// <param name="port">The value to set for the Port property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RestoreFromClusterSnapshotRequest WithPort(int port)
        {
            this._port = port;
            return this;
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


        /// <summary>
        /// Sets the PreferredMaintenanceWindow property
        /// </summary>
        /// <param name="preferredMaintenanceWindow">The value to set for the PreferredMaintenanceWindow property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RestoreFromClusterSnapshotRequest WithPreferredMaintenanceWindow(string preferredMaintenanceWindow)
        {
            this._preferredMaintenanceWindow = preferredMaintenanceWindow;
            return this;
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


        /// <summary>
        /// Sets the PubliclyAccessible property
        /// </summary>
        /// <param name="publiclyAccessible">The value to set for the PubliclyAccessible property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RestoreFromClusterSnapshotRequest WithPubliclyAccessible(bool publiclyAccessible)
        {
            this._publiclyAccessible = publiclyAccessible;
            return this;
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


        /// <summary>
        /// Sets the SnapshotClusterIdentifier property
        /// </summary>
        /// <param name="snapshotClusterIdentifier">The value to set for the SnapshotClusterIdentifier property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RestoreFromClusterSnapshotRequest WithSnapshotClusterIdentifier(string snapshotClusterIdentifier)
        {
            this._snapshotClusterIdentifier = snapshotClusterIdentifier;
            return this;
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


        /// <summary>
        /// Sets the SnapshotIdentifier property
        /// </summary>
        /// <param name="snapshotIdentifier">The value to set for the SnapshotIdentifier property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RestoreFromClusterSnapshotRequest WithSnapshotIdentifier(string snapshotIdentifier)
        {
            this._snapshotIdentifier = snapshotIdentifier;
            return this;
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

        /// <summary>
        /// Sets the VpcSecurityGroupIds property
        /// </summary>
        /// <param name="vpcSecurityGroupIds">The values to add to the VpcSecurityGroupIds collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RestoreFromClusterSnapshotRequest WithVpcSecurityGroupIds(params string[] vpcSecurityGroupIds)
        {
            foreach (var element in vpcSecurityGroupIds)
            {
                this._vpcSecurityGroupIds.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the VpcSecurityGroupIds property
        /// </summary>
        /// <param name="vpcSecurityGroupIds">The values to add to the VpcSecurityGroupIds collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RestoreFromClusterSnapshotRequest WithVpcSecurityGroupIds(IEnumerable<string> vpcSecurityGroupIds)
        {
            foreach (var element in vpcSecurityGroupIds)
            {
                this._vpcSecurityGroupIds.Add(element);
            }
            return this;
        }
        // Check to see if VpcSecurityGroupIds property is set
        internal bool IsSetVpcSecurityGroupIds()
        {
            return this._vpcSecurityGroupIds != null && this._vpcSecurityGroupIds.Count > 0; 
        }

    }
}