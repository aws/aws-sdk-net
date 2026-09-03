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
 * Do not modify this file. This file is generated from the support-2013-04-15.normal.json service model.
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
namespace Amazon.AWSSupport.Model
{
    /// <summary>
    /// The range of part indexes for which to return presigned upload URLs from <a>GetAttachmentUploadLinks</a>.
    /// </summary>
    public partial class UploadRange
    {
        private int? _endIndex;
        private int? _startIndex;

        /// <summary>
        /// Gets and sets the property EndIndex. 
        /// <para>
        /// The ending part index of the range, exclusive. The range is half-open: <c>startIndex</c>
        /// is inclusive and <c>endIndex</c> is exclusive. For example, a range with <c>startIndex</c>
        /// of 1 and <c>endIndex</c> of 4 requests URLs for parts 1, 2, and 3. The range size
        /// (<c>endIndex</c> - <c>startIndex</c>) must not exceed 10. If you omit <c>endIndex</c>,
        /// the service defaults to <c>startIndex</c> + 10, capped by the total number of parts.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2)]
        public int? EndIndex
        {
            get { return this._endIndex; }
            set { this._endIndex = value; }
        }

        // Check to see if EndIndex property is set
        internal bool IsSetEndIndex()
        {
            return this._endIndex.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartIndex. 
        /// <para>
        /// The starting part index of the range, inclusive. Part indexes start at 1.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public int? StartIndex
        {
            get { return this._startIndex; }
            set { this._startIndex = value; }
        }

        // Check to see if StartIndex property is set
        internal bool IsSetStartIndex()
        {
            return this._startIndex.HasValue; 
        }

    }
}