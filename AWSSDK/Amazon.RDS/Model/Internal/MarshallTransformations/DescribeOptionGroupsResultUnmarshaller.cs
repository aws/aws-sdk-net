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
     ///   DescribeOptionGroupsResult Unmarshaller
     /// </summary>
    internal class DescribeOptionGroupsResultUnmarshaller : IUnmarshaller<DescribeOptionGroupsResult, XmlUnmarshallerContext>, IUnmarshaller<DescribeOptionGroupsResult, JsonUnmarshallerContext> 
    {
        public DescribeOptionGroupsResult Unmarshall(XmlUnmarshallerContext context) 
        {
            DescribeOptionGroupsResult describeOptionGroupsResult = new DescribeOptionGroupsResult();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("OptionGroupsList/OptionGroup", targetDepth))
                    {
                        describeOptionGroupsResult.OptionGroupsList.Add(OptionGroupUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    } 
                    if (context.TestExpression("Marker", targetDepth))
                    {
                        describeOptionGroupsResult.Marker = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return describeOptionGroupsResult;
                }
            }
                        


            return describeOptionGroupsResult;
        }

        public DescribeOptionGroupsResult Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static DescribeOptionGroupsResultUnmarshaller instance;

        public static DescribeOptionGroupsResultUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new DescribeOptionGroupsResultUnmarshaller();

            return instance;
        }
    }
}
    
