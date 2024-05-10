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
    /// The <c>segmentation_descriptor</c> message can contain advanced metadata fields, like
    /// content identifiers, to convey a wide range of information about the ad break. MediaTailor
    /// writes the ad metadata in the egress manifest as part of the <c>EXT-X-DATERANGE</c>
    /// or <c>EventStream</c> ad marker's SCTE-35 data.
    /// 
    ///  
    /// <para>
    ///  <c>segmentation_descriptor</c> messages must be sent with the <c>time_signal</c>
    /// message type.
    /// </para>
    ///  
    /// <para>
    /// See the <c>segmentation_descriptor()</c> table of the 2022 SCTE-35 specification for
    /// more information.
    /// </para>
    /// </summary>
    public partial class SegmentationDescriptor
    {
        private int? _segmentationEventId;
        private int? _segmentationTypeId;
        private string _segmentationUpid;
        private int? _segmentationUpidType;
        private int? _segmentNum;
        private int? _segmentsExpected;
        private int? _subSegmentNum;
        private int? _subSegmentsExpected;

        /// <summary>
        /// Gets and sets the property SegmentationEventId. 
        /// <para>
        /// The Event Identifier to assign to the <c>segmentation_descriptor.segmentation_event_id</c>
        /// message, as defined in section 10.3.3.1 of the 2022 SCTE-35 specification. The default
        /// value is 1.
        /// </para>
        /// </summary>
        public int? SegmentationEventId
        {
            get { return this._segmentationEventId; }
            set { this._segmentationEventId = value; }
        }

        // Check to see if SegmentationEventId property is set
        internal bool IsSetSegmentationEventId()
        {
            return this._segmentationEventId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SegmentationTypeId. 
        /// <para>
        /// The Type Identifier to assign to the <c>segmentation_descriptor.segmentation_type_id</c>
        /// message, as defined in section 10.3.3.1 of the 2022 SCTE-35 specification. Values
        /// must be between 0 and 256, inclusive. The default value is 48.
        /// </para>
        /// </summary>
        public int? SegmentationTypeId
        {
            get { return this._segmentationTypeId; }
            set { this._segmentationTypeId = value; }
        }

        // Check to see if SegmentationTypeId property is set
        internal bool IsSetSegmentationTypeId()
        {
            return this._segmentationTypeId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SegmentationUpid. 
        /// <para>
        /// The Upid to assign to the <c>segmentation_descriptor.segmentation_upid</c> message,
        /// as defined in section 10.3.3.1 of the 2022 SCTE-35 specification. The value must be
        /// a hexadecimal string containing only the characters 0 though 9 and A through F. The
        /// default value is "" (an empty string).
        /// </para>
        /// </summary>
        public string SegmentationUpid
        {
            get { return this._segmentationUpid; }
            set { this._segmentationUpid = value; }
        }

        // Check to see if SegmentationUpid property is set
        internal bool IsSetSegmentationUpid()
        {
            return this._segmentationUpid != null;
        }

        /// <summary>
        /// Gets and sets the property SegmentationUpidType. 
        /// <para>
        /// The Upid Type to assign to the <c>segmentation_descriptor.segmentation_upid_type</c>
        /// message, as defined in section 10.3.3.1 of the 2022 SCTE-35 specification. Values
        /// must be between 0 and 256, inclusive. The default value is 14.
        /// </para>
        /// </summary>
        public int? SegmentationUpidType
        {
            get { return this._segmentationUpidType; }
            set { this._segmentationUpidType = value; }
        }

        // Check to see if SegmentationUpidType property is set
        internal bool IsSetSegmentationUpidType()
        {
            return this._segmentationUpidType.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SegmentNum. 
        /// <para>
        /// The segment number to assign to the <c>segmentation_descriptor.segment_num</c> message,
        /// as defined in section 10.3.3.1 of the 2022 SCTE-35 specification Values must be between
        /// 0 and 256, inclusive. The default value is 0.
        /// </para>
        /// </summary>
        public int? SegmentNum
        {
            get { return this._segmentNum; }
            set { this._segmentNum = value; }
        }

        // Check to see if SegmentNum property is set
        internal bool IsSetSegmentNum()
        {
            return this._segmentNum.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SegmentsExpected. 
        /// <para>
        /// The number of segments expected, which is assigned to the <c>segmentation_descriptor.segments_expectedS</c>
        /// message, as defined in section 10.3.3.1 of the 2022 SCTE-35 specification Values must
        /// be between 0 and 256, inclusive. The default value is 0.
        /// </para>
        /// </summary>
        public int? SegmentsExpected
        {
            get { return this._segmentsExpected; }
            set { this._segmentsExpected = value; }
        }

        // Check to see if SegmentsExpected property is set
        internal bool IsSetSegmentsExpected()
        {
            return this._segmentsExpected.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SubSegmentNum. 
        /// <para>
        /// The sub-segment number to assign to the <c>segmentation_descriptor.sub_segment_num</c>
        /// message, as defined in section 10.3.3.1 of the 2022 SCTE-35 specification. Values
        /// must be between 0 and 256, inclusive. The defualt value is null.
        /// </para>
        /// </summary>
        public int? SubSegmentNum
        {
            get { return this._subSegmentNum; }
            set { this._subSegmentNum = value; }
        }

        // Check to see if SubSegmentNum property is set
        internal bool IsSetSubSegmentNum()
        {
            return this._subSegmentNum.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SubSegmentsExpected. 
        /// <para>
        /// The number of sub-segments expected, which is assigned to the <c>segmentation_descriptor.sub_segments_expected</c>
        /// message, as defined in section 10.3.3.1 of the 2022 SCTE-35 specification. Values
        /// must be between 0 and 256, inclusive. The default value is null.
        /// </para>
        /// </summary>
        public int? SubSegmentsExpected
        {
            get { return this._subSegmentsExpected; }
            set { this._subSegmentsExpected = value; }
        }

        // Check to see if SubSegmentsExpected property is set
        internal bool IsSetSubSegmentsExpected()
        {
            return this._subSegmentsExpected.HasValue; 
        }

    }
}