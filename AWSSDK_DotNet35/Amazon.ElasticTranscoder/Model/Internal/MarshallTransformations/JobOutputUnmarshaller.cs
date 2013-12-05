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
            if (context.CurrentTokenType == JsonToken.Null)
                return null;

            JobOutput jobOutput = new JobOutput();

        
        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("Id", targetDepth))
              {
                context.Read();
                jobOutput.Id = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Key", targetDepth))
              {
                context.Read();
                jobOutput.Key = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("ThumbnailPattern", targetDepth))
              {
                context.Read();
                jobOutput.ThumbnailPattern = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Rotate", targetDepth))
              {
                context.Read();
                jobOutput.Rotate = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("PresetId", targetDepth))
              {
                context.Read();
                jobOutput.PresetId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("SegmentDuration", targetDepth))
              {
                context.Read();
                jobOutput.SegmentDuration = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Status", targetDepth))
              {
                context.Read();
                jobOutput.Status = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("StatusDetail", targetDepth))
              {
                context.Read();
                jobOutput.StatusDetail = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Duration", targetDepth))
              {
                context.Read();
                jobOutput.Duration = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Width", targetDepth))
              {
                context.Read();
                jobOutput.Width = IntUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Height", targetDepth))
              {
                context.Read();
                jobOutput.Height = IntUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Watermarks", targetDepth))
              {
                context.Read();
                
                if (context.CurrentTokenType == JsonToken.Null)
                {
                    jobOutput.Watermarks = null;
                    continue;
                }
                  jobOutput.Watermarks = new List<JobWatermark>();
                  JobWatermarkUnmarshaller unmarshaller = JobWatermarkUnmarshaller.GetInstance();
                while (context.Read())
                {
                  JsonToken token = context.CurrentTokenType;                
                  if (token == JsonToken.ArrayStart)
                  {
                    continue;
                  }
                  if (token == JsonToken.ArrayEnd)
                  {
                    break;
                  }
                   jobOutput.Watermarks.Add(unmarshaller.Unmarshall(context));
                }
                continue;
              }
  
              if (context.TestExpression("AlbumArt", targetDepth))
              {
                context.Read();
                jobOutput.AlbumArt = JobAlbumArtUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Composition", targetDepth))
              {
                context.Read();
                
                if (context.CurrentTokenType == JsonToken.Null)
                {
                    jobOutput.Composition = null;
                    continue;
                }
                  jobOutput.Composition = new List<Clip>();
                  ClipUnmarshaller unmarshaller = ClipUnmarshaller.GetInstance();
                while (context.Read())
                {
                  JsonToken token = context.CurrentTokenType;                
                  if (token == JsonToken.ArrayStart)
                  {
                    continue;
                  }
                  if (token == JsonToken.ArrayEnd)
                  {
                    break;
                  }
                   jobOutput.Composition.Add(unmarshaller.Unmarshall(context));
                }
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
                {
                    return jobOutput;
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
  
