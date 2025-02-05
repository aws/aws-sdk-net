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
 * Do not modify this file. This file is generated from the ivs-realtime-2020-07-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.IVSRealTime.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.IVSRealTime.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for S3DestinationConfiguration Object
    /// </summary>  
    public class S3DestinationConfigurationUnmarshaller : IJsonUnmarshaller<S3DestinationConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public S3DestinationConfiguration Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            S3DestinationConfiguration unmarshalledObject = new S3DestinationConfiguration();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("encoderConfigurationArns", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.EncoderConfigurationArns = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("recordingConfiguration", targetDepth))
                {
                    var unmarshaller = RecordingConfigurationUnmarshaller.Instance;
                    unmarshalledObject.RecordingConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("storageConfigurationArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StorageConfigurationArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("thumbnailConfigurations", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<CompositionThumbnailConfiguration, CompositionThumbnailConfigurationUnmarshaller>(CompositionThumbnailConfigurationUnmarshaller.Instance);
                    unmarshalledObject.ThumbnailConfigurations = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static S3DestinationConfigurationUnmarshaller _instance = new S3DestinationConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static S3DestinationConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}