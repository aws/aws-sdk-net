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
    using ThirdParty.Json.LitJson;
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
            if (context.CurrentTokenType == JsonToken.Null)
                return null;

            Offering offering = new Offering();

        
        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("offeringId", targetDepth))
              {
                context.Read();
                offering.OfferingId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("region", targetDepth))
              {
                context.Read();
                offering.Region = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("location", targetDepth))
              {
                context.Read();
                offering.Location = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("offeringName", targetDepth))
              {
                context.Read();
                offering.OfferingName = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("description", targetDepth))
              {
                context.Read();
                offering.Description = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("bandwidth", targetDepth))
              {
                context.Read();
                offering.Bandwidth = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("connectionCosts", targetDepth))
              {
                context.Read();
                offering.ConnectionCosts = new List<ConnectionCost>();
                        ConnectionCostUnmarshaller unmarshaller = ConnectionCostUnmarshaller.GetInstance();
                while (context.Read())
                {
                  JsonToken token = context.CurrentTokenType;                
                  if (token == JsonToken.ArrayStart)
                  {
                    continue;
                  }
                  if (token == JsonToken.ArrayEnd)
                  {
                    break;
                  }
                   offering.ConnectionCosts.Add(unmarshaller.Unmarshall(context));
                }
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
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
  
