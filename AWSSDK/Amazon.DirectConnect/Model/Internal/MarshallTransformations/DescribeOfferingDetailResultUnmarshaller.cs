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
      /// DescribeOfferingDetailResultUnmarshaller 
      /// </summary> 
      internal class DescribeOfferingDetailResultUnmarshaller : IUnmarshaller<DescribeOfferingDetailResult, XmlUnmarshallerContext>, IUnmarshaller<DescribeOfferingDetailResult, JsonUnmarshallerContext> 
      { 
        DescribeOfferingDetailResult IUnmarshaller<DescribeOfferingDetailResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }
        
        public DescribeOfferingDetailResult Unmarshall(JsonUnmarshallerContext context) 
        {
            DescribeOfferingDetailResult describeOfferingDetailResult = new DescribeOfferingDetailResult();
          describeOfferingDetailResult.ConnectionCosts = null; 
                        describeOfferingDetailResult.OrderSteps = null; 
                                  
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
               
              if (context.TestExpression("OfferingId", targetDepth)) 
              {
                describeOfferingDetailResult.OfferingId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("Region", targetDepth)) 
              {
                describeOfferingDetailResult.Region = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("Location", targetDepth)) 
              {
                describeOfferingDetailResult.Location = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("OfferingName", targetDepth)) 
              {
                describeOfferingDetailResult.OfferingName = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("Description", targetDepth)) 
              {
                describeOfferingDetailResult.Description = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("Bandwidth", targetDepth)) 
              {
                describeOfferingDetailResult.Bandwidth = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("ConnectionCosts", targetDepth)) 
              {
                describeOfferingDetailResult.ConnectionCosts = new List<ConnectionCost>();
                        ConnectionCostUnmarshaller unmarshaller = ConnectionCostUnmarshaller.GetInstance();
                while (context.Read())
                {
                  if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                  {
                     describeOfferingDetailResult.ConnectionCosts.Add(unmarshaller.Unmarshall(context));
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
                describeOfferingDetailResult.OrderSteps = new List<OfferingOrderStep>();
                        OfferingOrderStepUnmarshaller unmarshaller = OfferingOrderStepUnmarshaller.GetInstance();
                while (context.Read())
                {
                  if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                  {
                     describeOfferingDetailResult.OrderSteps.Add(unmarshaller.Unmarshall(context));
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
                    return describeOfferingDetailResult; 
                } 
            } 
          
          
            return describeOfferingDetailResult; 
        } 
        
        private static DescribeOfferingDetailResultUnmarshaller instance; 
        public static DescribeOfferingDetailResultUnmarshaller GetInstance() 
        { 
            if (instance == null) 
                instance = new DescribeOfferingDetailResultUnmarshaller(); 
            return instance;
        } 
    } 
} 
  
