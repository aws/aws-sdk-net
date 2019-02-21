/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the kinesis-video-archived-media-2017-09-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisVideoArchivedMedia.Model
{
    /// <summary>
    /// Represents a segment of video or other time-delimited data.
    /// </summary>
    public partial class Fragment
    {
        private long? _fragmentLengthInMilliseconds;
        private string _fragmentNumber;
        private long? _fragmentSizeInBytes;
        private DateTime? _producerTimestamp;
        private DateTime? _serverTimestamp;

        /// <summary>
        /// Gets and sets the property FragmentLengthInMilliseconds. 
        /// <para>
        /// The playback duration or other time value associated with the fragment.
        /// </para>
        /// </summary>
        public long FragmentLengthInMilliseconds
        {
            get { return this._fragmentLengthInMilliseconds.GetValueOrDefault(); }
            set { this._fragmentLengthInMilliseconds = value; }
        }

        // Check to see if FragmentLengthInMilliseconds property is set
        internal bool IsSetFragmentLengthInMilliseconds()
        {
            return this._fragmentLengthInMilliseconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FragmentNumber. 
        /// <para>
        /// The index value of the fragment.
        /// </para>
        /// </summary>
        public string FragmentNumber
        {
            get { return this._fragmentNumber; }
            set { this._fragmentNumber = value; }
        }

        // Check to see if FragmentNumber property is set
        internal bool IsSetFragmentNumber()
        {
            return this._fragmentNumber != null;
        }

        /// <summary>
        /// Gets and sets the property FragmentSizeInBytes. 
        /// <para>
        /// The total fragment size, including information about the fragment and contained media
        /// data.
        /// </para>
        /// </summary>
        public long FragmentSizeInBytes
        {
            get { return this._fragmentSizeInBytes.GetValueOrDefault(); }
            set { this._fragmentSizeInBytes = value; }
        }

        // Check to see if FragmentSizeInBytes property is set
        internal bool IsSetFragmentSizeInBytes()
        {
            return this._fragmentSizeInBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProducerTimestamp. 
        /// <para>
        /// The timestamp from the producer corresponding to the fragment.
        /// </para>
        /// </summary>
        public DateTime ProducerTimestamp
        {
            get { return this._producerTimestamp.GetValueOrDefault(); }
            set { this._producerTimestamp = value; }
        }

        // Check to see if ProducerTimestamp property is set
        internal bool IsSetProducerTimestamp()
        {
            return this._producerTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServerTimestamp. 
        /// <para>
        /// The timestamp from the AWS server corresponding to the fragment.
        /// </para>
        /// </summary>
        public DateTime ServerTimestamp
        {
            get { return this._serverTimestamp.GetValueOrDefault(); }
            set { this._serverTimestamp = value; }
        }

        // Check to see if ServerTimestamp property is set
        internal bool IsSetServerTimestamp()
        {
            return this._serverTimestamp.HasValue; 
        }

    }
}