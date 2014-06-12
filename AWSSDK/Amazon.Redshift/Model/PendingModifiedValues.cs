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
    /// Describes cluster attributes that are in a pending state. A change to one
    /// or        more the attributes was requested and is in progress or will be applied.
    /// </summary>
    public partial class PendingModifiedValues
    {
        private int? _automatedSnapshotRetentionPeriod;
        private string _clusterIdentifier;
        private string _clusterType;
        private string _clusterVersion;
        private string _masterUserPassword;
        private string _nodeType;
        private int? _numberOfNodes;


        /// <summary>
        /// Gets and sets the property AutomatedSnapshotRetentionPeriod. 
        /// <para>
        ///             The pending or in-progress change of the automated snapshot retention
        /// period.                    
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
        public PendingModifiedValues WithAutomatedSnapshotRetentionPeriod(int automatedSnapshotRetentionPeriod)
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
        /// The pending or in-progress change of the new identifier for the cluster.
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
        public PendingModifiedValues WithClusterIdentifier(string clusterIdentifier)
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
        /// Gets and sets the property ClusterType. 
        /// <para>
        ///         The pending or in-progress change of the cluster type.        
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
        public PendingModifiedValues WithClusterType(string clusterType)
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
        ///          The pending or in-progress change of the service version.               
        ///     
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
        public PendingModifiedValues WithClusterVersion(string clusterVersion)
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
        /// Gets and sets the property MasterUserPassword. 
        /// <para>
        ///         The pending or in-progress change of the master user password for the cluster.
        ///        
        /// </para>
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
        public PendingModifiedValues WithMasterUserPassword(string masterUserPassword)
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
        /// Gets and sets the property NodeType. 
        /// <para>
        ///         The pending or in-progress change of the cluster's node type.        
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
        public PendingModifiedValues WithNodeType(string nodeType)
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
        ///             The pending or in-progress change of the number of nodes in the cluster.
        ///                    
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
        public PendingModifiedValues WithNumberOfNodes(int numberOfNodes)
        {
            this._numberOfNodes = numberOfNodes;
            return this;
        }

        // Check to see if NumberOfNodes property is set
        internal bool IsSetNumberOfNodes()
        {
            return this._numberOfNodes.HasValue; 
        }

    }
}