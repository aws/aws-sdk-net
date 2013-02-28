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
     ///   ListHostedZonesResult Unmarshaller
     /// </summary>
    internal class ListHostedZonesResultUnmarshaller : IUnmarshaller<ListHostedZonesResult, XmlUnmarshallerContext>, IUnmarshaller<ListHostedZonesResult, JsonUnmarshallerContext> 
    {
        public ListHostedZonesResult Unmarshall(XmlUnmarshallerContext context) 
        {
            ListHostedZonesResult listHostedZonesResult = new ListHostedZonesResult();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("HostedZones/HostedZone", targetDepth))
                    {
                        listHostedZonesResult.HostedZones.Add(HostedZoneUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    } 
                    if (context.TestExpression("Marker", targetDepth))
                    {
                        listHostedZonesResult.Marker = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("IsTruncated", targetDepth))
                    {
                        listHostedZonesResult.IsTruncated = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("NextMarker", targetDepth))
                    {
                        listHostedZonesResult.NextMarker = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("MaxItems", targetDepth))
                    {
                        listHostedZonesResult.MaxItems = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return listHostedZonesResult;
                }
            }
                        


            return listHostedZonesResult;
        }

        public ListHostedZonesResult Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static ListHostedZonesResultUnmarshaller instance;

        public static ListHostedZonesResultUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new ListHostedZonesResultUnmarshaller();

            return instance;
        }
    }
}
    
