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
    /// Container for the parameters to the CreateCluster operation.
    /// <para> Creates a new cluster. To create the cluster in virtual private cloud (VPC), you must provide cluster subnet group name. If you don't
    /// provide a cluster subnet group name or the cluster security group parameter, Amazon Redshift creates a non-VPC cluster, it associates the
    /// default cluster security group with the cluster. For more information about managing clusters, go to <a
    /// href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html" >Amazon Redshift Clusters</a> in the <i>Amazon Redshift
    /// Management Guide</i> .
    /// </para>
    /// </summary>
    public partial class CreateClusterRequest : AmazonRedshiftRequest
    {
        private string dBName;
        private string clusterIdentifier;
        private string clusterType;
        private string nodeType;
        private string masterUsername;
        private string masterUserPassword;
        private List<string> clusterSecurityGroups = new List<string>();
        private List<string> vpcSecurityGroupIds = new List<string>();
        private string clusterSubnetGroupName;
        private string availabilityZone;
        private string preferredMaintenanceWindow;
        private string clusterParameterGroupName;
        private int? automatedSnapshotRetentionPeriod;
        private int? port;
        private string clusterVersion;
        private bool? allowVersionUpgrade;
        private int? numberOfNodes;
        private bool? publiclyAccessible;
        private bool? encrypted;
        private string hsmClientCertificateIdentifier;
        private string hsmConfigurationIdentifier;
        private string elasticIp;


        /// <summary>
        /// The name of the first database to be created when the cluster is created. To create additional databases after the cluster is created,
        /// connect to the cluster with a SQL client and use SQL commands to create a database. For more information, go to <a
        /// href="http://docs.aws.amazon.com/redshift/latest/dg/t_creating_database.html">Create a Database</a> in the Amazon Redshift Database
        /// Developer Guide. Default: <c>dev</c> Constraints: <ul> <li>Must contain 1 to 64 alphanumeric characters.</li> <li>Must contain only
        /// lowercase letters.</li> <li>Cannot be a word that is reserved by the service. A list of reserved words can be found in <a
        /// href="http://docs.aws.amazon.com/redshift/latest/dg/r_pg_keywords.html">Reserved Words</a> in the Amazon Redshift Database Developer Guide.
        /// </li> </ul>
        ///  
        /// </summary>
        public string DBName
        {
            get { return this.dBName; }
            set { this.dBName = value; }
        }

        // Check to see if DBName property is set
        internal bool IsSetDBName()
        {
            return this.dBName != null;
        }

        /// <summary>
        /// A unique identifier for the cluster. You use this identifier to refer to the cluster for any subsequent cluster operations such as deleting
        /// or modifying. The identifier also appears in the Amazon Redshift console. Constraints: <ul> <li>Must contain from 1 to 63 alphanumeric
        /// characters or hyphens.</li> <li>Alphabetic characters must be lowercase.</li> <li>First character must be a letter.</li> <li>Cannot end with
        /// a hyphen or contain two consecutive hyphens.</li> <li>Must be unique for all clusters within an AWS account.</li> </ul> Example:
        /// <c>myexamplecluster</c>
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
        /// The type of the cluster. When cluster type is specified as <ul> <li><c>single-node</c>, the <b>NumberOfNodes</b> parameter is not
        /// required.</li> <li><c>multi-node</c>, the <b>NumberOfNodes</b> parameter is required.</li> </ul> Valid Values: <c>multi-node</c> |
        /// <c>single-node</c> Default: <c>multi-node</c>
        ///  
        /// </summary>
        public string ClusterType
        {
            get { return this.clusterType; }
            set { this.clusterType = value; }
        }

        // Check to see if ClusterType property is set
        internal bool IsSetClusterType()
        {
            return this.clusterType != null;
        }

        /// <summary>
        /// The node type to be provisioned for the cluster. For information about node types, go to <a
        /// href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html#how-many-nodes"> Working with Clusters</a> in the <i>Amazon
        /// Redshift Management Guide</i>. Valid Values: <c>dw.hs1.xlarge</c> | <c>dw.hs1.8xlarge</c>.
        ///  
        /// </summary>
        public string NodeType
        {
            get { return this.nodeType; }
            set { this.nodeType = value; }
        }

        // Check to see if NodeType property is set
        internal bool IsSetNodeType()
        {
            return this.nodeType != null;
        }

        /// <summary>
        /// The user name associated with the master user account for the cluster that is being created. Constraints: <ul> <li>Must be 1 - 128
        /// alphanumeric characters.</li> <li>First character must be a letter.</li> <li>Cannot be a reserved word. A list of reserved words can be
        /// found in <a href="http://docs.aws.amazon.com/redshift/latest/dg/r_pg_keywords.html">Reserved Words</a> in the Amazon Redshift Database
        /// Developer Guide. </li> </ul>
        ///  
        /// </summary>
        public string MasterUsername
        {
            get { return this.masterUsername; }
            set { this.masterUsername = value; }
        }

        // Check to see if MasterUsername property is set
        internal bool IsSetMasterUsername()
        {
            return this.masterUsername != null;
        }

        /// <summary>
        /// The password associated with the master user account for the cluster that is being created. Constraints: <ul> <li>Must be between 8 and 64
        /// characters in length.</li> <li>Must contain at least one uppercase letter.</li> <li>Must contain at least one lowercase letter.</li>
        /// <li>Must contain one number.</li> <li>Can be any printable ASCII character (ASCII code 33 to 126) except ' (single quote), " (double quote),
        /// \, /, @, or space.</li> </ul>
        ///  
        /// </summary>
        public string MasterUserPassword
        {
            get { return this.masterUserPassword; }
            set { this.masterUserPassword = value; }
        }

        // Check to see if MasterUserPassword property is set
        internal bool IsSetMasterUserPassword()
        {
            return this.masterUserPassword != null;
        }

        /// <summary>
        /// A list of security groups to be associated with this cluster. Default: The default cluster security group for Amazon Redshift.
        ///  
        /// </summary>
        public List<string> ClusterSecurityGroups
        {
            get { return this.clusterSecurityGroups; }
            set { this.clusterSecurityGroups = value; }
        }

        // Check to see if ClusterSecurityGroups property is set
        internal bool IsSetClusterSecurityGroups()
        {
            return this.clusterSecurityGroups.Count > 0;
        }

        /// <summary>
        /// A list of Virtual Private Cloud (VPC) security groups to be associated with the cluster. Default: The default VPC security group is
        /// associated with the cluster.
        ///  
        /// </summary>
        public List<string> VpcSecurityGroupIds
        {
            get { return this.vpcSecurityGroupIds; }
            set { this.vpcSecurityGroupIds = value; }
        }

        // Check to see if VpcSecurityGroupIds property is set
        internal bool IsSetVpcSecurityGroupIds()
        {
            return this.vpcSecurityGroupIds.Count > 0;
        }

        /// <summary>
        /// The name of a cluster subnet group to be associated with this cluster. If this parameter is not provided the resulting cluster will be
        /// deployed outside virtual private cloud (VPC).
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
        /// The EC2 Availability Zone (AZ) in which you want Amazon Redshift to provision the cluster. For example, if you have several EC2 instances
        /// running in a specific Availability Zone, then you might want the cluster to be provisioned in the same zone in order to decrease network
        /// latency. Default: A random, system-chosen Availability Zone in the region that is specified by the endpoint. Example: <c>us-east-1d</c>
        /// Constraint: The specified Availability Zone must be in the same region as the current endpoint.
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
        /// The weekly time range (in UTC) during which automated cluster maintenance can occur. Format: <c>ddd:hh24:mi-ddd:hh24:mi</c> Default: A
        /// 30-minute window selected at random from an 8-hour block of time per region, occurring on a random day of the week. The following list shows
        /// the time blocks for each region from which the default maintenance windows are assigned. <ul> <li><b>US-East (Northern Virginia) Region:</b>
        /// 03:00-11:00 UTC</li> <li><b>US-West (Oregon) Region</b> 06:00-14:00 UTC</li> </ul> Valid Days: Mon | Tue | Wed | Thu | Fri | Sat | Sun
        /// Constraints: Minimum 30-minute window.
        ///  
        /// </summary>
        public string PreferredMaintenanceWindow
        {
            get { return this.preferredMaintenanceWindow; }
            set { this.preferredMaintenanceWindow = value; }
        }

        // Check to see if PreferredMaintenanceWindow property is set
        internal bool IsSetPreferredMaintenanceWindow()
        {
            return this.preferredMaintenanceWindow != null;
        }

        /// <summary>
        /// The name of the parameter group to be associated with this cluster. Default: The default Amazon Redshift cluster parameter group. For
        /// information about the default parameter group, go to <a
        /// href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html">Working with Amazon Redshift Parameter Groups</a>
        /// Constraints: <ul> <li>Must be 1 to 255 alphanumeric characters or hyphens.</li> <li>First character must be a letter.</li> <li>Cannot end
        /// with a hyphen or contain two consecutive hyphens.</li> </ul>
        ///  
        /// </summary>
        public string ClusterParameterGroupName
        {
            get { return this.clusterParameterGroupName; }
            set { this.clusterParameterGroupName = value; }
        }

        // Check to see if ClusterParameterGroupName property is set
        internal bool IsSetClusterParameterGroupName()
        {
            return this.clusterParameterGroupName != null;
        }

        /// <summary>
        /// The number of days that automated snapshots are retained. If the value is 0, automated snapshots are disabled. Even if automated snapshots
        /// are disabled, you can still create manual snapshots when you want with <a>CreateClusterSnapshot</a>. Default: <c>1</c> Constraints: Must be
        /// a value from 0 to 35.
        ///  
        /// </summary>
        public int AutomatedSnapshotRetentionPeriod
        {
            get { return this.automatedSnapshotRetentionPeriod ?? default(int); }
            set { this.automatedSnapshotRetentionPeriod = value; }
        }

        // Check to see if AutomatedSnapshotRetentionPeriod property is set
        internal bool IsSetAutomatedSnapshotRetentionPeriod()
        {
            return this.automatedSnapshotRetentionPeriod.HasValue;
        }

        /// <summary>
        /// The port number on which the cluster accepts incoming connections. The cluster is accessible only via the JDBC and ODBC connection strings.
        /// Part of the connection string requires the port on which the cluster will listen for incoming connections. Default: <c>5439</c> Valid
        /// Values: <c>1150-65535</c>
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
        /// The version of the Amazon Redshift engine software that you want to deploy on the cluster. The version selected runs on all the nodes in the
        /// cluster. Constraints: Only version 1.0 is currently available. Example: <c>1.0</c>
        ///  
        /// </summary>
        public string ClusterVersion
        {
            get { return this.clusterVersion; }
            set { this.clusterVersion = value; }
        }

        // Check to see if ClusterVersion property is set
        internal bool IsSetClusterVersion()
        {
            return this.clusterVersion != null;
        }

        /// <summary>
        /// If <c>true</c>, upgrades can be applied during the maintenance window to the Amazon Redshift engine that is running on the cluster. When a
        /// new version of the Amazon Redshift engine is released, you can request that the service automatically apply upgrades during the maintenance
        /// window to the Amazon Redshift engine that is running on your cluster. Default: <c>true</c>
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
        /// The number of compute nodes in the cluster. This parameter is required when the <b>ClusterType</b> parameter is specified as
        /// <c>multi-node</c>. For information about determining how many nodes you need, go to <a
        /// href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html#how-many-nodes"> Working with Clusters</a> in the <i>Amazon
        /// Redshift Management Guide</i>. If you don't specify this parameter, you get a single-node cluster. When requesting a multi-node cluster, you
        /// must specify the number of nodes that you want in the cluster. Default: <c>1</c> Constraints: Value must be at least 1 and no more than 100.
        ///  
        /// </summary>
        public int NumberOfNodes
        {
            get { return this.numberOfNodes ?? default(int); }
            set { this.numberOfNodes = value; }
        }

        // Check to see if NumberOfNodes property is set
        internal bool IsSetNumberOfNodes()
        {
            return this.numberOfNodes.HasValue;
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
        /// If <c>true</c>, the data in cluster is encrypted at rest. Default: false
        ///  
        /// </summary>
        public bool Encrypted
        {
            get { return this.encrypted ?? default(bool); }
            set { this.encrypted = value; }
        }

        // Check to see if Encrypted property is set
        internal bool IsSetEncrypted()
        {
            return this.encrypted.HasValue;
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
        /// The Elastic IP (EIP) address for the cluster. Constraints: The cluster must be provisioned in EC2-VPC and publicly-accessible through an
        /// Internet gateway. For more information about provisioning clusters in EC2-VPC, go to <a
        /// href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html#cluster-platforms">Supported Platforms to Launch Your
        /// Cluster</a> in the Amazon Redshift Management Guide.
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
    
