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
    /// Container for the parameters to the ModifyCluster operation.
    /// Modifies the settings for a cluster.         For example, you can add
    /// another security or parameter group,         update the preferred maintenance window,
    /// or change the master user password.          Resetting a cluster password or modifying
    /// the security groups associated         with a cluster do not need a reboot. However,
    /// modifying a parameter group         requires a reboot for parameters to take effect.
    ///                For more information about managing clusters, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
    /// Redshift Clusters</a> in the <i>Amazon Redshift Management Guide</i>        
    /// 
    ///         
    /// <para>
    /// You can also change node type and the number of nodes to scale up or down the cluster.
    ///             When resizing a cluster, you must specify            both the number of
    /// nodes and the node type even if one of the parameters does             not change.
    /// If you specify        the same number of nodes and node type that are already configured
    /// for the cluster,         an error is returned.
    /// </para>
    /// </summary>
    public partial class ModifyClusterRequest : AmazonWebServiceRequest
    {
        private bool? _allowVersionUpgrade;
        private int? _automatedSnapshotRetentionPeriod;
        private string _clusterIdentifier;
        private string _clusterParameterGroupName;
        private List<string> _clusterSecurityGroups = new List<string>();
        private string _clusterType;
        private string _clusterVersion;
        private string _hsmClientCertificateIdentifier;
        private string _hsmConfigurationIdentifier;
        private string _masterUserPassword;
        private string _newClusterIdentifier;
        private string _nodeType;
        private int? _numberOfNodes;
        private string _preferredMaintenanceWindow;
        private List<string> _vpcSecurityGroupIds = new List<string>();


        /// <summary>
        /// Gets and sets the property AllowVersionUpgrade. 
        /// <para>
        ///         If <code>true</code>, upgrades will be applied automatically    to the cluster
        /// during the maintenance window.    
        /// </para>
        ///        
        /// <para>
        /// Default: <code>false</code>
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
        public ModifyClusterRequest WithAllowVersionUpgrade(bool allowVersionUpgrade)
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
        ///         The number of days that automated snapshots are retained.        If the value
        /// is 0, automated snapshots are disabled. Even if        automated snapshots are disabled,
        /// you can still create        manual snapshots when you want with <a>CreateClusterSnapshot</a>.
        ///        
        /// </para>
        ///         
        /// <para>
        ///  If you decrease the automated snapshot retention period from its current value, existing
        /// automated snapshots that fall outside of the new retention period will be immediately
        /// deleted.
        /// </para>
        ///         
        /// <para>
        /// Default: Uses existing setting.
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
        public ModifyClusterRequest WithAutomatedSnapshotRetentionPeriod(int automatedSnapshotRetentionPeriod)
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
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        ///             The unique identifier of the cluster to be modified.         
        /// </para>
        ///         
        /// <para>
        /// Example: <code>examplecluster</code>
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
        public ModifyClusterRequest WithClusterIdentifier(string clusterIdentifier)
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
        ///         The name of the cluster parameter group to apply to this cluster.        This
        /// change is applied only after the cluster is rebooted. To reboot        a cluster use
        /// <a>RebootCluster</a>.        
        /// </para>
        ///         
        /// <para>
        /// Default: Uses existing setting.
        /// </para>
        ///         
        /// <para>
        /// Constraints: The cluster parameter group must be in the same             parameter
        /// group family that matches the cluster version.
        /// </para>
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
        public ModifyClusterRequest WithClusterParameterGroupName(string clusterParameterGroupName)
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
        ///         A list of cluster security groups to be authorized on this cluster.      
        ///  This change is asynchronously applied as soon as possible.         
        /// </para>
        ///         
        /// <para>
        /// Security groups currently associated with the cluster, and not in         the list
        /// of groups to apply, will be revoked from the cluster.
        /// </para>
        ///         
        /// <para>
        /// Constraints:
        /// </para>
        ///         <ul>            <li>Must be 1 to 255 alphanumeric characters or hyphens</li>
        ///            <li>First character must be a letter</li>            <li>Cannot end with
        /// a hyphen or contain two consecutive hyphens</li>        </ul>
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
        public ModifyClusterRequest WithClusterSecurityGroups(params string[] clusterSecurityGroups)
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
        public ModifyClusterRequest WithClusterSecurityGroups(IEnumerable<string> clusterSecurityGroups)
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
        /// Gets and sets the property ClusterType. 
        /// <para>
        ///         The new cluster type.        
        /// </para>
        ///         
        /// <para>
        ///             When you submit your cluster resize request, your existing cluster goes
        /// into a             read-only mode. After Amazon Redshift provisions a new cluster
        /// based on your             resize requirements, there will be outage for a period while
        /// the old cluster is             deleted and your connection is switched to the new
        /// cluster.            You can use <a>DescribeResize</a> to track the progress of the
        /// resize request.                   
        /// </para>
        ///         
        /// <para>
        /// Valid Values: <code> multi-node | single-node </code>
        /// </para>
        /// </summary>
        public string ClusterType
        {
            get { return this._clusterType; }
            set { this._clusterType = value; }
        }


        /// <summary>
        /// Sets the ClusterType property
        /// </summary>
        /// <param name="clusterType">The value to set for the ClusterType property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ModifyClusterRequest WithClusterType(string clusterType)
        {
            this._clusterType = clusterType;
            return this;
        }

        // Check to see if ClusterType property is set
        internal bool IsSetClusterType()
        {
            return this._clusterType != null;
        }


        /// <summary>
        /// Gets and sets the property ClusterVersion. 
        /// <para>
        ///     The new version number of the Amazon Redshift engine to upgrade to.    
        /// </para>
        ///     
        /// <para>
        ///     For major version upgrades, if a non-default cluster parameter group is currently
        /// in use,    a new cluster parameter group in the cluster parameter group family   
        /// for the new  version must be specified.    The new cluster parameter group can be
        /// the default for that cluster parameter group family.    For more information about
        /// managing parameter groups, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html">Amazon
        /// Redshift Parameter Groups</a> in the <i>Amazon Redshift Management Guide</i>.    
        /// </para>
        ///     
        /// <para>
        /// Example: <code>1.0</code>
        /// </para>
        /// </summary>
        public string ClusterVersion
        {
            get { return this._clusterVersion; }
            set { this._clusterVersion = value; }
        }


        /// <summary>
        /// Sets the ClusterVersion property
        /// </summary>
        /// <param name="clusterVersion">The value to set for the ClusterVersion property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ModifyClusterRequest WithClusterVersion(string clusterVersion)
        {
            this._clusterVersion = clusterVersion;
            return this;
        }

        // Check to see if ClusterVersion property is set
        internal bool IsSetClusterVersion()
        {
            return this._clusterVersion != null;
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
        public ModifyClusterRequest WithHsmClientCertificateIdentifier(string hsmClientCertificateIdentifier)
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
        public ModifyClusterRequest WithHsmConfigurationIdentifier(string hsmConfigurationIdentifier)
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
        /// Gets and sets the property MasterUserPassword. 
        /// <para>
        ///         The new password for the cluster master user.        This change is asynchronously
        /// applied as soon as possible.        Between the time of the request and the completion
        /// of the request,        the <code>MasterUserPassword</code> element exists in the 
        ///       <code>PendingModifiedValues</code> element of the operation response.      
        ///      <note>                Operations never return the password, so this operation
        /// provides a way to                 regain access to the master user account for a cluster
        /// if the password is lost.            </note>        
        /// </para>
        ///         
        /// <para>
        /// Default: Uses existing setting.
        /// </para>
        ///         
        /// <para>
        ///             Constraints:        
        /// </para>
        ///         <ul>            <li>Must be between 8 and 64 characters in length.</li>  
        ///          <li>Must contain at least one uppercase letter.</li>            <li>Must
        /// contain at least one lowercase letter.</li>            <li>Must contain one number.</li>
        ///            <li>Can be any printable ASCII character (ASCII code 33 to 126) except
        /// ' (single quote), " (double quote), \, /, @, or space.</li>        </ul>
        /// </summary>
        public string MasterUserPassword
        {
            get { return this._masterUserPassword; }
            set { this._masterUserPassword = value; }
        }


        /// <summary>
        /// Sets the MasterUserPassword property
        /// </summary>
        /// <param name="masterUserPassword">The value to set for the MasterUserPassword property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ModifyClusterRequest WithMasterUserPassword(string masterUserPassword)
        {
            this._masterUserPassword = masterUserPassword;
            return this;
        }

        // Check to see if MasterUserPassword property is set
        internal bool IsSetMasterUserPassword()
        {
            return this._masterUserPassword != null;
        }


        /// <summary>
        /// Gets and sets the property NewClusterIdentifier. 
        /// <para>
        /// The new identifier for the cluster.
        /// </para>
        ///         
        /// <para>
        /// Constraints:
        /// </para>
        /// <ul><li>Must contain from 1 to 63 alphanumeric characters or hyphens.</li><li>Alphabetic
        /// characters must be lowercase.</li><li>First character must be a letter.</li><li>Cannot
        /// end with a hyphen or contain two consecutive hyphens.</li><li>Must be unique for all
        /// clusters within an AWS account.</li></ul>        
        /// <para>
        /// Example: <code>examplecluster</code>
        /// </para>
        /// </summary>
        public string NewClusterIdentifier
        {
            get { return this._newClusterIdentifier; }
            set { this._newClusterIdentifier = value; }
        }


        /// <summary>
        /// Sets the NewClusterIdentifier property
        /// </summary>
        /// <param name="newClusterIdentifier">The value to set for the NewClusterIdentifier property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ModifyClusterRequest WithNewClusterIdentifier(string newClusterIdentifier)
        {
            this._newClusterIdentifier = newClusterIdentifier;
            return this;
        }

        // Check to see if NewClusterIdentifier property is set
        internal bool IsSetNewClusterIdentifier()
        {
            return this._newClusterIdentifier != null;
        }


        /// <summary>
        /// Gets and sets the property NodeType. 
        /// <para>
        ///         The new node type of the cluster. If you specify a new node type,        
        /// you must also specify the number of nodes parameter also.        
        /// </para>
        ///         
        /// <para>
        ///             When you submit your request to resize a cluster,             Amazon Redshift
        /// sets access permissions for the cluster to read-only.            After Amazon Redshift
        /// provisions a new cluster according to your             resize requirements, there
        /// will be a temporary outage while the old cluster is             deleted and your connection
        /// is switched to the new cluster. When            the new connection is complete, the
        /// original access permissions for the            cluster are restored.            You
        /// can use the <a>DescribeResize</a> to track the progress of the resize request.   
        ///     
        /// </para>
        ///         
        /// <para>
        /// Valid Values: <code> dw1.xlarge</code> | <code>dw1.8xlarge</code> | <code>dw2.large</code>
        /// | <code>dw2.8xlarge</code>.
        /// </para>
        /// </summary>
        public string NodeType
        {
            get { return this._nodeType; }
            set { this._nodeType = value; }
        }


        /// <summary>
        /// Sets the NodeType property
        /// </summary>
        /// <param name="nodeType">The value to set for the NodeType property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ModifyClusterRequest WithNodeType(string nodeType)
        {
            this._nodeType = nodeType;
            return this;
        }

        // Check to see if NodeType property is set
        internal bool IsSetNodeType()
        {
            return this._nodeType != null;
        }


        /// <summary>
        /// Gets and sets the property NumberOfNodes. 
        /// <para>
        ///         The new number of nodes of the cluster. If you specify a new number of nodes,
        /// you must also specify the node type parameter also.        
        /// </para>
        ///         
        /// <para>
        ///             When you submit your request to resize a cluster,             Amazon Redshift
        /// sets access permissions for the cluster to read-only.            After Amazon Redshift
        /// provisions a new cluster according to your             resize requirements, there
        /// will be a temporary outage while the old cluster is             deleted and your connection
        /// is switched to the new cluster. When            the new connection is complete, the
        /// original access permissions for the            cluster are restored.            You
        /// can use <a>DescribeResize</a> to track the progress of the resize request.       
        /// 
        /// </para>
        ///         
        /// <para>
        /// Valid Values: Integer greater than <code>0</code>.
        /// </para>
        /// </summary>
        public int NumberOfNodes
        {
            get { return this._numberOfNodes.GetValueOrDefault(); }
            set { this._numberOfNodes = value; }
        }


        /// <summary>
        /// Sets the NumberOfNodes property
        /// </summary>
        /// <param name="numberOfNodes">The value to set for the NumberOfNodes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ModifyClusterRequest WithNumberOfNodes(int numberOfNodes)
        {
            this._numberOfNodes = numberOfNodes;
            return this;
        }

        // Check to see if NumberOfNodes property is set
        internal bool IsSetNumberOfNodes()
        {
            return this._numberOfNodes.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property PreferredMaintenanceWindow. 
        /// <para>
        ///         The weekly time range (in UTC) during which system maintenance can occur,
        /// if necessary.        If system maintenance is necessary during the window, it may
        /// result in an outage.         
        /// </para>
        ///         
        /// <para>
        ///         This maintenance window change is made immediately.        If the new maintenance
        /// window indicates the current time,        there must be at least 120 minutes between
        /// the current time and        end of the window in order to ensure that pending changes
        /// are applied.         
        /// </para>
        ///         
        /// <para>
        /// Default: Uses existing setting.
        /// </para>
        ///         
        /// <para>
        /// Format: ddd:hh24:mi-ddd:hh24:mi, for example <code>wed:07:30-wed:08:00</code>.
        /// </para>
        ///         
        /// <para>
        /// Valid Days: Mon | Tue | Wed | Thu | Fri | Sat | Sun
        /// </para>
        ///         
        /// <para>
        /// Constraints: Must be at least 30 minutes.
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
        public ModifyClusterRequest WithPreferredMaintenanceWindow(string preferredMaintenanceWindow)
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
        /// Gets and sets the property VpcSecurityGroupIds. 
        /// <para>
        ///            A list of virtual private cloud (VPC) security groups to be associated
        /// with the cluster.        
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
        public ModifyClusterRequest WithVpcSecurityGroupIds(params string[] vpcSecurityGroupIds)
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
        public ModifyClusterRequest WithVpcSecurityGroupIds(IEnumerable<string> vpcSecurityGroupIds)
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