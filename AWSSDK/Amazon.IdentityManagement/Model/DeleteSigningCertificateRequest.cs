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
    /// Container for the parameters to the DeleteSigningCertificate operation.
    /// Deletes the specified signing certificate associated with the specified user.
    /// 
    ///         
    /// <para>
    /// If you do not specify a user name, IAM determines the user name implicitly based on
    /// the AWS            access key ID signing the request. Because this action works for access
    /// keys under the AWS            account, you can use this API to manage root credentials even
    /// if the AWS account has no            associated users.
    /// </para>
    /// </summary>
    public partial class DeleteSigningCertificateRequest : AmazonWebServiceRequest
    {
        private string _certificateId;
        private string _userName;


        /// <summary>
        /// Gets and sets the property CertificateId. 
        /// <para>
        /// ID of the signing certificate to delete.
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
        public DeleteSigningCertificateRequest WithCertificateId(string certificateId)
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
        /// Gets and sets the property UserName. 
        /// <para>
        /// Name of the user the signing certificate belongs to.
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
        public DeleteSigningCertificateRequest WithUserName(string userName)
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