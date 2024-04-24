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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
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
namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Information about credentials that provide access to a private Docker registry. When
    /// this is set: 
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <c>imagePullCredentialsType</c> must be set to <c>SERVICE_ROLE</c>. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  images cannot be curated or an Amazon ECR image.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  For more information, see <a href="https://docs.aws.amazon.com/codebuild/latest/userguide/sample-private-registry.html">Private
    /// Registry with Secrets Manager Sample for CodeBuild</a>. 
    /// </para>
    /// </summary>
    public partial class RegistryCredential
    {
        private string _credential;
        private CredentialProviderType _credentialProvider;

        /// <summary>
        /// Gets and sets the property Credential. 
        /// <para>
        ///  The Amazon Resource Name (ARN) or name of credentials created using Secrets Manager.
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        ///  The <c>credential</c> can use the name of the credentials only if they exist in your
        /// current Amazon Web Services Region. 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
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
        ///  The service that created the credentials to access a private Docker registry. The
        /// valid value, SECRETS_MANAGER, is for Secrets Manager. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CredentialProviderType CredentialProvider
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