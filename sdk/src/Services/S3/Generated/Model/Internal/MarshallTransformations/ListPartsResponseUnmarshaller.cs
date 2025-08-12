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
    /// Response Unmarshaller for ListParts operation
    /// </summary>  
    public partial class ListPartsResponseUnmarshaller : S3ReponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            ListPartsResponse response = new ListPartsResponse();
            UnmarshallResult(context,response);
            if (context.ResponseData.IsHeaderPresent("x-amz-abort-date"))
                response.AbortDate = DateTime.Parse(context.ResponseData.GetHeaderValue("x-amz-abort-date"), CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal | DateTimeStyles.AdjustToUniversal);
            if (context.ResponseData.IsHeaderPresent("x-amz-abort-rule-id"))
                response.AbortRuleId = context.ResponseData.GetHeaderValue("x-amz-abort-rule-id");
            if (context.ResponseData.IsHeaderPresent("x-amz-request-charged"))
                response.RequestCharged = context.ResponseData.GetHeaderValue("x-amz-request-charged");
            
            PostUnmarshallCustomization(context, response);
            return response;
        }        

        private static void UnmarshallResult(XmlUnmarshallerContext context, ListPartsResponse response)
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
                    if (context.TestExpression("Bucket", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.BucketName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ChecksumAlgorithm", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.ChecksumAlgorithm = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ChecksumType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.ChecksumType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Initiator", targetDepth))
                    {
                        var unmarshaller = InitiatorUnmarshaller.Instance;
                        response.Initiator = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("IsTruncated", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        response.IsTruncated = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Key", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.Key = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MaxParts", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        response.MaxParts = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("NextPartNumberMarker", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        response.NextPartNumberMarker = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Owner", targetDepth))
                    {
                        var unmarshaller = OwnerUnmarshaller.Instance;
                        response.Owner = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("PartNumberMarker", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        response.PartNumberMarker = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Part", targetDepth))
                    {
                        if (response.Parts == null)
                        {
                            response.Parts = new List<PartDetail>();
                        }
                        var unmarshaller = PartDetailUnmarshaller.Instance;
                        response.Parts.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }
                    if (context.TestExpression("StorageClass", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.StorageClass = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("UploadId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.UploadId = unmarshaller.Unmarshall(context);
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

        partial void PostUnmarshallCustomization(XmlUnmarshallerContext context, ListPartsResponse response);

        private static ListPartsResponseUnmarshaller _instance = new ListPartsResponseUnmarshaller();        

        internal static ListPartsResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListPartsResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}