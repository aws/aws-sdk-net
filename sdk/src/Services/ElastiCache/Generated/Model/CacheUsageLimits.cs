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
 * Do not modify this file. This file is generated from the elasticache-2015-02-02.normal.json service model.
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
namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// The usage limits for storage and ElastiCache Processing Units for the cache.
    /// </summary>
    public partial class CacheUsageLimits
    {
        private DataStorage _dataStorage;
        private ECPUPerSecond _ecpuPerSecond;

        /// <summary>
        /// Gets and sets the property DataStorage. 
        /// <para>
        ///  The maximum data storage limit in the cache, expressed in Gigabytes. 
        /// </para>
        /// </summary>
        public DataStorage DataStorage
        {
            get { return this._dataStorage; }
            set { this._dataStorage = value; }
        }

        // Check to see if DataStorage property is set
        internal bool IsSetDataStorage()
        {
            return this._dataStorage != null;
        }

        /// <summary>
        /// Gets and sets the property ECPUPerSecond.
        /// </summary>
        public ECPUPerSecond ECPUPerSecond
        {
            get { return this._ecpuPerSecond; }
            set { this._ecpuPerSecond = value; }
        }

        // Check to see if ECPUPerSecond property is set
        internal bool IsSetECPUPerSecond()
        {
            return this._ecpuPerSecond != null;
        }

    }
}