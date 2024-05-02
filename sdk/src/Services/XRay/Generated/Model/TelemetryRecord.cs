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
 * Do not modify this file. This file is generated from the xray-2016-04-12.normal.json service model.
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
    /// 
    /// </summary>
    public partial class TelemetryRecord
    {
        private BackendConnectionErrors _backendConnectionErrors;
        private int? _segmentsReceivedCount;
        private int? _segmentsRejectedCount;
        private int? _segmentsSentCount;
        private int? _segmentsSpilloverCount;
        private DateTime? _timestamp;

        /// <summary>
        /// Gets and sets the property BackendConnectionErrors.
        /// </summary>
        public BackendConnectionErrors BackendConnectionErrors
        {
            get { return this._backendConnectionErrors; }
            set { this._backendConnectionErrors = value; }
        }

        // Check to see if BackendConnectionErrors property is set
        internal bool IsSetBackendConnectionErrors()
        {
            return this._backendConnectionErrors != null;
        }

        /// <summary>
        /// Gets and sets the property SegmentsReceivedCount.
        /// </summary>
        public int? SegmentsReceivedCount
        {
            get { return this._segmentsReceivedCount; }
            set { this._segmentsReceivedCount = value; }
        }

        // Check to see if SegmentsReceivedCount property is set
        internal bool IsSetSegmentsReceivedCount()
        {
            return this._segmentsReceivedCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SegmentsRejectedCount.
        /// </summary>
        public int? SegmentsRejectedCount
        {
            get { return this._segmentsRejectedCount; }
            set { this._segmentsRejectedCount = value; }
        }

        // Check to see if SegmentsRejectedCount property is set
        internal bool IsSetSegmentsRejectedCount()
        {
            return this._segmentsRejectedCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SegmentsSentCount.
        /// </summary>
        public int? SegmentsSentCount
        {
            get { return this._segmentsSentCount; }
            set { this._segmentsSentCount = value; }
        }

        // Check to see if SegmentsSentCount property is set
        internal bool IsSetSegmentsSentCount()
        {
            return this._segmentsSentCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SegmentsSpilloverCount.
        /// </summary>
        public int? SegmentsSpilloverCount
        {
            get { return this._segmentsSpilloverCount; }
            set { this._segmentsSpilloverCount = value; }
        }

        // Check to see if SegmentsSpilloverCount property is set
        internal bool IsSetSegmentsSpilloverCount()
        {
            return this._segmentsSpilloverCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Timestamp.
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? Timestamp
        {
            get { return this._timestamp; }
            set { this._timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this._timestamp.HasValue; 
        }

    }
}