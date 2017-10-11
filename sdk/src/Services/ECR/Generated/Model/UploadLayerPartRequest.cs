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
    /// Container for the parameters to the UploadLayerPart operation.
    /// Uploads an image layer part to Amazon ECR.
    /// 
    ///  <note> 
    /// <para>
    /// This operation is used by the Amazon ECR proxy, and it is not intended for general
    /// use by customers for pulling and pushing images. In most cases, you should use the
    /// <code>docker</code> CLI to pull, tag, and push images.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class UploadLayerPartRequest : AmazonECRRequest
    {
        private MemoryStream _layerPartBlob;
        private long? _partFirstByte;
        private long? _partLastByte;
        private string _registryId;
        private string _repositoryName;
        private string _uploadId;

        /// <summary>
        /// Gets and sets the property LayerPartBlob. 
        /// <para>
        /// The base64-encoded layer part payload.
        /// </para>
        /// </summary>
        public MemoryStream LayerPartBlob
        {
            get { return this._layerPartBlob; }
            set { this._layerPartBlob = value; }
        }

        // Check to see if LayerPartBlob property is set
        internal bool IsSetLayerPartBlob()
        {
            return this._layerPartBlob != null;
        }

        /// <summary>
        /// Gets and sets the property PartFirstByte. 
        /// <para>
        /// The integer value of the first byte of the layer part.
        /// </para>
        /// </summary>
        public long PartFirstByte
        {
            get { return this._partFirstByte.GetValueOrDefault(); }
            set { this._partFirstByte = value; }
        }

        // Check to see if PartFirstByte property is set
        internal bool IsSetPartFirstByte()
        {
            return this._partFirstByte.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PartLastByte. 
        /// <para>
        /// The integer value of the last byte of the layer part.
        /// </para>
        /// </summary>
        public long PartLastByte
        {
            get { return this._partLastByte.GetValueOrDefault(); }
            set { this._partLastByte = value; }
        }

        // Check to see if PartLastByte property is set
        internal bool IsSetPartLastByte()
        {
            return this._partLastByte.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RegistryId. 
        /// <para>
        /// The AWS account ID associated with the registry to which you are uploading layer parts.
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
        /// The name of the repository to which you are uploading layer parts.
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

        /// <summary>
        /// Gets and sets the property UploadId. 
        /// <para>
        /// The upload ID from a previous <a>InitiateLayerUpload</a> operation to associate with
        /// the layer part upload.
        /// </para>
        /// </summary>
        public string UploadId
        {
            get { return this._uploadId; }
            set { this._uploadId = value; }
        }

        // Check to see if UploadId property is set
        internal bool IsSetUploadId()
        {
            return this._uploadId != null;
        }

    }
}