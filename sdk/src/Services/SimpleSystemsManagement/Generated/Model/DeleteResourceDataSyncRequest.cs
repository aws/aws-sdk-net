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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteResourceDataSync operation.
    /// Deletes a Resource Data Sync configuration. After the configuration is deleted, changes
    /// to inventory data on managed instances are no longer synced with the target Amazon
    /// S3 bucket. Deleting a sync configuration does not delete data in the target Amazon
    /// S3 bucket.
    /// </summary>
    public partial class DeleteResourceDataSyncRequest : AmazonSimpleSystemsManagementRequest
    {
        private string _syncName;

        /// <summary>
        /// Gets and sets the property SyncName. 
        /// <para>
        /// The name of the configuration to delete.
        /// </para>
        /// </summary>
        public string SyncName
        {
            get { return this._syncName; }
            set { this._syncName = value; }
        }

        // Check to see if SyncName property is set
        internal bool IsSetSyncName()
        {
            return this._syncName != null;
        }

    }
}