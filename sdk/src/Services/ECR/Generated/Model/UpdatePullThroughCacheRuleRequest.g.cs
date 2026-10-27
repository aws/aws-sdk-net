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

namespace Amazon.ECR.Model
{
    /// <summary>
    /// Container for the parameters to the UpdatePullThroughCacheRule operation. Updates
    /// an existing pull through cache rule.
    /// </summary>
    public partial class UpdatePullThroughCacheRuleRequest : AmazonECRRequest
    {
        /// <summary>
        /// Gets and sets the property CredentialArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Web Services Secrets Manager secret that
        /// identifies the credentials to authenticate to the upstream registry.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 50, Max = 612)]
        public string CredentialArn { get; set; }

        /// <summary>
        /// Checks to see if the CredentialArn property is set.
        /// </summary>
        internal bool IsSetCredentialArn() => this.CredentialArn != null;

        /// <summary>
        /// Gets and sets the property CustomRoleArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the IAM role to be assumed by Amazon ECR to authenticate
        /// to the ECR upstream registry. This role must be in the same account as the registry
        /// that you are configuring.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string CustomRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the CustomRoleArn property is set.
        /// </summary>
        internal bool IsSetCustomRoleArn() => this.CustomRoleArn != null;

        /// <summary>
        /// Gets and sets the property EcrRepositoryPrefix. 
        /// <para>
        /// The repository name prefix to use when caching images from the source registry.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 30)]
        public string EcrRepositoryPrefix { get; set; }

        /// <summary>
        /// Checks to see if the EcrRepositoryPrefix property is set.
        /// </summary>
        internal bool IsSetEcrRepositoryPrefix() => this.EcrRepositoryPrefix != null;

        /// <summary>
        /// Gets and sets the property RegistryId. 
        /// <para>
        /// The Amazon Web Services account ID associated with the registry associated with the
        /// pull through cache rule. If you do not specify a registry, the default registry is
        /// assumed.
        /// </para>
        /// </summary>
        public string RegistryId { get; set; }

        /// <summary>
        /// Checks to see if the RegistryId property is set.
        /// </summary>
        internal bool IsSetRegistryId() => this.RegistryId != null;
    }
}
