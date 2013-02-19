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
    using System;
    using System.Collections.Generic;
    using System.IO;
    using Amazon.OpsWorks.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.OpsWorks.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// DescribeStacksResultUnmarshaller
      /// </summary>
      internal class DescribeStacksResultUnmarshaller : IUnmarshaller<DescribeStacksResult, XmlUnmarshallerContext>, IUnmarshaller<DescribeStacksResult, JsonUnmarshallerContext>
      {
        DescribeStacksResult IUnmarshaller<DescribeStacksResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public DescribeStacksResult Unmarshall(JsonUnmarshallerContext context)
        {
            DescribeStacksResult describeStacksResult = new DescribeStacksResult();
          describeStacksResult.Stacks = null;
                        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
              
              if (context.TestExpression("Stacks", targetDepth))
              {
                describeStacksResult.Stacks = new List<Stack>();
                        StackUnmarshaller unmarshaller = StackUnmarshaller.GetInstance();
                while (context.Read())
                {
                  if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                  {
                     describeStacksResult.Stacks.Add(unmarshaller.Unmarshall(context));
                  }
                  else if (context.IsEndArray)
                  {
                    break;
                  }
                }
                continue;
              }
  
                }
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth)
                {
                    return describeStacksResult;
                }
            }
          

            return describeStacksResult;
        }

        private static DescribeStacksResultUnmarshaller instance;
        public static DescribeStacksResultUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new DescribeStacksResultUnmarshaller();
            return instance;
        }
    }
}
  
