/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the elastic-inference-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticInference.Model
{
    /// <summary>
    /// The details of an Elastic Inference Accelerator type.
    /// </summary>
    public partial class AcceleratorType
    {
        private string _acceleratorTypeName;
        private MemoryInfo _memoryInfo;
        private List<KeyValuePair> _throughputInfo = new List<KeyValuePair>();

        /// <summary>
        /// Gets and sets the property AcceleratorTypeName. 
        /// <para>
        ///  The name of the Elastic Inference Accelerator type. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string AcceleratorTypeName
        {
            get { return this._acceleratorTypeName; }
            set { this._acceleratorTypeName = value; }
        }

        // Check to see if AcceleratorTypeName property is set
        internal bool IsSetAcceleratorTypeName()
        {
            return this._acceleratorTypeName != null;
        }

        /// <summary>
        /// Gets and sets the property MemoryInfo. 
        /// <para>
        ///  The memory information of the Elastic Inference Accelerator type. 
        /// </para>
        /// </summary>
        public MemoryInfo MemoryInfo
        {
            get { return this._memoryInfo; }
            set { this._memoryInfo = value; }
        }

        // Check to see if MemoryInfo property is set
        internal bool IsSetMemoryInfo()
        {
            return this._memoryInfo != null;
        }

        /// <summary>
        /// Gets and sets the property ThroughputInfo. 
        /// <para>
        ///  The throughput information of the Elastic Inference Accelerator type. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<KeyValuePair> ThroughputInfo
        {
            get { return this._throughputInfo; }
            set { this._throughputInfo = value; }
        }

        // Check to see if ThroughputInfo property is set
        internal bool IsSetThroughputInfo()
        {
            return this._throughputInfo != null && this._throughputInfo.Count > 0; 
        }

    }
}