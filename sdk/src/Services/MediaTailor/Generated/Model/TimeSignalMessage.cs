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
 * Do not modify this file. This file is generated from the mediatailor-2018-04-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaTailor.Model
{
    /// <summary>
    /// The SCTE-35 <code>time_signal</code> message can be sent with one or more <code>segmentation_descriptor</code>
    /// messages. A <code>time_signal</code> message can be sent only if a single <code>segmentation_descriptor</code>
    /// message is sent.
    /// 
    ///  
    /// <para>
    /// The <code>time_signal</code> message contains only the <code>splice_time</code> field
    /// which is constructed using a given presentation timestamp. When sending a <code>time_signal</code>
    /// message, the <code>splice_command_type</code> field in the <code>splice_info_section</code>
    /// message is set to 6 (0x06).
    /// </para>
    ///  
    /// <para>
    /// See the <code>time_signal()</code> table of the 2022 SCTE-35 specification for more
    /// information.
    /// </para>
    /// </summary>
    public partial class TimeSignalMessage
    {
        private List<SegmentationDescriptor> _segmentationDescriptors = new List<SegmentationDescriptor>();

        /// <summary>
        /// Gets and sets the property SegmentationDescriptors. 
        /// <para>
        /// The configurations for the SCTE-35 <code>segmentation_descriptor</code> message(s)
        /// sent with the <code>time_signal</code> message.
        /// </para>
        /// </summary>
        public List<SegmentationDescriptor> SegmentationDescriptors
        {
            get { return this._segmentationDescriptors; }
            set { this._segmentationDescriptors = value; }
        }

        // Check to see if SegmentationDescriptors property is set
        internal bool IsSetSegmentationDescriptors()
        {
            return this._segmentationDescriptors != null && this._segmentationDescriptors.Count > 0; 
        }

    }
}