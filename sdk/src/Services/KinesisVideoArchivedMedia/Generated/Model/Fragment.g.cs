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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.KinesisVideoArchivedMedia.Model
{
    /// <summary>
    /// Represents a segment of video or other time-delimited data.
    /// </summary>
    public partial class Fragment
    {
        /// <summary>
        /// Gets and sets the property FragmentLengthInMilliseconds. 
        /// <para>
        /// The playback duration or other time value associated with the fragment.
        /// </para>
        /// </summary>
        public long? FragmentLengthInMilliseconds { get; set; }

        /// <summary>
        /// Checks to see if the FragmentLengthInMilliseconds property is set.
        /// </summary>
        internal bool IsSetFragmentLengthInMilliseconds() => this.FragmentLengthInMilliseconds.HasValue;

        /// <summary>
        /// Gets and sets the property FragmentNumber. 
        /// <para>
        /// The unique identifier of the fragment. This value monotonically increases based on
        /// the ingestion order.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string FragmentNumber { get; set; }

        /// <summary>
        /// Checks to see if the FragmentNumber property is set.
        /// </summary>
        internal bool IsSetFragmentNumber() => this.FragmentNumber != null;

        /// <summary>
        /// Gets and sets the property FragmentSizeInBytes. 
        /// <para>
        /// The total fragment size, including information about the fragment and contained media
        /// data.
        /// </para>
        /// </summary>
        public long? FragmentSizeInBytes { get; set; }

        /// <summary>
        /// Checks to see if the FragmentSizeInBytes property is set.
        /// </summary>
        internal bool IsSetFragmentSizeInBytes() => this.FragmentSizeInBytes.HasValue;

        /// <summary>
        /// Gets and sets the property ProducerTimestamp. 
        /// <para>
        /// The timestamp from the producer corresponding to the fragment.
        /// </para>
        /// </summary>
        public DateTime? ProducerTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the ProducerTimestamp property is set.
        /// </summary>
        internal bool IsSetProducerTimestamp() => this.ProducerTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property ServerTimestamp. 
        /// <para>
        /// The timestamp from the Amazon Web Services server corresponding to the fragment.
        /// </para>
        /// </summary>
        public DateTime? ServerTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the ServerTimestamp property is set.
        /// </summary>
        internal bool IsSetServerTimestamp() => this.ServerTimestamp.HasValue;
    }
}
