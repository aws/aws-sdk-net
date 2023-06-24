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
 * Do not modify this file. This file is generated from the timestream-write-2018-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.TimestreamWrite.Model
{
    /// <summary>
    /// Retention properties contain the duration for which your time-series data must be
    /// stored in the magnetic store and the memory store.
    /// </summary>
    public partial class RetentionProperties
    {
        private long? _magneticStoreRetentionPeriodInDays;
        private long? _memoryStoreRetentionPeriodInHours;

        /// <summary>
        /// Gets and sets the property MagneticStoreRetentionPeriodInDays. 
        /// <para>
        /// The duration for which data must be stored in the magnetic store. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=73000)]
        public long MagneticStoreRetentionPeriodInDays
        {
            get { return this._magneticStoreRetentionPeriodInDays.GetValueOrDefault(); }
            set { this._magneticStoreRetentionPeriodInDays = value; }
        }

        // Check to see if MagneticStoreRetentionPeriodInDays property is set
        internal bool IsSetMagneticStoreRetentionPeriodInDays()
        {
            return this._magneticStoreRetentionPeriodInDays.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MemoryStoreRetentionPeriodInHours. 
        /// <para>
        /// The duration for which data must be stored in the memory store. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=8766)]
        public long MemoryStoreRetentionPeriodInHours
        {
            get { return this._memoryStoreRetentionPeriodInHours.GetValueOrDefault(); }
            set { this._memoryStoreRetentionPeriodInHours = value; }
        }

        // Check to see if MemoryStoreRetentionPeriodInHours property is set
        internal bool IsSetMemoryStoreRetentionPeriodInHours()
        {
            return this._memoryStoreRetentionPeriodInHours.HasValue; 
        }

    }
}