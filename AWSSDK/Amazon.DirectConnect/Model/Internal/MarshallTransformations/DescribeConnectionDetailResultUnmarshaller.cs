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
    using Amazon.DirectConnect.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.DirectConnect.Model.Internal.MarshallTransformations 
    { 
      /// <summary> 
      /// DescribeConnectionDetailResultUnmarshaller 
      /// </summary> 
      internal class DescribeConnectionDetailResultUnmarshaller : IUnmarshaller<DescribeConnectionDetailResult, XmlUnmarshallerContext>, IUnmarshaller<DescribeConnectionDetailResult, JsonUnmarshallerContext> 
      { 
        DescribeConnectionDetailResult IUnmarshaller<DescribeConnectionDetailResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }
        
        public DescribeConnectionDetailResult Unmarshall(JsonUnmarshallerContext context) 
        {
            DescribeConnectionDetailResult describeConnectionDetailResult = new DescribeConnectionDetailResult();
          describeConnectionDetailResult.ConnectionCosts = null; 
                        describeConnectionDetailResult.OrderSteps = null; 
                                  
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
               
              if (context.TestExpression("ConnectionId", targetDepth)) 
              {
                describeConnectionDetailResult.ConnectionId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("ConnectionName", targetDepth)) 
              {
                describeConnectionDetailResult.ConnectionName = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("ConnectionState", targetDepth)) 
              {
                describeConnectionDetailResult.ConnectionState = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("Region", targetDepth)) 
              {
                describeConnectionDetailResult.Region = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("Location", targetDepth)) 
              {
                describeConnectionDetailResult.Location = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("Bandwidth", targetDepth)) 
              {
                describeConnectionDetailResult.Bandwidth = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("ConnectionCosts", targetDepth)) 
              {
                describeConnectionDetailResult.ConnectionCosts = new List<ConnectionCost>();
                        ConnectionCostUnmarshaller unmarshaller = ConnectionCostUnmarshaller.GetInstance();
                while (context.Read())
                {
                  if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                  {
                     describeConnectionDetailResult.ConnectionCosts.Add(unmarshaller.Unmarshall(context));
                  }
                  else if (context.IsEndArray)
                  {
                    break;
                  }
                }
                continue; 
              }
   
              if (context.TestExpression("OrderSteps", targetDepth)) 
              {
                describeConnectionDetailResult.OrderSteps = new List<ConnectionOrderStep>();
                        ConnectionOrderStepUnmarshaller unmarshaller = ConnectionOrderStepUnmarshaller.GetInstance();
                while (context.Read())
                {
                  if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                  {
                     describeConnectionDetailResult.OrderSteps.Add(unmarshaller.Unmarshall(context));
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
                    return describeConnectionDetailResult; 
                } 
            } 
          
          
            return describeConnectionDetailResult; 
        } 
        
        private static DescribeConnectionDetailResultUnmarshaller instance; 
        public static DescribeConnectionDetailResultUnmarshaller GetInstance() 
        { 
            if (instance == null) 
                instance = new DescribeConnectionDetailResultUnmarshaller(); 
            return instance;
        } 
    } 
} 
  
