/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// <para>The SigningCertificate data type contains information about an X.509 signing certificate.</para> <para> This data type is used as a
    /// response element in the actions UploadSigningCertificate and ListSigningCertificates. </para>
    /// </summary>
    public class SigningCertificate  
    {
        
        private string userName;
        private string certificateId;
        private string certificateBody;
        private string status;
        private DateTime? uploadDate;

        /// <summary>
        /// Name of the user the signing certificate is associated with.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 64</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\w+=,.@-]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string UserName
        {
            get { return this.userName; }
            set { this.userName = value; }
        }

        /// <summary>
        /// Sets the UserName property
        /// </summary>
        /// <param name="userName">The value to set for the UserName property </param>
        /// <returns>this instance</returns>
        public SigningCertificate WithUserName(string userName)
        {
            this.userName = userName;
            return this;
        }
            

        // Check to see if UserName property is set
        internal bool IsSetUserName()
        {
            return this.userName != null;       
        }

        /// <summary>
        /// The ID for the signing certificate.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>24 - 128</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\w]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string CertificateId
        {
            get { return this.certificateId; }
            set { this.certificateId = value; }
        }

        /// <summary>
        /// Sets the CertificateId property
        /// </summary>
        /// <param name="certificateId">The value to set for the CertificateId property </param>
        /// <returns>this instance</returns>
        public SigningCertificate WithCertificateId(string certificateId)
        {
            this.certificateId = certificateId;
            return this;
        }
            

        // Check to see if CertificateId property is set
        internal bool IsSetCertificateId()
        {
            return this.certificateId != null;       
        }

        /// <summary>
        /// The contents of the signing certificate.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 16384</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0009\u000A\u000D\u0020-\u00FF]+</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string CertificateBody
        {
            get { return this.certificateBody; }
            set { this.certificateBody = value; }
        }

        /// <summary>
        /// Sets the CertificateBody property
        /// </summary>
        /// <param name="certificateBody">The value to set for the CertificateBody property </param>
        /// <returns>this instance</returns>
        public SigningCertificate WithCertificateBody(string certificateBody)
        {
            this.certificateBody = certificateBody;
            return this;
        }
            

        // Check to see if CertificateBody property is set
        internal bool IsSetCertificateBody()
        {
            return this.certificateBody != null;       
        }

        /// <summary>
        /// The status of the signing certificate. <c>Active</c> means the key is valid for API calls, while <c>Inactive</c> means it is not.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>Active, Inactive</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        /// <summary>
        /// Sets the Status property
        /// </summary>
        /// <param name="status">The value to set for the Status property </param>
        /// <returns>this instance</returns>
        public SigningCertificate WithStatus(string status)
        {
            this.status = status;
            return this;
        }
            

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this.status != null;       
        }

        /// <summary>
        /// The date when the signing certificate was uploaded.
        ///  
        /// </summary>
        public DateTime UploadDate
        {
            get { return this.uploadDate ?? default(DateTime); }
            set { this.uploadDate = value; }
        }

        /// <summary>
        /// Sets the UploadDate property
        /// </summary>
        /// <param name="uploadDate">The value to set for the UploadDate property </param>
        /// <returns>this instance</returns>
        public SigningCertificate WithUploadDate(DateTime uploadDate)
        {
            this.uploadDate = uploadDate;
            return this;
        }
            

        // Check to see if UploadDate property is set
        internal bool IsSetUploadDate()
        {
            return this.uploadDate.HasValue;       
        }
    }
}
