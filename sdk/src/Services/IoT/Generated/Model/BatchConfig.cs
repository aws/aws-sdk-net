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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// Configuration settings for batching.
    /// </summary>
    public partial class BatchConfig
    {
        private int? _maxBatchOpenMs;
        private int? _maxBatchSize;
        private int? _maxBatchSizeBytes;

        /// <summary>
        /// Gets and sets the property MaxBatchOpenMs. 
        /// <para>
        /// The maximum amount of time (in milliseconds) that an outgoing call waits for other
        /// calls with which it batches messages of the same type. The higher the setting, the
        /// longer the latency of the batched HTTP Action will be.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=200)]
        public int? MaxBatchOpenMs
        {
            get { return this._maxBatchOpenMs; }
            set { this._maxBatchOpenMs = value; }
        }

        // Check to see if MaxBatchOpenMs property is set
        internal bool IsSetMaxBatchOpenMs()
        {
            return this._maxBatchOpenMs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxBatchSize. 
        /// <para>
        /// The maximum number of messages that are batched together in a single action execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=10)]
        public int? MaxBatchSize
        {
            get { return this._maxBatchSize; }
            set { this._maxBatchSize = value; }
        }

        // Check to see if MaxBatchSize property is set
        internal bool IsSetMaxBatchSize()
        {
            return this._maxBatchSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxBatchSizeBytes. 
        /// <para>
        /// Maximum size of a message batch, in bytes.
        /// </para>
        /// </summary>
        [AWSProperty(Min=100, Max=131072)]
        public int? MaxBatchSizeBytes
        {
            get { return this._maxBatchSizeBytes; }
            set { this._maxBatchSizeBytes = value; }
        }

        // Check to see if MaxBatchSizeBytes property is set
        internal bool IsSetMaxBatchSizeBytes()
        {
            return this._maxBatchSizeBytes.HasValue; 
        }

    }
}