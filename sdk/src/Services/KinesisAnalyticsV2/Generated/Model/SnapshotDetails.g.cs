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

namespace Amazon.KinesisAnalyticsV2.Model
{
    /// <summary>
    /// Provides details about a snapshot of application state.
    /// </summary>
    public partial class SnapshotDetails
    {
        /// <summary>
        /// Gets and sets the property ApplicationEncryptionConfigurationDescription. 
        /// <para>
        /// Specifies the encryption settings of data at rest for the application snapshot.
        /// </para>
        /// </summary>
        public ApplicationEncryptionConfigurationDescription ApplicationEncryptionConfigurationDescription { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationEncryptionConfigurationDescription property is set.
        /// </summary>
        internal bool IsSetApplicationEncryptionConfigurationDescription() => this.ApplicationEncryptionConfigurationDescription != null;

        /// <summary>
        /// Gets and sets the property ApplicationVersionId. 
        /// <para>
        /// The current application version ID when the snapshot was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 999999999)]
        public long? ApplicationVersionId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationVersionId property is set.
        /// </summary>
        internal bool IsSetApplicationVersionId() => this.ApplicationVersionId.HasValue;

        /// <summary>
        /// Gets and sets the property RuntimeEnvironment. 
        /// <para>
        /// The Flink Runtime for the application snapshot.
        /// </para>
        /// </summary>
        public RuntimeEnvironment RuntimeEnvironment { get; set; }

        /// <summary>
        /// Checks to see if the RuntimeEnvironment property is set.
        /// </summary>
        internal bool IsSetRuntimeEnvironment() => this.RuntimeEnvironment != null;

        /// <summary>
        /// Gets and sets the property SnapshotCreationTimestamp. 
        /// <para>
        /// The timestamp of the application snapshot.
        /// </para>
        /// </summary>
        public DateTime? SnapshotCreationTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotCreationTimestamp property is set.
        /// </summary>
        internal bool IsSetSnapshotCreationTimestamp() => this.SnapshotCreationTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property SnapshotName. 
        /// <para>
        /// The identifier for the application snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string SnapshotName { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotName property is set.
        /// </summary>
        internal bool IsSetSnapshotName() => this.SnapshotName != null;

        /// <summary>
        /// Gets and sets the property SnapshotStatus. 
        /// <para>
        /// The status of the application snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SnapshotStatus SnapshotStatus { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotStatus property is set.
        /// </summary>
        internal bool IsSetSnapshotStatus() => this.SnapshotStatus != null;
    }
}
