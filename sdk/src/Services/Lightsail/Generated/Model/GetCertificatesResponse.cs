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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// This is the response object from the GetCertificates operation.
    /// </summary>
    public partial class GetCertificatesResponse : AmazonWebServiceResponse
    {
        private List<CertificateSummary> _certificates = new List<CertificateSummary>();
        private string _nextPageToken;

        /// <summary>
        /// Gets and sets the property Certificates. 
        /// <para>
        /// An object that describes certificates.
        /// </para>
        /// </summary>
        public List<CertificateSummary> Certificates
        {
            get { return this._certificates; }
            set { this._certificates = value; }
        }

        // Check to see if Certificates property is set
        internal bool IsSetCertificates()
        {
            return this._certificates != null && this._certificates.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextPageToken. 
        /// <para>
        /// If <code>NextPageToken</code> is returned there are more results available. The value
        /// of <code>NextPageToken</code> is a unique pagination token for each page. Make the
        /// call again using the returned token to retrieve the next page. Keep all other arguments
        /// unchanged.
        /// </para>
        /// </summary>
        public string NextPageToken
        {
            get { return this._nextPageToken; }
            set { this._nextPageToken = value; }
        }

        // Check to see if NextPageToken property is set
        internal bool IsSetNextPageToken()
        {
            return this._nextPageToken != null;
        }

    }
}