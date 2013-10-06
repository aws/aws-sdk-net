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
     ///   DistributionConfig Unmarshaller
     /// </summary>
    internal class DistributionConfigUnmarshaller : IUnmarshaller<DistributionConfig, XmlUnmarshallerContext>, IUnmarshaller<DistributionConfig, JsonUnmarshallerContext> 
    {
        public DistributionConfig Unmarshall(XmlUnmarshallerContext context) 
        {
            DistributionConfig distributionConfig = new DistributionConfig();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("CallerReference", targetDepth))
                    {
                        distributionConfig.CallerReference = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Aliases", targetDepth))
                    {
                        distributionConfig.Aliases = AliasesUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("DefaultRootObject", targetDepth))
                    {
                        distributionConfig.DefaultRootObject = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Origins", targetDepth))
                    {
                        distributionConfig.Origins = OriginsUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("DefaultCacheBehavior", targetDepth))
                    {
                        distributionConfig.DefaultCacheBehavior = DefaultCacheBehaviorUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("CacheBehaviors", targetDepth))
                    {
                        distributionConfig.CacheBehaviors = CacheBehaviorsUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("CustomErrorResponses", targetDepth))
                    {
                        distributionConfig.CustomErrorResponses = CustomErrorResponsesUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Comment", targetDepth))
                    {
                        distributionConfig.Comment = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Logging", targetDepth))
                    {
                        distributionConfig.Logging = LoggingConfigUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("PriceClass", targetDepth))
                    {
                        distributionConfig.PriceClass = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Enabled", targetDepth))
                    {
                        distributionConfig.Enabled = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("ViewerCertificate", targetDepth))
                    {
                        distributionConfig.ViewerCertificate = ViewerCertificateUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return distributionConfig;
                }
            }
                        


            return distributionConfig;
        }

        public DistributionConfig Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static DistributionConfigUnmarshaller instance;

        public static DistributionConfigUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new DistributionConfigUnmarshaller();

            return instance;
        }
    }
}
    
