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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Container for the parameters to the RequestUploadCredentials operation.
    /// Retrieves a fresh set of credentials for use when uploading a new set of game build
    /// files to Amazon GameLift's Amazon S3. This is done as part of the build creation process;
    /// see <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_CreateBuild.html">GameSession</a>.
    /// 
    ///  
    /// <para>
    /// To request new credentials, specify the build ID as returned with an initial <code>CreateBuild</code>
    /// request. If successful, a new set of credentials are returned, along with the S3 storage
    /// location associated with the build ID.
    /// </para>
    ///  
    /// <para>
    ///  <b>Learn more</b> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-build-cli-uploading.html#gamelift-build-cli-uploading-create-build">
    /// Create a Build with Files in S3</a> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
    /// APIs by task</a> 
    /// </para>
    /// </summary>
    public partial class RequestUploadCredentialsRequest : AmazonGameLiftRequest
    {
        private string _buildId;

        /// <summary>
        /// Gets and sets the property BuildId. 
        /// <para>
        /// A unique identifier for the build to get credentials for. You can use either the build
        /// ID or ARN value. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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