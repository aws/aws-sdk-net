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

namespace Amazon.ChimeSDKMediaPipelines.Model
{
    /// <summary>
    /// The video stream pool configuration object.
    /// </summary>
    public partial class KinesisVideoStreamPoolConfiguration
    {
        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The time at which the configuration was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTimestamp property is set.
        /// </summary>
        internal bool IsSetCreatedTimestamp() => this.CreatedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property PoolArn. 
        /// <para>
        /// The ARN of the video stream pool configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 1024)]
        public string PoolArn { get; set; }

        /// <summary>
        /// Checks to see if the PoolArn property is set.
        /// </summary>
        internal bool IsSetPoolArn() => this.PoolArn != null;

        /// <summary>
        /// Gets and sets the property PoolId. 
        /// <para>
        /// The ID of the video stream pool in the configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string PoolId { get; set; }

        /// <summary>
        /// Checks to see if the PoolId property is set.
        /// </summary>
        internal bool IsSetPoolId() => this.PoolId != null;

        /// <summary>
        /// Gets and sets the property PoolName. 
        /// <para>
        /// The name of the video stream pool configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string PoolName { get; set; }

        /// <summary>
        /// Checks to see if the PoolName property is set.
        /// </summary>
        internal bool IsSetPoolName() => this.PoolName != null;

        /// <summary>
        /// Gets and sets the property PoolSize. 
        /// <para>
        /// The size of the video stream pool in the configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? PoolSize { get; set; }

        /// <summary>
        /// Checks to see if the PoolSize property is set.
        /// </summary>
        internal bool IsSetPoolSize() => this.PoolSize.HasValue;

        /// <summary>
        /// Gets and sets the property PoolStatus. 
        /// <para>
        /// The status of the video stream pool in the configuration. 
        /// </para>
        /// </summary>
        public KinesisVideoStreamPoolStatus PoolStatus { get; set; }

        /// <summary>
        /// Checks to see if the PoolStatus property is set.
        /// </summary>
        internal bool IsSetPoolStatus() => this.PoolStatus != null;

        /// <summary>
        /// Gets and sets the property StreamConfiguration. 
        /// <para>
        /// The Kinesis video stream pool configuration object.
        /// </para>
        /// </summary>
        public KinesisVideoStreamConfiguration StreamConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the StreamConfiguration property is set.
        /// </summary>
        internal bool IsSetStreamConfiguration() => this.StreamConfiguration != null;

        /// <summary>
        /// Gets and sets the property UpdatedTimestamp. 
        /// <para>
        /// The time at which the configuration was updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedTimestamp property is set.
        /// </summary>
        internal bool IsSetUpdatedTimestamp() => this.UpdatedTimestamp.HasValue;
    }
}
