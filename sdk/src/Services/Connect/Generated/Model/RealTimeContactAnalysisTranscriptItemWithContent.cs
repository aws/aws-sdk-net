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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Transcript representation containing Id, Content and list of character intervals that
    /// are associated with analysis data. For example, this object within an issue detected
    /// would describe both content that contains identified issue and intervals where that
    /// content is taken from.
    /// </summary>
    public partial class RealTimeContactAnalysisTranscriptItemWithContent
    {
        private RealTimeContactAnalysisCharacterInterval _characterOffsets;
        private string _content;
        private string _id;

        /// <summary>
        /// Gets and sets the property CharacterOffsets.
        /// </summary>
        public RealTimeContactAnalysisCharacterInterval CharacterOffsets
        {
            get { return this._characterOffsets; }
            set { this._characterOffsets = value; }
        }

        // Check to see if CharacterOffsets property is set
        internal bool IsSetCharacterOffsets()
        {
            return this._characterOffsets != null;
        }

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// Part of the transcript content that contains identified issue. Can be redacted
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=16384)]
        public string Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        // Check to see if Content property is set
        internal bool IsSetContent()
        {
            return this._content != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// Transcript identifier. Matches the identifier from one of the TranscriptSegments.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
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

    }
}