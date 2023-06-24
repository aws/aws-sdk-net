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
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.S3.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetObjectAttributes operation
    /// </summary>  
    public class GetObjectAttributesResponseUnmarshaller : S3ReponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            GetObjectAttributesResponse response = new GetObjectAttributesResponse();
            UnmarshallResult(context, response);
            if (context.ResponseData.IsHeaderPresent("x-amz-delete-marker"))
                response.DeleteMarker = S3Transforms.ToBool(context.ResponseData.GetHeaderValue("x-amz-delete-marker"));
            if (context.ResponseData.IsHeaderPresent("Last-Modified"))
                    response.LastModified = S3Transforms.ToDateTime(context.ResponseData.GetHeaderValue("Last-Modified"));
            if (context.ResponseData.IsHeaderPresent("x-amz-request-charged"))
                response.RequestCharged = context.ResponseData.GetHeaderValue("x-amz-request-charged");
            if (context.ResponseData.IsHeaderPresent("x-amz-version-id"))
                response.VersionId = context.ResponseData.GetHeaderValue("x-amz-version-id");

            return response;
        }

        private static void UnmarshallResult(XmlUnmarshallerContext context, GetObjectAttributesResponse response)
        {
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument)
                targetDepth += 1;

            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Checksum", targetDepth))
                    {
                        var unmarshaller = ChecksumUnmarshaller.Instance;
                        response.Checksum = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ETag", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.ETag = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ObjectParts", targetDepth))
                    {
                        var unmarshaller = GetObjectAttributesPartsUnmarshaller.Instance;
                        response.ObjectParts = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ObjectSize", targetDepth))
                    {
                        var unmarshaller = LongUnmarshaller.Instance;
                        response.ObjectSize = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("StorageClass", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.StorageClass = unmarshaller.Unmarshall(context);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return;
                }
            }

            return;
        }

        private static GetObjectAttributesResponseUnmarshaller _instance = new GetObjectAttributesResponseUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetObjectAttributesResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}