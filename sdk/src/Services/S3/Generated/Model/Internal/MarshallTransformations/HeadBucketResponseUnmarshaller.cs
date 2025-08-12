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
    /// Response Unmarshaller for HeadBucket operation
    /// </summary>  
    public class HeadBucketResponseUnmarshaller : S3ReponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            HeadBucketResponse response = new HeadBucketResponse();
            if (context.ResponseData.IsHeaderPresent("x-amz-access-point-alias"))
                response.AccessPointAlias = bool.Parse(context.ResponseData.GetHeaderValue("x-amz-access-point-alias"));
            if (context.ResponseData.IsHeaderPresent("x-amz-bucket-arn"))
                response.BucketArn = context.ResponseData.GetHeaderValue("x-amz-bucket-arn");
            if (context.ResponseData.IsHeaderPresent("x-amz-bucket-location-name"))
                response.BucketLocationName = context.ResponseData.GetHeaderValue("x-amz-bucket-location-name");
            if (context.ResponseData.IsHeaderPresent("x-amz-bucket-location-type"))
                response.BucketLocationType = context.ResponseData.GetHeaderValue("x-amz-bucket-location-type");
            if (context.ResponseData.IsHeaderPresent("x-amz-bucket-region"))
                response.BucketRegion = context.ResponseData.GetHeaderValue("x-amz-bucket-region");
            
            return response;
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

        private static HeadBucketResponseUnmarshaller _instance = new HeadBucketResponseUnmarshaller();        

        internal static HeadBucketResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static HeadBucketResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}