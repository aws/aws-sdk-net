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
    /// Container for the parameters to the ResetSnapshotAttribute operation.
    /// <para>Resets permission settings for the specified snapshot.</para> <para>For more information on modifying snapshot permissions, see <a
    /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-modifying-snapshot-permissions.html" >Sharing Snapshots</a> in the <i>Amazon
    /// Elastic Compute Cloud User Guide</i> .</para>
    /// </summary>
    public partial class ResetSnapshotAttributeRequest : AmazonEC2Request
    {
        private string snapshotId;
        private SnapshotAttributeName attribute;


        /// <summary>
        /// The ID of the snapshot.
        ///  
        /// </summary>
        public string SnapshotId
        {
            get { return this.snapshotId; }
            set { this.snapshotId = value; }
        }

        // Check to see if SnapshotId property is set
        internal bool IsSetSnapshotId()
        {
            return this.snapshotId != null;
        }

        /// <summary>
        /// The attribute to reset (currently only the attribute for permission to create volumes can be reset).
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>productCodes, createVolumePermission</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public SnapshotAttributeName Attribute
        {
            get { return this.attribute; }
            set { this.attribute = value; }
        }

        // Check to see if Attribute property is set
        internal bool IsSetAttribute()
        {
            return this.attribute != null;
        }

    }
}
    
