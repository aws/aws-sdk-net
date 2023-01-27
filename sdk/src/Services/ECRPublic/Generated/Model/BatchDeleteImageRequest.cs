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
    /// Container for the parameters to the BatchDeleteImage operation.
    /// Deletes a list of specified images that are within a repository in a public registry.
    /// Images are specified with either an <code>imageTag</code> or <code>imageDigest</code>.
    /// 
    ///  
    /// <para>
    /// You can remove a tag from an image by specifying the image's tag in your request.
    /// When you remove the last tag from an image, the image is deleted from your repository.
    /// </para>
    ///  
    /// <para>
    /// You can completely delete an image (and all of its tags) by specifying the digest
    /// of the image in your request.
    /// </para>
    /// </summary>
    public partial class BatchDeleteImageRequest : AmazonECRPublicRequest
    {
        private List<ImageIdentifier> _imageIds = new List<ImageIdentifier>();
        private string _registryId;
        private string _repositoryName;

        /// <summary>
        /// Gets and sets the property ImageIds. 
        /// <para>
        /// A list of image ID references that correspond to images to delete. The format of the
        /// <code>imageIds</code> reference is <code>imageTag=tag</code> or <code>imageDigest=digest</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public List<ImageIdentifier> ImageIds
        {
            get { return this._imageIds; }
            set { this._imageIds = value; }
        }

        // Check to see if ImageIds property is set
        internal bool IsSetImageIds()
        {
            return this._imageIds != null && this._imageIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RegistryId. 
        /// <para>
        /// The Amazon Web Services account ID that's associated with the registry that contains
        /// the image to delete. If you do not specify a registry, the default public registry
        /// is assumed.
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
        /// The repository in a public registry that contains the image to delete.
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