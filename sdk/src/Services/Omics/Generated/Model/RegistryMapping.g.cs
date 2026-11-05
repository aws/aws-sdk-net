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

namespace Amazon.Omics.Model
{
    /// <summary>
    /// Maps an upstream container registry to a repository prefix in your Amazon Elastic
    /// Container Registry (Amazon ECR) private registry. For registries that Amazon ECR pull
    /// through cache supports, you create a pull through cache rule that synchronizes the
    /// upstream repositories with your private repositories. You can also use some registries
    /// that pull through cache doesn't support. For these registries, specify <c>credentialArn</c>,
    /// and Amazon Web Services HealthOmics copies each image into a private Amazon ECR repository
    /// the first time a task needs it.
    /// </summary>
    public partial class RegistryMapping
    {
        /// <summary>
        /// Gets and sets the property CredentialArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Web Services Secrets Manager secret that
        /// holds the credentials for the upstream registry. You must specify this value when
        /// Amazon Elastic Container Registry (Amazon ECR) doesn't support pull through cache
        /// for the upstream registry. HealthOmics supports only some of these registries. The
        /// workflow role must have permission to call the <c>secretsmanager:GetSecretValue</c>
        /// operation on the secret. For more information about the supported registries, see
        /// <a href="https://docs.aws.amazon.com/omics/latest/dev/workflows-ecr.html">Container
        /// images</a> in the <i>Amazon Web Services HealthOmics User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string CredentialArn { get; set; }

        /// <summary>
        /// Checks to see if the CredentialArn property is set.
        /// </summary>
        internal bool IsSetCredentialArn() => this.CredentialArn != null;

        /// <summary>
        /// Gets and sets the property EcrAccountId. 
        /// <para>
        /// Account ID of the account that owns the upstream container image.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string EcrAccountId { get; set; }

        /// <summary>
        /// Checks to see if the EcrAccountId property is set.
        /// </summary>
        internal bool IsSetEcrAccountId() => this.EcrAccountId != null;

        /// <summary>
        /// Gets and sets the property EcrRepositoryPrefix. 
        /// <para>
        /// The repository prefix to use in the ECR private repository.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string EcrRepositoryPrefix { get; set; }

        /// <summary>
        /// Checks to see if the EcrRepositoryPrefix property is set.
        /// </summary>
        internal bool IsSetEcrRepositoryPrefix() => this.EcrRepositoryPrefix != null;

        /// <summary>
        /// Gets and sets the property UpstreamRegistryUrl. 
        /// <para>
        /// The URI of the upstream registry.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 750)]
        public string UpstreamRegistryUrl { get; set; }

        /// <summary>
        /// Checks to see if the UpstreamRegistryUrl property is set.
        /// </summary>
        internal bool IsSetUpstreamRegistryUrl() => this.UpstreamRegistryUrl != null;

        /// <summary>
        /// Gets and sets the property UpstreamRepositoryPrefix. 
        /// <para>
        /// The repository prefix of the corresponding repository in the upstream registry.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 30)]
        public string UpstreamRepositoryPrefix { get; set; }

        /// <summary>
        /// Checks to see if the UpstreamRepositoryPrefix property is set.
        /// </summary>
        internal bool IsSetUpstreamRepositoryPrefix() => this.UpstreamRepositoryPrefix != null;
    }
}
