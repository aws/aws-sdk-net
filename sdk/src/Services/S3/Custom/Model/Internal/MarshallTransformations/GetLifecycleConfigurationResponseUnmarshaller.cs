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
using System.Net;
using Amazon.Runtime.Internal.Transform;
using Amazon.S3.Util;

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Custom response unmarshaller for GetLifecycleConfiguration operation.
    /// Handles the case where S3 returns an HTTP 200 with an empty body when
    /// no lifecycle configuration exists on the bucket. In this case, we throw
    /// an AmazonS3Exception with the NoSuchLifecycleConfiguration error code
    /// to match the documented S3 API behavior.
    /// See: https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetBucketLifecycleConfiguration.html
    /// </summary>
    public partial class GetLifecycleConfigurationResponseUnmarshaller
    {
        partial void PostUnmarshallCustomization(XmlUnmarshallerContext context, GetLifecycleConfigurationResponse response)
        {
            // When S3 returns an HTTP 200 with an empty body (no lifecycle configuration),
            // the Configuration property will not have been set by the unmarshaller.
            // The S3 API documentation states that NoSuchLifecycleConfiguration (HTTP 404)
            // should be returned when no lifecycle configuration exists:
            // https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetBucketLifecycleConfiguration.html
            if (context.IsEmptyResponse && !response.IsSetConfiguration())
            {
                throw new AmazonS3Exception("The lifecycle configuration does not exist")
                {
                    ErrorCode = S3Constants.NoSuchLifecycleConfiguration,
                    StatusCode = HttpStatusCode.NotFound
                };
            }
        }
    }
}
