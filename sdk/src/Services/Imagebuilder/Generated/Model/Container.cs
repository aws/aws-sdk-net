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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// A container encapsulates the runtime environment for an application.
    /// </summary>
    public partial class Container
    {
        private List<string> _imageUris = new List<string>();
        private string _region;

        /// <summary>
        /// Gets and sets the property ImageUris. 
        /// <para>
        /// A list of URIs for containers created in the context Region.
        /// </para>
        /// </summary>
        public List<string> ImageUris
        {
            get { return this._imageUris; }
            set { this._imageUris = value; }
        }

        // Check to see if ImageUris property is set
        internal bool IsSetImageUris()
        {
            return this._imageUris != null && this._imageUris.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// Containers and container images are Region-specific. This is the Region context for
        /// the container.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

    }
}