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
    /// Container for the parameters to the PutRepositoryCatalogData operation.
    /// Creates or updates the catalog data for a repository in a public registry.
    /// </summary>
    public partial class PutRepositoryCatalogDataRequest : AmazonECRPublicRequest
    {
        private RepositoryCatalogDataInput _catalogData;
        private string _registryId;
        private string _repositoryName;

        /// <summary>
        /// Gets and sets the property CatalogData. 
        /// <para>
        /// An object containing the catalog data for a repository. This data is publicly visible
        /// in the Amazon ECR Public Gallery.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property RegistryId. 
        /// <para>
        /// The Amazon Web Services account ID that's associated with the public registry the
        /// repository is in. If you do not specify a registry, the default public registry is
        /// assumed.
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
        /// The name of the repository to create or update the catalog data for.
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