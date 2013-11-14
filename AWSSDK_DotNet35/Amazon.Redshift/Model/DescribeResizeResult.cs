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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// <para>Describes the result of a cluster resize operation.</para>
    /// </summary>
    public partial class DescribeResizeResult : AmazonWebServiceResponse
    {
        
        private string targetNodeType;
        private int? targetNumberOfNodes;
        private string targetClusterType;
        private string status;
        private List<string> importTablesCompleted = new List<string>();
        private List<string> importTablesInProgress = new List<string>();
        private List<string> importTablesNotStarted = new List<string>();


        /// <summary>
        /// The node type that the cluster will have after the resize is complete.
        ///  
        /// </summary>
        public string TargetNodeType
        {
            get { return this.targetNodeType; }
            set { this.targetNodeType = value; }
        }

        // Check to see if TargetNodeType property is set
        internal bool IsSetTargetNodeType()
        {
            return this.targetNodeType != null;
        }

        /// <summary>
        /// The number of nodes that the cluster will have after the resize is complete.
        ///  
        /// </summary>
        public int TargetNumberOfNodes
        {
            get { return this.targetNumberOfNodes ?? default(int); }
            set { this.targetNumberOfNodes = value; }
        }

        // Check to see if TargetNumberOfNodes property is set
        internal bool IsSetTargetNumberOfNodes()
        {
            return this.targetNumberOfNodes.HasValue;
        }

        /// <summary>
        /// The cluster type after the resize is complete. Valid Values: <c>multi-node</c> | <c>single-node</c>
        ///  
        /// </summary>
        public string TargetClusterType
        {
            get { return this.targetClusterType; }
            set { this.targetClusterType = value; }
        }

        // Check to see if TargetClusterType property is set
        internal bool IsSetTargetClusterType()
        {
            return this.targetClusterType != null;
        }

        /// <summary>
        /// The status of the resize operation. Valid Values: <c>NONE</c> | <c>IN_PROGRESS</c> | <c>FAILED</c> | <c>SUCCEEDED</c>
        ///  
        /// </summary>
        public string Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this.status != null;
        }

        /// <summary>
        /// The names of tables that have been completely imported . Valid Values: List of table names.
        ///  
        /// </summary>
        public List<string> ImportTablesCompleted
        {
            get { return this.importTablesCompleted; }
            set { this.importTablesCompleted = value; }
        }

        // Check to see if ImportTablesCompleted property is set
        internal bool IsSetImportTablesCompleted()
        {
            return this.importTablesCompleted.Count > 0;
        }

        /// <summary>
        /// The names of tables that are being currently imported. Valid Values: List of table names.
        ///  
        /// </summary>
        public List<string> ImportTablesInProgress
        {
            get { return this.importTablesInProgress; }
            set { this.importTablesInProgress = value; }
        }

        // Check to see if ImportTablesInProgress property is set
        internal bool IsSetImportTablesInProgress()
        {
            return this.importTablesInProgress.Count > 0;
        }

        /// <summary>
        /// The names of tables that have not been yet imported. Valid Values: List of table names
        ///  
        /// </summary>
        public List<string> ImportTablesNotStarted
        {
            get { return this.importTablesNotStarted; }
            set { this.importTablesNotStarted = value; }
        }

        // Check to see if ImportTablesNotStarted property is set
        internal bool IsSetImportTablesNotStarted()
        {
            return this.importTablesNotStarted.Count > 0;
        }
    }
}
