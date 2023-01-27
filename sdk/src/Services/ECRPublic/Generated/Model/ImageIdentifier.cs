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
    /// An object with identifying information for an Amazon ECR image.
    /// </summary>
    public partial class ImageIdentifier
    {
        private string _imageDigest;
        private string _imageTag;

        /// <summary>
        /// Gets and sets the property ImageDigest. 
        /// <para>
        /// The <code>sha256</code> digest of the image manifest.
        /// </para>
        /// </summary>
        public string ImageDigest
        {
            get { return this._imageDigest; }
            set { this._imageDigest = value; }
        }

        // Check to see if ImageDigest property is set
        internal bool IsSetImageDigest()
        {
            return this._imageDigest != null;
        }

        /// <summary>
        /// Gets and sets the property ImageTag. 
        /// <para>
        /// The tag that's used for the image.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=300)]
        public string ImageTag
        {
            get { return this._imageTag; }
            set { this._imageTag = value; }
        }

        // Check to see if ImageTag property is set
        internal bool IsSetImageTag()
        {
            return this._imageTag != null;
        }

    }
}