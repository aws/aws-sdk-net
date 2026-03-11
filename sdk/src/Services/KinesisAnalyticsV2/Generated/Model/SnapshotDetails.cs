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
 * Do not modify this file. This file is generated from the kinesisanalyticsv2-2018-05-23.normal.json service model.
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
namespace Amazon.KinesisAnalyticsV2.Model
{
    /// <summary>
    /// Provides details about a snapshot of application state.
    /// </summary>
    public partial class SnapshotDetails
    {
        private ApplicationEncryptionConfigurationDescription _applicationEncryptionConfigurationDescription;
        private long? _applicationVersionId;
        private RuntimeEnvironment _runtimeEnvironment;
        private DateTime? _snapshotCreationTimestamp;
        private string _snapshotName;
        private SnapshotStatus _snapshotStatus;

        /// <summary>
        /// Gets and sets the property ApplicationEncryptionConfigurationDescription. 
        /// <para>
        /// Specifies the encryption settings of data at rest for the application snapshot.
        /// </para>
        /// </summary>
        public ApplicationEncryptionConfigurationDescription ApplicationEncryptionConfigurationDescription
        {
            get { return this._applicationEncryptionConfigurationDescription; }
            set { this._applicationEncryptionConfigurationDescription = value; }
        }

        // Check to see if ApplicationEncryptionConfigurationDescription property is set
        internal bool IsSetApplicationEncryptionConfigurationDescription()
        {
            return this._applicationEncryptionConfigurationDescription != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationVersionId. 
        /// <para>
        /// The current application version ID when the snapshot was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=999999999)]
        public long? ApplicationVersionId
        {
            get { return this._applicationVersionId; }
            set { this._applicationVersionId = value; }
        }

        // Check to see if ApplicationVersionId property is set
        internal bool IsSetApplicationVersionId()
        {
            return this._applicationVersionId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RuntimeEnvironment. 
        /// <para>
        /// The Flink Runtime for the application snapshot.
        /// </para>
        /// </summary>
        public RuntimeEnvironment RuntimeEnvironment
        {
            get { return this._runtimeEnvironment; }
            set { this._runtimeEnvironment = value; }
        }

        // Check to see if RuntimeEnvironment property is set
        internal bool IsSetRuntimeEnvironment()
        {
            return this._runtimeEnvironment != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotCreationTimestamp. 
        /// <para>
        /// The timestamp of the application snapshot.
        /// </para>
        /// </summary>
        public DateTime? SnapshotCreationTimestamp
        {
            get { return this._snapshotCreationTimestamp; }
            set { this._snapshotCreationTimestamp = value; }
        }

        // Check to see if SnapshotCreationTimestamp property is set
        internal bool IsSetSnapshotCreationTimestamp()
        {
            return this._snapshotCreationTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SnapshotName. 
        /// <para>
        /// The identifier for the application snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string SnapshotName
        {
            get { return this._snapshotName; }
            set { this._snapshotName = value; }
        }

        // Check to see if SnapshotName property is set
        internal bool IsSetSnapshotName()
        {
            return this._snapshotName != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotStatus. 
        /// <para>
        /// The status of the application snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SnapshotStatus SnapshotStatus
        {
            get { return this._snapshotStatus; }
            set { this._snapshotStatus = value; }
        }

        // Check to see if SnapshotStatus property is set
        internal bool IsSetSnapshotStatus()
        {
            return this._snapshotStatus != null;
        }

    }
}