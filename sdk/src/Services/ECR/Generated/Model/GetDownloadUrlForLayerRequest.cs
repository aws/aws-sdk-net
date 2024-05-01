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
    /// Container for the parameters to the GetDownloadUrlForLayer operation.
    /// Retrieves the pre-signed Amazon S3 download URL corresponding to an image layer. You
    /// can only get URLs for image layers that are referenced in an image.
    /// 
    ///  
    /// <para>
    /// When an image is pulled, the GetDownloadUrlForLayer API is called once per image layer
    /// that is not already cached.
    /// </para>
    ///  <note> 
    /// <para>
    /// This operation is used by the Amazon ECR proxy and is not generally used by customers
    /// for pulling and pushing images. In most cases, you should use the <c>docker</c> CLI
    /// to pull, tag, and push images.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class GetDownloadUrlForLayerRequest : AmazonECRRequest
    {
        private string _layerDigest;
        private string _registryId;
        private string _repositoryName;

        /// <summary>
        /// Gets and sets the property LayerDigest. 
        /// <para>
        /// The digest of the image layer to download.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string LayerDigest
        {
            get { return this._layerDigest; }
            set { this._layerDigest = value; }
        }

        // Check to see if LayerDigest property is set
        internal bool IsSetLayerDigest()
        {
            return this._layerDigest != null;
        }

        /// <summary>
        /// Gets and sets the property RegistryId. 
        /// <para>
        /// The Amazon Web Services account ID associated with the registry that contains the
        /// image layer to download. If you do not specify a registry, the default registry is
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
        /// The name of the repository that is associated with the image layer to download.
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