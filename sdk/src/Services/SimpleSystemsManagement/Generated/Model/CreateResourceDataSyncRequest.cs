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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the CreateResourceDataSync operation.
    /// A resource data sync helps you view data from multiple sources in a single location.
    /// Amazon Web Services Systems Manager offers two types of resource data sync: <c>SyncToDestination</c>
    /// and <c>SyncFromSource</c>.
    /// 
    ///  
    /// <para>
    /// You can configure Systems Manager Inventory to use the <c>SyncToDestination</c> type
    /// to synchronize Inventory data from multiple Amazon Web Services Regions to a single
    /// Amazon Simple Storage Service (Amazon S3) bucket. For more information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/inventory-create-resource-data-sync.html">Creating
    /// a resource data sync for Inventory</a> in the <i>Amazon Web Services Systems Manager
    /// User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// You can configure Systems Manager Explorer to use the <c>SyncFromSource</c> type to
    /// synchronize operational work items (OpsItems) and operational data (OpsData) from
    /// multiple Amazon Web Services Regions to a single Amazon S3 bucket. This type can synchronize
    /// OpsItems and OpsData from multiple Amazon Web Services accounts and Amazon Web Services
    /// Regions or <c>EntireOrganization</c> by using Organizations. For more information,
    /// see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/Explorer-resource-data-sync.html">Setting
    /// up Systems Manager Explorer to display data from multiple accounts and Regions</a>
    /// in the <i>Amazon Web Services Systems Manager User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// A resource data sync is an asynchronous operation that returns immediately. After
    /// a successful initial sync is completed, the system continuously syncs data. To check
    /// the status of a sync, use the <a>ListResourceDataSync</a>.
    /// </para>
    ///  <note> 
    /// <para>
    /// By default, data isn't encrypted in Amazon S3. We strongly recommend that you enable
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
        /// Amazon S3 configuration details for the sync. This parameter is required if the <c>SyncType</c>
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
        /// if the <c>SyncType</c> value is SyncFromSource.
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
        /// Specify <c>SyncToDestination</c> to create a resource data sync that synchronizes
        /// data to an S3 bucket for Inventory. If you specify <c>SyncToDestination</c>, you must
        /// provide a value for <c>S3Destination</c>. Specify <c>SyncFromSource</c> to synchronize
        /// data from a single account and multiple Regions, or multiple Amazon Web Services accounts
        /// and Amazon Web Services Regions, as listed in Organizations for Explorer. If you specify
        /// <c>SyncFromSource</c>, you must provide a value for <c>SyncSource</c>. The default
        /// value is <c>SyncToDestination</c>.
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