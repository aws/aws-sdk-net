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
    /// Container for the parameters to the UpdateResourceDataSync operation.
    /// Update a resource data sync. After you create a resource data sync for a Region, you
    /// can't change the account options for that sync. For example, if you create a sync
    /// in the us-east-2 (Ohio) Region and you choose the <c>Include only the current account</c>
    /// option, you can't edit that sync later and choose the <c>Include all accounts from
    /// my Organizations configuration</c> option. Instead, you must delete the first resource
    /// data sync, and create a new one.
    /// 
    ///  <note> 
    /// <para>
    /// This API operation only supports a resource data sync that was created with a SyncFromSource
    /// <c>SyncType</c>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class UpdateResourceDataSyncRequest : AmazonSimpleSystemsManagementRequest
    {
        private string _syncName;
        private ResourceDataSyncSource _syncSource;
        private string _syncType;

        /// <summary>
        /// Gets and sets the property SyncName. 
        /// <para>
        /// The name of the resource data sync you want to update.
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
        /// Specify information about the data sources to synchronize.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The type of resource data sync. The supported <c>SyncType</c> is SyncFromSource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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