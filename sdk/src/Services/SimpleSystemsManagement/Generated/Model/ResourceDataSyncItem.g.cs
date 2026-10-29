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
    /// Information about a resource data sync configuration, including its current status
    /// and last successful sync.
    /// </summary>
    public partial class ResourceDataSyncItem
    {
        /// <summary>
        /// Gets and sets the property LastStatus. 
        /// <para>
        /// The status reported by the last sync.
        /// </para>
        /// </summary>
        public LastResourceDataSyncStatus LastStatus { get; set; }

        /// <summary>
        /// Checks to see if the LastStatus property is set.
        /// </summary>
        internal bool IsSetLastStatus() => this.LastStatus != null;

        /// <summary>
        /// Gets and sets the property LastSuccessfulSyncTime. 
        /// <para>
        /// The last time the sync operations returned a status of <c>SUCCESSFUL</c> (UTC).
        /// </para>
        /// </summary>
        public DateTime? LastSuccessfulSyncTime { get; set; }

        /// <summary>
        /// Checks to see if the LastSuccessfulSyncTime property is set.
        /// </summary>
        internal bool IsSetLastSuccessfulSyncTime() => this.LastSuccessfulSyncTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastSyncStatusMessage. 
        /// <para>
        /// The status message details reported by the last sync.
        /// </para>
        /// </summary>
        public string LastSyncStatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the LastSyncStatusMessage property is set.
        /// </summary>
        internal bool IsSetLastSyncStatusMessage() => this.LastSyncStatusMessage != null;

        /// <summary>
        /// Gets and sets the property LastSyncTime. 
        /// <para>
        /// The last time the configuration attempted to sync (UTC).
        /// </para>
        /// </summary>
        public DateTime? LastSyncTime { get; set; }

        /// <summary>
        /// Checks to see if the LastSyncTime property is set.
        /// </summary>
        internal bool IsSetLastSyncTime() => this.LastSyncTime.HasValue;

        /// <summary>
        /// Gets and sets the property S3Destination. 
        /// <para>
        /// Configuration information for the target S3 bucket.
        /// </para>
        /// </summary>
        public ResourceDataSyncS3Destination S3Destination { get; set; }

        /// <summary>
        /// Checks to see if the S3Destination property is set.
        /// </summary>
        internal bool IsSetS3Destination() => this.S3Destination != null;

        /// <summary>
        /// Gets and sets the property SyncCreatedTime. 
        /// <para>
        /// The date and time the configuration was created (UTC).
        /// </para>
        /// </summary>
        public DateTime? SyncCreatedTime { get; set; }

        /// <summary>
        /// Checks to see if the SyncCreatedTime property is set.
        /// </summary>
        internal bool IsSetSyncCreatedTime() => this.SyncCreatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property SyncLastModifiedTime. 
        /// <para>
        /// The date and time the resource data sync was changed. 
        /// </para>
        /// </summary>
        public DateTime? SyncLastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the SyncLastModifiedTime property is set.
        /// </summary>
        internal bool IsSetSyncLastModifiedTime() => this.SyncLastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property SyncName. 
        /// <para>
        /// The name of the resource data sync.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string SyncName { get; set; }

        /// <summary>
        /// Checks to see if the SyncName property is set.
        /// </summary>
        internal bool IsSetSyncName() => this.SyncName != null;

        /// <summary>
        /// Gets and sets the property SyncSource. 
        /// <para>
        /// Information about the source where the data was synchronized. 
        /// </para>
        /// </summary>
        public ResourceDataSyncSourceWithState SyncSource { get; set; }

        /// <summary>
        /// Checks to see if the SyncSource property is set.
        /// </summary>
        internal bool IsSetSyncSource() => this.SyncSource != null;

        /// <summary>
        /// Gets and sets the property SyncType. 
        /// <para>
        /// The type of resource data sync. If <c>SyncType</c> is <c>SyncToDestination</c>, then
        /// the resource data sync synchronizes data to an S3 bucket. If the <c>SyncType</c> is
        /// <c>SyncFromSource</c> then the resource data sync synchronizes data from Organizations
        /// or from multiple Amazon Web Services Regions.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string SyncType { get; set; }

        /// <summary>
        /// Checks to see if the SyncType property is set.
        /// </summary>
        internal bool IsSetSyncType() => this.SyncType != null;
    }
}
