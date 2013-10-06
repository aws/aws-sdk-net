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
     ///   ListHealthChecksResult Unmarshaller
     /// </summary>
    internal class ListHealthChecksResultUnmarshaller : IUnmarshaller<ListHealthChecksResult, XmlUnmarshallerContext>, IUnmarshaller<ListHealthChecksResult, JsonUnmarshallerContext> 
    {
        public ListHealthChecksResult Unmarshall(XmlUnmarshallerContext context) 
        {
            ListHealthChecksResult listHealthChecksResult = new ListHealthChecksResult();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("HealthChecks/HealthCheck", targetDepth))
                    {
                        listHealthChecksResult.HealthChecks.Add(HealthCheckUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    } 
                    if (context.TestExpression("Marker", targetDepth))
                    {
                        listHealthChecksResult.Marker = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("IsTruncated", targetDepth))
                    {
                        listHealthChecksResult.IsTruncated = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("NextMarker", targetDepth))
                    {
                        listHealthChecksResult.NextMarker = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("MaxItems", targetDepth))
                    {
                        listHealthChecksResult.MaxItems = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return listHealthChecksResult;
                }
            }
                        


            return listHealthChecksResult;
        }

        public ListHealthChecksResult Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static ListHealthChecksResultUnmarshaller instance;

        public static ListHealthChecksResultUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new ListHealthChecksResultUnmarshaller();

            return instance;
        }
    }
}
    
