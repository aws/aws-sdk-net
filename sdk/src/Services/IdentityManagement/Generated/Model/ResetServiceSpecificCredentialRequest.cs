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
    /// Container for the parameters to the ResetServiceSpecificCredential operation.
    /// Resets the password for a service-specific credential. The new password is Amazon
    /// Web Services generated and cryptographically strong. It cannot be configured by the
    /// user. Resetting the password immediately invalidates the previous password associated
    /// with this user.
    /// </summary>
    public partial class ResetServiceSpecificCredentialRequest : AmazonIdentityManagementServiceRequest
    {
        private string _serviceSpecificCredentialId;
        private string _userName;

        /// <summary>
        /// Gets and sets the property ServiceSpecificCredentialId. 
        /// <para>
        /// The unique identifier of the service-specific credential.
        /// </para>
        ///  
        /// <para>
        /// This parameter allows (through its <a href="http://wikipedia.org/wiki/regex">regex
        /// pattern</a>) a string of characters that can consist of any upper or lowercased letter
        /// or digit.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=128)]
        public string ServiceSpecificCredentialId
        {
            get { return this._serviceSpecificCredentialId; }
            set { this._serviceSpecificCredentialId = value; }
        }

        // Check to see if ServiceSpecificCredentialId property is set
        internal bool IsSetServiceSpecificCredentialId()
        {
            return this._serviceSpecificCredentialId != null;
        }

        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// The name of the IAM user associated with the service-specific credential. If this
        /// value is not specified, then the operation assumes the user whose credentials are
        /// used to call the operation.
        /// </para>
        ///  
        /// <para>
        /// This parameter allows (through its <a href="http://wikipedia.org/wiki/regex">regex
        /// pattern</a>) a string of characters consisting of upper and lowercase alphanumeric
        /// characters with no spaces. You can also include any of the following characters: _+=,.@-
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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