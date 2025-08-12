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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
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

#pragma warning disable CS0612,CS0618
namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ListVersions operation
    /// </summary>  
    public partial class ListVersionsResponseUnmarshaller : S3ReponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            ListVersionsResponse response = new ListVersionsResponse();
            UnmarshallResult(context,response);
            if (context.ResponseData.IsHeaderPresent("x-amz-request-charged"))
                response.RequestCharged = context.ResponseData.GetHeaderValue("x-amz-request-charged");
            
            PostUnmarshallCustomization(context, response);
            return response;
        }        

        private static void UnmarshallResult(XmlUnmarshallerContext context, ListVersionsResponse response)
        {
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument) 
                   targetDepth += 1;
            if (context.IsEmptyResponse)
            {
                return;
            }
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("CommonPrefixes", targetDepth))
                    {
                        if (response.CommonPrefixes == null)
                        {
                            response.CommonPrefixes = new List<string>();
                        }
                        var unmarshaller = CommonPrefixesItemUnmarshaller.Instance;
                        response.CommonPrefixes.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }
                    if (context.TestExpression("DeleteMarker", targetDepth))
                    {
                        DeleteItemCustomUnmarshall(context, response);
                        continue;
                    }
                    if (context.TestExpression("Delimiter", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.Delimiter = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("EncodingType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.Encoding = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("IsTruncated", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        response.IsTruncated = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("KeyMarker", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.KeyMarker = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MaxKeys", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        response.MaxKeys = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Name", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.Name = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("NextKeyMarker", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.NextKeyMarker = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("NextVersionIdMarker", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.NextVersionIdMarker = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Prefix", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.Prefix = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("VersionIdMarker", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.VersionIdMarker = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Version", targetDepth))
                    {
                        VersionsItemCustomUnmarshall(context, response);
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
  

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="innerException"></param>
        /// <param name="statusCode"></param>
        /// <returns></returns>
        public override AmazonServiceException UnmarshallException(XmlUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            S3ErrorResponse errorResponse = S3ErrorResponseUnmarshaller.Instance.Unmarshall(context);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            using (var contextCopy = new XmlUnmarshallerContext(streamCopy, false, null))
            {
            }
            return base.ConstructS3Exception(context, errorResponse, innerException, statusCode);
        }

        partial void PostUnmarshallCustomization(XmlUnmarshallerContext context, ListVersionsResponse response);

        private static ListVersionsResponseUnmarshaller _instance = new ListVersionsResponseUnmarshaller();        

        internal static ListVersionsResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListVersionsResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}