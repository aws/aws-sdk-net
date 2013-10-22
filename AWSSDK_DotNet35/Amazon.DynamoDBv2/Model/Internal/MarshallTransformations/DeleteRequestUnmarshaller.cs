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
    using Amazon.DynamoDBv2.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.DynamoDBv2.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// DeleteRequestUnmarshaller
      /// </summary>
      internal class DeleteRequestUnmarshaller : IUnmarshaller<DeleteRequest, XmlUnmarshallerContext>, IUnmarshaller<DeleteRequest, JsonUnmarshallerContext>
      {
        DeleteRequest IUnmarshaller<DeleteRequest, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public DeleteRequest Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonToken.Null)
                return null;

            DeleteRequest deleteRequest = new DeleteRequest();

        
        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("Key", targetDepth))
              {
                context.Read();
                deleteRequest.Key = new Dictionary<String,AttributeValue>();
                KeyValueUnmarshaller<string, AttributeValue, StringUnmarshaller, AttributeValueUnmarshaller> unmarshaller = new KeyValueUnmarshaller<string, AttributeValue, StringUnmarshaller, AttributeValueUnmarshaller>(StringUnmarshaller.GetInstance(), AttributeValueUnmarshaller.GetInstance());
                while (context.Read())
                {
                  JsonToken token = context.CurrentTokenType;
                  if (token == JsonToken.ArrayStart || token == JsonToken.ObjectStart)
                  {
                      continue;
                  }
                  if (token == JsonToken.ArrayEnd || token == JsonToken.ObjectEnd)
                  {
                      break;
                  }
                  KeyValuePair<string, AttributeValue> kvp = unmarshaller.Unmarshall(context);
                    deleteRequest.Key.Add(kvp.Key, kvp.Value);
                }
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
                {
                    return deleteRequest;
                }
            }
          

            return deleteRequest;
        }

        private static DeleteRequestUnmarshaller instance;
        public static DeleteRequestUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new DeleteRequestUnmarshaller();
            return instance;
        }
    }
}
  
