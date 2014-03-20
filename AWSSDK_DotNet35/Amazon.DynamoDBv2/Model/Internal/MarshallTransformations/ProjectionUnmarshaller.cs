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
      /// ProjectionUnmarshaller
      /// </summary>
      internal class ProjectionUnmarshaller : IUnmarshaller<Projection, XmlUnmarshallerContext>, IUnmarshaller<Projection, JsonUnmarshallerContext>
      {
        Projection IUnmarshaller<Projection, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public Projection Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) return null;
            Projection projection = new Projection();
        
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
              
              if (context.TestExpression("ProjectionType", targetDepth))
              {
                projection.ProjectionType = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("NonKeyAttributes", targetDepth))
              {
                
                var unmarshaller = new ListUnmarshaller<String,StringUnmarshaller>(
                    StringUnmarshaller.GetInstance());                  
                projection.NonKeyAttributes = unmarshaller.Unmarshall(context);
                
                continue;
              }
  
            }
          
            return projection;
        }

        private static ProjectionUnmarshaller instance;
        public static ProjectionUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new ProjectionUnmarshaller();
            return instance;
        }
    }
}
  
