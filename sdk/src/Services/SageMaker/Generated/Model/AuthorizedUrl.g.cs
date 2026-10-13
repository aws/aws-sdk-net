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
    /// Contains a presigned URL and its associated local file path for downloading hub content
    /// artifacts.
    /// </summary>
    public partial class AuthorizedUrl
    {
        /// <summary>
        /// Gets and sets the property LocalPath. 
        /// <para>
        /// The recommended local file path where the downloaded file should be stored to maintain
        /// proper directory structure and file organization.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string LocalPath { get; set; }

        /// <summary>
        /// Checks to see if the LocalPath property is set.
        /// </summary>
        internal bool IsSetLocalPath() => this.LocalPath != null;

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The presigned S3 URL that provides temporary, secure access to download the file.
        /// URLs expire within 15 minutes for security purposes.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string Url { get; set; }

        /// <summary>
        /// Checks to see if the Url property is set.
        /// </summary>
        internal bool IsSetUrl() => this.Url != null;
    }
}
