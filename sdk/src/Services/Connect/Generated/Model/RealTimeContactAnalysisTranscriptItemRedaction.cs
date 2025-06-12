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
    /// Object describing redaction applied to the segment.
    /// </summary>
    public partial class RealTimeContactAnalysisTranscriptItemRedaction
    {
        private List<RealTimeContactAnalysisCharacterInterval> _characterOffsets = AWSConfigs.InitializeCollections ? new List<RealTimeContactAnalysisCharacterInterval>() : null;

        /// <summary>
        /// Gets and sets the property CharacterOffsets. 
        /// <para>
        /// List of character intervals each describing a part of the text that was redacted.
        /// For <c>OutputType.Raw</c>, part of the original text that contains data that can be
        /// redacted. For <c> OutputType.Redacted</c>, part of the string with redaction tag.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RealTimeContactAnalysisCharacterInterval> CharacterOffsets
        {
            get { return this._characterOffsets; }
            set { this._characterOffsets = value; }
        }

        // Check to see if CharacterOffsets property is set
        internal bool IsSetCharacterOffsets()
        {
            return this._characterOffsets != null && (this._characterOffsets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}