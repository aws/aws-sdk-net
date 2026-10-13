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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateCodeRepository operation. Updates the specified
    /// Git repository with the specified values.
    /// </summary>
    public partial class UpdateCodeRepositoryRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property CodeRepositoryName. 
        /// <para>
        /// The name of the Git repository to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string CodeRepositoryName { get; set; }

        /// <summary>
        /// Checks to see if the CodeRepositoryName property is set.
        /// </summary>
        internal bool IsSetCodeRepositoryName() => this.CodeRepositoryName != null;

        /// <summary>
        /// Gets and sets the property GitConfig. 
        /// <para>
        /// The configuration of the git repository, including the URL and the Amazon Resource
        /// Name (ARN) of the Amazon Web Services Secrets Manager secret that contains the credentials
        /// used to access the repository. The secret must have a staging label of <c>AWSCURRENT</c>
        /// and must be in the following format:
        /// </para>
        ///  
        /// <para>
        ///  <c>{"username": <i>UserName</i>, "password": <i>Password</i>}</c> 
        /// </para>
        /// </summary>
        public GitConfigForUpdate GitConfig { get; set; }

        /// <summary>
        /// Checks to see if the GitConfig property is set.
        /// </summary>
        internal bool IsSetGitConfig() => this.GitConfig != null;
    }
}
