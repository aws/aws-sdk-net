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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteSigningCertificate operation.
    /// Deletes a signing certificate associated with the specified IAM user.
    /// 
    ///  
    /// <para>
    /// If you do not specify a user name, IAM determines the user name implicitly based on
    /// the Amazon Web Services access key ID signing the request. This operation works for
    /// access keys under the Amazon Web Services account. Consequently, you can use this
    /// operation to manage Amazon Web Services account root user credentials even if the
    /// Amazon Web Services account has no associated IAM users.
    /// </para>
    /// </summary>
    public partial class DeleteSigningCertificateRequest : AmazonIdentityManagementServiceRequest
    {
        private string _certificateId;
        private string _userName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DeleteSigningCertificateRequest() { }

        /// <summary>
        /// Instantiates DeleteSigningCertificateRequest with the parameterized properties
        /// </summary>
        /// <param name="certificateId">The ID of the signing certificate to delete. The format of this parameter, as described by its <a href="http://wikipedia.org/wiki/regex">regex</a> pattern, is a string of characters that can be upper- or lower-cased letters or digits.</param>
        public DeleteSigningCertificateRequest(string certificateId)
        {
            _certificateId = certificateId;
        }

        /// <summary>
        /// Gets and sets the property CertificateId. 
        /// <para>
        /// The ID of the signing certificate to delete.
        /// </para>
        ///  
        /// <para>
        /// The format of this parameter, as described by its <a href="http://wikipedia.org/wiki/regex">regex</a>
        /// pattern, is a string of characters that can be upper- or lower-cased letters or digits.
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
        /// Gets and sets the property UserName. 
        /// <para>
        /// The name of the user the signing certificate belongs to.
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