/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
      /// InterconnectUnmarshaller
      /// </summary>
      internal class InterconnectUnmarshaller : IUnmarshaller<Interconnect, XmlUnmarshallerContext>, IUnmarshaller<Interconnect, JsonUnmarshallerContext>
      {
        Interconnect IUnmarshaller<Interconnect, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public Interconnect Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) return null;
            Interconnect interconnect = new Interconnect();
        
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
              
              if (context.TestExpression("interconnectId", targetDepth))
              {
                interconnect.InterconnectId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("interconnectName", targetDepth))
              {
                interconnect.InterconnectName = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("interconnectState", targetDepth))
              {
                interconnect.InterconnectState = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("region", targetDepth))
              {
                interconnect.Region = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("location", targetDepth))
              {
                interconnect.Location = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("bandwidth", targetDepth))
              {
                interconnect.Bandwidth = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
            }
          
            return interconnect;
        }

        private static InterconnectUnmarshaller instance;
        public static InterconnectUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new InterconnectUnmarshaller();
            return instance;
        }
    }
}
  
