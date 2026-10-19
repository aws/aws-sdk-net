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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the UploadLayerPart operation. Uploads an image layer
    /// part to Amazon ECR. <para> When an image is pushed, each new image layer is uploaded
    /// in parts. The maximum size of each image layer part can be 20971520 bytes (or about
    /// 20MB). The UploadLayerPart API is called once per each new image layer part. </para>
    /// <note> <para> This operation is used by the Amazon ECR proxy and is not generally
    /// used by customers for pulling and pushing images. In most cases, you should use the
    /// <c>docker</c> CLI to pull, tag, and push images. </para> </note>
    /// </summary>
    public partial class UploadLayerPartRequest : AmazonECRRequest
    {
        /// <summary>
        /// Gets and sets the property LayerPartBlob. 
        /// <para>
        /// The base64-encoded layer part payload.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 20971520)]
        public MemoryStream LayerPartBlob { get; set; }

        /// <summary>
        /// Checks to see if the LayerPartBlob property is set.
        /// </summary>
        internal bool IsSetLayerPartBlob() => this.LayerPartBlob != null;

        /// <summary>
        /// Gets and sets the property PartFirstByte. 
        /// <para>
        /// The position of the first byte of the layer part witin the overall image layer.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public long? PartFirstByte { get; set; }

        /// <summary>
        /// Checks to see if the PartFirstByte property is set.
        /// </summary>
        internal bool IsSetPartFirstByte() => this.PartFirstByte.HasValue;

        /// <summary>
        /// Gets and sets the property PartLastByte. 
        /// <para>
        /// The position of the last byte of the layer part within the overall image layer.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public long? PartLastByte { get; set; }

        /// <summary>
        /// Checks to see if the PartLastByte property is set.
        /// </summary>
        internal bool IsSetPartLastByte() => this.PartLastByte.HasValue;

        /// <summary>
        /// Gets and sets the property RegistryId. 
        /// <para>
        /// The Amazon Web Services account ID associated with the registry to which you are uploading
        /// layer parts. If you do not specify a registry, the default registry is assumed.
        /// </para>
        /// </summary>
        public string RegistryId { get; set; }

        /// <summary>
        /// Checks to see if the RegistryId property is set.
        /// </summary>
        internal bool IsSetRegistryId() => this.RegistryId != null;

        /// <summary>
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The name of the repository to which you are uploading layer parts.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 256)]
        public string RepositoryName { get; set; }

        /// <summary>
        /// Checks to see if the RepositoryName property is set.
        /// </summary>
        internal bool IsSetRepositoryName() => this.RepositoryName != null;

        /// <summary>
        /// Gets and sets the property UploadId. 
        /// <para>
        /// The upload ID from a previous <a>InitiateLayerUpload</a> operation to associate with
        /// the layer part upload.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string UploadId { get; set; }

        /// <summary>
        /// Checks to see if the UploadId property is set.
        /// </summary>
        internal bool IsSetUploadId() => this.UploadId != null;
    }
}
