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
    using Amazon.DynamoDBv2.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.DynamoDBv2.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// PutRequestUnmarshaller
      /// </summary>
      internal class PutRequestUnmarshaller : IUnmarshaller<PutRequest, XmlUnmarshallerContext>, IUnmarshaller<PutRequest, JsonUnmarshallerContext>
      {
        PutRequest IUnmarshaller<PutRequest, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public PutRequest Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) return null;
            PutRequest putRequest = new PutRequest();
        
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
              
              if (context.TestExpression("Item", targetDepth))
              {
                
                var unmarshaller =  new DictionaryUnmarshaller<String,AttributeValue,StringUnmarshaller,AttributeValueUnmarshaller>(
                    StringUnmarshaller.GetInstance(),AttributeValueUnmarshaller.GetInstance());               
                putRequest.Item = unmarshaller.Unmarshall(context);
                
                continue;
              }
  
            }
          
            return putRequest;
        }

        private static PutRequestUnmarshaller instance;
        public static PutRequestUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new PutRequestUnmarshaller();
            return instance;
        }
    }
}
  
