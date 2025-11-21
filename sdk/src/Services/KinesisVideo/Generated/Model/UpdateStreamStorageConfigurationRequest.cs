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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.KinesisVideo.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateStreamStorageConfiguration operation.
    /// Updates the storage configuration for an existing Kinesis video stream.
    /// 
    ///  
    /// <para>
    /// This operation allows you to modify the storage tier settings for a stream, enabling
    /// you to optimize storage costs and performance based on your access patterns.
    /// </para>
    ///  
    /// <para>
    ///  <c>UpdateStreamStorageConfiguration</c> is an asynchronous operation.
    /// </para>
    ///  
    /// <para>
    /// You must have permissions for the <c>KinesisVideo:UpdateStreamStorageConfiguration</c>
    /// action.
    /// </para>
    /// </summary>
    public partial class UpdateStreamStorageConfigurationRequest : AmazonKinesisVideoRequest
    {
        private string _currentVersion;
        private string _streamARN;
        private string _streamName;
        private StreamStorageConfiguration _streamStorageConfiguration;

        /// <summary>
        /// Gets and sets the property CurrentVersion. 
        /// <para>
        /// The version of the stream whose storage configuration you want to change. To get the
        /// version, call either the <c>DescribeStream</c> or the <c>ListStreams</c> API.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string CurrentVersion
        {
            get { return this._currentVersion; }
            set { this._currentVersion = value; }
        }

        // Check to see if CurrentVersion property is set
        internal bool IsSetCurrentVersion()
        {
            return this._currentVersion != null;
        }

        /// <summary>
        /// Gets and sets the property StreamARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the stream for which you want to update the storage
        /// configuration.
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
        /// The name of the stream for which you want to update the storage configuration.
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

        /// <summary>
        /// Gets and sets the property StreamStorageConfiguration. 
        /// <para>
        /// The new storage configuration for the stream. This includes the default storage tier
        /// that determines how stream data is stored and accessed.
        /// </para>
        ///  
        /// <para>
        /// Different storage tiers offer varying levels of performance and cost optimization
        /// to match your specific use case requirements.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public StreamStorageConfiguration StreamStorageConfiguration
        {
            get { return this._streamStorageConfiguration; }
            set { this._streamStorageConfiguration = value; }
        }

        // Check to see if StreamStorageConfiguration property is set
        internal bool IsSetStreamStorageConfiguration()
        {
            return this._streamStorageConfiguration != null;
        }

    }
}