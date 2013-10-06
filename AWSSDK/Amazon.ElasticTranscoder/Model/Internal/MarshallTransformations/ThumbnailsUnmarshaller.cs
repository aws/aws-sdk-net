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
    using Amazon.ElasticTranscoder.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.ElasticTranscoder.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// ThumbnailsUnmarshaller
      /// </summary>
      internal class ThumbnailsUnmarshaller : IUnmarshaller<Thumbnails, XmlUnmarshallerContext>, IUnmarshaller<Thumbnails, JsonUnmarshallerContext>
      {
        Thumbnails IUnmarshaller<Thumbnails, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public Thumbnails Unmarshall(JsonUnmarshallerContext context)
        {
            Thumbnails thumbnails = new Thumbnails();
          
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
              
              if (context.TestExpression("Format", targetDepth))
              {
                thumbnails.Format = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Interval", targetDepth))
              {
                thumbnails.Interval = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Resolution", targetDepth))
              {
                thumbnails.Resolution = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("AspectRatio", targetDepth))
              {
                thumbnails.AspectRatio = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("MaxWidth", targetDepth))
              {
                thumbnails.MaxWidth = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("MaxHeight", targetDepth))
              {
                thumbnails.MaxHeight = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("SizingPolicy", targetDepth))
              {
                thumbnails.SizingPolicy = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("PaddingPolicy", targetDepth))
              {
                thumbnails.PaddingPolicy = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                }
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth)
                {
                    return thumbnails;
                }
            }
          

            return thumbnails;
        }

        private static ThumbnailsUnmarshaller instance;
        public static ThumbnailsUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new ThumbnailsUnmarshaller();
            return instance;
        }
    }
}
  
