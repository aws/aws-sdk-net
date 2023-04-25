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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DataSync.Model
{
    /// <summary>
    /// The storage capacity of an on-premises storage system resource (for example, a volume).
    /// </summary>
    public partial class Capacity
    {
        private long? _logicalUsed;
        private long? _provisioned;
        private long? _used;

        /// <summary>
        /// Gets and sets the property LogicalUsed. 
        /// <para>
        /// The amount of space that's being used in a storage system resource without accounting
        /// for compression or deduplication.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long LogicalUsed
        {
            get { return this._logicalUsed.GetValueOrDefault(); }
            set { this._logicalUsed = value; }
        }

        // Check to see if LogicalUsed property is set
        internal bool IsSetLogicalUsed()
        {
            return this._logicalUsed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Provisioned. 
        /// <para>
        /// The total amount of space available in a storage system resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long Provisioned
        {
            get { return this._provisioned.GetValueOrDefault(); }
            set { this._provisioned = value; }
        }

        // Check to see if Provisioned property is set
        internal bool IsSetProvisioned()
        {
            return this._provisioned.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Used. 
        /// <para>
        /// The amount of space that's being used in a storage system resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long Used
        {
            get { return this._used.GetValueOrDefault(); }
            set { this._used = value; }
        }

        // Check to see if Used property is set
        internal bool IsSetUsed()
        {
            return this._used.HasValue; 
        }

    }
}