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

namespace Amazon.ConnectContactLens.Model
{
    /// <summary>
    /// Provides the category rules that are used to automatically categorize contacts based
    /// on uttered keywords and phrases.
    /// </summary>
    public partial class Categories
    {
        private List<string> _matchedCategories = new List<string>();
        private Dictionary<string, CategoryDetails> _matchedDetails = new Dictionary<string, CategoryDetails>();

        /// <summary>
        /// Gets and sets the property MatchedCategories. 
        /// <para>
        /// The category rules that have been matched in the analyzed segment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=150)]
        public List<string> MatchedCategories
        {
            get { return this._matchedCategories; }
            set { this._matchedCategories = value; }
        }

        // Check to see if MatchedCategories property is set
        internal bool IsSetMatchedCategories()
        {
            return this._matchedCategories != null && this._matchedCategories.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MatchedDetails. 
        /// <para>
        /// The category rule that was matched and when it occurred in the transcript.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=150)]
        public Dictionary<string, CategoryDetails> MatchedDetails
        {
            get { return this._matchedDetails; }
            set { this._matchedDetails = value; }
        }

        // Check to see if MatchedDetails property is set
        internal bool IsSetMatchedDetails()
        {
            return this._matchedDetails != null && this._matchedDetails.Count > 0; 
        }

    }
}