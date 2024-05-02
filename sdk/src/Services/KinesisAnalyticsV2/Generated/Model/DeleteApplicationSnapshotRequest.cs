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
    /// Container for the parameters to the DeleteApplicationSnapshot operation.
    /// Deletes a snapshot of application state.
    /// </summary>
    public partial class DeleteApplicationSnapshotRequest : AmazonKinesisAnalyticsV2Request
    {
        private string _applicationName;
        private DateTime? _snapshotCreationTimestamp;
        private string _snapshotName;

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The name of an existing application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ApplicationName
        {
            get { return this._applicationName; }
            set { this._applicationName = value; }
        }

        // Check to see if ApplicationName property is set
        internal bool IsSetApplicationName()
        {
            return this._applicationName != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotCreationTimestamp. 
        /// <para>
        /// The creation timestamp of the application snapshot to delete. You can retrieve this
        /// value using or .
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The identifier for the snapshot delete.
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

    }
}