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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateSigningCertificate operation.
    /// Changes the status of the specified user signing certificate from active to disabled,
    /// or vice versa. This operation can be used to disable an IAM user's signing certificate
    /// as part of a certificate rotation work flow.
    /// 
    ///  
    /// <para>
    /// If the <code>UserName</code> field is not specified, the user name is determined implicitly
    /// based on the AWS access key ID used to sign the request. This operation works for
    /// access keys under the AWS account. Consequently, you can use this operation to manage
    /// AWS account root user credentials even if the AWS account has no associated users.
    /// </para>
    /// </summary>
    public partial class UpdateSigningCertificateRequest : AmazonIdentityManagementServiceRequest
    {
        private string _certificateId;
        private StatusType _status;
        private string _userName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public UpdateSigningCertificateRequest() { }

        /// <summary>
        /// Instantiates UpdateSigningCertificateRequest with the parameterized properties
        /// </summary>
        /// <param name="certificateId">The ID of the signing certificate you want to update. This parameter allows (through its <a href="http://wikipedia.org/wiki/regex">regex pattern</a>) a string of characters that can consist of any upper or lowercased letter or digit.</param>
        /// <param name="status"> The status you want to assign to the certificate. <code>Active</code> means that the certificate can be used for API calls to AWS <code>Inactive</code> means that the certificate cannot be used.</param>
        public UpdateSigningCertificateRequest(string certificateId, StatusType status)
        {
            _certificateId = certificateId;
            _status = status;
        }

        /// <summary>
        /// Gets and sets the property CertificateId. 
        /// <para>
        /// The ID of the signing certificate you want to update.
        /// </para>
        ///  
        /// <para>
        /// This parameter allows (through its <a href="http://wikipedia.org/wiki/regex">regex
        /// pattern</a>) a string of characters that can consist of any upper or lowercased letter
        /// or digit.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=24, Max=128)]
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
        ///  The status you want to assign to the certificate. <code>Active</code> means that
        /// the certificate can be used for API calls to AWS <code>Inactive</code> means that
        /// the certificate cannot be used.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property UserName. 
        /// <para>
        /// The name of the IAM user the signing certificate belongs to.
        /// </para>
        ///  
        /// <para>
        /// This parameter allows (through its <a href="http://wikipedia.org/wiki/regex">regex
        /// pattern</a>) a string of characters consisting of upper and lowercase alphanumeric
        /// characters with no spaces. You can also include any of the following characters: _+=,.@-
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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