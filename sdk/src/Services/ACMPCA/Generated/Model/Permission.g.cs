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
    /// Permissions designate which private CA actions can be performed by an Amazon Web Services
    /// service or entity. In order for ACM to automatically renew private certificates, you
    /// must give the ACM service principal all available permissions (<c>IssueCertificate</c>,
    /// <c>GetCertificate</c>, and <c>ListPermissions</c>). Permissions can be assigned with
    /// the <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_CreatePermission.html">CreatePermission</a>
    /// action, removed with the <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_DeletePermission.html">DeletePermission</a>
    /// action, and listed with the <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_ListPermissions.html">ListPermissions</a>
    /// action.
    /// </summary>
    public partial class Permission
    {
        /// <summary>
        /// Gets and sets the property Actions. 
        /// <para>
        /// The private CA actions that can be performed by the designated Amazon Web Services
        /// service.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 3)]
        public List<string> Actions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Actions property is set.
        /// </summary>
        internal bool IsSetActions() => this.Actions != null && (this.Actions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CertificateAuthorityArn. 
        /// <para>
        /// The Amazon Resource Number (ARN) of the private CA from which the permission was issued.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 5, Max = 200)]
        public string CertificateAuthorityArn { get; set; }

        /// <summary>
        /// Checks to see if the CertificateAuthorityArn property is set.
        /// </summary>
        internal bool IsSetCertificateAuthorityArn() => this.CertificateAuthorityArn != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time at which the permission was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Policy. 
        /// <para>
        /// The name of the policy that is associated with the permission.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 81920)]
        public string Policy { get; set; }

        /// <summary>
        /// Checks to see if the Policy property is set.
        /// </summary>
        internal bool IsSetPolicy() => this.Policy != null;

        /// <summary>
        /// Gets and sets the property Principal. 
        /// <para>
        /// The Amazon Web Services service or entity that holds the permission. At this time,
        /// the only valid principal is <c>acm.amazonaws.com</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string Principal { get; set; }

        /// <summary>
        /// Checks to see if the Principal property is set.
        /// </summary>
        internal bool IsSetPrincipal() => this.Principal != null;

        /// <summary>
        /// Gets and sets the property SourceAccount. 
        /// <para>
        /// The ID of the account that assigned the permission.
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
