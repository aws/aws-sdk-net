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

namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Contains settings for Image Builder image resource and container image scans.
    /// </summary>
    public partial class ImageScanningConfiguration
    {
        /// <summary>
        /// Gets and sets the property EcrConfiguration. 
        /// <para>
        /// Contains Amazon ECR settings for vulnerability scans.
        /// </para>
        /// </summary>
        public EcrConfiguration EcrConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EcrConfiguration property is set.
        /// </summary>
        internal bool IsSetEcrConfiguration() => this.EcrConfiguration != null;

        /// <summary>
        /// Gets and sets the property ImageScanningEnabled. 
        /// <para>
        /// Specifies whether Amazon Inspector scans for vulnerabilities when you create a new
        /// image, and whether Image Builder saves the findings. Amazon Inspector must be enabled
        /// in the account. Image tests must also be enabled. For AMI output, Amazon Inspector
        /// scans the test instance. For container output, Amazon Inspector scans the container
        /// image that Image Builder pushes to the Amazon ECR repository from your <c>ecrConfiguration</c>
        /// settings.
        /// </para>
        /// </summary>
        public bool? ImageScanningEnabled { get; set; }

        /// <summary>
        /// Checks to see if the ImageScanningEnabled property is set.
        /// </summary>
        internal bool IsSetImageScanningEnabled() => this.ImageScanningEnabled.HasValue;
    }
}
