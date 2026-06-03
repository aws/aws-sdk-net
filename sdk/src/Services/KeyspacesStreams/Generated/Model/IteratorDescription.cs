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
 * Do not modify this file. This file is generated from the keyspacesstreams-2024-09-09.normal.json service model.
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
namespace Amazon.KeyspacesStreams.Model
{
    /// <summary>
    /// Provides information about the current iterator.
    /// </summary>
    public partial class IteratorDescription
    {
        private IteratorPosition _iteratorPosition;

        /// <summary>
        /// Gets and sets the property IteratorPosition. 
        /// <para>
        ///  Indicates the current iterator's position within the shard. The possible values are:
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AT_TIP</c> - No more records are currently available.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BEHIND_TIP</c> - Additional records may be available.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Stream progresses in absence of customer records. <c>BEHIND_TIP</c> with an empty
        /// <c>changeRecords</c> list indicates the stream is progressing but no customer records
        /// are available at this position. Continue polling normally.
        /// </para>
        /// </summary>
        public IteratorPosition IteratorPosition
        {
            get { return this._iteratorPosition; }
            set { this._iteratorPosition = value; }
        }

        // Check to see if IteratorPosition property is set
        internal bool IsSetIteratorPosition()
        {
            return this._iteratorPosition != null;
        }

    }
}