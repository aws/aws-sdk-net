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
 * Do not modify this file. This file is generated from the connect-contact-lens-2020-08-21.normal.json service model.
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
namespace Amazon.ConnectContactLens.Model
{
    /// <summary>
    /// For characters that were detected as issues, where they occur in the transcript.
    /// </summary>
    public partial class CharacterOffsets
    {
        private int? _beginOffsetChar;
        private int? _endOffsetChar;

        /// <summary>
        /// Gets and sets the property BeginOffsetChar. 
        /// <para>
        /// The beginning of the issue.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public int? BeginOffsetChar
        {
            get { return this._beginOffsetChar; }
            set { this._beginOffsetChar = value; }
        }

        // Check to see if BeginOffsetChar property is set
        internal bool IsSetBeginOffsetChar()
        {
            return this._beginOffsetChar.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndOffsetChar. 
        /// <para>
        /// The end of the issue.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public int? EndOffsetChar
        {
            get { return this._endOffsetChar; }
            set { this._endOffsetChar = value; }
        }

        // Check to see if EndOffsetChar property is set
        internal bool IsSetEndOffsetChar()
        {
            return this._endOffsetChar.HasValue; 
        }

    }
}