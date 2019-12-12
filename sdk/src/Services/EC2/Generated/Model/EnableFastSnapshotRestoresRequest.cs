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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
    /// Container for the parameters to the EnableFastSnapshotRestores operation.
    /// Enables fast snapshot restores for the specified snapshots in the specified Availability
    /// Zones.
    /// 
    ///  
    /// <para>
    /// You get the full benefit of fast snapshot restores after they enter the <code>enabled</code>
    /// state. To get the current state of fast snapshot restores, use <a>DescribeFastSnapshotRestores</a>.
    /// To disable fast snapshot restores, use <a>DisableFastSnapshotRestores</a>.
    /// </para>
    /// </summary>
    public partial class EnableFastSnapshotRestoresRequest : AmazonEC2Request
    {
        private List<string> _availabilityZones = new List<string>();
        private List<string> _sourceSnapshotIds = new List<string>();

        /// <summary>
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        /// One or more Availability Zones. For example, <code>us-east-2a</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> AvailabilityZones
        {
            get { return this._availabilityZones; }
            set { this._availabilityZones = value; }
        }

        // Check to see if AvailabilityZones property is set
        internal bool IsSetAvailabilityZones()
        {
            return this._availabilityZones != null && this._availabilityZones.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SourceSnapshotIds. 
        /// <para>
        /// The IDs of one or more snapshots. For example, <code>snap-1234567890abcdef0</code>.
        /// You can specify a snapshot that was shared with you from another AWS account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> SourceSnapshotIds
        {
            get { return this._sourceSnapshotIds; }
            set { this._sourceSnapshotIds = value; }
        }

        // Check to see if SourceSnapshotIds property is set
        internal bool IsSetSourceSnapshotIds()
        {
            return this._sourceSnapshotIds != null && this._sourceSnapshotIds.Count > 0; 
        }

    }
}