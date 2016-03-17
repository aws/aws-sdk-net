/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using Amazon.Util;

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    ///    Response Unmarshaller for ListParts operation
    /// </summary>
    internal class ListPartsResponseUnmarshaller : S3ReponseUnmarshaller
    {
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context) 
        {   
            ListPartsResponse response = new ListPartsResponse();
            
            while (context.Read())
            {
                if (context.IsStartElement)
                {                    
                    UnmarshallResult(context,response);                        
                    continue;
                }
            }
                 
                        
            return response;
        }
        
        private static void UnmarshallResult(XmlUnmarshallerContext context,ListPartsResponse response)
        {
            
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Bucket", targetDepth))
                    {
                        response.BucketName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Key", targetDepth))
                    {
                        response.Key = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("UploadId", targetDepth))
                    {
                        response.UploadId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("PartNumberMarker", targetDepth))
                    {
                        response.PartNumberMarker = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("NextPartNumberMarker", targetDepth))
                    {
                        response.NextPartNumberMarker = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("MaxParts", targetDepth))
                    {
                        response.MaxParts = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("IsTruncated", targetDepth))
                    {
                        response.IsTruncated = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Part", targetDepth))
                    {
                        response.Parts.Add(PartDetailUnmarshaller.Instance.Unmarshall(context));
                            
                        continue;
                    }
                    if (context.TestExpression("Initiator", targetDepth))
                    {
                        response.Initiator = InitiatorUnmarshaller.Instance.Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Owner", targetDepth))
                    {
                        response.Owner = OwnerUnmarshaller.Instance.Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("StorageClass", targetDepth))
                    {
                        response.StorageClass = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return;
                }
            }

            IWebResponseData responseData = context.ResponseData;
            if (responseData.IsHeaderPresent(HeaderKeys.XAmzAbortDateHeader))
                response.AbortDate = S3Transforms.ToDateTime(responseData.GetHeaderValue(HeaderKeys.XAmzAbortDateHeader));
            if (responseData.IsHeaderPresent(HeaderKeys.XAmzAbortRuleIdHeader))
                response.AbortRuleId = S3Transforms.ToString(responseData.GetHeaderValue(HeaderKeys.XAmzAbortRuleIdHeader));

            return;
        }

        private static ListPartsResponseUnmarshaller _instance;

        public static ListPartsResponseUnmarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ListPartsResponseUnmarshaller();
                }
                return _instance;
            }
        }
    }
}
    
