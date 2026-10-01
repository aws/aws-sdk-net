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

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Contains error information for a data segment association that failed.
    /// </summary>
    public partial class FailedDataSegmentAssociation
    {
        /// <summary>
        /// Gets and sets the property EndTimestamp. 
        /// <para>
        /// The nanosecond-precision end time of the data segment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TimeInNanos EndTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the EndTimestamp property is set.
        /// </summary>
        internal bool IsSetEndTimestamp() => this.EndTimestamp != null;

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// The error code for the failed association.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DataSegmentErrorCode ErrorCode { get; set; }

        /// <summary>
        /// Checks to see if the ErrorCode property is set.
        /// </summary>
        internal bool IsSetErrorCode() => this.ErrorCode != null;

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// The error message for the failed association.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;

        /// <summary>
        /// Gets and sets the property SourceDatasetId. 
        /// <para>
        /// The ID of the source dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string SourceDatasetId { get; set; }

        /// <summary>
        /// Checks to see if the SourceDatasetId property is set.
        /// </summary>
        internal bool IsSetSourceDatasetId() => this.SourceDatasetId != null;

        /// <summary>
        /// Gets and sets the property StartTimestamp. 
        /// <para>
        /// The nanosecond-precision start time of the data segment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TimeInNanos StartTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the StartTimestamp property is set.
        /// </summary>
        internal bool IsSetStartTimestamp() => this.StartTimestamp != null;

        /// <summary>
        /// Gets and sets the property TimeSeriesId. 
        /// <para>
        /// The ID of the time series.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 73)]
        public string TimeSeriesId { get; set; }

        /// <summary>
        /// Checks to see if the TimeSeriesId property is set.
        /// </summary>
        internal bool IsSetTimeSeriesId() => this.TimeSeriesId != null;
    }
}
