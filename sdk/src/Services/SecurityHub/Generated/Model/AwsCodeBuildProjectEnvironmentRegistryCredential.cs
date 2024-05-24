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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// The credentials for access to a private registry.
    /// </summary>
    public partial class AwsCodeBuildProjectEnvironmentRegistryCredential
    {
        private string _credential;
        private string _credentialProvider;

        /// <summary>
        /// Gets and sets the property Credential. 
        /// <para>
        /// The ARN or name of credentials created using Secrets Manager.
        /// </para>
        ///  <note> 
        /// <para>
        /// The credential can use the name of the credentials only if they exist in your current
        /// Amazon Web Services Region. 
        /// </para>
        ///  </note>
        /// </summary>
        public string Credential
        {
            get { return this._credential; }
            set { this._credential = value; }
        }

        // Check to see if Credential property is set
        internal bool IsSetCredential()
        {
            return this._credential != null;
        }

        /// <summary>
        /// Gets and sets the property CredentialProvider. 
        /// <para>
        /// The service that created the credentials to access a private Docker registry.
        /// </para>
        ///  
        /// <para>
        /// The valid value,<c> SECRETS_MANAGER</c>, is for Secrets Manager.
        /// </para>
        /// </summary>
        public string CredentialProvider
        {
            get { return this._credentialProvider; }
            set { this._credentialProvider = value; }
        }

        // Check to see if CredentialProvider property is set
        internal bool IsSetCredentialProvider()
        {
            return this._credentialProvider != null;
        }

    }
}