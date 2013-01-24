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
using System.Collections.Generic;

using Amazon.CloudSearch.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CloudSearch.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   ServiceEndpoint Unmarshaller
     /// </summary>
    internal class ServiceEndpointUnmarshaller : IUnmarshaller<ServiceEndpoint, XmlUnmarshallerContext> 
    {
        public ServiceEndpoint Unmarshall(XmlUnmarshallerContext context) 
        {
            ServiceEndpoint serviceEndpoint = new ServiceEndpoint();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("Arn", targetDepth))
                    {
                        serviceEndpoint.Arn = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Endpoint", targetDepth))
                    {
                        serviceEndpoint.Endpoint = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return serviceEndpoint;
                }
            }
                        


            return serviceEndpoint;
        }

        private static ServiceEndpointUnmarshaller instance;

        public static ServiceEndpointUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new ServiceEndpointUnmarshaller();

            return instance;
        }
    }
}
    
