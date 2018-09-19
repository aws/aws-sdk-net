/*
 * Copyright 2018 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.S3.Model
{
    /// <summary>
    /// <p>Specifies whether Amazon S3 should replicate delete makers.</p>
    /// </summary>
    public partial class DeleteMarkerReplication
    {
        private DeleteMarkerReplicationStatus status;

        /// <summary>
        /// Gets and sets the property Status.
        /// <p>The status of the delete marker replication.</p> <note>
        /// <p> In the current implementation, Amazon S3 does not replicate
        /// the delete markers. Therefore, the status must be
        /// <code>Disabled</code>. </p> </note>
        /// </summary>
        public DeleteMarkerReplicationStatus Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this.status != null;
        }
    }
}
