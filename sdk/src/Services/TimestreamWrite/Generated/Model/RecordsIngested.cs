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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.TimestreamWrite.Model
{
    /// <summary>
    /// Information on the records ingested by this request.
    /// </summary>
    public partial class RecordsIngested
    {
        private int? _magneticStore;
        private int? _memoryStore;
        private int? _total;

        /// <summary>
        /// Gets and sets the property MagneticStore. 
        /// <para>
        /// Count of records ingested into the magnetic store.
        /// </para>
        /// </summary>
        public int? MagneticStore
        {
            get { return this._magneticStore; }
            set { this._magneticStore = value; }
        }

        // Check to see if MagneticStore property is set
        internal bool IsSetMagneticStore()
        {
            return this._magneticStore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MemoryStore. 
        /// <para>
        /// Count of records ingested into the memory store.
        /// </para>
        /// </summary>
        public int? MemoryStore
        {
            get { return this._memoryStore; }
            set { this._memoryStore = value; }
        }

        // Check to see if MemoryStore property is set
        internal bool IsSetMemoryStore()
        {
            return this._memoryStore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Total. 
        /// <para>
        /// Total count of successfully ingested records.
        /// </para>
        /// </summary>
        public int? Total
        {
            get { return this._total; }
            set { this._total = value; }
        }

        // Check to see if Total property is set
        internal bool IsSetTotal()
        {
            return this._total.HasValue; 
        }

    }
}