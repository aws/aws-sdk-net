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
    /// Container for the parameters to the DeleteCluster operation.
    /// <para> Deletes a previously provisioned cluster. A successful response from the web service indicates that the request was received
    /// correctly. If a final cluster snapshot is requested the status of the cluster will be "final-snapshot" while the snapshot is being taken,
    /// then it's "deleting" once Amazon Redshift begins deleting the cluster. Use DescribeClusters to monitor the status of the deletion. The
    /// delete operation cannot be canceled or reverted once submitted. For more information about managing clusters, go to Amazon Redshift Clusters
    /// in the <i>Amazon Redshift Management Guide</i> .
    /// </para>
    /// </summary>
    /// <seealso cref="Amazon.Redshift.AmazonRedshift.DeleteCluster"/>
    public class DeleteClusterRequest : AmazonWebServiceRequest
    {
        private string clusterIdentifier;
        private bool? skipFinalClusterSnapshot;
        private string finalClusterSnapshotIdentifier;

        /// <summary>
        /// The identifier of the cluster to be deleted. Constraints: <ul> <li>Must contain lowercase characters.</li> <li>Must contain from 1 to 63
        /// alphanumeric characters or hyphens.</li> <li>First character must be a letter.</li> <li>Cannot end with a hyphen or contain two consecutive
        /// hyphens.</li> </ul>
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
        public DeleteClusterRequest WithClusterIdentifier(string clusterIdentifier)
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
        /// Determines whether a final snapshot of the cluster is created before Amazon Redshift deletes the cluster. If <c>true</c>, a final cluster
        /// snapshot is not created. If <c>false</c>, a final cluster snapshot is created before the cluster is deleted. <note>The
        /// <i>FinalClusterSnapshotIdentifier</i> parameter must be specified if <i>SkipFinalClusterSnapshot</i> is <c>false</c>.</note> Default:
        /// <c>false</c>
        ///  
        /// </summary>
        public bool SkipFinalClusterSnapshot
        {
            get { return this.skipFinalClusterSnapshot ?? default(bool); }
            set { this.skipFinalClusterSnapshot = value; }
        }

        /// <summary>
        /// Sets the SkipFinalClusterSnapshot property
        /// </summary>
        /// <param name="skipFinalClusterSnapshot">The value to set for the SkipFinalClusterSnapshot property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DeleteClusterRequest WithSkipFinalClusterSnapshot(bool skipFinalClusterSnapshot)
        {
            this.skipFinalClusterSnapshot = skipFinalClusterSnapshot;
            return this;
        }
            

        // Check to see if SkipFinalClusterSnapshot property is set
        internal bool IsSetSkipFinalClusterSnapshot()
        {
            return this.skipFinalClusterSnapshot.HasValue;
        }

        /// <summary>
        /// The identifier of the final snapshot that is to be created immediately before deleting the cluster. If this parameter is provided,
        /// <i>SkipFinalClusterSnapshot</i> must be <c>false</c>. Constraints: <ul> <li>Must be 1 to 255 alphanumeric characters.</li> <li>First
        /// character must be a letter.</li> <li>Cannot end with a hyphen or contain two consecutive hyphens.</li> </ul>
        ///  
        /// </summary>
        public string FinalClusterSnapshotIdentifier
        {
            get { return this.finalClusterSnapshotIdentifier; }
            set { this.finalClusterSnapshotIdentifier = value; }
        }

        /// <summary>
        /// Sets the FinalClusterSnapshotIdentifier property
        /// </summary>
        /// <param name="finalClusterSnapshotIdentifier">The value to set for the FinalClusterSnapshotIdentifier property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DeleteClusterRequest WithFinalClusterSnapshotIdentifier(string finalClusterSnapshotIdentifier)
        {
            this.finalClusterSnapshotIdentifier = finalClusterSnapshotIdentifier;
            return this;
        }
            

        // Check to see if FinalClusterSnapshotIdentifier property is set
        internal bool IsSetFinalClusterSnapshotIdentifier()
        {
            return this.finalClusterSnapshotIdentifier != null;
        }
    }
}
    
