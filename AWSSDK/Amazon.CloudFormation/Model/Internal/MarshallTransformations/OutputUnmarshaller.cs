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

using Amazon.CloudFormation.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CloudFormation.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   Output Unmarshaller
     /// </summary>
    internal class OutputUnmarshaller : IUnmarshaller<Output, XmlUnmarshallerContext>, IUnmarshaller<Output, JsonUnmarshallerContext> 
    {
        public Output Unmarshall(XmlUnmarshallerContext context) 
        {
            Output output = new Output();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("OutputKey", targetDepth))
                    {
                        output.OutputKey = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("OutputValue", targetDepth))
                    {
                        output.OutputValue = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Description", targetDepth))
                    {
                        output.Description = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return output;
                }
            }
                        


            return output;
        }

        public Output Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static OutputUnmarshaller instance;

        public static OutputUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new OutputUnmarshaller();

            return instance;
        }
    }
}
    
