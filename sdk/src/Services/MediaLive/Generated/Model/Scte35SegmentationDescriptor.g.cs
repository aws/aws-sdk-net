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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Corresponds to SCTE-35 segmentation_descriptor.
    /// </summary>
    public partial class Scte35SegmentationDescriptor
    {
        /// <summary>
        /// Gets and sets the property DeliveryRestrictions. Holds the four SCTE-35 delivery restriction
        /// parameters.
        /// </summary>
        public Scte35DeliveryRestrictions DeliveryRestrictions { get; set; }

        /// <summary>
        /// Checks to see if the DeliveryRestrictions property is set.
        /// </summary>
        internal bool IsSetDeliveryRestrictions() => this.DeliveryRestrictions != null;

        /// <summary>
        /// Gets and sets the property SegmentNum. Corresponds to SCTE-35 segment_num. A value
        /// that is valid for the specified segmentation_type_id.
        /// </summary>
        public int? SegmentNum { get; set; }

        /// <summary>
        /// Checks to see if the SegmentNum property is set.
        /// </summary>
        internal bool IsSetSegmentNum() => this.SegmentNum.HasValue;

        /// <summary>
        /// Gets and sets the property SegmentationCancelIndicator. Corresponds to SCTE-35 segmentation_event_cancel_indicator.
        /// </summary>
        [AWSProperty(Required = true)]
        public Scte35SegmentationCancelIndicator SegmentationCancelIndicator { get; set; }

        /// <summary>
        /// Checks to see if the SegmentationCancelIndicator property is set.
        /// </summary>
        internal bool IsSetSegmentationCancelIndicator() => this.SegmentationCancelIndicator != null;

        /// <summary>
        /// Gets and sets the property SegmentationDuration. Corresponds to SCTE-35 segmentation_duration.
        /// Optional. The duration for the time_signal, in 90 KHz ticks. To convert seconds to
        /// ticks, multiple the seconds by 90,000. Enter time in 90 KHz clock ticks. If you do
        /// not enter a duration, the time_signal will continue until you insert a cancellation
        /// message.
        /// </summary>
        public long? SegmentationDuration { get; set; }

        /// <summary>
        /// Checks to see if the SegmentationDuration property is set.
        /// </summary>
        internal bool IsSetSegmentationDuration() => this.SegmentationDuration.HasValue;

        /// <summary>
        /// Gets and sets the property SegmentationEventId. Corresponds to SCTE-35 segmentation_event_id.
        /// </summary>
        [AWSProperty(Required = true)]
        public long? SegmentationEventId { get; set; }

        /// <summary>
        /// Checks to see if the SegmentationEventId property is set.
        /// </summary>
        internal bool IsSetSegmentationEventId() => this.SegmentationEventId.HasValue;

        /// <summary>
        /// Gets and sets the property SegmentationTypeId. Corresponds to SCTE-35 segmentation_type_id.
        /// One of the segmentation_type_id values listed in the SCTE-35 specification. On the
        /// console, enter the ID in decimal (for example, "52"). In the CLI, API, or an SDK,
        /// enter the ID in hex (for example, "0x34") or decimal (for example, "52").
        /// </summary>
        public int? SegmentationTypeId { get; set; }

        /// <summary>
        /// Checks to see if the SegmentationTypeId property is set.
        /// </summary>
        internal bool IsSetSegmentationTypeId() => this.SegmentationTypeId.HasValue;

        /// <summary>
        /// Gets and sets the property SegmentationUpid. Corresponds to SCTE-35 segmentation_upid.
        /// Enter a string containing the hexadecimal representation of the characters that make
        /// up the SCTE-35 segmentation_upid value. Must contain an even number of hex characters.
        /// Do not include spaces between each hex pair. For example, the ASCII "ADS Information"
        /// becomes hex "41445320496e666f726d6174696f6e.
        /// </summary>
        public string SegmentationUpid { get; set; }

        /// <summary>
        /// Checks to see if the SegmentationUpid property is set.
        /// </summary>
        internal bool IsSetSegmentationUpid() => this.SegmentationUpid != null;

        /// <summary>
        /// Gets and sets the property SegmentationUpidType. Corresponds to SCTE-35 segmentation_upid_type.
        /// On the console, enter one of the types listed in the SCTE-35 specification, converted
        /// to a decimal. For example, "0x0C" hex from the specification is "12" in decimal. In
        /// the CLI, API, or an SDK, enter one of the types listed in the SCTE-35 specification,
        /// in either hex (for example, "0x0C" ) or in decimal (for example, "12").
        /// </summary>
        public int? SegmentationUpidType { get; set; }

        /// <summary>
        /// Checks to see if the SegmentationUpidType property is set.
        /// </summary>
        internal bool IsSetSegmentationUpidType() => this.SegmentationUpidType.HasValue;

        /// <summary>
        /// Gets and sets the property SegmentsExpected. Corresponds to SCTE-35 segments_expected.
        /// A value that is valid for the specified segmentation_type_id.
        /// </summary>
        public int? SegmentsExpected { get; set; }

        /// <summary>
        /// Checks to see if the SegmentsExpected property is set.
        /// </summary>
        internal bool IsSetSegmentsExpected() => this.SegmentsExpected.HasValue;

        /// <summary>
        /// Gets and sets the property SubSegmentNum. Corresponds to SCTE-35 sub_segment_num.
        /// A value that is valid for the specified segmentation_type_id.
        /// </summary>
        public int? SubSegmentNum { get; set; }

        /// <summary>
        /// Checks to see if the SubSegmentNum property is set.
        /// </summary>
        internal bool IsSetSubSegmentNum() => this.SubSegmentNum.HasValue;

        /// <summary>
        /// Gets and sets the property SubSegmentsExpected. Corresponds to SCTE-35 sub_segments_expected.
        /// A value that is valid for the specified segmentation_type_id.
        /// </summary>
        public int? SubSegmentsExpected { get; set; }

        /// <summary>
        /// Checks to see if the SubSegmentsExpected property is set.
        /// </summary>
        internal bool IsSetSubSegmentsExpected() => this.SubSegmentsExpected.HasValue;
    }
}
