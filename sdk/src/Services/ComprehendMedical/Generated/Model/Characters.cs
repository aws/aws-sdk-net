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
 * Do not modify this file. This file is generated from the comprehendmedical-2018-10-30.normal.json service model.
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
namespace Amazon.ComprehendMedical.Model
{
    /// <summary>
    /// The number of characters in the input text to be analyzed.
    /// </summary>
    public partial class Characters
    {
        private int? _originalTextCharacters;

        /// <summary>
        /// Gets and sets the property OriginalTextCharacters. 
        /// <para>
        ///  The number of characters present in the input text document as processed by Amazon
        /// Comprehend Medical. 
        /// </para>
        /// </summary>
        public int? OriginalTextCharacters
        {
            get { return this._originalTextCharacters; }
            set { this._originalTextCharacters = value; }
        }

        // Check to see if OriginalTextCharacters property is set
        internal bool IsSetOriginalTextCharacters()
        {
            return this._originalTextCharacters.HasValue; 
        }

    }
}