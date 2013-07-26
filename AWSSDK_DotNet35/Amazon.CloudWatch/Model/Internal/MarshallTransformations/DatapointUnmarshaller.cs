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

using Amazon.CloudWatch.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CloudWatch.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   Datapoint Unmarshaller
     /// </summary>
    internal class DatapointUnmarshaller : IUnmarshaller<Datapoint, XmlUnmarshallerContext>, IUnmarshaller<Datapoint, JsonUnmarshallerContext> 
    {
        public Datapoint Unmarshall(XmlUnmarshallerContext context) 
        {
            Datapoint datapoint = new Datapoint();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Timestamp", targetDepth))
                    {
                        datapoint.Timestamp = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("SampleCount", targetDepth))
                    {
                        datapoint.SampleCount = DoubleUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Average", targetDepth))
                    {
                        datapoint.Average = DoubleUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Sum", targetDepth))
                    {
                        datapoint.Sum = DoubleUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Minimum", targetDepth))
                    {
                        datapoint.Minimum = DoubleUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Maximum", targetDepth))
                    {
                        datapoint.Maximum = DoubleUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Unit", targetDepth))
                    {
                        datapoint.Unit = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return datapoint;
                }
            }
                        


            return datapoint;
        }

        public Datapoint Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static DatapointUnmarshaller instance;

        public static DatapointUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new DatapointUnmarshaller();

            return instance;
        }
    }
}
    
