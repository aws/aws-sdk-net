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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Response to a <code>GetFunctionConfiguration</code> request.
    /// </summary>
    public partial class ImageConfigResponse
    {
        private ImageConfigError _error;
        private ImageConfig _imageConfig;

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// Error response to <code>GetFunctionConfiguration</code>.
        /// </para>
        /// </summary>
        public ImageConfigError Error
        {
            get { return this._error; }
            set { this._error = value; }
        }

        // Check to see if Error property is set
        internal bool IsSetError()
        {
            return this._error != null;
        }

        /// <summary>
        /// Gets and sets the property ImageConfig. 
        /// <para>
        /// Configuration values that override the container image Dockerfile.
        /// </para>
        /// </summary>
        public ImageConfig ImageConfig
        {
            get { return this._imageConfig; }
            set { this._imageConfig = value; }
        }

        // Check to see if ImageConfig property is set
        internal bool IsSetImageConfig()
        {
            return this._imageConfig != null;
        }

    }
}