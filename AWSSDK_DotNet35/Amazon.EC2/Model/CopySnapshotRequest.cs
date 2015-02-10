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

/*
 * Do not modify this file. This file is generated from the ec2-2014-10-01.normal.json service model.
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
    /// Copies a point-in-time snapshot of an Amazon EBS volume and stores it in Amazon S3.
    /// You can copy the snapshot within the same region or from one region to another. You
    /// can use the snapshot to create Amazon EBS volumes or Amazon Machine Images (AMIs).
    /// The snapshot is copied to the regional endpoint that you send the HTTP request to.
    /// 
    ///  
    /// <para>
    /// Copies of encrypted Amazon EBS snapshots remain encrypted. Copies of unencrypted snapshots
    /// remain unencrypted.
    /// </para>
    ///  <note> 
    /// <para>
    /// Copying snapshots that were encrypted with non-default AWS Key Management Service
    /// (KMS) master keys is not supported at this time. 
    /// </para>
    ///  </note> 
    /// <para>
    /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-copy-snapshot.html">Copying
    /// an Amazon EBS Snapshot</a> in the <i>Amazon Elastic Compute Cloud User Guide for Linux</i>.
    /// </para>
    /// </summary>
    public partial class CopySnapshotRequest : AmazonEC2Request
    {
        private string _description;
        private string _destinationRegion;
        private string _presignedUrl;
        private string _sourceRegion;
        private string _sourceSnapshotId;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the new Amazon EBS snapshot.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationRegion. 
        /// <para>
        /// The destination region of the snapshot copy operation. This parameter is required
        /// in the <code>PresignedUrl</code>.
        /// </para>
        /// </summary>
        public string DestinationRegion
        {
            get { return this._destinationRegion; }
            set { this._destinationRegion = value; }
        }

        // Check to see if DestinationRegion property is set
        internal bool IsSetDestinationRegion()
        {
            return this._destinationRegion != null;
        }

        /// <summary>
        /// Gets and sets the property PresignedUrl. 
        /// <para>
        /// The pre-signed URL that facilitates copying an encrypted snapshot. This parameter
        /// is only required when copying an encrypted snapshot with the Amazon EC2 Query API;
        /// it is available as an optional parameter in all other cases. The <code>PresignedUrl</code>
        /// should use the snapshot source endpoint, the <code>CopySnapshot</code> action, and
        /// include the <code>SourceRegion</code>, <code>SourceSnapshotId</code>, and <code>DestinationRegion</code>
        /// parameters. The <code>PresignedUrl</code> must be signed using AWS Signature Version
        /// 4. Because Amazon EBS snapshots are stored in Amazon S3, the signing algorithm for
        /// this parameter uses the same logic that is described in <a href="http://docs.aws.amazon.com/AmazonS3/latest/API/sigv4-query-string-auth.html">Authenticating
        /// Requests by Using Query Parameters (AWS Signature Version 4)</a> in the <i>Amazon
        /// Simple Storage Service API Reference</i>. An invalid or improperly signed <code>PresignedUrl</code>
        /// will cause the copy operation to fail asynchronously, and the snapshot will move to
        /// an <code>error</code> state.
        /// </para>
        /// </summary>
        internal string PresignedUrl
        {
            get { return this._presignedUrl; }
            set { this._presignedUrl = value; }
        }

        // Check to see if PresignedUrl property is set
        internal bool IsSetPresignedUrl()
        {
            return this._presignedUrl != null;
        }

        /// <summary>
        /// Gets and sets the property SourceRegion. 
        /// <para>
        /// The ID of the region that contains the snapshot to be copied.
        /// </para>
        /// </summary>
        public string SourceRegion
        {
            get { return this._sourceRegion; }
            set { this._sourceRegion = value; }
        }

        // Check to see if SourceRegion property is set
        internal bool IsSetSourceRegion()
        {
            return this._sourceRegion != null;
        }

        /// <summary>
        /// Gets and sets the property SourceSnapshotId. 
        /// <para>
        /// The ID of the Amazon EBS snapshot to copy.
        /// </para>
        /// </summary>
        public string SourceSnapshotId
        {
            get { return this._sourceSnapshotId; }
            set { this._sourceSnapshotId = value; }
        }

        // Check to see if SourceSnapshotId property is set
        internal bool IsSetSourceSnapshotId()
        {
            return this._sourceSnapshotId != null;
        }

    }
}