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
    /// <para>Describes the result of a cluster resize operation.</para>
    /// </summary>
    public class DescribeResizeResult
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

        /// <summary>
        /// Sets the TargetNodeType property
        /// </summary>
        /// <param name="targetNodeType">The value to set for the TargetNodeType property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeResizeResult WithTargetNodeType(string targetNodeType)
        {
            this.targetNodeType = targetNodeType;
            return this;
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

        /// <summary>
        /// Sets the TargetNumberOfNodes property
        /// </summary>
        /// <param name="targetNumberOfNodes">The value to set for the TargetNumberOfNodes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeResizeResult WithTargetNumberOfNodes(int targetNumberOfNodes)
        {
            this.targetNumberOfNodes = targetNumberOfNodes;
            return this;
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

        /// <summary>
        /// Sets the TargetClusterType property
        /// </summary>
        /// <param name="targetClusterType">The value to set for the TargetClusterType property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeResizeResult WithTargetClusterType(string targetClusterType)
        {
            this.targetClusterType = targetClusterType;
            return this;
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

        /// <summary>
        /// Sets the Status property
        /// </summary>
        /// <param name="status">The value to set for the Status property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeResizeResult WithStatus(string status)
        {
            this.status = status;
            return this;
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
        /// <summary>
        /// Adds elements to the ImportTablesCompleted collection
        /// </summary>
        /// <param name="importTablesCompleted">The values to add to the ImportTablesCompleted collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeResizeResult WithImportTablesCompleted(params string[] importTablesCompleted)
        {
            foreach (string element in importTablesCompleted)
            {
                this.importTablesCompleted.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the ImportTablesCompleted collection
        /// </summary>
        /// <param name="importTablesCompleted">The values to add to the ImportTablesCompleted collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeResizeResult WithImportTablesCompleted(IEnumerable<string> importTablesCompleted)
        {
            foreach (string element in importTablesCompleted)
            {
                this.importTablesCompleted.Add(element);
            }

            return this;
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
        /// <summary>
        /// Adds elements to the ImportTablesInProgress collection
        /// </summary>
        /// <param name="importTablesInProgress">The values to add to the ImportTablesInProgress collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeResizeResult WithImportTablesInProgress(params string[] importTablesInProgress)
        {
            foreach (string element in importTablesInProgress)
            {
                this.importTablesInProgress.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the ImportTablesInProgress collection
        /// </summary>
        /// <param name="importTablesInProgress">The values to add to the ImportTablesInProgress collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeResizeResult WithImportTablesInProgress(IEnumerable<string> importTablesInProgress)
        {
            foreach (string element in importTablesInProgress)
            {
                this.importTablesInProgress.Add(element);
            }

            return this;
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
        /// <summary>
        /// Adds elements to the ImportTablesNotStarted collection
        /// </summary>
        /// <param name="importTablesNotStarted">The values to add to the ImportTablesNotStarted collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeResizeResult WithImportTablesNotStarted(params string[] importTablesNotStarted)
        {
            foreach (string element in importTablesNotStarted)
            {
                this.importTablesNotStarted.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the ImportTablesNotStarted collection
        /// </summary>
        /// <param name="importTablesNotStarted">The values to add to the ImportTablesNotStarted collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeResizeResult WithImportTablesNotStarted(IEnumerable<string> importTablesNotStarted)
        {
            foreach (string element in importTablesNotStarted)
            {
                this.importTablesNotStarted.Add(element);
            }

            return this;
        }

        // Check to see if ImportTablesNotStarted property is set
        internal bool IsSetImportTablesNotStarted()
        {
            return this.importTablesNotStarted.Count > 0;
        }
    }
}
