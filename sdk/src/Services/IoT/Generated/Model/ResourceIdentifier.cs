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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// Information that identifies the noncompliant resource.
    /// </summary>
    public partial class ResourceIdentifier
    {
        private string _account;
        private string _caCertificateId;
        private string _clientId;
        private string _cognitoIdentityPoolId;
        private string _deviceCertificateArn;
        private string _deviceCertificateId;
        private string _iamRoleArn;
        private IssuerCertificateIdentifier _issuerCertificateIdentifier;
        private PolicyVersionIdentifier _policyVersionIdentifier;
        private string _roleAliasArn;

        /// <summary>
        /// Gets and sets the property Account. 
        /// <para>
        /// The account with which the resource is associated.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string Account
        {
            get { return this._account; }
            set { this._account = value; }
        }

        // Check to see if Account property is set
        internal bool IsSetAccount()
        {
            return this._account != null;
        }

        /// <summary>
        /// Gets and sets the property CaCertificateId. 
        /// <para>
        /// The ID of the CA certificate used to authorize the certificate.
        /// </para>
        /// </summary>
        [AWSProperty(Min=64, Max=64)]
        public string CaCertificateId
        {
            get { return this._caCertificateId; }
            set { this._caCertificateId = value; }
        }

        // Check to see if CaCertificateId property is set
        internal bool IsSetCaCertificateId()
        {
            return this._caCertificateId != null;
        }

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The client ID.
        /// </para>
        /// </summary>
        public string ClientId
        {
            get { return this._clientId; }
            set { this._clientId = value; }
        }

        // Check to see if ClientId property is set
        internal bool IsSetClientId()
        {
            return this._clientId != null;
        }

        /// <summary>
        /// Gets and sets the property CognitoIdentityPoolId. 
        /// <para>
        /// The ID of the Amazon Cognito identity pool.
        /// </para>
        /// </summary>
        public string CognitoIdentityPoolId
        {
            get { return this._cognitoIdentityPoolId; }
            set { this._cognitoIdentityPoolId = value; }
        }

        // Check to see if CognitoIdentityPoolId property is set
        internal bool IsSetCognitoIdentityPoolId()
        {
            return this._cognitoIdentityPoolId != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceCertificateArn. 
        /// <para>
        /// The ARN of the identified device certificate.
        /// </para>
        /// </summary>
        public string DeviceCertificateArn
        {
            get { return this._deviceCertificateArn; }
            set { this._deviceCertificateArn = value; }
        }

        // Check to see if DeviceCertificateArn property is set
        internal bool IsSetDeviceCertificateArn()
        {
            return this._deviceCertificateArn != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceCertificateId. 
        /// <para>
        /// The ID of the certificate attached to the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=64, Max=64)]
        public string DeviceCertificateId
        {
            get { return this._deviceCertificateId; }
            set { this._deviceCertificateId = value; }
        }

        // Check to see if DeviceCertificateId property is set
        internal bool IsSetDeviceCertificateId()
        {
            return this._deviceCertificateId != null;
        }

        /// <summary>
        /// Gets and sets the property IamRoleArn. 
        /// <para>
        /// The ARN of the IAM role that has overly permissive actions.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string IamRoleArn
        {
            get { return this._iamRoleArn; }
            set { this._iamRoleArn = value; }
        }

        // Check to see if IamRoleArn property is set
        internal bool IsSetIamRoleArn()
        {
            return this._iamRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property IssuerCertificateIdentifier. 
        /// <para>
        /// The issuer certificate identifier.
        /// </para>
        /// </summary>
        public IssuerCertificateIdentifier IssuerCertificateIdentifier
        {
            get { return this._issuerCertificateIdentifier; }
            set { this._issuerCertificateIdentifier = value; }
        }

        // Check to see if IssuerCertificateIdentifier property is set
        internal bool IsSetIssuerCertificateIdentifier()
        {
            return this._issuerCertificateIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyVersionIdentifier. 
        /// <para>
        /// The version of the policy associated with the resource.
        /// </para>
        /// </summary>
        public PolicyVersionIdentifier PolicyVersionIdentifier
        {
            get { return this._policyVersionIdentifier; }
            set { this._policyVersionIdentifier = value; }
        }

        // Check to see if PolicyVersionIdentifier property is set
        internal bool IsSetPolicyVersionIdentifier()
        {
            return this._policyVersionIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property RoleAliasArn. 
        /// <para>
        /// The ARN of the role alias that has overly permissive actions.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string RoleAliasArn
        {
            get { return this._roleAliasArn; }
            set { this._roleAliasArn = value; }
        }

        // Check to see if RoleAliasArn property is set
        internal bool IsSetRoleAliasArn()
        {
            return this._roleAliasArn != null;
        }

    }
}