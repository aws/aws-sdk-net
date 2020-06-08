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
 * Do not modify this file. This file is generated from the acm-pca-2017-08-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ACMPCA.Model
{
    /// <summary>
    /// Container for the parameters to the ListPermissions operation.
    /// Lists all the permissions, if any, that have been assigned by a private CA. Permissions
    /// can be granted with the <a>CreatePermission</a> action and revoked with the <a>DeletePermission</a>
    /// action.
    /// </summary>
    public partial class ListPermissionsRequest : AmazonACMPCARequest
    {
        private string _certificateAuthorityArn;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property CertificateAuthorityArn. 
        /// <para>
        /// The Amazon Resource Number (ARN) of the private CA to inspect. You can find the ARN
        /// by calling the <a>ListCertificateAuthorities</a> action. This must be of the form:
        /// <code>arn:aws:acm-pca:region:account:certificate-authority/12345678-1234-1234-1234-123456789012</code>
        /// You can get a private CA's ARN by running the <a>ListCertificateAuthorities</a> action.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=5, Max=200)]
        public string CertificateAuthorityArn
        {
            get { return this._certificateAuthorityArn; }
            set { this._certificateAuthorityArn = value; }
        }

        // Check to see if CertificateAuthorityArn property is set
        internal bool IsSetCertificateAuthorityArn()
        {
            return this._certificateAuthorityArn != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// When paginating results, use this parameter to specify the maximum number of items
        /// to return in the response. If additional items exist beyond the number you specify,
        /// the <b>NextToken</b> element is sent in the response. Use this <b>NextToken</b> value
        /// in a subsequent request to retrieve additional items.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// When paginating results, use this parameter in a subsequent request after you receive
        /// a response with truncated results. Set it to the value of <b>NextToken</b> from the
        /// response you just received.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
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