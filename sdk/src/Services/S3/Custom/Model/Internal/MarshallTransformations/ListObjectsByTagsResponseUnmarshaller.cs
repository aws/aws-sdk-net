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

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ListObjectsByTags operation
    /// </summary>
    internal class ListObjectsByTagsResponseUnmarshaller : S3ReponseUnmarshaller
    {
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context) 
        {   
            ListObjectsByTagsResponse response = new ListObjectsByTagsResponse();

            UnmarshallResult(context, response);

            return response;
        }
        
        private static void UnmarshallResult(XmlUnmarshallerContext context, ListObjectsByTagsResponse response)
        {
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth;

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
                    if (context.TestExpression("ContinuationToken", targetDepth))
                    {
                        response.ContinuationToken = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("NextContinuationToken", targetDepth))
                    {
                        response.NextContinuationToken = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MaxKeys", targetDepth))
                    {
                        response.MaxKeys = IntUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("IsTruncated", targetDepth))
                    {
                        response.IsTruncated = BoolUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("EncodingType", targetDepth))
                    {
                        response.EncodingType = EncodingType.FindValue(StringUnmarshaller.GetInstance().Unmarshall(context));
                        continue;
                    }
                    if (context.TestExpression("Contents", targetDepth))
                    {
                        response.Contents.Add(TaggedResourceUnmarshaller.Instance.Unmarshall(context));
                    }
                }
            }
        }

        private static ListObjectsByTagsResponseUnmarshaller _instance;

        public static ListObjectsByTagsResponseUnmarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ListObjectsByTagsResponseUnmarshaller();
                }
                return _instance;
            }
        }
    }
}
    
