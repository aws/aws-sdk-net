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
    /// The class assigned to a Page object detected in an input document. Contains information
    /// regarding the predicted type/class of a document's page and the page number that the
    /// Page object was detected on.
    /// </summary>
    public partial class PageClassification
    {
        private List<Prediction> _pageNumber = new List<Prediction>();
        private List<Prediction> _pageType = new List<Prediction>();

        /// <summary>
        /// Gets and sets the property PageNumber. 
        /// <para>
        ///  The page number the value was detected on, relative to Amazon Textract's starting
        /// position.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Prediction> PageNumber
        {
            get { return this._pageNumber; }
            set { this._pageNumber = value; }
        }

        // Check to see if PageNumber property is set
        internal bool IsSetPageNumber()
        {
            return this._pageNumber != null && this._pageNumber.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PageType. 
        /// <para>
        /// The class, or document type, assigned to a detected Page object. The class, or document
        /// type, assigned to a detected Page object.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Prediction> PageType
        {
            get { return this._pageType; }
            set { this._pageType = value; }
        }

        // Check to see if PageType property is set
        internal bool IsSetPageType()
        {
            return this._pageType != null && this._pageType.Count > 0; 
        }

    }
}