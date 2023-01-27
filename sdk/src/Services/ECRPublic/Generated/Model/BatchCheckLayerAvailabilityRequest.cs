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
    /// Container for the parameters to the BatchCheckLayerAvailability operation.
    /// Checks the availability of one or more image layers that are within a repository in
    /// a public registry. When an image is pushed to a repository, each image layer is checked
    /// to verify if it has been uploaded before. If it has been uploaded, then the image
    /// layer is skipped.
    /// 
    ///  <note> 
    /// <para>
    /// This operation is used by the Amazon ECR proxy and is not generally used by customers
    /// for pulling and pushing images. In most cases, you should use the <code>docker</code>
    /// CLI to pull, tag, and push images.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class BatchCheckLayerAvailabilityRequest : AmazonECRPublicRequest
    {
        private List<string> _layerDigests = new List<string>();
        private string _registryId;
        private string _repositoryName;

        /// <summary>
        /// Gets and sets the property LayerDigests. 
        /// <para>
        /// The digests of the image layers to check.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public List<string> LayerDigests
        {
            get { return this._layerDigests; }
            set { this._layerDigests = value; }
        }

        // Check to see if LayerDigests property is set
        internal bool IsSetLayerDigests()
        {
            return this._layerDigests != null && this._layerDigests.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RegistryId. 
        /// <para>
        /// The Amazon Web Services account ID, or registry alias, associated with the public
        /// registry that contains the image layers to check. If you do not specify a registry,
        /// the default public registry is assumed.
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
        /// The name of the repository that's associated with the image layers to check.
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