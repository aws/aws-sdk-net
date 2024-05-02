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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Specifies configuration details for a Git repository in your Amazon Web Services account.
    /// </summary>
    public partial class GitConfig
    {
        private string _branch;
        private string _repositoryUrl;
        private string _secretArn;

        /// <summary>
        /// Gets and sets the property Branch. 
        /// <para>
        /// The default branch for the Git repository.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string Branch
        {
            get { return this._branch; }
            set { this._branch = value; }
        }

        // Check to see if Branch property is set
        internal bool IsSetBranch()
        {
            return this._branch != null;
        }

        /// <summary>
        /// Gets and sets the property RepositoryUrl. 
        /// <para>
        /// The URL where the Git repository is located.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=11, Max=1024)]
        public string RepositoryUrl
        {
            get { return this._repositoryUrl; }
            set { this._repositoryUrl = value; }
        }

        // Check to see if RepositoryUrl property is set
        internal bool IsSetRepositoryUrl()
        {
            return this._repositoryUrl != null;
        }

        /// <summary>
        /// Gets and sets the property SecretArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Web Services Secrets Manager secret that
        /// contains the credentials used to access the git repository. The secret must have a
        /// staging label of <c>AWSCURRENT</c> and must be in the following format:
        /// </para>
        ///  
        /// <para>
        ///  <c>{"username": <i>UserName</i>, "password": <i>Password</i>}</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string SecretArn
        {
            get { return this._secretArn; }
            set { this._secretArn = value; }
        }

        // Check to see if SecretArn property is set
        internal bool IsSetSecretArn()
        {
            return this._secretArn != null;
        }

    }
}