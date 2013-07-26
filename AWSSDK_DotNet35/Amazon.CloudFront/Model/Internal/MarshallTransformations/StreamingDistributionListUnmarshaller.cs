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
     ///   StreamingDistributionList Unmarshaller
     /// </summary>
    internal class StreamingDistributionListUnmarshaller : IUnmarshaller<StreamingDistributionList, XmlUnmarshallerContext>, IUnmarshaller<StreamingDistributionList, JsonUnmarshallerContext> 
    {
        public StreamingDistributionList Unmarshall(XmlUnmarshallerContext context) 
        {
            StreamingDistributionList streamingDistributionList = new StreamingDistributionList();
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
                        streamingDistributionList.Marker = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("NextMarker", targetDepth))
                    {
                        streamingDistributionList.NextMarker = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("MaxItems", targetDepth))
                    {
                        streamingDistributionList.MaxItems = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("IsTruncated", targetDepth))
                    {
                        streamingDistributionList.IsTruncated = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Quantity", targetDepth))
                    {
                        streamingDistributionList.Quantity = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Items/StreamingDistributionSummary", targetDepth))
                    {
                        streamingDistributionList.Items.Add(StreamingDistributionSummaryUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return streamingDistributionList;
                }
            }
                        


            return streamingDistributionList;
        }

        public StreamingDistributionList Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static StreamingDistributionListUnmarshaller instance;

        public static StreamingDistributionListUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new StreamingDistributionListUnmarshaller();

            return instance;
        }
    }
}
    
