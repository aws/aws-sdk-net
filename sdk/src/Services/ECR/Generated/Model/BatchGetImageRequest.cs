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
    /// Container for the parameters to the BatchGetImage operation.
    /// Gets detailed information for an image. Images are specified with either an <c>imageTag</c>
    /// or <c>imageDigest</c>.
    /// 
    ///  
    /// <para>
    /// When an image is pulled, the BatchGetImage API is called once to retrieve the image
    /// manifest.
    /// </para>
    /// </summary>
    public partial class BatchGetImageRequest : AmazonECRRequest
    {
        private List<string> _acceptedMediaTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<ImageIdentifier> _imageIds = AWSConfigs.InitializeCollections ? new List<ImageIdentifier>() : null;
        private string _registryId;
        private string _repositoryName;

        /// <summary>
        /// Gets and sets the property AcceptedMediaTypes. 
        /// <para>
        /// The accepted media types for the request.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>application/vnd.docker.distribution.manifest.v1+json</c> | <c>application/vnd.docker.distribution.manifest.v2+json</c>
        /// | <c>application/vnd.oci.image.manifest.v1+json</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> AcceptedMediaTypes
        {
            get { return this._acceptedMediaTypes; }
            set { this._acceptedMediaTypes = value; }
        }

        // Check to see if AcceptedMediaTypes property is set
        internal bool IsSetAcceptedMediaTypes()
        {
            return this._acceptedMediaTypes != null && (this._acceptedMediaTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ImageIds. 
        /// <para>
        /// A list of image ID references that correspond to images to describe. The format of
        /// the <c>imageIds</c> reference is <c>imageTag=tag</c> or <c>imageDigest=digest</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._imageIds != null && (this._imageIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RegistryId. 
        /// <para>
        /// The Amazon Web Services account ID associated with the registry that contains the
        /// images to describe. If you do not specify a registry, the default registry is assumed.
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
        /// The repository that contains the images to describe.
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