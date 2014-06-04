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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityToken.Model
{
    /// <summary>
    /// Contains the result of a successful call to the <a>AssumeRoleWithSAML</a> action,
    /// including      temporary AWS credentials that can be used to make AWS requests.
    /// </summary>
    public partial class AssumeRoleWithSAMLResult
    {
        private AssumedRoleUser _assumedRoleUser;
        private string _audience;
        private Credentials _credentials;
        private string _issuer;
        private string _nameQualifier;
        private int? _packedPolicySize;
        private string _subject;
        private string _subjectType;


        /// <summary>
        /// Gets and sets the property AssumedRoleUser.
        /// </summary>
        public AssumedRoleUser AssumedRoleUser
        {
            get { return this._assumedRoleUser; }
            set { this._assumedRoleUser = value; }
        }


        /// <summary>
        /// Sets the AssumedRoleUser property
        /// </summary>
        /// <param name="assumedRoleUser">The value to set for the AssumedRoleUser property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AssumeRoleWithSAMLResult WithAssumedRoleUser(AssumedRoleUser assumedRoleUser)
        {
            this._assumedRoleUser = assumedRoleUser;
            return this;
        }

        // Check to see if AssumedRoleUser property is set
        internal bool IsSetAssumedRoleUser()
        {
            return this._assumedRoleUser != null;
        }


        /// <summary>
        /// Gets and sets the property Audience.
        /// </summary>
        public string Audience
        {
            get { return this._audience; }
            set { this._audience = value; }
        }


        /// <summary>
        /// Sets the Audience property
        /// </summary>
        /// <param name="audience">The value to set for the Audience property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AssumeRoleWithSAMLResult WithAudience(string audience)
        {
            this._audience = audience;
            return this;
        }

        // Check to see if Audience property is set
        internal bool IsSetAudience()
        {
            return this._audience != null;
        }


        /// <summary>
        /// Gets and sets the property Credentials.
        /// </summary>
        public Credentials Credentials
        {
            get { return this._credentials; }
            set { this._credentials = value; }
        }


        /// <summary>
        /// Sets the Credentials property
        /// </summary>
        /// <param name="credentials">The value to set for the Credentials property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AssumeRoleWithSAMLResult WithCredentials(Credentials credentials)
        {
            this._credentials = credentials;
            return this;
        }

        // Check to see if Credentials property is set
        internal bool IsSetCredentials()
        {
            return this._credentials != null;
        }


        /// <summary>
        /// Gets and sets the property Issuer.
        /// </summary>
        public string Issuer
        {
            get { return this._issuer; }
            set { this._issuer = value; }
        }


        /// <summary>
        /// Sets the Issuer property
        /// </summary>
        /// <param name="issuer">The value to set for the Issuer property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AssumeRoleWithSAMLResult WithIssuer(string issuer)
        {
            this._issuer = issuer;
            return this;
        }

        // Check to see if Issuer property is set
        internal bool IsSetIssuer()
        {
            return this._issuer != null;
        }


        /// <summary>
        /// Gets and sets the property NameQualifier.
        /// </summary>
        public string NameQualifier
        {
            get { return this._nameQualifier; }
            set { this._nameQualifier = value; }
        }


        /// <summary>
        /// Sets the NameQualifier property
        /// </summary>
        /// <param name="nameQualifier">The value to set for the NameQualifier property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AssumeRoleWithSAMLResult WithNameQualifier(string nameQualifier)
        {
            this._nameQualifier = nameQualifier;
            return this;
        }

        // Check to see if NameQualifier property is set
        internal bool IsSetNameQualifier()
        {
            return this._nameQualifier != null;
        }


        /// <summary>
        /// Gets and sets the property PackedPolicySize. 
        /// <para>
        /// A percentage value that indicates the size of the policy in packed form. The service
        /// rejects      any policy with a packed size greater than 100 percent, which means the
        /// policy exceeded the      allowed space. 
        /// </para>
        /// </summary>
        public int PackedPolicySize
        {
            get { return this._packedPolicySize.GetValueOrDefault(); }
            set { this._packedPolicySize = value; }
        }


        /// <summary>
        /// Sets the PackedPolicySize property
        /// </summary>
        /// <param name="packedPolicySize">The value to set for the PackedPolicySize property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AssumeRoleWithSAMLResult WithPackedPolicySize(int packedPolicySize)
        {
            this._packedPolicySize = packedPolicySize;
            return this;
        }

        // Check to see if PackedPolicySize property is set
        internal bool IsSetPackedPolicySize()
        {
            return this._packedPolicySize.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property Subject.
        /// </summary>
        public string Subject
        {
            get { return this._subject; }
            set { this._subject = value; }
        }


        /// <summary>
        /// Sets the Subject property
        /// </summary>
        /// <param name="subject">The value to set for the Subject property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AssumeRoleWithSAMLResult WithSubject(string subject)
        {
            this._subject = subject;
            return this;
        }

        // Check to see if Subject property is set
        internal bool IsSetSubject()
        {
            return this._subject != null;
        }


        /// <summary>
        /// Gets and sets the property SubjectType.
        /// </summary>
        public string SubjectType
        {
            get { return this._subjectType; }
            set { this._subjectType = value; }
        }


        /// <summary>
        /// Sets the SubjectType property
        /// </summary>
        /// <param name="subjectType">The value to set for the SubjectType property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AssumeRoleWithSAMLResult WithSubjectType(string subjectType)
        {
            this._subjectType = subjectType;
            return this;
        }

        // Check to see if SubjectType property is set
        internal bool IsSetSubjectType()
        {
            return this._subjectType != null;
        }

    }
}