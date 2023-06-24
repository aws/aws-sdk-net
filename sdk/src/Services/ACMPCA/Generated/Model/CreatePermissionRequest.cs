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
    /// Container for the parameters to the CreatePermission operation.
    /// Grants one or more permissions on a private CA to the Certificate Manager (ACM) service
    /// principal (<code>acm.amazonaws.com</code>). These permissions allow ACM to issue and
    /// renew ACM certificates that reside in the same Amazon Web Services account as the
    /// CA.
    /// 
    ///  
    /// <para>
    /// You can list current permissions with the <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_ListPermissions.html">ListPermissions</a>
    /// action and revoke them with the <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_DeletePermission.html">DeletePermission</a>
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
    public partial class CreatePermissionRequest : AmazonACMPCARequest
    {
        private List<string> _actions = new List<string>();
        private string _certificateAuthorityArn;
        private string _principal;
        private string _sourceAccount;

        /// <summary>
        /// Gets and sets the property Actions. 
        /// <para>
        /// The actions that the specified Amazon Web Services service principal can use. These
        /// include <code>IssueCertificate</code>, <code>GetCertificate</code>, and <code>ListPermissions</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=3)]
        public List<string> Actions
        {
            get { return this._actions; }
            set { this._actions = value; }
        }

        // Check to see if Actions property is set
        internal bool IsSetActions()
        {
            return this._actions != null && this._actions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CertificateAuthorityArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the CA that grants the permissions. You can find
        /// the ARN by calling the <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_ListCertificateAuthorities.html">ListCertificateAuthorities</a>
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
        /// The Amazon Web Services service or identity that receives the permission. At this
        /// time, the only valid principal is <code>acm.amazonaws.com</code>.
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
        /// The ID of the calling account.
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