/*
 * Copyright 2010-2018 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.S3.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
     /// <summary>
     /// PublicAccessBlockConfiguration Unmarshaller
     /// </summary>
    public class PublicAccessBlockConfigurationUnmarshaller : IUnmarshaller<PublicAccessBlockConfiguration, XmlUnmarshallerContext>, IUnmarshaller<PublicAccessBlockConfiguration, JsonUnmarshallerContext> 
    {
        public PublicAccessBlockConfiguration Unmarshall(XmlUnmarshallerContext context) 
        {
            PublicAccessBlockConfiguration publicAccessBlockConfiguration = new PublicAccessBlockConfiguration();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("BlockPublicAcls", targetDepth))
                    {
                        publicAccessBlockConfiguration.BlockPublicAcls = BoolUnmarshaller.GetInstance().Unmarshall(context);                            
                        continue;
                    }                    
                    else if (context.TestExpression("IgnorePublicAcls", targetDepth))
                    {
                        publicAccessBlockConfiguration.IgnorePublicAcls = BoolUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    else if (context.TestExpression("BlockPublicPolicy", targetDepth))
                    {
                        publicAccessBlockConfiguration.BlockPublicPolicy = BoolUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    else if (context.TestExpression("RestrictPublicBuckets", targetDepth))
                    {
                        publicAccessBlockConfiguration.RestrictPublicBuckets = BoolUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return publicAccessBlockConfiguration;
                }
            }

            return publicAccessBlockConfiguration;
        }

        public PublicAccessBlockConfiguration Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static PublicAccessBlockConfigurationUnmarshaller _instance;

        public static PublicAccessBlockConfigurationUnmarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PublicAccessBlockConfigurationUnmarshaller();
                }
                return _instance;
            }
        }

    }
}
    
