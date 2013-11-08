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
     ///   DistributionSummary Unmarshaller
     /// </summary>
    internal class DistributionSummaryUnmarshaller : IUnmarshaller<DistributionSummary, XmlUnmarshallerContext>, IUnmarshaller<DistributionSummary, JsonUnmarshallerContext> 
    {
        public DistributionSummary Unmarshall(XmlUnmarshallerContext context) 
        {
            DistributionSummary distributionSummary = new DistributionSummary();
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
                        distributionSummary.Id = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Status", targetDepth))
                    {
                        distributionSummary.Status = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("LastModifiedTime", targetDepth))
                    {
                        distributionSummary.LastModifiedTime = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("DomainName", targetDepth))
                    {
                        distributionSummary.DomainName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Aliases", targetDepth))
                    {
                        distributionSummary.Aliases = AliasesUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Origins", targetDepth))
                    {
                        distributionSummary.Origins = OriginsUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("DefaultCacheBehavior", targetDepth))
                    {
                        distributionSummary.DefaultCacheBehavior = DefaultCacheBehaviorUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("CacheBehaviors", targetDepth))
                    {
                        distributionSummary.CacheBehaviors = CacheBehaviorsUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("CustomErrorResponses", targetDepth))
                    {
                        distributionSummary.CustomErrorResponses = CustomErrorResponsesUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Comment", targetDepth))
                    {
                        distributionSummary.Comment = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("PriceClass", targetDepth))
                    {
                        distributionSummary.PriceClass = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Enabled", targetDepth))
                    {
                        distributionSummary.Enabled = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("ViewerCertificate", targetDepth))
                    {
                        distributionSummary.ViewerCertificate = ViewerCertificateUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return distributionSummary;
                }
            }
                        


            return distributionSummary;
        }

        public DistributionSummary Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static DistributionSummaryUnmarshaller instance;

        public static DistributionSummaryUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new DistributionSummaryUnmarshaller();

            return instance;
        }
    }
}
    
