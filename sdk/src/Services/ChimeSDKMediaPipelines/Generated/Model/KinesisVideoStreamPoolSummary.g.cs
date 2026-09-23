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
    /// A summary of the Kinesis video stream pool.
    /// </summary>
    public partial class KinesisVideoStreamPoolSummary
    {
        /// <summary>
        /// Gets and sets the property PoolArn. 
        /// <para>
        /// The ARN of the video stream pool.
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
        /// The ID of the video stream pool.
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
        /// The name of the video stream pool.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string PoolName { get; set; }

        /// <summary>
        /// Checks to see if the PoolName property is set.
        /// </summary>
        internal bool IsSetPoolName() => this.PoolName != null;
    }
}
