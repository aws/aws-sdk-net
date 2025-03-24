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
    /// This is the response object from the DeletePullThroughCacheRule operation.
    /// </summary>
    public partial class DeletePullThroughCacheRuleResponse : AmazonWebServiceResponse
    {
        private DateTime? _createdAt;
        private string _credentialArn;
        private string _customRoleArn;
        private string _ecrRepositoryPrefix;
        private string _registryId;
        private string _upstreamRegistryUrl;
        private string _upstreamRepositoryPrefix;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp associated with the pull through cache rule.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

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
        /// The Amazon ECR repository prefix associated with the request.
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