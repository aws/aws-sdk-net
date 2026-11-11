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

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Contains information about an X.509 signing certificate.
    /// 
    ///  
    /// <para>
    /// This data type is used as a response element in the <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_UploadSigningCertificate.html">UploadSigningCertificate</a>
    /// and <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_ListSigningCertificates.html">ListSigningCertificates</a>
    /// operations. 
    /// </para>
    /// </summary>
    public partial class SigningCertificate
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public SigningCertificate() { }

        /// <summary>
        /// Instantiates SigningCertificate with the parameterized properties
        /// </summary>
        /// <param name="userName">The name of the user the signing certificate is associated with.</param>
        /// <param name="certificateId">The ID for the signing certificate.</param>
        /// <param name="certificateBody">The contents of the signing certificate.</param>
        /// <param name="status">The status of the signing certificate. <c>Active</c> means that the key is valid   for API calls, while <c>Inactive</c> means it is not.</param>
        public SigningCertificate(string userName, string certificateId, string certificateBody, StatusType status)
        {
            this.UserName = userName;
            this.CertificateId = certificateId;
            this.CertificateBody = certificateBody;
            this.Status = status;
        }

        /// <summary>
        /// Gets and sets the property CertificateBody. 
        /// <para>
        /// The contents of the signing certificate.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 16384)]
        public string CertificateBody { get; set; }

        /// <summary>
        /// Checks to see if the CertificateBody property is set.
        /// </summary>
        internal bool IsSetCertificateBody() => this.CertificateBody != null;

        /// <summary>
        /// Gets and sets the property CertificateId. 
        /// <para>
        /// The ID for the signing certificate.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 24, Max = 128)]
        public string CertificateId { get; set; }

        /// <summary>
        /// Checks to see if the CertificateId property is set.
        /// </summary>
        internal bool IsSetCertificateId() => this.CertificateId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the signing certificate. <c>Active</c> means that the key is valid for
        /// API calls, while <c>Inactive</c> means it is not.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public StatusType Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UploadDate. 
        /// <para>
        /// The date when the signing certificate was uploaded.
        /// </para>
        /// </summary>
        public DateTime? UploadDate { get; set; }

        /// <summary>
        /// Checks to see if the UploadDate property is set.
        /// </summary>
        internal bool IsSetUploadDate() => this.UploadDate.HasValue;

        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// The name of the user the signing certificate is associated with.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string UserName { get; set; }

        /// <summary>
        /// Checks to see if the UserName property is set.
        /// </summary>
        internal bool IsSetUserName() => this.UserName != null;
    }
}
