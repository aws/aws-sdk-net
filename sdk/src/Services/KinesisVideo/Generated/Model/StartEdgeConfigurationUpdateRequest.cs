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
 * Do not modify this file. This file is generated from the kinesisvideo-2017-09-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisVideo.Model
{
    /// <summary>
    /// Container for the parameters to the StartEdgeConfigurationUpdate operation.
    /// An asynchronous API that updates a stream’s existing edge configuration. The Kinesis
    /// Video Stream will sync the stream’s edge configuration with the Edge Agent IoT Greengrass
    /// component that runs on an IoT Hub Device, setup at your premise. The time to sync
    /// can vary and depends on the connectivity of the Hub Device. The <code>SyncStatus</code>
    /// will be updated as the edge configuration is acknowledged, and synced with the Edge
    /// Agent. 
    /// 
    ///  
    /// <para>
    /// If this API is invoked for the first time, a new edge configuration will be created
    /// for the stream, and the sync status will be set to <code>SYNCING</code>. You will
    /// have to wait for the sync status to reach a terminal state such as: <code>IN_SYNC</code>,
    /// or <code>SYNC_FAILED</code>, before using this API again. If you invoke this API during
    /// the syncing process, a <code>ResourceInUseException</code> will be thrown. The connectivity
    /// of the stream’s edge configuration and the Edge Agent will be retried for 15 minutes.
    /// After 15 minutes, the status will transition into the <code>SYNC_FAILED</code> state.
    /// </para>
    /// </summary>
    public partial class StartEdgeConfigurationUpdateRequest : AmazonKinesisVideoRequest
    {
        private EdgeConfig _edgeConfig;
        private string _streamARN;
        private string _streamName;

        /// <summary>
        /// Gets and sets the property EdgeConfig. 
        /// <para>
        /// The edge configuration details required to invoke the update process.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EdgeConfig EdgeConfig
        {
            get { return this._edgeConfig; }
            set { this._edgeConfig = value; }
        }

        // Check to see if EdgeConfig property is set
        internal bool IsSetEdgeConfig()
        {
            return this._edgeConfig != null;
        }

        /// <summary>
        /// Gets and sets the property StreamARN. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the stream. Specify either the <code>StreamName</code>
        /// or the <code>StreamARN</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string StreamARN
        {
            get { return this._streamARN; }
            set { this._streamARN = value; }
        }

        // Check to see if StreamARN property is set
        internal bool IsSetStreamARN()
        {
            return this._streamARN != null;
        }

        /// <summary>
        /// Gets and sets the property StreamName. 
        /// <para>
        /// The name of the stream whose edge configuration you want to update. Specify either
        /// the <code>StreamName</code> or the <code>StreamARN</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string StreamName
        {
            get { return this._streamName; }
            set { this._streamName = value; }
        }

        // Check to see if StreamName property is set
        internal bool IsSetStreamName()
        {
            return this._streamName != null;
        }

    }
}