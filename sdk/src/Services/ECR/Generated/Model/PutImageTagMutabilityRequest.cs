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

namespace Amazon.ECR.Model
{
    /// <summary>
    /// Container for the parameters to the PutImageTagMutability operation.
    /// Updates the image tag mutability settings for the specified repository. For more information,
    /// see <a href="https://docs.aws.amazon.com/AmazonECR/latest/userguide/image-tag-mutability.html">Image
    /// Tag Mutability</a> in the <i>Amazon Elastic Container Registry User Guide</i>.
    /// </summary>
    public partial class PutImageTagMutabilityRequest : AmazonECRRequest
    {
        private ImageTagMutability _imageTagMutability;
        private string _registryId;
        private string _repositoryName;

        /// <summary>
        /// Gets and sets the property ImageTagMutability. 
        /// <para>
        /// The tag mutability setting for the repository. If <code>MUTABLE</code> is specified,
        /// image tags can be overwritten. If <code>IMMUTABLE</code> is specified, all image tags
        /// within the repository will be immutable which will prevent them from being overwritten.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ImageTagMutability ImageTagMutability
        {
            get { return this._imageTagMutability; }
            set { this._imageTagMutability = value; }
        }

        // Check to see if ImageTagMutability property is set
        internal bool IsSetImageTagMutability()
        {
            return this._imageTagMutability != null;
        }

        /// <summary>
        /// Gets and sets the property RegistryId. 
        /// <para>
        /// The AWS account ID associated with the registry that contains the repository in which
        /// to update the image tag mutability settings. If you do not specify a registry, the
        /// default registry is assumed.
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
        /// The name of the repository in which to update the image tag mutability settings.
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