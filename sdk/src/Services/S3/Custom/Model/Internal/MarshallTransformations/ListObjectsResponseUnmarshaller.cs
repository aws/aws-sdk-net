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
    public class ListObjectsResponseUnmarshaller : S3ReponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context) 
        {   
            ListObjectsResponse response = new ListObjectsResponse();
            
            while (context.Read())
            {
                if (context.IsStartElement)
                {                    
                    UnmarshallResult(context,response);                        
                    continue;
                }
            }

            IWebResponseData responseData = context.ResponseData;
            if (responseData.IsHeaderPresent(S3Constants.AmzHeaderRequestCharged))
                response.RequestCharged = RequestCharged.FindValue(responseData.GetHeaderValue(S3Constants.AmzHeaderRequestCharged));

            return response;
        }
        
        private static void UnmarshallResult(XmlUnmarshallerContext context,ListObjectsResponse response)
        {
            
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("IsTruncated", targetDepth))
                    {
                        response.IsTruncated = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("NextMarker", targetDepth))
                    {
                        response.NextMarker = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Contents", targetDepth))
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
                        continue;
                    }
                    if (context.TestExpression("Name", targetDepth))
                    {
                        response.Name = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Prefix", targetDepth))
                    {
                        response.Prefix = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Delimiter", targetDepth))
                    {
                        response.Delimiter = StringUnmarshaller.GetInstance().Unmarshall(context);

                        continue;
                    }
                    if (context.TestExpression("MaxKeys", targetDepth))
                    {
                        response.MaxKeys = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("CommonPrefixes", targetDepth))
                    {
                        var prefix = CommonPrefixesItemUnmarshaller.Instance.Unmarshall(context);

                        if(prefix != null)
                        {
                            if (response.CommonPrefixes == null)
                            {
                                response.CommonPrefixes = new List<string>();
                            }
                            response.CommonPrefixes.Add(prefix);
                        }

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

        private static ListObjectsResponseUnmarshaller _instance;

        /// <summary>
        /// Singleton for the unmarshaller
        /// </summary>
        public static ListObjectsResponseUnmarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ListObjectsResponseUnmarshaller();
                }
                return _instance;
            }
        }
    }
}
    
