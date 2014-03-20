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
      /// JobOutputUnmarshaller
      /// </summary>
      internal class JobOutputUnmarshaller : IUnmarshaller<JobOutput, XmlUnmarshallerContext>, IUnmarshaller<JobOutput, JsonUnmarshallerContext>
      {
        JobOutput IUnmarshaller<JobOutput, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public JobOutput Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) return null;
            JobOutput jobOutput = new JobOutput();
        
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
              
              if (context.TestExpression("Id", targetDepth))
              {
                jobOutput.Id = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Key", targetDepth))
              {
                jobOutput.Key = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("ThumbnailPattern", targetDepth))
              {
                jobOutput.ThumbnailPattern = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Rotate", targetDepth))
              {
                jobOutput.Rotate = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("PresetId", targetDepth))
              {
                jobOutput.PresetId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("SegmentDuration", targetDepth))
              {
                jobOutput.SegmentDuration = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Status", targetDepth))
              {
                jobOutput.Status = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("StatusDetail", targetDepth))
              {
                jobOutput.StatusDetail = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Duration", targetDepth))
              {
                jobOutput.Duration = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Width", targetDepth))
              {
                jobOutput.Width = IntUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Height", targetDepth))
              {
                jobOutput.Height = IntUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Watermarks", targetDepth))
              {
                
                var unmarshaller = new ListUnmarshaller<JobWatermark,JobWatermarkUnmarshaller>(
                    JobWatermarkUnmarshaller.GetInstance());                  
                jobOutput.Watermarks = unmarshaller.Unmarshall(context);
                
                continue;
              }
  
              if (context.TestExpression("AlbumArt", targetDepth))
              {
                jobOutput.AlbumArt = JobAlbumArtUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Composition", targetDepth))
              {
                
                var unmarshaller = new ListUnmarshaller<Clip,ClipUnmarshaller>(
                    ClipUnmarshaller.GetInstance());                  
                jobOutput.Composition = unmarshaller.Unmarshall(context);
                
                continue;
              }
  
            }
          
            return jobOutput;
        }

        private static JobOutputUnmarshaller instance;
        public static JobOutputUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new JobOutputUnmarshaller();
            return instance;
        }
    }
}
  
