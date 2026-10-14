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
    /// This is the response object from the DescribeCodeRepository operation.
    /// </summary>
    public partial class DescribeCodeRepositoryResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CodeRepositoryArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Git repository.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string CodeRepositoryArn { get; set; }

        /// <summary>
        /// Checks to see if the CodeRepositoryArn property is set.
        /// </summary>
        internal bool IsSetCodeRepositoryArn() => this.CodeRepositoryArn != null;

        /// <summary>
        /// Gets and sets the property CodeRepositoryName. 
        /// <para>
        /// The name of the Git repository.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string CodeRepositoryName { get; set; }

        /// <summary>
        /// Checks to see if the CodeRepositoryName property is set.
        /// </summary>
        internal bool IsSetCodeRepositoryName() => this.CodeRepositoryName != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time that the repository was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property GitConfig. 
        /// <para>
        /// Configuration details about the repository, including the URL where the repository
        /// is located, the default branch, and the Amazon Resource Name (ARN) of the Amazon Web
        /// Services Secrets Manager secret that contains the credentials used to access the repository.
        /// </para>
        /// </summary>
        public GitConfig GitConfig { get; set; }

        /// <summary>
        /// Checks to see if the GitConfig property is set.
        /// </summary>
        internal bool IsSetGitConfig() => this.GitConfig != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The date and time that the repository was last changed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;
    }
}
