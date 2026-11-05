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

namespace Amazon.Continuum.Model
{
    /// <summary>
    /// Identity only. Future providers may add union members without duplicating state.
    /// </summary>
    public partial class DestinationTarget
    {
        /// <summary>
        /// Gets and sets the property Github. The GitHub repository the patch is delivered to,
        /// including the pull request once it is opened.
        /// </summary>
        public GitHubTarget Github { get; set; }

        /// <summary>
        /// Checks to see if the Github property is set.
        /// </summary>
        internal bool IsSetGithub() => this.Github != null;

        /// <summary>
        /// Gets and sets the property S3. The S3 object the patch is delivered to.
        /// </summary>
        public S3Target S3 { get; set; }

        /// <summary>
        /// Checks to see if the S3 property is set.
        /// </summary>
        internal bool IsSetS3() => this.S3 != null;
    }
}
