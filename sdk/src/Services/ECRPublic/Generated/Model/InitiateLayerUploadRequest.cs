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
    /// Container for the parameters to the InitiateLayerUpload operation.
    /// Notifies Amazon ECR that you intend to upload an image layer.
    /// 
    ///  
    /// <para>
    /// When an image is pushed, the InitiateLayerUpload API is called once for each image
    /// layer that hasn't already been uploaded. Whether an image layer uploads is determined
    /// by the BatchCheckLayerAvailability API action.
    /// </para>
    ///  <note> 
    /// <para>
    /// This operation is used by the Amazon ECR proxy and is not generally used by customers
    /// for pulling and pushing images. In most cases, you should use the <code>docker</code>
    /// CLI to pull, tag, and push images.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class InitiateLayerUploadRequest : AmazonECRPublicRequest
    {
        private string _registryId;
        private string _repositoryName;

        /// <summary>
        /// Gets and sets the property RegistryId. 
        /// <para>
        /// The Amazon Web Services account ID, or registry alias, that's associated with the
        /// registry to which you intend to upload layers. If you do not specify a registry, the
        /// default public registry is assumed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=50)]
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
        /// The name of the repository that you want to upload layers to.
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