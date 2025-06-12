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
    /// Container for the parameters to the PutTraceSegments operation.
    /// Uploads segment documents to Amazon Web Services X-Ray. A segment document can be
    /// a completed segment, an in-progress segment, or an array of subsegments.
    /// 
    ///  
    /// <para>
    /// Segments must include the following fields. For the full segment document schema,
    /// see <a href="https://docs.aws.amazon.com/xray/latest/devguide/aws-xray-interface-api.html#xray-api-segmentdocuments.html">Amazon
    /// Web Services X-Ray Segment Documents</a> in the <i>Amazon Web Services X-Ray Developer
    /// Guide</i>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Required segment document fields</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>name</c> - The name of the service that handled the request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>id</c> - A 64-bit identifier for the segment, unique among segments in the same
    /// trace, in 16 hexadecimal digits.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>trace_id</c> - A unique identifier that connects all segments and subsegments
    /// originating from a single client request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>start_time</c> - Time the segment or subsegment was created, in floating point
    /// seconds in epoch time, accurate to milliseconds. For example, <c>1480615200.010</c>
    /// or <c>1.480615200010E9</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>end_time</c> - Time the segment or subsegment was closed. For example, <c>1480615200.090</c>
    /// or <c>1.480615200090E9</c>. Specify either an <c>end_time</c> or <c>in_progress</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>in_progress</c> - Set to <c>true</c> instead of specifying an <c>end_time</c>
    /// to record that a segment has been started, but is not complete. Send an in-progress
    /// segment when your application receives a request that will take a long time to serve,
    /// to trace that the request was received. When the response is sent, send the complete
    /// segment to overwrite the in-progress segment.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// A <c>trace_id</c> consists of three numbers separated by hyphens. For example, 1-58406520-a006649127e371903a2de979.
    /// For trace IDs created by an X-Ray SDK, or by Amazon Web Services services integrated
    /// with X-Ray, a trace ID includes:
    /// </para>
    ///  
    /// <para>
    ///  <b>Trace ID Format</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The version number, for instance, <c>1</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The time of the original request, in Unix epoch time, in 8 hexadecimal digits. For
    /// example, 10:00AM December 2nd, 2016 PST in epoch time is <c>1480615200</c> seconds,
    /// or <c>58406520</c> in hexadecimal.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A 96-bit identifier for the trace, globally unique, in 24 hexadecimal digits.
    /// </para>
    ///  </li> </ul> <note> 
    /// <para>
    /// Trace IDs created via OpenTelemetry have a different format based on the <a href="https://www.w3.org/TR/trace-context/">W3C
    /// Trace Context specification</a>. A W3C trace ID must be formatted in the X-Ray trace
    /// ID format when sending to X-Ray. For example, a W3C trace ID <c>4efaaf4d1e8720b39541901950019ee5</c>
    /// should be formatted as <c>1-4efaaf4d-1e8720b39541901950019ee5</c> when sending to
    /// X-Ray. While X-Ray trace IDs include the original request timestamp in Unix epoch
    /// time, this is not required or validated. 
    /// </para>
    ///  </note>
    /// </summary>
    public partial class PutTraceSegmentsRequest : AmazonXRayRequest
    {
        private List<string> _traceSegmentDocuments = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property TraceSegmentDocuments. 
        /// <para>
        /// A string containing a JSON document defining one or more segments or subsegments.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> TraceSegmentDocuments
        {
            get { return this._traceSegmentDocuments; }
            set { this._traceSegmentDocuments = value; }
        }

        // Check to see if TraceSegmentDocuments property is set
        internal bool IsSetTraceSegmentDocuments()
        {
            return this._traceSegmentDocuments != null && (this._traceSegmentDocuments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}