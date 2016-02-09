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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Container for the parameters to the RequestUploadCredentials operation.
    /// Retrieves a fresh set of upload credentials and the assigned Amazon S3 storage location
    /// for a specific build. Valid credentials are required to upload your game build files
    /// to Amazon S3.
    /// 
    ///  <important>
    /// <para>
    /// Call this action only if you need credentials for a build created with <a>CreateBuild</a>.
    /// This is a rare situation; in most cases, builds are created using the CLI command
    /// <code>upload-build</code>, which creates a build record and also uploads build files.
    /// 
    /// </para>
    /// </important> 
    /// <para>
    /// Upload credentials are returned when you create the build, but they have a limited
    /// lifespan. You can get fresh credentials and use them to re-upload game files until
    /// the state of that build changes to READY. Once this happens, you must create a brand
    /// new build.
    /// </para>
    /// </summary>
    public partial class RequestUploadCredentialsRequest : AmazonGameLiftRequest
    {
        private string _buildId;

        /// <summary>
        /// Gets and sets the property BuildId. 
        /// <para>
        /// Unique identifier for the build you want to get credentials for. 
        /// </para>
        /// </summary>
        public string BuildId
        {
            get { return this._buildId; }
            set { this._buildId = value; }
        }

        // Check to see if BuildId property is set
        internal bool IsSetBuildId()
        {
            return this._buildId != null;
        }

    }
}