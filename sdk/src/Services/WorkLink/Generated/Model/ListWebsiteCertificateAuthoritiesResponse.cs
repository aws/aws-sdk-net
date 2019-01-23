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
 * Do not modify this file. This file is generated from the worklink-2018-09-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WorkLink.Model
{
    /// <summary>
    /// This is the response object from the ListWebsiteCertificateAuthorities operation.
    /// </summary>
    public partial class ListWebsiteCertificateAuthoritiesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<WebsiteCaSummary> _websiteCertificateAuthorities = new List<WebsiteCaSummary>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token used to retrieve the next page of results for this operation.
        /// If there are no more pages, this value is null.
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
        /// Gets and sets the property WebsiteCertificateAuthorities. 
        /// <para>
        /// Information about the certificates.
        /// </para>
        /// </summary>
        public List<WebsiteCaSummary> WebsiteCertificateAuthorities
        {
            get { return this._websiteCertificateAuthorities; }
            set { this._websiteCertificateAuthorities = value; }
        }

        // Check to see if WebsiteCertificateAuthorities property is set
        internal bool IsSetWebsiteCertificateAuthorities()
        {
            return this._websiteCertificateAuthorities != null && this._websiteCertificateAuthorities.Count > 0; 
        }

    }
}