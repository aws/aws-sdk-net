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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.MediaTailor.Model
{
    /// <summary>
    /// The SCTE-35 <c>time_signal</c> message can be sent with one or more <c>segmentation_descriptor</c>
    /// messages. A <c>time_signal</c> message can be sent only if a single <c>segmentation_descriptor</c>
    /// message is sent.
    /// 
    ///  
    /// <para>
    /// The <c>time_signal</c> message contains only the <c>splice_time</c> field which is
    /// constructed using a given presentation timestamp. When sending a <c>time_signal</c>
    /// message, the <c>splice_command_type</c> field in the <c>splice_info_section</c> message
    /// is set to 6 (0x06).
    /// </para>
    ///  
    /// <para>
    /// See the <c>time_signal()</c> table of the 2022 SCTE-35 specification for more information.
    /// </para>
    /// </summary>
    public partial class TimeSignalMessage
    {
        private List<SegmentationDescriptor> _segmentationDescriptors = AWSConfigs.InitializeCollections ? new List<SegmentationDescriptor>() : null;

        /// <summary>
        /// Gets and sets the property SegmentationDescriptors. 
        /// <para>
        /// The configurations for the SCTE-35 <c>segmentation_descriptor</c> message(s) sent
        /// with the <c>time_signal</c> message.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SegmentationDescriptor> SegmentationDescriptors
        {
            get { return this._segmentationDescriptors; }
            set { this._segmentationDescriptors = value; }
        }

        // Check to see if SegmentationDescriptors property is set
        internal bool IsSetSegmentationDescriptors()
        {
            return this._segmentationDescriptors != null && (this._segmentationDescriptors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}