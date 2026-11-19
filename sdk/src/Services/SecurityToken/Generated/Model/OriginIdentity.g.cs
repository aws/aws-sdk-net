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

namespace Amazon.SecurityToken.Model
{
    /// <summary>
    /// The session's <c>aws:OriginIdentity/Subject</c>, <c>aws:OriginIdentity/SubjectType</c>,
    /// <c>aws:OriginIdentity/Issuer</c> and <c>aws:OriginIdentity/FederatedProviderArn</c>
    /// keys. A member is absent when the session does not have the key.
    /// </summary>
    public partial class OriginIdentity
    {
        /// <summary>
        /// Gets and sets the property FederatedProviderArn. 
        /// <para>
        /// The value of the <c>aws:OriginIdentity/FederatedProviderArn</c> key: the ARN of the
        /// IAM identity provider that the request federated through.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string FederatedProviderArn { get; set; }

        /// <summary>
        /// Checks to see if the FederatedProviderArn property is set.
        /// </summary>
        internal bool IsSetFederatedProviderArn() => this.FederatedProviderArn != null;

        /// <summary>
        /// Gets and sets the property Issuer. 
        /// <para>
        /// The value of the <c>aws:OriginIdentity/Issuer</c> key. For <c>AssumeRoleWithWebIdentity</c>,
        /// this is the <c>iss</c> claim of the token without the <c>https://</c> prefix. For
        /// <c>AssumeRoleWithSAML</c>, this is a hash of the key that signed the SAML assertion,
        /// not the <c>Issuer</c> element of the assertion.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string Issuer { get; set; }

        /// <summary>
        /// Checks to see if the Issuer property is set.
        /// </summary>
        internal bool IsSetIssuer() => this.Issuer != null;

        /// <summary>
        /// Gets and sets the property Subject. 
        /// <para>
        /// The value of the <c>aws:OriginIdentity/Subject</c> key: the end user's identifier,
        /// taken from the token claim that the context provider maps as the subject.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string Subject { get; set; }

        /// <summary>
        /// Checks to see if the Subject property is set.
        /// </summary>
        internal bool IsSetSubject() => this.Subject != null;

        /// <summary>
        /// Gets and sets the property SubjectType. 
        /// <para>
        /// The value of the <c>aws:OriginIdentity/SubjectType</c> key, which indicates whether
        /// the end user is a person (<c>user</c>) or a non-human caller such as an application
        /// or service (<c>workload</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string SubjectType { get; set; }

        /// <summary>
        /// Checks to see if the SubjectType property is set.
        /// </summary>
        internal bool IsSetSubjectType() => this.SubjectType != null;
    }
}
