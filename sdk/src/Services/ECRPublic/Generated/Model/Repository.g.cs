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
    /// An object representing a repository.
    /// </summary>
    public partial class Repository
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time, in JavaScript date format, when the repository was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property RegistryId. 
        /// <para>
        /// The Amazon Web Services account ID that's associated with the public registry that
        /// contains the repository.
        /// </para>
        /// </summary>
        public string RegistryId { get; set; }

        /// <summary>
        /// Checks to see if the RegistryId property is set.
        /// </summary>
        internal bool IsSetRegistryId() => this.RegistryId != null;

        /// <summary>
        /// Gets and sets the property RepositoryArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that identifies the repository. The ARN contains the
        /// <c>arn:aws:ecr</c> namespace, followed by the region of the repository, Amazon Web
        /// Services account ID of the repository owner, repository namespace, and repository
        /// name. For example, <c>arn:aws:ecr:region:012345678910:repository/test</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string RepositoryArn { get; set; }

        /// <summary>
        /// Checks to see if the RepositoryArn property is set.
        /// </summary>
        internal bool IsSetRepositoryArn() => this.RepositoryArn != null;

        /// <summary>
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The name of the repository.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 205)]
        public string RepositoryName { get; set; }

        /// <summary>
        /// Checks to see if the RepositoryName property is set.
        /// </summary>
        internal bool IsSetRepositoryName() => this.RepositoryName != null;

        /// <summary>
        /// Gets and sets the property RepositoryUri. 
        /// <para>
        /// The URI for the repository. You can use this URI for container image <c>push</c> and
        /// <c>pull</c> operations.
        /// </para>
        /// </summary>
        public string RepositoryUri { get; set; }

        /// <summary>
        /// Checks to see if the RepositoryUri property is set.
        /// </summary>
        internal bool IsSetRepositoryUri() => this.RepositoryUri != null;
    }
}
