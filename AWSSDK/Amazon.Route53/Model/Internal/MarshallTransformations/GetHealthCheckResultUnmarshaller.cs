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

using Amazon.Route53.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Route53.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   GetHealthCheckResult Unmarshaller
     /// </summary>
    internal class GetHealthCheckResultUnmarshaller : IUnmarshaller<GetHealthCheckResult, XmlUnmarshallerContext>, IUnmarshaller<GetHealthCheckResult, JsonUnmarshallerContext> 
    {
        public GetHealthCheckResult Unmarshall(XmlUnmarshallerContext context) 
        {
            GetHealthCheckResult getHealthCheckResult = new GetHealthCheckResult();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("HealthCheck", targetDepth))
                    {
                        getHealthCheckResult.HealthCheck = HealthCheckUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return getHealthCheckResult;
                }
            }
                        


            return getHealthCheckResult;
        }

        public GetHealthCheckResult Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static GetHealthCheckResultUnmarshaller instance;

        public static GetHealthCheckResultUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new GetHealthCheckResultUnmarshaller();

            return instance;
        }
    }
}
    
