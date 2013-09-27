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

using Amazon.RDS.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.RDS.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   DescribeDBParametersResult Unmarshaller
     /// </summary>
    internal class DescribeDBParametersResultUnmarshaller : IUnmarshaller<DescribeDBParametersResult, XmlUnmarshallerContext>, IUnmarshaller<DescribeDBParametersResult, JsonUnmarshallerContext> 
    {
        public DescribeDBParametersResult Unmarshall(XmlUnmarshallerContext context) 
        {
            DescribeDBParametersResult describeDBParametersResult = new DescribeDBParametersResult();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("Parameters/Parameter", targetDepth))
                    {
                        describeDBParametersResult.Parameters.Add(ParameterUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    } 
                    if (context.TestExpression("Marker", targetDepth))
                    {
                        describeDBParametersResult.Marker = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return describeDBParametersResult;
                }
            }
                        


            return describeDBParametersResult;
        }

        public DescribeDBParametersResult Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static DescribeDBParametersResultUnmarshaller instance;

        public static DescribeDBParametersResultUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new DescribeDBParametersResultUnmarshaller();

            return instance;
        }
    }
}
    
