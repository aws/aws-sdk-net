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
    /// Response Unmarshaller for ListObjectAnnotations operation
    /// </summary>  
    public partial class ListObjectAnnotationsResponseUnmarshaller : S3ReponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            ListObjectAnnotationsResponse response = new ListObjectAnnotationsResponse();
            UnmarshallResult(context,response);
            if (context.ResponseData.IsHeaderPresent("x-amz-object-version-id"))
                response.ObjectVersionId = context.ResponseData.GetHeaderValue("x-amz-object-version-id");
            if (context.ResponseData.IsHeaderPresent("x-amz-request-charged"))
                response.RequestCharged = context.ResponseData.GetHeaderValue("x-amz-request-charged");
            
            PostUnmarshallCustomization(context, response);
            return response;
        }        

        private static void UnmarshallResult(XmlUnmarshallerContext context, ListObjectAnnotationsResponse response)
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
                    if (context.TestExpression("AnnotationCount", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        response.AnnotationCount = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("AnnotationPrefix", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.AnnotationPrefix = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Annotations/AnnotationEntry", targetDepth))
                    {
                        if (response.Annotations == null)
                        {
                            response.Annotations = new List<AnnotationEntry>();
                        }
                        var unmarshaller = AnnotationEntryUnmarshaller.Instance;
                        response.Annotations.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }
                    if (context.TestExpression("Bucket", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.BucketName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ContinuationToken", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.ContinuationToken = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Key", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.Key = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MaxAnnotationResults", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        response.MaxAnnotationResults = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("NextContinuationToken", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.NextContinuationToken = unmarshaller.Unmarshall(context);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidPrefix"))
                {
                    return InvalidPrefixExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("NoSuchBucket"))
                {
                    return NoSuchBucketExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("NoSuchKey"))
                {
                    return NoSuchKeyExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return base.ConstructS3Exception(context, errorResponse, innerException, statusCode);
        }

        partial void PostUnmarshallCustomization(XmlUnmarshallerContext context, ListObjectAnnotationsResponse response);

        private static ListObjectAnnotationsResponseUnmarshaller _instance = new ListObjectAnnotationsResponseUnmarshaller();        

        internal static ListObjectAnnotationsResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListObjectAnnotationsResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}