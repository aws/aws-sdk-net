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
 * Do not modify this file. This file is generated from the emr-serverless-2021-07-13.normal.json service model.
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
namespace Amazon.EMRServerless.Model
{
    /// <summary>
    /// The initial capacity configuration per worker.
    /// </summary>
    public partial class InitialCapacityConfig
    {
        private WorkerResourceConfig _workerConfiguration;
        private long? _workerCount;

        /// <summary>
        /// Gets and sets the property WorkerConfiguration. 
        /// <para>
        /// The resource configuration of the initial capacity configuration.
        /// </para>
        /// </summary>
        public WorkerResourceConfig WorkerConfiguration
        {
            get { return this._workerConfiguration; }
            set { this._workerConfiguration = value; }
        }

        // Check to see if WorkerConfiguration property is set
        internal bool IsSetWorkerConfiguration()
        {
            return this._workerConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property WorkerCount. 
        /// <para>
        /// The number of workers in the initial capacity configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1000000)]
        public long? WorkerCount
        {
            get { return this._workerCount; }
            set { this._workerCount = value; }
        }

        // Check to see if WorkerCount property is set
        internal bool IsSetWorkerCount()
        {
            return this._workerCount.HasValue; 
        }

    }
}