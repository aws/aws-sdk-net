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
     ///   StreamingDistributionConfig Unmarshaller
     /// </summary>
    internal class StreamingDistributionConfigUnmarshaller : IUnmarshaller<StreamingDistributionConfig, XmlUnmarshallerContext>, IUnmarshaller<StreamingDistributionConfig, JsonUnmarshallerContext> 
    {
        public StreamingDistributionConfig Unmarshall(XmlUnmarshallerContext context) 
        {
            StreamingDistributionConfig streamingDistributionConfig = new StreamingDistributionConfig();
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
                        streamingDistributionConfig.CallerReference = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("S3Origin", targetDepth))
                    {
                        streamingDistributionConfig.S3Origin = S3OriginUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Aliases", targetDepth))
                    {
                        streamingDistributionConfig.Aliases = AliasesUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Comment", targetDepth))
                    {
                        streamingDistributionConfig.Comment = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Logging", targetDepth))
                    {
                        streamingDistributionConfig.Logging = StreamingLoggingConfigUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("TrustedSigners", targetDepth))
                    {
                        streamingDistributionConfig.TrustedSigners = TrustedSignersUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("PriceClass", targetDepth))
                    {
                        streamingDistributionConfig.PriceClass = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Enabled", targetDepth))
                    {
                        streamingDistributionConfig.Enabled = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return streamingDistributionConfig;
                }
            }
                        


            return streamingDistributionConfig;
        }

        public StreamingDistributionConfig Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static StreamingDistributionConfigUnmarshaller instance;

        public static StreamingDistributionConfigUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new StreamingDistributionConfigUnmarshaller();

            return instance;
        }
    }
}
    
