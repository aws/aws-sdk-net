/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ECR.Model
{
    /// <summary>
    /// Container for the parameters to the BatchGetImage operation.
    /// Gets detailed information for specified images within a specified repository. Images
    /// are specified with either <code>imageTag</code> or <code>imageDigest</code>.
    /// </summary>
    public partial class BatchGetImageRequest : AmazonECRRequest
    {
        private List<string> _acceptedMediaTypes = new List<string>();
        private List<ImageIdentifier> _imageIds = new List<ImageIdentifier>();
        private string _registryId;
        private string _repositoryName;

        /// <summary>
        /// Gets and sets the property AcceptedMediaTypes. 
        /// <para>
        /// The accepted media types for the request.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <code>application/vnd.docker.distribution.manifest.v1+json</code> |
        /// <code>application/vnd.docker.distribution.manifest.v2+json</code> | <code>application/vnd.oci.image.manifest.v1+json</code>
        /// 
        /// </para>
        /// </summary>
        public List<string> AcceptedMediaTypes
        {
            get { return this._acceptedMediaTypes; }
            set { this._acceptedMediaTypes = value; }
        }

        // Check to see if AcceptedMediaTypes property is set
        internal bool IsSetAcceptedMediaTypes()
        {
            return this._acceptedMediaTypes != null && this._acceptedMediaTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ImageIds. 
        /// <para>
        /// A list of image ID references that correspond to images to describe. The format of
        /// the <code>imageIds</code> reference is <code>imageTag=tag</code> or <code>imageDigest=digest</code>.
        /// </para>
        /// </summary>
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
        /// The AWS account ID associated with the registry that contains the images to describe.
        /// If you do not specify a registry, the default registry is assumed.
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