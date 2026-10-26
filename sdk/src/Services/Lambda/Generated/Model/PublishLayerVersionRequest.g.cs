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

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Container for the parameters to the PublishLayerVersion operation. Creates an <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-layers.html">Lambda
    /// layer</a> from a ZIP archive. Each time you call <c>PublishLayerVersion</c> with the
    /// same layer name, a new version is created. <para> Add layers to your function with
    /// <a>CreateFunction</a> or <a>UpdateFunctionConfiguration</a>. </para>
    /// </summary>
    public partial class PublishLayerVersionRequest : AmazonLambdaRequest
    {
        /// <summary>
        /// Gets and sets the property CompatibleArchitectures. 
        /// <para>
        /// A list of compatible <a href="https://docs.aws.amazon.com/lambda/latest/dg/foundation-arch.html">instruction
        /// set architectures</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2)]
        public List<string> CompatibleArchitectures { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the CompatibleArchitectures property is set.
        /// </summary>
        internal bool IsSetCompatibleArchitectures() => this.CompatibleArchitectures != null && (this.CompatibleArchitectures.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CompatibleRuntimes. 
        /// <para>
        /// A list of compatible <a href="https://docs.aws.amazon.com/lambda/latest/dg/lambda-runtimes.html">function
        /// runtimes</a>. Used for filtering with <a>ListLayers</a> and <a>ListLayerVersions</a>.
        /// </para>
        ///  
        /// <para>
        /// The following list includes deprecated runtimes. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/lambda-runtimes.html#runtime-support-policy">Runtime
        /// deprecation policy</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 15)]
        public List<string> CompatibleRuntimes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the CompatibleRuntimes property is set.
        /// </summary>
        internal bool IsSetCompatibleRuntimes() => this.CompatibleRuntimes != null && (this.CompatibleRuntimes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The function layer archive.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public LayerVersionContentInput Content { get; set; }

        /// <summary>
        /// Checks to see if the Content property is set.
        /// </summary>
        internal bool IsSetContent() => this.Content != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property LayerName. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of the layer.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 140)]
        public string LayerName { get; set; }

        /// <summary>
        /// Checks to see if the LayerName property is set.
        /// </summary>
        internal bool IsSetLayerName() => this.LayerName != null;

        /// <summary>
        /// Gets and sets the property LicenseInfo. 
        /// <para>
        /// The layer's software license. It can be any of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// An <a href="https://spdx.org/licenses/">SPDX license identifier</a>. For example,
        /// <c>MIT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The URL of a license hosted on the internet. For example, <c>https://opensource.org/licenses/MIT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The full text of the license.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public string LicenseInfo { get; set; }

        /// <summary>
        /// Checks to see if the LicenseInfo property is set.
        /// </summary>
        internal bool IsSetLicenseInfo() => this.LicenseInfo != null;
    }
}
