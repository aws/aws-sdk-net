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
    /// Container for the parameters to the DeleteClusterSnapshot operation.
    /// <para> Deletes the specified manual snapshot. The snapshot must be in the "available" state, with no other users authorized to access the
    /// snapshot. </para> <para> Unlike automated snapshots, manual snapshots are retained even after you delete your cluster. Amazon Redshift does
    /// not delete your manual snapshots. You must delete manual snapshot explicitly to avoid getting charged. If other accounts are authorized to
    /// access the snapshot, you must revoke all of the authorizations before you can delete the snapshot. </para>
    /// </summary>
    /// <seealso cref="Amazon.Redshift.AmazonRedshift.DeleteClusterSnapshot"/>
    public class DeleteClusterSnapshotRequest : AmazonWebServiceRequest
    {
        private string snapshotIdentifier;

        /// <summary>
        /// The unique identifier of the manual snapshot to be deleted. Constraints: Must be the name of an existing snapshot that is in the
        /// <c>available</c> state.
        ///  
        /// </summary>
        public string SnapshotIdentifier
        {
            get { return this.snapshotIdentifier; }
            set { this.snapshotIdentifier = value; }
        }

        /// <summary>
        /// Sets the SnapshotIdentifier property
        /// </summary>
        /// <param name="snapshotIdentifier">The value to set for the SnapshotIdentifier property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DeleteClusterSnapshotRequest WithSnapshotIdentifier(string snapshotIdentifier)
        {
            this.snapshotIdentifier = snapshotIdentifier;
            return this;
        }
            

        // Check to see if SnapshotIdentifier property is set
        internal bool IsSetSnapshotIdentifier()
        {
            return this.snapshotIdentifier != null;
        }
    }
}
    
