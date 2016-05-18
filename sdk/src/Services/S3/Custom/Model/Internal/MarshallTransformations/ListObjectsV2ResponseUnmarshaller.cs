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
    ///    Response Unmarshaller for ListObjects operation
    /// </summary>
    internal class ListObjectsV2ResponseUnmarshaller : S3ReponseUnmarshaller
    {
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context) 
        {
            ListObjectsV2Response response = new ListObjectsV2Response();
            
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

        private static void UnmarshallResult(XmlUnmarshallerContext context, ListObjectsV2Response response)
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
                    if (context.TestExpression("Contents", targetDepth))
                    {
                        response.S3Objects.Add(ContentsItemUnmarshaller.Instance.Unmarshall(context));

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
                            response.CommonPrefixes.Add(prefix);
                            
                        continue;
                    }
                    if (context.TestExpression("EncodingType", targetDepth))
                    {
                        response.Encoding = StringUnmarshaller.GetInstance().Unmarshall(context);

                        continue;
                    }
                    if (context.TestExpression("KeyCount", targetDepth))
                    {
                        response.KeyCount = IntUnmarshaller.GetInstance().Unmarshall(context);

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
                    if (context.TestExpression("StartAfter", targetDepth))
                    {
                        response.StartAfter = StringUnmarshaller.GetInstance().Unmarshall(context);

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

        private static ListObjectsV2ResponseUnmarshaller _instance;

        public static ListObjectsV2ResponseUnmarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ListObjectsV2ResponseUnmarshaller();
                }
                return _instance;
            }
        }
    }
}
    
