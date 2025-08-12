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
using System.Net;
using System.Collections.Generic;
using Amazon.S3.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.S3.Util;

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    ///    Response Unmarshaller for ListObjects operation
    /// </summary>
    public partial class ListObjectsV2ResponseUnmarshaller : S3ReponseUnmarshaller
    {
        //https://github.com/aws/aws-sdk-net/blob/79cbc392fc3f1c74fcdf34efd77ad681da8af328/sdk/src/Services/S3/Custom/Model/Internal/MarshallTransformations/ListObjectsV2ResponseUnmarshaller.cs#L75-L87
        private static void CustomContentsUnmarshall(XmlUnmarshallerContext context, ListObjectsV2Response response)
        {           
            // adding the bucket name into the S3Object instance enables
            // a better pipelining experience in PowerShell
            if (response.S3Objects == null)
            {
                response.S3Objects = new List<S3Object>();
            }
            var s3Object = S3ObjectUnmarshaller.Instance.Unmarshall(context);
            s3Object.BucketName = response.Name;
            response.S3Objects.Add(s3Object);

        }
    }
}
    
