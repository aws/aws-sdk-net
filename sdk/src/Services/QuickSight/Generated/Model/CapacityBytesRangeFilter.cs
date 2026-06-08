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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A filter that matches users by total capacity range in bytes.
    /// </summary>
    public partial class CapacityBytesRangeFilter
    {
        private long? _maxBytes;
        private long? _minBytes;

        /// <summary>
        /// Gets and sets the property MaxBytes. 
        /// <para>
        /// The maximum capacity in bytes (inclusive). At least one of minBytes or maxBytes is
        /// required.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public long? MaxBytes
        {
            get { return this._maxBytes; }
            set { this._maxBytes = value; }
        }

        // Check to see if MaxBytes property is set
        internal bool IsSetMaxBytes()
        {
            return this._maxBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinBytes. 
        /// <para>
        /// The minimum capacity in bytes (inclusive). At least one of minBytes or maxBytes is
        /// required.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public long? MinBytes
        {
            get { return this._minBytes; }
            set { this._minBytes = value; }
        }

        // Check to see if MinBytes property is set
        internal bool IsSetMinBytes()
        {
            return this._minBytes.HasValue; 
        }

    }
}