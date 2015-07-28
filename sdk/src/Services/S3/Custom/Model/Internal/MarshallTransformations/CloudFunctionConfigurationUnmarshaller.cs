/*
 * Copyright 2010-2015 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

#pragma warning disable 1591

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    public class LambdaFunctionConfigurationUnmarshaller : IUnmarshaller<LambdaFunctionConfiguration, XmlUnmarshallerContext>, IUnmarshaller<LambdaFunctionConfiguration, JsonUnmarshallerContext> 
    {
        public LambdaFunctionConfiguration Unmarshall(XmlUnmarshallerContext context)
        {
            LambdaFunctionConfiguration cloudFunctionConfiguration = new LambdaFunctionConfiguration();
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
                        cloudFunctionConfiguration.Id = StringUnmarshaller.GetInstance().Unmarshall(context);

                        continue;
                    }
                    if (context.TestExpression("Event", targetDepth))
                    {
                        cloudFunctionConfiguration.Events.Add(StringUnmarshaller.GetInstance().Unmarshall(context));

                        continue;
                    }
                    if (context.TestExpression("CloudFunction", targetDepth))
                    {
                        cloudFunctionConfiguration.FunctionArn = StringUnmarshaller.GetInstance().Unmarshall(context);

                        continue;
                    }
                    if (context.TestExpression("Filter", targetDepth))
                    {
                        cloudFunctionConfiguration.Filter = FilterUnmarshaller.Instance.Unmarshall(context);

                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return cloudFunctionConfiguration;
                }
            }

            return cloudFunctionConfiguration;
        }

        public LambdaFunctionConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }

        private static LambdaFunctionConfigurationUnmarshaller _instance;

        public static LambdaFunctionConfigurationUnmarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new LambdaFunctionConfigurationUnmarshaller();
                }
                return _instance;
            }
        }
    }
}
