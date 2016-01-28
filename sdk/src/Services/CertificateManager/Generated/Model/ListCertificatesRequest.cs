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
    /// Container for the parameters to the ListCertificates operation.
    /// Retrieves a list of the certificate ARNs, and the domain name for each ARN, owned
    /// by the calling account. You can filter the list based on the <code>CertificateStatuses</code>
    /// parameter, and you can display up to <code>MaxItems</code> certificates at one time.
    /// If you have more than <code>MaxItems</code> certificates, use the <code>NextToken</code>
    /// marker from the response object in your next call to the <code>ListCertificates</code>
    /// function to retrieve the next set of certificate ARNs.
    /// </summary>
    public partial class ListCertificatesRequest : AmazonCertificateManagerRequest
    {
        private List<string> _certificateStatuses = new List<string>();
        private int? _maxItems;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property CertificateStatuses. 
        /// <para>
        ///  Identifies the status of the certificates for which you want to retrieve the certificate
        /// ARNs. This can be one or more of the following values: <ul> <li><code>PENDING_VALIDATION</code></li>
        /// <li><code>ISSUED</code></li> <li><code>INACTIVE</code></li> <li><code>EXPIRED</code></li>
        /// <li><code>VALIDATION_TIMED_OUT</code></li> <li><code>REVOKED</code></li> <li><code>FAILED</code></li>
        /// </ul> 
        /// </para>
        /// </summary>
        public List<string> CertificateStatuses
        {
            get { return this._certificateStatuses; }
            set { this._certificateStatuses = value; }
        }

        // Check to see if CertificateStatuses property is set
        internal bool IsSetCertificateStatuses()
        {
            return this._certificateStatuses != null && this._certificateStatuses.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxItems. 
        /// <para>
        ///  Specify this parameter when paginating results to indicate the maximum number of
        /// certificates that you want to display for each response. If there are additional certificates
        /// beyond the maximum you specify, use the <code>NextToken</code> value in your next
        /// call to the <code>ListCertificates</code> function. 
        /// </para>
        /// </summary>
        public int MaxItems
        {
            get { return this._maxItems.GetValueOrDefault(); }
            set { this._maxItems = value; }
        }

        // Check to see if MaxItems property is set
        internal bool IsSetMaxItems()
        {
            return this._maxItems.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  String that contains an opaque marker of the next certificate to be displayed. Use
        /// this parameter when paginating results, and only in a subsequent request after you've
        /// received a response where the results have been truncated. Set it to an empty string
        /// the first time you call this function, and set it to the value of the <code>NextToken</code>
        /// element you receive in the response object for subsequent calls. 
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