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
      /// DescribeDeploymentsResultUnmarshaller
      /// </summary>
      internal class DescribeDeploymentsResultUnmarshaller : IUnmarshaller<DescribeDeploymentsResult, XmlUnmarshallerContext>, IUnmarshaller<DescribeDeploymentsResult, JsonUnmarshallerContext>
      {
        DescribeDeploymentsResult IUnmarshaller<DescribeDeploymentsResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public DescribeDeploymentsResult Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonUnmarshallerContext.TokenType.Null)
                return null;
            DescribeDeploymentsResult describeDeploymentsResult = new DescribeDeploymentsResult();
          describeDeploymentsResult.Deployments = null;
                        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
              
              if (context.TestExpression("Deployments", targetDepth))
              {
                describeDeploymentsResult.Deployments = new List<Deployment>();
                        DeploymentUnmarshaller unmarshaller = DeploymentUnmarshaller.GetInstance();
                while (context.Read())
                {
                  if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                  {
                     describeDeploymentsResult.Deployments.Add(unmarshaller.Unmarshall(context));
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
                    return describeDeploymentsResult;
                }
            }
          

            return describeDeploymentsResult;
        }

        private static DescribeDeploymentsResultUnmarshaller instance;
        public static DescribeDeploymentsResultUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new DescribeDeploymentsResultUnmarshaller();
            return instance;
        }
    }
}
  
