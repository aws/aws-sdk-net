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
 * Do not modify this file. This file is generated from the ecr-public-2020-10-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ECRPublic.Model
{
    /// <summary>
    /// Container for the parameters to the CreateRepository operation.
    /// Creates a repository in a public registry. For more information, see <a href="https://docs.aws.amazon.com/AmazonECR/latest/userguide/Repositories.html">Amazon
    /// ECR repositories</a> in the <i>Amazon Elastic Container Registry User Guide</i>.
    /// </summary>
    public partial class CreateRepositoryRequest : AmazonECRPublicRequest
    {
        private RepositoryCatalogDataInput _catalogData;
        private string _repositoryName;

        /// <summary>
        /// Gets and sets the property CatalogData. 
        /// <para>
        /// The details about the repository that are publicly visible in the Amazon ECR Public
        /// Gallery.
        /// </para>
        /// </summary>
        public RepositoryCatalogDataInput CatalogData
        {
            get { return this._catalogData; }
            set { this._catalogData = value; }
        }

        // Check to see if CatalogData property is set
        internal bool IsSetCatalogData()
        {
            return this._catalogData != null;
        }

        /// <summary>
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The name to use for the repository. This appears publicly in the Amazon ECR Public
        /// Gallery. The repository name may be specified on its own (such as <code>nginx-web-app</code>)
        /// or it can be prepended with a namespace to group the repository into a category (such
        /// as <code>project-a/nginx-web-app</code>).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=205)]
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