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
    /// List all permissions on a private CA, if any, granted to the Certificate Manager (ACM)
    /// service principal (acm.amazonaws.com). 
    /// 
    ///  
    /// <para>
    /// These permissions allow ACM to issue and renew ACM certificates that reside in the
    /// same Amazon Web Services account as the CA. 
    /// </para>
    ///  
    /// <para>
    /// Permissions can be granted with the <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_CreatePermission.html">CreatePermission</a>
    /// action and revoked with the <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_DeletePermission.html">DeletePermission</a>
    /// action.
    /// </para>
    ///  <p class="title"> <b>About Permissions</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If the private CA and the certificates it issues reside in the same account, you can
    /// use <code>CreatePermission</code> to grant permissions for ACM to carry out automatic
    /// certificate renewals.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For automatic certificate renewal to succeed, the ACM service principal needs permissions
    /// to create, retrieve, and list certificates.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If the private CA and the ACM certificates reside in different accounts, then permissions
    /// cannot be used to enable automatic renewals. Instead, the ACM certificate owner must
    /// set up a resource-based policy to enable cross-account issuance and renewals. For
    /// more information, see <a href="https://docs.aws.amazon.com/privateca/latest/userguide/pca-rbp.html">Using
    /// a Resource Based Policy with Amazon Web Services Private CA</a>.
    /// </para>
    ///  </li> </ul>
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
        /// by calling the <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_ListCertificateAuthorities.html">ListCertificateAuthorities</a>
        /// action. This must be of the form: <code>arn:aws:acm-pca:region:account:certificate-authority/12345678-1234-1234-1234-123456789012</code>
        /// You can get a private CA's ARN by running the <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_ListCertificateAuthorities.html">ListCertificateAuthorities</a>
        /// action.
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