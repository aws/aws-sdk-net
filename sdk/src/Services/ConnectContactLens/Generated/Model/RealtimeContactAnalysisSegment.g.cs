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

namespace Amazon.ConnectContactLens.Model
{
    /// <summary>
    /// An analyzed segment for a real-time analysis session.
    /// </summary>
    public partial class RealtimeContactAnalysisSegment
    {
        /// <summary>
        /// Gets and sets the property Categories. 
        /// <para>
        /// The matched category rules.
        /// </para>
        /// </summary>
        public Categories Categories { get; set; }

        /// <summary>
        /// Checks to see if the Categories property is set.
        /// </summary>
        internal bool IsSetCategories() => this.Categories != null;

        /// <summary>
        /// Gets and sets the property ExtractedInformation. 
        /// <para>
        /// The extracted information from the conversation.
        /// </para>
        /// </summary>
        public ExtractedInformation ExtractedInformation { get; set; }

        /// <summary>
        /// Checks to see if the ExtractedInformation property is set.
        /// </summary>
        internal bool IsSetExtractedInformation() => this.ExtractedInformation != null;

        /// <summary>
        /// Gets and sets the property PostContactSummary. 
        /// <para>
        /// Information about the post-contact summary.
        /// </para>
        /// </summary>
        public PostContactSummary PostContactSummary { get; set; }

        /// <summary>
        /// Checks to see if the PostContactSummary property is set.
        /// </summary>
        internal bool IsSetPostContactSummary() => this.PostContactSummary != null;

        /// <summary>
        /// Gets and sets the property Transcript. 
        /// <para>
        /// The analyzed transcript.
        /// </para>
        /// </summary>
        public Transcript Transcript { get; set; }

        /// <summary>
        /// Checks to see if the Transcript property is set.
        /// </summary>
        internal bool IsSetTranscript() => this.Transcript != null;
    }
}
