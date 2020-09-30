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
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amazon.S3Control.Internal
{
    /// <summary>
    /// Type of S3 Outpost Resource
    /// </summary>
    public enum S3ResourceType
    {
        /// <summary>
        /// Access point ARN in format
        /// arn:aws:s3-outposts:us-west-2:123456789012:outpost/[outpost-id]/accesspoint/[accesspoint-name]
        /// </summary>
        AccessPoint,
        /// <summary>
        /// Bucket ARN in format
        /// arn:aws:s3-outposts:us-west-2:123456789012:outpost/[outpost-id]/bucket/[bucket-name]
        /// </summary>
        Bucket
    }
}
