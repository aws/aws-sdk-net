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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
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
namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Provides information that you can use to highlight a search result so that your users
    /// can quickly identify terms in the response.
    /// </summary>
    public partial class Highlight
    {
        private int? _beginOffset;
        private int? _endOffset;
        private bool? _topAnswer;
        private HighlightType _type;

        /// <summary>
        /// Gets and sets the property BeginOffset. 
        /// <para>
        /// The zero-based location in the response string where the highlight starts.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? BeginOffset
        {
            get { return this._beginOffset; }
            set { this._beginOffset = value; }
        }

        // Check to see if BeginOffset property is set
        internal bool IsSetBeginOffset()
        {
            return this._beginOffset.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndOffset. 
        /// <para>
        /// The zero-based location in the response string where the highlight ends.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? EndOffset
        {
            get { return this._endOffset; }
            set { this._endOffset = value; }
        }

        // Check to see if EndOffset property is set
        internal bool IsSetEndOffset()
        {
            return this._endOffset.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TopAnswer. 
        /// <para>
        /// Indicates whether the response is the best response. True if this is the best response;
        /// otherwise, false.
        /// </para>
        /// </summary>
        public bool? TopAnswer
        {
            get { return this._topAnswer; }
            set { this._topAnswer = value; }
        }

        // Check to see if TopAnswer property is set
        internal bool IsSetTopAnswer()
        {
            return this._topAnswer.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The highlight type. 
        /// </para>
        /// </summary>
        public HighlightType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}