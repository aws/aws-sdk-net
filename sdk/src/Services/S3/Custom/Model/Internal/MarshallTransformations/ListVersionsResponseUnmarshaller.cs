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
    ///    Response Unmarshaller for ListVersions operation
    /// </summary>
    public partial class ListVersionsResponseUnmarshaller : S3ReponseUnmarshaller
    {
        // https://github.com/aws/aws-sdk-net/blob/79cbc392fc3f1c74fcdf34efd77ad681da8af328/sdk/src/Services/S3/Custom/Model/Internal/MarshallTransformations/ListVersionsResponseUnmarshaller.cs#L105-L115
        private static void DeleteItemCustomUnmarshall(XmlUnmarshallerContext context, ListVersionsResponse response)
        {
            if (response.Versions == null)
            {
                response.Versions = new List<S3ObjectVersion>();
            }

            var version = S3ObjectVersionUnmarshaller.Instance.Unmarshall(context);
            version.BucketName = response.Name;
            version.IsDeleteMarker = true;
            response.Versions.Add(version);
            return;
        }
        // https://github.com/aws/aws-sdk-net/blob/79cbc392fc3f1c74fcdf34efd77ad681da8af328/sdk/src/Services/S3/Custom/Model/Internal/MarshallTransformations/ListVersionsResponseUnmarshaller.cs#L117-L128
        private static void VersionsItemCustomUnmarshall(XmlUnmarshallerContext context, ListVersionsResponse response)
        {
            if (response.Versions == null)
            {
                response.Versions = new List<S3ObjectVersion>();
            }

            var version = S3ObjectVersionUnmarshaller.Instance.Unmarshall(context);
            version.BucketName = response.Name;
            response.Versions.Add(version);
            return;
        }

    }
}
    
