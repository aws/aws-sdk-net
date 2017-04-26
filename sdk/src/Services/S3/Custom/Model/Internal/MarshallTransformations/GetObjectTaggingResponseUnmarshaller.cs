/*
 * Copyright 2010-2016 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetObjectTagging operation
    /// </summary>
    public class GetObjectTaggingResponseUnmarshaller : S3ReponseUnmarshaller
    {
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context) 
        {
            GetObjectTaggingResponse response = new GetObjectTaggingResponse();
            
            while (context.Read())
            {
                if (context.IsStartElement)
                {
                    UnmarshallResult(context, response);
                    continue;
                }
            }
            return response;
        }
        
        private static void UnmarshallResult(XmlUnmarshallerContext context, GetObjectTaggingResponse response)
        {
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 2;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;

            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Tag", targetDepth))
                    {
                        response.Tagging.Add(TagUnmarshaller.Instance.Unmarshall(context));

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

        private static GetObjectTaggingResponseUnmarshaller _instance;
        
        public static GetObjectTaggingResponseUnmarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GetObjectTaggingResponseUnmarshaller();
                }
                return _instance;
            }
        }
    }
}
    
