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
 * Do not modify this file. This file is generated from the textract-2018-06-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Textract.Model
{
    /// <summary>
    /// Contains the detections for each page analyzed through the Analyze Lending API.
    /// </summary>
    public partial class LendingResult
    {
        private List<Extraction> _extractions = new List<Extraction>();
        private int? _page;
        private PageClassification _pageClassification;

        /// <summary>
        /// Gets and sets the property Extractions. 
        /// <para>
        /// An array of Extraction to hold structured data. e.g. normalized key value pairs instead
        /// of raw OCR detections .
        /// </para>
        /// </summary>
        public List<Extraction> Extractions
        {
            get { return this._extractions; }
            set { this._extractions = value; }
        }

        // Check to see if Extractions property is set
        internal bool IsSetExtractions()
        {
            return this._extractions != null && this._extractions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Page. 
        /// <para>
        /// The page number for a page, with regard to whole submission.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int Page
        {
            get { return this._page.GetValueOrDefault(); }
            set { this._page = value; }
        }

        // Check to see if Page property is set
        internal bool IsSetPage()
        {
            return this._page.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PageClassification. 
        /// <para>
        /// The classifier result for a given page.
        /// </para>
        /// </summary>
        public PageClassification PageClassification
        {
            get { return this._pageClassification; }
            set { this._pageClassification = value; }
        }

        // Check to see if PageClassification property is set
        internal bool IsSetPageClassification()
        {
            return this._pageClassification != null;
        }

    }
}