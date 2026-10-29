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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property Account. 
        /// <para>
        /// The account with which the resource is associated.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string Account { get; set; }

        /// <summary>
        /// Checks to see if the Account property is set.
        /// </summary>
        internal bool IsSetAccount() => this.Account != null;

        /// <summary>
        /// Gets and sets the property CaCertificateId. 
        /// <para>
        /// The ID of the CA certificate used to authorize the certificate.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 64, Max = 64)]
        public string CaCertificateId { get; set; }

        /// <summary>
        /// Checks to see if the CaCertificateId property is set.
        /// </summary>
        internal bool IsSetCaCertificateId() => this.CaCertificateId != null;

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The client ID.
        /// </para>
        /// </summary>
        public string ClientId { get; set; }

        /// <summary>
        /// Checks to see if the ClientId property is set.
        /// </summary>
        internal bool IsSetClientId() => this.ClientId != null;

        /// <summary>
        /// Gets and sets the property CognitoIdentityPoolId. 
        /// <para>
        /// The ID of the Amazon Cognito identity pool.
        /// </para>
        /// </summary>
        public string CognitoIdentityPoolId { get; set; }

        /// <summary>
        /// Checks to see if the CognitoIdentityPoolId property is set.
        /// </summary>
        internal bool IsSetCognitoIdentityPoolId() => this.CognitoIdentityPoolId != null;

        /// <summary>
        /// Gets and sets the property DeviceCertificateArn. 
        /// <para>
        /// The ARN of the identified device certificate.
        /// </para>
        /// </summary>
        public string DeviceCertificateArn { get; set; }

        /// <summary>
        /// Checks to see if the DeviceCertificateArn property is set.
        /// </summary>
        internal bool IsSetDeviceCertificateArn() => this.DeviceCertificateArn != null;

        /// <summary>
        /// Gets and sets the property DeviceCertificateId. 
        /// <para>
        /// The ID of the certificate attached to the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 64, Max = 64)]
        public string DeviceCertificateId { get; set; }

        /// <summary>
        /// Checks to see if the DeviceCertificateId property is set.
        /// </summary>
        internal bool IsSetDeviceCertificateId() => this.DeviceCertificateId != null;

        /// <summary>
        /// Gets and sets the property IamRoleArn. 
        /// <para>
        /// The ARN of the IAM role that has overly permissive actions.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string IamRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the IamRoleArn property is set.
        /// </summary>
        internal bool IsSetIamRoleArn() => this.IamRoleArn != null;

        /// <summary>
        /// Gets and sets the property IssuerCertificateIdentifier. 
        /// <para>
        /// The issuer certificate identifier.
        /// </para>
        /// </summary>
        public IssuerCertificateIdentifier IssuerCertificateIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the IssuerCertificateIdentifier property is set.
        /// </summary>
        internal bool IsSetIssuerCertificateIdentifier() => this.IssuerCertificateIdentifier != null;

        /// <summary>
        /// Gets and sets the property PolicyVersionIdentifier. 
        /// <para>
        /// The version of the policy associated with the resource.
        /// </para>
        /// </summary>
        public PolicyVersionIdentifier PolicyVersionIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the PolicyVersionIdentifier property is set.
        /// </summary>
        internal bool IsSetPolicyVersionIdentifier() => this.PolicyVersionIdentifier != null;

        /// <summary>
        /// Gets and sets the property RoleAliasArn. 
        /// <para>
        /// The ARN of the role alias that has overly permissive actions.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string RoleAliasArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleAliasArn property is set.
        /// </summary>
        internal bool IsSetRoleAliasArn() => this.RoleAliasArn != null;
    }
}
