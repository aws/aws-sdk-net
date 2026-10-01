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

namespace Amazon.KinesisVideo.Model
{
    /// <summary>
    /// This is the response object from the StartEdgeConfigurationUpdate operation.
    /// </summary>
    public partial class StartEdgeConfigurationUpdateResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The timestamp at which a stream’s edge configuration was first created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property EdgeConfig. 
        /// <para>
        /// A description of the stream's edge configuration that will be used to sync with the
        /// Edge Agent IoT Greengrass component. The Edge Agent component will run on an IoT Hub
        /// Device setup at your premise.
        /// </para>
        /// </summary>
        public EdgeConfig EdgeConfig { get; set; }

        /// <summary>
        /// Checks to see if the EdgeConfig property is set.
        /// </summary>
        internal bool IsSetEdgeConfig() => this.EdgeConfig != null;

        /// <summary>
        /// Gets and sets the property FailedStatusDetails. 
        /// <para>
        /// A description of the generated failure status.
        /// </para>
        /// </summary>
        public string FailedStatusDetails { get; set; }

        /// <summary>
        /// Checks to see if the FailedStatusDetails property is set.
        /// </summary>
        internal bool IsSetFailedStatusDetails() => this.FailedStatusDetails != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The timestamp at which a stream’s edge configuration was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTime() => this.LastUpdatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property StreamARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the stream.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string StreamARN { get; set; }

        /// <summary>
        /// Checks to see if the StreamARN property is set.
        /// </summary>
        internal bool IsSetStreamARN() => this.StreamARN != null;

        /// <summary>
        /// Gets and sets the property StreamName. 
        /// <para>
        /// The name of the stream from which the edge configuration was updated.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string StreamName { get; set; }

        /// <summary>
        /// Checks to see if the StreamName property is set.
        /// </summary>
        internal bool IsSetStreamName() => this.StreamName != null;

        /// <summary>
        /// Gets and sets the property SyncStatus. 
        /// <para>
        ///  The current sync status of the stream's edge configuration. When you invoke this
        /// API, the sync status will be set to the <c>SYNCING</c> state. Use the <c>DescribeEdgeConfiguration</c>
        /// API to get the latest status of the edge configuration.
        /// </para>
        /// </summary>
        public SyncStatus SyncStatus { get; set; }

        /// <summary>
        /// Checks to see if the SyncStatus property is set.
        /// </summary>
        internal bool IsSetSyncStatus() => this.SyncStatus != null;
    }
}
