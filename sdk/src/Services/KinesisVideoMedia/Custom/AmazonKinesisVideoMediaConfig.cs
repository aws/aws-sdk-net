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

using System;

using Amazon.Runtime;
using Amazon.Util.Internal;


namespace Amazon.KinesisVideoMedia
{
    /// <summary>
    /// Configuration for accessing Amazon KinesisVideoMedia service
    /// </summary>
    public partial class AmazonKinesisVideoMediaConfig : ClientConfig
    {
        /// <summary>
        /// This method contains custom initializations for the config object.
        /// </summary>
        protected override void Initialize()
        {
            this.AllowAutoRedirect = false;
#if BCL || NETSTANDARD
            // Set Timeout and ReadWriteTimeout for Amazon KinesisVideoMedia service to max timeout as per-request
            // timeouts are not supported.
            this.Timeout = ClientConfig.MaxTimeout;
#if NETFRAMEWORK
            this.ReadWriteTimeout = ClientConfig.MaxTimeout;
#endif
#endif
        }
    }
}