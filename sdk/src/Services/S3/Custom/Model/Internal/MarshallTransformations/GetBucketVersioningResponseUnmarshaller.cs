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
    ///    Response Unmarshaller for GetBucketVersioning operation
    /// </summary>
    public class GetBucketVersioningResponseUnmarshaller : S3ReponseUnmarshaller
    {
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context) 
        {   
            GetBucketVersioningResponse response = new GetBucketVersioningResponse();
            
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
        
        private static void UnmarshallResult(XmlUnmarshallerContext context,GetBucketVersioningResponse response)
        {
            
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Status", targetDepth))
                    {
                        response.VersioningConfig.Status = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("MfaDelete", targetDepth))
                    {
                        response.VersioningConfig.EnableMfaDelete = string.Equals(StringUnmarshaller.GetInstance().Unmarshall(context), "Enabled");
                            
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

        private static GetBucketVersioningResponseUnmarshaller _instance;

        public static GetBucketVersioningResponseUnmarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GetBucketVersioningResponseUnmarshaller();
                }
                return _instance;
            }
        }
    }
}
    
