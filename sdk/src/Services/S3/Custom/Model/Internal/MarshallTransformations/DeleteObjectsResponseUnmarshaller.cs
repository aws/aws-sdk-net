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
using Amazon.S3.Util;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    ///    Response Unmarshaller for DeleteObjects operation
    /// </summary>
    public class DeleteObjectsResponseUnmarshaller : S3ReponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context) 
        {   
            DeleteObjectsResponse response = new DeleteObjectsResponse();
            
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
        
        private static void UnmarshallResult(XmlUnmarshallerContext context,DeleteObjectsResponse response)
        {
            IWebResponseData responseData = context.ResponseData;
            if (responseData.IsHeaderPresent(S3Constants.AmzHeaderRequestCharged))
                response.RequestCharged = RequestCharged.FindValue(responseData.GetHeaderValue(S3Constants.AmzHeaderRequestCharged));

            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Deleted", targetDepth))
                    {
                        if (response.DeletedObjects == null)
                        {
                            response.DeletedObjects = new List<DeletedObject>();
                        }

                        response.DeletedObjects.Add(DeletedObjectUnmarshaller.Instance.Unmarshall(context));
                        continue;
                    }
                    if (context.TestExpression("Error", targetDepth))
                    {
                        if (response.DeleteErrors == null)
                        {
                            response.DeleteErrors = new List<DeleteError>();
                        }

                        response.DeleteErrors.Add(ErrorsItemUnmarshaller.Instance.Unmarshall(context));
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

        private static DeleteObjectsResponseUnmarshaller _instance;

        /// <summary>
        /// Singleton for the unmarshaller
        /// </summary>
        public static DeleteObjectsResponseUnmarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DeleteObjectsResponseUnmarshaller();
                }
                return _instance;
            }
        }
    }
}
    
