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
    /// The section of the contact transcript segment that category rule was detected.
    /// </summary>
    public partial class RealTimeContactAnalysisPointOfInterest
    {
        private List<RealTimeContactAnalysisTranscriptItemWithCharacterOffsets> _transcriptItems = AWSConfigs.InitializeCollections ? new List<RealTimeContactAnalysisTranscriptItemWithCharacterOffsets>() : null;

        /// <summary>
        /// Gets and sets the property TranscriptItems. 
        /// <para>
        /// List of the transcript items (segments) that are associated with a given point of
        /// interest. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<RealTimeContactAnalysisTranscriptItemWithCharacterOffsets> TranscriptItems
        {
            get { return this._transcriptItems; }
            set { this._transcriptItems = value; }
        }

        // Check to see if TranscriptItems property is set
        internal bool IsSetTranscriptItems()
        {
            return this._transcriptItems != null && (this._transcriptItems.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}