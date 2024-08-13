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
    /// Information about a resource data sync configuration, including its current status
    /// and last successful sync.
    /// </summary>
    public partial class ResourceDataSyncItem
    {
        private LastResourceDataSyncStatus _lastStatus;
        private DateTime? _lastSuccessfulSyncTime;
        private string _lastSyncStatusMessage;
        private DateTime? _lastSyncTime;
        private ResourceDataSyncS3Destination _s3Destination;
        private DateTime? _syncCreatedTime;
        private DateTime? _syncLastModifiedTime;
        private string _syncName;
        private ResourceDataSyncSourceWithState _syncSource;
        private string _syncType;

        /// <summary>
        /// Gets and sets the property LastStatus. 
        /// <para>
        /// The status reported by the last sync.
        /// </para>
        /// </summary>
        public LastResourceDataSyncStatus LastStatus
        {
            get { return this._lastStatus; }
            set { this._lastStatus = value; }
        }

        // Check to see if LastStatus property is set
        internal bool IsSetLastStatus()
        {
            return this._lastStatus != null;
        }

        /// <summary>
        /// Gets and sets the property LastSuccessfulSyncTime. 
        /// <para>
        /// The last time the sync operations returned a status of <c>SUCCESSFUL</c> (UTC).
        /// </para>
        /// </summary>
        public DateTime? LastSuccessfulSyncTime
        {
            get { return this._lastSuccessfulSyncTime; }
            set { this._lastSuccessfulSyncTime = value; }
        }

        // Check to see if LastSuccessfulSyncTime property is set
        internal bool IsSetLastSuccessfulSyncTime()
        {
            return this._lastSuccessfulSyncTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastSyncStatusMessage. 
        /// <para>
        /// The status message details reported by the last sync.
        /// </para>
        /// </summary>
        public string LastSyncStatusMessage
        {
            get { return this._lastSyncStatusMessage; }
            set { this._lastSyncStatusMessage = value; }
        }

        // Check to see if LastSyncStatusMessage property is set
        internal bool IsSetLastSyncStatusMessage()
        {
            return this._lastSyncStatusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property LastSyncTime. 
        /// <para>
        /// The last time the configuration attempted to sync (UTC).
        /// </para>
        /// </summary>
        public DateTime? LastSyncTime
        {
            get { return this._lastSyncTime; }
            set { this._lastSyncTime = value; }
        }

        // Check to see if LastSyncTime property is set
        internal bool IsSetLastSyncTime()
        {
            return this._lastSyncTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property S3Destination. 
        /// <para>
        /// Configuration information for the target S3 bucket.
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
        /// Gets and sets the property SyncCreatedTime. 
        /// <para>
        /// The date and time the configuration was created (UTC).
        /// </para>
        /// </summary>
        public DateTime? SyncCreatedTime
        {
            get { return this._syncCreatedTime; }
            set { this._syncCreatedTime = value; }
        }

        // Check to see if SyncCreatedTime property is set
        internal bool IsSetSyncCreatedTime()
        {
            return this._syncCreatedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SyncLastModifiedTime. 
        /// <para>
        /// The date and time the resource data sync was changed. 
        /// </para>
        /// </summary>
        public DateTime? SyncLastModifiedTime
        {
            get { return this._syncLastModifiedTime; }
            set { this._syncLastModifiedTime = value; }
        }

        // Check to see if SyncLastModifiedTime property is set
        internal bool IsSetSyncLastModifiedTime()
        {
            return this._syncLastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SyncName. 
        /// <para>
        /// The name of the resource data sync.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// Information about the source where the data was synchronized. 
        /// </para>
        /// </summary>
        public ResourceDataSyncSourceWithState SyncSource
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
        /// The type of resource data sync. If <c>SyncType</c> is <c>SyncToDestination</c>, then
        /// the resource data sync synchronizes data to an S3 bucket. If the <c>SyncType</c> is
        /// <c>SyncFromSource</c> then the resource data sync synchronizes data from Organizations
        /// or from multiple Amazon Web Services Regions.
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