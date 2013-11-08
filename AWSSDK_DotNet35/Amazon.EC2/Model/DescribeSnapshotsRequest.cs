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
    /// Container for the parameters to the DescribeSnapshots operation.
    /// <para> Returns information about the Amazon EBS snapshots available to you. Snapshots available to you include public snapshots available
    /// for any AWS account to launch, private snapshots you own, and private snapshots owned by another AWS account but for which you've been given
    /// explicit create volume permissions. </para>
    /// </summary>
    public partial class DescribeSnapshotsRequest : AmazonEC2Request
    {
        private List<string> snapshotIds = new List<string>();
        private List<string> ownerIds = new List<string>();
        private List<string> restorableByUserIds = new List<string>();
        private List<Filter> filters = new List<Filter>();


        /// <summary>
        /// The optional list of EBS snapshot IDs to describe.
        ///  
        /// </summary>
        public List<string> SnapshotIds
        {
            get { return this.snapshotIds; }
            set { this.snapshotIds = value; }
        }

        // Check to see if SnapshotIds property is set
        internal bool IsSetSnapshotIds()
        {
            return this.snapshotIds.Count > 0;
        }

        /// <summary>
        /// An optional list of owners by which to scope the described EBS snapshots. Valid values are: <ul> <li> <c>self</c> : Snapshots owned by you
        /// </li> <li> <i>AWS account ID</i> : Snapshots owned by this account ID </li> <li> <c>amazon</c> : Snapshots owned by Amazon </li> </ul> The
        /// values <c>self</c> and <c>amazon</c> are literals.
        ///  
        /// </summary>
        public List<string> OwnerIds
        {
            get { return this.ownerIds; }
            set { this.ownerIds = value; }
        }

        // Check to see if OwnerIds property is set
        internal bool IsSetOwnerIds()
        {
            return this.ownerIds.Count > 0;
        }

        /// <summary>
        /// An optional list of users. The described snapshots are scoped to only those snapshots from which these users can create volumes.
        ///  
        /// </summary>
        public List<string> RestorableByUserIds
        {
            get { return this.restorableByUserIds; }
            set { this.restorableByUserIds = value; }
        }

        // Check to see if RestorableByUserIds property is set
        internal bool IsSetRestorableByUserIds()
        {
            return this.restorableByUserIds.Count > 0;
        }

        /// <summary>
        /// A list of filters used to match properties for Snapshots. For a complete reference to the available filter keys for this operation, see the
        /// <a href="http://docs.amazonwebservices.com/AWSEC2/latest/APIReference/">Amazon EC2 API reference</a>.
        ///  
        /// </summary>
        public List<Filter> Filters
        {
            get { return this.filters; }
            set { this.filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this.filters.Count > 0;
        }

    }
}
    
