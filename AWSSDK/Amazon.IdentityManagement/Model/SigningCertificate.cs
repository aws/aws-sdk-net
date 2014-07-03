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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// The SigningCertificate data type contains information about an X.509 signing certificate.
    /// 
    ///         
    /// <para>
    ///  This data type is used as a response element in the actions <a>UploadSigningCertificate</a>            and
    /// <a>ListSigningCertificates</a>. 
    /// </para>
    /// </summary>
    public partial class SigningCertificate
    {
        private string _certificateBody;
        private string _certificateId;
        private string _status;
        private DateTime? _uploadDate;
        private string _userName;


        /// <summary>
        /// Gets and sets the property CertificateBody. 
        /// <para>
        /// The contents of the signing certificate.
        /// </para>
        /// </summary>
        public string CertificateBody
        {
            get { return this._certificateBody; }
            set { this._certificateBody = value; }
        }


        /// <summary>
        /// Sets the CertificateBody property
        /// </summary>
        /// <param name="certificateBody">The value to set for the CertificateBody property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SigningCertificate WithCertificateBody(string certificateBody)
        {
            this._certificateBody = certificateBody;
            return this;
        }

        // Check to see if CertificateBody property is set
        internal bool IsSetCertificateBody()
        {
            return this._certificateBody != null;
        }


        /// <summary>
        /// Gets and sets the property CertificateId. 
        /// <para>
        /// The ID for the signing certificate.
        /// </para>
        /// </summary>
        public string CertificateId
        {
            get { return this._certificateId; }
            set { this._certificateId = value; }
        }


        /// <summary>
        /// Sets the CertificateId property
        /// </summary>
        /// <param name="certificateId">The value to set for the CertificateId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SigningCertificate WithCertificateId(string certificateId)
        {
            this._certificateId = certificateId;
            return this;
        }

        // Check to see if CertificateId property is set
        internal bool IsSetCertificateId()
        {
            return this._certificateId != null;
        }


        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the signing certificate. <code>Active</code> means the key is valid
        /// for API            calls, while <code>Inactive</code> means it is not.
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }


        /// <summary>
        /// Sets the Status property
        /// </summary>
        /// <param name="status">The value to set for the Status property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SigningCertificate WithStatus(string status)
        {
            this._status = status;
            return this;
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }


        /// <summary>
        /// Gets and sets the property UploadDate. 
        /// <para>
        /// The date when the signing certificate was uploaded.
        /// </para>
        /// </summary>
        public DateTime UploadDate
        {
            get { return this._uploadDate.GetValueOrDefault(); }
            set { this._uploadDate = value; }
        }


        /// <summary>
        /// Sets the UploadDate property
        /// </summary>
        /// <param name="uploadDate">The value to set for the UploadDate property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SigningCertificate WithUploadDate(DateTime uploadDate)
        {
            this._uploadDate = uploadDate;
            return this;
        }

        // Check to see if UploadDate property is set
        internal bool IsSetUploadDate()
        {
            return this._uploadDate.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// Name of the user the signing certificate is associated with.
        /// </para>
        /// </summary>
        public string UserName
        {
            get { return this._userName; }
            set { this._userName = value; }
        }


        /// <summary>
        /// Sets the UserName property
        /// </summary>
        /// <param name="userName">The value to set for the UserName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SigningCertificate WithUserName(string userName)
        {
            this._userName = userName;
            return this;
        }

        // Check to see if UserName property is set
        internal bool IsSetUserName()
        {
            return this._userName != null;
        }

    }
}