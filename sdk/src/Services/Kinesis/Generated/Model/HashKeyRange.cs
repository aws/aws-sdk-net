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
 * Do not modify this file. This file is generated from the kinesis-2013-12-02.normal.json service model.
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
namespace Amazon.Kinesis.Model
{
    /// <summary>
    /// The range of possible hash key values for the shard, which is a set of ordered contiguous
    /// positive integers.
    /// </summary>
    public partial class HashKeyRange
    {
        private string _endingHashKey;
        private string _startingHashKey;

        /// <summary>
        /// Gets and sets the property EndingHashKey. 
        /// <para>
        /// The ending hash key of the hash key range.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EndingHashKey
        {
            get { return this._endingHashKey; }
            set { this._endingHashKey = value; }
        }

        // Check to see if EndingHashKey property is set
        internal bool IsSetEndingHashKey()
        {
            return this._endingHashKey != null;
        }

        /// <summary>
        /// Gets and sets the property StartingHashKey. 
        /// <para>
        /// The starting hash key of the hash key range.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string StartingHashKey
        {
            get { return this._startingHashKey; }
            set { this._startingHashKey = value; }
        }

        // Check to see if StartingHashKey property is set
        internal bool IsSetStartingHashKey()
        {
            return this._startingHashKey != null;
        }

    }
}