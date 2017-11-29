/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the comprehend-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// Container for the parameters to the DetectDominantLanguage operation.
    /// Determines the dominant language of the input text. For a list of languages that Amazon
    /// Comprehend can detect, see <a href="http://docs.aws.amazon.com/comprehend/latest/dg/how-languages.html">Amazon
    /// Comprehend Supported Languages</a>.
    /// </summary>
    public partial class DetectDominantLanguageRequest : AmazonComprehendRequest
    {
        private string _text;

        /// <summary>
        /// Gets and sets the property Text. 
        /// <para>
        /// A UTF-8 text string. Each string should contain at least 20 characters and must contain
        /// fewer that 5,000 bytes of UTF-8 encoded characters.
        /// </para>
        /// </summary>
        public string Text
        {
            get { return this._text; }
            set { this._text = value; }
        }

        // Check to see if Text property is set
        internal bool IsSetText()
        {
            return this._text != null;
        }

    }
}