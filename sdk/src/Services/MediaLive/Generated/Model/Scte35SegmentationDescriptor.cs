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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Corresponds to SCTE-35 segmentation_descriptor.
    /// </summary>
    public partial class Scte35SegmentationDescriptor
    {
        private Scte35DeliveryRestrictions _deliveryRestrictions;
        private Scte35SegmentationCancelIndicator _segmentationCancelIndicator;
        private long? _segmentationDuration;
        private long? _segmentationEventId;
        private int? _segmentationTypeId;
        private string _segmentationUpid;
        private int? _segmentationUpidType;
        private int? _segmentNum;
        private int? _segmentsExpected;
        private int? _subSegmentNum;
        private int? _subSegmentsExpected;

        /// <summary>
        /// Gets and sets the property DeliveryRestrictions. Holds the four SCTE-35 delivery restriction
        /// parameters.
        /// </summary>
        public Scte35DeliveryRestrictions DeliveryRestrictions
        {
            get { return this._deliveryRestrictions; }
            set { this._deliveryRestrictions = value; }
        }

        // Check to see if DeliveryRestrictions property is set
        internal bool IsSetDeliveryRestrictions()
        {
            return this._deliveryRestrictions != null;
        }

        /// <summary>
        /// Gets and sets the property SegmentationCancelIndicator. Corresponds to SCTE-35 segmentation_event_cancel_indicator.
        /// </summary>
        [AWSProperty(Required=true)]
        public Scte35SegmentationCancelIndicator SegmentationCancelIndicator
        {
            get { return this._segmentationCancelIndicator; }
            set { this._segmentationCancelIndicator = value; }
        }

        // Check to see if SegmentationCancelIndicator property is set
        internal bool IsSetSegmentationCancelIndicator()
        {
            return this._segmentationCancelIndicator != null;
        }

        /// <summary>
        /// Gets and sets the property SegmentationDuration. Corresponds to SCTE-35 segmentation_duration.
        /// Optional. The duration for the time_signal, in 90 KHz ticks. To convert seconds to
        /// ticks, multiple the seconds by 90,000. Enter time in 90 KHz clock ticks. If you do
        /// not enter a duration, the time_signal will continue until you insert a cancellation
        /// message.
        /// </summary>
        [AWSProperty(Min=0, Max=1099511627775)]
        public long? SegmentationDuration
        {
            get { return this._segmentationDuration; }
            set { this._segmentationDuration = value; }
        }

        // Check to see if SegmentationDuration property is set
        internal bool IsSetSegmentationDuration()
        {
            return this._segmentationDuration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SegmentationEventId. Corresponds to SCTE-35 segmentation_event_id.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=4294967295)]
        public long? SegmentationEventId
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
        /// Gets and sets the property SegmentationTypeId. Corresponds to SCTE-35 segmentation_type_id.
        /// One of the segmentation_type_id values listed in the SCTE-35 specification. On the
        /// console, enter the ID in decimal (for example, "52"). In the CLI, API, or an SDK,
        /// enter the ID in hex (for example, "0x34") or decimal (for example, "52").
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
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
        /// Gets and sets the property SegmentationUpid. Corresponds to SCTE-35 segmentation_upid.
        /// Enter a string containing the hexadecimal representation of the characters that make
        /// up the SCTE-35 segmentation_upid value. Must contain an even number of hex characters.
        /// Do not include spaces between each hex pair. For example, the ASCII "ADS Information"
        /// becomes hex "41445320496e666f726d6174696f6e.
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
        /// Gets and sets the property SegmentationUpidType. Corresponds to SCTE-35 segmentation_upid_type.
        /// On the console, enter one of the types listed in the SCTE-35 specification, converted
        /// to a decimal. For example, "0x0C" hex from the specification is "12" in decimal. In
        /// the CLI, API, or an SDK, enter one of the types listed in the SCTE-35 specification,
        /// in either hex (for example, "0x0C" ) or in decimal (for example, "12").
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
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
        /// Gets and sets the property SegmentNum. Corresponds to SCTE-35 segment_num. A value
        /// that is valid for the specified segmentation_type_id.
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
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
        /// Gets and sets the property SegmentsExpected. Corresponds to SCTE-35 segments_expected.
        /// A value that is valid for the specified segmentation_type_id.
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
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
        /// Gets and sets the property SubSegmentNum. Corresponds to SCTE-35 sub_segment_num.
        /// A value that is valid for the specified segmentation_type_id.
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
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
        /// Gets and sets the property SubSegmentsExpected. Corresponds to SCTE-35 sub_segments_expected.
        /// A value that is valid for the specified segmentation_type_id.
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
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