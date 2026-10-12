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

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// An image file from a managed login branding style in a user pool.
    /// </summary>
    public partial class AssetType
    {
        /// <summary>
        /// Gets and sets the property Bytes. 
        /// <para>
        /// The image file, in Base64-encoded binary.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000000)]
        public MemoryStream Bytes { get; set; }

        /// <summary>
        /// Checks to see if the Bytes property is set.
        /// </summary>
        internal bool IsSetBytes() => this.Bytes != null;

        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// The category that the image corresponds to in your managed login configuration. Managed
        /// login has asset categories for different types of logos, backgrounds, and icons.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AssetCategoryType Category { get; set; }

        /// <summary>
        /// Checks to see if the Category property is set.
        /// </summary>
        internal bool IsSetCategory() => this.Category != null;

        /// <summary>
        /// Gets and sets the property ColorMode. 
        /// <para>
        /// The display-mode target of the asset: light, dark, or browser-adaptive. For example,
        /// Amazon Cognito displays a dark-mode image only when the browser or application is
        /// in dark mode, but displays a browser-adaptive file in all contexts.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ColorSchemeModeType ColorMode { get; set; }

        /// <summary>
        /// Checks to see if the ColorMode property is set.
        /// </summary>
        internal bool IsSetColorMode() => this.ColorMode != null;

        /// <summary>
        /// Gets and sets the property Extension. 
        /// <para>
        /// The file type of the image file.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AssetExtensionType Extension { get; set; }

        /// <summary>
        /// Checks to see if the Extension property is set.
        /// </summary>
        internal bool IsSetExtension() => this.Extension != null;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The ID of the asset.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 40)]
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;
    }
}
