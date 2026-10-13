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

namespace Amazon.ECRPublic.Model
{
    /// <summary>
    /// An object that represents an Amazon ECR image layer.
    /// </summary>
    public partial class Layer
    {
        /// <summary>
        /// Gets and sets the property LayerAvailability. 
        /// <para>
        /// The availability status of the image layer.
        /// </para>
        /// </summary>
        public LayerAvailability LayerAvailability { get; set; }

        /// <summary>
        /// Checks to see if the LayerAvailability property is set.
        /// </summary>
        internal bool IsSetLayerAvailability() => this.LayerAvailability != null;

        /// <summary>
        /// Gets and sets the property LayerDigest. 
        /// <para>
        /// The <c>sha256</c> digest of the image layer.
        /// </para>
        /// </summary>
        public string LayerDigest { get; set; }

        /// <summary>
        /// Checks to see if the LayerDigest property is set.
        /// </summary>
        internal bool IsSetLayerDigest() => this.LayerDigest != null;

        /// <summary>
        /// Gets and sets the property LayerSize. 
        /// <para>
        /// The size, in bytes, of the image layer.
        /// </para>
        /// </summary>
        public long? LayerSize { get; set; }

        /// <summary>
        /// Checks to see if the LayerSize property is set.
        /// </summary>
        internal bool IsSetLayerSize() => this.LayerSize.HasValue;

        /// <summary>
        /// Gets and sets the property MediaType. 
        /// <para>
        /// The media type of the layer, such as <c>application/vnd.docker.image.rootfs.diff.tar.gzip</c>
        /// or <c>application/vnd.oci.image.layer.v1.tar+gzip</c>.
        /// </para>
        /// </summary>
        public string MediaType { get; set; }

        /// <summary>
        /// Checks to see if the MediaType property is set.
        /// </summary>
        internal bool IsSetMediaType() => this.MediaType != null;
    }
}
