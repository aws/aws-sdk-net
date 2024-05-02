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
    /// Container for the parameters to the SetRepositoryPolicy operation.
    /// Applies a repository policy to the specified repository to control access permissions.
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonECR/latest/userguide/repository-policies.html">Amazon
    /// ECR Repository policies</a> in the <i>Amazon Elastic Container Registry User Guide</i>.
    /// </summary>
    public partial class SetRepositoryPolicyRequest : AmazonECRRequest
    {
        private bool? _force;
        private string _policyText;
        private string _registryId;
        private string _repositoryName;

        /// <summary>
        /// Gets and sets the property Force. 
        /// <para>
        /// If the policy you are attempting to set on a repository policy would prevent you from
        /// setting another policy in the future, you must force the <a>SetRepositoryPolicy</a>
        /// operation. This is intended to prevent accidental repository lock outs.
        /// </para>
        /// </summary>
        public bool? Force
        {
            get { return this._force; }
            set { this._force = value; }
        }

        // Check to see if Force property is set
        internal bool IsSetForce()
        {
            return this._force.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PolicyText. 
        /// <para>
        /// The JSON repository policy text to apply to the repository. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonECR/latest/userguide/repository-policy-examples.html">Amazon
        /// ECR repository policies</a> in the <i>Amazon Elastic Container Registry User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10240)]
        public string PolicyText
        {
            get { return this._policyText; }
            set { this._policyText = value; }
        }

        // Check to see if PolicyText property is set
        internal bool IsSetPolicyText()
        {
            return this._policyText != null;
        }

        /// <summary>
        /// Gets and sets the property RegistryId. 
        /// <para>
        /// The Amazon Web Services account ID associated with the registry that contains the
        /// repository. If you do not specify a registry, the default registry is assumed.
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
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The name of the repository to receive the policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=256)]
        public string RepositoryName
        {
            get { return this._repositoryName; }
            set { this._repositoryName = value; }
        }

        // Check to see if RepositoryName property is set
        internal bool IsSetRepositoryName()
        {
            return this._repositoryName != null;
        }

    }
}