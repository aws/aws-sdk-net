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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// <para>Describes a cluster.</para>
    /// </summary>
    public class Cluster
    {
        
        private string clusterIdentifier;
        private string nodeType;
        private string clusterStatus;
        private string modifyStatus;
        private string masterUsername;
        private string dBName;
        private Endpoint endpoint;
        private DateTime? clusterCreateTime;
        private int? automatedSnapshotRetentionPeriod;
        private List<ClusterSecurityGroupMembership> clusterSecurityGroups = new List<ClusterSecurityGroupMembership>();
        private List<VpcSecurityGroupMembership> vpcSecurityGroups = new List<VpcSecurityGroupMembership>();
        private List<ClusterParameterGroupStatus> clusterParameterGroups = new List<ClusterParameterGroupStatus>();
        private string clusterSubnetGroupName;
        private string vpcId;
        private string availabilityZone;
        private string preferredMaintenanceWindow;
        private PendingModifiedValues pendingModifiedValues;
        private string clusterVersion;
        private bool? allowVersionUpgrade;
        private int? numberOfNodes;
        private bool? publiclyAccessible;
        private bool? encrypted;

        /// <summary>
        /// The unique identifier of the cluster.
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
        public Cluster WithClusterIdentifier(string clusterIdentifier)
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
        /// The node type for the nodes in the cluster.
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
        public Cluster WithNodeType(string nodeType)
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
        /// The current state of this cluster. Possible values include <c>available</c>, <c>creating</c>, <c>deleting</c>, <c>rebooting</c>, and
        /// <c>resizing</c>.
        ///  
        /// </summary>
        public string ClusterStatus
        {
            get { return this.clusterStatus; }
            set { this.clusterStatus = value; }
        }

        /// <summary>
        /// Sets the ClusterStatus property
        /// </summary>
        /// <param name="clusterStatus">The value to set for the ClusterStatus property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Cluster WithClusterStatus(string clusterStatus)
        {
            this.clusterStatus = clusterStatus;
            return this;
        }
            

        // Check to see if ClusterStatus property is set
        internal bool IsSetClusterStatus()
        {
            return this.clusterStatus != null;
        }

        /// <summary>
        /// The status of a modify operation, if any, initiated for the cluster.
        ///  
        /// </summary>
        public string ModifyStatus
        {
            get { return this.modifyStatus; }
            set { this.modifyStatus = value; }
        }

        /// <summary>
        /// Sets the ModifyStatus property
        /// </summary>
        /// <param name="modifyStatus">The value to set for the ModifyStatus property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Cluster WithModifyStatus(string modifyStatus)
        {
            this.modifyStatus = modifyStatus;
            return this;
        }
            

        // Check to see if ModifyStatus property is set
        internal bool IsSetModifyStatus()
        {
            return this.modifyStatus != null;
        }

        /// <summary>
        /// The master user name for the cluster. This name is used to connect to the database that is specified in <b>DBName</b>.
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
        public Cluster WithMasterUsername(string masterUsername)
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
        /// The name of the initial database that was created when the cluster was created. This same name is returned for the life of the cluster. If
        /// an initial database was not specified, a database named "dev" was created by default.
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
        public Cluster WithDBName(string dBName)
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
        /// The connection endpoint.
        ///  
        /// </summary>
        public Endpoint Endpoint
        {
            get { return this.endpoint; }
            set { this.endpoint = value; }
        }

        /// <summary>
        /// Sets the Endpoint property
        /// </summary>
        /// <param name="endpoint">The value to set for the Endpoint property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Cluster WithEndpoint(Endpoint endpoint)
        {
            this.endpoint = endpoint;
            return this;
        }
            

        // Check to see if Endpoint property is set
        internal bool IsSetEndpoint()
        {
            return this.endpoint != null;
        }

        /// <summary>
        /// The date and time that the cluster was created.
        ///  
        /// </summary>
        public DateTime ClusterCreateTime
        {
            get { return this.clusterCreateTime ?? default(DateTime); }
            set { this.clusterCreateTime = value; }
        }

        /// <summary>
        /// Sets the ClusterCreateTime property
        /// </summary>
        /// <param name="clusterCreateTime">The value to set for the ClusterCreateTime property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Cluster WithClusterCreateTime(DateTime clusterCreateTime)
        {
            this.clusterCreateTime = clusterCreateTime;
            return this;
        }
            

        // Check to see if ClusterCreateTime property is set
        internal bool IsSetClusterCreateTime()
        {
            return this.clusterCreateTime.HasValue;
        }

        /// <summary>
        /// The number of days that automatic cluster snapshots are retained.
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
        public Cluster WithAutomatedSnapshotRetentionPeriod(int automatedSnapshotRetentionPeriod)
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
        /// A list of cluster security group that are associated with the cluster. Each security group is represented by an element that contains
        /// <c>ClusterSecurityGroup.Name</c> and <c>ClusterSecurityGroup.Status</c> subelements. Cluster security groups are used when the cluster is
        /// not created in a VPC. Clusters that are created in a VPC use VPC security groups, which are listed by the <b>VpcSecurityGroups</b>
        /// parameter.
        ///  
        /// </summary>
        public List<ClusterSecurityGroupMembership> ClusterSecurityGroups
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
        public Cluster WithClusterSecurityGroups(params ClusterSecurityGroupMembership[] clusterSecurityGroups)
        {
            foreach (ClusterSecurityGroupMembership element in clusterSecurityGroups)
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
        public Cluster WithClusterSecurityGroups(IEnumerable<ClusterSecurityGroupMembership> clusterSecurityGroups)
        {
            foreach (ClusterSecurityGroupMembership element in clusterSecurityGroups)
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
        /// A list of Virtual Private Cloud (VPC) security groups that are associated with the cluster. This parameter is returned only if the cluster
        /// is in a VPC.
        ///  
        /// </summary>
        public List<VpcSecurityGroupMembership> VpcSecurityGroups
        {
            get { return this.vpcSecurityGroups; }
            set { this.vpcSecurityGroups = value; }
        }
        /// <summary>
        /// Adds elements to the VpcSecurityGroups collection
        /// </summary>
        /// <param name="vpcSecurityGroups">The values to add to the VpcSecurityGroups collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Cluster WithVpcSecurityGroups(params VpcSecurityGroupMembership[] vpcSecurityGroups)
        {
            foreach (VpcSecurityGroupMembership element in vpcSecurityGroups)
            {
                this.vpcSecurityGroups.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the VpcSecurityGroups collection
        /// </summary>
        /// <param name="vpcSecurityGroups">The values to add to the VpcSecurityGroups collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Cluster WithVpcSecurityGroups(IEnumerable<VpcSecurityGroupMembership> vpcSecurityGroups)
        {
            foreach (VpcSecurityGroupMembership element in vpcSecurityGroups)
            {
                this.vpcSecurityGroups.Add(element);
            }

            return this;
        }

        // Check to see if VpcSecurityGroups property is set
        internal bool IsSetVpcSecurityGroups()
        {
            return this.vpcSecurityGroups.Count > 0;
        }

        /// <summary>
        /// The list of cluster parameter groups that are associated with this cluster.
        ///  
        /// </summary>
        public List<ClusterParameterGroupStatus> ClusterParameterGroups
        {
            get { return this.clusterParameterGroups; }
            set { this.clusterParameterGroups = value; }
        }
        /// <summary>
        /// Adds elements to the ClusterParameterGroups collection
        /// </summary>
        /// <param name="clusterParameterGroups">The values to add to the ClusterParameterGroups collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Cluster WithClusterParameterGroups(params ClusterParameterGroupStatus[] clusterParameterGroups)
        {
            foreach (ClusterParameterGroupStatus element in clusterParameterGroups)
            {
                this.clusterParameterGroups.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the ClusterParameterGroups collection
        /// </summary>
        /// <param name="clusterParameterGroups">The values to add to the ClusterParameterGroups collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Cluster WithClusterParameterGroups(IEnumerable<ClusterParameterGroupStatus> clusterParameterGroups)
        {
            foreach (ClusterParameterGroupStatus element in clusterParameterGroups)
            {
                this.clusterParameterGroups.Add(element);
            }

            return this;
        }

        // Check to see if ClusterParameterGroups property is set
        internal bool IsSetClusterParameterGroups()
        {
            return this.clusterParameterGroups.Count > 0;
        }

        /// <summary>
        /// The name of the subnet group that is associated with the cluster. This parameter is valid only when the cluster is in a VPC.
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
        public Cluster WithClusterSubnetGroupName(string clusterSubnetGroupName)
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
        /// The identifier of the VPC the cluster is in, if the cluster is in a VPC.
        ///  
        /// </summary>
        public string VpcId
        {
            get { return this.vpcId; }
            set { this.vpcId = value; }
        }

        /// <summary>
        /// Sets the VpcId property
        /// </summary>
        /// <param name="vpcId">The value to set for the VpcId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Cluster WithVpcId(string vpcId)
        {
            this.vpcId = vpcId;
            return this;
        }
            

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this.vpcId != null;
        }

        /// <summary>
        /// The name of the Availability Zone in which the cluster is located.
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
        public Cluster WithAvailabilityZone(string availabilityZone)
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
        /// The weekly time range (in UTC) during which system maintenance can occur.
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
        public Cluster WithPreferredMaintenanceWindow(string preferredMaintenanceWindow)
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
        /// If present, changes to the cluster are pending. Specific pending changes are identified by subelements.
        ///  
        /// </summary>
        public PendingModifiedValues PendingModifiedValues
        {
            get { return this.pendingModifiedValues; }
            set { this.pendingModifiedValues = value; }
        }

        /// <summary>
        /// Sets the PendingModifiedValues property
        /// </summary>
        /// <param name="pendingModifiedValues">The value to set for the PendingModifiedValues property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Cluster WithPendingModifiedValues(PendingModifiedValues pendingModifiedValues)
        {
            this.pendingModifiedValues = pendingModifiedValues;
            return this;
        }
            

        // Check to see if PendingModifiedValues property is set
        internal bool IsSetPendingModifiedValues()
        {
            return this.pendingModifiedValues != null;
        }

        /// <summary>
        /// The version ID of the Amazon Redshift engine that is running on the cluster.
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
        public Cluster WithClusterVersion(string clusterVersion)
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
        /// If <c>true</c>, version upgrades will be applied automatically to the cluster during the maintenance window.
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
        public Cluster WithAllowVersionUpgrade(bool allowVersionUpgrade)
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
        /// The number of compute nodes in the cluster.
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
        public Cluster WithNumberOfNodes(int numberOfNodes)
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
        public Cluster WithPubliclyAccessible(bool publiclyAccessible)
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
        /// If <c>true</c>, data in cluster is encrypted at rest.
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
        public Cluster WithEncrypted(bool encrypted)
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
