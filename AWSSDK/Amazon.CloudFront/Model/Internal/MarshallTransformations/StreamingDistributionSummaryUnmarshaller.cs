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
     ///   StreamingDistributionSummary Unmarshaller
     /// </summary>
    internal class StreamingDistributionSummaryUnmarshaller : IUnmarshaller<StreamingDistributionSummary, XmlUnmarshallerContext>, IUnmarshaller<StreamingDistributionSummary, JsonUnmarshallerContext> 
    {
        public StreamingDistributionSummary Unmarshall(XmlUnmarshallerContext context) 
        {
            StreamingDistributionSummary streamingDistributionSummary = new StreamingDistributionSummary();
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
                        streamingDistributionSummary.Id = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Status", targetDepth))
                    {
                        streamingDistributionSummary.Status = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("LastModifiedTime", targetDepth))
                    {
                        streamingDistributionSummary.LastModifiedTime = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("DomainName", targetDepth))
                    {
                        streamingDistributionSummary.DomainName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("S3Origin", targetDepth))
                    {
                        streamingDistributionSummary.S3Origin = S3OriginUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Aliases", targetDepth))
                    {
                        streamingDistributionSummary.Aliases = AliasesUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("TrustedSigners", targetDepth))
                    {
                        streamingDistributionSummary.TrustedSigners = TrustedSignersUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Comment", targetDepth))
                    {
                        streamingDistributionSummary.Comment = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("PriceClass", targetDepth))
                    {
                        streamingDistributionSummary.PriceClass = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Enabled", targetDepth))
                    {
                        streamingDistributionSummary.Enabled = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return streamingDistributionSummary;
                }
            }
                        


            return streamingDistributionSummary;
        }

        public StreamingDistributionSummary Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static StreamingDistributionSummaryUnmarshaller instance;

        public static StreamingDistributionSummaryUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new StreamingDistributionSummaryUnmarshaller();

            return instance;
        }
    }
}
    
