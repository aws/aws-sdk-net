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
 * Do not modify this file. This file is generated from the acm-2015-12-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CertificateManager.Model
{
    /// <summary>
    /// This is the response object from the ListCertificates operation.
    /// </summary>
    public partial class ListCertificatesResponse : AmazonWebServiceResponse
    {
        private List<CertificateSummary> _certificateSummaryList = new List<CertificateSummary>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property CertificateSummaryList. 
        /// <para>
        /// A list of ACM Certificates.
        /// </para>
        /// </summary>
        public List<CertificateSummary> CertificateSummaryList
        {
            get { return this._certificateSummaryList; }
            set { this._certificateSummaryList = value; }
        }

        // Check to see if CertificateSummaryList property is set
        internal bool IsSetCertificateSummaryList()
        {
            return this._certificateSummaryList != null && this._certificateSummaryList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// When the list is truncated, this value is present and contains the value to use for
        /// the <code>NextToken</code> parameter in a subsequent pagination request.
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

    }
}