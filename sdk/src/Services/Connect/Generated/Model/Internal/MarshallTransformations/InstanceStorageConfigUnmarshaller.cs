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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Connect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.Connect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for InstanceStorageConfig Object
    /// </summary>  
    public class InstanceStorageConfigUnmarshaller : IJsonUnmarshaller<InstanceStorageConfig, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public InstanceStorageConfig Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            InstanceStorageConfig unmarshalledObject = new InstanceStorageConfig();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("AssociationId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AssociationId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("KinesisFirehoseConfig", targetDepth))
                {
                    var unmarshaller = KinesisFirehoseConfigUnmarshaller.Instance;
                    unmarshalledObject.KinesisFirehoseConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("KinesisStreamConfig", targetDepth))
                {
                    var unmarshaller = KinesisStreamConfigUnmarshaller.Instance;
                    unmarshalledObject.KinesisStreamConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("KinesisVideoStreamConfig", targetDepth))
                {
                    var unmarshaller = KinesisVideoStreamConfigUnmarshaller.Instance;
                    unmarshalledObject.KinesisVideoStreamConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("S3Config", targetDepth))
                {
                    var unmarshaller = S3ConfigUnmarshaller.Instance;
                    unmarshalledObject.S3Config = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("StorageType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StorageType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static InstanceStorageConfigUnmarshaller _instance = new InstanceStorageConfigUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InstanceStorageConfigUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}