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
 * Do not modify this file. This file is generated from the sms-2016-10-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServerMigrationService.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteReplicationJob operation.
    /// Deletes the specified replication job.
    /// 
    ///  
    /// <para>
    /// After you delete a replication job, there are no further replication runs. AWS deletes
    /// the contents of the Amazon S3 bucket used to store AWS SMS artifacts. The AMIs created
    /// by the replication runs are not deleted.
    /// </para>
    /// </summary>
    public partial class DeleteReplicationJobRequest : AmazonServerMigrationServiceRequest
    {
        private string _replicationJobId;

        /// <summary>
        /// Gets and sets the property ReplicationJobId. 
        /// <para>
        /// The identifier of the replication job.
        /// </para>
        /// </summary>
        public string ReplicationJobId
        {
            get { return this._replicationJobId; }
            set { this._replicationJobId = value; }
        }

        // Check to see if ReplicationJobId property is set
        internal bool IsSetReplicationJobId()
        {
            return this._replicationJobId != null;
        }

    }
}