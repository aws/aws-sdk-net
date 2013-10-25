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
      /// CreateInterconnectResultUnmarshaller
      /// </summary>
      internal class CreateInterconnectResultUnmarshaller : IUnmarshaller<CreateInterconnectResult, XmlUnmarshallerContext>, IUnmarshaller<CreateInterconnectResult, JsonUnmarshallerContext>
      {
        CreateInterconnectResult IUnmarshaller<CreateInterconnectResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public CreateInterconnectResult Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonUnmarshallerContext.TokenType.Null)
                return null;
            CreateInterconnectResult createInterconnectResult = new CreateInterconnectResult();
          
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
              
              if (context.TestExpression("InterconnectId", targetDepth))
              {
                createInterconnectResult.InterconnectId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("InterconnectName", targetDepth))
              {
                createInterconnectResult.InterconnectName = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("InterconnectState", targetDepth))
              {
                createInterconnectResult.InterconnectState = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Region", targetDepth))
              {
                createInterconnectResult.Region = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Location", targetDepth))
              {
                createInterconnectResult.Location = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Bandwidth", targetDepth))
              {
                createInterconnectResult.Bandwidth = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                }
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth)
                {
                    return createInterconnectResult;
                }
            }
          

            return createInterconnectResult;
        }

        private static CreateInterconnectResultUnmarshaller instance;
        public static CreateInterconnectResultUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new CreateInterconnectResultUnmarshaller();
            return instance;
        }
    }
}
  
