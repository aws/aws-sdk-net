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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.ACMPCA.Model
{
    /// <summary>
    /// Container for the parameters to the CreatePermission operation. Grants one or more
    /// permissions on a private CA to the Certificate Manager (ACM) service principal (<c>acm.amazonaws.com</c>).
    /// These permissions allow ACM to issue and renew ACM certificates that reside in the
    /// same Amazon Web Services account as the CA. <para> You can list current permissions
    /// with the <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_ListPermissions.html">ListPermissions</a>
    /// action and revoke them with the <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_DeletePermission.html">DeletePermission</a>
    /// action. </para> <para> <b>About Permissions</b> </para> <ul> <li> <para> If the private
    /// CA and the certificates it issues reside in the same account, you can use <c>CreatePermission</c>
    /// to grant permissions for ACM to carry out automatic certificate renewals. </para>
    /// </li> <li> <para> For automatic certificate renewal to succeed, the ACM service principal
    /// needs permissions to create, retrieve, and list certificates. </para> </li> <li> <para>
    /// If the private CA and the ACM certificates reside in different accounts, then permissions
    /// cannot be used to enable automatic renewals. Instead, the ACM certificate owner must
    /// set up a resource-based policy to enable cross-account issuance and renewals. For
    /// more information, see <a href="https://docs.aws.amazon.com/privateca/latest/userguide/pca-rbp.html">Using
    /// a Resource Based Policy with Amazon Web Services Private CA</a>. </para> </li> </ul>
    /// </summary>
    public partial class CreatePermissionRequest : AmazonACMPCARequest
    {
        /// <summary>
        /// Gets and sets the property Actions. 
        /// <para>
        /// The actions that the specified Amazon Web Services service principal can use. These
        /// include <c>IssueCertificate</c>, <c>GetCertificate</c>, and <c>ListPermissions</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 3)]
        public List<string> Actions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Actions property is set.
        /// </summary>
        internal bool IsSetActions() => this.Actions != null && (this.Actions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CertificateAuthorityArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the CA that grants the permissions. You can find
        /// the ARN by calling the <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_ListCertificateAuthorities.html">ListCertificateAuthorities</a>
        /// action. This must have the following form: 
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:aws:acm-pca:<i>region</i>:<i>account</i>:certificate-authority/<i>12345678-1234-1234-1234-123456789012</i>
        /// </c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 5, Max = 200)]
        public string CertificateAuthorityArn { get; set; }

        /// <summary>
        /// Checks to see if the CertificateAuthorityArn property is set.
        /// </summary>
        internal bool IsSetCertificateAuthorityArn() => this.CertificateAuthorityArn != null;

        /// <summary>
        /// Gets and sets the property Principal. 
        /// <para>
        /// The Amazon Web Services service or identity that receives the permission. At this
        /// time, the only valid principal is <c>acm.amazonaws.com</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 128)]
        public string Principal { get; set; }

        /// <summary>
        /// Checks to see if the Principal property is set.
        /// </summary>
        internal bool IsSetPrincipal() => this.Principal != null;

        /// <summary>
        /// Gets and sets the property SourceAccount. 
        /// <para>
        /// The ID of the calling account.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string SourceAccount { get; set; }

        /// <summary>
        /// Checks to see if the SourceAccount property is set.
        /// </summary>
        internal bool IsSetSourceAccount() => this.SourceAccount != null;
    }
}
