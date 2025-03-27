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
 * Do not modify this file. This file is generated from the ecr-2015-09-21.normal.json service model.
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
namespace Amazon.ECR.Model
{
    /// <summary>
    /// This is the response object from the ValidatePullThroughCacheRule operation.
    /// </summary>
    public partial class ValidatePullThroughCacheRuleResponse : AmazonWebServiceResponse
    {
        private string _credentialArn;
        private string _customRoleArn;
        private string _ecrRepositoryPrefix;
        private string _failure;
        private bool? _isValid;
        private string _registryId;
        private string _upstreamRegistryUrl;
        private string _upstreamRepositoryPrefix;

        /// <summary>
        /// Gets and sets the property CredentialArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Web Services Secrets Manager secret associated
        /// with the pull through cache rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min=50, Max=612)]
        public string CredentialArn
        {
            get { return this._credentialArn; }
            set { this._credentialArn = value; }
        }

        // Check to see if CredentialArn property is set
        internal bool IsSetCredentialArn()
        {
            return this._credentialArn != null;
        }

        /// <summary>
        /// Gets and sets the property CustomRoleArn. 
        /// <para>
        /// The ARN of the IAM role associated with the pull through cache rule.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
        public string CustomRoleArn
        {
            get { return this._customRoleArn; }
            set { this._customRoleArn = value; }
        }

        // Check to see if CustomRoleArn property is set
        internal bool IsSetCustomRoleArn()
        {
            return this._customRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property EcrRepositoryPrefix. 
        /// <para>
        /// The Amazon ECR repository prefix associated with the pull through cache rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=30)]
        public string EcrRepositoryPrefix
        {
            get { return this._ecrRepositoryPrefix; }
            set { this._ecrRepositoryPrefix = value; }
        }

        // Check to see if EcrRepositoryPrefix property is set
        internal bool IsSetEcrRepositoryPrefix()
        {
            return this._ecrRepositoryPrefix != null;
        }

        /// <summary>
        /// Gets and sets the property Failure. 
        /// <para>
        /// The reason the validation failed. For more details about possible causes and how to
        /// address them, see <a href="https://docs.aws.amazon.com/AmazonECR/latest/userguide/pull-through-cache.html">Using
        /// pull through cache rules</a> in the <i>Amazon Elastic Container Registry User Guide</i>.
        /// </para>
        /// </summary>
        public string Failure
        {
            get { return this._failure; }
            set { this._failure = value; }
        }

        // Check to see if Failure property is set
        internal bool IsSetFailure()
        {
            return this._failure != null;
        }

        /// <summary>
        /// Gets and sets the property IsValid. 
        /// <para>
        /// Whether or not the pull through cache rule was validated. If <c>true</c>, Amazon ECR
        /// was able to reach the upstream registry and authentication was successful. If <c>false</c>,
        /// there was an issue and validation failed. The <c>failure</c> reason indicates the
        /// cause.
        /// </para>
        /// </summary>
        public bool? IsValid
        {
            get { return this._isValid; }
            set { this._isValid = value; }
        }

        // Check to see if IsValid property is set
        internal bool IsSetIsValid()
        {
            return this._isValid.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RegistryId. 
        /// <para>
        /// The registry ID associated with the request.
        /// </para>
        /// </summary>
        public string RegistryId
        {
            get { return this._registryId; }
            set { this._registryId = value; }
        }

        // Check to see if RegistryId property is set
        internal bool IsSetRegistryId()
        {
            return this._registryId != null;
        }

        /// <summary>
        /// Gets and sets the property UpstreamRegistryUrl. 
        /// <para>
        /// The upstream registry URL associated with the pull through cache rule.
        /// </para>
        /// </summary>
        public string UpstreamRegistryUrl
        {
            get { return this._upstreamRegistryUrl; }
            set { this._upstreamRegistryUrl = value; }
        }

        // Check to see if UpstreamRegistryUrl property is set
        internal bool IsSetUpstreamRegistryUrl()
        {
            return this._upstreamRegistryUrl != null;
        }

        /// <summary>
        /// Gets and sets the property UpstreamRepositoryPrefix. 
        /// <para>
        /// The upstream repository prefix associated with the pull through cache rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=30)]
        public string UpstreamRepositoryPrefix
        {
            get { return this._upstreamRepositoryPrefix; }
            set { this._upstreamRepositoryPrefix = value; }
        }

        // Check to see if UpstreamRepositoryPrefix property is set
        internal bool IsSetUpstreamRepositoryPrefix()
        {
            return this._upstreamRepositoryPrefix != null;
        }

    }
}