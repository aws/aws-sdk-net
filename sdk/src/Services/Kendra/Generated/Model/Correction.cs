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
    /// A corrected misspelled word in a query.
    /// </summary>
    public partial class Correction
    {
        private int? _beginOffset;
        private string _correctedTerm;
        private int? _endOffset;
        private string _term;

        /// <summary>
        /// Gets and sets the property BeginOffset. 
        /// <para>
        /// The zero-based location in the response string or text where the corrected word starts.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property CorrectedTerm. 
        /// <para>
        /// The string or text of a corrected misspelled word in a query.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string CorrectedTerm
        {
            get { return this._correctedTerm; }
            set { this._correctedTerm = value; }
        }

        // Check to see if CorrectedTerm property is set
        internal bool IsSetCorrectedTerm()
        {
            return this._correctedTerm != null;
        }

        /// <summary>
        /// Gets and sets the property EndOffset. 
        /// <para>
        /// The zero-based location in the response string or text where the corrected word ends.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Term. 
        /// <para>
        /// The string or text of a misspelled word in a query.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string Term
        {
            get { return this._term; }
            set { this._term = value; }
        }

        // Check to see if Term property is set
        internal bool IsSetTerm()
        {
            return this._term != null;
        }

    }
}