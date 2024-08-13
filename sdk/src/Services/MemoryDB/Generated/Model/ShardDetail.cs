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
 * Do not modify this file. This file is generated from the memorydb-2021-01-01.normal.json service model.
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
namespace Amazon.MemoryDB.Model
{
    /// <summary>
    /// Provides details of a shard in a snapshot
    /// </summary>
    public partial class ShardDetail
    {
        private ShardConfiguration _configuration;
        private string _name;
        private string _size;
        private DateTime? _snapshotCreationTime;

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The configuration details of the shard
        /// </para>
        /// </summary>
        public ShardConfiguration Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the shard
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Size. 
        /// <para>
        /// The size of the shard's snapshot
        /// </para>
        /// </summary>
        public string Size
        {
            get { return this._size; }
            set { this._size = value; }
        }

        // Check to see if Size property is set
        internal bool IsSetSize()
        {
            return this._size != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotCreationTime. 
        /// <para>
        /// The date and time that the shard's snapshot was created
        /// </para>
        /// </summary>
        public DateTime? SnapshotCreationTime
        {
            get { return this._snapshotCreationTime; }
            set { this._snapshotCreationTime = value; }
        }

        // Check to see if SnapshotCreationTime property is set
        internal bool IsSetSnapshotCreationTime()
        {
            return this._snapshotCreationTime.HasValue; 
        }

    }
}