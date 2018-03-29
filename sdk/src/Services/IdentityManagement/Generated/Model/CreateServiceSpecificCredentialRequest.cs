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
    /// Container for the parameters to the CreateServiceSpecificCredential operation.
    /// Generates a set of credentials consisting of a user name and password that can be
    /// used to access the service specified in the request. These credentials are generated
    /// by IAM, and can be used only for the specified service. 
    /// 
    ///  
    /// <para>
    /// You can have a maximum of two sets of service-specific credentials for each supported
    /// service per user.
    /// </para>
    ///  
    /// <para>
    /// The only supported service at this time is AWS CodeCommit.
    /// </para>
    ///  
    /// <para>
    /// You can reset the password to a new service-generated value by calling <a>ResetServiceSpecificCredential</a>.
    /// </para>
    ///  
    /// <para>
    /// For more information about service-specific credentials, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_ssh-keys.html">Using
    /// IAM with AWS CodeCommit: Git Credentials, SSH Keys, and AWS Access Keys</a> in the
    /// <i>IAM User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateServiceSpecificCredentialRequest : AmazonIdentityManagementServiceRequest
    {
        private string _serviceName;
        private string _userName;

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The name of the AWS service that is to be associated with the credentials. The service
        /// you specify here is the only service that can be accessed using these credentials.
        /// </para>
        /// </summary>
        public string ServiceName
        {
            get { return this._serviceName; }
            set { this._serviceName = value; }
        }

        // Check to see if ServiceName property is set
        internal bool IsSetServiceName()
        {
            return this._serviceName != null;
        }

        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// The name of the IAM user that is to be associated with the credentials. The new service-specific
        /// credentials have the same permissions as the associated user except that they can
        /// be used only to access the specified service.
        /// </para>
        ///  
        /// <para>
        /// This parameter allows (per its <a href="http://wikipedia.org/wiki/regex">regex pattern</a>)
        /// a string of characters consisting of upper and lowercase alphanumeric characters with
        /// no spaces. You can also include any of the following characters: _+=,.@-
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