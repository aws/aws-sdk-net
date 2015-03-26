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
 * Do not modify this file. This file is generated from the cloudsearch-2013-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudSearch.Model
{
    /// <summary>
    /// The result of a <code>BuildSuggester</code> request. Contains a list of the fields
    /// used for suggestions.
    /// </summary>
    public partial class BuildSuggestersResponse : AmazonWebServiceResponse
    {
        private List<string> _fieldNames = new List<string>();

        /// <summary>
        /// Gets and sets the property FieldNames.
        /// </summary>
        public List<string> FieldNames
        {
            get { return this._fieldNames; }
            set { this._fieldNames = value; }
        }

        // Check to see if FieldNames property is set
        internal bool IsSetFieldNames()
        {
            return this._fieldNames != null && this._fieldNames.Count > 0; 
        }

    }
}