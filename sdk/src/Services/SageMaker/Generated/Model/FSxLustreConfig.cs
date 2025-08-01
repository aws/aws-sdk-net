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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Configuration settings for an Amazon FSx for Lustre file system to be used with the
    /// cluster.
    /// </summary>
    public partial class FSxLustreConfig
    {
        private int? _perUnitStorageThroughput;
        private int? _sizeInGiB;

        /// <summary>
        /// Gets and sets the property PerUnitStorageThroughput. 
        /// <para>
        /// The throughput capacity of the Amazon FSx for Lustre file system, measured in MB/s
        /// per TiB of storage.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=125, Max=1000)]
        public int? PerUnitStorageThroughput
        {
            get { return this._perUnitStorageThroughput; }
            set { this._perUnitStorageThroughput = value; }
        }

        // Check to see if PerUnitStorageThroughput property is set
        internal bool IsSetPerUnitStorageThroughput()
        {
            return this._perUnitStorageThroughput.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SizeInGiB. 
        /// <para>
        /// The storage capacity of the Amazon FSx for Lustre file system, specified in gibibytes
        /// (GiB).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1200, Max=100800)]
        public int? SizeInGiB
        {
            get { return this._sizeInGiB; }
            set { this._sizeInGiB = value; }
        }

        // Check to see if SizeInGiB property is set
        internal bool IsSetSizeInGiB()
        {
            return this._sizeInGiB.HasValue; 
        }

    }
}