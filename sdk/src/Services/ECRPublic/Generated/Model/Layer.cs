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
    /// An object that represents an Amazon ECR image layer.
    /// </summary>
    public partial class Layer
    {
        private LayerAvailability _layerAvailability;
        private string _layerDigest;
        private long? _layerSize;
        private string _mediaType;

        /// <summary>
        /// Gets and sets the property LayerAvailability. 
        /// <para>
        /// The availability status of the image layer.
        /// </para>
        /// </summary>
        public LayerAvailability LayerAvailability
        {
            get { return this._layerAvailability; }
            set { this._layerAvailability = value; }
        }

        // Check to see if LayerAvailability property is set
        internal bool IsSetLayerAvailability()
        {
            return this._layerAvailability != null;
        }

        /// <summary>
        /// Gets and sets the property LayerDigest. 
        /// <para>
        /// The <code>sha256</code> digest of the image layer.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property LayerSize. 
        /// <para>
        /// The size, in bytes, of the image layer.
        /// </para>
        /// </summary>
        public long LayerSize
        {
            get { return this._layerSize.GetValueOrDefault(); }
            set { this._layerSize = value; }
        }

        // Check to see if LayerSize property is set
        internal bool IsSetLayerSize()
        {
            return this._layerSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MediaType. 
        /// <para>
        /// The media type of the layer, such as <code>application/vnd.docker.image.rootfs.diff.tar.gzip</code>
        /// or <code>application/vnd.oci.image.layer.v1.tar+gzip</code>.
        /// </para>
        /// </summary>
        public string MediaType
        {
            get { return this._mediaType; }
            set { this._mediaType = value; }
        }

        // Check to see if MediaType property is set
        internal bool IsSetMediaType()
        {
            return this._mediaType != null;
        }

    }
}