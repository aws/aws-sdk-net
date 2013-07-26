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

using Amazon.ElasticBeanstalk.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ElasticBeanstalk.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   EnvironmentInfoDescription Unmarshaller
     /// </summary>
    internal class EnvironmentInfoDescriptionUnmarshaller : IUnmarshaller<EnvironmentInfoDescription, XmlUnmarshallerContext>, IUnmarshaller<EnvironmentInfoDescription, JsonUnmarshallerContext> 
    {
        public EnvironmentInfoDescription Unmarshall(XmlUnmarshallerContext context) 
        {
            EnvironmentInfoDescription environmentInfoDescription = new EnvironmentInfoDescription();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("InfoType", targetDepth))
                    {
                        environmentInfoDescription.InfoType = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Ec2InstanceId", targetDepth))
                    {
                        environmentInfoDescription.Ec2InstanceId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("SampleTimestamp", targetDepth))
                    {
                        environmentInfoDescription.SampleTimestamp = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Message", targetDepth))
                    {
                        environmentInfoDescription.Message = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return environmentInfoDescription;
                }
            }
                        


            return environmentInfoDescription;
        }

        public EnvironmentInfoDescription Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static EnvironmentInfoDescriptionUnmarshaller instance;

        public static EnvironmentInfoDescriptionUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new EnvironmentInfoDescriptionUnmarshaller();

            return instance;
        }
    }
}
    
