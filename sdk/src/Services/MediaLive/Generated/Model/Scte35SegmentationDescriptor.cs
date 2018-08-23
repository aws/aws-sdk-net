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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// SCTE-35 Segmentation Descriptor.
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
        /// Gets and sets the property DeliveryRestrictions. SCTE-35 delivery restrictions.
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
        /// Gets and sets the property SegmentationCancelIndicator. SCTE-35 segmentation_descriptor
        /// segmentation_event_cancel_indicator.
        /// </summary>
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
        /// Gets and sets the property SegmentationDuration. SCTE-35 segmentation_descriptor segmentation_duration
        /// specified in 90 KHz clock ticks.
        /// </summary>
        public long SegmentationDuration
        {
            get { return this._segmentationDuration.GetValueOrDefault(); }
            set { this._segmentationDuration = value; }
        }

        // Check to see if SegmentationDuration property is set
        internal bool IsSetSegmentationDuration()
        {
            return this._segmentationDuration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SegmentationEventId. SCTE-35 segmentation_descriptor segmentation_event_id.
        /// </summary>
        public long SegmentationEventId
        {
            get { return this._segmentationEventId.GetValueOrDefault(); }
            set { this._segmentationEventId = value; }
        }

        // Check to see if SegmentationEventId property is set
        internal bool IsSetSegmentationEventId()
        {
            return this._segmentationEventId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SegmentationTypeId. SCTE-35 segmentation_descriptor segmentation_type_id.
        /// </summary>
        public int SegmentationTypeId
        {
            get { return this._segmentationTypeId.GetValueOrDefault(); }
            set { this._segmentationTypeId = value; }
        }

        // Check to see if SegmentationTypeId property is set
        internal bool IsSetSegmentationTypeId()
        {
            return this._segmentationTypeId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SegmentationUpid. SCTE-35 segmentation_descriptor segmentation_upid
        /// as a hex string.
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
        /// Gets and sets the property SegmentationUpidType. SCTE-35 segmentation_descriptor segmentation_upid_type.
        /// </summary>
        public int SegmentationUpidType
        {
            get { return this._segmentationUpidType.GetValueOrDefault(); }
            set { this._segmentationUpidType = value; }
        }

        // Check to see if SegmentationUpidType property is set
        internal bool IsSetSegmentationUpidType()
        {
            return this._segmentationUpidType.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SegmentNum. SCTE-35 segmentation_descriptor segment_num.
        /// </summary>
        public int SegmentNum
        {
            get { return this._segmentNum.GetValueOrDefault(); }
            set { this._segmentNum = value; }
        }

        // Check to see if SegmentNum property is set
        internal bool IsSetSegmentNum()
        {
            return this._segmentNum.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SegmentsExpected. SCTE-35 segmentation_descriptor segments_expected.
        /// </summary>
        public int SegmentsExpected
        {
            get { return this._segmentsExpected.GetValueOrDefault(); }
            set { this._segmentsExpected = value; }
        }

        // Check to see if SegmentsExpected property is set
        internal bool IsSetSegmentsExpected()
        {
            return this._segmentsExpected.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SubSegmentNum. SCTE-35 segmentation_descriptor sub_segment_num.
        /// </summary>
        public int SubSegmentNum
        {
            get { return this._subSegmentNum.GetValueOrDefault(); }
            set { this._subSegmentNum = value; }
        }

        // Check to see if SubSegmentNum property is set
        internal bool IsSetSubSegmentNum()
        {
            return this._subSegmentNum.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SubSegmentsExpected. SCTE-35 segmentation_descriptor sub_segments_expected.
        /// </summary>
        public int SubSegmentsExpected
        {
            get { return this._subSegmentsExpected.GetValueOrDefault(); }
            set { this._subSegmentsExpected = value; }
        }

        // Check to see if SubSegmentsExpected property is set
        internal bool IsSetSubSegmentsExpected()
        {
            return this._subSegmentsExpected.HasValue; 
        }

    }
}