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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the UpdateResourceDataSync operation. Update a resource
    /// data sync. After you create a resource data sync for a Region, you can't change the
    /// account options for that sync. For example, if you create a sync in the us-east-2
    /// (Ohio) Region and you choose the <c>Include only the current account</c> option, you
    /// can't edit that sync later and choose the <c>Include all accounts from my Organizations
    /// configuration</c> option. Instead, you must delete the first resource data sync, and
    /// create a new one. <note> <para> This API operation only supports a resource data sync
    /// that was created with a SyncFromSource <c>SyncType</c>. </para> </note>
    /// </summary>
    public partial class UpdateResourceDataSyncRequest : AmazonSimpleSystemsManagementRequest
    {
        /// <summary>
        /// Gets and sets the property SyncName. 
        /// <para>
        /// The name of the resource data sync you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string SyncName { get; set; }

        /// <summary>
        /// Checks to see if the SyncName property is set.
        /// </summary>
        internal bool IsSetSyncName() => this.SyncName != null;

        /// <summary>
        /// Gets and sets the property SyncSource. 
        /// <para>
        /// Specify information about the data sources to synchronize.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ResourceDataSyncSource SyncSource { get; set; }

        /// <summary>
        /// Checks to see if the SyncSource property is set.
        /// </summary>
        internal bool IsSetSyncSource() => this.SyncSource != null;

        /// <summary>
        /// Gets and sets the property SyncType. 
        /// <para>
        /// The type of resource data sync. The supported <c>SyncType</c> is SyncFromSource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string SyncType { get; set; }

        /// <summary>
        /// Checks to see if the SyncType property is set.
        /// </summary>
        internal bool IsSetSyncType() => this.SyncType != null;
    }
}
