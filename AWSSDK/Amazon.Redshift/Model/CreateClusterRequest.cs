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
    /// default cluster security group with the cluster. For more information about managing clusters, go to Amazon Redshift Clusters in the
    /// <i>Amazon Redshift Management Guide</i> .
    /// </para>
    /// </summary>
    /// <seealso cref="Amazon.Redshift.AmazonRedshift.CreateCluster"/>
    public class CreateClusterRequest : AmazonWebServiceRequest
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

        /// <summary>
        /// The name of the first database to be created when the cluster is created. To create additional databases after the cluster is created,
        /// connect to the cluster with a SQL client and use SQL commands to create a database. For more information, go to <a
        /// href="http://docs.aws.amazon.com/redshift/latest/dg/t_creating_database.html">Create a Database</a> in the Amazon Redshift Developer Guide.
        /// Default: <c>dev</c> Constraints: <ul> <li>Must contain 1 to 64 alphanumeric characters.</li> <li>Must contain only lowercase letters.</li>
        /// <li>Cannot be a word that is reserved by the service. A list of reserved words can be found in <a
        /// href="http://docs.aws.amazon.com/redshift/latest/dg/r_pg_keywords.html">Reserved Words</a> in the Amazon Redshift Developer Guide. </li>
        /// </ul>
        ///  
        /// </summary>
        public string DBName
        {
            get { return this.dBName; }
            set { this.dBName = value; }
        }

        /// <summary>
        /// Sets the DBName property
        /// </summary>
        /// <param name="dBName">The value to set for the DBName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateClusterRequest WithDBName(string dBName)
        {
            this.dBName = dBName;
            return this;
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

        /// <summary>
        /// Sets the ClusterIdentifier property
        /// </summary>
        /// <param name="clusterIdentifier">The value to set for the ClusterIdentifier property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateClusterRequest WithClusterIdentifier(string clusterIdentifier)
        {
            this.clusterIdentifier = clusterIdentifier;
            return this;
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

        /// <summary>
        /// Sets the ClusterType property
        /// </summary>
        /// <param name="clusterType">The value to set for the ClusterType property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateClusterRequest WithClusterType(string clusterType)
        {
            this.clusterType = clusterType;
            return this;
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

        /// <summary>
        /// Sets the NodeType property
        /// </summary>
        /// <param name="nodeType">The value to set for the NodeType property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateClusterRequest WithNodeType(string nodeType)
        {
            this.nodeType = nodeType;
            return this;
        }
            

        // Check to see if NodeType property is set
        internal bool IsSetNodeType()
        {
            return this.nodeType != null;
        }

        /// <summary>
        /// The user name associated with the master user account for the cluster that is being created. Constraints: <ul> <li>Must be 1 - 128
        /// alphanumeric characters.</li> <li>First character must be a letter.</li> <li>Cannot be a reserved word. A list of reserved words can be
        /// found in <a href="http://docs.aws.amazon.com/redshift/latest/dg/r_pg_keywords.html">Reserved Words</a> in the Amazon Redshift Developer
        /// Guide. </li> </ul>
        ///  
        /// </summary>
        public string MasterUsername
        {
            get { return this.masterUsername; }
            set { this.masterUsername = value; }
        }

        /// <summary>
        /// Sets the MasterUsername property
        /// </summary>
        /// <param name="masterUsername">The value to set for the MasterUsername property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateClusterRequest WithMasterUsername(string masterUsername)
        {
            this.masterUsername = masterUsername;
            return this;
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

        /// <summary>
        /// Sets the MasterUserPassword property
        /// </summary>
        /// <param name="masterUserPassword">The value to set for the MasterUserPassword property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateClusterRequest WithMasterUserPassword(string masterUserPassword)
        {
            this.masterUserPassword = masterUserPassword;
            return this;
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
        /// <summary>
        /// Adds elements to the ClusterSecurityGroups collection
        /// </summary>
        /// <param name="clusterSecurityGroups">The values to add to the ClusterSecurityGroups collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateClusterRequest WithClusterSecurityGroups(params string[] clusterSecurityGroups)
        {
            foreach (string element in clusterSecurityGroups)
            {
                this.clusterSecurityGroups.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the ClusterSecurityGroups collection
        /// </summary>
        /// <param name="clusterSecurityGroups">The values to add to the ClusterSecurityGroups collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateClusterRequest WithClusterSecurityGroups(IEnumerable<string> clusterSecurityGroups)
        {
            foreach (string element in clusterSecurityGroups)
            {
                this.clusterSecurityGroups.Add(element);
            }

            return this;
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
        /// <summary>
        /// Adds elements to the VpcSecurityGroupIds collection
        /// </summary>
        /// <param name="vpcSecurityGroupIds">The values to add to the VpcSecurityGroupIds collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateClusterRequest WithVpcSecurityGroupIds(params string[] vpcSecurityGroupIds)
        {
            foreach (string element in vpcSecurityGroupIds)
            {
                this.vpcSecurityGroupIds.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the VpcSecurityGroupIds collection
        /// </summary>
        /// <param name="vpcSecurityGroupIds">The values to add to the VpcSecurityGroupIds collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateClusterRequest WithVpcSecurityGroupIds(IEnumerable<string> vpcSecurityGroupIds)
        {
            foreach (string element in vpcSecurityGroupIds)
            {
                this.vpcSecurityGroupIds.Add(element);
            }

            return this;
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

        /// <summary>
        /// Sets the ClusterSubnetGroupName property
        /// </summary>
        /// <param name="clusterSubnetGroupName">The value to set for the ClusterSubnetGroupName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateClusterRequest WithClusterSubnetGroupName(string clusterSubnetGroupName)
        {
            this.clusterSubnetGroupName = clusterSubnetGroupName;
            return this;
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

        /// <summary>
        /// Sets the AvailabilityZone property
        /// </summary>
        /// <param name="availabilityZone">The value to set for the AvailabilityZone property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateClusterRequest WithAvailabilityZone(string availabilityZone)
        {
            this.availabilityZone = availabilityZone;
            return this;
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

        /// <summary>
        /// Sets the PreferredMaintenanceWindow property
        /// </summary>
        /// <param name="preferredMaintenanceWindow">The value to set for the PreferredMaintenanceWindow property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateClusterRequest WithPreferredMaintenanceWindow(string preferredMaintenanceWindow)
        {
            this.preferredMaintenanceWindow = preferredMaintenanceWindow;
            return this;
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

        /// <summary>
        /// Sets the ClusterParameterGroupName property
        /// </summary>
        /// <param name="clusterParameterGroupName">The value to set for the ClusterParameterGroupName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateClusterRequest WithClusterParameterGroupName(string clusterParameterGroupName)
        {
            this.clusterParameterGroupName = clusterParameterGroupName;
            return this;
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

        /// <summary>
        /// Sets the AutomatedSnapshotRetentionPeriod property
        /// </summary>
        /// <param name="automatedSnapshotRetentionPeriod">The value to set for the AutomatedSnapshotRetentionPeriod property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateClusterRequest WithAutomatedSnapshotRetentionPeriod(int automatedSnapshotRetentionPeriod)
        {
            this.automatedSnapshotRetentionPeriod = automatedSnapshotRetentionPeriod;
            return this;
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

        /// <summary>
        /// Sets the Port property
        /// </summary>
        /// <param name="port">The value to set for the Port property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateClusterRequest WithPort(int port)
        {
            this.port = port;
            return this;
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

        /// <summary>
        /// Sets the ClusterVersion property
        /// </summary>
        /// <param name="clusterVersion">The value to set for the ClusterVersion property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateClusterRequest WithClusterVersion(string clusterVersion)
        {
            this.clusterVersion = clusterVersion;
            return this;
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

        /// <summary>
        /// Sets the AllowVersionUpgrade property
        /// </summary>
        /// <param name="allowVersionUpgrade">The value to set for the AllowVersionUpgrade property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateClusterRequest WithAllowVersionUpgrade(bool allowVersionUpgrade)
        {
            this.allowVersionUpgrade = allowVersionUpgrade;
            return this;
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

        /// <summary>
        /// Sets the NumberOfNodes property
        /// </summary>
        /// <param name="numberOfNodes">The value to set for the NumberOfNodes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateClusterRequest WithNumberOfNodes(int numberOfNodes)
        {
            this.numberOfNodes = numberOfNodes;
            return this;
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

        /// <summary>
        /// Sets the PubliclyAccessible property
        /// </summary>
        /// <param name="publiclyAccessible">The value to set for the PubliclyAccessible property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateClusterRequest WithPubliclyAccessible(bool publiclyAccessible)
        {
            this.publiclyAccessible = publiclyAccessible;
            return this;
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

        /// <summary>
        /// Sets the Encrypted property
        /// </summary>
        /// <param name="encrypted">The value to set for the Encrypted property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateClusterRequest WithEncrypted(bool encrypted)
        {
            this.encrypted = encrypted;
            return this;
        }
            

        // Check to see if Encrypted property is set
        internal bool IsSetEncrypted()
        {
            return this.encrypted.HasValue;
        }
    }
}
    
