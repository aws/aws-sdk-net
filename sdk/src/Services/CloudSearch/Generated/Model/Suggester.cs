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
 * Do not modify this file. This file is generated from the cloudsearch-2013-01-01.normal.json service model.
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
namespace Amazon.CloudSearch.Model
{
    /// <summary>
    /// Configuration information for a search suggester. Each suggester has a unique name
    /// and specifies the text field you want to use for suggestions. The following options
    /// can be configured for a suggester: <c>FuzzyMatching</c>, <c>SortExpression</c>.
    /// </summary>
    public partial class Suggester
    {
        private DocumentSuggesterOptions _documentSuggesterOptions;
        private string _suggesterName;

        /// <summary>
        /// Gets and sets the property DocumentSuggesterOptions.
        /// </summary>
        [AWSProperty(Required=true)]
        public DocumentSuggesterOptions DocumentSuggesterOptions
        {
            get { return this._documentSuggesterOptions; }
            set { this._documentSuggesterOptions = value; }
        }

        // Check to see if DocumentSuggesterOptions property is set
        internal bool IsSetDocumentSuggesterOptions()
        {
            return this._documentSuggesterOptions != null;
        }

        /// <summary>
        /// Gets and sets the property SuggesterName.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string SuggesterName
        {
            get { return this._suggesterName; }
            set { this._suggesterName = value; }
        }

        // Check to see if SuggesterName property is set
        internal bool IsSetSuggesterName()
        {
            return this._suggesterName != null;
        }

    }
}