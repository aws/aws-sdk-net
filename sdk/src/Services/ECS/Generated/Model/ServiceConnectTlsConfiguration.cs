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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
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
namespace Amazon.ECS.Model
{
    /// <summary>
    /// The key that encrypts and decrypts your resources for Service Connect TLS.
    /// </summary>
    public partial class ServiceConnectTlsConfiguration
    {
        private ServiceConnectTlsCertificateAuthority _issuerCertificateAuthority;
        private string _kmsKey;
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property IssuerCertificateAuthority. 
        /// <para>
        /// The signer certificate authority.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ServiceConnectTlsCertificateAuthority IssuerCertificateAuthority
        {
            get { return this._issuerCertificateAuthority; }
            set { this._issuerCertificateAuthority = value; }
        }

        // Check to see if IssuerCertificateAuthority property is set
        internal bool IsSetIssuerCertificateAuthority()
        {
            return this._issuerCertificateAuthority != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKey. 
        /// <para>
        /// The Amazon Web Services Key Management Service key.
        /// </para>
        /// </summary>
        public string KmsKey
        {
            get { return this._kmsKey; }
            set { this._kmsKey = value; }
        }

        // Check to see if KmsKey property is set
        internal bool IsSetKmsKey()
        {
            return this._kmsKey != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that's associated with the Service
        /// Connect TLS.
        /// </para>
        /// </summary>
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

    }
}