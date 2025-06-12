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
    /// Retrieved collection of spans with matching trace IDs.
    /// </summary>
    public partial class RetrievedTrace
    {
        private double? _duration;
        private string _id;
        private List<Span> _spans = AWSConfigs.InitializeCollections ? new List<Span>() : null;

        /// <summary>
        /// Gets and sets the property Duration. 
        /// <para>
        ///  The length of time in seconds between the start time of the root span and the end
        /// time of the last span that completed. 
        /// </para>
        /// </summary>
        public double? Duration
        {
            get { return this._duration; }
            set { this._duration = value; }
        }

        // Check to see if Duration property is set
        internal bool IsSetDuration()
        {
            return this._duration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        ///  The unique identifier for the span. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=35)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Spans. 
        /// <para>
        ///  Spans that comprise the trace. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<Span> Spans
        {
            get { return this._spans; }
            set { this._spans = value; }
        }

        // Check to see if Spans property is set
        internal bool IsSetSpans()
        {
            return this._spans != null && (this._spans.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}