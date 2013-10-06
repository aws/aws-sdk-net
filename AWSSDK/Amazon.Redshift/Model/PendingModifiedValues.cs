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
    /// <para> Describes cluster attributes that are in a pending state. A change to one or more the attributes was requested and is in progress or
    /// will be applied. </para>
    /// </summary>
    public class PendingModifiedValues
    {
        
        private string masterUserPassword;
        private string nodeType;
        private int? numberOfNodes;
        private string clusterType;
        private string clusterVersion;
        private int? automatedSnapshotRetentionPeriod;

        /// <summary>
        /// The pending or in-progress change of the master credentials for the cluster.
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
        public PendingModifiedValues WithMasterUserPassword(string masterUserPassword)
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
        /// The pending or in-progress change of the cluster's node type.
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
        public PendingModifiedValues WithNodeType(string nodeType)
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
        /// The pending or in-progress change of the number nodes in the cluster.
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
        public PendingModifiedValues WithNumberOfNodes(int numberOfNodes)
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
        /// The pending or in-progress change of the cluster type.
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
        public PendingModifiedValues WithClusterType(string clusterType)
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
        /// The pending or in-progress change of the service version.
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
        public PendingModifiedValues WithClusterVersion(string clusterVersion)
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
        /// The pending or in-progress change of the automated snapshot retention period.
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
        public PendingModifiedValues WithAutomatedSnapshotRetentionPeriod(int automatedSnapshotRetentionPeriod)
        {
            this.automatedSnapshotRetentionPeriod = automatedSnapshotRetentionPeriod;
            return this;
        }
            

        // Check to see if AutomatedSnapshotRetentionPeriod property is set
        internal bool IsSetAutomatedSnapshotRetentionPeriod()
        {
            return this.automatedSnapshotRetentionPeriod.HasValue;
        }
    }
}
