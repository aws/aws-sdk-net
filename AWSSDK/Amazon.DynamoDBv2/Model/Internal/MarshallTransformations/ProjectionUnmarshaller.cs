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
            Projection projection = new Projection();
          projection.NonKeyAttributes = null;
                        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
              
              if (context.TestExpression("ProjectionType", targetDepth))
              {
                projection.ProjectionType = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("NonKeyAttributes", targetDepth))
              {
                projection.NonKeyAttributes = new List<String>();
                        StringUnmarshaller unmarshaller = StringUnmarshaller.GetInstance();
                while (context.Read())
                {
                  if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                  {
                     projection.NonKeyAttributes.Add(unmarshaller.Unmarshall(context));
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
                    return projection;
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
  
