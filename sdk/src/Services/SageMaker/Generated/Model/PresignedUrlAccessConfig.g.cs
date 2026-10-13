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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Configuration for accessing hub content through presigned URLs, including license
    /// agreement acceptance and URL validation settings.
    /// </summary>
    public partial class PresignedUrlAccessConfig
    {
        /// <summary>
        /// Gets and sets the property AcceptEula. 
        /// <para>
        /// Indicates acceptance of the End User License Agreement (EULA) for gated models. Set
        /// to true to acknowledge acceptance of the license terms required for accessing gated
        /// content.
        /// </para>
        /// </summary>
        public bool? AcceptEula { get; set; }

        /// <summary>
        /// Checks to see if the AcceptEula property is set.
        /// </summary>
        internal bool IsSetAcceptEula() => this.AcceptEula.HasValue;

        /// <summary>
        /// Gets and sets the property ExpectedS3Url. 
        /// <para>
        /// The expected S3 URL prefix for validation purposes. This parameter helps ensure consistency
        /// between the resolved S3 URIs and the deployment configuration, reducing potential
        /// compatibility issues.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string ExpectedS3Url { get; set; }

        /// <summary>
        /// Checks to see if the ExpectedS3Url property is set.
        /// </summary>
        internal bool IsSetExpectedS3Url() => this.ExpectedS3Url != null;
    }
}
