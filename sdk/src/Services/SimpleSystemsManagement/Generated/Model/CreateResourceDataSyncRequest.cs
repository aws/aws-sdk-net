/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the CreateResourceDataSync operation.
    /// A resource data sync helps you view data from multiple sources in a single location.
    /// Systems Manager offers two types of resource data sync: <code>SyncToDestination</code>
    /// and <code>SyncFromSource</code>.
    /// 
    ///  
    /// <para>
    /// You can configure Systems Manager Inventory to use the <code>SyncToDestination</code>
    /// type to synchronize Inventory data from multiple AWS Regions to a single S3 bucket.
    /// For more information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/sysman-inventory-datasync.html">Configuring
    /// Resource Data Sync for Inventory</a> in the <i>AWS Systems Manager User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// You can configure Systems Manager Explorer to use the <code>SyncFromSource</code>
    /// type to synchronize operational work items (OpsItems) and operational data (OpsData)
    /// from multiple AWS Regions to a single S3 bucket. This type can synchronize OpsItems
    /// and OpsData from multiple AWS accounts and Regions or <code>EntireOrganization</code>
    /// by using AWS Organizations. For more information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/Explorer-resource-data-sync.html">Setting
    /// up Systems Manager Explorer to display data from multiple accounts and Regions</a>
    /// in the <i>AWS Systems Manager User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// A resource data sync is an asynchronous operation that returns immediately. After
    /// a successful initial sync is completed, the system continuously syncs data. To check
    /// the status of a sync, use the <a>ListResourceDataSync</a>.
    /// </para>
    ///  <note> 
    /// <para>
    /// By default, data is not encrypted in Amazon S3. We strongly recommend that you enable
    /// encryption in Amazon S3 to ensure secure data storage. We also recommend that you
    /// secure access to the Amazon S3 bucket by creating a restrictive bucket policy. 
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateResourceDataSyncRequest : AmazonSimpleSystemsManagementRequest
    {
        private ResourceDataSyncS3Destination _s3Destination;
        private string _syncName;
        private ResourceDataSyncSource _syncSource;
        private string _syncType;

        /// <summary>
        /// Gets and sets the property S3Destination. 
        /// <para>
        /// Amazon S3 configuration details for the sync. This parameter is required if the <code>SyncType</code>
        /// value is SyncToDestination.
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
        [AWSProperty(Required=true, Min=1, Max=64)]
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

        /// <summary>
        /// Gets and sets the property SyncSource. 
        /// <para>
        /// Specify information about the data sources to synchronize. This parameter is required
        /// if the <code>SyncType</code> value is SyncFromSource.
        /// </para>
        /// </summary>
        public ResourceDataSyncSource SyncSource
        {
            get { return this._syncSource; }
            set { this._syncSource = value; }
        }

        // Check to see if SyncSource property is set
        internal bool IsSetSyncSource()
        {
            return this._syncSource != null;
        }

        /// <summary>
        /// Gets and sets the property SyncType. 
        /// <para>
        /// Specify <code>SyncToDestination</code> to create a resource data sync that synchronizes
        /// data to an S3 bucket for Inventory. If you specify <code>SyncToDestination</code>,
        /// you must provide a value for <code>S3Destination</code>. Specify <code>SyncFromSource</code>
        /// to synchronize data from a single account and multiple Regions, or multiple AWS accounts
        /// and Regions, as listed in AWS Organizations for Explorer. If you specify <code>SyncFromSource</code>,
        /// you must provide a value for <code>SyncSource</code>. The default value is <code>SyncToDestination</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string SyncType
        {
            get { return this._syncType; }
            set { this._syncType = value; }
        }

        // Check to see if SyncType property is set
        internal bool IsSetSyncType()
        {
            return this._syncType != null;
        }

    }
}