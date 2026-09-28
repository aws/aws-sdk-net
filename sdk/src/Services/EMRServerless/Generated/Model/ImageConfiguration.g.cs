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

namespace Amazon.EMRServerless.Model
{
    /// <summary>
    /// The applied image configuration.
    /// </summary>
    public partial class ImageConfiguration
    {
        /// <summary>
        /// Gets and sets the property ApplicationLevelDigestResolution. 
        /// <para>
        /// Boolean value indicating if the digest resolution is application level or workload
        /// level. If true, a custom image URI is resolved at application start time and all workloads
        /// submitted will use that image digest. If false, the custom image URI is resolved at
        /// the workload submission time.
        /// </para>
        /// </summary>
        public bool? ApplicationLevelDigestResolution { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationLevelDigestResolution property is set.
        /// </summary>
        internal bool IsSetApplicationLevelDigestResolution() => this.ApplicationLevelDigestResolution.HasValue;

        /// <summary>
        /// Gets and sets the property ImageUri. 
        /// <para>
        /// The image URI.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string ImageUri { get; set; }

        /// <summary>
        /// Checks to see if the ImageUri property is set.
        /// </summary>
        internal bool IsSetImageUri() => this.ImageUri != null;

        /// <summary>
        /// Gets and sets the property ResolvedImageDigest. 
        /// <para>
        /// The SHA256 digest of the image URI. This indicates which specific image the application
        /// is configured for. The image digest doesn't exist until an application has started.
        /// </para>
        /// </summary>
        public string ResolvedImageDigest { get; set; }

        /// <summary>
        /// Checks to see if the ResolvedImageDigest property is set.
        /// </summary>
        internal bool IsSetResolvedImageDigest() => this.ResolvedImageDigest != null;
    }
}
