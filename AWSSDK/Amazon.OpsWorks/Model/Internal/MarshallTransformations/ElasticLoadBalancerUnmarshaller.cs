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
      /// ElasticLoadBalancerUnmarshaller
      /// </summary>
      internal class ElasticLoadBalancerUnmarshaller : IUnmarshaller<ElasticLoadBalancer, XmlUnmarshallerContext>, IUnmarshaller<ElasticLoadBalancer, JsonUnmarshallerContext>
      {
        ElasticLoadBalancer IUnmarshaller<ElasticLoadBalancer, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public ElasticLoadBalancer Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonUnmarshallerContext.TokenType.Null)
                return null;
            ElasticLoadBalancer elasticLoadBalancer = new ElasticLoadBalancer();
          elasticLoadBalancer.AvailabilityZones = null;
                        elasticLoadBalancer.SubnetIds = null;
                        elasticLoadBalancer.Ec2InstanceIds = null;
                        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
              
              if (context.TestExpression("ElasticLoadBalancerName", targetDepth))
              {
                elasticLoadBalancer.ElasticLoadBalancerName = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Region", targetDepth))
              {
                elasticLoadBalancer.Region = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("DnsName", targetDepth))
              {
                elasticLoadBalancer.DnsName = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("StackId", targetDepth))
              {
                elasticLoadBalancer.StackId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("LayerId", targetDepth))
              {
                elasticLoadBalancer.LayerId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("VpcId", targetDepth))
              {
                elasticLoadBalancer.VpcId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("AvailabilityZones", targetDepth))
              {
                elasticLoadBalancer.AvailabilityZones = new List<String>();
                        StringUnmarshaller unmarshaller = StringUnmarshaller.GetInstance();
                while (context.Read())
                {
                  if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                  {
                     elasticLoadBalancer.AvailabilityZones.Add(unmarshaller.Unmarshall(context));
                  }
                  else if (context.IsEndArray)
                  {
                    break;
                  }
                }
                continue;
              }
  
              if (context.TestExpression("SubnetIds", targetDepth))
              {
                elasticLoadBalancer.SubnetIds = new List<String>();
                        StringUnmarshaller unmarshaller = StringUnmarshaller.GetInstance();
                while (context.Read())
                {
                  if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                  {
                     elasticLoadBalancer.SubnetIds.Add(unmarshaller.Unmarshall(context));
                  }
                  else if (context.IsEndArray)
                  {
                    break;
                  }
                }
                continue;
              }
  
              if (context.TestExpression("Ec2InstanceIds", targetDepth))
              {
                elasticLoadBalancer.Ec2InstanceIds = new List<String>();
                        StringUnmarshaller unmarshaller = StringUnmarshaller.GetInstance();
                while (context.Read())
                {
                  if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                  {
                     elasticLoadBalancer.Ec2InstanceIds.Add(unmarshaller.Unmarshall(context));
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
                    return elasticLoadBalancer;
                }
            }
          

            return elasticLoadBalancer;
        }

        private static ElasticLoadBalancerUnmarshaller instance;
        public static ElasticLoadBalancerUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new ElasticLoadBalancerUnmarshaller();
            return instance;
        }
    }
}
  
