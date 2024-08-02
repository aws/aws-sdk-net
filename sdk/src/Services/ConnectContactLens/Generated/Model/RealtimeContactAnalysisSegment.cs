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
    /// An analyzed segment for a real-time analysis session.
    /// </summary>
    public partial class RealtimeContactAnalysisSegment
    {
        private Categories _categories;
        private PostContactSummary _postContactSummary;
        private Transcript _transcript;

        /// <summary>
        /// Gets and sets the property Categories. 
        /// <para>
        /// The matched category rules.
        /// </para>
        /// </summary>
        public Categories Categories
        {
            get { return this._categories; }
            set { this._categories = value; }
        }

        // Check to see if Categories property is set
        internal bool IsSetCategories()
        {
            return this._categories != null;
        }

        /// <summary>
        /// Gets and sets the property PostContactSummary. 
        /// <para>
        /// Information about the post-contact summary.
        /// </para>
        /// </summary>
        public PostContactSummary PostContactSummary
        {
            get { return this._postContactSummary; }
            set { this._postContactSummary = value; }
        }

        // Check to see if PostContactSummary property is set
        internal bool IsSetPostContactSummary()
        {
            return this._postContactSummary != null;
        }

        /// <summary>
        /// Gets and sets the property Transcript. 
        /// <para>
        /// The analyzed transcript.
        /// </para>
        /// </summary>
        public Transcript Transcript
        {
            get { return this._transcript; }
            set { this._transcript = value; }
        }

        // Check to see if Transcript property is set
        internal bool IsSetTranscript()
        {
            return this._transcript != null;
        }

    }
}