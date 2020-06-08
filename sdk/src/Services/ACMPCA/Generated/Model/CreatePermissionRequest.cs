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
    /// Container for the parameters to the CreatePermission operation.
    /// Assigns permissions from a private CA to a designated AWS service. Services are specified
    /// by their service principals and can be given permission to create and retrieve certificates
    /// on a private CA. Services can also be given permission to list the active permissions
    /// that the private CA has granted. For ACM to automatically renew your private CA's
    /// certificates, you must assign all possible permissions from the CA to the ACM service
    /// principal.
    /// 
    ///  
    /// <para>
    /// At this time, you can only assign permissions to ACM (<code>acm.amazonaws.com</code>).
    /// Permissions can be revoked with the <a>DeletePermission</a> action and listed with
    /// the <a>ListPermissions</a> action.
    /// </para>
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
        /// The actions that the specified AWS service principal can use. These include <code>IssueCertificate</code>,
        /// <code>GetCertificate</code>, and <code>ListPermissions</code>.
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
        /// the ARN by calling the <a>ListCertificateAuthorities</a> action. This must have the
        /// following form: 
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
        /// The AWS service or identity that receives the permission. At this time, the only valid
        /// principal is <code>acm.amazonaws.com</code>.
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