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

namespace Amazon.ECRPublic.Model
{
    /// <summary>
    /// Container for the parameters to the SetRepositoryPolicy operation. Applies a repository
    /// policy to the specified public repository to control access permissions. For more
    /// information, see <a href="https://docs.aws.amazon.com/AmazonECR/latest/userguide/repository-policies.html">Amazon
    /// ECR Repository Policies</a> in the <i>Amazon Elastic Container Registry User Guide</i>.
    /// </summary>
    public partial class SetRepositoryPolicyRequest : AmazonECRPublicRequest
    {
        /// <summary>
        /// Gets and sets the property Force. 
        /// <para>
        /// If the policy that you want to set on a repository policy would prevent you from setting
        /// another policy in the future, you must force the <a>SetRepositoryPolicy</a> operation.
        /// This prevents accidental repository lockouts.
        /// </para>
        /// </summary>
        public bool? Force { get; set; }

        /// <summary>
        /// Checks to see if the Force property is set.
        /// </summary>
        internal bool IsSetForce() => this.Force.HasValue;

        /// <summary>
        /// Gets and sets the property PolicyText. 
        /// <para>
        /// The JSON repository policy text to apply to the repository. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonECR/latest/userguide/repository-policy-examples.html">Amazon
        /// ECR Repository Policies</a> in the <i>Amazon Elastic Container Registry User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 10240)]
        public string PolicyText { get; set; }

        /// <summary>
        /// Checks to see if the PolicyText property is set.
        /// </summary>
        internal bool IsSetPolicyText() => this.PolicyText != null;

        /// <summary>
        /// Gets and sets the property RegistryId. 
        /// <para>
        /// The Amazon Web Services account ID that's associated with the registry that contains
        /// the repository. If you do not specify a registry, the default public registry is assumed.
        /// </para>
        /// </summary>
        public string RegistryId { get; set; }

        /// <summary>
        /// Checks to see if the RegistryId property is set.
        /// </summary>
        internal bool IsSetRegistryId() => this.RegistryId != null;

        /// <summary>
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The name of the repository to receive the policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 205)]
        public string RepositoryName { get; set; }

        /// <summary>
        /// Checks to see if the RepositoryName property is set.
        /// </summary>
        internal bool IsSetRepositoryName() => this.RepositoryName != null;
    }
}
