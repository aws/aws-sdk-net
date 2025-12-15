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
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.S3.Model;
using Amazon.S3.Util;
using System;
using System.Collections.Generic;
using System.Net;

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    ///    Response Unmarshaller for ListObjects operation
    /// </summary>
    public partial class ListObjectsResponseUnmarshaller : S3ReponseUnmarshaller
    {
        private static void ContentsCustomUnmarshall(XmlUnmarshallerContext context, ListObjectsResponse response)
        {
            if (response.S3Objects == null)
            {
                response.S3Objects = new List<S3Object>();
            }

            // adding the bucket name into the S3Object instance enables
            // a better pipelining experience in PowerShell
            var s3Object = ContentsItemUnmarshaller.Instance.Unmarshall(context);
            s3Object.BucketName = response.Name;
            response.S3Objects.Add(s3Object);
        }
    }
}
    
