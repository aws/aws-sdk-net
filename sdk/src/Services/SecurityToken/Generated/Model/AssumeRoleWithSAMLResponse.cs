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
 * Do not modify this file. This file is generated from the sts-2011-06-15.normal.json service model.
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
    /// Contains the response to a successful <a>AssumeRoleWithSAML</a> request, including
    /// temporary Amazon Web Services credentials that can be used to make Amazon Web Services
    /// requests.
    /// </summary>
    public partial class AssumeRoleWithSAMLResponse : AmazonWebServiceResponse
    {
        private AssumedRoleUser _assumedRoleUser;
        private string _audience;
        private Credentials _credentials;
        private string _issuer;
        private string _nameQualifier;
        private int? _packedPolicySize;
        private string _sourceIdentity;
        private string _subject;
        private string _subjectType;

        /// <summary>
        /// Gets and sets the property AssumedRoleUser. 
        /// <para>
        /// The identifiers for the temporary security credentials that the operation returns.
        /// </para>
        /// </summary>
        public AssumedRoleUser AssumedRoleUser
        {
            get { return this._assumedRoleUser; }
            set { this._assumedRoleUser = value; }
        }

        // Check to see if AssumedRoleUser property is set
        internal bool IsSetAssumedRoleUser()
        {
            return this._assumedRoleUser != null;
        }

        /// <summary>
        /// Gets and sets the property Audience. 
        /// <para>
        ///  The value of the <c>Recipient</c> attribute of the <c>SubjectConfirmationData</c>
        /// element of the SAML assertion. 
        /// </para>
        /// </summary>
        public string Audience
        {
            get { return this._audience; }
            set { this._audience = value; }
        }

        // Check to see if Audience property is set
        internal bool IsSetAudience()
        {
            return this._audience != null;
        }

        /// <summary>
        /// Gets and sets the property Credentials. 
        /// <para>
        /// The temporary security credentials, which include an access key ID, a secret access
        /// key, and a security (or session) token.
        /// </para>
        ///  <note> 
        /// <para>
        /// The size of the security token that STS API operations return is not fixed. We strongly
        /// recommend that you make no assumptions about the maximum size.
        /// </para>
        ///  </note>
        /// </summary>
        public Credentials Credentials
        {
            get { return this._credentials; }
            set { this._credentials = value; }
        }

        // Check to see if Credentials property is set
        internal bool IsSetCredentials()
        {
            return this._credentials != null;
        }

        /// <summary>
        /// Gets and sets the property Issuer. 
        /// <para>
        /// The value of the <c>Issuer</c> element of the SAML assertion.
        /// </para>
        /// </summary>
        public string Issuer
        {
            get { return this._issuer; }
            set { this._issuer = value; }
        }

        // Check to see if Issuer property is set
        internal bool IsSetIssuer()
        {
            return this._issuer != null;
        }

        /// <summary>
        /// Gets and sets the property NameQualifier. 
        /// <para>
        /// A hash value based on the concatenation of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The <c>Issuer</c> response value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The Amazon Web Services account ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The friendly name (the last part of the ARN) of the SAML provider in IAM.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The combination of <c>NameQualifier</c> and <c>Subject</c> can be used to uniquely
        /// identify a user.
        /// </para>
        ///  
        /// <para>
        /// The following pseudocode shows how the hash value is calculated:
        /// </para>
        ///  
        /// <para>
        ///  <c>BASE64 ( SHA1 ( "https://example.com/saml" + "123456789012" + "/MySAMLIdP" ) )</c>
        /// 
        /// </para>
        /// </summary>
        public string NameQualifier
        {
            get { return this._nameQualifier; }
            set { this._nameQualifier = value; }
        }

        // Check to see if NameQualifier property is set
        internal bool IsSetNameQualifier()
        {
            return this._nameQualifier != null;
        }

        /// <summary>
        /// Gets and sets the property PackedPolicySize. 
        /// <para>
        /// A percentage value that indicates the packed size of the session policies and session
        /// tags combined passed in the request. The request fails if the packed size is greater
        /// than 100 percent, which means the policies and tags exceeded the allowed space.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? PackedPolicySize
        {
            get { return this._packedPolicySize; }
            set { this._packedPolicySize = value; }
        }

        // Check to see if PackedPolicySize property is set
        internal bool IsSetPackedPolicySize()
        {
            return this._packedPolicySize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SourceIdentity. 
        /// <para>
        /// The value in the <c>SourceIdentity</c> attribute in the SAML assertion. The source
        /// identity value persists across <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles.html#iam-term-role-chaining">chained
        /// role</a> sessions.
        /// </para>
        ///  
        /// <para>
        /// You can require users to set a source identity value when they assume a role. You
        /// do this by using the <c>sts:SourceIdentity</c> condition key in a role trust policy.
        /// That way, actions that are taken with the role are associated with that user. After
        /// the source identity is set, the value cannot be changed. It is present in the request
        /// for all actions that are taken by the role and persists across <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles.html#id_roles_terms-and-concepts">chained
        /// role</a> sessions. You can configure your SAML identity provider to use an attribute
        /// associated with your users, like user name or email, as the source identity when calling
        /// <c>AssumeRoleWithSAML</c>. You do this by adding an attribute to the SAML assertion.
        /// For more information about using source identity, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_control-access_monitor.html">Monitor
        /// and control actions taken with assumed roles</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The regex used to validate this parameter is a string of characters consisting of
        /// upper- and lower-case alphanumeric characters with no spaces. You can also include
        /// underscores or any of the following characters: =,.@-
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=64)]
        public string SourceIdentity
        {
            get { return this._sourceIdentity; }
            set { this._sourceIdentity = value; }
        }

        // Check to see if SourceIdentity property is set
        internal bool IsSetSourceIdentity()
        {
            return this._sourceIdentity != null;
        }

        /// <summary>
        /// Gets and sets the property Subject. 
        /// <para>
        /// The value of the <c>NameID</c> element in the <c>Subject</c> element of the SAML assertion.
        /// </para>
        /// </summary>
        public string Subject
        {
            get { return this._subject; }
            set { this._subject = value; }
        }

        // Check to see if Subject property is set
        internal bool IsSetSubject()
        {
            return this._subject != null;
        }

        /// <summary>
        /// Gets and sets the property SubjectType. 
        /// <para>
        ///  The format of the name ID, as defined by the <c>Format</c> attribute in the <c>NameID</c>
        /// element of the SAML assertion. Typical examples of the format are <c>transient</c>
        /// or <c>persistent</c>. 
        /// </para>
        ///  
        /// <para>
        ///  If the format includes the prefix <c>urn:oasis:names:tc:SAML:2.0:nameid-format</c>,
        /// that prefix is removed. For example, <c>urn:oasis:names:tc:SAML:2.0:nameid-format:transient</c>
        /// is returned as <c>transient</c>. If the format includes any other prefix, the format
        /// is returned with no modifications.
        /// </para>
        /// </summary>
        public string SubjectType
        {
            get { return this._subjectType; }
            set { this._subjectType = value; }
        }

        // Check to see if SubjectType property is set
        internal bool IsSetSubjectType()
        {
            return this._subjectType != null;
        }

    }
}