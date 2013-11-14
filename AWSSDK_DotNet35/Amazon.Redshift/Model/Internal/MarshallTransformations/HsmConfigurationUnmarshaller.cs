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

using Amazon.Redshift.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Redshift.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   HsmConfiguration Unmarshaller
     /// </summary>
    internal class HsmConfigurationUnmarshaller : IUnmarshaller<HsmConfiguration, XmlUnmarshallerContext>, IUnmarshaller<HsmConfiguration, JsonUnmarshallerContext> 
    {
        public HsmConfiguration Unmarshall(XmlUnmarshallerContext context) 
        {
            HsmConfiguration hsmConfiguration = new HsmConfiguration();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            if (context.IsStartOfDocument) 
               targetDepth++;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("HsmConfigurationIdentifier", targetDepth))
                    {
                        hsmConfiguration.HsmConfigurationIdentifier = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Description", targetDepth))
                    {
                        hsmConfiguration.Description = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("HsmIpAddress", targetDepth))
                    {
                        hsmConfiguration.HsmIpAddress = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("HsmPartitionName", targetDepth))
                    {
                        hsmConfiguration.HsmPartitionName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return hsmConfiguration;
                }
            }
                        


            return hsmConfiguration;
        }

        public HsmConfiguration Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static HsmConfigurationUnmarshaller instance;

        public static HsmConfigurationUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new HsmConfigurationUnmarshaller();

            return instance;
        }
    }
}
    
