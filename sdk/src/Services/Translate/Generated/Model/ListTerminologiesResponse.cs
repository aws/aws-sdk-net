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
 * Do not modify this file. This file is generated from the translate-2017-07-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Translate.Model
{
    /// <summary>
    /// This is the response object from the ListTerminologies operation.
    /// </summary>
    public partial class ListTerminologiesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<TerminologyProperties> _terminologyPropertiesList = new List<TerminologyProperties>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  If the response to the ListTerminologies was truncated, the NextToken fetches the
        /// next group of custom terminologies. 
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property TerminologyPropertiesList. 
        /// <para>
        /// The properties list of the custom terminologies returned on the list request.
        /// </para>
        /// </summary>
        public List<TerminologyProperties> TerminologyPropertiesList
        {
            get { return this._terminologyPropertiesList; }
            set { this._terminologyPropertiesList = value; }
        }

        // Check to see if TerminologyPropertiesList property is set
        internal bool IsSetTerminologyPropertiesList()
        {
            return this._terminologyPropertiesList != null && this._terminologyPropertiesList.Count > 0; 
        }

    }
}