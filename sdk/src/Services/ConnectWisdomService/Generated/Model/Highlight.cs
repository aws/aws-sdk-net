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
 * Do not modify this file. This file is generated from the wisdom-2020-10-19.normal.json service model.
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
namespace Amazon.ConnectWisdomService.Model
{
    /// <summary>
    /// Offset specification to describe highlighting of document excerpts for rendering search
    /// results and recommendations.
    /// </summary>
    public partial class Highlight
    {
        private int? _beginOffsetInclusive;
        private int? _endOffsetExclusive;

        /// <summary>
        /// Gets and sets the property BeginOffsetInclusive. 
        /// <para>
        /// The offset for the start of the highlight.
        /// </para>
        /// </summary>
        public int? BeginOffsetInclusive
        {
            get { return this._beginOffsetInclusive; }
            set { this._beginOffsetInclusive = value; }
        }

        // Check to see if BeginOffsetInclusive property is set
        internal bool IsSetBeginOffsetInclusive()
        {
            return this._beginOffsetInclusive.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndOffsetExclusive. 
        /// <para>
        /// The offset for the end of the highlight.
        /// </para>
        /// </summary>
        public int? EndOffsetExclusive
        {
            get { return this._endOffsetExclusive; }
            set { this._endOffsetExclusive = value; }
        }

        // Check to see if EndOffsetExclusive property is set
        internal bool IsSetEndOffsetExclusive()
        {
            return this._endOffsetExclusive.HasValue; 
        }

    }
}