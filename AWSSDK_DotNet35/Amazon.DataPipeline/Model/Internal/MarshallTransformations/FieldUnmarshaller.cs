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
    using Amazon.DataPipeline.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.DataPipeline.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// FieldUnmarshaller
      /// </summary>
      internal class FieldUnmarshaller : IUnmarshaller<Field, XmlUnmarshallerContext>, IUnmarshaller<Field, JsonUnmarshallerContext>
      {
        Field IUnmarshaller<Field, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public Field Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) return null;
            Field field = new Field();
        
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
              
              if (context.TestExpression("key", targetDepth))
              {
                field.Key = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("stringValue", targetDepth))
              {
                field.StringValue = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("refValue", targetDepth))
              {
                field.RefValue = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
            }
          
            return field;
        }

        private static FieldUnmarshaller instance;
        public static FieldUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new FieldUnmarshaller();
            return instance;
        }
    }
}
  
