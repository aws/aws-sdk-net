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
      /// OfferingUnmarshaller 
      /// </summary> 
      internal class OfferingUnmarshaller : IUnmarshaller<Offering, XmlUnmarshallerContext>, IUnmarshaller<Offering, JsonUnmarshallerContext> 
      { 
        Offering IUnmarshaller<Offering, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }
        
        public Offering Unmarshall(JsonUnmarshallerContext context) 
        {
            Offering offering = new Offering();
          offering.ConnectionCosts = null; 
                                  
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
                offering.OfferingId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("Region", targetDepth)) 
              {
                offering.Region = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("Location", targetDepth)) 
              {
                offering.Location = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("OfferingName", targetDepth)) 
              {
                offering.OfferingName = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("Description", targetDepth)) 
              {
                offering.Description = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("Bandwidth", targetDepth)) 
              {
                offering.Bandwidth = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("ConnectionCosts", targetDepth)) 
              {
                offering.ConnectionCosts = new List<ConnectionCost>();
                        ConnectionCostUnmarshaller unmarshaller = ConnectionCostUnmarshaller.GetInstance();
                while (context.Read())
                {
                  if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                  {
                     offering.ConnectionCosts.Add(unmarshaller.Unmarshall(context));
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
                    return offering; 
                } 
            } 
          
          
            return offering; 
        } 
        
        private static OfferingUnmarshaller instance; 
        public static OfferingUnmarshaller GetInstance() 
        { 
            if (instance == null) 
                instance = new OfferingUnmarshaller(); 
            return instance;
        } 
    } 
} 
  
