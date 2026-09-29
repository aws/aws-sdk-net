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

namespace Amazon.Omics.Model
{
    /// <summary>
    /// Specifies image mappings that workflow tasks can use. For example, you can replace
    /// all the task references of a public image to use an equivalent image in your private
    /// ECR repository. You can use image mappings with upstream registries that don't support
    /// pull through cache. You need to manually synchronize the upstream registry with your
    /// private repository.
    /// </summary>
    public partial class ImageMapping
    {
        /// <summary>
        /// Gets and sets the property DestinationImage. 
        /// <para>
        /// Specifies the URI of the corresponding image in the private ECR registry.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 750)]
        public string DestinationImage { get; set; }

        /// <summary>
        /// Checks to see if the DestinationImage property is set.
        /// </summary>
        internal bool IsSetDestinationImage() => this.DestinationImage != null;

        /// <summary>
        /// Gets and sets the property SourceImage. 
        /// <para>
        /// Specifies the URI of the source image in the upstream registry.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 750)]
        public string SourceImage { get; set; }

        /// <summary>
        /// Checks to see if the SourceImage property is set.
        /// </summary>
        internal bool IsSetSourceImage() => this.SourceImage != null;
    }
}
