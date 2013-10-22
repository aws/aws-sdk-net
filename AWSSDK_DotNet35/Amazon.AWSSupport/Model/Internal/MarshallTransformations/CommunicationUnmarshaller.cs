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
    using Amazon.AWSSupport.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.AWSSupport.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// CommunicationUnmarshaller
      /// </summary>
      internal class CommunicationUnmarshaller : IUnmarshaller<Communication, XmlUnmarshallerContext>, IUnmarshaller<Communication, JsonUnmarshallerContext>
      {
        Communication IUnmarshaller<Communication, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public Communication Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonToken.Null)
                return null;

            Communication communication = new Communication();

        
        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("caseId", targetDepth))
              {
                context.Read();
                communication.CaseId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("body", targetDepth))
              {
                context.Read();
                communication.Body = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("submittedBy", targetDepth))
              {
                context.Read();
                communication.SubmittedBy = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("timeCreated", targetDepth))
              {
                context.Read();
                communication.TimeCreated = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
                {
                    return communication;
                }
            }
          

            return communication;
        }

        private static CommunicationUnmarshaller instance;
        public static CommunicationUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new CommunicationUnmarshaller();
            return instance;
        }
    }
}
  
