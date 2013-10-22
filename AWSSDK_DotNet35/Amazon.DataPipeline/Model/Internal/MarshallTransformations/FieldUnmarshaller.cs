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
            if (context.CurrentTokenType == JsonToken.Null)
                return null;

            Field field = new Field();

        
        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("key", targetDepth))
              {
                context.Read();
                field.Key = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("stringValue", targetDepth))
              {
                context.Read();
                field.StringValue = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("refValue", targetDepth))
              {
                context.Read();
                field.RefValue = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
                {
                    return field;
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
  
