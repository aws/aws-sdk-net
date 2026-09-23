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

namespace Amazon.XRay.Model
{
    /// <summary>
    /// </summary>
    public partial class TelemetryRecord
    {
        /// <summary>
        /// Gets and sets the property BackendConnectionErrors. 
        /// <para>
        /// 
        /// </para>
        /// </summary>
        public BackendConnectionErrors BackendConnectionErrors { get; set; }

        /// <summary>
        /// Checks to see if the BackendConnectionErrors property is set.
        /// </summary>
        internal bool IsSetBackendConnectionErrors() => this.BackendConnectionErrors != null;

        /// <summary>
        /// Gets and sets the property SegmentsReceivedCount. 
        /// <para>
        /// 
        /// </para>
        /// </summary>
        public int? SegmentsReceivedCount { get; set; }

        /// <summary>
        /// Checks to see if the SegmentsReceivedCount property is set.
        /// </summary>
        internal bool IsSetSegmentsReceivedCount() => this.SegmentsReceivedCount.HasValue;

        /// <summary>
        /// Gets and sets the property SegmentsRejectedCount. 
        /// <para>
        /// 
        /// </para>
        /// </summary>
        public int? SegmentsRejectedCount { get; set; }

        /// <summary>
        /// Checks to see if the SegmentsRejectedCount property is set.
        /// </summary>
        internal bool IsSetSegmentsRejectedCount() => this.SegmentsRejectedCount.HasValue;

        /// <summary>
        /// Gets and sets the property SegmentsSentCount. 
        /// <para>
        /// 
        /// </para>
        /// </summary>
        public int? SegmentsSentCount { get; set; }

        /// <summary>
        /// Checks to see if the SegmentsSentCount property is set.
        /// </summary>
        internal bool IsSetSegmentsSentCount() => this.SegmentsSentCount.HasValue;

        /// <summary>
        /// Gets and sets the property SegmentsSpilloverCount. 
        /// <para>
        /// 
        /// </para>
        /// </summary>
        public int? SegmentsSpilloverCount { get; set; }

        /// <summary>
        /// Checks to see if the SegmentsSpilloverCount property is set.
        /// </summary>
        internal bool IsSetSegmentsSpilloverCount() => this.SegmentsSpilloverCount.HasValue;

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Checks to see if the Timestamp property is set.
        /// </summary>
        internal bool IsSetTimestamp() => this.Timestamp.HasValue;
    }
}
