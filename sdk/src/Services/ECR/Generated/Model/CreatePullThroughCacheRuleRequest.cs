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
    /// Container for the parameters to the CreatePullThroughCacheRule operation.
    /// Creates a pull through cache rule. A pull through cache rule provides a way to cache
    /// images from an upstream registry source in your Amazon ECR private registry. For more
    /// information, see <a href="https://docs.aws.amazon.com/AmazonECR/latest/userguide/pull-through-cache.html">Using
    /// pull through cache rules</a> in the <i>Amazon Elastic Container Registry User Guide</i>.
    /// </summary>
    public partial class CreatePullThroughCacheRuleRequest : AmazonECRRequest
    {
        private string _credentialArn;
        private string _ecrRepositoryPrefix;
        private string _registryId;
        private UpstreamRegistry _upstreamRegistry;
        private string _upstreamRegistryUrl;

        /// <summary>
        /// Gets and sets the property CredentialArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Web Services Secrets Manager secret that
        /// identifies the credentials to authenticate to the upstream registry.
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
        /// Gets and sets the property EcrRepositoryPrefix. 
        /// <para>
        /// The repository name prefix to use when caching images from the source registry.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=30)]
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
        /// The Amazon Web Services account ID associated with the registry to create the pull
        /// through cache rule for. If you do not specify a registry, the default registry is
        /// assumed.
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
        /// Gets and sets the property UpstreamRegistry. 
        /// <para>
        /// The name of the upstream registry.
        /// </para>
        /// </summary>
        public UpstreamRegistry UpstreamRegistry
        {
            get { return this._upstreamRegistry; }
            set { this._upstreamRegistry = value; }
        }

        // Check to see if UpstreamRegistry property is set
        internal bool IsSetUpstreamRegistry()
        {
            return this._upstreamRegistry != null;
        }

        /// <summary>
        /// Gets and sets the property UpstreamRegistryUrl. 
        /// <para>
        /// The registry URL of the upstream public registry to use as the source for the pull
        /// through cache rule. The following is the syntax to use for each supported upstream
        /// registry.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Amazon ECR Public (<c>ecr-public</c>) - <c>public.ecr.aws</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Docker Hub (<c>docker-hub</c>) - <c>registry-1.docker.io</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Quay (<c>quay</c>) - <c>quay.io</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Kubernetes (<c>k8s</c>) - <c>registry.k8s.io</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// GitHub Container Registry (<c>github-container-registry</c>) - <c>ghcr.io</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Microsoft Azure Container Registry (<c>azure-container-registry</c>) - <c>&lt;custom&gt;.azurecr.io</c>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}