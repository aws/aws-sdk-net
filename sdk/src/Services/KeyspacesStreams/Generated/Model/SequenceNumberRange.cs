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
    /// Defines a range of sequence numbers within a change data capture stream's shard for
    /// Amazon Keyspaces.
    /// </summary>
    public partial class SequenceNumberRange
    {
        private string _endingSequenceNumber;
        private string _startingSequenceNumber;

        /// <summary>
        /// Gets and sets the property EndingSequenceNumber. 
        /// <para>
        /// The ending sequence number of the range, which may be null for open-ended ranges.
        /// </para>
        /// </summary>
        [AWSProperty(Min=21, Max=48)]
        public string EndingSequenceNumber
        {
            get { return this._endingSequenceNumber; }
            set { this._endingSequenceNumber = value; }
        }

        // Check to see if EndingSequenceNumber property is set
        internal bool IsSetEndingSequenceNumber()
        {
            return this._endingSequenceNumber != null;
        }

        /// <summary>
        /// Gets and sets the property StartingSequenceNumber. 
        /// <para>
        /// The starting sequence number of the range.
        /// </para>
        /// </summary>
        [AWSProperty(Min=21, Max=48)]
        public string StartingSequenceNumber
        {
            get { return this._startingSequenceNumber; }
            set { this._startingSequenceNumber = value; }
        }

        // Check to see if StartingSequenceNumber property is set
        internal bool IsSetStartingSequenceNumber()
        {
            return this._startingSequenceNumber != null;
        }

    }
}