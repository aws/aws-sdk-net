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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the CopySnapshot operation.
    /// <para>Copies a point-in-time snapshot of an Amazon EBS volume and stores it in Amazon S3. You can copy the snapshot within the same region
    /// or from one region to another. You can use the snapshot to create Amazon EBS volumes or Amazon Machine Images (AMIs).</para> <para>For more
    /// information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-copy-snapshot.html" >Copying an Amazon EBS Snapshot</a> in
    /// the <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
    /// </summary>
    public partial class CopySnapshotRequest : AmazonEC2Request
    {
        private string sourceRegion;
        private string sourceSnapshotId;
        private string description;


        /// <summary>
        /// The ID of the region that contains the snapshot to be copied.
        ///  
        /// </summary>
        public string SourceRegion
        {
            get { return this.sourceRegion; }
            set { this.sourceRegion = value; }
        }

        // Check to see if SourceRegion property is set
        internal bool IsSetSourceRegion()
        {
            return this.sourceRegion != null;
        }

        /// <summary>
        /// The ID of the Amazon EBS snapshot to copy.
        ///  
        /// </summary>
        public string SourceSnapshotId
        {
            get { return this.sourceSnapshotId; }
            set { this.sourceSnapshotId = value; }
        }

        // Check to see if SourceSnapshotId property is set
        internal bool IsSetSourceSnapshotId()
        {
            return this.sourceSnapshotId != null;
        }

        /// <summary>
        /// A description for the new Amazon EBS snapshot.
        ///  
        /// </summary>
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this.description != null;
        }

    }
}
    
