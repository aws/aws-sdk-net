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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Container for the parameters to the PublishLayerVersion operation.
    /// Creates an <a href="http://docs.aws.amazon.com/lambda/latest/dg/configuration-layers.html">AWS
    /// Lambda layer</a> from a ZIP archive. Each time you call <code>PublishLayerVersion</code>
    /// with the same version name, a new version is created.
    /// 
    ///  
    /// <para>
    /// Add layers to your function with <a>CreateFunction</a> or <a>UpdateFunctionConfiguration</a>.
    /// </para>
    /// </summary>
    public partial class PublishLayerVersionRequest : AmazonLambdaRequest
    {
        private List<string> _compatibleRuntimes = new List<string>();
        private LayerVersionContentInput _content;
        private string _description;
        private string _layerName;
        private string _licenseInfo;

        /// <summary>
        /// Gets and sets the property CompatibleRuntimes. 
        /// <para>
        /// A list of compatible <a href="http://docs.aws.amazon.com/lambda/latest/dg/lambda-runtimes.html">function
        /// runtimes</a>. Used for filtering with <a>ListLayers</a> and <a>ListLayerVersions</a>.
        /// </para>
        /// </summary>
        public List<string> CompatibleRuntimes
        {
            get { return this._compatibleRuntimes; }
            set { this._compatibleRuntimes = value; }
        }

        // Check to see if CompatibleRuntimes property is set
        internal bool IsSetCompatibleRuntimes()
        {
            return this._compatibleRuntimes != null && this._compatibleRuntimes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The function layer archive.
        /// </para>
        /// </summary>
        public LayerVersionContentInput Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        // Check to see if Content property is set
        internal bool IsSetContent()
        {
            return this._content != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the version.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property LayerName. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of the layer.
        /// </para>
        /// </summary>
        public string LayerName
        {
            get { return this._layerName; }
            set { this._layerName = value; }
        }

        // Check to see if LayerName property is set
        internal bool IsSetLayerName()
        {
            return this._layerName != null;
        }

        /// <summary>
        /// Gets and sets the property LicenseInfo. 
        /// <para>
        /// The layer's software license. It can be any of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// An <a href="https://spdx.org/licenses/">SPDX license identifier</a>. For example,
        /// <code>MIT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The URL of a license hosted on the internet. For example, <code>https://opensource.org/licenses/MIT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The full text of the license.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string LicenseInfo
        {
            get { return this._licenseInfo; }
            set { this._licenseInfo = value; }
        }

        // Check to see if LicenseInfo property is set
        internal bool IsSetLicenseInfo()
        {
            return this._licenseInfo != null;
        }

    }
}