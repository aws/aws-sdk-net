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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// This is the response object from the ListCuratedEnvironmentImages operation.
    /// </summary>
    public partial class ListCuratedEnvironmentImagesResponse : AmazonWebServiceResponse
    {
        private List<EnvironmentPlatform> _platforms = new List<EnvironmentPlatform>();

        /// <summary>
        /// Gets and sets the property Platforms. 
        /// <para>
        /// Information about supported platforms for Docker images that are managed by AWS CodeBuild.
        /// </para>
        /// </summary>
        public List<EnvironmentPlatform> Platforms
        {
            get { return this._platforms; }
            set { this._platforms = value; }
        }

        // Check to see if Platforms property is set
        internal bool IsSetPlatforms()
        {
            return this._platforms != null && this._platforms.Count > 0; 
        }

    }
}