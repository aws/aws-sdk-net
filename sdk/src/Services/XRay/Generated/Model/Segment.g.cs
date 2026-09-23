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
    /// A segment from a trace that has been ingested by the X-Ray service. The segment can
    /// be compiled from documents uploaded with <a href="https://docs.aws.amazon.com/xray/latest/api/API_PutTraceSegments.html">PutTraceSegments</a>,
    /// or an <c>inferred</c> segment for a downstream service, generated from a subsegment
    /// sent by the service that called it.
    /// 
    ///  
    /// <para>
    /// For the full segment document schema, see <a href="https://docs.aws.amazon.com/xray/latest/devguide/aws-xray-interface-api.html#xray-api-segmentdocuments">Amazon
    /// Web Services X-Ray segment documents</a> in the <i>Amazon Web Services X-Ray Developer
    /// Guide</i>.
    /// </para>
    /// </summary>
    public partial class Segment
    {
        /// <summary>
        /// Gets and sets the property Document. 
        /// <para>
        /// The segment document.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string Document { get; set; }

        /// <summary>
        /// Checks to see if the Document property is set.
        /// </summary>
        internal bool IsSetDocument() => this.Document != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The segment's ID.
        /// </para>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;
    }
}
