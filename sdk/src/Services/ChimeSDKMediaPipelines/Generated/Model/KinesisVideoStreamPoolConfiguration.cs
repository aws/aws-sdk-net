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
 * Do not modify this file. This file is generated from the chime-sdk-media-pipelines-2021-07-15.normal.json service model.
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
namespace Amazon.ChimeSDKMediaPipelines.Model
{
    /// <summary>
    /// The video stream pool configuration object.
    /// </summary>
    public partial class KinesisVideoStreamPoolConfiguration
    {
        private DateTime? _createdTimestamp;
        private string _poolArn;
        private string _poolId;
        private string _poolName;
        private int? _poolSize;
        private KinesisVideoStreamPoolStatus _poolStatus;
        private KinesisVideoStreamConfiguration _streamConfiguration;
        private DateTime? _updatedTimestamp;

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The time at which the configuration was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTimestamp
        {
            get { return this._createdTimestamp; }
            set { this._createdTimestamp = value; }
        }

        // Check to see if CreatedTimestamp property is set
        internal bool IsSetCreatedTimestamp()
        {
            return this._createdTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PoolArn. 
        /// <para>
        /// The ARN of the video stream pool configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=1024)]
        public string PoolArn
        {
            get { return this._poolArn; }
            set { this._poolArn = value; }
        }

        // Check to see if PoolArn property is set
        internal bool IsSetPoolArn()
        {
            return this._poolArn != null;
        }

        /// <summary>
        /// Gets and sets the property PoolId. 
        /// <para>
        /// The ID of the video stream pool in the configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string PoolId
        {
            get { return this._poolId; }
            set { this._poolId = value; }
        }

        // Check to see if PoolId property is set
        internal bool IsSetPoolId()
        {
            return this._poolId != null;
        }

        /// <summary>
        /// Gets and sets the property PoolName. 
        /// <para>
        /// The name of the video stream pool configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string PoolName
        {
            get { return this._poolName; }
            set { this._poolName = value; }
        }

        // Check to see if PoolName property is set
        internal bool IsSetPoolName()
        {
            return this._poolName != null;
        }

        /// <summary>
        /// Gets and sets the property PoolSize. 
        /// <para>
        /// The size of the video stream pool in the configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? PoolSize
        {
            get { return this._poolSize; }
            set { this._poolSize = value; }
        }

        // Check to see if PoolSize property is set
        internal bool IsSetPoolSize()
        {
            return this._poolSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PoolStatus. 
        /// <para>
        /// The status of the video stream pool in the configuration. 
        /// </para>
        /// </summary>
        public KinesisVideoStreamPoolStatus PoolStatus
        {
            get { return this._poolStatus; }
            set { this._poolStatus = value; }
        }

        // Check to see if PoolStatus property is set
        internal bool IsSetPoolStatus()
        {
            return this._poolStatus != null;
        }

        /// <summary>
        /// Gets and sets the property StreamConfiguration. 
        /// <para>
        /// The Kinesis video stream pool configuration object.
        /// </para>
        /// </summary>
        public KinesisVideoStreamConfiguration StreamConfiguration
        {
            get { return this._streamConfiguration; }
            set { this._streamConfiguration = value; }
        }

        // Check to see if StreamConfiguration property is set
        internal bool IsSetStreamConfiguration()
        {
            return this._streamConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedTimestamp. 
        /// <para>
        /// The time at which the configuration was updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedTimestamp
        {
            get { return this._updatedTimestamp; }
            set { this._updatedTimestamp = value; }
        }

        // Check to see if UpdatedTimestamp property is set
        internal bool IsSetUpdatedTimestamp()
        {
            return this._updatedTimestamp.HasValue; 
        }

    }
}