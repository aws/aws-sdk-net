/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the elastictranscoder-2012-09-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticTranscoder.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.ElasticTranscoder.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for JobOutput Object
    /// </summary>  
    public class JobOutputUnmarshaller : IJsonUnmarshaller<JobOutput, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public JobOutput Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            JobOutput unmarshalledObject = new JobOutput();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("AlbumArt", targetDepth))
                {
                    var unmarshaller = JobAlbumArtUnmarshaller.Instance;
                    unmarshalledObject.AlbumArt = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AppliedColorSpaceConversion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AppliedColorSpaceConversion = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Captions", targetDepth))
                {
                    var unmarshaller = CaptionsUnmarshaller.Instance;
                    unmarshalledObject.Captions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Composition", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<Clip, ClipUnmarshaller>(ClipUnmarshaller.Instance);
                    unmarshalledObject.Composition = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Duration", targetDepth))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.Duration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DurationMillis", targetDepth))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.DurationMillis = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Encryption", targetDepth))
                {
                    var unmarshaller = EncryptionUnmarshaller.Instance;
                    unmarshalledObject.Encryption = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("FileSize", targetDepth))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.FileSize = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("FrameRate", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FrameRate = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Height", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.Height = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Id", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Id = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Key", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Key = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("PresetId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PresetId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Rotate", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Rotate = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SegmentDuration", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SegmentDuration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("StatusDetail", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StatusDetail = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ThumbnailEncryption", targetDepth))
                {
                    var unmarshaller = EncryptionUnmarshaller.Instance;
                    unmarshalledObject.ThumbnailEncryption = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ThumbnailPattern", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ThumbnailPattern = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Watermarks", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<JobWatermark, JobWatermarkUnmarshaller>(JobWatermarkUnmarshaller.Instance);
                    unmarshalledObject.Watermarks = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Width", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.Width = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static JobOutputUnmarshaller _instance = new JobOutputUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static JobOutputUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}