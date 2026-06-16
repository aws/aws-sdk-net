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
    /// You can reset the password to a new service-generated value by calling <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_ResetServiceSpecificCredential.html">ResetServiceSpecificCredential</a>.
    /// </para>
    ///  
    /// <para>
    /// For more information about using service-specific credentials to authenticate to an
    /// Amazon Web Services service, refer to the following docs:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// For service-specific credentials with CodeCommit, refer to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_ssh-keys.html">IAM
    /// credentials for CodeCommit: Git credentials, SSH keys, and Amazon Web Services access
    /// keys</a> in the <i>IAM User Guide</i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For service-specific credentials with Amazon Keyspaces (for Apache Cassandra), refer
    /// to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_keyspaces.html">Use
    /// IAM with Amazon Keyspaces (for Apache Cassandra)</a> in the <i>IAM User Guide</i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For services that support long-term API keys, refer to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_api_keys_for_aws_services.html">API
    /// keys for Amazon Web Services services</a> in the <i>IAM User Guide</i>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateServiceSpecificCredentialRequest : AmazonIdentityManagementServiceRequest
    {
        private int? _credentialAgeDays;
        private string _serviceName;
        private string _userName;

        /// <summary>
        /// Gets and sets the property CredentialAgeDays. 
        /// <para>
        /// The number of days until the service specific credential expires. This field is only
        /// valid for services that support long-term API keys and must be a positive integer.
        /// When not specified, the credential will not expire.
        /// </para>
        ///  
        /// <para>
        /// To see which services support long-term API keys, refer to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_api_keys_for_aws_services.html">API
        /// keys for Amazon Web Services services</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=36600)]
        public int? CredentialAgeDays
        {
            get { return this._credentialAgeDays; }
            set { this._credentialAgeDays = value; }
        }

        // Check to see if CredentialAgeDays property is set
        internal bool IsSetCredentialAgeDays()
        {
            return this._credentialAgeDays.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The name of the Amazon Web Services service that is to be associated with the credentials.
        /// The service you specify here is the only service that can be accessed using these
        /// credentials.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// This parameter allows (through its <a href="http://wikipedia.org/wiki/regex">regex
        /// pattern</a>) a string of characters consisting of upper and lowercase alphanumeric
        /// characters with no spaces. You can also include any of the following characters: _+=,.@-
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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