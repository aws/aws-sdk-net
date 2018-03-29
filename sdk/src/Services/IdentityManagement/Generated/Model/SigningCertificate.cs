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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
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
    /// Contains information about an X.509 signing certificate.
    /// 
    ///  
    /// <para>
    /// This data type is used as a response element in the <a>UploadSigningCertificate</a>
    /// and <a>ListSigningCertificates</a> operations. 
    /// </para>
    /// </summary>
    public partial class SigningCertificate
    {
        private string _certificateBody;
        private string _certificateId;
        private StatusType _status;
        private DateTime? _uploadDate;
        private string _userName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public SigningCertificate() { }

        /// <summary>
        /// Instantiates SigningCertificate with the parameterized properties
        /// </summary>
        /// <param name="userName">The name of the user the signing certificate is associated with.</param>
        /// <param name="certificateId">The ID for the signing certificate.</param>
        /// <param name="certificateBody">The contents of the signing certificate.</param>
        /// <param name="status">The status of the signing certificate. <code>Active</code> means that the key is valid for API calls, while <code>Inactive</code> means it is not.</param>
        public SigningCertificate(string userName, string certificateId, string certificateBody, StatusType status)
        {
            _userName = userName;
            _certificateId = certificateId;
            _certificateBody = certificateBody;
            _status = status;
        }

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

        // Check to see if CertificateId property is set
        internal bool IsSetCertificateId()
        {
            return this._certificateId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the signing certificate. <code>Active</code> means that the key is valid
        /// for API calls, while <code>Inactive</code> means it is not.
        /// </para>
        /// </summary>
        public StatusType Status
        {
            get { return this._status; }
            set { this._status = value; }
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

        // Check to see if UploadDate property is set
        internal bool IsSetUploadDate()
        {
            return this._uploadDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// The name of the user the signing certificate is associated with.
        /// </para>
        /// </summary>
        public string UserName
        {
            get { return this._userName; }
            set { this._userName = value; }
        }

        // Check to see if UserName property is set
        internal bool IsSetUserName()
        {
            return this._userName != null;
        }

    }
}