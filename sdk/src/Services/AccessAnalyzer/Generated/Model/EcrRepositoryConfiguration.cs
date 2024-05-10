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
 * Do not modify this file. This file is generated from the accessanalyzer-2019-11-01.normal.json service model.
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
namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// The proposed access control configuration for an Amazon ECR repository. You can propose
    /// a configuration for a new Amazon ECR repository or an existing Amazon ECR repository
    /// that you own by specifying the Amazon ECR policy. For more information, see <a href="https://docs.aws.amazon.com/AmazonECR/latest/APIReference/API_Repository.html">Repository</a>.
    /// 
    ///  <ul> <li> 
    /// <para>
    /// If the configuration is for an existing Amazon ECR repository and you do not specify
    /// the Amazon ECR policy, then the access preview uses the existing Amazon ECR policy
    /// for the repository.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If the access preview is for a new resource and you do not specify the policy, then
    /// the access preview assumes an Amazon ECR repository without a policy.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To propose deletion of an existing Amazon ECR repository policy, you can specify an
    /// empty string for the Amazon ECR policy.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class EcrRepositoryConfiguration
    {
        private string _repositoryPolicy;

        /// <summary>
        /// Gets and sets the property RepositoryPolicy. 
        /// <para>
        /// The JSON repository policy text to apply to the Amazon ECR repository. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonECR/latest/userguide/repository-policy-examples.html">Private
        /// repository policy examples</a> in the <i>Amazon ECR User Guide</i>.
        /// </para>
        /// </summary>
        public string RepositoryPolicy
        {
            get { return this._repositoryPolicy; }
            set { this._repositoryPolicy = value; }
        }

        // Check to see if RepositoryPolicy property is set
        internal bool IsSetRepositoryPolicy()
        {
            return this._repositoryPolicy != null;
        }

    }
}