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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// AWS access credentials required to upload game build files to GameLift. These credentials
    /// are generated with <a>CreateBuild</a>, and are valid for a limited time. If they expire
    /// before you upload your game build, get a new set by calling <a>RequestUploadCredentials</a>.
    /// </summary>
    public partial class Credentials : AWSCredentials
    {
        private ImmutableCredentials _credentials = null;

        /// <summary>
        /// Returns a copy of ImmutableCredentials corresponding to these credentials
        /// </summary>
        /// <returns></returns>
        public override ImmutableCredentials GetCredentials()
        {
            if (_credentials == null)
                _credentials = new ImmutableCredentials(AccessKeyId, SecretAccessKey, SessionToken);
            return _credentials;
        }
    }
}