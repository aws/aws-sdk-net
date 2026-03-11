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
    /// Response Unmarshaller for ListObjectsV2 operation
    /// </summary>  
    public partial class ListObjectsV2ResponseUnmarshaller : S3ReponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            ListObjectsV2Response response = new ListObjectsV2Response();
            UnmarshallResult(context,response);
            if (context.ResponseData.IsHeaderPresent("x-amz-request-charged"))
                response.RequestCharged = context.ResponseData.GetHeaderValue("x-amz-request-charged");
            
            PostUnmarshallCustomization(context, response);
            return response;
        }        

        private static void UnmarshallResult(XmlUnmarshallerContext context, ListObjectsV2Response response)
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
                    if (context.TestExpression("ContinuationToken", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.ContinuationToken = unmarshaller.Unmarshall(context);
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
                    if (context.TestExpression("KeyCount", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        response.KeyCount = unmarshaller.Unmarshall(context);
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
                    if (context.TestExpression("NextContinuationToken", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.NextContinuationToken = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Prefix", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.Prefix = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Contents", targetDepth))
                    {
                        CustomContentsUnmarshall(context, response);
                        continue;
                    }
                    if (context.TestExpression("StartAfter", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.StartAfter = unmarshaller.Unmarshall(context);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("NoSuchBucket"))
                {
                    return NoSuchBucketExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return base.ConstructS3Exception(context, errorResponse, innerException, statusCode);
        }

        partial void PostUnmarshallCustomization(XmlUnmarshallerContext context, ListObjectsV2Response response);

        private static ListObjectsV2ResponseUnmarshaller _instance = new ListObjectsV2ResponseUnmarshaller();        

        internal static ListObjectsV2ResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListObjectsV2ResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}