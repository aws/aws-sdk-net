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
    /// Container for the parameters to the CreateResourceDataSync operation.
    /// Creates a resource data sync configuration to a single bucket in Amazon S3. This is
    /// an asynchronous operation that returns immediately. After a successful initial sync
    /// is completed, the system continuously syncs data to the Amazon S3 bucket. To check
    /// the status of the sync, use the <a>ListResourceDataSync</a>.
    /// 
    ///  
    /// <para>
    /// By default, data is not encrypted in Amazon S3. We strongly recommend that you enable
    /// encryption in Amazon S3 to ensure secure data storage. We also recommend that you
    /// secure access to the Amazon S3 bucket by creating a restrictive bucket policy. For
    /// more information, see <a href="http://docs.aws.amazon.com/systems-manager/latest/userguide/sysman-inventory-datasync.html">Configuring
    /// Resource Data Sync for Inventory</a> in the <i>AWS Systems Manager User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateResourceDataSyncRequest : AmazonSimpleSystemsManagementRequest
    {
        private ResourceDataSyncS3Destination _s3Destination;
        private string _syncName;

        /// <summary>
        /// Gets and sets the property S3Destination. 
        /// <para>
        /// Amazon S3 configuration details for the sync.
        /// </para>
        /// </summary>
        public ResourceDataSyncS3Destination S3Destination
        {
            get { return this._s3Destination; }
            set { this._s3Destination = value; }
        }

        // Check to see if S3Destination property is set
        internal bool IsSetS3Destination()
        {
            return this._s3Destination != null;
        }

        /// <summary>
        /// Gets and sets the property SyncName. 
        /// <para>
        /// A name for the configuration.
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