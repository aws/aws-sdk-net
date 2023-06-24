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
    /// Container for the parameters to the DeletePermission operation.
    /// Revokes permissions on a private CA granted to the Certificate Manager (ACM) service
    /// principal (acm.amazonaws.com). 
    /// 
    ///  
    /// <para>
    /// These permissions allow ACM to issue and renew ACM certificates that reside in the
    /// same Amazon Web Services account as the CA. If you revoke these permissions, ACM will
    /// no longer renew the affected certificates automatically.
    /// </para>
    ///  
    /// <para>
    /// Permissions can be granted with the <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_CreatePermission.html">CreatePermission</a>
    /// action and listed with the <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_ListPermissions.html">ListPermissions</a>
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
    public partial class DeletePermissionRequest : AmazonACMPCARequest
    {
        private string _certificateAuthorityArn;
        private string _principal;
        private string _sourceAccount;

        /// <summary>
        /// Gets and sets the property CertificateAuthorityArn. 
        /// <para>
        /// The Amazon Resource Number (ARN) of the private CA that issued the permissions. You
        /// can find the CA's ARN by calling the <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_ListCertificateAuthorities.html">ListCertificateAuthorities</a>
        /// action. This must have the following form: 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:acm-pca:<i>region</i>:<i>account</i>:certificate-authority/<i>12345678-1234-1234-1234-123456789012</i>
        /// </code>. 
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
        /// Gets and sets the property Principal. 
        /// <para>
        /// The Amazon Web Services service or identity that will have its CA permissions revoked.
        /// At this time, the only valid service principal is <code>acm.amazonaws.com</code> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=128)]
        public string Principal
        {
            get { return this._principal; }
            set { this._principal = value; }
        }

        // Check to see if Principal property is set
        internal bool IsSetPrincipal()
        {
            return this._principal != null;
        }

        /// <summary>
        /// Gets and sets the property SourceAccount. 
        /// <para>
        /// The Amazon Web Services account that calls this action.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string SourceAccount
        {
            get { return this._sourceAccount; }
            set { this._sourceAccount = value; }
        }

        // Check to see if SourceAccount property is set
        internal bool IsSetSourceAccount()
        {
            return this._sourceAccount != null;
        }

    }
}