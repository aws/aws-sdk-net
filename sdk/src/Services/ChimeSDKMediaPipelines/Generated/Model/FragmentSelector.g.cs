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

namespace Amazon.ChimeSDKMediaPipelines.Model
{
    /// <summary>
    /// Describes the timestamp range and timestamp origin of a range of fragments.
    /// 
    ///  
    /// <para>
    /// Only fragments with a start timestamp greater than or equal to the given start time
    /// and less than or equal to the end time are returned. For example, say a stream contains
    /// fragments with the following start timestamps:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// 00:00:00
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// 00:00:02
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// 00:00:04
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// 00:00:06
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// A fragment selector range with a start time of 00:00:01 and end time of 00:00:04 would
    /// return the fragments with start times of 00:00:02 and 00:00:04.
    /// </para>
    /// </summary>
    public partial class FragmentSelector
    {
        /// <summary>
        /// Gets and sets the property FragmentSelectorType. 
        /// <para>
        /// The origin of the timestamps to use, <c>Server</c> or <c>Producer</c>. For more information,
        /// see <a href="https://docs.aws.amazon.com/kinesisvideostreams/latest/dg/API_dataplane_StartSelector.html">StartSelectorType</a>
        /// in the <i>Amazon Kinesis Video Streams Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FragmentSelectorType FragmentSelectorType { get; set; }

        /// <summary>
        /// Checks to see if the FragmentSelectorType property is set.
        /// </summary>
        internal bool IsSetFragmentSelectorType() => this.FragmentSelectorType != null;

        /// <summary>
        /// Gets and sets the property TimestampRange. 
        /// <para>
        /// The range of timestamps to return.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TimestampRange TimestampRange { get; set; }

        /// <summary>
        /// Checks to see if the TimestampRange property is set.
        /// </summary>
        internal bool IsSetTimestampRange() => this.TimestampRange != null;
    }
}
