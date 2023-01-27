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
 * Do not modify this file. This file is generated from the emr-serverless-2021-07-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EMRServerless.Model
{
    /// <summary>
    /// The applied image configuration.
    /// </summary>
    public partial class ImageConfiguration
    {
        private string _imageUri;
        private string _resolvedImageDigest;

        /// <summary>
        /// Gets and sets the property ImageUri. 
        /// <para>
        /// The image URI.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string ImageUri
        {
            get { return this._imageUri; }
            set { this._imageUri = value; }
        }

        // Check to see if ImageUri property is set
        internal bool IsSetImageUri()
        {
            return this._imageUri != null;
        }

        /// <summary>
        /// Gets and sets the property ResolvedImageDigest. 
        /// <para>
        /// The SHA256 digest of the image URI. This indicates which specific image the application
        /// is configured for. The image digest doesn't exist until an application has started.
        /// </para>
        /// </summary>
        public string ResolvedImageDigest
        {
            get { return this._resolvedImageDigest; }
            set { this._resolvedImageDigest = value; }
        }

        // Check to see if ResolvedImageDigest property is set
        internal bool IsSetResolvedImageDigest()
        {
            return this._resolvedImageDigest != null;
        }

    }
}