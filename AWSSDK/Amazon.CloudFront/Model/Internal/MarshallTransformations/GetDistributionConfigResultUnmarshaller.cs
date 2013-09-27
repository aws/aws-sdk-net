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
     ///   GetDistributionConfigResult Unmarshaller
     /// </summary>
    internal class GetDistributionConfigResultUnmarshaller : IUnmarshaller<GetDistributionConfigResult, XmlUnmarshallerContext>, IUnmarshaller<GetDistributionConfigResult, JsonUnmarshallerContext> 
    {
        public GetDistributionConfigResult Unmarshall(XmlUnmarshallerContext context) 
        {
            GetDistributionConfigResult getDistributionConfigResult = new GetDistributionConfigResult();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("DistributionConfig", targetDepth))
                    {
                        getDistributionConfigResult.DistributionConfig = DistributionConfigUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return getDistributionConfigResult;
                }
            }
            

            getDistributionConfigResult.ETag = context.Headers["ETag"];         


            return getDistributionConfigResult;
        }

        public GetDistributionConfigResult Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static GetDistributionConfigResultUnmarshaller instance;

        public static GetDistributionConfigResultUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new GetDistributionConfigResultUnmarshaller();

            return instance;
        }
    }
}
    
