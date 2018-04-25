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
 * Do not modify this file. This file is generated from the xray-2016-04-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.XRay.Model
{
    /// <summary>
    /// Container for the parameters to the PutTraceSegments operation.
    /// Uploads segment documents to AWS X-Ray. The X-Ray SDK generates segment documents
    /// and sends them to the X-Ray daemon, which uploads them in batches. A segment document
    /// can be a completed segment, an in-progress segment, or an array of subsegments.
    /// 
    ///  
    /// <para>
    /// Segments must include the following fields. For the full segment document schema,
    /// see <a href="https://docs.aws.amazon.com/xray/latest/devguide/xray-api-segmentdocuments.html">AWS
    /// X-Ray Segment Documents</a> in the <i>AWS X-Ray Developer Guide</i>.
    /// </para>
    ///  <p class="title"> <b>Required Segment Document Fields</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>name</code> - The name of the service that handled the request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>id</code> - A 64-bit identifier for the segment, unique among segments in the
    /// same trace, in 16 hexadecimal digits.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>trace_id</code> - A unique identifier that connects all segments and subsegments
    /// originating from a single client request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>start_time</code> - Time the segment or subsegment was created, in floating
    /// point seconds in epoch time, accurate to milliseconds. For example, <code>1480615200.010</code>
    /// or <code>1.480615200010E9</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>end_time</code> - Time the segment or subsegment was closed. For example, <code>1480615200.090</code>
    /// or <code>1.480615200090E9</code>. Specify either an <code>end_time</code> or <code>in_progress</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>in_progress</code> - Set to <code>true</code> instead of specifying an <code>end_time</code>
    /// to record that a segment has been started, but is not complete. Send an in progress
    /// segment when your application receives a request that will take a long time to serve,
    /// to trace the fact that the request was received. When the response is sent, send the
    /// complete segment to overwrite the in-progress segment.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// A <code>trace_id</code> consists of three numbers separated by hyphens. For example,
    /// 1-58406520-a006649127e371903a2de979. This includes:
    /// </para>
    ///  <p class="title"> <b>Trace ID Format</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The version number, i.e. <code>1</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The time of the original request, in Unix epoch time, in 8 hexadecimal digits. For
    /// example, 10:00AM December 2nd, 2016 PST in epoch time is <code>1480615200</code> seconds,
    /// or <code>58406520</code> in hexadecimal.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A 96-bit identifier for the trace, globally unique, in 24 hexadecimal digits.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class PutTraceSegmentsRequest : AmazonXRayRequest
    {
        private List<string> _traceSegmentDocuments = new List<string>();

        /// <summary>
        /// Gets and sets the property TraceSegmentDocuments. 
        /// <para>
        /// A string containing a JSON document defining one or more segments or subsegments.
        /// </para>
        /// </summary>
        public List<string> TraceSegmentDocuments
        {
            get { return this._traceSegmentDocuments; }
            set { this._traceSegmentDocuments = value; }
        }

        // Check to see if TraceSegmentDocuments property is set
        internal bool IsSetTraceSegmentDocuments()
        {
            return this._traceSegmentDocuments != null && this._traceSegmentDocuments.Count > 0; 
        }

    }
}