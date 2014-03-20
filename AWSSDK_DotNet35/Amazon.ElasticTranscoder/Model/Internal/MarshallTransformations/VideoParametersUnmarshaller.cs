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
    using Amazon.ElasticTranscoder.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.ElasticTranscoder.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// VideoParametersUnmarshaller
      /// </summary>
      internal class VideoParametersUnmarshaller : IUnmarshaller<VideoParameters, XmlUnmarshallerContext>, IUnmarshaller<VideoParameters, JsonUnmarshallerContext>
      {
        VideoParameters IUnmarshaller<VideoParameters, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public VideoParameters Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) return null;
            VideoParameters videoParameters = new VideoParameters();
        
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
              
              if (context.TestExpression("Codec", targetDepth))
              {
                videoParameters.Codec = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("CodecOptions", targetDepth))
              {
                
                var unmarshaller =  new DictionaryUnmarshaller<String,String,StringUnmarshaller,StringUnmarshaller>(
                    StringUnmarshaller.GetInstance(),StringUnmarshaller.GetInstance());               
                videoParameters.CodecOptions = unmarshaller.Unmarshall(context);
                
                continue;
              }
  
              if (context.TestExpression("KeyframesMaxDist", targetDepth))
              {
                videoParameters.KeyframesMaxDist = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("FixedGOP", targetDepth))
              {
                videoParameters.FixedGOP = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("BitRate", targetDepth))
              {
                videoParameters.BitRate = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("FrameRate", targetDepth))
              {
                videoParameters.FrameRate = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("MaxFrameRate", targetDepth))
              {
                videoParameters.MaxFrameRate = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Resolution", targetDepth))
              {
                videoParameters.Resolution = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("AspectRatio", targetDepth))
              {
                videoParameters.AspectRatio = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("MaxWidth", targetDepth))
              {
                videoParameters.MaxWidth = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("MaxHeight", targetDepth))
              {
                videoParameters.MaxHeight = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("DisplayAspectRatio", targetDepth))
              {
                videoParameters.DisplayAspectRatio = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("SizingPolicy", targetDepth))
              {
                videoParameters.SizingPolicy = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("PaddingPolicy", targetDepth))
              {
                videoParameters.PaddingPolicy = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Watermarks", targetDepth))
              {
                
                var unmarshaller = new ListUnmarshaller<PresetWatermark,PresetWatermarkUnmarshaller>(
                    PresetWatermarkUnmarshaller.GetInstance());                  
                videoParameters.Watermarks = unmarshaller.Unmarshall(context);
                
                continue;
              }
  
            }
          
            return videoParameters;
        }

        private static VideoParametersUnmarshaller instance;
        public static VideoParametersUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new VideoParametersUnmarshaller();
            return instance;
        }
    }
}
  
