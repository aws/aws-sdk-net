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

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetPublicAccessBlock operation
    /// </summary>
    public class GetPublicAccessBlockResponseUnmarshaller : S3ReponseUnmarshaller
    {
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context) 
        {
            var response = new GetPublicAccessBlockResponse();
            UnmarshallResult(context, response);                        
            return response;
        }

        private static void UnmarshallResult(XmlUnmarshallerContext context, GetPublicAccessBlockResponse response)
        {                        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
                        
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("PublicAccessBlockConfiguration", targetDepth))
                    {                    
                        response.PublicAccessBlockConfiguration = PublicAccessBlockConfigurationUnmarshaller.Instance.Unmarshall(context);
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return;
                }
            }            
        }

        private static GetPublicAccessBlockResponseUnmarshaller _instance;

        public static GetPublicAccessBlockResponseUnmarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GetPublicAccessBlockResponseUnmarshaller();
                }
                return _instance;
            }
        }
    }
}
    
