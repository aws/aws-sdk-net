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
    using Amazon.ElasticTranscoder.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.ElasticTranscoder.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// PresetWatermarkUnmarshaller
      /// </summary>
      internal class PresetWatermarkUnmarshaller : IUnmarshaller<PresetWatermark, XmlUnmarshallerContext>, IUnmarshaller<PresetWatermark, JsonUnmarshallerContext>
      {
        PresetWatermark IUnmarshaller<PresetWatermark, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public PresetWatermark Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonToken.Null)
                return null;

            PresetWatermark presetWatermark = new PresetWatermark();

        
        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("Id", targetDepth))
              {
                context.Read();
                presetWatermark.Id = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("MaxWidth", targetDepth))
              {
                context.Read();
                presetWatermark.MaxWidth = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("MaxHeight", targetDepth))
              {
                context.Read();
                presetWatermark.MaxHeight = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("SizingPolicy", targetDepth))
              {
                context.Read();
                presetWatermark.SizingPolicy = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("HorizontalAlign", targetDepth))
              {
                context.Read();
                presetWatermark.HorizontalAlign = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("HorizontalOffset", targetDepth))
              {
                context.Read();
                presetWatermark.HorizontalOffset = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("VerticalAlign", targetDepth))
              {
                context.Read();
                presetWatermark.VerticalAlign = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("VerticalOffset", targetDepth))
              {
                context.Read();
                presetWatermark.VerticalOffset = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Opacity", targetDepth))
              {
                context.Read();
                presetWatermark.Opacity = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Target", targetDepth))
              {
                context.Read();
                presetWatermark.Target = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
                {
                    return presetWatermark;
                }
            }
          

            return presetWatermark;
        }

        private static PresetWatermarkUnmarshaller instance;
        public static PresetWatermarkUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new PresetWatermarkUnmarshaller();
            return instance;
        }
    }
}
  
