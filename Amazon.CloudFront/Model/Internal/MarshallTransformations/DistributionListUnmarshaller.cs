/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.CloudFront.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CloudFront.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   DistributionList Unmarshaller
     /// </summary>
    internal class DistributionListUnmarshaller : IUnmarshaller<DistributionList, XmlUnmarshallerContext>, IUnmarshaller<DistributionList, JsonUnmarshallerContext> 
    {
        public DistributionList Unmarshall(XmlUnmarshallerContext context) 
        {
            DistributionList distributionList = new DistributionList();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("Marker", targetDepth))
                    {
                        distributionList.Marker = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("NextMarker", targetDepth))
                    {
                        distributionList.NextMarker = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("MaxItems", targetDepth))
                    {
                        distributionList.MaxItems = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("IsTruncated", targetDepth))
                    {
                        distributionList.IsTruncated = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Quantity", targetDepth))
                    {
                        distributionList.Quantity = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Items/DistributionSummary", targetDepth))
                    {
                        distributionList.Items.Add(DistributionSummaryUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return distributionList;
                }
            }
                        


            return distributionList;
        }

        public DistributionList Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static DistributionListUnmarshaller instance;

        public static DistributionListUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new DistributionListUnmarshaller();

            return instance;
        }
    }
}
    
