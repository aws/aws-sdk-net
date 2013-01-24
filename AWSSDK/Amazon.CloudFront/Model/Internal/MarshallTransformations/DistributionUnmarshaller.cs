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

using Amazon.CloudFront.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CloudFront.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   Distribution Unmarshaller
     /// </summary>
    internal class DistributionUnmarshaller : IUnmarshaller<Distribution, XmlUnmarshallerContext>, IUnmarshaller<Distribution, JsonUnmarshallerContext> 
    {
        public Distribution Unmarshall(XmlUnmarshallerContext context) 
        {
            Distribution distribution = new Distribution();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("Id", targetDepth))
                    {
                        distribution.Id = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Status", targetDepth))
                    {
                        distribution.Status = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("LastModifiedTime", targetDepth))
                    {
                        distribution.LastModifiedTime = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("InProgressInvalidationBatches", targetDepth))
                    {
                        distribution.InProgressInvalidationBatches = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("DomainName", targetDepth))
                    {
                        distribution.DomainName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("ActiveTrustedSigners", targetDepth))
                    {
                        distribution.ActiveTrustedSigners = ActiveTrustedSignersUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("DistributionConfig", targetDepth))
                    {
                        distribution.DistributionConfig = DistributionConfigUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return distribution;
                }
            }
                        


            return distribution;
        }

        public Distribution Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static DistributionUnmarshaller instance;

        public static DistributionUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new DistributionUnmarshaller();

            return instance;
        }
    }
}
    
