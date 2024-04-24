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
 * Do not modify this file. This file is generated from the kinesis-video-archived-media-2017-09-30.normal.json service model.
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
    /// Describes the timestamp range and timestamp origin of a range of fragments.
    /// 
    ///  
    /// <para>
    /// Fragments that have duplicate producer timestamps are deduplicated. This means that
    /// if producers are producing a stream of fragments with producer timestamps that are
    /// approximately equal to the true clock time, the clip will contain all of the fragments
    /// within the requested timestamp range. If some fragments are ingested within the same
    /// time range and very different points in time, only the oldest ingested collection
    /// of fragments are returned.
    /// </para>
    /// </summary>
    public partial class ClipFragmentSelector
    {
        private ClipFragmentSelectorType _fragmentSelectorType;
        private ClipTimestampRange _timestampRange;

        /// <summary>
        /// Gets and sets the property FragmentSelectorType. 
        /// <para>
        /// The origin of the timestamps to use (Server or Producer).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ClipFragmentSelectorType FragmentSelectorType
        {
            get { return this._fragmentSelectorType; }
            set { this._fragmentSelectorType = value; }
        }

        // Check to see if FragmentSelectorType property is set
        internal bool IsSetFragmentSelectorType()
        {
            return this._fragmentSelectorType != null;
        }

        /// <summary>
        /// Gets and sets the property TimestampRange. 
        /// <para>
        /// The range of timestamps to return.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ClipTimestampRange TimestampRange
        {
            get { return this._timestampRange; }
            set { this._timestampRange = value; }
        }

        // Check to see if TimestampRange property is set
        internal bool IsSetTimestampRange()
        {
            return this._timestampRange != null;
        }

    }
}